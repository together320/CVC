// Decompiled with JetBrains decompiler
// Type: CVC.Machine.SettingsPageModel
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data;
using CVC.Data.EDMX;
using System;
using System.Collections.Generic;

namespace CVC.Machine
{
    public class SettingsPageModel
    {
        public IList<ViewField> ViewFieldList { get; set; }

        public MachineRecipe MachineRecipe { get; set; }

        public int OpenOrders { get; set; }

        public int ClosedOrderPercent { get; set; }

        public int CustomerCount { get; set; }

        public int ProductCount { get; set; }

        public int ModuleId { get; set; }

        public List<KeyValuePair<int, string>> Views { get; set; }

        public List<Tuple<string, string, bool, int>> Alarms { get; set; }// changes done By Vinayak ;;; added int thirt tuple

        public List<Tuple<string, string, bool, int,bool?>> AlarmsExist { get; set; }// changes done By Vinayak  on 02.08.2018

        public int LabelRollViewId { get; set; }

        public bool IsModifyLabelRoll { get; set; }
    }
}
