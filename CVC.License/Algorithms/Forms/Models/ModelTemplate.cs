using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CVC.License.Algorithms.Models
{
    public class ModelTemplate
    {
        public int? ID { get; set; }
        public string TemplateName { get; set; }
        public string TemplateDisplaytext { get; set; }
        public string TemplateDescription { get; set; }
        public List<ModelLicenseModule> ModelLicenseModules { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string DbAction { get; set; }
        public string Status { get; set; }
    }
}