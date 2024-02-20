using CVC.Modules.Common.CommonServices;
using CVC.Data.EDMX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using AdvancedHMIDrivers;
using CVC.Data;
using CVC.Modules.Common.MachineDashboard;
using System.Linq.Expressions;
using Serenity;
using CVC.Machine;
using CVC.Machine.Pages;
using CVC.ViewModels;
using CVC.Modules.Common.Dashboard;
using System.Configuration;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using static CVC.BusinessServices.Common.ClsConstants;
using System.Threading.Tasks;
using bs=CVC.BusinessServices.Common;
using System.Data;
using Serenity.Services;
using CVC.Configuration.Entities;
using Serenity.Data;
using CVC.Configuration.Endpoints;
using AutoMapper;
using CVC.License.Algorithms.Notification;

namespace CVC.Controllers
{
    [RoutePrefix("Common")]
    [Route("{action=index}")]
    public class CommonController : Controller
    {
        bs.CommonServices bsnessCommonServices =new bs.CommonServices();
        bs.ClsCacheConfig clsCacheConfig = new bs.ClsCacheConfig();

        // GET: Common
        public ActionResult Index()
        {
            return View();
        }


        #region Read HeartBeat
        public JsonResult GetDateTimeInEnvironmentalVariableFormat()
        {

            CommonServices objCommonServices = new CommonServices();
            var DateFormat = objCommonServices.GetDateFormatFromEnvironmentVariable();
            DateTime dt = DateTime.Now;
            return Json(dt.ToString(DateFormat), JsonRequestBehavior.AllowGet);

        }


        public JsonResult CheckHeartBeat(int ModuleId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var MachineId = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == ModuleId).MachineId.Value;
                var IPCParameter = cvcEntities.IPCParameters.FirstOrDefault(i => i.MachineId == MachineId && i.IsHeartBeat == true);
                if (IPCParameter != null)
                {
                    var result = new { IsHeartBeat = IPCParameter.IsHeartBeat, MachineParameterId = IPCParameter.MachineParameterId, IPCAddress = IPCParameter.IPCAddress };
                    return Json(result, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    var result = new { IsHeartBeat = false };
                    return Json(result, JsonRequestBehavior.AllowGet);
                }

            }

        }

        public JsonResult ReadHeartBeat(int MachineParameterId, string IPCAddress)
        {
            CVCEntities cvcEntities = new CVCEntities();
            try
            {
                //  using (CVCEntities cvcEntities = new CVCEntities())
                using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
                {
                    var machinePara = new MachineParameter();
                    machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == MachineParameterId);

                    var machineCommunication = new MachineCommunication();
                    if (cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().Count > 0)
                    {
                        machineCommunication = cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().First<MachineCommunication>();
                    }

                    if (machineCommunication != null)
                    {
                        modbusTCP.IPAddress = machineCommunication.IPAddress;
                        modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
                        modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;

                        var HeartBeatValue = modbusTCP.Read(IPCAddress);
                        return Json(HeartBeatValue, JsonRequestBehavior.AllowGet);
                    }

                }
            }
            catch (System.Exception ex)
            {

            }
            finally
            {
                cvcEntities.Dispose();
            }

