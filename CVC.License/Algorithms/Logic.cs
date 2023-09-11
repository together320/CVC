using CVC.License.Algorithms.Forms.Common;
using CVC.License.Algorithms.License;
using CVC.License.Algorithms.Transforming;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
namespace CVC.License.Algorithms
{
    public static class Logic
    {
        public static bool isActivationValid = false, isLicenseFileValid = false, IsLicenseActionValid = false, IsLicenseControllerValid = true;
        public static DataTable db;
        public static DataTable db_Whitelist;
        public static bool LType = true;
        public static int LTypeValue = 0;
        public static int LicenseErrorCode = 0;
        public static ErrorManagement errorManagement = new ErrorManagement();
        public static bool LogicImplementation()
        {
            bool response = false;
            try
            {
                HttpContextBase context = new HttpContextWrapper(HttpContext.Current);
                if (context != null)
                {
                    RouteData routeData = RouteTable.Routes.GetRouteData(context);
                    if (routeData.Values.ContainsKey("MS_DirectRouteMatches"))
                    {
                        routeData = ((IEnumerable<RouteData>)routeData.Values["MS_DirectRouteMatches"]).First();
                    }
                    if (routeData != null)
                    {
                        string controllerName = (routeData.Values["controller"] as string != null) ? routeData.Values["controller"] as string : null;
                        string actionName = (routeData.Values["action"] as string != null) ? routeData.Values["action"] as string : null;
                        if (!isActivationValid)
                        {
                            ActivationManagement activationManagement = new ActivationManagement();
                            activationManagement.GetActivationKey();
                            isActivationValid = activationManagement.isActivationValid;
                        }
                        if (CheckForWhitelist(controllerName, actionName))
                        {
                            return true;
                        }
                        //Todo: Validating activation code if true license will be loaded and serviced
                        if (!isActivationValid)
                        {
                            ActivationManagement activationManagement = new ActivationManagement();
                            activationManagement.GetActivationKey();
                            isActivationValid = activationManagement.isActivationValid;
                            //isActivationValid = false;
                            if (!isActivationValid)
                            {
                                return false;
                            }
                        }
                        //Validating activation code if true license will be loaded and serviced -END
                        LicenseModel licenseModel = new LicenseModel();
                        if (!string.IsNullOrWhiteSpace(controllerName))
                        {
                            controllerName = controllerName.Trim();
                            licenseModel.ControllerName = controllerName.ToLower();
                            response = IsLicensed(licenseModel, "Controller");
                            if (response)
                            {
                                IsLicenseControllerValid = true;
                                if (!string.IsNullOrWhiteSpace(actionName))
                                {
                                    actionName = actionName.Trim();
                                    licenseModel.ActionName = actionName.ToLower();
                                    response = IsLicensed(licenseModel, "Action");
                                    if (response)
                                    {
                                        ErrorManagement errorManagement = new ErrorManagement();
                                        errorManagement.ErrorMessage("Licensed Module");
                                        IsLicenseActionValid = true;
                                    }
                                    else
                                    {
                                        ErrorManagement errorManagement = new ErrorManagement();
                                        errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", null);
                                        IsLicenseActionValid = false;
                                    }
                                }
                            }
                            else
                            {
                                ErrorManagement errorManagement = new ErrorManagement();
                                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", null);
                                IsLicenseControllerValid = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return response;
        }
        private static bool CheckForWhitelist(string ControllerName, string ActionName)
        {
            CommonData commonData = new CommonData();
            WhitelistManagement whitelistManagement = new WhitelistManagement();
            bool Flag = false;
            bool Flag_ControllerException = false;

            //Todo: Adding New White List Content
            //List<Whitelist> whitelists = new List<Whitelist>();
            //whitelists.Add(new Whitelist() { Controller = "LicenseValidation", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "LicenseUpload", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "File", Action = null });
            ////  whitelists.Add(new Whitelist() { Controller = "Settings", Action = null });
            ////whitelists.Add(new Whitelist() { Controller = "LicenseUpload", Action = "Index" });
            ////whitelists.Add(new Whitelist() { Controller = "LicenseUpload", Action = "UploadLicenseFile" });
            ////whitelists.Add(new Whitelist() { Controller = "LicenseUpload", Action = "UploadActivationKey" });
            ////whitelists.Add(new Whitelist() { Controller = "LicenseUpload", Action = "GetUID" });
            //whitelists.Add(new Whitelist() { Controller = "Account", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "Common", Action = "GetMessageDetailsById" });
            //whitelists.Add(new Whitelist() { Controller = "Common", Action = "GetMessageDetailsById" });
            //whitelists.Add(new Whitelist() { Controller = "Common", Action = "GetNotification" });

            ////  whitelists.Add(new Whitelist() { Controller = "DashboardCommon", Action = null });
            ////  whitelists.Add(new Whitelist() { Controller = "Dashboard", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "SocketHub", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "CommandPanelController", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "ClsOpcUaClient", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "MachineSummaryController", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "AlarmSummaryController", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "RenderViewFieldsController", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "api/Batch", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "OpcUaClient", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "Common", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "CommonController", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "RenderViewFields", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "Batch", Action = null });
            //whitelists.Add(new Whitelist() { Controller = "PermissionService", Action = null });


            //whitelistManagement.AddWhitelist(whitelists);

            if (!string.IsNullOrWhiteSpace(ControllerName))
            {
                if (string.IsNullOrWhiteSpace(ActionName))
                {
                    ActionName = null;
                }
                if (db_Whitelist == null)
                {
                    db_Whitelist = whitelistManagement.GetWhitelistData();
                }
                if (db_Whitelist != null)
                {
                    if (db_Whitelist.Rows.Count > 0)
                    {
                        DataTable dataTable = db_Whitelist.DefaultView.ToTable(true, "Controller");
                        IEnumerable<DataRow> rows = db_Whitelist.AsEnumerable().Where(r =>
                        r.Field<string>("Controller").ToLower() == ControllerName.ToLower()
                        &&
                        r.Field<string>("Action") == null
                        );
                        if (rows != null)
                        {
                            if (rows.Count() > 0)
                            {
                                Flag = true;
                                Flag_ControllerException = true;
                            }
                        }
                        if (Flag_ControllerException == false)
                        {
                            rows = db_Whitelist.AsEnumerable().Where(r => r.Field<string>("Controller").ToLower() == ControllerName.ToLower() && r.Field<string>("Action").ToLower() == ActionName.ToLower());

                            if (rows != null)
                            {
                                if (rows.Count() > 0)
                                {
                                    Flag = true;
                                }
                            }
                        }
                    }
                }
            }
            return Flag;
        }
        private static bool IsLicensed(LicenseModel model, string Type)
        {
            string controllerName, actionName;
            bool response = true, IsBreak = false;
            try
            {
                controllerName = model.ControllerName.ToLower();
                actionName = (model.ActionName as string != null) ? model.ActionName.ToLower() : null; ;
                if (!(new LicenseValidation().ValidateLicenseType()))
                {
                    LType = false;
                    return false;
                }
                if (db == null)
                {
                    db = GetLicenseData();
                    if (db == null)
                    {
                        isLicenseFileValid = false;
                        return false;
                    }
                    else
                    {
                        isLicenseFileValid = true;
                    }
                }
                else
                {
                    isLicenseFileValid = true;
                }
                //db = ReEvaluateLicenseData(db);
                //Filtering Necessary content for loop
                IEnumerable<DataRow> rows = Logic.db.AsEnumerable()
                   .Where(r => r.Field<string>("Controller").ToLower() == model.ControllerName.ToLower());
                foreach (DataRow item in rows)
                {
                    if (Type == "Controller")
                    {
                        if (controllerName == item["Controller"].ToString().ToLower() && (bool)(item["IsLicensed"]) && !(bool)(item["IsExpiredController"]))
                        {
                            response = true;
                            IsBreak = true;
                        }
                        else if (controllerName == item["Controller"].ToString() && (bool)(item["IsLicensed"]) && (bool)(item["IsExpiredController"]))
                        {
                            response = false;
                            IsBreak = true;
                        }
                    }
                    else if (Type == "Action")
                    {
                        if (controllerName == item["Controller"].ToString().ToLower() && actionName == item["Action"].ToString().ToLower() && (bool)(item["IsLicensed"])
                            && !(bool)(item["IsExpiredAction"]))
                        {
                            foreach (string LicenseName in Enum.GetNames(typeof(LicenseType)))
                            {
                                if (item["LicenseType"].ToString() == LicenseName)
                                {
                                    response = Call(LicenseName, model);
                                    IsBreak = true;
                                    break;
                                }
                            }
                        }
                        else if (controllerName == item["Controller"].ToString().ToLower() && actionName == item["Action"].ToString().ToLower() && (bool)(item["IsLicensed"])
                            && (bool)(item["IsExpiredAction"]))
                        {
                            response = false;
                            IsBreak = true;
                        }
                    }
                    if (IsBreak) break;
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return response;
        }
        private static bool Call(string Licensename, LicenseModel model)
        {
            try
            {
                var factoryLog = Activator.CreateInstance(Type.GetType($"CVC.License.Algorithms.License{Licensename}")) as ILicenseValidation;
                return factoryLog.License(model);
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                return false;
            }
        }
        private static DataTable GetLicenseFileDetails()
        {
            //Check Here
            DataTable dt = null;
            try
            {
                CommonData commonData = new CommonData();
                dt = commonData.getCommonMethodBySPNAME("SP_LICENSE_GET_LATEST_LICENSE_DETAILS");
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dt;
        }
        private static DataTable GetLicenseUpdates()
        {
            //Check Here
            DataTable dt = null;
            try
            {
                CommonData commonData = new CommonData();
                dt = commonData.getCommonMethodBySPNAME("CS_SP_GET_UPDATED_LICENSE_DATA");
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dt;
        }
        public static DataTable GetLicenseData()
        {
            //Check Here
            CommonData common = new CommonData();
            DataTable dt;
            try
            {
                FileContentForLicense licenseValue = new FileContentForLicense();
                licenseValue.key = Properties.Settings.Default.AESKEY;
                LicenseFile licenseFile = new LicenseFile();
                dt = GetLicenseUpdates();
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        var plaintext = common.DecryptToJsonString(dt.Rows[0]["LicenseData"].ToString(), licenseValue.key);
                        db = common.ConvertJsonToDt(plaintext);
                        db = EvaluateLicenseData(db);
                    }
                    else
                    {
                        dt = GetLicenseFileDetails();
                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                licenseFile.FileName = dt.Rows[0]["FILENAME"].ToString();
                                licenseFile.FilePath_Private = Properties.Settings.Default.RSAPrivateFile;
                                licenseFile.FilePath_Public = Properties.Settings.Default.RSAPublicFile;
                                licenseFile.FileSavePath = Path.Combine(dt.Rows[0]["FILEPATH"].ToString());
                                NewLicense newLicense = new NewLicense(licenseFile);
                                licenseFile = newLicense.Read();
                                licenseFile.FileContentLicense = licenseValue;
                                db = EvaluateLicenseData(licenseFile.FileLicenseDt);
                                SaveUpdatedDtToDB(db, licenseValue.key);
                            }
                            else
                            {
                                Console.WriteLine("No license file found");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No license file found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return db;
        }
        internal static void SaveUpdatedDtToDB(DataTable data, string AESKEY)
        {
            try
            {
                var JsonString = ConvertDtToJson(data);
                SetLicenseDatatoDB(EncryptFromJsonString(JsonString, AESKEY));
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
        }
        //private static DataTable EvaluateLicenseData(DataTable dataTable)
        //{
        //    try
        //    {
        //        if (dataTable != null)
        //        {
        //            if (dataTable.Columns.Count > 0)
        //            {
        //                dataTable.Columns[2].ColumnName = "Controller";
        //                dataTable.Columns[4].ColumnName = "Action";
        //                dataTable.Columns.Add("IsLicensed", typeof(bool)).DefaultValue = true;
        //                dataTable.Columns.Add("IsExpiredController", typeof(bool)).DefaultValue = false;
        //                dataTable.Columns.Add("IsExpiredAction", typeof(bool)).DefaultValue = false;
        //                dataTable.Columns.Add("LicenseCurrentValue", typeof(string)).DefaultValue = null;
        //                dataTable.Columns.Add("ControllerValidStartDate", typeof(DateTime));
        //                dataTable.Columns.Add("ControllerValidEndDate", typeof(DateTime));
        //            }
        //            foreach (DataRow item in dataTable.Rows)
        //            {
        //                item["IsLicensed"] = true;
        //                item["IsExpiredController"] = false;
        //                item["IsExpiredAction"] = false;
        //                item["LicenseCurrentValue"] = 0;
        //                //Check for perpectual license
        //                if (item["LicenseType"].ToString() == "Perpectual")
        //                {
        //                }
        //                //check for pack
        //                if (item["LicenseType"].ToString() == "Pack")
        //                {
        //                    int LicenseValue = 0, LicenseCurrentValue = 0;
        //                    LicenseCurrentValue = int.Parse(item["LicenseCurrentValue"].ToString());
        //                    LicenseValue = int.Parse(item["LicenseValue"].ToString());
        //                    if (LicenseCurrentValue != 0)
        //                    {
        //                        LicenseCurrentValue += LicenseValue;
        //                    }
        //                    item["LicenseCurrentValue"] = LicenseCurrentValue;
        //                    if (LicenseCurrentValue <= 0)
        //                    {
        //                        item["IsExpiredAction"] = true;
        //                    }
        //                    else
        //                    {
        //                        item["IsExpiredAction"] = false;
        //                    }

        //                }
        //                //check for subscription
        //                if (item["LicenseType"].ToString() == "TimeBound")
        //                {
        //                    double TotalDays = 0;
        //                    bool isInt = double.TryParse(item["LicenseValue"].ToString(), out double result);
        //                    if (isInt)
        //                    {
        //                        TotalDays = double.Parse(item["LicenseValue"].ToString());
        //                    }
        //                    item["ControllerValidStartDate"] = DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss");
        //                    item["ControllerValidEndDate"] = DateTime.Now.AddDays(TotalDays).Date.AddHours(23).AddMinutes(59).AddSeconds(59).ToString("yyyy-MM-dd HH:mm:ss");
        //                    if (TotalDays <= 0)
        //                    {
        //                        item["IsExpiredAction"] = true;
        //                    }
        //                    else
        //                    {
        //                        item["IsExpiredAction"] = false;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorManagement errorManagement = new ErrorManagement();
        //        errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
        //    }
        //    return dataTable;
        //}
        //private static DataTable ReEvaluateLicenseData(DataTable dataTable)
        //{
        //    try
        //    {
        //        if (dataTable != null)
        //        {
        //            foreach (DataRow item in dataTable.Rows)
        //            {
        //                item["IsLicensed"] = true;
        //                item["IsExpiredController"] = false;
        //                item["IsExpiredAction"] = false;

        //                //Check for perpectual license
        //                if (item["LicenseType"].ToString() == "Perpectual")
        //                {
        //                }
        //                //check for pack
        //                if (item["LicenseType"].ToString() == "Pack")
        //                {
        //                    int LicenseValue = 0, LicenseCurrentValue = 0;
        //                    LicenseCurrentValue = int.Parse(item["LicenseCurrentValue"].ToString());
        //                    LicenseValue = int.Parse(item["LicenseValue"].ToString());
        //                    if (LicenseCurrentValue != 0)
        //                    {
        //                        //LicenseCurrentValue += LicenseValue;
        //                        //item["LicenseCurrentValue"] = LicenseCurrentValue;
        //                        if (LicenseCurrentValue == LicenseValue)
        //                        {
        //                            item["IsExpiredAction"] = true;
        //                        }
        //                    }

        //                }
        //                //check for subscription
        //                if (item["LicenseType"].ToString() == "TimeBound")
        //                {
        //                    double TotalDays = 0;
        //                    bool isInt = double.TryParse(item["LicenseValue"].ToString(), out double result);
        //                    if (isInt)
        //                    {
        //                        TotalDays = double.Parse(item["LicenseValue"].ToString());
        //                    }
        //                    item["ControllerValidStartDate"] = DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss");
        //                    item["ControllerValidEndDate"] = DateTime.Now.AddDays(TotalDays).Date.AddHours(23).AddMinutes(59).AddSeconds(59).ToString("yyyy-MM-dd HH:mm:ss");
        //                    if (TotalDays <= 0)
        //                    {
        //                        item["IsExpiredAction"] = true;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorManagement errorManagement = new ErrorManagement();
        //        errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
        //    }
        //    return dataTable;
        //}
        private static DataTable EvaluateLicenseData(DataTable dataTable)
        {
            try
            {
                if (dataTable != null)
                {
                    try
                    {
                        if (dataTable.Columns.Count > 0)
                        {
                            dataTable.Columns[2].ColumnName = "Controller";
                            dataTable.Columns[4].ColumnName = "Action";
                            dataTable.Columns.Add("IsLicensed", typeof(bool)).DefaultValue = true;
                            dataTable.Columns.Add("IsExpiredController", typeof(bool)).DefaultValue = false;
                            dataTable.Columns.Add("IsExpiredAction", typeof(bool)).DefaultValue = false;
                            dataTable.Columns.Add("LicenseCurrentValue", typeof(string)).DefaultValue = null;
                            dataTable.Columns.Add("ControllerValidStartDate", typeof(DateTime));
                            dataTable.Columns.Add("ControllerValidEndDate", typeof(DateTime));
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorManagement errorManagement = new ErrorManagement();
                        errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                    }
                    dataTable = ReEvaluateLicenseData(dataTable);
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        public static DataTable ReEvaluateLicenseData(DataTable dataTable)
        {
            string controller = null, Action = null;
            try
            {
                if (dataTable != null)
                {
                    foreach (DataRow item in dataTable.Rows)
                    {
                        item["IsLicensed"] = true;
                        item["IsExpiredController"] = false;
                        item["IsExpiredAction"] = false;
                        //item["LicenseCurrentValue"] = 0;

                        item["Controller"] = item["Controller"].ToString().ToLower().Replace("\n", "").Replace("\r", "").Trim();
                        item["Action"] = item["Action"].ToString().ToLower().Replace("\n", "").Replace("\r", "").Trim();
                        //Check for perpectual license
                        if (item["Controller"] != null)
                        {
                            controller = item["Controller"].ToString();
                            if (!string.IsNullOrWhiteSpace(controller))
                            {
                                controller = controller.ToLower().Replace("\n", "").Replace("\r", "");
                            }
                            item["Controller"] = controller;
                        }
                        if (item["Action"] != null)
                        {
                            Action = item["Action"].ToString();
                            if (!string.IsNullOrWhiteSpace(Action))
                            {
                                Action = Action.ToLower().Replace("\n", "").Replace("\r", "");
                            }
                            item["Action"] = Action;
                        }
                        if (item["LicenseType"].ToString() == "Perpectual")
                        {
                            _ = int.TryParse(item["LicenseValue"].ToString(), out int LicenseCurrentValue);
                            item["LicenseCurrentValue"] = LicenseCurrentValue;
                        }
                        //check for pack
                        else if (item["LicenseType"].ToString() == "Pack")
                        {
                            int LicenseValue = 0, LicenseCurrentValue = 0;
                            _ = int.TryParse(item["LicenseCurrentValue"].ToString(), out LicenseCurrentValue);
                            LicenseValue = int.Parse(item["LicenseValue"].ToString());
                            if (LicenseCurrentValue != 0)
                            {
                                if (LicenseCurrentValue >= LicenseValue)
                                {
                                    item["IsExpiredAction"] = true;
                                }
                            }

                            item["LicenseCurrentValue"] = LicenseCurrentValue;

                        }
                        //check for subscription
                        else if (item["LicenseType"].ToString() == "TimeBound")
                        {
                            double TotalDays = 0;
                            bool isInt = double.TryParse(item["LicenseValue"].ToString(), out double result);
                            if (isInt)
                            {
                                TotalDays = double.Parse(item["LicenseValue"].ToString());
                            }
                            _ = DateTime.TryParse(item["ControllerValidStartDate"].ToString(), out DateTime ControllerValidStartDate);
                            _ = DateTime.TryParse(item["ControllerValidEndDate"].ToString(), out DateTime ControllerValidEndDate);
                            if(ControllerValidStartDate == null || ControllerValidEndDate == null)
                            {
                                item["ControllerValidStartDate"] = DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss");
                                item["ControllerValidEndDate"] = DateTime.Now.AddDays(TotalDays).Date.AddHours(23).AddMinutes(59).AddSeconds(59).ToString("yyyy-MM-dd HH:mm:ss");
                            }                          
                            if (TotalDays <= 0)
                            {
                                item["IsExpiredAction"] = true;
                            }
                            item["LicenseCurrentValue"] = TotalDays;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        public static bool PostLicenseAction(string Cntrl, string Act, Forms.Enums.CommonEnums.LicenseAction Action)
        {
            bool Flag = false;
            string ItemController = null, ItemAction = null;
            if(Logic.db == null)
            {
                Logic.GetLicenseData();
            }
            DataTable dataTable = Logic.db.Copy();
            try
            {
                Cntrl = Cntrl.ToLower().Replace("\n", "").Replace("\r", "");
                Act = Act.ToLower().Replace("\n", "").Replace("\r", "");
                if (dataTable != null)
                {
                    if (!(string.IsNullOrWhiteSpace(Cntrl)) && !(string.IsNullOrWhiteSpace(Act)) && !(string.IsNullOrWhiteSpace(Action.ToString())))
                    {
                        foreach (DataRow item in dataTable.Rows)
                        {
                            //var data = item["Controller"].ToString().ToLower().Replace(Environment.NewLine, string.Empty);
                            ItemController = item["Controller"].ToString().ToLower().Replace("\n", "").Replace("\r", "");
                            ItemAction = item["Action"].ToString().ToLower().Replace("\n", "").Replace("\r", "");

                            if (ItemController == Cntrl && ItemAction == Act)
                            {
                                //Check for perpectual license
                                if (item["LicenseType"].ToString().Replace("\n", "").Replace("\r", "") == "Perpectual")
                                {
                                    Flag = true;
                                }
                                //check for pack
                                if (item["LicenseType"].ToString().Replace("\n", "").Replace("\r", "") == "Pack")
                                {
                                    int LicenseValue = 0, LicenseCurrentValue = 0;
                                    bool IsActionExpired = true;
                                    _ = int.TryParse(item["LicenseCurrentValue"].ToString(), out LicenseCurrentValue);
                                    _ = int.TryParse(item["LicenseValue"].ToString(), out LicenseValue);
                                    //LicenseValue = int.Parse(item["LicenseValue"].ToString());
                                    _ = bool.TryParse(item["IsExpiredAction"].ToString(), out IsActionExpired);
                                    if (IsActionExpired != true)
                                    {
                                        if (LicenseCurrentValue <= LicenseValue)
                                        {
                                            if (Action == Forms.Enums.CommonEnums.LicenseAction.Success)
                                            {
                                                LicenseCurrentValue++;
                                                Flag = true;

                                            }
                                            else if (Action == Forms.Enums.CommonEnums.LicenseAction.Failure)
                                            {
                                                LicenseCurrentValue--;
                                                Flag = true;
                                                if (LicenseCurrentValue >= LicenseValue)
                                                {
                                                    item["IsExpiredAction"] = true;
                                                }
                                            }
                                            item["LicenseCurrentValue"] = LicenseCurrentValue;
                                        }
                                    }

                                }
                                //check for subscription
                                if (item["LicenseType"].ToString().Replace("\n", "").Replace("\r", "") == "TimeBound")
                                {

                                    _ = DateTime.TryParse(item["ControllerValidEndDate"].ToString(), out DateTime EndDate);
                                    //_ = DateTime.TryParse(FilteredNewLicenseItems_Item["ControllerValidEndDate"].ToString(), out New_EndDate);
                                    //_ = int.TryParse(FilteredNewLicenseItems_Item["LicenseValue"].ToString(), out NewVal);
                                   int EndDateDiffCount = (EndDate - DateTime.Now).Days;
                                    if (EndDateDiffCount > 0)
                                    {
                                        Flag = true;
                                    }
                                    else
                                    {
                                        item["IsExpiredAction"] = true;
                                    }


                                    //double TotalDays = 0;
                                    //bool isInt = double.TryParse(item["LicenseValue"].ToString(), out double result);
                                    //if (isInt)
                                    //{
                                    //    TotalDays = double.Parse(item["LicenseValue"].ToString());
                                    //}
                                    //item["ControllerValidStartDate"] = DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss");
                                    //item["ControllerValidEndDate"] = DateTime.Now.AddDays(TotalDays).Date.AddHours(23).AddMinutes(59).AddSeconds(59).ToString("yyyy-MM-dd HH:mm:ss");
                                    //if (TotalDays <= 0)
                                    //{
                                    //    item["IsExpiredAction"] = true;
                                    //}
                                    //else
                                    //{
                                    //    Flag = true;
                                    //}
                                }
                            }
                        }
                        Logic.db = dataTable.Copy();
                    }
                }

                if (Flag == true)
                {
                    FileContentForLicense licenseValue = new FileContentForLicense();
                    licenseValue.key = Properties.Settings.Default.AESKEY;
                    SaveUpdatedDtToDB(Logic.db, licenseValue.key);
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Flag;
        }
        private static bool SetLicenseDatatoDB(string encryptedData)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(encryptedData))
                {
                    JObject obj = new JObject();
                    obj["EncryptedData"] = encryptedData;
                    //add object data
                    CommonData commonData = new CommonData();
                    commonData.getCommonMethod(obj, "CS_SP_UPDATED_LICENSE_DATA");
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return false;
        }
        private static string ConvertDtToJson(DataTable data)
        {
            //Check Here
            string JSONresult;
            DataTable dataTable = data;
            try
            {
                if (dataTable != null)
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        JSONresult = JsonConvert.SerializeObject(dataTable);
                    }
                    else
                    {
                        JSONresult = null;
                    }
                }
                else
                {
                    JSONresult = null;
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
                JSONresult = null;
            }
            return JSONresult;
        }
        private static string EncryptFromJsonString(string text, string aeskey)
        {
            //Check Here
            string encryptedText;
            try
            {
                string plainText = text;
                string key = aeskey;
                //DECLARATION
                SecurityController keyManagement = new SecurityController();
                if (plainText != null)
                {
                    if (plainText.Length > 0)
                    {
                        encryptedText = keyManagement.Encrypt(key, plainText);
                    }
                    else
                    {
                        encryptedText = null;
                    }
                }
                else
                {
                    encryptedText = null;
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
                encryptedText = null;
            }
            return encryptedText;
        }
    }
}
