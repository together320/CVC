using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace CVC.License.Algorithms
{
    public class LicensePack : ILicenseValidation
    {
        ErrorManagement errorManagement = new ErrorManagement();
        public bool License(LicenseModel model)
        {

            model.RequestValue = "1";
            int result, requestvalue, CurrentValue = 0, LicenseValue = 0;
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
                   .Where(r => (r.Field<string>("Controller")).ToLower() == model.ControllerName.ToLower()
                           && (r.Field<string>("Action")).ToLower() == model.ActionName.ToLower()
                           && r.Field<bool>("IsLicensed") == true
                           && r.Field<bool>("IsExpiredController") == false
                           && r.Field<bool>("IsExpiredAction") == false
                           && (r.Field<string>("LicenseType")).ToLower() == LicenseType.Pack.ToString().ToLower());

                foreach (DataRow item in rows)
                {
                    if (controllerName == item["Controller"].ToString().ToLower()
                        && actionName == item["Action"].ToString().ToLower()
                        && (bool)(item["IsLicensed"])
                        && !(bool)(item["IsExpiredAction"]))
                    {
                        _ = int.TryParse(item["LicenseCurrentValue"].ToString(), out CurrentValue);
                        _ = int.TryParse(item["LicenseValue"].ToString(), out LicenseValue);
                        if ((requestvalue + CurrentValue) <= LicenseValue)
                        {
                            LicenseManagement licenseManagement = new LicenseManagement();
                            licenseManagement.Update(model);
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
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return response;
        }
    }
}