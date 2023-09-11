namespace CVC.License.Algorithms.Models
{
    public class ModelLicenseModule
    {
        public string ModuleID { get; set; }
        public string ModuleName { get; set; }
        public string ActionID { get; set; }
        public string LicenseTypeID { get; set; }
         public string ActionName { get; set; }
        public LicenseType LicenseType{ get; set; }
        public string LicenseValue { get; set; }
        public string Status { get; set; }

    }
}