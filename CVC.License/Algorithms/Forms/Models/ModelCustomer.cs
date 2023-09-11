using System;
using System.Collections.Generic;

namespace CVC.License.Algorithms
{

    public class ModelCustomer
    {
        public string CustomerID { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerUID { get; set; }
        public string CustomerActivation_Key { get; set; }
        public string CustomerLocation { get; set; }
        public string CustomerAddressType { get; set; }
        public string CustomerContactID { get; set; }
        public string CustomerContactNumber { get; set; }
        public string CustomerLineId { get; set; }
        public string Status { get; set; }
        public string DbAction { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<ModelContact> ContactList { get; set; }
        public List<ModelUIDItem> UIDList { get; set; }
    }


}
