using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.ViewModels
{
    public class MessageMasterViewModel
    {
        public int Index { get; set; }
        public int MessageMasterId { get; set; }
        public int PickListValueId { get; set; }
        public string MessageText { get; set; }
        public string MessageDescription { get; set; }
        public bool IsActive { get; set; }
        public string MessageType { get; set; }
    }
}
