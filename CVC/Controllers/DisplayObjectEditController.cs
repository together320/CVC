using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Hosting;
using System.Web.Mvc;
using CVC.Data.EDMX;
using CVC.ViewModels;
using CVC.Service;
using System.Threading.Tasks;
using CVC.Models;
using CVC.Modules.Common.CommonServices;
using CVC.Modules.Common.Dashboard;
using CVC.Modules.NModuleManagement;
using static CVC.BusinessServices.Common.ClsConstants;

namespace CVC.Controllers
{
  [RoutePrefix("MachineCustomization/DisplayObjectEdit"), Route("{action=index}")]
  public class DisplayObjectEditController : Controller
  {
    // GET: DisplayObjectEdit
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet]
    public async Task<ActionResult> DisplayObjectEdit(int ViewsId)
    {
      DisplayObjectEditModel displayObjectEditModel = new DisplayObjectEditModel();
      displayObjectEditModel.SubDO = new SubDisplayObject();
      displayObjectEditModel.SubDO.SelectedEFs = new List<SelectedEntityFieldForDO>();
      displayObjectEditModel.SubDO.SelectedVFs = new List<SelectedViewField>();
      CVCEntities cvcEntities = new CVCEntities();
      var displayObject = cvcEntities.Views.FirstOrDefault(v => v.ViewsId == ViewsId);
      var machine = cvcEntities.Machines.FirstOrDefault(m => m.MachineId == displayObject.MachineId);
      var machineParameters = cvcEntities.MachineParameters.Where(mf => mf.MachineId == displayObject.MachineId).ToList();
      var viewFields = cvcEntities.ViewFields.Where(vf => vf.ViewsId == ViewsId).ToList();
      displayObjectEditModel.SelectedDisplayObject = new SelectedDisplayObjectData
      {
        ViewsId = ViewsId,
        ViewName = displayObject.ViewName,
        StatusId = displayObject.StatusId,
        DisplayObjectTypeId = displayObject.DisplayObjectTypeId,
        ListDisplayId = displayObject.ListDisplayId,
        FormDisplayId = displayObject.FormDisplayId,
        ButtonDisplayId = displayObject.ButtonDisplayId,
        RealtimeParameterDisplayId = displayObject.RealtimeParameterDisplayId,
        LineChartDisplayId = displayObject.LineChartDisplayId,
        PieDisplayId = displayObject.PieChartDisplayId,
        TreeDisplayId = displayObject.TreeDisplayId,
        AttachmentDisplayId = displayObject.AttachmentDisplayId,
        AlarmDisplayId = displayObject.AlarmDisplayId,
        NotificationDisplayId = displayObject.NotificationDisplayId,
        ContainerDisplayId = displayObject.ContainerDisplayId,
      };
      displayObjectEditModel.SelectedMachine = new SelectedMachieDataForEditDO
      {
        MachineId = machine.MachineId,
        IsRealTime = machine.IsRealTime,
        TableName = machine.TableName,
        MachineName = machine.MachineName
      };

      var sortParameters = machineParameters.OrderBy(p => p.ParameterName).ToList();
      var sortViewFields = viewFields.OrderBy(v => v.ViewFieldName).ToList();
      foreach (var item in sortViewFields)
      {
        SelectedViewField vf = new SelectedViewField()
        {
          MachineParameterId = item.MachineParameterId,
          ViewField = item.ViewField1,
          ViewFieldName = item.ViewFieldName,
          StatusId = item.StatusId,
          MachineParameterName = item.MachineParameter.ParameterName,
          ColumnName = item.MachineParameter.ColumnName
        };
        displayObjectEditModel.SubDO.SelectedVFs.Add(vf);
      }
      foreach (var sp in sortParameters)
      {
        SelectedEntityFieldForDO ef = new SelectedEntityFieldForDO
        {
          MachineParameterId = sp.MachineParameterId,
          ParameterName = sp.ParameterName,
          ColumnName = sp.ColumnName,
          PickListId = sp.PickListId
        };
        displayObjectEditModel.SubDO.SelectedEFs.Add(ef);
      }



      // get the data List of the EF parameterTable by machine's TableName    **** name mark is wrong
      CustomRepository _repo = new CustomRepository();
      if (displayObjectEditModel.SelectedMachine.TableName != null && displayObjectEditModel.SelectedMachine.TableName != "")
      {
        var subTypeData = await _repo.GetAllData(displayObjectEditModel.SelectedMachine.TableName);
        var subColumnData = await _repo.GetAllDataTypes(displayObjectEditModel.SelectedMachine.TableName);
        if (subTypeData.resultCode != 200)
          ModelState.AddModelError("", subTypeData.message);
        else if (subColumnData.resultCode != 200)
          ModelState.AddModelError("", subColumnData.message);

        displayObjectEditModel.SubDO.SubDOTypeData = subTypeData.Data; // ef parameter table's all data
        displayObjectEditModel.SubDO.SubDOTypeColumns = subColumnData.Data; // ef parameter table's ColumnName and DataType
      }
      else
      {
        displayObjectEditModel.SubDO.SubDOTypeData = "[]";
        displayObjectEditModel.SubDO.SubDOTypeColumns = "[]";
      }

      // get the dataList from the sub type table by subtypeid
      SubTypeRowData realSubTypeTable = getTableNameByDisplayObjectType(displayObjectEditModel.SelectedDisplayObject);
      var realsubtypedata = await _repo.GetSomeRowsById(realSubTypeTable.tableName, realSubTypeTable.id.Value, realSubTypeTable.idName);
      if (realsubtypedata.resultCode != 200)
        ModelState.AddModelError("", realsubtypedata.message);

      displayObjectEditModel.SubDO.SubTypeData = realsubtypedata.Data; // real dataList for subtype of displayobject
      displayObjectEditModel.SubDO.SubTypeColors = cvcEntities.DisplayObjectTypeColors.Where(a => a.DisplayObjectTypeId == displayObjectEditModel.SelectedDisplayObject.DisplayObjectTypeId && a.SubTypeId == realSubTypeTable.id.Value).ToList();
      return View(displayObjectEditModel);
    }


