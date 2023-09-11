using CVC.Data.EDMX;
using CVC.License.Algorithms.Notification;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Exception = System.Exception;

namespace CVC.License.Algorithms.Process
{
    public class LicenseStatus
    {
        ErrorManagement errorManagement = new ErrorManagement();
        private DataTable dt;
        public LicenseStatus()
        {
            if (Logic.db == null)
            {
                Logic.db = null;
                Logic.LogicImplementation();
            }
            else
            {
                if (Logic.db.Rows.Count > 0)
                {
                    dt = Logic.db.Copy();
                }
                else
                {
                    dt = Logic.db.Clone();
                }
            }
        }

        public DataTable GetLicenseExpireSoon()
        {
            bool Flag = false;
            int ThresholdPercentage = 50, CurrentThresholdPercentage = 0, ThresholdDays = 30, CurrentDays = 0;
            if (dt == null)
            {
                return null;
            }
            DataTable dataTable = dt.Clone();
            try
            {


                IEnumerable<DataRow> rows = dt.AsEnumerable()
                   .Where(r => r.Field<bool>("IsLicensed") == true
                          && r.Field<bool>("IsExpiredAction") == false
                          && r.Field<string>("LicenseType") == LicenseType.Pack.ToString()
                          );

                foreach (DataRow row in rows)
                {
                    //Calculate current threshold
                    _ = (int.TryParse(row["LicenseValue"].ToString(), out int requestvalue)) ? requestvalue : 0;
                    _ = (int.TryParse(row["LicenseCurrentValue"].ToString(), out int currentValue)) ? currentValue : 0;

                    if (currentValue > 0)
                    {
                        CurrentThresholdPercentage = (currentValue / requestvalue) * 100;
                        if (CurrentThresholdPercentage <= ThresholdPercentage)
                        {
                            dataTable.ImportRow(row);
                        }
                    }
                    else if (currentValue == 0 && requestvalue > 0)
                    {
                        dataTable.ImportRow(row);
                    }
                }

                rows = dt.AsEnumerable()
                   .Where(r => r.Field<bool>("IsLicensed") == true
                          && r.Field<bool>("IsExpiredAction") == false
                          && r.Field<string>("LicenseType") == LicenseType.TimeBound.ToString()
                          );

                foreach (DataRow row in rows)
                {
                    //Calculate current threshold
                    DateTime oDate = DateTime.Parse(row["ControllerValidEndDate"].ToString());
                    int res = DateTime.Compare(oDate, DateTime.Now);
                    if (res >= 0)
                    {
                        _ = int.TryParse((DateTime.Now - oDate).TotalDays.ToString(), out CurrentDays);
                        if (CurrentDays <= ThresholdDays)
                        {
                            dataTable.ImportRow(row);
                        }
                    }
                }

                if (dataTable != null)
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        Flag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            if (Flag == true)
            {
                return dataTable;
            }
            else
            {
                return null;
            }

        }

        public DataTable GetLicenseStatusbyParam(string ControllerName, string ActionName)
        {
            bool Flag = false;
            if (dt == null)
            {
                return null;
            }
            DataTable dataTable = dt.Clone();
            try
            {

                IEnumerable<DataRow> rows = dt.AsEnumerable()
                    .Where(r => r.Field<string>("Controller") == ControllerName
                            && r.Field<string>("Action") == ActionName
                           );

                if (rows != null)
                {
                    if (rows.Count() > 0)
                    {
                        foreach (DataRow row in rows)
                        {
                            dataTable.ImportRow(row);
                        }
                        Flag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            if (Flag == true)
            {
                return dataTable;
            }
            else
            {
                return null;
            }
        }

        public DataTable GetExpiredLicenses()
        {
            bool Flag = false;
            if (dt == null)
            {
                return null;
            }
            DataTable dataTable = dt.Clone();
            try
            {
                IEnumerable<DataRow> rows = dt.AsEnumerable()
                   .Where(r => r.Field<bool>("IsLicensed") == true
                          && r.Field<bool>("IsExpiredAction") == true);

                if (rows != null)
                {
                    if (rows.Count() > 0)
                    {
                        foreach (DataRow row in rows)
                        {
                            dataTable.ImportRow(row);
                        }
                        Flag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            if (Flag == true)
            {
                return dataTable;
            }
            else
            {
                return null;
            }
        }

        public bool GenerateNotification(BusinessServices.Common.ClsConstants.MessageType MessageCode, string TargetAudiance)
        {
            bool Flag = false;
            try
            {
                LicenseStatus licensestatus = new LicenseStatus();

                ModelNotification notification = new ModelNotification();
                notification.MsgCode = (int)MessageCode;
                notification.TargetAudience = TargetAudiance;

                DataTable dt = new DataTable();
                if (MessageCode == BusinessServices.Common.ClsConstants.MessageType.LicenseExpiredSoon)
                {
                    dt = licensestatus.GetLicenseExpireSoon();
                }
                else if (MessageCode == BusinessServices.Common.ClsConstants.MessageType.LicenseExpired)
                {
                    dt = licensestatus.GetExpiredLicenses();
                }

                licensestatus.AddtoNotification(dt, notification);
                Flag = true;
            }
            catch (System.Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Flag;
        }
        private bool AddtoNotification(DataTable dataTable, ModelNotification Notification)
        {
            bool Flag = false;
            try
            {
                if (dataTable != null)
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        NotificationManagement notificationManagement = new NotificationManagement();
                        Notification = ProcessNotification(dataTable, Notification);
                        if (Notification != null)
                        {
                            notificationManagement.Create(Notification);
                            Flag = true;
                        }


                    }

                }
            }
            catch (System.Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Flag;

        }

        private ModelNotification ProcessNotification(DataTable dt, ModelNotification notification)
        {

            //Get Message from Server

            var messageDetails = new MessageMaster();
            List<CVC.Data.EDMX.MessageMaster> messageMasterCache = (List<CVC.Data.EDMX.MessageMaster>)HttpContext.Current.Cache["MessageMasrerCache"];
            messageDetails = messageMasterCache.Find(m => m.MessageMasterId == notification.MsgCode);
            //ms.CommonServices.AddAuditLog($"{macAddressAfterHypen} Terminal is not registered", "Login", "", "", "", "", null, null, userDetails);


            string ValueContent = null;
            foreach (DataRow Row in dt.Rows)
            {
                ValueContent += $"{Row["Controller"]} - {Row["Action"]},{System.Environment.NewLine}";
            }
            if (!string.IsNullOrWhiteSpace(ValueContent))
            {
                notification.Message = $"{messageDetails.MessageText.Replace("#tag", ValueContent)}";
            }
            else
            {
                notification = null;
            }

            return notification;

        }
    }
}
