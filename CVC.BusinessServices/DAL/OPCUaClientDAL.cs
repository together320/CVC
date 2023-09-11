using CVC.BusinessServices.Common;
using CVC.Data.EDMX;
using CVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CVC.BusinessServices.DAL
{
    public class OPCUaClientDAL
    {
        ClsCacheConfig clsCacheConfig = new ClsCacheConfig();
        public object SaveAddressSpace(AddressSpaceModel addressSpaceModel)
        {
            int? userId = null;

            var cachedLoggedUserId = clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.LoggedUserId);
            if (cachedLoggedUserId != null)
            {
                userId = (int)cachedLoggedUserId;
            }
            try
            {
                bool isFirstRecordOfMachineParameter = true;
                bool isFirstRecordOfIpcParameter = true;
              

                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    foreach (var item in addressSpaceModel.nodeModelList)
                    {
                        var machineParameterDetails = addressSpaceModel.machineParameterList.FirstOrDefault(mpl => mpl.NodeId == item.nodeId);

                        if (machineParameterDetails != null)
                        {
                            if (machineParameterDetails.MachineParameterId > 0)
                            {
                                var ipcParameter = new IPCParameter
                                {
                                    MachineId = addressSpaceModel.machineId,
                                    IPCParameterName = item.displayName,
                                    MachineParameterId = machineParameterDetails.MachineParameterId,
                                    NodeId = item.nodeId,
                                    AttributeId = 13,
                                    StatusId = (int)CVC.BusinessServices.Common.ClsConstants.StatusType.Active

                                };

                                cvcEntities.IPCParameters.Add(ipcParameter);
                                cvcEntities.SaveChanges();
                                if (isFirstRecordOfIpcParameter)
                                {
                                    CommonServices commonServices = new CommonServices();
                                    commonServices.AddToAuditLog("Ipc Parameter Added by Opc Ua Client Address Space", "Address Space", "", MachineId: addressSpaceModel.machineId, UserId: userId);
                                    isFirstRecordOfIpcParameter = false;
                                }
                            }
                            else
                            {
                               
                                var machineParameter = new MachineParameter
                                {
                                    MachineId = addressSpaceModel.machineId,
                                    ParameterName = item.displayName,
                                    DataTypeId = item.dataTypeId,
                                    IsRead=item.isRead,
                                    IsWrite=item.isWrite,
                                    StatusId = (int)CVC.BusinessServices.Common.ClsConstants.StatusType.Active

                                };

                                cvcEntities.MachineParameters.Add(machineParameter);
                                cvcEntities.SaveChanges();

                                if (isFirstRecordOfMachineParameter)
                                {
                                    CommonServices commonServices = new CommonServices();
                                    commonServices.AddToAuditLog("New Machine Parameter Added by Opc Ua Client Address Space", "Address Space", "", MachineId: addressSpaceModel.machineId, UserId: userId);
                                    isFirstRecordOfMachineParameter = false;
                                }

                                if (machineParameter.MachineParameterId > 0)
                                {
                                    var ipcParameter = new IPCParameter
                                    {
                                        MachineId = addressSpaceModel.machineId,
                                        IPCParameterName =item.displayName,
                                        MachineParameterId = machineParameter.MachineParameterId,
                                        NodeId = item.nodeId,
                                        AttributeId = 13,
                                        StatusId = (int)CVC.BusinessServices.Common.ClsConstants.StatusType.Active
                                    };

                                    cvcEntities.IPCParameters.Add(ipcParameter);
                                    cvcEntities.SaveChanges();

                                    if (isFirstRecordOfIpcParameter)
                                    {
                                        CommonServices commonServices = new CommonServices();
                                        commonServices.AddToAuditLog("Ipc Parameter Added by Opc Ua Client Address Space", "Address Space", "", MachineId: addressSpaceModel.machineId, UserId: userId);
                                        isFirstRecordOfIpcParameter = false;
                                    }

                                }

                            }

                        }

                    }

                }
                return new { status = true, message = "Data saved successfully" };
            }
            catch (System.Exception ex)
            {
                  CommonServices commonServices = new CommonServices();
                commonServices.AddToAuditLog("Error while adding Machine Parameter/Ipc Parameterby Opc Ua Client Address Space", "Address Space", "", MachineId: addressSpaceModel.machineId, UserId: userId);

                return new { status = false, message = "Error while saving data" };

            }
        }


        public bool CheckNodeExist(int machineId,string nodeId)
        {
            using (CVCEntities cVCEntities = new CVCEntities())
            {
                return cVCEntities.IPCParameters.Any(ipc => ipc.MachineId == machineId && ipc.NodeId == nodeId);
            }
        }

        public int GetMachineParameterIdByNode(int machineId, string nodeId)
        {
            using (CVCEntities cVCEntities = new CVCEntities())
            {
                return cVCEntities?.IPCParameters?.FirstOrDefault(ipc => ipc.MachineId == machineId && ipc.NodeId == nodeId)?.MachineParameterId??-1;
            }
        }

    }
}