    [Route("ListDisplay_PartialView")]
    public ActionResult ListDisplay_PartialView()
    {
      return PartialView("~/Views/DisplayObjectEdit/ListDisplay_PartialView.cshtml");
    }

    private SubTypeRowData getTableNameByDisplayObjectType(SelectedDisplayObjectData data)
    {
      var cont = new SubTypeRowData();
      if (data.ListDisplayId != null && data.ListDisplayId > 0)
        cont = new SubTypeRowData { tableName = "ListDisplay", id = data.ListDisplayId, idName = "ListDisplayId" };
      else if (data.FormDisplayId != null && data.FormDisplayId > 0)
        cont = new SubTypeRowData { tableName = "FormDisplay", id = data.FormDisplayId, idName = "FormDisplayId" };
      else if (data.ButtonDisplayId != null && data.ButtonDisplayId > 0)
        cont = new SubTypeRowData { tableName = "ButtonDisplay", id = data.ButtonDisplayId, idName = "ButtonDisplayId" };
      else if (data.RealtimeParameterDisplayId != null && data.RealtimeParameterDisplayId > 0)
        cont = new SubTypeRowData { tableName = "RealtimeParameterDisplay", id = data.RealtimeParameterDisplayId, idName = "RealtimeParameterDisplayId" };
      else if (data.LineChartDisplayId != null && data.LineChartDisplayId > 0)
        cont = new SubTypeRowData { tableName = "LineChartDisplay", id = data.LineChartDisplayId, idName = "LineChartDisplayId" };
      else if (data.PieDisplayId != null && data.PieDisplayId > 0)
        cont = new SubTypeRowData { tableName = "PieChartDisplay", id = data.PieDisplayId, idName = "PieChartDisplayId" };
      else if (data.TreeDisplayId != null && data.TreeDisplayId > 0)
        cont = new SubTypeRowData { tableName = "TreeDisplay", id = data.TreeDisplayId, idName = "TreeDisplayId" };
      else if (data.AttachmentDisplayId != null && data.AttachmentDisplayId > 0)
        cont = new SubTypeRowData { tableName = "AttachmentDisplay", id = data.AttachmentDisplayId, idName = "AttachmentDisplayId" };
      else if (data.AlarmDisplayId != null && data.AlarmDisplayId > 0)
        cont = new SubTypeRowData { tableName = "AlarmDisplay", id = data.AlarmDisplayId, idName = "AlarmDisplayId" };
      else if (data.NotificationDisplayId != null && data.NotificationDisplayId > 0)
        cont = new SubTypeRowData { tableName = "NotificationDisplay", id = data.NotificationDisplayId, idName = "NotificationDisplayId" };
      else if (data.ContainerDisplayId != null && data.ContainerDisplayId > 0)
        cont = new SubTypeRowData { tableName = "ContainerDisplay", id = data.ContainerDisplayId, idName = "ContainerDisplayId" };
      return cont;
    }

    private struct SubTypeRowData
    {
      public string tableName { get; set; }
      public int? id { get; set; }
      public string idName { get; set; }
    }

