using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.ViewModels
{
  
        public class RenderViewFieldsPageModel
        {
            public List<DashBoardField> ViewFieldList { get; set; }

            public int ModuleId { get; set; }

            public int? MachineId { get; set; }

            public int ViewId { get; set; }

            public string ViewName { get; set; }

            public string RecipeId { get; set; }

            public string RecipeName { get; set; }

            public int MachineParameterId { get; set; }

            public bool IsMachineSettings { get; set; }

            public bool IsLabelRoll { get; set; }

            public object Clone()
            {
                return this.MemberwiseClone();
            }

            public string IPAddress { get; set; }

            public ushort TcpipPort { get; set; }

            public int PollRateOverride { get; set; } = 100;

            public string ProtocolType { get; set; }

            public string MDBPath { get; set; }

            public List<int> LstViewId { get; set; }

            public int LabelRollViewId { get; set; }

            public string ViewDisplay { get; set; } = "none";

            public int MachineSettingsViewId { get; set; }

            public bool isWriteTerminalType { get; set; }

            public string PackName { get; set; }

            public bool IsReadSelectRecipe { get; set; }

            public bool IsModifySelectRecipe { get; set; }

            public bool IsReadSaveRecipe { get; set; }

            public bool IsModifySaveRecipe { get; set; }

            public bool IsReadUpdateRecipe { get; set; }

            public bool IsModifyUpdateRecipe { get; set; }

            public string UserName { get; set; }

            public string Password { get; set; }

        public string CpuType { get; set; }

        public short? Rack { get; set; }

        public short? Slot { get; set; }

    }
}
