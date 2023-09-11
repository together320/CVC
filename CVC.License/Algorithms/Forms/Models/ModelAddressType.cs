using System;

namespace CVC.License.Algorithms
{
    public class ModelAddressType
    {
        public string ID { get; set; } //NEW
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string DbAction { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

   
}