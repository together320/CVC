// Decompiled with JetBrains decompiler
// Type: CVC.PLCToHMIController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data;
using CVC.Data.EDMX;
using CVC.PLC;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CVC
{
  public class PLCToHMIController : ApiController
  {
    private PLCToHMI aPLCToHMI = new PLCToHMI();
    private HMIToPLC aHMIToPLC = new HMIToPLC();

    //[HttpPost]
    //[ActionName("Settings")]
    //public HttpResponseMessage GetSettingsFromPLC(Parameter parameter)
    //{
    //  if (!this.ModelState.IsValid)
    //    return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
    //  IList<HMIParameterValue> hmiParameterValueList = (IList<HMIParameterValue>) new List<HMIParameterValue>();
    //  return this.Request.CreateResponse<IList<HMIParameterValue>>(HttpStatusCode.OK, this.aPLCToHMI.GetSectionParameterValue(parameter.MachineId, 1));
    //}

    //[HttpPost]
    //[ActionName("SettingsParameter")]
    //public HttpResponseMessage GetSettingsParameterFromPLC(Parameter parameter)
    //{
    //  if (!this.ModelState.IsValid)
    //    return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
    //  IList<HMIParameterValue> hmiParameterValueList = (IList<HMIParameterValue>) new List<HMIParameterValue>();
    //  return this.Request.CreateResponse<IList<HMIParameterValue>>(HttpStatusCode.OK, this.aPLCToHMI.GetSectionParameterValue(parameter.MachineId, parameter.ViewId));
    //}

    //[HttpPost]
    //[ActionName("MachineSummary")]
    //public HttpResponseMessage GetMachineSummaryFromPLC(Parameter parameter)
    //{
    //  if (!this.ModelState.IsValid)
    //    return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
    //  IList<HMIParameterValue> hmiParameterValueList = (IList<HMIParameterValue>) new List<HMIParameterValue>();
    //  return this.Request.CreateResponse<IList<HMIParameterValue>>(HttpStatusCode.OK, this.aPLCToHMI.GetMachineSummary(parameter.MachineId, parameter.ViewId));
    //}

    //[HttpPost]
    //[ActionName("BatchParameter")]
    //public HttpResponseMessage GetBatchParameterFromPLC(Parameter parameter)
    //{
    //  if (!this.ModelState.IsValid)
    //    return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
    //  IList<HMIParameterValue> hmiParameterValueList = (IList<HMIParameterValue>) new List<HMIParameterValue>();
    //  return this.Request.CreateResponse<IList<HMIParameterValue>>(HttpStatusCode.OK, this.aPLCToHMI.GetBatchParameterValue(parameter.MachineId, 1));
    //}

    [HttpPost]
    [ActionName("MachineStatus")]
    public HttpResponseMessage GetMachineStatus(Parameter parameter)
    {
      if (!this.ModelState.IsValid)
        return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
      return this.Request.CreateResponse<string>(HttpStatusCode.OK, "1"); //this.aPLCToHMI.GetMachineStatus(parameter.MachineId, 1)
        }

    [HttpPost]
    [ActionName("HeaderStatus")]
    public HttpResponseMessage GetHeaderStatus(Parameter parameter)
    {
      if (!this.ModelState.IsValid)
        return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
      return this.Request.CreateResponse<string>(HttpStatusCode.OK, "1");//this.aPLCToHMI.GetHeaderStatus(parameter.MachineId, 1)
        }

    [HttpPost]
    [ActionName("SeparatorStatus")]
    public HttpResponseMessage SeparatorStatus(Parameter parameter)
    {
      if (!this.ModelState.IsValid)
        return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
      return this.Request.CreateResponse<string>(HttpStatusCode.OK, this.aPLCToHMI.GetSeparatorStatus(parameter.MachineId, 1));
    }

    [HttpPost]
    [ActionName("PLCVersion")]
    public HttpResponseMessage GetPLCVersion(Parameter parameter)
    {
      if (!this.ModelState.IsValid)
        return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
      string empty = string.Empty;
      return this.Request.CreateResponse<string>(HttpStatusCode.OK, this.aPLCToHMI.GetPLCVersion(parameter.MachineId, 1));
    }

    [HttpPost]
    [ActionName("MachineOnOff")]
    public HttpResponseMessage MachineOnOff(Parameter parameter)
    {
      if (!this.ModelState.IsValid)
        return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
      string empty = string.Empty;
      return this.Request.CreateResponse<string>(HttpStatusCode.OK, this.aHMIToPLC.OnOffMachine(parameter.MachineId, parameter.OnOrOff));
    }

    [HttpPost]
    [ActionName("HeaderOnOff")]
    public HttpResponseMessage HeaderOnOff(Parameter parameter)
    {
      if (!this.ModelState.IsValid)
        return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
      string empty = string.Empty;
      return this.Request.CreateResponse<string>(HttpStatusCode.OK, this.aHMIToPLC.OnOffHeader(parameter.MachineId, parameter.OnOrOff));
    }

    [HttpPost]
    [ActionName("SeparatorOnOff")]
    public HttpResponseMessage SeparatorOnOff(Parameter parameter)
    {
      if (!this.ModelState.IsValid)
        return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
      string empty = string.Empty;
      return this.Request.CreateResponse<string>(HttpStatusCode.OK, this.aHMIToPLC.OnOffSeparator(parameter.MachineId, parameter.OnOrOff));
    }

    [HttpPost]
    [ActionName("Selfset")]
    public HttpResponseMessage Selfset(Parameter parameter)
    {
      if (!this.ModelState.IsValid)
        return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
      string empty = string.Empty;
      return this.Request.CreateResponse<string>(HttpStatusCode.OK, this.aHMIToPLC.OnOffSelfset(parameter.MachineId, parameter.OnOrOff));
    }

    [HttpPost]
    [ActionName("SelfsetStatus")]
    public HttpResponseMessage SelfsetStatus(Parameter parameter)
    {
      if (!this.ModelState.IsValid)
        return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
      string empty = string.Empty;
      return this.Request.CreateResponse<string>(HttpStatusCode.OK, this.aPLCToHMI.GetSelfsetStatus(parameter.MachineId, 1));
    }

    [HttpPost]
    [ActionName("OnCounterForContinuousRun")]
    public HttpResponseMessage OnCounterForContinuousRun(Parameter parameter)
    {
      if (!this.ModelState.IsValid)
        return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
      string empty = string.Empty;
      return this.Request.CreateResponse<string>(HttpStatusCode.OK, this.aHMIToPLC.OnOffCounter(parameter.MachineId, parameter.OnOrOff));
    }

    //[HttpPost]
    //[ActionName("AlarmDetails")]
    //public HttpResponseMessage AlarmDetails(Parameter parameter)
    //{
    //  if (!this.ModelState.IsValid)
    //    return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
    //  return this.Request.CreateResponse<Alarm>(HttpStatusCode.OK, this.aPLCToHMI.GetAlarmValue(parameter.MachineId));
    //}

    [HttpPost]
    [ActionName("AlarmReset")]
    public HttpResponseMessage AlarmReset(Parameter parameter)
    {
      if (!this.ModelState.IsValid)
        return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
      string empty = string.Empty;
      return this.Request.CreateResponse<string>(HttpStatusCode.OK, this.aHMIToPLC.ResetAlarm(parameter.MachineId, parameter.AlarmId, parameter.OnOrOff));
    }

    //[HttpPost]
    //[ActionName("AlarmOnMachineStart")]
    //public HttpResponseMessage AlarmOnMachineStart(Parameter parameter)
    //{
    //  if (!this.ModelState.IsValid)
    //    return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
    //  IList<Alarm> alarmList = (IList<Alarm>) new List<Alarm>();
    //  return this.Request.CreateResponse<IList<Alarm>>(HttpStatusCode.OK, this.aPLCToHMI.GetAlarmOnMachineStartup(parameter.MachineId));
    //}
  }
}
