using CVC.ModuleManagement.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVC.Modules.NModuleManagement
{
    public class NModuleManagementViewModel
    {
        public NModuleManagementViewModel()
        {
            //isModule = true;
            ModuleColumnsList = new List<NModuleColumns>();
            ViewsColumnsList = new List<ViewsColumns>();
            ViewFieldColumnsList = new List<ViewFieldColumns>();
            MachineListInfo = new List<MachineInfo>();
            StatusInfoList = new List<StatusInfo>();
            MachineParameterInfo = new List<NMachineParameterInfo>();
            ViewFieldFormInfo = new NViewFieldForm();
        }
        public NModuleForm ModuleFormInfo { get; set; }
        public List<NModuleColumns> ModuleColumnsList { get; set; }
        public NViewsForm ViewsFormInfo { get; set; }
        public List<ViewsColumns> ViewsColumnsList { get; set; }
        public NViewFieldForm ViewFieldFormInfo { get; set; }
        public List<ViewFieldColumns> ViewFieldColumnsList { get; set; }
        public string ErrorMessage { get; set; }
        public bool isModule { get; set; }
        public bool isView { get; set; }
        public bool isViewField { get; set; }
        public string selectedView { get; set; }
        public List<MachineInfo> MachineListInfo { get; set; }
        public List<StatusInfo> StatusInfoList { get; set; }
        public List<NMachineParameterInfo> MachineParameterInfo { get; set; }
    }
}