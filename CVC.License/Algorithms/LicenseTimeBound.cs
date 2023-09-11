using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Reflection;

namespace CVC.License.Algorithms
{
    public class LicenseTimeBound : ILicenseValidation
    {
        ErrorManagement errorManagement = new ErrorManagement();

        public bool License(LicenseModel model)
        {
            int result, requestvalue;
            string controllerName, actionName;
            bool response = false, IsBreak = false;
              try
            {
                controllerName = (model.ControllerName as string != null) ? model.ControllerName.ToLower() : null;
                actionName = (model.ActionName as string != null) ? model.ActionName.ToLower() : null;
                requestvalue = (int.TryParse(model.RequestValue, out result)) ? result : 0;

                if (Logic.db == null)
                {
                    Logic.db = Logic.GetLicenseData();
                }

                //Filtering Necessary content for loop

                IEnumerable<DataRow> rows = Logic.db.AsEnumerable()
                   .Where(r => r.Field<string>("Controller").ToLower() == model.ControllerName
                           && r.Field<string>("Action").ToLower() == model.ActionName
                           && r.Field<bool>("IsLicensed") == true
                           && r.Field<bool>("IsExpiredController") == false
                           && r.Field<bool>("IsExpiredAction") == false
                           && r.Field<string>("LicenseType") == LicenseType.TimeBound.ToString());

                foreach (DataRow item in rows)
                {
                    if (controllerName == item["Controller"].ToString().ToLower() && actionName == item["Action"].ToString().ToLower() && (bool)(item["IsLicensed"])
                    && !(bool)(item["IsExpiredAction"]))
                    {
                        DateTime oDate = DateTime.Parse(item["ControllerValidEndDate"].ToString());
                        //DateTime oDate = DateTime.Now;
                        int res = DateTime.Compare(oDate, DateTime.Now);
                        if (res >= 0)
                        {
                            response = true;
                            IsBreak = true;
                        }
                        else
                        {
                            item["IsExpiredAction"] = true;
                        }
                    }
                    if (IsBreak) break;
                }
            }
            catch(Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return response;
        }
    }
}

