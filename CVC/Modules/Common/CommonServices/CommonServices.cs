using CVC.Administration.Endpoints;
using CVC.Administration.Entities;
using CVC.BusinessServices.Common;
using CVC.Configuration.Endpoints;
using CVC.Configuration.Entities;
using CVC.Data.EDMX;
using CVC.ExternalApplicationInterface.Endpoints;
using CVC.ExternalApplicationInterface.Entities;
using CVC.License.Algorithms;
using CVC.MachineCustomization.Endpoints;
using CVC.MachineCustomization.Entities;
using CVC.Modules.Common.MachineDashboard;
using CVC.OpcUaClient;
using CVC.PackSettings.Endpoints;
using CVC.PackSettings.Entities;
using CVC.SiemensS7Net;
using CVC.ViewModels;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Caching;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Routing;
using static CVC.BusinessServices.Common.ClsConstants;
using Attribute = CVC.Data.EDMX.Attribute;
using bs = CVC.BusinessServices.Common;
using CVC.SiemensS7Net;
using System.Threading.Tasks;

namespace CVC.Modules.Common.CommonServices
{
    public class CommonServices
    {
        ObjectCache cache = MemoryCache.Default;
        ClsCacheConfig clsCacheConfig = new ClsCacheConfig();
        //  private static CVCEntities cvcEntities;

        int failedRecordCount = 0;
        int succededRecordCount = 0;
        bs.CommonServices commonServices = new bs.CommonServices();

        public CommonServices()
        {
            // cvcEntities = new CVCEntities();
        }

        public int GetProtocolTypeIdID(int? MachineId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {

                var ProtocolTypeId = cvcEntities.MachineCommunications.FirstOrDefault(m => m.MachineId == MachineId)?.ProtocolTypeId ?? 0;
                return ProtocolTypeId;
            }
        }

