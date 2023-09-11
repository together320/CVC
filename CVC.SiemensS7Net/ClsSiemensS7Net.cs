using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7;
using S7.Net;
using CVC.ViewModels;
using CVC.BusinessServices.Common;
using System.Web;

namespace CVC.SiemensS7Net
{
    public class ClsSiemensS7Net
    {
        readonly CommonServices commonServices = new CommonServices();

        public async Task<string> Read(DashBoardViewModel dashBoardViewModel)
        {
            try
            {
                await Task.Run(async () =>
                {
                    using (var plc = new Plc(GetCpuType(dashBoardViewModel.CpuType), dashBoardViewModel.IPAddress, (int)dashBoardViewModel.TCPIPPort, (short)dashBoardViewModel.Rack, (short)dashBoardViewModel.Slot))
                    {
                        try
                        {
                            plc.Open();
                            if (plc.IsConnected)
                            {
                              //  var result = (string)await ReadValueConversion(plc, dashBoardViewModel.ViewFieldList.FirstOrDefault()?.IPCAddress, dashBoardViewModel.ViewFieldList.FirstOrDefault()?.DataTypeName);

                            }
                        }
                        catch (PlcException ex)
                        {

                        }
                    }

                });
            }
            catch (Exception ex)
            {
                  commonServices.AddExceptionLog(type: ex.GetType().ToString(), isProtected: false, url: "", message: ex.Message);

            }
            return null;
        }
        public async Task Write(DashBoardViewModel dashBoardViewModel)
        {
            await Task.Run(() =>
            {
                using (var plc = new Plc(GetCpuType(dashBoardViewModel.CpuType), dashBoardViewModel.IPAddress, (int)dashBoardViewModel.TCPIPPort, (short)dashBoardViewModel.Rack, (short)dashBoardViewModel.Slot))
                {
                    plc.Open();
                    if(plc.IsConnected)
                    {

                    }
                }

            });
        }

        public  CommandPanelPageModel ReadCommandPanel(CommandPanelPageModel commandPanelPageModel)
        {
            try
            {
                //await Task.Run(async () =>
                //{
                    using (var plc = new Plc(GetCpuType(commandPanelPageModel.CpuType), commandPanelPageModel.IPAddress, (int)commandPanelPageModel.TcpipPort, (short)commandPanelPageModel.Rack, (short)commandPanelPageModel.Slot))
                    {
                        plc.Open();
                        if (plc.IsConnected)
                        {
                            foreach (var item in commandPanelPageModel.ViewFieldList)
                            {
                               // item.Value = (string) ReadValueConversion(plc, item.IPCAddress, item.DataTypeName);
                            }

                        }
                    }

               // });
            }
            catch (PlcException ex)
            {
                commonServices.AddExceptionLog(type: ex.GetType().ToString(), isProtected: false, url: "", message: ex.Message);

            }
            catch (Exception ex)
            {
                commonServices.AddExceptionLog(type: ex.GetType().ToString(), isProtected: false, url: "", message: ex.Message);

            }
            return commandPanelPageModel;
        }

