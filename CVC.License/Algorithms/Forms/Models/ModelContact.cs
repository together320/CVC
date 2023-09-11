using System;

namespace CVC.License.Algorithms
{
    public class ModelContact
    {
        public string CustomerID { get; set; }
        public string CompanyID { get; set; }
        public string ContactID { get; set; }
        public string ContactName { get; set; }
        public string ContactMobile { get; set; }
        public string ContactEmail { get; set; }
        public string ContactDesig { get; set; }
        public string ContactDesc { get; set; }
        public bool ContactIsPrimary { get; set; }
        public string Status { get; set; }
        public string DbAction { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

    }


}
