using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.License.Algorithms.Notification
{
    public class ModelNotification
    {
        public int ID { get; set; }
        public int MsgCode { get; set; }
        public int Type { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public string TargetAudience { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime Expired { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string DbAction { get; set; }
        public ModelNotification()
        {
            Type = 1;
            Status = 1;
            Expired = DateTime.Now.AddDays(10);
        }
    }



}
