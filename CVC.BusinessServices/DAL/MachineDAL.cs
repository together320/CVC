using CVC.BusinessServices.Common;
using CVC.Data.EDMX;
using CVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using bs = CVC.BusinessServices.Common;

namespace CVC.BusinessServices.DAL
{
    public class MachineDAL
    {
        Common.CommonServices commonServices;
        bs.CommonServices bsCommonServices = new bs.CommonServices();

        public MachineDAL()
        {
            commonServices = new Common.CommonServices();
        }

        public object SaveMachineDetails(MachineDetails machineDetails)
        {
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var isExist = cvcEntities.Machines.FirstOrDefault(tt => tt.MachineName.ToLower() == machineDetails.MachineName.ToLower());

                    if (isExist != null)
                    {
                        return new { status = false, message = "Machine name already exist" };
                    }

                    var isExistSequence = cvcEntities.Machines.FirstOrDefault(tt => tt.MachineSequence == machineDetails.MachineSequence);

                    if (isExistSequence != null)
                    {
                        return new { status = false, message = "Machine sequence already exist" };
                    }

                    var loggedUserIdCache = commonServices.GetCacheData(ClsCacheConfig.CacheKeys.LoggedUserId);
                    var machine = new Machine
                    {
                        MachineName = machineDetails.MachineName,
                        MachineSequence = machineDetails.MachineSequence,
                        AccessIPAddress = machineDetails.AccessIPAddress,
                        Description = machineDetails.Description,
                        ModelNumber = machineDetails.ModelNumber,
                        SerialNumber = machineDetails.SerialNumber,
                        Make = machineDetails.Make,
                        Year = machineDetails.Year,
                        PlcMake = machineDetails.PlcMake,
                        PlcModelNumber = machineDetails.PlcModelNumber,
                        PlcSerialNumber = machineDetails.PlcSerialNumber,
                        PLCAddress = machineDetails.PLCAddress,
                        StatusId = machineDetails.StatusId,
                        CreatedDate=DateTime.Now,
                        CreatedBy=loggedUserIdCache
                    };
                    cvcEntities.Machines.Add(machine);
                    cvcEntities.SaveChanges();
                    AddAuditLog(machineDetails);

                }
                return new { status = true, message = "Data saved successfully" };
            }
            catch (System.Exception ex)
            {
                return new { status = false, message = "Error while saving data" };

            }
        }

        public object UpdateMachineDetails(MachineDetails machineDetails)
        {
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var isExist = cvcEntities.Machines.FirstOrDefault(tt => tt.MachineName.ToLower() == machineDetails.MachineName.ToLower() && tt.MachineId != machineDetails.MachineId);

                    if (isExist != null)
                    {
                        return new { status = false, message = "Machine name already exist" };
                    }

                    var isExistMachineSequence = cvcEntities.Machines.FirstOrDefault(tt => tt.MachineSequence == machineDetails.MachineSequence && tt.MachineId != machineDetails.MachineId);

                    if (isExistMachineSequence != null)
                    {
                        return new { status = false, message = "Machine sequence already exist" };
                    }
                    var loggedUserIdCache = commonServices.GetCacheData(ClsCacheConfig.CacheKeys.LoggedUserId);

                    var machine = cvcEntities.Machines.SingleOrDefault(m => m.MachineId == machineDetails.MachineId);
                    machineDetails.OldAccessIPAddress = machine.AccessIPAddress;
                    machineDetails.OldDescription = machine.Description;
                    machineDetails.OldMachineName = machine.MachineName;
                    machineDetails.OldMachineSequence = machine.MachineSequence;
                    machineDetails.OldMake = machine.Make;
                    machineDetails.OldModelNumber = machine.ModelNumber;
                    machineDetails.OldPLCAddress = machine.PLCAddress;
                    machineDetails.OldPlcMake = machine.PlcMake;
                    machineDetails.OldPlcModelNumber = machine.PlcModelNumber;
                    machineDetails.OldPlcSerialNumber = machine.PlcSerialNumber;
                    machineDetails.OldSerialNumber = machine.SerialNumber;
                    machineDetails.OldStatusId =(int) machine.StatusId;
                    machineDetails.OldYear = machine.Year;

                    machine.MachineName = machineDetails.MachineName;
                    machine.MachineSequence = machineDetails.MachineSequence;
                    machine.AccessIPAddress = machineDetails.AccessIPAddress;
                    machine.Description = machineDetails.Description;
                    machine.ModelNumber = machineDetails.ModelNumber;
                    machine.SerialNumber = machineDetails.SerialNumber;
                    machine.Make = machineDetails.Make;
                    machine.Year = machineDetails.Year;
                    machine.PlcMake = machineDetails.PlcMake;
                    machine.PlcModelNumber = machineDetails.PlcModelNumber;
                    machine.PlcSerialNumber = machineDetails.PlcSerialNumber;
                    machine.PLCAddress = machineDetails.PLCAddress;
                    machine.StatusId = machineDetails.StatusId;
                    machine.UpdatedBy = loggedUserIdCache;
                    machine.UpdatedDate = DateTime.Now;
                    cvcEntities.SaveChanges();
                    AddAuditLog(machineDetails);


                    return new { status = true, message = "Data saved successfully" };
                }
            }
            catch (System.Exception ex)
            {
                return new { status = false, message = "Error while saving data" };

            }
        }

        public List<MachineTerminalMapping> GetMachineTerminalMappedData(MachineTerminalMapping machineTerminalMapping)
        {
            var listMachineTerminalMapping = new List<MachineTerminalMapping>();
            try
            {
                using (CVCEntities cVCEntities = new CVCEntities())
                {
                    var results = cVCEntities.TerminalMachineMappings.Where(mtm => mtm.MachineId == machineTerminalMapping.MachineId).ToList();

                    listMachineTerminalMapping = results.Select((item, index) => new MachineTerminalMapping
                    {
                        Id = index + 1,
                        TerminalName = item.MasterTerminal.TerminalName,
                        MacAddress = item.MasterTerminal.MacAddress,
                        IsRead = item.IsRead,
                        IsWrite = item.IsWrite,
                    }).ToList();
                    return listMachineTerminalMapping;
                }
            }
            catch (System.Exception ex)
            {
                return listMachineTerminalMapping;
            }
        }

        public List<MachineUserMapping> GetMachineUserMappingData(MachineUserMapping machineUserMapping)
        {
            var listMachineUserMapping = new List<MachineUserMapping>();
            try
            {
                using (CVCEntities cVCEntities = new CVCEntities())
                {
                    var results = cVCEntities.Users.ToList();

                    listMachineUserMapping = results.Select((item, index) => new MachineUserMapping
                    {
                        Id = index + 1,
                        UserId = item.UserId,
                        UserName = item.Username,
                        Role = item.Role?.RoleName??"NA",
                        Status = item.Status.StatusName,
                        IsSelected=cVCEntities.UserMachineMappings.FirstOrDefault(umm=>umm.MachineId==machineUserMapping.MachineId && umm.UserId==item.UserId)!=null?true:false
                    }).ToList();
                    return listMachineUserMapping;
                }
            }
            catch (System.Exception ex)
            {
                return listMachineUserMapping;
            }
        }

        public List<MachineUserMapping> GetMachineUserMappedData(MachineUserMapping machineUserMapping)
        {
            var listMachineUserMapping = new List<MachineUserMapping>();
            try
            {
                using (CVCEntities cVCEntities = new CVCEntities())
                {
                    var results = cVCEntities.UserMachineMappings.Where(mtm => mtm.MachineId == machineUserMapping.MachineId).ToList();

                    listMachineUserMapping = results.Select((item, index) => new MachineUserMapping
                    {
                        Id = index + 1,
                        UserName = item.User1.Username,
                        Role = item.User1.Role.RoleName,
                        Status = item.User.Status.StatusName,
                    }).ToList();
                    return listMachineUserMapping;
                }
            }
            catch (System.Exception ex)
            {
                return listMachineUserMapping;
            }
        }
      
        #region Save Machine User Mapping
        public object SaveMachineUerMapping(MachineUserMapping userMachineMapping)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                using (System.Data.Entity.DbContextTransaction dbTran = cvcEntities.Database.BeginTransaction())
                {
                    try
                    {

                        var userMachineMappingData = cvcEntities.UserMachineMappings.Where(mt => mt.MachineId == userMachineMapping.MachineId).ToList();
                        if (userMachineMappingData.Any())
                        {
                            foreach (var item in userMachineMappingData)
                            {
                                cvcEntities.Entry(item).State = EntityState.Deleted;
                                cvcEntities.SaveChanges();
                            }
                        }

                        int? userId = null;
                        if (HttpContext.Current.Session["CVCUserId"] != null)
                        {
                            userId = Convert.ToInt32(HttpContext.Current.Session["CVCUserId"].ToString());
                        }
                        foreach (var item in userMachineMapping.SelectedItemList)
                        {
                            var userMachineMappingEntity = new UserMachineMapping()
                            {
                                MachineId = userMachineMapping.MachineId,
                                UserId = Convert.ToInt32(item),
                                CreatedOn = DateTime.Now,
                                CreatedBy = userId
                            };
                            cvcEntities.UserMachineMappings.Add(userMachineMappingEntity);
                            cvcEntities.SaveChanges();

                          //  var terminalDetails = cvcEntities.MasterTerminals.FirstOrDefault(a => a.ID == getTerminalId);
                          //  new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Machine Terminal Mapping", "Machine Customization", "Terminal View", terminalDetails.TerminalName + "-" + "IsWrite", NewValue: (bool)terminalMachineMapping.IsWrite ? "True" : "False", MachineId: machineTerminalMapping.MachineId);
                          //  new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Machine Terminal Mapping", "Machine Customization", "Terminal View", terminalDetails.TerminalName + "-" + "IsRead", NewValue: (bool)terminalMachineMapping.IsRead ? "True" : "False", MachineId: machineTerminalMapping.MachineId);
                        }

                        
                        dbTran.Commit();
                        return new { status = true, message = "Data saved successfully" };

                    }
                    catch (System.Exception ex)
                    {
                        dbTran.Rollback();
                        return new { status = false, message = "Error while saving data" };

                    }

                }


            }
        }
        #endregion

        public List<MachineUserMapping> GetMachinesByUserId(MachineUserMapping machineUserMapping)

        {
            var listMachineUserMapping = new List<MachineUserMapping>();
            try
            {
                using (CVCEntities cVCEntities = new CVCEntities())
                {
                    var results = cVCEntities.UserMachineMappings.Where(mtm => mtm.UserId == machineUserMapping.UserId ).ToList();

                    listMachineUserMapping = results.Select((item, index) => new MachineUserMapping
                    {
                        Id = index + 1,
                        UserName = item?.User1?.FirstName + " " + item?.User1?.LastName,
                        Role = item?.User1?.Role?.RoleName,
                        Status = item?.User?.Status?.StatusName,
                        ModuleId = (cVCEntities.Modules.FirstOrDefault(m => m.MachineId == item.MachineId && m.StatusId==1)?.ModuleId ?? 0)

                    }).ToList();
                    return listMachineUserMapping;
                }
            }
            catch (System.Exception ex)
            {
                return listMachineUserMapping;
            }
        }

        private void AddAuditLog(MachineDetails machineDetails)
        {
            var propertyInfos = machineDetails.GetType().GetProperties();
            int userId = HttpContext.Current.Session["CVCUserId"] != null ? Convert.ToInt32(HttpContext.Current.Session["CVCUserId"].ToString()) : 0;
            var userDetails = commonServices.GetUserDetailsByUserId(userId);
            List<AuditLog> lstAuditLog = new List<AuditLog>();
            foreach (PropertyInfo pInfo in propertyInfos)
            {
                string propertyName = pInfo.Name;
                var propertyValue = (pInfo.GetValue(machineDetails, null));
                var oldValue = "";
                if (machineDetails.MachineId > 0)
                {
                    if (propertyName == "MachineName")
                    {
                        oldValue = machineDetails.OldMachineName;
                    }
                    if (propertyName == "MachineSequence")
                    {
                        oldValue = machineDetails.OldMachineSequence!=null ? (Convert.ToString( machineDetails.OldMachineSequence)):null;

                    }
                    if (propertyName == "AccessIPAddress")
                    {
                        oldValue = machineDetails.OldAccessIPAddress;
                    }
                    if (propertyName == "Description")
                    {
                        oldValue = machineDetails.OldDescription;
                    }
                    if (propertyName == "ModelNumber")
                    {
                        oldValue = machineDetails.OldModelNumber;
                    }
                    if (propertyName == "SerialNumber")
                    {
                        oldValue = machineDetails.OldSerialNumber;
                    }
                    if (propertyName == "Make")
                    {
                        oldValue = machineDetails.OldMake;
                    }
                    if (propertyName == "Year")
                    {
                        oldValue = machineDetails.OldYear!= null ? (Convert.ToString(machineDetails.OldYear)): null;
                    }

                    if (propertyName == "PlcMake")
                    {
                        oldValue = machineDetails.OldPlcMake;
                     }
                    if (propertyName == "PlcModelNumber")
                    {
                        oldValue = machineDetails.OldPlcModelNumber;
                    }
                    if (propertyName == "PlcSerialNumber")
                    {
                        oldValue = machineDetails.OldPlcSerialNumber;
                    }
                    if (propertyName == "PLCAddress")
                    {
                        oldValue = machineDetails.OldPLCAddress;
                    }

                    if (propertyName == "StatusId")
                    {
                        oldValue = machineDetails.OldStatusId == 1 ? "Active" : "In-Active";
                       // propertyName = "ActiveStatus";
                       
                    }


                }

                if (propertyName == "MachineName" || propertyName == "MachineSequence" || propertyName == "AccessIPAddress" || propertyName == "Description" || propertyName == "ModelNumber" || propertyName == "SerialNumber" || propertyName == "Make" || propertyName == "Year" || propertyName == "PlcMake" || propertyName == "PlcModelNumber" || propertyName == "PlcSerialNumber" || propertyName == "PLCAddress" || propertyName == "StatusId")
                {
                  
                    if (machineDetails.MachineId > 0)
                    {

                        if (propertyName == "StatusId")
                        {
                            oldValue = machineDetails.OldStatusId == 1 ? "Active" : "In-Active";
                            propertyName = "ActiveStatus";
                            propertyValue = machineDetails.StatusId == 1 ? "Active" : "In-Active";


                        }
                    }
                    else
                    {
                        if (propertyName == "StatusId")
                        {
                            propertyValue = machineDetails.StatusId == 1 ? "Active" : "In-Active";
                            propertyName = "ActiveStatus";

                        }

                    }

                    AuditLog auditLog = new AuditLog
                    {
                        Action = "Add Machine",
                        Module = "Machine Customization",
                        Page = "Terminal View",
                        FieldName = propertyName,
                        OldValue = oldValue,
                        NewValue = Convert.ToString(propertyValue),
                        User = userDetails,
                        // UserName= userDetails.Username,
                        // UserId = Convert.ToInt32(HttpContext.Current.Session["CVCUserId"].ToString()),
                    };
                    lstAuditLog.Add(auditLog);

                }

            }
            commonServices.AddAuditLog(lstAuditLog);
        }


    }
}
