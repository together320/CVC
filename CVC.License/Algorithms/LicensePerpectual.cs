using System;
using System.Data;
using System.Reflection;

namespace CVC.License.Algorithms
{
    public class LicensePerpectual : ILicenseValidation
    {
        ErrorManagement errorManagement = new ErrorManagement();

        public bool License(LicenseModel licenseModel)
        {
            try
            {
                if (Logic.db == null)
                {
                    Logic.db = Logic.GetLicenseData();
                }
            }catch(Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return true;
        }
    }

}
