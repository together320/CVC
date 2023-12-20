using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CVC.Data.EDMX;

namespace CVC.Models
{
  public class DisplayObjectEditModel
  {
    public SelectedMachieDataForEditDO SelectedMachine { get; set; }
    public SelectedDisplayObjectData SelectedDisplayObject { get; set; }
    public SubDisplayObject SubDO { get; set; } // ef parameter data List in some parameter table == this table is found by machine parameter whose name is TableName// current name mark is wrong

  }

  public class SelectedMachieDataForEditDO
  {
    public int? MachineId { get; set; }
    public string MachineName { get; set; }
    public bool? IsRealTime { get; set; }
    public string TableName { get; set; }
  }

  public class SelectedEntityFieldForDO //MachineParameters
  {
    public int MachineParameterId { get; set; }
    public string ParameterName { get; set; }
    public string ColumnName { get; set; }
    public int? PickListId { get; set; }
  }

  public class SelectedViewField // ViewFields
  {
    public int? MachineParameterId { get; set; }
    public int ViewField { get; set; }
    public string ViewFieldName { get; set; }
    public int? StatusId { get; set; }
    public string MachineParameterName { get; set; }
    public string ColumnName { get; set; }
  }

  public class SelectedDisplayObjectData
  {
    public int ViewsId { get; set; }
    public string ViewName { get; set; }
    public int? StatusId { get; set; }
    public int? DisplayObjectTypeId { get; set; }
    public int? ListDisplayId { get; set; }
    public int? FormDisplayId { get; set; }
    public int? ButtonDisplayId { get; set; }
    public int? RealtimeParameterDisplayId { get; set; }
    public int? LineChartDisplayId { get; set; }
    public int? PieDisplayId { get; set; }
    public int? TreeDisplayId { get; set; }
    public int? AttachmentDisplayId { get; set; }
    public int? AlarmDisplayId { get; set; }
    public int? NotificationDisplayId { get; set; }
    public int? ContainerDisplayId { get; set; }
  }

  public class SubDisplayObject
  {
    public string SubDOTypeData { get; set; } // all rows of subdisplayobjecttype of Table of DB
    public string SubDOTypeColumns { get; set; } // ef parameter table's ColumnNames and DataTypes
    public List<DisplayObjectTypeColor> SubTypeColors { get; set; } // this defines the color range for displayobject paramters
    public string SubTypeData { get; set; } // real subtype of displayobject is gotten by subdotype table, which is gotten by viewTable's displayobjecttypeId
    public List<SelectedEntityFieldForDO> SelectedEFs { get; set; }
    public List<SelectedViewField> SelectedVFs { get; set; }
  }
}