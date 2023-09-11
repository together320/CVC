using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVC.MachineCustomization
{
    public class ColumnIdsRequest : ServiceRequest
    {
        public Int32 TableId { get; set; }
    }
}