    [HttpPost]
    public async Task<JsonResult> GetRealtimeParametersAsync(int MachineId, int ViewsId)
    {
      CommonServices objCommonServices = new CommonServices();
      var Model = new MachineSummaryPageModel() { ViewFieldList = new List<DashBoardField>() };
      Model.ViewFieldList = new List<DashBoardField>();
      Model.ViewFieldList = await new DashboardCommon().GetDashBoardFieldAsyncForDisplayPreview(MachineId, ViewsId); //

      var LabelRoll = new LabelRoll();
      if (objCommonServices.CheckIsLabelRollByMachineId(MachineId) == true)
      {
        Model.IsLabelRoll = true;

        LabelRoll = objCommonServices.GetLabelRollDetails(MachineId);
        if (LabelRoll != null)
        {
          Model.ViewFieldList.Add(new DashBoardField() { ParameterName = "Label Roll", Value = LabelRoll.LabelRollNumber.ToString(), IPCAddress = "NA" });
          System.Web.HttpContext.Current.Cache["LabelRollNumber"] = LabelRoll.LabelRollNumber;
          System.Web.HttpContext.Current.Cache["NumberOfLabels"] = LabelRoll.NumberOfLabels;
          System.Web.HttpContext.Current.Cache["LabelRollId"] = LabelRoll.LabelRollId;
          //  Model.ViewFieldList.Add(new DashBoardField() { ParameterName = "Label On Rolls", Value = LabelRoll.NumberOfLabels.ToString(), IPCAddress = "NA" });
        }
      }

      Model.ViewFieldList = Model.ViewFieldList.Where(a => a.IPCAddress != null).ToList();

      // Model.ViewFieldList = Model.ViewFieldList.Where(a => a.IPCAddress != null).OrderByDescending(a => a.IsMachineSpeed).ToList();
      if (Model.ViewFieldList.Count > 0)
      {
        Model.MachineParameterId = Model.ViewFieldList?.Where(a => a.MachineParameterId > 0)?.FirstOrDefault()?.MachineParameterId ?? 0;
        var machineCommunication = new CVC.BusinessServices.Common.CommonServices().GetMachineCommunicationDetails(Model.MachineParameterId);
        if (machineCommunication != null)
        {
          Model.ProtocolType = machineCommunication.Protocol.ProtocolName;
          Model.IPAddress = machineCommunication.IPAddress;
          Model.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
          Model.PollRateOverride = machineCommunication?.PollRate ?? 100;

          if (Model.ProtocolType.ToUpper() == ProtocolType.MDB.ToUpper())
          {
            Model.MDBPath = machineCommunication.MDBPath;
          }
          else if (Model.ProtocolType.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
          {

            Model.UserName = machineCommunication.UserName;
            Model.Password = machineCommunication.Password;
          }
          else if (Model.ProtocolType.ToUpper() == ProtocolType.SiemensS7Net.ToUpper())
          {
            Model.CpuType = machineCommunication?.PickListValue6?.PickList?.PickListName;
            Model.Rack = machineCommunication.Rack;
            Model.Slot = machineCommunication.Slot;
          }


        }
        Model.MachineId = MachineId;
        System.Web.HttpContext.Current.Cache.Remove("DisplayPreview");
        System.Web.HttpContext.Current.Cache["DisplayPreview"] = Model;
      }
      else
      {
        System.Web.HttpContext.Current.Cache.Remove("DisplayPreview");
      }
      return Json(Model, JsonRequestBehavior.AllowGet);
    }

    [HttpPost]
    public void AddUpdateDOF(List<NViewFieldForm> parameterList)
    {
      NModuleRepository _repo = new NModuleRepository();
      foreach (var parameter in parameterList)
      {
        try
        {
          if (parameter.StatusId == 1)
          {
            if (_repo.AddUpdateViewField(parameter)) { }
          }
          else
          {
            if (_repo.deleteViewField(parameter.ViewField)) { }
          }
        }
        catch (System.Exception ex)
        {
          throw ex;
        }
      }
    }

    [HttpGet]
    public async Task<JsonResult> GetTableData(string tableName)
    {
      CustomRepository _repo = new CustomRepository();
      var subTypeData = await _repo.GetAllData(tableName);

      return Json(subTypeData, JsonRequestBehavior.AllowGet);
    }

    [HttpPost]
    public JsonResult CreateTextFile(string fileName, string content)
    {
      string filePath = HostingEnvironment.MapPath("~/Logs/" + fileName);
      try
      {
        // Create a new text file or overwrite the existing file
        if (System.IO.File.Exists(filePath))
        {
          System.IO.File.AppendAllText(filePath, content + "\n");
        }
        else
        {
          System.IO.File.WriteAllText(filePath, content + "\n");
        }
        return Json(new { success = true, message = "Text file created successfully." });
      }
      catch (System.Exception ex)
      {
        return Json(new { success = false, message = "Error creating text file: " + ex.Message });
      }
    }
  }
}