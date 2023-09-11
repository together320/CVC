using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CVC.License.Algorithms
{
    public class LicenseManagement
    {

        public void Delete(LicenseModel model)
        {
            throw new NotImplementedException();
        }

        //public bool Update(LicenseModel model)
        //{
        //    IEnumerable<DataRow> rows = Logic.db.AsEnumerable()
        //       .Where(r => r.Field<string>("Controller") == model.ControllerName
        //               && r.Field<string>("Action") == model.ActionName
        //               && r.Field<bool>("IsLicensed") == true
        //               && r.Field<bool>("IsExpiredController") == false
        //               && r.Field<bool>("IsExpiredAction") == false);

        //    foreach (var item in rows)
        //    {
        //        if (item["LicenseType"].ToString() == LicenseType.Pack.ToString())
        //        {
        //            int result, requestvalue, currentValue;
        //            requestvalue = (int.TryParse(model.RequestValue, out result)) ? result : 0;
        //            currentValue = (int.TryParse(item["LicenseCurrentValue"].ToString(), out result)) ? result : 0;
        //            item["LicenseCurrentValue"] = requestvalue + currentValue;
        //            if ((requestvalue - currentValue) <= 0)
        //            {
        //                item["IsExpiredAction"] = true;
        //            }
        //            break;
        //        }
        //    }
        //    Logic.SaveUpdatedDtToDB(Logic.db, Properties.Settings.Default.AESKEY);
        //    return true;
        //}

        public bool Update(LicenseModel model)
        {
            IEnumerable<DataRow> rows = Logic.db.AsEnumerable()
               .Where(r => (r.Field<string>("Controller")).ToLower() == model.ControllerName
                       && (r.Field<string>("Action")).ToLower() == model.ActionName
                       && r.Field<bool>("IsLicensed") == true
                       && r.Field<bool>("IsExpiredController") == false
                       && r.Field<bool>("IsExpiredAction") == false);

            foreach (var item in rows)
            {
                if (item["LicenseType"].ToString().ToLower() == LicenseType.Pack.ToString().ToLower())
                {
                    int result, requestvalue, currentValue;
                    requestvalue = (int.TryParse(model.RequestValue, out result)) ? result : 0;
                    currentValue = (int.TryParse(item["LicenseCurrentValue"].ToString(), out result)) ? result : 0;
                    item["LicenseCurrentValue"] = requestvalue + currentValue;
                    //if ((requestvalue - currentValue) <= 0)
                    //{
                    //    item["IsExpiredAction"] = true;
                    //}
                    break;
                }
            }
            Logic.SaveUpdatedDtToDB(Logic.db, Properties.Settings.Default.AESKEY);
            return true;
        }

        public void Create(LicenseModel model)
        {
            throw new NotImplementedException();
        }
    }
}