        public MachineSummaryPageModel ReadMachineSummaryPanel(MachineSummaryPageModel machineSummaryPageModel)
        {
            try
            {

                //await Task.Run(async () =>
                //{
                    using (var plc = new Plc(GetCpuType(machineSummaryPageModel.CpuType), machineSummaryPageModel.IPAddress, (int)machineSummaryPageModel.TcpipPort, (short)machineSummaryPageModel.Rack, (short)machineSummaryPageModel.Slot))
                    {
                        plc.Open();
                        if (plc.IsConnected)
                        {
                            foreach (var item in machineSummaryPageModel.ViewFieldList)
                            {

                                if (machineSummaryPageModel.IsLabelRoll && (HttpContext.Current?.Cache["LabelRollNumber"] != null || System.Web.HttpContext.Current.Cache["LabelRollNumber"] != null))
                                {

                                    if (machineSummaryPageModel.ViewFieldList.Any(v => v.IPCAddress == "NA") == true)
                                    {
                                        machineSummaryPageModel.ViewFieldList.Where(v => v.IPCAddress == "NA")
                                            .Select(v =>
                                            {
                                                v.Value = (System.Web.HttpContext.Current.Cache["LabelRollNumber"]).ToString();
                                                return v;
                                            }).ToList();
                                    }
                                    else
                                    {
                                        machineSummaryPageModel.ViewFieldList.Add(
                                            new DashBoardField()
                                            {
                                                ParameterName = "Label Roll",
                                                Value = (System.Web.HttpContext.Current.Cache["LabelRollNumber"]).ToString(),
                                                IPCAddress = "NA"
                                            });
                                    }

                                }


                              //  item.Value = (string)await ReadValueConversion(plc, item.IPCAddress, item.DataTypeName);

                                if (item.OperationTypeIPC > 0)
                                {
                                    item.Value = commonServices.GetParsedValueForOperationType(item.Value, item.OperationTypeName,    item.OperationValueIPC.Value);
                                }


                                if (item.IsLabelRollIPC == true)
                                {
                                    var LabelRemaining = 0;
                                    LabelRemaining = Convert.ToInt32(item.Value);
                                    item.BackgroundColor = LabelRemaining <= 500 ? "red" : LabelRemaining <= 1000 ? "yellow" : "green";
                                }

                                if (item.IsGoodBottles == true)
                                {
                                    var GoodBottles = 0;
                                    var BatchSize = 0;
                                    GoodBottles = Convert.ToInt32(item.Value);
                                    BatchSize = item.BatchSizeIPCAddress != null ? Convert.ToInt32(plc.Read(item.BatchSizeIPCAddress)) : 0;
                                    item.BackgroundColor = GoodBottles == BatchSize ? "green" : "yellow";

                                }

                                if (item.IsRejectBottles == true)
                                {
                                    var TotalBottles = 0;
                                    var GoodBottles = 0;
                                    var RejectBottles = 0;

                                    RejectBottles = Convert.ToInt32(item.Value);
                                    GoodBottles = Convert.ToInt32(machineSummaryPageModel.ViewFieldList.Where(vf => vf.IsGoodBottles == true)?.FirstOrDefault()?.Value ?? "0");
                                    TotalBottles = GoodBottles + RejectBottles;
                                    var RejectBottlesPercentage = Math.Round(((RejectBottles / (TotalBottles + 0.00)) * 100.00), 2);
                                    item.BackgroundColor = RejectBottlesPercentage <= 2 ? "green" : RejectBottlesPercentage <= 4 ? "yellow" : "red";

                                }

                            }

                        }
                    }

                //});
            }
            catch (PlcException ex)
            {
                commonServices.AddExceptionLog(type: ex.GetType().ToString(), isProtected: false, url: "", message: ex.Message);

            }
            catch (Exception ex)
            {
                commonServices.AddExceptionLog(type: ex.GetType().ToString(), isProtected: false, url: "", message: ex.Message);
            }
            return machineSummaryPageModel;
        }

        public RenderViewFieldsPageModel ReadSettingsPanel(RenderViewFieldsPageModel renderViewFieldsPageModel)
        {
            try
            {
               // await Task.Run(async () =>
                //{
                    using (var plc = new Plc(GetCpuType(renderViewFieldsPageModel.CpuType), renderViewFieldsPageModel.IPAddress, (int)renderViewFieldsPageModel.TcpipPort, (short)renderViewFieldsPageModel.Rack, (short)renderViewFieldsPageModel.Slot))
                    {
                        plc.Open();
                        if (plc.IsConnected)
                        {
                            foreach (var item in renderViewFieldsPageModel.ViewFieldList)
                            {
                                try
                                {
                                    var LblReadCall = 0;


                                //LblRead: string TechnicalSettingValue = (string)await plc.ReadAsync(item.IPCAddress);


                                LblRead: string TechnicalSettingValue = "";
                                    //(string)await ReadValueConversion(plc, item.IPCAddress, item.DataTypeName);

                                    if (string.IsNullOrEmpty(TechnicalSettingValue))
                                    {
                                        if (LblReadCall <= 3)
                                        {
                                            LblReadCall = LblReadCall++;
                                            goto LblRead;
                                        }

                                    }

                                    item.Value = TechnicalSettingValue;

                                    if (item.OperationTypeIPC > 0)
                                    {
                                        item.Value = commonServices.GetParsedValueForOperationType(TechnicalSettingValue, item.OperationTypeName, item.OperationValueIPC.Value);
                                    }
                                    else
                                    {
                                        item.Value = TechnicalSettingValue;
                                    }
                                }
                                catch (System.Exception ex)
                                {
                                    //throw new Serenity.Services.ValidationError("Error", ex.Message);
                                    continue;
                                }
                            }


                        }
                    }

               // });
            }
            catch (PlcException ex)
            {
                commonServices.AddExceptionLog(type: ex.GetType().ToString(), isProtected: false, url: "", message: ex.Message);

            }
            catch (Exception ex)
            {
                commonServices.AddExceptionLog(type: ex.GetType().ToString(), isProtected: false, url: "", message: ex.Message);

            }
            return renderViewFieldsPageModel;
        }

