using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVC.Modules.Batch.Batch
{
    public class BatchReport
    {
        public string PackName { get; set; }

        public string ProductName { get; set; }

        public string BatchStart { get; set; }

        public string BatchEnd { get; set; }

        public string BatchName { get; set; }

        public string CreateBy { get; set; }

        public string Size { get; set; }

        public string Total { get; set; }

        public string Reject { get; set; }

        public string Good { get; set; }

        public string GoodPercentage { get; set; }

        public string RunTime { get; set; }

        public string Rejcam1 { get; set; }

        public string Rejcam2 { get; set; }

        public string Rejmissi { get; set; }

        public string RejectionPer { get; set; }

        public string AverageSpeed { get; set; }

        public string RecipeName { get; set; }

        public string BottleName { get; set; } = "Bottles";

        public string Pack { get; set; } = "Pack Code";

        public string BatchVersion { get; set; }

        public string BatchLatestVersion { get; set; } 

        public string Comments { get; set; } 


    }
}