            return null;
        }
        //@MT 05.08.2019- Machine Communication Fail to be displayed as Alarms and Messages
        public JsonResult DisplayComError(int ModuleId, int MachineParameterId, bool IsError)
        {
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == MachineParameterId);
                    if (updateAlarm != null)
                    {
                        updateAlarm.lastvalue = IsError;
                        cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
                        cvcEntities.SaveChanges();
                        return Json(updateAlarm.lastvalue, JsonRequestBehavior.AllowGet);
                    }
                }

            }
            catch (System.Exception ex)
            {

            }

            return Json("OK", JsonRequestBehavior.AllowGet);
        }
        #endregion     

        #region AuditLog
        [HttpPost]
        public JsonResult AddAuditLog(Parameter parameter)
        {
            if(parameter.Action=="Select Recipe"|| parameter.Action=="Save Recipe"|| parameter.Action=="Update Recipe")
            {
                parameter.ViewFieldId = 0;
            }

            var inValidText = "";
            try
            {
                if (parameter.IsAuthentication)
                {

                    //CVC.BusinessServices.Common.CommonServices objCommonServices = new CVC.BusinessServices.Common.CommonServices();
                    using (CVC.BusinessServices.Common.CommonServices objCommonServices = new CVC.BusinessServices.Common.CommonServices())
                    {
                        if (parameter.ViewFieldId == 0)
                        {
                            Tuple<bool, int?> AuthenticateData = objCommonServices.AuthenticateUserByLogin(parameter.UserName, parameter.Password);

                            if (AuthenticateData.Item1 == false)
                            {
                                inValidText = "Invalid Credentials while";
                                return Json("Invalid", JsonRequestBehavior.AllowGet);

                            }
                            else
                            {
                                parameter.AuthenticationId = AuthenticateData.Item2;

                                if (parameter.Action == "Select Recipe" || parameter.Action == "Save Recipe" || parameter.Action == "Update Recipe")
                                {
                                    return Json(parameter.AuthenticationId, JsonRequestBehavior.AllowGet);

                                }

                                #region Sr.No.100 Check user have access for batch section
                                var userDetails = objCommonServices.GetUserDetailsByUserName(parameter.UserName);

                                #region Sr.No.110 Date:17/02/2020
                                if (userDetails.RoleId == (int)BusinessServices.Common.ClsConstants.RoleType.Administrator)
                                {
                                    return Json(parameter.AuthenticationId, JsonRequestBehavior.AllowGet);
                                }
                                #endregion

                                var rolePermissions = objCommonServices.GetRolePermission((int)userDetails.RoleId);

                                if (rolePermissions.Count > 0)
                                {
                                    var checkBtachPermission = rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "Batch:Authentication");
                                    if (checkBtachPermission == null)
                                    {
                                        return Json("Invalid", JsonRequestBehavior.AllowGet);
                                    }

                                    return Json(parameter.AuthenticationId, JsonRequestBehavior.AllowGet);
                                }

                                #endregion

                            }
                        }
                        else
                        {
                            Tuple<bool, int?> AuthenticateData = objCommonServices.AuthenticateUserByViewFieldWise(parameter.ViewFieldId, parameter.UserName, parameter.Password);
                            if (AuthenticateData.Item1 == false)
                            {
                                return Json("Invalid", JsonRequestBehavior.AllowGet);

                            }
                            else
                            {
                                parameter.AuthenticationId = AuthenticateData.Item2;
                                return Json(parameter.AuthenticationId, JsonRequestBehavior.AllowGet);

                            }
                        }
                    }

                }

                //int? BatchId = null;
                //using (CVCEntities cvcEntities = new CVCEntities())
                //{
                //    parameter.MachineId = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == parameter.ModuleId).MachineId.Value;
                //}
                //User objUser = new Data.EDMX.User();

                //objUser.Username = parameter.UserName;
                //objUser.UserId = Convert.ToInt32(Session["CVCUserId"]);

                //CommonServices.AddAuditLog(parameter.Action, "", "", parameter.FieldName, "", "", BatchId, parameter.MachineId, objUser, parameter.PickListValueId, parameter.Comments, parameter.AuthenticationId);
                //objUser = null;
                //return null;
            }
            catch
            {

            }
            finally

            {
                // int? BatchId = null;

                if (parameter.ModuleId != 0)
                {
                    using (CVCEntities cvcEntities = new CVCEntities())
                    {
                        parameter.MachineId = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == parameter.ModuleId).MachineId.Value;
                    }
                }
                else
                {
                    parameter.MachineId = Convert.ToInt32(HttpContext.Cache["ActiveMachineId"]);
                }

                User objUser = new Data.EDMX.User();

                objUser.Username = parameter.UserName;
                var UserDetails = DashboardCommon.GetUserDetailsByUserName(parameter.UserName);
                objUser.UserId = UserDetails?.UserId ?? 0;

                if(parameter.RequestPanel=="Import")
                {
                    var cuurentPageUrl = Request.UrlReferrer.AbsoluteUri;
                    clsCacheConfig.AddItemToCache(bs.ClsCacheConfig.CacheKeys.ImportedFilePreviousPageUrl, cuurentPageUrl);

                    var loggedUserIdCache = bsnessCommonServices.GetCacheData(bs.ClsCacheConfig.CacheKeys.LoggedUserId);
                    objUser.UserId = loggedUserIdCache;
                    bsnessCommonServices.AddToImportLog(parameter.Action, loggedUserIdCache, parameter.Module);
                }

                CommonServices.AddAuditLog($"{inValidText} {parameter.Action}", parameter.Module, "", parameter.FieldName, "", "", parameter.BatchId, parameter.MachineId, objUser, parameter.PickListValueId, parameter.Comments, parameter.AuthenticationId);
                objUser = null;
            }
            return null;

        }

        [HttpPost]
        public void AddToAuditLog(Parameter parameter)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                parameter.MachineId = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == parameter.ModuleId).MachineId.Value;
            }
            User objUser = new Data.EDMX.User();

            objUser.Username = Serenity.Authorization.Username;
            objUser.UserId = Convert.ToInt32(Serenity.Authorization.UserId);

            CommonServices.AddAuditLog(parameter.Action, "", "", parameter.FieldName, "", parameter.Value, parameter.BatchId, parameter.MachineId, objUser, parameter.PickListValueId, parameter.Comments, parameter.AuthenticationId);
            objUser = null;
            parameter = null;
        }
        #endregion

        [HttpPost]

        public JsonResult AddAlarmLog(Parameter parameter)
        {
            AlarmLog log = new AlarmLog();
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var machineId = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == parameter.ModuleId).MachineId.Value;

                    log.AlarmId = parameter.AlarmId;

                    log.MachineId = machineId;
                    log.LoggedUserId = null;
                    log.AlarmDateTime = DateTime.Now;
                    log.BatchId = new CVC.Modules.Common.Dashboard.DashboardCommon().GetCurrentRunningBatch();
                    log.IsAlarmActive = true;
                    cvcEntities.AlarmLogs.Add(log);
                    cvcEntities.SaveChanges();
                }
            }
            catch (System.Exception ex)
            {
                ex = null;
            }
            finally
            {
                log = null;
            }
            return null;
        }


        #region Send HeartBeat
        public JsonResult CheckHeartBeatSend(int ModuleId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var MachineId = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == ModuleId).MachineId.Value;
                var IPCParameter = cvcEntities.IPCParameters.FirstOrDefault(i => i.MachineId == MachineId && i.IsHeartBeatSend == true);
                if (IPCParameter != null)
                {
                    var result = new { IsHeartBeatSend = IPCParameter.IsHeartBeatSend, MachineParameterId = IPCParameter.MachineParameterId, IPCAddress = IPCParameter.IPCAddress, IncrementalNumber = IPCParameter.IncrementalNumber, StartNumber = IPCParameter.StartNumber, EndNumber = IPCParameter.EndNumber };
                    return Json(result, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    var result = new { IsHeartBeat = false };
                    return Json(result, JsonRequestBehavior.AllowGet);
                }

            }

        }

        public JsonResult CheckHeartBeatSendByMachineId(int MachineId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var IPCParameter = cvcEntities.IPCParameters.FirstOrDefault(i => i.MachineId == MachineId && i.IsHeartBeatSend == true);
                if (IPCParameter != null)
                {
                    var result = new { IsHeartBeatSend = IPCParameter.IsHeartBeatSend, MachineParameterId = IPCParameter.MachineParameterId, IPCAddress = IPCParameter.IPCAddress, IncrementalNumber = IPCParameter.IncrementalNumber, StartNumber = IPCParameter.StartNumber, EndNumber = IPCParameter.EndNumber };
                    return Json(result, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    var result = new { IsHeartBeat = false };
                    return Json(result, JsonRequestBehavior.AllowGet);
                }

            }

        }

        public JsonResult SendHeartBeat(int MachineParameterId, int Value, int IncrementalNumber, int EndNumber)
        {
            try
            {
                new ConnectMachine().Write(MachineParameterId, Value.ToString());
                // Value =  Value + IncrementalNumber;
                Value = (EndNumber == 1 ? (Value == 0 ? 1 : 0) : (Value + IncrementalNumber));
                //var result = Value;
                return Json(Value, JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception ex)
            {
                //    Value = Value + IncrementalNumber;
                //    var result = Value;
                //    return Json(result, JsonRequestBehavior.AllowGet);

            }
            return Json("", JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region  HeartBeat Failed Time

        public JsonResult GetHeartBeatFailedTime(int ModuleId)
        {
            CommonServices objCommonServices = new CommonServices();
            int HeartBeatFailedTime = objCommonServices.GetHeartBeatFailedTime(ModuleId);
            var ConvertSecondsToMilliseconds = TimeSpan.FromSeconds(HeartBeatFailedTime).TotalMilliseconds;
            objCommonServices = null;
            return Json(ConvertSecondsToMilliseconds, JsonRequestBehavior.AllowGet);

        }
        #endregion

        #region Sr.No:107 ShutDown PC 
        #region PC ShutDown
        [HttpGet]
        public ActionResult PCShutDown()
        {
            User objUser = new Data.EDMX.User();
            if (Session["CVCUserId"] != null)
            {
                objUser.Username = Serenity.Authorization.Username;
                objUser.UserId = Convert.ToInt32(Session["CVCUserId"]);
            }
            CommonServices.AddAuditLog("PC Was ShutDown ", "", "", "", "", "", null, null, objUser);
            Process.Start("shutdown", "/s /f /t 0");
            return null;
        }
        #endregion
        #region Get Notification
        [HttpGet]
        public ActionResult GetNotification()
        {
            User objUser = new Data.EDMX.User();
            var response = new ResponseViewModel<string>();
            if (Session["CVCUserId"] != null)
            {
                objUser.Username = Serenity.Authorization.Username;
                objUser.UserId = Convert.ToInt32(Session["CVCUserId"]);

                NotificationManagement notificationManagement = new NotificationManagement();
                ModelGetNotification modelGetNotification1 = new ModelGetNotification()
                {
                    DbAction = "getnotification",
                    UserID = objUser.UserId,
                    Type = 1
                };
                List<ModelNotification> notificationsList1 = notificationManagement.GetNotificationbyUser(modelGetNotification1);
                if(notificationsList1!= null)
                {
                    if(notificationsList1.Count > 0)
                    {
                        if(!string.IsNullOrWhiteSpace(notificationsList1[0].Message))
                        {
                            response = new ResponseViewModel<string>
                            {
                                IsStatus = true,
                                StatusMessage = StatusMessage.DataFound,
                                Data = notificationsList1[0].Message
                            };
                            return Json(response, JsonRequestBehavior.AllowGet);
                        }
                    }
                }
            }
            CommonServices.AddAuditLog("Getting Notification", "", "", "", "", "", null, null, objUser);
            return Json(null, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion

        #region Sr.No:103 Date:09/01/2020 Restart PC 
        [HttpGet]
        public ActionResult RestartPC()
        {
            User objUser = new Data.EDMX.User();
            if (Session["CVCUserId"] != null)
            {
                objUser.Username = Serenity.Authorization.Username;
                objUser.UserId = Convert.ToInt32(Session["CVCUserId"]);
            }
            CommonServices.AddAuditLog("PC Was Restarted", "", "", "", "", "", null, null, objUser);
            Process.Start("shutdown", "/r /f /t 0");
            objUser = null;
            return null;
        }
        #endregion


        [HttpGet]
        public JsonResult CheckUserAccess(string userName, string passWord, string type)
        {
            var messageData = new ResponseViewModel<string>();
            var isStatus = true;
            var userDetails = bsnessCommonServices.CheckUserLogin(userName, passWord);
            if (userDetails != null)
            {
                var isModifyPermission = bsnessCommonServices.GetRolePermission((int)userDetails.RoleId, bsnessCommonServices.GetRolePermissionKey(type));
                if (!isModifyPermission)
                {
                    isStatus = false;
                    var messageType = type.ToLower() == "restart pc" ? (int)CVC.BusinessServices.Common.ClsConstants.MessageType.NoAceesToRestartPC : (int)CVC.BusinessServices.Common.ClsConstants.MessageType.NoAceesToShutDownPC;
                    messageData = bsnessCommonServices.GetMessageDetailsById(messageType);
                    CommonServices.AddAuditLog($"{messageData.Data}", type, "", "", "", "", null, null, userDetails);
                }

            }
            else
            {
                isStatus = false;
                messageData = bsnessCommonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.InvalidCredentials);
                CommonServices.AddAuditLog($"{messageData.Data}", type, "", "", "", "", null, null, userDetails);

            }
            return Json(new { isStatus = isStatus, message = messageData.Data }, JsonRequestBehavior.AllowGet);


        }


        public JsonResult AllInOneAjax(int ModuleId)
        {
            CommandPanelPageModel cp = ReadCommandPanel();
            MachineSummaryPageModel msp = ReadMachineSummary();

            return Json(new { cp = cp, msp = msp }, JsonRequestBehavior.AllowGet);
        }

        private CommandPanelPageModel ReadCommandPanel()
        {
            CommandPanelController cpc = new CommandPanelController();
            var CommandPanel = new CommandPanelPageModel();
            CommandPanel = (CommandPanelPageModel)HttpContext.Cache["CommandPanel"];

            if (CommandPanel.ProtocolType.ToUpper() ==ProtocolType.MDB.ToUpper())
            {
                return cpc.CallMDBMachineCommandPanel(CommandPanel);
            }
            else
            {
                return cpc.CallPLCMachineCommandPanel(CommandPanel);
            }

        }

        private MachineSummaryPageModel ReadMachineSummary()
        {
            MachineSummaryController msc = new MachineSummaryController();
            var MachineSummaryPanel = new MachineSummaryPageModel();
            MachineSummaryPanel = (MachineSummaryPageModel)HttpContext.Cache["MachineSummary"];

            if (MachineSummaryPanel.ProtocolType.ToUpper() == ProtocolType.MDB.ToUpper())
            {
                return msc.CallMDBMachineSummaryPanel(MachineSummaryPanel);
            }
            else if (MachineSummaryPanel.ProtocolType.ToUpper().Contains(ProtocolType.Modbus.ToUpper()))
            {
                return msc.CallPLCMachineSummaryPanel(MachineSummaryPanel);
            }
            else if (MachineSummaryPanel.ProtocolType.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
            {
                return null;
            }
            return MachineSummaryPanel;

        }

        public JsonResult GetPickListValue()
        {
            using (CVCEntities cVCEntities = new CVCEntities())
            {
                var pickListValues = cVCEntities.PickListValues.Where(pl => pl.PickListValueId == 11).ToList();
                return Json(pickListValues, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult GetPacksList()
        {
            using (CVCEntities cVCEntities = new CVCEntities())
            {
                var packs = cVCEntities.Packs.Select(p => p.PackName).ToArray();
                return Json(packs, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult AddNewBatch(Data.EDMX.Batch batchModel)
        {
            using (CVCEntities cVCEntities = new CVCEntities())
            {
                var checkBatchExist = cVCEntities.Batches.FirstOrDefault(b => b.BatchName == batchModel.BatchName);
                if (checkBatchExist != null)
                {
                    return Json("Batch Name Already exist", JsonRequestBehavior.AllowGet);
                }

                Data.EDMX.Batch batch = new Data.EDMX.Batch
                {
                    BatchName = batchModel.BatchName,
                    PackId = batchModel.PackId,
                    MachineLineId = batchModel.MachineLineId,
                    BatchStatus = batchModel.BatchStatus,
                    BatchSize = batchModel.BatchSize,
                    BatchFor = batchModel.BatchFor,
                    ExpiryDate = batchModel.ExpiryDate,
                    StatusId = batchModel.StatusId,
                    CreatedBy = batchModel.CreatedBy,
                    CreatedDate = batchModel.CreatedDate
                };
                cVCEntities.Batches.Add(batch);
                cVCEntities.SaveChanges();

            }
            return Json("Batch Record Saved Successfully", JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetRepackedBatch()
        {
            using (CVCEntities cVCEntities = new CVCEntities())
            {
                var repacksBatch = cVCEntities.Batches.Where(b => b.RepackStatus == "Taken for Repack").Select(b => b.BatchName).ToArray();
                return Json(repacksBatch, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult SaveBatchGraph(string base64, int batchId,int width,int height,int xaxis,int yaxis)
        {
            var folderName = BusinessServices.Common.ClsConstants.GraphFolderPath.GraphPath;
            if (!Directory.Exists(Server.MapPath(folderName)))
            {
                Directory.CreateDirectory(Server.MapPath(folderName));
            }

            string[] FilePaths = Directory.GetFiles(Server.MapPath(folderName));
            foreach (string file in FilePaths)
            {
                System.IO.File.Delete(file);
            }


            string filePath = "";

            try
            {
                var imageParts = base64.Split(',').ToList<string>();

                byte[] imageBytes = Convert.FromBase64String(imageParts[1]);


                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                // Convert byte[] to Image
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);

                using (var newImage = new Bitmap(800, 800))
                using (var graphics = Graphics.FromImage(newImage))
                using (var stream = new MemoryStream())
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                   // graphics.DrawImage(image, new Rectangle(0, 0, 800, 800));
                    graphics.DrawImage(image, new Rectangle(xaxis, yaxis, width, height));

                    newImage.Save(stream, ImageFormat.Png);
                    //return File(stream.ToArray(), "image/png");
                    byte[] bytes = stream.ToArray();
                    filePath = System.Web.Hosting.HostingEnvironment.MapPath(folderName + "/" + batchId + ".png");
                    System.IO.File.WriteAllBytes(filePath, bytes);
                    //  filePath = DomainName + "Image/" + FileName + ".png";
                }
            }
            catch (System.Exception ex)
            {
                filePath = "";
            }



            return Json(filePath, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMessageDetailsById1(int messageTypeId)
        {
            try
            {
                using (CVCEntities cVCEntities = new CVCEntities())
                {
                    var messageDetails = cVCEntities.MessageMasters.FirstOrDefault(m => m.MessageMasterId == messageTypeId && m.IsActive == true).MessageText;


                    var response = new ResponseViewModel<string>();
                    if (messageDetails != null)
                    {
                        response = new ResponseViewModel<string>
                        {
                            IsStatus = true,
                            StatusMessage = StatusMessage.DataFound,
                            Data = messageDetails
                        };
                    }
                    return  Json(response, JsonRequestBehavior.AllowGet);
                }
            }
            catch(System.Exception ex)
            {
                return Json("", JsonRequestBehavior.AllowGet);

            }
        }

        public JsonResult GetMessageDetailsById(int messageTypeId)
        {
            try
            {
                using (CVCEntities cVCEntities = new CVCEntities())
                {
                    var response = bsnessCommonServices.GetMessageDetailsById(messageTypeId);
                    return Json(response, JsonRequestBehavior.AllowGet);
                }
            }
            catch (System.Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }

        public void Validata(string entityType, dynamic req)
        {
            var config = new MapperConfiguration(com => com.CreateMap<CityDetail, CityDetailsRow>());
            var mapper = config.CreateMapper();
            var data1 = mapper.Map<MachineCommunicationViewModel>(req);

            IDbConnection connection = null;
            SaveRequest<CityDetailsRow> request = null;
            if (entityType == "city")
            {
                connection = SqlConnections.NewFor<CityDetailsRow>();
                request = req;
            }
            using (connection)
            {
                using (UnitOfWork unitOfWork = new UnitOfWork(connection))
                {
                    var result = new CityDetailsController().Create(unitOfWork, request);
                    var data = result;
                    unitOfWork.Commit();
                }
            }

        }

        public JsonResult GetProtocolTypeByMachineId(int machineId)
        {
            try
            {
                using (CVCEntities cVCEntities = new CVCEntities())
                {
                    var response = bsnessCommonServices.GetProtocolTypeByMachineId(machineId);
                    return Json(response, JsonRequestBehavior.AllowGet);
                }
            }
            catch (System.Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }

        public JsonResult IsFieldExist(string param1, int param2,int param3)
        {
            var result = bsnessCommonServices.IsFieldExist(param1, param2,param3);
            return Json(result,JsonRequestBehavior.AllowGet);

        }

    }
}