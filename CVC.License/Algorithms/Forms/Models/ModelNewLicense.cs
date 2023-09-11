using CVC.License.Algorithms.License;
using CVC.License.Algorithms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVC.License.Algorithms.Forms.License_New
{
    public class ModelNewLicense
    {
        public int Id { get; set; }
        public int tbl_template_id { get; set; }
        public List<ModelLicenseModule> ModelLicenseModules { get; set; }
        public string LicenseName { get; set; }
        public string LicenseDescription { get; set; }
        public string LicenseType { get; set; }
        public string UID_ID { get; set; }
        public string UID { get; set; }
        public ModelCompany CustomerDetails { get; set; }
        public string LicenseStartDate { get; set; }
        public string LicenseEndDate { get; set; }
        public LicenseFile LicenseFile { get; set; }
        public string Status { get; set; }
        public string DbAction { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}