        public int GetScreenLockTimeOutFromEnvironmentVariable()
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var GetScreenLockTimeOut = cvcEntities.EnvironmentVariables.FirstOrDefault()?.SessionTimeOut ?? 20;
                return GetScreenLockTimeOut;
            }
        }

        public string GetDateFormatFromEnvironmentVariable()
        {
            try
            {

                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var DateFormat = "";
                    var GetDateFormat = cvcEntities.EnvironmentVariables.FirstOrDefault();
                    if (GetDateFormat != null)
                    {
                        if (GetDateFormat.DateFormatTypeID != null && GetDateFormat.HourFormatTypeID != null && GetDateFormat.TimeFormatTypeID != null)
                        {
                            return DateFormat = GetDateFormat.HourFormatType.HourFormatTypeValue == "12hr" ? GetDateFormat.DateFormatType.DateFormatTypeValue + " " + GetDateFormat.TimeFormatType.TimeFormatValue + " tt" : GetDateFormat.DateFormatType.DateFormatTypeValue + " " + GetDateFormat.TimeFormatType.TimeFormatValue.Replace("hh", "HH");
                        }
                    }
                    return "dd-MM-yyyy hh:mm:ss tt";
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException e)
            {
                string rs = "";
                foreach (var eve in e.EntityValidationErrors)
                {
                    rs = string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:", eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    Console.WriteLine(rs);

                    foreach (var ve in eve.ValidationErrors)
                    {
                        rs += "<br />" + string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw new System.Exception(rs);
            }
        }

        public static void AddAuditLog(string Action, string Module, string Page, string FieldName, string OldValue, string NewValue, int? BatchId, int? MachineId, User user = null, int? PickListValueId = null, string Comments = null, int? AuthenticationId = null)
        {
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {

                    AuditLog log = new AuditLog();
                    UserDefinition userDefinition = (UserDefinition)Authorization.UserDefinition;

                    if (user != null)
                    {
                        log.UserId = user.UserId;
                        log.UserName = user.Username;
                    }
                    else if (userDefinition != null)
                    {
                        log.UserId = userDefinition.UserId;
                        log.UserName = userDefinition.Username;
                    }

                    log.Action = Action;

                    log.ChangedOn = DateTime.Now;
                    log.Module = Module;
                    log.Page = Page;
                    log.FieldName = FieldName;
                    log.OldValue = OldValue;
                    log.NewValue = NewValue;
                    log.BatchId = BatchId == 0 ? null : BatchId;
                    log.MachineId = MachineId;
                    log.Comments = Comments;
                    log.PickListValueId = PickListValueId;
                    log.AuthenticationId = AuthenticationId;

                    if (log.UserId == 0)
                    {
                        log.UserId = null;
                    }

                    cvcEntities.AuditLogs.Add(log);
                    cvcEntities.SaveChanges();
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException e)
            {
                string rs = "";
                foreach (var eve in e.EntityValidationErrors)
                {
                    rs = string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:", eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    Console.WriteLine(rs);

                    foreach (var ve in eve.ValidationErrors)
                    {
                        rs += "<br />" + string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw new System.Exception(rs);
            }


        }

        public bool CheckIsLabelRoll(int? ModuleId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                bool IsLabelRoll = false;
                var result = cvcEntities.Views.Where(v => v.ModuleId == ModuleId && v.StatusId == 1 && v.IslabelRoll == true).FirstOrDefault();

                if (result != null)
                {
                    IsLabelRoll = true;
                }
                return IsLabelRoll;
            }
        }

        public bool CheckIsLabelRollByMachineId(int? MachineId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                bool IsLabelRoll = false;
                var result = cvcEntities.Views.Where(v => v.MachineId == MachineId && v.StatusId == 1 && v.IslabelRoll == true).FirstOrDefault();

                if (result != null)
                {
                    IsLabelRoll = true;
                }
                return IsLabelRoll;
            }
        }

        public LabelRoll GetLabelRollDetails(int? MachineId)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var LabelRoll = cvcEntities.LabelRolls.OrderByDescending(a => a.LabelRollId).FirstOrDefault(a => a.MachineId == MachineId && a.IsApplied == true);
                if (LabelRoll != null)
                    return LabelRoll;
            }
            return null;
        }

        public static string GetMachineType(int? MachineId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var GetMDBPath = cvcEntities.MachineCommunications.FirstOrDefault(m => m.MachineId == MachineId)?.MDBPath ?? null;
                string MachineType = string.Empty;
                if (GetMDBPath == null)
                {
                    MachineType = Enum.GetName(typeof(ClsConstants.MachineType), 1);
                }
                else
                {
                    MachineType = Enum.GetName(typeof(ClsConstants.MachineType), 2);
                }
                return MachineType;
            }
        }

        public int GetHeartBeatFailedTime(int ModuleId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var MachineId = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == ModuleId).MachineId.Value;
                var GetHeartBeatFailedTime = cvcEntities.IPCParameters.FirstOrDefault(i => i.MachineId == MachineId && i.IsHeartBeat == true)?.HeartBeatFailedTime ?? 0;
                return GetHeartBeatFailedTime;
            }
        }

        public bool GetAuthorization(string PermissionKey)
        {
            bool isPermissionGranted = false;
            isPermissionGranted = Serenity.Authorization.HasPermission(PermissionKey);
            return isPermissionGranted;

        }

        public async Task WriteValuesToAllMachinesAsync(string filterType, string value, int? machineRecipeId = null)
        {
            var dashBoardViewModel = new DashBoardViewModel();
            //  var getIPCParameterData = new List<DashBoardField>();
            var ipcParameterData = new List<IPCParameter>();

            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var statusId = (int)BusinessServices.Common.ClsConstants.StatusType.Active;

                bool? IsBatchSize = false, IsCounterReset = false, IsBatchStartRequiredIPC = false, IsLabelRollIPC = false, IsWriteToPLC = false;
                var flag = filterType == "IsBatchSize" ? IsBatchSize = true : filterType == "IsCounterReset" ? IsCounterReset = true : filterType == "IsBatchStartRequiredIPC" ? IsBatchStartRequiredIPC = true : filterType == "IsLabelRollIPC" ? IsLabelRollIPC = true : filterType == "IsWriteToPLC" ? IsWriteToPLC = true : false;

                switch (filterType)
                {
                    case "IsBatchSize":
                    case "IsCounterReset":
                    case "IsBatchStartRequiredIPC":
                    case "IsLabelRollIPC":
                    case "IsWriteToPLC":
                        ipcParameterData
                            = cvcEntities.IPCParameters
                            .Where(i => (i.IsBatchSize == IsBatchSize ||
                            ((IsBatchSize == true ? (i.IsBatchSize != null && i.IsBatchSize != false) : i.IsBatchSize == null) || i.IsBatchSize ==
                            IsBatchSize) && i.StatusId == statusId))
                            .Where(i => (i.IsCounterReset == IsCounterReset ||
                            ((IsCounterReset == true ? (i.IsCounterReset != null && i.IsCounterReset != false) : i.IsCounterReset == null) || i.IsCounterReset == IsCounterReset) && i.StatusId == statusId))
                            .Where(i => (i.IsBatchStartRequiredIPC == IsBatchStartRequiredIPC ||
                            ((IsBatchStartRequiredIPC == true ? (i.IsBatchStartRequiredIPC != null && i.IsBatchStartRequiredIPC != false) : i.IsBatchStartRequiredIPC == null) || i.IsBatchStartRequiredIPC == IsBatchStartRequiredIPC) && i.StatusId == statusId))
                             .Where(i => (i.IsLabelRollIPC == IsLabelRollIPC ||
                            ((IsLabelRollIPC == true ? (i.IsLabelRollIPC != null && i.IsLabelRollIPC != false) : i.IsLabelRollIPC == null) || i.IsLabelRollIPC == IsLabelRollIPC) && i.StatusId == statusId))
                           .Where(i => (i.IsWriteToPLC == IsWriteToPLC ||
                            ((IsWriteToPLC == true ? (i.IsWriteToPLC != null && i.IsWriteToPLC != false) : i.IsWriteToPLC == null) || i.IsWriteToPLC ==
                            IsWriteToPLC) && i.StatusId == statusId)).ToList();
                        break;

                        //.Where(i => (i.IsCounterReset == IsCounterReset ||
                        //(i.IsCounterReset == null || i.IsCounterReset == IsCounterReset) && i.StatusId == statusId))
                        //.Where(i => (i.IsBatchStartRequiredIPC == IsBatchStartRequiredIPC || (i.IsBatchStartRequiredIPC == null || i.IsBatchStartRequiredIPC == IsBatchStartRequiredIPC) && i.StatusId == statusId))
                        //.Where(i => (i.IsLabelRollIPC == IsLabelRollIPC || (i.IsLabelRollIPC == null || i.IsLabelRollIPC == IsLabelRollIPC) && i.StatusId == statusId)).ToList();

                        //.Select(i => new DashBoardViewModel()
                        //{
                        //    IPAddress = i.Machine.MachineCommunications.FirstOrDefault().IPAddress,
                        //    TCPIPPort = i.Machine.MachineCommunications.FirstOrDefault().TCPIPPort,
                        //    Rack = i.Machine.MachineCommunications.FirstOrDefault().Rack,
                        //    Slot = i.Machine.MachineCommunications.FirstOrDefault().Slot,
                        //    CpuType = i.Machine.MachineCommunications.FirstOrDefault().PickListValue6.PickList.PickListName,
                        //    ViewFieldList=dashBoardViewModel.ViewFieldList. Select(df => new DashBoardField()
                        //    { MachineParameterId = (int)i.MachineParameterId, DateTypeId = (int)i.MachineParameter.DataTypeId,IPCAddress=i.IPCAddress }).ToList()
                        //}).FirstOrDefault();

                        //case "IsBatchSize":
                        //    getIPCParameterData = cvcEntities.IPCParameters.Where(i => i.IsBatchSize == true && i.StatusId ==statusId ).Select(i => new DashBoardField() { MachineParameterId = (int)i.MachineParameterId, NodeId = i.NodeId, AttributeId = i.AttributeId, DateTypeId = (int)i.MachineParameter.DataTypeId, IsBatchSize = i.IsBatchSize, IsCounterReset = i.IsCounterReset }).ToList();
                        //    break;


                        //case "IsCounterReset":
                        //    dashBoardViewModel
                        //        = cvcEntities.IPCParameters.Where(i => i.IsCounterReset == true && i.StatusId == statusId).Select(i => new DashBoardViewModel()
                        //        {
                        //            IPAddress = i.Machine.MachineCommunications.FirstOrDefault().IPAddress,
                        //            TCPIPPort = i.Machine.MachineCommunications.FirstOrDefault().TCPIPPort,
                        //            Rack = i.Machine.MachineCommunications.FirstOrDefault().Rack,
                        //            Slot = i.Machine.MachineCommunications.FirstOrDefault().Slot,
                        //            CpuType = i.Machine.MachineCommunications.FirstOrDefault().PickListValue6.PickList.PickListName,
                        //            ViewFieldList = new List<DashBoardField>().Select(df => new DashBoardField()
                        //            { MachineParameterId = (int)i.MachineParameterId, NodeId = i.NodeId, AttributeId = i.AttributeId, DateTypeId = (int)i.MachineParameter.DataTypeId, IsBatchSize = i.IsBatchSize, IsCounterReset = i.IsCounterReset }).ToList()
                        //        }).FirstOrDefault();
                        //    break;


                        //case "IsCounterReset":
                        //    getIPCParameterData = cvcEntities.IPCParameters.Where(i => i.IsCounterReset == true && i.StatusId == statusId).Select(i => new DashBoardField() { MachineParameterId = (int)i.MachineParameterId, NodeId = i.NodeId, AttributeId = i.AttributeId, DateTypeId = (int)i.MachineParameter.DataTypeId, IsBatchSize = i.IsBatchSize, IsCounterReset = i.IsCounterReset }).ToList();
                        //    break;

                        //case "IsBatchStartRequiredIPC":
                        //    getIPCParameterData = cvcEntities.IPCParameters.Where(i => i.IsBatchStartRequiredIPC == true && i.StatusId == statusId).Select(i => new DashBoardField() { MachineParameterId = (int)i.MachineParameterId, NodeId = i.NodeId, AttributeId = i.AttributeId, DateTypeId = (int)i.MachineParameter.DataTypeId, IsBatchSize = i.IsBatchSize, IsCounterReset = i.IsCounterReset }).ToList();
                        //    break;

                        //case "IsLabelRollIPC":
                        //    getIPCParameterData = cvcEntities.IPCParameters.Where(i => i.IsLabelRollIPC == true && i.StatusId == statusId).Select(i => new DashBoardField() { MachineParameterId = (int)i.MachineParameterId, NodeId = i.NodeId, AttributeId = i.AttributeId, DateTypeId = (int)i.MachineParameter.DataTypeId, IsBatchSize = i.IsBatchSize, IsCounterReset = i.IsCounterReset }).ToList();
                        //    break;

                        //case "ApplyRecipe":

                        // getIPCParameterData = cvcEntities.MachineRecipeParameters.Where(i => i.MachineRecipeId == machineRecipeId ).Select(i => new DashBoardField() { MachineParameterId = (int)i.MachineParameterId, NodeId = i.NodeId, AttributeId = i.AttributeId, DateTypeId = (int)i.MachineParameter.DataTypeId, IsBatchSize = i.IsBatchSize, IsCounterReset = i.IsCounterReset }).ToList();
                        // break;

                }



                List<OPCUaClientWriteValues> lstOPCUaClientWriteValues = new List<OPCUaClientWriteValues>();
                bs.CommonServices commonServices = new bs.CommonServices();

                if (ipcParameterData != null)
                {

                    foreach (var item in ipcParameterData)
                    {
                        var protocolType = commonServices.GetProtocolType((int)item.MachineParameterId);
                        if (protocolType.Contains(ProtocolType.Modbus.ToUpper()) || protocolType == ProtocolType.MDB.ToUpper())
                        {
                            new ConnectMachine().WriteToAllMachine((int)item.MachineParameterId, value, protocolType);
                        }
                        else if (protocolType == ProtocolType.OPCUaClient.ToUpper())
                        {

                            OPCUaClientWriteValues batchSizeWriteValues = new OPCUaClientWriteValues
                            {
                                NodeId = item.NodeId,
                                AttributeId = Convert.ToUInt32(item.AttributeId),
                                Value = value
                            };
                            lstOPCUaClientWriteValues.Add(batchSizeWriteValues);

                        }

                        else if (protocolType == ProtocolType.SiemensS7Net.ToUpper())
                        {
                            var machineCommunication = item?.Machine?.MachineCommunications?.FirstOrDefault();
                            DashBoardViewModel objDashBoardViewModel = commonServices.GetDashBoardViewModel(machineCommunication);
                            ClsSiemensS7Net clsSiemensS7Net = new ClsSiemensS7Net();

                            DashBoardField dashBoardField = new DashBoardField
                            {
                                IPCAddress = item.IPCAddress,
                                Value = value,
                                DataTypeName=item?.MachineParameter?.DataType?.DataTypeName
                            };
                            List<DashBoardField> lstDashBoardFields = new List<DashBoardField>();
                            lstDashBoardFields.Add(dashBoardField);
                            objDashBoardViewModel.ViewFieldList = lstDashBoardFields;
                            await clsSiemensS7Net.Write(objDashBoardViewModel);
                        }
                    }
                    if (lstOPCUaClientWriteValues.Count() > 0)
                    {
                        ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
                        var opcUaClientViewModel = new OPCUaClientViewModel();
                        opcUaClientViewModel.lstWriteValues = lstOPCUaClientWriteValues;

                        clsOpcUaClient.WriteValueCollection(opcUaClientViewModel);

                    }
                    //  commonServices.WriteValueCollectionForOPCUaClient(lstOPCUaClientWriteValues);
                }
            }

        }

        //public void IsWriteToPLC(int machineId, String value)
        //{
        //    using (CVCEntities cvcEntities = new CVCEntities())
        //    {
        //        var isWriteToPLCData = cvcEntities.IPCParameters.Where(i => i.MachineId == machineId && i.IsWriteToPLC == true)?.ToList();

        //        if (isWriteToPLCData != null)
        //        {
        //            foreach (var items in isWriteToPLCData)
        //            {
        //                new CVC.PLC.Operations().Write(items.MachineParameterId.Value, value);
        //            }
        //        }
        //    }


        //}


        //public Node GetNodeDetails(string nodeId)
        //{
        //    ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
        //    return clsOpcUaClient.GetNodeDetails(nodeId);

        //}

        public void Validata(object cty, dynamic req)
        {
            dynamic usobj = null;
            IDbConnection connection = null;
            SaveRequest<CityDetailsRow> request = null;
            if (cty == "city")
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

        public Tuple<int, int> ImportData()
        {
            var formName = clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileFormName);
            if (formName != null)
            {
                formName = (string)formName;
            }

            var dt = new DataTable();

            var importedFileDataAfterColumnFieldMapping = clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileDataAfterColumnFieldMapping);
            if (importedFileDataAfterColumnFieldMapping != null)
            {
                dt = (DataTable)importedFileDataAfterColumnFieldMapping;
            }

            return CallImportData(formName.ToString(), dt);
        }

        public Tuple<int, int> ImportCityData(DataTable dt, string formType)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                try
                {
                    CityDetailsRow cityDetails = new CityDetailsRow();
                    cityDetails.Country = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CityFormField), 1)]);
                    cityDetails.State = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CityFormField), 2)]);
                    cityDetails.City = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CityFormField), 3)]);
                    cityDetails.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CityFormField), 4)]);

                    if (string.IsNullOrWhiteSpace(cityDetails.Country) || string.IsNullOrWhiteSpace(cityDetails.State) || string.IsNullOrWhiteSpace(cityDetails.City) || string.IsNullOrWhiteSpace(cityDetails.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Country, State, City, Status"));
                        continue;
                    }
                    var statusData = (Status)commonServices.GetTableDataByName("status", cityDetails.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    cityDetails.StatusId = statusData.StatusId;

                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {
                        SaveData(formType, cityDetails);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }


                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }

            }


            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportRoleData(DataTable dt, string formType)
        {
            var parentRoleExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.RoleFormField), 2)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {

                    RoleRow role = new RoleRow();

                    role.RoleName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.RoleFormField), 1)]);
                    role.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.RoleFormField), 3)]);

                    if (string.IsNullOrWhiteSpace(role.RoleName) || string.IsNullOrWhiteSpace(role.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Role, Status"));

                        continue;
                    }
                    if (parentRoleExist)
                    {
                        role.RolesRoleName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.RoleFormField), 2)]);

                        var parentRoleData = (Role)commonServices.GetTableDataByName("role", role.RolesRoleName);
                        if (parentRoleData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Parent Role"));

                            continue;
                        }
                        role.ParentRoleId = parentRoleData.RoleId;
                    }

                    var statusData = (Status)commonServices.GetTableDataByName("status", role.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));

                        continue;
                    }
                    role.StatusId = statusData.StatusId;
                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {

                        SaveData(formType, role);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }




                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportDepartmentData(DataTable dt, string formType)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    DepartmentRow department = new DepartmentRow();

                    department.DepartmentCode = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DepartmentFormField), 1)]);
                    department.DepartmentName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DepartmentFormField), 2)]);
                    department.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DepartmentFormField), 3)]);

                    if (string.IsNullOrWhiteSpace(department.DepartmentCode) || string.IsNullOrWhiteSpace(department.DepartmentName) || string.IsNullOrWhiteSpace(department.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Department Code, Department Name, Status"));
                        continue;
                    }

                    var statusData = (Status)commonServices.GetTableDataByName("status", department.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    department.StatusId = statusData.StatusId;


                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {
                        SaveData(formType, department);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }

                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }
            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportProtocolData(DataTable dt, string formType)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    ProtocolRow protocol = new ProtocolRow();
                    protocol.ProtocolName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.ProtocolFormField), 1)]);
                    protocol.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.ProtocolFormField), 2)]);

                    if (string.IsNullOrWhiteSpace(protocol.ProtocolName) || string.IsNullOrWhiteSpace(protocol.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Protocol, Status"));
                        continue;
                    }

                    var statusData = (Status)commonServices.GetTableDataByName("status", protocol.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    protocol.StatusId = statusData.StatusId;

                    if (Logic.PostLicenseAction("Protocol", "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {

                        SaveData("protocol", protocol);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }



                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportPickListValueData(DataTable dt, string formType)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    PickListValueRow pickListValue = new PickListValueRow();

                    pickListValue.PickListName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PickListValueFormField), 1)]);
                    pickListValue.PickListValueName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PickListValueFormField), 2)]);
                    pickListValue.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PickListValueFormField), 3)]);

                    if (string.IsNullOrWhiteSpace(pickListValue.PickListName) || string.IsNullOrWhiteSpace(pickListValue.PickListValueName) || string.IsNullOrWhiteSpace(pickListValue.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "PickList, PickList Value Name, Status"));

                        continue;
                    }
                    var pickListData = (PickList)commonServices.GetTableDataByName("pickList", pickListValue.PickListName);

                    if (pickListData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "PickList"));
                        continue;
                    }
                    pickListValue.PickListId = pickListData.PickListId;


                    var statusData = (Status)commonServices.GetTableDataByName("status", pickListValue.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }

                    pickListValue.StatusId = statusData.StatusId;


                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {
                        SaveData(formType, pickListValue);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }


                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);

        }

        public Tuple<int, int> ImportSupplierData(DataTable dt, string formType)
        {
            var pinCodeExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.SupplierFormField), 4)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    SupplierRow supplierRow = new SupplierRow();
                    supplierRow.SupplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.SupplierFormField), 1)]);
                    supplierRow.SupplierAddress = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.SupplierFormField), 2)]);
                    supplierRow.City = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.SupplierFormField), 3)]);
                    var mobileCode = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.SupplierFormField), 5)]);
                    var mobileNumber = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.SupplierFormField), 6)]);
                    supplierRow.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.SupplierFormField), 7)]);

                    if (string.IsNullOrWhiteSpace(supplierRow.SupplierName) || string.IsNullOrWhiteSpace(supplierRow.SupplierAddress) || string.IsNullOrWhiteSpace(supplierRow.City) || string.IsNullOrWhiteSpace(mobileCode) || string.IsNullOrWhiteSpace(mobileNumber) || string.IsNullOrWhiteSpace(supplierRow.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Supplier Name, Supplier Address, City, Mobile Code, Mobile Number, Status"));
                        continue;
                    }

                    var statusData = (Status)commonServices.GetTableDataByName("status", supplierRow.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    supplierRow.StatusId = statusData.StatusId;

                    if (pinCodeExist)
                    {
                        supplierRow.PinCode = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.SupplierFormField), 4)]);

                    }
                    supplierRow.MobileCode = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.SupplierFormField), 5)]));
                    supplierRow.MobileNumber = GetInt64NumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.SupplierFormField), 6)]));


                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {

                        SaveData(formType, supplierRow);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }
                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportShiftData(DataTable dt, string formType)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    ShiftRow shiftRow = new ShiftRow();

                    shiftRow.ShiftName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.ShiftFormField), 1)]);
                    shiftRow.StartTime = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.ShiftFormField), 2)]);
                    shiftRow.EndTime = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.ShiftFormField), 3)]);
                    shiftRow.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.ShiftFormField), 4)]);

                    if (string.IsNullOrWhiteSpace(shiftRow.ShiftName) || string.IsNullOrWhiteSpace(shiftRow.StartTime) || string.IsNullOrWhiteSpace(shiftRow.EndTime) || string.IsNullOrWhiteSpace(shiftRow.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Shift Name, Start Time, End Time, Status"));
                        continue;
                    }

                    var statusData = (Status)commonServices.GetTableDataByName("status", shiftRow.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    shiftRow.StatusId = statusData.StatusId;

                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {

                        SaveData(formType, shiftRow);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }


                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportAlarmData(DataTable dt, string formType)
        {

            var descriptionExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 5)));
            var isResetRequiredExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 6)));
            var isCommentRequiredExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 7)));
            var isMachineRequiredExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 8)));
            var machineStopParameterExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 9)));
            var isCountForRejectExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 10)));
            var bitValueExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 11)));
            var isCheckAtMachineStartExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 12)));
            var isRefreshMachineSettingsExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 14)));
            var isHideEditExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 15)));
            var isAlarmForCounterExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 16)));


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    AlarmRow alarmRow = new AlarmRow();
                    alarmRow.AlarmName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 1)]);
                    alarmRow.MachineMachineName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 2)]);
                    alarmRow.MachineParameterMachineParameterName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 3)]);
                    alarmRow.Message = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 4)]);
                    alarmRow.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 13)]);


                    if (string.IsNullOrWhiteSpace(alarmRow.AlarmName) || string.IsNullOrWhiteSpace(alarmRow.MachineMachineName) || string.IsNullOrWhiteSpace(alarmRow.MachineParameterMachineParameterName) || string.IsNullOrWhiteSpace(alarmRow.Message) || string.IsNullOrWhiteSpace(alarmRow.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Alarm Name, Machine, Machine Parameter, Message, Status"));
                        continue;
                    }

                    if (descriptionExist)
                    {
                        alarmRow.Description = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 5)]);
                    }
                    if (isResetRequiredExist)
                    {
                        var isresetRequired = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 6)]));
                    }
                    if (isCommentRequiredExist)
                    {
                        alarmRow.IsCommentRequired = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 7)]));
                    }

                    if (isMachineRequiredExist)
                    {
                        alarmRow.IsMachineRequiredToStop = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 8)]));
                    }
                    if (machineStopParameterExist)
                    {
                        alarmRow.IsMachineRequiredToStop = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 9)]));
                    }
                    if (isAlarmForCounterExist)
                    {
                        alarmRow.IsAlarmForCounter = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 16)]));
                    }
                    if (isCountForRejectExist)
                    {
                        alarmRow.IsCountForReject = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 10)]));
                    }

                    if (bitValueExist)
                    {
                        alarmRow.BitValue = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 11)]));
                    }
                    if (isCheckAtMachineStartExist)
                    {
                        alarmRow.IsCheckAtMachineStart = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 12)]));
                    }
                    if (isRefreshMachineSettingsExist)
                    {
                        alarmRow.IsRefreshMachineSettings = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 14)]));
                    }
                    if (isHideEditExist)
                    {
                        alarmRow.IsHideEdit = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 15)]));
                    }

                    var machineData = (CVC.Data.EDMX.Machine)commonServices.GetTableDataByName("machine", alarmRow.MachineMachineName);
                    if (machineData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Machine Name"));
                        continue;
                    }
                    alarmRow.MachineId = machineData.MachineId;

                    var machineParameterData = (MachineParameter)commonServices.GetTableDataByName("machineParameter", alarmRow.MachineParameterMachineParameterName);
                    if (machineParameterData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Machine Parameter Name"));
                        continue;
                    }
                    alarmRow.MachineParameterId = machineParameterData.MachineParameterId;

                    var statusData = (Status)commonServices.GetTableDataByName("status", alarmRow.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    alarmRow.StatusId = statusData.StatusId;

                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {

                        SaveData(formType, alarmRow);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }

                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportMachineData(DataTable dt, string formType)
        {
            var descriptionExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 4)));
            var modelNumberExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 5)));
            var serialNuberExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 6)));
            var makeExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 7)));
            var yearExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 8)));
            var plcMakeExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 9)));
            var plcModelNumberExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 10)));
            var plcSerialNumberExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 11)));
            var plcAddressExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 12)));
            var timerForAlarmExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 13)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    MachineRow machineRow = new MachineRow();
                    machineRow.MachineName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 1)]);
                    machineRow.AccessIpAddress = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 2)]);
                    var machineSequence = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 3)]);
                    machineRow.PlcMake = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 9)]);
                    machineRow.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 14)]);

                    if (string.IsNullOrWhiteSpace(machineRow.MachineName) || string.IsNullOrWhiteSpace(machineRow.AccessIpAddress) || string.IsNullOrWhiteSpace(machineSequence) || string.IsNullOrWhiteSpace(machineRow.PlcMake) || string.IsNullOrWhiteSpace(machineRow.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Machine, Access IP Address, Machine Sequence,Plc Make, Status"));
                        continue;
                    }

                    if (descriptionExist)
                    {
                        machineRow.Description = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 4)]);
                    }
                    if (modelNumberExist)
                    {
                        machineRow.ModelNumber = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 5)]);
                    }
                    if (serialNuberExist)
                    {
                        machineRow.SerialNumber = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 6)]);
                    }

                    if (makeExist)
                    {
                        machineRow.Make = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 7)]);
                    }
                    if (yearExist)
                    {
                        machineRow.Year = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 8)]));
                    }
                    if (plcModelNumberExist)
                    {
                        machineRow.PlcModelNumber = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 10)]);
                    }

                    if (plcSerialNumberExist)
                    {
                        machineRow.PlcSerialNumber = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 11)]);
                    }

                    if (plcAddressExist)
                    {
                        machineRow.PlcAddress = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 12)]);
                    }

                    if (timerForAlarmExist)
                    {
                        machineRow.TimerForAlarm = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 13)]));
                    }

                    var statusData = (Status)commonServices.GetTableDataByName("status", machineRow.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    machineRow.StatusId = statusData.StatusId;

                    machineRow.MachineSequence = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 3)]));

                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {

                        SaveData(formType, machineRow);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }


                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportBottleData(DataTable dt, string formType)
        {
            var bottleCCExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.BottleFormField), 2)));
            var bottleHeightExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.BottleFormField), 4)));
            var bottleDiameterExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.BottleFormField), 5)));
            var bottleMouthOpening_IDExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.BottleFormField), 6)));
            var bottleMouthOpening_ODExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.BottleFormField), 7)));
            var containerTypeExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.BottleFormField), 3)));
            var supplierNameExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.BottleFormField), 8)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    BottleRow bottle = new BottleRow();
                    bottle.BottleName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 1)]);
                    bottle.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 9)]);

                    if (string.IsNullOrWhiteSpace(bottle.BottleName) || string.IsNullOrWhiteSpace(bottle.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Bottle Name, Status"));
                        continue;
                    }

                    if (bottleCCExist)
                    {
                        bottle.BottleCc = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 2)]);
                    }
                    if (bottleHeightExist)
                    {
                        bottle.BottleHeight = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 4)]);
                    }
                    if (bottleDiameterExist)
                    {
                        bottle.BottleDiameter = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 5)]);
                    }
                    if (bottleMouthOpening_IDExist)
                    {
                        bottle.BottleMouthOpeningId = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 6)]);
                    }
                    if (bottleMouthOpening_ODExist)
                    {
                        bottle.BottleMouthOpeningOd = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 7)]);
                    }

                    if (containerTypeExist)
                    {
                        bottle.ContainerTypePickListValueName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 3)]);

                        var pickListValueData = (PickListValue)commonServices.GetTableDataByName("pickListValue", bottle.ContainerTypePickListValueName);
                        if (pickListValueData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Container Type"));
                            continue;
                        }
                        bottle.ContainerTypeId = pickListValueData.PickListValueId;
                    }

                    var statusData = (Status)commonServices.GetTableDataByName("status", bottle.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    bottle.StatusId = statusData.StatusId;

                    if (supplierNameExist)
                    {
                        bottle.SupplierSupplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 8)]);

                        var supplierData = (Supplier)commonServices.GetTableDataByName("supplier", bottle.SupplierSupplierName);
                        if (supplierData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Supplier Name"));
                            continue;
                        }
                        bottle.SupplierId = supplierData.SupplierId;
                    }

                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {
                        //try
                        //{
                        SaveData(formType, bottle);
                        //}
                        //catch (System.Exception ex)
                        //{
                        //    failedRecordCount++;
                        //AddImportErrorMessage(dt, i, ex.Message);
                        //    Logic.PostLicenseAction("Role", "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Failure);
                        //    continue;
                        //}
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                        // If the function return true , then proceed with importing values , If it returns False, then eother action and controller is not matching or license for action is expired
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }


                    //SaveData("bottle", bottle);
                    //succededRecordCount++;
                    //commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                    //i = i - 1;

                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportCapData(DataTable dt, string formType)
        {
            var capCCExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.CapFormField), 2)));
            var supplierExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.CapFormField), 6)));


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    CapRow cap = new CapRow();

                    cap.CapName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CapFormField), 1)]);
                    cap.CapTypePickListValueName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CapFormField), 3)]);
                    cap.CapDiameter = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CapFormField), 4)]);
                    cap.CapHeight = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CapFormField), 5)]);
                    cap.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CapFormField), 7)]);

                    if (string.IsNullOrWhiteSpace(cap.CapName) || string.IsNullOrWhiteSpace(cap.CapTypePickListValueName) || string.IsNullOrWhiteSpace(cap.CapDiameter) || string.IsNullOrWhiteSpace(cap.CapHeight) || string.IsNullOrWhiteSpace(cap.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Cap Name, Cap Type, Cap Diameter, Cap Height, Status"));
                        continue;
                    }

                    if (capCCExist)
                    {
                        cap.CapCc = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CapFormField), 2)]);
                    }
                    if (supplierExist)
                    {
                        cap.SupplierSupplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CapFormField), 6)]);
                        var supplierData = (Supplier)commonServices.GetTableDataByName("supplier", cap.SupplierSupplierName);
                        if (supplierData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Supplier Name"));
                            continue;
                        }
                        cap.SupplierId = supplierData.SupplierId;

                    }

                    var pickListValueData = (PickListValue)commonServices.GetTableDataByName("pickListValue", cap.CapTypePickListValueName);
                    if (pickListValueData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Cap Type"));
                        continue;
                    }
                    cap.CapTypeId = pickListValueData.PickListValueId;

                    var statusData = (Status)commonServices.GetTableDataByName("status", cap.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    cap.StatusId = statusData.StatusId;


                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {
                        SaveData(formType, cap);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }

                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }
            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportCottonData(DataTable dt, string formType)
        {

            var supplierExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.CottonFormField), 4)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    CottonRow cotton = new CottonRow();

                    cotton.CottonName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CottonFormField), 1)]);
                    cotton.CottonTypePickListValueName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CottonFormField), 2)]);
                    cotton.GmOrYard = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CottonFormField), 3)]);
                    cotton.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CottonFormField), 5)]);

                    if (string.IsNullOrWhiteSpace(cotton.CottonName) || string.IsNullOrWhiteSpace(cotton.CottonTypePickListValueName) || string.IsNullOrWhiteSpace(cotton.GmOrYard) || string.IsNullOrWhiteSpace(cotton.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Cotton Type, Gm Or Yard, Status"));
                        continue;
                    }

                    if (supplierExist)
                    {
                        cotton.SupplierSupplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CottonFormField), 4)]);
                        var supplierData = (Supplier)commonServices.GetTableDataByName("supplier", cotton.SupplierSupplierName);
                        if (supplierData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Supplier Name"));
                            continue;
                        }
                        cotton.SupplierId = supplierData.SupplierId;

                    }

                    var pickListValueData = (PickListValue)commonServices.GetTableDataByName("pickListValue", cotton.CottonTypePickListValueName);

                    if (pickListValueData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Cotton Type"));
                        continue;
                    }
                    cotton.CottonTypePickListId = pickListValueData.PickListValueId;

                    var statusData = (Status)commonServices.GetTableDataByName("status", cotton.StatusStatusName);

                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    cotton.StatusId = statusData.StatusId;
                    cotton.CreatedBy = null;
                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {

                        SaveData(formType, cotton);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }


                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportDesiccantData(DataTable dt, string formType)
        {
            var supplierExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.DesiccantFormField), 7)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    DesiccantRow desiccantRow = new DesiccantRow();

                    desiccantRow.DesiccantName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 1)]);
                    desiccantRow.DesiccantTypePickListValueName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 2)]);
                    desiccantRow.Grammage = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 3)]);
                    desiccantRow.LengthOrHeight = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 4)]);
                    desiccantRow.DiameterOrWidth = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 5)]);
                    desiccantRow.IdentificationPickListValueName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 6)]);
                    desiccantRow.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 8)]);

                    if (string.IsNullOrWhiteSpace(desiccantRow.DesiccantName) || string.IsNullOrWhiteSpace(desiccantRow.DesiccantTypePickListValueName) || string.IsNullOrWhiteSpace(desiccantRow.Grammage) || string.IsNullOrWhiteSpace(desiccantRow.LengthOrHeight) || string.IsNullOrWhiteSpace(desiccantRow.DiameterOrWidth) || string.IsNullOrWhiteSpace(desiccantRow.IdentificationPickListValueName) || string.IsNullOrWhiteSpace(desiccantRow.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Desiccant Name, Desiccant Type, Grammage, Length Or Height, Diameter Or Width, Identification, Status"));
                        continue;
                    }

                    if (supplierExist)
                    {
                        desiccantRow.SupplierSupplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 7)]);
                        var supplierData = (Supplier)commonServices.GetTableDataByName("supplier", desiccantRow.SupplierSupplierName);
                        if (supplierData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Supplier Name"));
                            continue;
                        }
                        desiccantRow.SupplierId = supplierData.SupplierId;

                    }

                    var pickListValueForDesicantType = (PickListValue)commonServices.GetTableDataByName("pickListValue", desiccantRow.DesiccantTypePickListValueName);
                    if (pickListValueForDesicantType == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Desiccant Type"));
                        continue;
                    }
                    desiccantRow.DesiccantTypeId = pickListValueForDesicantType.PickListValueId;

                    var pickListValueDataForIdentification = (PickListValue)commonServices.GetTableDataByName("pickListValue", desiccantRow.IdentificationPickListValueName);
                    if (pickListValueDataForIdentification == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Identification"));
                        continue;
                    }
                    desiccantRow.Identification = pickListValueDataForIdentification.PickListValueId;


                    var statusData = (Status)commonServices.GetTableDataByName("status", desiccantRow.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    desiccantRow.StatusId = statusData.StatusId;


                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {
                        SaveData(formType, desiccantRow);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }


                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);

        }

        public Tuple<int, int> ImportLabelData(DataTable dt, string formType)
        {
            var supplierExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.LabelFormField), 5)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    LabelRow labelRow = new LabelRow();
                    labelRow.LabelName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 1)]);
                    labelRow.LabelLength = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 2)]);
                    labelRow.LabelHeight = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 3)]);
                    labelRow.LabelType = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 4)]);
                    labelRow.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 6)]);

                    if (string.IsNullOrWhiteSpace(labelRow.LabelName) || string.IsNullOrWhiteSpace(labelRow.LabelLength) || string.IsNullOrWhiteSpace(labelRow.LabelHeight) || string.IsNullOrWhiteSpace(labelRow.LabelType) || string.IsNullOrWhiteSpace(labelRow.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Label Name, Label Length, Label Height, Label Type, Status"));
                        continue;
                    }

                    if (supplierExist)
                    {
                        labelRow.SupplierSupplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 5)]);
                        var supplierData = (Supplier)commonServices.GetTableDataByName("supplier", labelRow.SupplierSupplierName);
                        if (supplierData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "supplier Name"));
                            continue;
                        }
                        labelRow.SupplierId = supplierData.SupplierId;

                    }
                    var statusData = (Status)commonServices.GetTableDataByName("status", labelRow.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    labelRow.StatusId = statusData.StatusId;


                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {

                        SaveData(formType, labelRow);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }

                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportOutsertData(DataTable dt, string formType)
        {
            var supplierExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.OutsertFormField), 5)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    OutsertRow outsertRow = new OutsertRow();
                    outsertRow.OutsertName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.OutsertFormField), 1)]);
                    outsertRow.OutsertLength = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.OutsertFormField), 2)]);
                    outsertRow.OutsertWidth = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.OutsertFormField), 3)]);
                    outsertRow.OutsertThickness = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.OutsertFormField), 4)]);
                    outsertRow.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.OutsertFormField), 6)]);

                    if (string.IsNullOrWhiteSpace(outsertRow.OutsertName) || string.IsNullOrWhiteSpace(outsertRow.OutsertLength) || string.IsNullOrWhiteSpace(outsertRow.OutsertWidth) || string.IsNullOrWhiteSpace(outsertRow.OutsertThickness) || string.IsNullOrWhiteSpace(outsertRow.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Outsert Name, Outsert Length, Outsert Width, Outsert Thickness, Status"));
                        continue;
                    }

                    if (supplierExist)
                    {
                        outsertRow.SupplierSupplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.OutsertFormField), 5)]);
                        var supplierData = (Supplier)commonServices.GetTableDataByName("supplier", outsertRow.SupplierSupplierName);
                        if (supplierData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Supplier Name"));
                            continue;
                        }
                        outsertRow.SupplierId = supplierData.SupplierId;
                    }

                    var statusData = (Status)commonServices.GetTableDataByName("status", outsertRow.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    outsertRow.StatusId = statusData.StatusId;

                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {

                        SaveData(formType, outsertRow);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }


                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportPackData(DataTable dt, string formType)
        {
            var productQuantityExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 3)));
            var bottleNameExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 4)));
            var capNameExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 5)));
            var cottonNameExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 6)));
            var cottonLengthExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 7)));
            var cottonPiecesExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 8)));
            var desiccantNameExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 9)));
            var desiccantPiecesExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 10)));
            var outsertNameExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 11)));
            var labelNameExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 12)));
            var endOfLineExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 13)));


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    PackRow packRow = new PackRow();
                    packRow.PackName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 1)]);
                    packRow.TabletName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 2)]);
                    packRow.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 14)]);

                    if (string.IsNullOrWhiteSpace(packRow.PackName) || string.IsNullOrWhiteSpace(packRow.TabletName) || string.IsNullOrWhiteSpace(packRow.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Pack Name, Tablet Name, Status"));
                        continue;

                    }

                    if (productQuantityExist)
                    {
                        packRow.TabletCount = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 3)]));
                    }
                    if (bottleNameExist)
                    {
                        packRow.BottleName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 4)]);
                        var bottleData = (Bottle)commonServices.GetTableDataByName("bottle", packRow.BottleName);
                        if (bottleData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Bottle Name"));
                            continue;
                        }
                        packRow.BottleId = bottleData.BottleId;

                    }

                    if (capNameExist)
                    {
                        packRow.CapName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 5)]);
                        var capData = (Cap)commonServices.GetTableDataByName("cap", packRow.CapName);
                        if (capData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Cap Name"));
                            continue;
                        }
                        packRow.CapId = capData.CapId;

                    }

                    if (cottonNameExist)
                    {
                        packRow.CottonName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 6)]);
                        var cottonData = (Cotton)commonServices.GetTableDataByName("cotton", packRow.CottonName);
                        if (cottonData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Cotton Name"));


                            continue;
                        }
                        packRow.CottonId = cottonData.CottonId;

                    }

                    if (cottonLengthExist)
                    {
                        packRow.CottonLength = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 7)]);
                    }

                    if (cottonPiecesExist)
                    {
                        packRow.NumberOfCottonPieces = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 8)]));
                    }

                    if (desiccantNameExist)
                    {
                        packRow.DesiccantName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 9)]);
                        var desiccantData = (Desiccant)commonServices.GetTableDataByName("desiccant", packRow.DesiccantName);
                        if (desiccantData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Desiccant Name"));
                            continue;
                        }
                        packRow.DesiccantId = desiccantData.DesiccantId;
                    }

                    if (desiccantPiecesExist)
                    {
                        packRow.NumberOfDesicantPieces = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 10)]));
                    }

                    if (outsertNameExist)
                    {
                        packRow.OutsertName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 11)]);
                        var outsertData = (Outsert)commonServices.GetTableDataByName("outsert", packRow.OutsertName);
                        if (outsertData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Outsert Name"));
                            continue;
                        }
                        packRow.OutsertId = outsertData.OutsertId;

                    }

                    if (labelNameExist)
                    {
                        packRow.LabelLabelName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 12)]);
                        var labelData = (Label)commonServices.GetTableDataByName("label", packRow.LabelLabelName);
                        if (labelData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Label Name"));
                            continue;
                        }
                        packRow.LabelId = labelData.LabelId;

                    }

                    if (endOfLineExist)
                    {
                        packRow.EndOfLineEndOfLineName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 13)]);

                        var endOfLineData = (EndOfLine)commonServices.GetTableDataByName("endOfLine", packRow.EndOfLineEndOfLineName);
                        if (endOfLineData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "End Of Line Name"));
                            continue;
                        }
                        packRow.EndOfLineId = endOfLineData.EndOfLineId;

                    }

                    var tabletData = (TabletDetail)commonServices.GetTableDataByName("tablet", packRow.TabletName);
                    if (tabletData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Tablet Name"));
                        continue;
                    }
                    packRow.TabletId = tabletData.TabletDetailsId;


                    var statusData = (Status)commonServices.GetTableDataByName("status", packRow.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    packRow.StatusId = statusData.StatusId;


                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {

                        SaveData(formType, packRow);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }


                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportTabletDetailsData(DataTable dt, string formType)
        {
            var tabletStrengthExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 2)));
            var tabletTypeExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 3)));
            var charasteristicsOneExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 4)));
            var charasteristicsTwoExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 5)));
            var tabletShapeExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 6)));
            var tabletLengthExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 7)));
            var tabletThicknessExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 8)));
            var tabletWidthExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 9)));


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    TabletDetailsRow tabletDetailsRow = new TabletDetailsRow();
                    tabletDetailsRow.TabletName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 1)]);
                    tabletDetailsRow.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 10)]);

                    if (string.IsNullOrWhiteSpace(tabletDetailsRow.TabletName) || string.IsNullOrWhiteSpace(tabletDetailsRow.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Tablet Name, Status"));
                        continue;
                    }

                    if (tabletStrengthExist)
                    {
                        tabletDetailsRow.TabletStrength = (Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 2)]));
                    }
                    if (tabletTypeExist)
                    {
                        tabletDetailsRow.TabletTypePickListValueName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 3)]);
                        var tabletDetailsData = (PickListValue)commonServices.GetTableDataByName("pickListValue", tabletDetailsRow.TabletTypePickListValueName);
                        if (tabletDetailsData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Tablet Type"));
                            continue;
                        }
                        tabletDetailsRow.TabletTypeId = tabletDetailsData.PickListValueId;
                    }

                    if (charasteristicsOneExist)
                    {
                        tabletDetailsRow.TabletCharOnePickListValueName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 4)]);
                        var charOneDetailsData = (PickListValue)commonServices.GetTableDataByName("pickListValue", tabletDetailsRow.TabletCharOnePickListValueName);
                        if (charOneDetailsData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Charasteristics One"));
                            continue;
                        }
                        tabletDetailsRow.TabletCharOneId = charOneDetailsData.PickListValueId;
                    }

                    if (charasteristicsTwoExist)
                    {
                        tabletDetailsRow.TabletCharTwoPickListValueName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 5)]);
                        var charTwoDetailsData = (PickListValue)commonServices.GetTableDataByName("pickListValue", tabletDetailsRow.TabletCharTwoPickListValueName);
                        if (charTwoDetailsData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Characteristics Two"));
                            continue;
                        }
                        tabletDetailsRow.TabletCharTwoId = charTwoDetailsData.PickListValueId;
                    }

                    if (tabletShapeExist)
                    {
                        tabletDetailsRow.TabletShapePickListValueName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 6)]);
                        var tabletShapeData = (PickListValue)commonServices.GetTableDataByName("pickListValue", tabletDetailsRow.TabletShapePickListValueName);
                        if (tabletShapeData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Tablet Shape"));
                            continue;
                        }
                        tabletDetailsRow.TabletShapeId = tabletShapeData.PickListValueId;
                    }

                    if (tabletLengthExist)
                    {
                        tabletDetailsRow.TabletLength = (Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 7)]));
                    }

                    if (tabletThicknessExist)
                    {
                        tabletDetailsRow.TabletThickness = (Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 8)]));
                    }

                    if (tabletWidthExist)
                    {
                        tabletDetailsRow.TabletWidth = (Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.TabletDetailsFormField), 9)]));

                    }

                    var statusData = (Status)commonServices.GetTableDataByName("status", tabletDetailsRow.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    tabletDetailsRow.StatusId = statusData.StatusId;



                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {

                        SaveData(formType, tabletDetailsRow);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }



                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportUserData(DataTable dt, string formType)
        {
            var employeeIdExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.UserFormField), 1)));
            var designationExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.UserFormField), 5)));
            var mobileCodeExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.UserFormField), 6)));
            var mobileNumberExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.UserFormField), 7)));
            var birthDateExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.UserFormField), 8)));
            var emailExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.UserFormField), 9)));
            var roleExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.UserFormField), 13)));
            var addressExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.UserFormField), 14)));
            var pinCodeExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.UserFormField), 16)));
            var isLockOutExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.UserFormField), 20)));
            var IsActiveDirectoryExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.UserFormField), 21)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    UserRow userRow = new UserRow();
                    userRow.FirstName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 2)]);
                    userRow.LastName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 3)]);
                    userRow.DepartmentName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 4)]);
                    userRow.Username = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 10)]);
                    userRow.Password = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 11)]);
                    userRow.PasswordConfirm = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 12)]);
                    userRow.City = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 15)]);
                    userRow.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 17)]);
                    var question = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 18)]);
                    userRow.QuestionAns = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 19)]);



                    if (string.IsNullOrWhiteSpace(userRow.FirstName) || string.IsNullOrWhiteSpace(userRow.LastName) || string.IsNullOrWhiteSpace(userRow.DepartmentName) || string.IsNullOrWhiteSpace(Convert.ToString(question)) || string.IsNullOrWhiteSpace(userRow.Username) || string.IsNullOrWhiteSpace(userRow.Password) || string.IsNullOrWhiteSpace(userRow.PasswordConfirm) || string.IsNullOrWhiteSpace(userRow.QuestionAns) || string.IsNullOrWhiteSpace(userRow.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "First Name, Last Name, Department, UserName, Password, Confirm Password, City, Question, Answer, Status"));
                        continue;
                    }

                    if (userRow.Password != userRow.PasswordConfirm)
                    {
                        failedRecordCount++;
                        AddImportErrorMessage(dt, i, "Password and Confirm Password does not match");
                        continue;
                    }
                    var statusData = (Status)commonServices.GetTableDataByName("status", userRow.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    userRow.StatusId = (short)statusData.StatusId;

                    var departmentData = (Department)commonServices.GetTableDataByName("department", userRow.DepartmentName);
                    if (departmentData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Department Name"));
                        continue;
                    }
                    userRow.DepartmentId = departmentData.DepartmentId;

                    var cityData = (CityDetail)commonServices.GetTableDataByName("city", userRow.City);
                    if (cityData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "City"));
                        continue;
                    }
                    userRow.CityId = cityData.CityDetailsId;

                    var questionData = (PickListValue)commonServices.GetTableDataByName("pickListValue", question);
                    if (questionData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Question"));
                        continue;
                    }
                    userRow.QuestionId = questionData.PickListValueId;

                    if (employeeIdExist)
                    {
                        userRow.EmployeeId = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 1)]);
                    }
                    if (designationExist)
                    {
                        userRow.Designation = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 5)]);
                    }
                    if (mobileCodeExist)
                    {
                        userRow.MobileCode = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 6)]));

                    }
                    if (mobileNumberExist)
                    {
                        userRow.MobileNumber = GetInt64NumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 7)]));
                    }
                    if (birthDateExist)
                    {
                        // userRow.BirthDate =con Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 8)]);
                    }
                    if (emailExist)
                    {
                        userRow.Email = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 9)]);
                    }
                    if (roleExist)
                    {
                        userRow.RolesRoleName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 13)]);
                        var roleData = (Role)commonServices.GetTableDataByName("role", userRow.RolesRoleName);
                        if (roleData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Role"));
                            continue;
                        }
                        userRow.RoleId = roleData.RoleId;

                    }
                    if (addressExist)
                    {
                        userRow.Address = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 14)]);
                    }
                    if (pinCodeExist)
                    {
                        userRow.PinCode = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 16)]);
                    }

                    if (isLockOutExist)
                    {
                        userRow.IsLockOut = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 20)]));
                    }

                    if (IsActiveDirectoryExist)
                    {
                        userRow.IsActiveDirectory = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.UserFormField), 21)]));
                    }



                    if (Logic.PostLicenseAction("User", "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {

                        SaveData(formType, userRow);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction("User");
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }

                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction("User");
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportMachineCommunicationData(DataTable dt, string formType)
        {
            var ipAddressExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 3)));
            var tCPIPPortExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 4)));
            var pollRateExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 5)));
            var securityModeIdExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 7)));
            var securityPolicyExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 8)));
            var authenticationSettingsExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 9)));
            var userNameExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 10)));
            var passwordExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 11)));
            var mdbPathExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 12)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    MachineCommunicationRow machineCommunicationRow = new MachineCommunicationRow();
                    machineCommunicationRow.ProtocolName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 1)]);
                    machineCommunicationRow.MachineMachineName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 2)]);
                    machineCommunicationRow.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 6)]);

                    if (string.IsNullOrWhiteSpace(machineCommunicationRow.ProtocolName) || string.IsNullOrWhiteSpace(machineCommunicationRow.MachineMachineName) || string.IsNullOrWhiteSpace(machineCommunicationRow.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Protocol Name, Machine, Status"));
                        continue;
                    }

                    var statusData = (Status)commonServices.GetTableDataByName("status", machineCommunicationRow.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    machineCommunicationRow.StatusId = statusData.StatusId;

                    var machineData = (CVC.Data.EDMX.Machine)commonServices.GetTableDataByName("machine", machineCommunicationRow.MachineMachineName);
                    if (machineData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Machine Name"));
                        continue;
                    }
                    machineCommunicationRow.MachineId = machineData.MachineId;

                    var protocolData = (Protocol)commonServices.GetTableDataByName("protocol", machineCommunicationRow.ProtocolName);
                    if (machineData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Protocol Name"));
                        continue;
                    }
                    machineCommunicationRow.ProtocolTypeId = protocolData.ProtocolId;


                    if (ipAddressExist)
                    {
                        machineCommunicationRow.IpAddress = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 3)]);
                    }
                    if (tCPIPPortExist)
                    {
                        machineCommunicationRow.TcpipPort = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 4)]));
                    }
                    if (pollRateExist)
                    {
                        machineCommunicationRow.PollRate = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 5)]));
                    }
                    if (userNameExist)
                    {
                        machineCommunicationRow.UserName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 10)]);
                    }
                    if (passwordExist)
                    {
                        machineCommunicationRow.Password = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 11)]);
                    }
                    if (mdbPathExist)
                    {
                        machineCommunicationRow.MDBPath = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 12)]);
                    }
                    if (securityModeIdExist)
                    {
                        var securityMode = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 7)]);
                        var securityModeData = (PickListValue)commonServices.GetTableDataByName("pickListValue", securityMode);
                        if (securityModeData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Security Mode"));
                            continue;
                        }
                        machineCommunicationRow.SecurityModeId = securityModeData.PickListValueId;
                    }

                    if (securityPolicyExist)
                    {
                        var securityPolicy = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 8)]);
                        var securityPolicyData = (PickListValue)commonServices.GetTableDataByName("pickListValue", securityPolicy);
                        if (securityPolicyData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Security Policy"));
                            continue;
                        }
                        machineCommunicationRow.SecurityPolicyId = securityPolicyData.PickListValueId;
                    }

                    if (authenticationSettingsExist)
                    {
                        var authenticationSettings = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineCommunicationFormField), 9)]);
                        var authenticationSettingsData = (PickListValue)commonServices.GetTableDataByName("pickListValue", authenticationSettings);
                        if (authenticationSettingsData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Authentication Settings"));
                            continue;
                        }
                        machineCommunicationRow.UserIdentityId = authenticationSettingsData.PickListValueId;
                    }

                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {

                        SaveData(formType, machineCommunicationRow);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }


                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportIpcParameterData(DataTable dt, string formType)
        {
            var iPCAddressExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 3)));
            var isBitWiseExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 6)));
            var is32BitExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 7)));
            var isWordSwapExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 8)));
            var isByteSwapExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 9)));
            var isStopATIPCExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 10)));
            var isShowAsMessageIPCExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 11)));
            var isBatchStartRequiredIPCExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 12)));
            var isResetOnBatchCreateIPCExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 13)));
            var isLabelRollIPCExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 14)));
            var disableParameterIdIPCExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 15)));
            var disableParameterValueIPCExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 16)));
            var isStopOnBatchStopIPCExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 17)));
            var operationTypeIPCExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 18)));
            var operationValueIPCExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 19)));
            var isAlarmExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 20)));
            var isMachineSpeedExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 21)));
            var isHeartBeatExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 22)));
            var heartBeatFailedTimeExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 23)));
            var isHeartBeatSendExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 24)));
            var incrementalNumberExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 25)));
            var startNumberExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 26)));
            var endNumberExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 27)));
            var isWriteToPLCExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 28)));
            var isIndicatorParameterExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 29)));
            var indicatorParameterIdExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 30)));
            var isGoodBottlesExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 31)));
            var isRejectBottlesExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 32)));
            var isBatchSizeExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 33)));
            var isCounterResetExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 34)));
            var isConveyerExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 35)));
            var isMissingLabelCounterExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 36)));
            var nodeIdExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 37)));
            var attributeIdExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 38)));
            var bit32AddressExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 39)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    IpcParameterRow ipcParameterRow = new IpcParameterRow();

                    ipcParameterRow.MachineMachineName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 1)]);
                    ipcParameterRow.MachineParameterName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 2)]);
                    ipcParameterRow.IpcParameterName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 4)]);
                    ipcParameterRow.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 5)]);

                    if (string.IsNullOrWhiteSpace(ipcParameterRow.MachineMachineName) || string.IsNullOrWhiteSpace(ipcParameterRow.MachineParameterName) || string.IsNullOrWhiteSpace(ipcParameterRow.IpcParameterName) || string.IsNullOrWhiteSpace(ipcParameterRow.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Machine, Machine Parameter Name,Ipc Parameter Name, Status"));
                        continue;
                    }
                    if (iPCAddressExist)
                    {
                        ipcParameterRow.IpcAddress = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 3)]);
                    }

                    if (isBitWiseExist)
                    {
                        ipcParameterRow.IsBitWise = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 6)]));
                    }
                    if (is32BitExist)
                    {
                        ipcParameterRow.Is32Bit = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 7)]));
                    }
                    if (isWordSwapExist)
                    {
                        ipcParameterRow.IsWordSwap = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 8)]));
                    }
                    if (isByteSwapExist)
                    {
                        ipcParameterRow.IsByteSwap = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 9)]));
                    }
                    if (isStopATIPCExist)
                    {
                        ipcParameterRow.IsStopATIPC = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 10)]));
                    }
                    if (isShowAsMessageIPCExist)
                    {
                        ipcParameterRow.IsShowAsMessageIPC = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 11)]));
                    }
                    if (isBatchStartRequiredIPCExist)
                    {
                        ipcParameterRow.IsBatchStartRequiredIPC = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 12)]));
                    }
                    if (isResetOnBatchCreateIPCExist)
                    {
                        ipcParameterRow.IsResetOnBatchCreateIPC = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 13)]));
                    }
                    if (isLabelRollIPCExist)
                    {
                        ipcParameterRow.IsLabelRollIPC = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 14)]));
                    }
                    if (disableParameterIdIPCExist)
                    {
                        var disableParameterName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 15)]);
                        var disableParameterData = (MachineParameter)commonServices.GetTableDataByName("machineParameter", disableParameterName);
                        if (disableParameterData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Disable Parameter Name"));
                            continue;
                        }
                        ipcParameterRow.DisableParameterIdIPC = disableParameterData.MachineParameterId;

                    }
                    if (disableParameterValueIPCExist)
                    {
                        ipcParameterRow.DisableParameterValueIPC = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 16)]);
                    }

                    if (isStopOnBatchStopIPCExist)
                    {
                        ipcParameterRow.IsStopOnBatchStopIPC = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 17)]));
                    }
                    if (operationTypeIPCExist)
                    {
                        var operationTypeName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 18)]);
                        var operationTypeData = (PickListValue)commonServices.GetTableDataByName("pickListValue", operationTypeName);
                        if (operationTypeData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Operation Type"));

                            continue;
                        }
                        ipcParameterRow.OperationTypeIPC = operationTypeData.PickListValueId;

                    }
                    if (operationValueIPCExist)
                    {
                        ipcParameterRow.OperationValueIPC = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 19)]));
                    }
                    if (isAlarmExist)
                    {
                        ipcParameterRow.IsAlarm = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 20)]));
                    }
                    if (isMachineSpeedExist)
                    {
                        ipcParameterRow.IsMachineSpeed = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 21)]));
                    }
                    if (isHeartBeatExist)
                    {
                        ipcParameterRow.IsHeartBeat = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 22)]));
                    }
                    if (heartBeatFailedTimeExist)
                    {
                        ipcParameterRow.HeartBeatFailedTime = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 23)]));
                    }
                    if (isHeartBeatSendExist)
                    {
                        ipcParameterRow.IsHeartBeatSend = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 24)]));
                    }
                    if (incrementalNumberExist)
                    {
                        ipcParameterRow.IncrementalNumber = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 25)]));
                    }
                    if (startNumberExist)
                    {
                        ipcParameterRow.StartNumber = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 26)]));
                    }
                    if (endNumberExist)
                    {
                        ipcParameterRow.EndNumber = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 27)]));
                    }
                    if (isWriteToPLCExist)
                    {
                        ipcParameterRow.IsWriteToPLC = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 28)]));
                    }
                    if (isIndicatorParameterExist)
                    {
                        ipcParameterRow.IsIndicatorParameter = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 29)]));
                    }
                    if (indicatorParameterIdExist)
                    {
                        var indicatorParameterName = (Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 30)]));

                        var indicatorParameterData = (MachineParameter)commonServices.GetTableDataByName("machineParameter", indicatorParameterName);
                        if (indicatorParameterData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Indicator Parameter Name"));

                            continue;
                        }
                        ipcParameterRow.IndicatorParameterId = indicatorParameterData.MachineParameterId;

                    }
                    if (isGoodBottlesExist)
                    {
                        ipcParameterRow.IsGoodBottles = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 31)]));
                    }
                    if (isRejectBottlesExist)
                    {
                        ipcParameterRow.IsRejectBottles = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 32)]));
                    }
                    if (isBatchSizeExist)
                    {
                        ipcParameterRow.IsBatchSize = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 33)]));
                    }
                    if (isCounterResetExist)
                    {
                        ipcParameterRow.IsCounterReset = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 34)]));
                    }
                    if (isConveyerExist)
                    {
                        ipcParameterRow.IsConveyer = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 35)]));
                    }
                    if (isMissingLabelCounterExist)
                    {
                        ipcParameterRow.IsMissingLabelCounter = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 36)]));
                    }
                    if (nodeIdExist)
                    {
                        ipcParameterRow.NodeId = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 37)]);
                    }
                    if (attributeIdExist)
                    {
                        var attributeName = (Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 38)]));

                        var attributeData = (Attribute)commonServices.GetTableDataByName("attribute", attributeName);
                        if (attributeData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Attribute Name"));

                            continue;
                        }
                        ipcParameterRow.AttributeId = attributeData.AttributeId;

                    }

                    var statusData = (Status)commonServices.GetTableDataByName("status", ipcParameterRow.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    ipcParameterRow.StatusId = statusData.StatusId;
                    if (bit32AddressExist)
                    {
                        ipcParameterRow.Bit32Address = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.IpcParameterFormField), 39)]);
                    }



                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {

                        SaveData(formType, ipcParameterRow);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }



                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);
        }

        public Tuple<int, int> ImportMachineParameterData(DataTable dt, string formType)
        {
            var descriptionExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 3)));
            var isRangeUnlimitedExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 5)));
            var minExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 6)));
            var maxExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 7)));
            var isUseUnitExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 8)));
            var unitIdExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 9)));
            var allowDecimalPointExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 10)));
            var isReadExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 11)));
            var isWriteExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 12)));
            var typeExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 14)));
            var rowIdExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 15)));
            var isStopAtExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 16)));
            var isBitWiseExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 17)));
            var operationTypeExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 18)));
            var is32BitExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 19)));
            var isShowAsMessageExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 20)));
            var isResetOnBatchCreateExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 21)));
            var isLabelRollExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 22)));
            var disableParameterIdExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 23)));
            var disableParameterValueExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 24)));
            var isStopOnBatchStopExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 25)));
            var bitWiseIndexExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 26)));
            var queryTypeRowIdExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 27)));
            var operationValueExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 28)));
            var bit32RowExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 29)));
            var readMachineParameterIdExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 30)));
            var reloadMachineParameterIdExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 31)));
            var isBatchStartRequiredExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 32)));


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    MachineParameterRow machineParameterRow = new MachineParameterRow();
                    machineParameterRow.ParameterName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 1)]);
                    machineParameterRow.MachineMachineName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 2)]);
                    machineParameterRow.DataTypeName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 4)]);
                    machineParameterRow.StatusStatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 13)]);

                    if (string.IsNullOrWhiteSpace(machineParameterRow.ParameterName) || string.IsNullOrWhiteSpace(machineParameterRow.MachineMachineName) || string.IsNullOrWhiteSpace(machineParameterRow.DataTypeName) ||
                        string.IsNullOrWhiteSpace(machineParameterRow.StatusStatusName))
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameCanNotBeBlank);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Parameter Name, Machine, Data Type, Status"));
                        continue;
                    }

                    var statusData = (Status)commonServices.GetTableDataByName("status", machineParameterRow.StatusStatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Status Name"));
                        continue;
                    }
                    machineParameterRow.StatusId = statusData.StatusId;

                    var dataTypeData = (DataType)commonServices.GetTableDataByName("dataType", machineParameterRow.DataTypeName);
                    if (dataTypeData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Data Type"));
                        continue;
                    }
                    machineParameterRow.DataTypeId = dataTypeData.DataTypeId;

                    var machineData = (CVC.Data.EDMX.Machine)commonServices.GetTableDataByName("machine", machineParameterRow.MachineMachineName);
                    if (machineData == null)
                    {
                        failedRecordCount++;
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                        AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Machine Name"));
                        continue;
                    }
                    machineParameterRow.MachineId = machineData.MachineId;



                    if (descriptionExist)
                    {
                        machineParameterRow.Description = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 3)]);
                    }
                    if (isRangeUnlimitedExist)
                    {
                        machineParameterRow.IsRangeUnlimited = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 5)]));
                    }
                    if (minExist)
                    {
                        machineParameterRow.Min = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 6)]));
                    }
                    if (maxExist)
                    {
                        machineParameterRow.Max = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 7)]));
                    }
                    if (isUseUnitExist)
                    {
                        machineParameterRow.IsUseUnit = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 8)]));
                    }

                    if (unitIdExist)
                    {
                        var unitName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 9)]);

                        var unitData = (PickListValue)commonServices.GetTableDataByName("pickListValue", unitName);
                        if (unitData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Unit Name"));
                            continue;
                        }
                        machineParameterRow.UnitId = unitData.PickListValueId;

                    }
                    if (allowDecimalPointExist)
                    {
                        machineParameterRow.AllowDecimalPoint = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 10)]));
                    }
                    if (isReadExist)
                    {
                        machineParameterRow.IsRead = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 11)]));
                    }
                    if (isWriteExist)
                    {
                        machineParameterRow.IsWrite = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 12)]));
                    }
                    if (typeExist)
                    {
                        var typeName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 14)]);

                        var typeData = (PickListValue)commonServices.GetTableDataByName("pickListValue", typeName);
                        if (typeData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Type Name"));
                            continue;
                        }
                        machineParameterRow.Type = typeData.PickListValueId;

                    }
                    if (rowIdExist)
                    {
                        machineParameterRow.RowId = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 15)]));
                    }
                    if (isStopAtExist)
                    {
                        machineParameterRow.IsStopAt = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 16)]));
                    }
                    if (isBitWiseExist)
                    {
                        machineParameterRow.IsBitWise = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 17)]));
                    }
                    if (operationTypeExist)
                    {
                        var operationTypeName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 18)]);

                        var operationTypeData = (PickListValue)commonServices.GetTableDataByName("pickListValue", operationTypeName);
                        if (operationTypeData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Operation Type"));
                            continue;
                        }
                        machineParameterRow.OperationType = operationTypeData.PickListValueId;

                    }
                    if (is32BitExist)
                    {
                        machineParameterRow.Is32Bit = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 19)]));
                    }
                    if (isShowAsMessageExist)
                    {
                        machineParameterRow.IsShowAsMessage = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 20)]));
                    }
                    if (isResetOnBatchCreateExist)
                    {
                        machineParameterRow.IsResetOnBatchCreate = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 21)]));
                    }
                    if (isLabelRollExist)
                    {
                        machineParameterRow.IsLabelRoll = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 22)]));
                    }
                    if (disableParameterIdExist)
                    {
                        var disableParameterName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 23)]);

                        var disableParameterData = (MachineParameter)commonServices.GetTableDataByName("machineParameter", disableParameterName);
                        if (disableParameterData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Disable Parameter Name"));
                            continue;
                        }
                        machineParameterRow.DisableParameterId = disableParameterData.MachineParameterId;

                    }
                    if (disableParameterValueExist)
                    {
                        machineParameterRow.DisableParameterValue = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 24)]);
                    }
                    if (isStopOnBatchStopExist)
                    {
                        machineParameterRow.IsStopOnBatchStop = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 25)]));
                    }
                    if (bitWiseIndexExist)
                    {
                        machineParameterRow.BitWiseIndex = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 26)]));
                    }
                    if (queryTypeRowIdExist)
                    {
                        machineParameterRow.QueryTypeRowId = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 27)]));
                    }
                    if (operationValueExist)
                    {
                        machineParameterRow.OperationValue = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 28)]));
                    }
                    if (bit32RowExist)
                    {
                        machineParameterRow.Bit32RowId = GetNumberValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 29)]));
                    }
                    if (readMachineParameterIdExist)
                    {
                        var readMacineParameterName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 30)]);

                        var readMacineParameterData = (MachineParameter)commonServices.GetTableDataByName("machineParameter", readMacineParameterName);
                        if (readMacineParameterData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Read Machine Parameter Name"));
                            continue;
                        }
                        machineParameterRow.ReadMachineParameterId = readMacineParameterData.MachineParameterId;

                    }

                    if (reloadMachineParameterIdExist)
                    {
                        var reloadMacineParameterName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 31)]);

                        var reloadMacineParameterData = (MachineParameter)commonServices.GetTableDataByName("machineParameter", reloadMacineParameterName);
                        if (reloadMacineParameterData == null)
                        {
                            failedRecordCount++;
                            var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.NameDoesNotExist);
                            AddImportErrorMessage(dt, i, messageData.Data.Replace("Name", "Reload Machine Parameter Name"));
                            continue;
                        }
                        machineParameterRow.ReloadMachineParameterId = reloadMacineParameterData.MachineParameterId;

                    }

                    if (isBatchStartRequiredExist)
                    {
                        machineParameterRow.IsBatchStartRequired = GetBooleanValue(Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineParameterFormField), 32)]));
                    }



                    if (Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Success))
                    {

                        SaveData(formType, machineParameterRow);
                        succededRecordCount++;
                        commonServices.DeleteRowFromDataTable(dt, dt.Rows[i]["serialNumber"].ToString());
                        i = i - 1;
                    }
                    else
                    {
                        failedRecordCount++;
                        PostLicenseAction(formType);
                        var messageData = commonServices.GetMessageDetailsById((int)CVC.BusinessServices.Common.ClsConstants.MessageType.LicenseValidityExpired);
                        AddImportErrorMessage(dt, i, messageData.Data);
                        continue;
                    }



                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    PostLicenseAction(formType);
                    AddImportErrorMessage(dt, i, ex.Message);
                    continue;
                }


            }

            return Tuple.Create(succededRecordCount, failedRecordCount);

        }


        public void SaveData(string type, dynamic entity)
        {
            var data = GetEntity(type, entity);
            var connection = data.Item2;
            var request = data.Item1;
            var controller = data.Item3;
            /*  IDbConnection connection = null;
              SaveRequest<CityDetailsRow> request = null;
              if (type == "city")
              {
                  connection = SqlConnections.NewFor<CityDetailsRow>();
                  // SaveRequest<CityDetailsRow> cityDetailRow = new SaveRequest<CityDetailsRow>();
                  // cityDetailRow.Entity = entity;

                  // request = cityDetailRow;
                  request = dd(entity);
              }*/
            using (connection)
            {
                var fileName = string.Empty;
                var cacheData = clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileName);
                if (cacheData != null)
                {
                    fileName = (string)cacheData;
                }
                var fileExtension = fileName?.Split('.')[1];
                var sourceType = commonServices.GetFileType(fileExtension);
                var loggedUserIdCache = commonServices.GetCacheData(ClsCacheConfig.CacheKeys.LoggedUserId);

                request.Entity.RecordAddedSource = sourceType;
                //if ( type=="shift"|| type=="supplier"|| type=="cityDetails" || type=="user" || type == "protocol" || type== "pickListValue" || type=="supplier" || type=="machine" || type=="alarm" || type=="machineCommunication")
                //{
                //    request.Entity.CreatedDate = DateTime.Now;
                //    request.Entity.CreatedBy = loggedUserIdCache;
                //}
                using (UnitOfWork unitOfWork = new UnitOfWork(connection))
                {
                    var result = controller.Create(unitOfWork, request);
                    unitOfWork.Commit();
                }
            }

        }

        private Tuple<dynamic, IDbConnection, object> GetEntity(string type, dynamic entity)
        {
            IDbConnection connection = null;
            object request = null;
            object controllerName = null;

            switch (type)
            {
                case "cityDetails":
                    connection = SqlConnections.NewFor<CityDetailsRow>();
                    SaveRequest<CityDetailsRow> cityDetailRow = new SaveRequest<CityDetailsRow>();
                    cityDetailRow.Entity = entity;
                    request = cityDetailRow;
                    controllerName = new CityDetailsController();
                    break;

                case "role":
                    connection = SqlConnections.NewFor<RoleRow>();
                    SaveRequest<RoleRow> roleRow = new SaveRequest<RoleRow>();
                    roleRow.Entity = entity;
                    request = roleRow;
                    controllerName = new RoleController();
                    break;

                case "department":
                    connection = SqlConnections.NewFor<DepartmentRow>();
                    SaveRequest<DepartmentRow> departmentRow = new SaveRequest<DepartmentRow>();
                    departmentRow.Entity = entity;
                    request = departmentRow;
                    controllerName = new DepartmentController();
                    break;

                case "protocol":
                    connection = SqlConnections.NewFor<ProtocolRow>();
                    SaveRequest<ProtocolRow> protocolRow = new SaveRequest<ProtocolRow>();
                    protocolRow.Entity = entity;
                    request = protocolRow;
                    controllerName = new ProtocolController();
                    break;

                case "pickListValue":
                    connection = SqlConnections.NewFor<PickListValueRow>();
                    SaveRequest<PickListValueRow> pickListValueRow = new SaveRequest<PickListValueRow>();
                    pickListValueRow.Entity = entity;
                    request = pickListValueRow;
                    controllerName = new PickListValueController();
                    break;

                case "bottle":
                    connection = SqlConnections.NewFor<BottleRow>();
                    SaveRequest<BottleRow> bottleRow = new SaveRequest<BottleRow>();
                    bottleRow.Entity = entity;
                    request = bottleRow;
                    controllerName = new BottleController();
                    break;

                case "cap":
                    connection = SqlConnections.NewFor<CapRow>();
                    SaveRequest<CapRow> capRow = new SaveRequest<CapRow>();
                    capRow.Entity = entity;
                    request = capRow;
                    controllerName = new CapController();
                    break;

                case "cotton":
                    connection = SqlConnections.NewFor<CottonRow>();
                    SaveRequest<CottonRow> cottonRow = new SaveRequest<CottonRow>();
                    cottonRow.Entity = entity;
                    request = cottonRow;
                    controllerName = new CottonController();
                    break;

                case "desiccant":
                    connection = SqlConnections.NewFor<DesiccantRow>();
                    SaveRequest<DesiccantRow> desiccantRow = new SaveRequest<DesiccantRow>();
                    desiccantRow.Entity = entity;
                    request = desiccantRow;
                    controllerName = new DesiccantController();
                    break;

                case "outsert":
                    connection = SqlConnections.NewFor<OutsertRow>();
                    SaveRequest<OutsertRow> outsertRow = new SaveRequest<OutsertRow>();
                    outsertRow.Entity = entity;
                    request = outsertRow;
                    controllerName = new OutsertController();
                    break;

                case "label":
                    connection = SqlConnections.NewFor<LabelRow>();
                    SaveRequest<LabelRow> labelRow = new SaveRequest<LabelRow>();
                    labelRow.Entity = entity;
                    request = labelRow;
                    controllerName = new LabelController();
                    break;

                case "pack":
                    connection = SqlConnections.NewFor<PackRow>();
                    SaveRequest<PackRow> packRow = new SaveRequest<PackRow>();
                    packRow.Entity = entity;
                    request = packRow;
                    controllerName = new PackController();
                    break;

                case "machine":
                    connection = SqlConnections.NewFor<MachineRow>();
                    SaveRequest<MachineRow> machineRow = new SaveRequest<MachineRow>();
                    machineRow.Entity = entity;
                    request = machineRow;
                    controllerName = new MachineController();
                    break;

                case "alarm":
                    connection = SqlConnections.NewFor<AlarmRow>();
                    SaveRequest<AlarmRow> alarmRow = new SaveRequest<AlarmRow>();
                    alarmRow.Entity = entity;
                    request = alarmRow;
                    controllerName = new AlarmController();
                    break;

                case "supplier":
                    connection = SqlConnections.NewFor<SupplierRow>();
                    SaveRequest<SupplierRow> supplierRow = new SaveRequest<SupplierRow>();
                    supplierRow.Entity = entity;
                    request = supplierRow;
                    controllerName = new SupplierController();
                    break;

                case "shift":
                    connection = SqlConnections.NewFor<ShiftRow>();
                    SaveRequest<ShiftRow> shiftRow = new SaveRequest<ShiftRow>();
                    shiftRow.Entity = entity;
                    request = shiftRow;
                    controllerName = new ShiftController();
                    break;

                case "machineCommunication":
                    connection = SqlConnections.NewFor<MachineCommunicationRow>();
                    SaveRequest<MachineCommunicationRow> machineCommunicationRow = new SaveRequest<MachineCommunicationRow>();
                    machineCommunicationRow.Entity = entity;
                    request = machineCommunicationRow;
                    controllerName = new MachineCommunicationController();
                    break;

                case "ipcParameter":
                    connection = SqlConnections.NewFor<IpcParameterRow>();
                    SaveRequest<IpcParameterRow> ipcParameterRow = new SaveRequest<IpcParameterRow>();
                    ipcParameterRow.Entity = entity;
                    request = ipcParameterRow;
                    controllerName = new IpcParameterController();
                    break;

                case "machineParameter":
                    connection = SqlConnections.NewFor<MachineParameterRow>();
                    SaveRequest<MachineParameterRow> machineParameterRow = new SaveRequest<MachineParameterRow>();
                    machineParameterRow.Entity = entity;
                    request = machineParameterRow;
                    controllerName = new MachineParameterController();
                    break;

                case "tabletDetails":
                    connection = SqlConnections.NewFor<TabletDetailsRow>();
                    SaveRequest<TabletDetailsRow> tabletDetailsRow = new SaveRequest<TabletDetailsRow>();
                    tabletDetailsRow.Entity = entity;
                    request = tabletDetailsRow;
                    controllerName = new TabletDetailsController();
                    break;

                case "user":
                    connection = SqlConnections.NewFor<UserRow>();
                    SaveRequest<UserRow> userRow = new SaveRequest<UserRow>();
                    userRow.Entity = entity;
                    request = userRow;
                    controllerName = new UserController();
                    break;



            }
            return Tuple.Create(request, connection, controllerName);


        }

        public Tuple<int, int> CallImportData(string formType, DataTable dt)
        {
            Tuple<int, int> tpleResult = new Tuple<int, int>(0, 0);
            Type returnEnumType = null;
            switch (formType)
            {
                case "role":
                    tpleResult = ImportRoleData(dt, formType);
                    break;

                case "pack":
                    tpleResult = ImportPackData(dt, formType);
                    break;

                case "outsert":
                    tpleResult = ImportOutsertData(dt, formType);
                    break;

                case "label":
                    tpleResult = ImportLabelData(dt, formType);
                    break;

                case "endOfLine":
                    tpleResult = ImportLabelData(dt, formType);
                    break;

                case "desiccant":
                    tpleResult = ImportDesiccantData(dt, formType);
                    break;

                case "cotton":
                    tpleResult = ImportCottonData(dt, formType);
                    break;

                case "cap":
                    tpleResult = ImportCapData(dt, formType);
                    break;

                case "bottle":
                    tpleResult = ImportBottleData(dt, formType);
                    break;

                case "machineParameter":
                    tpleResult = ImportMachineParameterData(dt, formType);
                    break;

                case "machine":
                    tpleResult = ImportMachineData(dt, formType);
                    break;

                case "alarm":
                    tpleResult = ImportAlarmData(dt, formType);
                    break;

                case "protocol":
                    tpleResult = ImportProtocolData(dt, formType);
                    break;

                case "machineCommunication":
                    tpleResult = ImportMachineCommunicationData(dt, formType);
                    break;

                case "ipcParameter":
                    tpleResult = ImportIpcParameterData(dt, formType);
                    break;

                case "supplier":
                    tpleResult = ImportSupplierData(dt, formType);
                    break;

                case "shift":
                    tpleResult = ImportShiftData(dt, formType);
                    break;

                case "department":
                    tpleResult = ImportDepartmentData(dt, formType);
                    break;

                case "cityDetails":
                    tpleResult = ImportCityData(dt, formType);
                    break;

                case "userManagement":
                    tpleResult = ImportUserData(dt, formType);
                    break;

                case "pickListValue":
                    tpleResult = ImportPickListValueData(dt, formType);
                    break;

                case "tabletDetails":
                    tpleResult = ImportTabletDetailsData(dt, formType);
                    break;


            }
            return tpleResult;
        }

        private Boolean? GetBooleanValue(string value)
        {
            return value.ToLower() == "yes" ? true : value.ToLower() == "no" ? false : (Boolean?)null;
        }

        private int? GetNumberValue(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? (int?)null : value == "NULL" ? (int?)null : Convert.ToInt32(value);
        }

        private Int64? GetInt64NumberValue(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? (Int64?)null : value == "NULL" ? (Int64?)null : Convert.ToInt64(value);
        }

        private void AddImportErrorMessage(DataTable dt, int rowIndex, string errorMessage)
        {
            dt.Rows[rowIndex]["Error Message"] = errorMessage;
            dt.AcceptChanges();
        }

        public void PostLicenseAction(string formType)
        {

            Logic.PostLicenseAction(formType, "Create", CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Failure);
        }













































































    }
}