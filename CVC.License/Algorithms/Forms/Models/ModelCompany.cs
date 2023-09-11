using System;
using System.Collections.Generic;

namespace CVC.License.Algorithms
{
    public class ModelCompany
    {
        public int CompanyID { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyAddressType { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyContactID { get; set; } //NEW
        public string ContactName { get; set; }
        public string ContactEmailID { get; set; }
        public string ContactNumber { get; set; }
        public string Status { get; set; }
        public string DbAction { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<ModelCustomer> CustomerList { get; set; }
        public List<ModelContact> ContactList { get; set; }
    }


}