        public CpuType GetCpuType(string cpuType)
        {
            CpuType objCpuType = CpuType.S71200;
            switch (cpuType)
            {
                case "Logo0BA8":
                    objCpuType = CpuType.Logo0BA8;
                    break;

                case "S71200":
                    objCpuType = CpuType.S71200;
                    break;

                case "S71500":
                    objCpuType = CpuType.S71500;
                    break;

                case "S7200":
                    objCpuType = CpuType.S7200;
                    break;

                case "S7200Smart":
                    objCpuType = CpuType.S7200Smart;
                    break;

                case "S7300":
                    objCpuType = CpuType.S7300;
                    break;

                case "S7400":
                    objCpuType = CpuType.S7400;
                    break;

            }
            return objCpuType;
        }

        //public object ReadValueConversion(Plc plc, string ipcAddress, string dataType)
        //{
        //    object result = null;
        //    switch (dataType)
        //    {
        //        case "bit":
        //            result = (bool)plc.Read(ipcAddress);
        //            break;

        //        case "byte":
        //            result = (byte)plc.Read(ipcAddress);
        //            break;

        //        case "word":
        //            result = (ushort)plc.Read(ipcAddress);
        //            break;

        //        case "dword":
        //            result = (uint)await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "int":
        //            result = ((ushort)await plc.ReadAsync(ipcAddress)).ConvertToShort();
        //            break;

        //        case "dint":
        //            result = ((uint)await plc.ReadAsync(ipcAddress)).ConvertToInt();
        //            break;

        //        case "real":
        //            result = ((uint)await plc.ReadAsync(ipcAddress)).ConvertToFloat();
        //            break;

        //        case "lreal":
        //            result = ((uint)await plc.ReadAsync(ipcAddress)).ConvertToFloat();
        //            break;

        //        case "string":
        //            result = await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "s7string":
        //            result = await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "s7wstring":
        //            result = await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "time":
        //            result = await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "counter":
        //            result = await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "datetime":
        //            result = await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "datetimelong":
        //            result = await plc.ReadAsync(ipcAddress);
        //            break;
        //    }
        //    return result;
        //}

        //public async Task GetCpuTypeAsync(Plc plc, string ipcAddress, string dataType, object value)
        //{

        //    switch (dataType)
        //    {
        //        case "bit":
        //            await plc.WriteAsync(ipcAddress, value);
        //            break;

        //        case "byte":
        //            await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "word":
        //            result = (ushort)await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "dword":
        //            result = (uint)await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "int":
        //            result = ((ushort)await plc.ReadAsync(ipcAddress)).ConvertToShort();
        //            break;

        //        case "dint":
        //            result = ((uint)await plc.ReadAsync(ipcAddress)).ConvertToInt();
        //            break;

        //        case "real":
        //            result = ((uint)await plc.ReadAsync(ipcAddress)).ConvertToFloat();
        //            break;

        //        case "lreal":
        //            result = ((uint)await plc.ReadAsync(ipcAddress)).ConvertToFloat();
        //            break;

        //        case "string":
        //            result = await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "s7string":
        //            result = await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "s7wstring":
        //            result = await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "time":
        //            result = await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "counter":
        //            result = await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "datetime":
        //            result = await plc.ReadAsync(ipcAddress);
        //            break;

        //        case "datetimelong":
        //            result = await plc.ReadAsync(ipcAddress);
        //            break;
        //    }
        //    return result;
        //}


    }
}
