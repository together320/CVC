// Decompiled with JetBrains decompiler
// Type: CVC.Machine.EquipmentOptionsPageModel
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data;
using CVC.Data.EDMX;
using CVC.Modules.Common.Dashboard;
using System;
using System.Collections.Generic;

namespace CVC.Machine
{
    public class AlarmPageModel
    {
        public List<Tuple<string, string,bool,int>> Alarms { get; set; }// changes done By Vinayak ;;; added int thirt tuple

        public List<string> Messages { get; set; }

        public List<Tuple<string, string, bool, int,bool?>> AlarmsExist { get; set; }// changes done By Vinayak  on 02.08.2018

        public bool IsRefreshMachineSettings { get; set; }

        public List<MisssingLabelAlarmModel> lstMisssingLabelAlarmModels { get; set; }

        public int? TimerForAlarm { get; set; }


    }
    public class MisssingLabelAlarmModel
    {
        public string MissingLabelAlarmName { get; set; }

        public int? MachineParameterId { get; set; }
    }



}
