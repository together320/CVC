using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.Data.DTO
{
   public class ReportDetails
    {
        public string MachineName { get; set; }

        public string Serial { get; set; }

        public string Model { get; set; }

        public string comname { get; set; }

        public string logo { get; set; }

        public string logotype { get; set; }

        public string address { get; set; }

        public string generatedby { get; set; }

        public string EquipmentId { get; set; }

        public string ReportName { get; set; } = "Alarm Log";
    }
}
