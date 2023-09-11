using CVC.Data.EDMX;
using CVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace CVC.Repository
{
    public class TerminalRepository
    {
        CVCEntities cvcEntities;

        public TerminalRepository()
        {
            cvcEntities = new CVCEntities();
        }

        public TerminalMappingVM GetMachine()
        {
            var data = new TerminalMappingVM();
            data.GetMachines = new List<MachineModel>();

            var listing = from m in cvcEntities.Machines
                          select new MachineModel
                          {
                              ID = m.MachineId,
                              MachineName = m.MachineName
                          };
            data.GetMachines = listing.ToList();
            return data;
        }

        #region Check Is Exist Terminal
        public bool IsExistTerminal(string TerminalName, int? TerminalId)
        {
            if (TerminalId == null)
            {
                return cvcEntities.MasterTerminals.Any(x => x.TerminalName == TerminalName);
            }
            else
            {
                return cvcEntities.MasterTerminals.Any(x => x.TerminalName == TerminalName && x.ID != TerminalId);
            }

        }
        #endregion

        #region Check Is Exist Mac Address
        public bool IsExistMacAddress(string MacAddress, int? TerminalId)
        {
            if (TerminalId == null)
            {
                return cvcEntities.MasterTerminals.Any(x => x.MacAddress == MacAddress);

            }
            else
            {
                return cvcEntities.MasterTerminals.Any(x => x.MacAddress == MacAddress && x.ID != TerminalId);
            }
        }
        #endregion

        #region Check Valid Mac Address
        public bool IsValidMacAddress(string input)
        {
            var alphabatesCount = Regex.Matches(input, @"[a-fA-Z]").Count;
            var numberCount = Regex.Matches(input, @"[0-9]").Count;
            if (alphabatesCount > 0 && numberCount > 0)
            {
                return Regex.IsMatch(input, "^([a-fA-F])[a-fA-F0-9-]*$");
            }
            else if (alphabatesCount == 0)
            {
                return Regex.IsMatch(input, "^[0-9-]*$");
            }
            else if (numberCount == 0)
            {
                return Regex.IsMatch(input, "^([a-fA-F])[a-fA-F-]*$");
            }
            return false;

        }
        #endregion

        #region Save Machine Terminal Mapping
        public object SaveMachineTerminalMapping(MachineTerminalMapping machineTerminalMapping)
        {
            using (CVCEntities cVCEntities = new CVCEntities())
            {
                using (System.Data.Entity.DbContextTransaction dbTran = cVCEntities.Database.BeginTransaction())
                {
                    try
                    {
                        var getAllTerminals = GetMachineTerminalMappingData(machineTerminalMapping.MachineId);

                        var terminalMachineMappingData = cvcEntities.TerminalMachineMappings.Where(mt => mt.MachineId == machineTerminalMapping.MachineId).ToList();
                        if (terminalMachineMappingData.Any())
                        {
                            foreach (var item in terminalMachineMappingData)
                            {
                                cvcEntities.Entry(item).State = EntityState.Deleted;
                                cvcEntities.SaveChanges();
                            }
                        }

                        var isWriteCount = 0;
                        var terminalId = 0;
                        var writeTerminalId = 0;
                        foreach (var item in machineTerminalMapping.SelectedItemList)
                        {
                            terminalId = Convert.ToInt32(item);
                            var isWrite = cvcEntities.MasterTerminals.Where(tm => tm.ID == terminalId).FirstOrDefault().TerminalType.IsWrite;
                            if (isWrite)
                            {
                                writeTerminalId = terminalId;
                                isWriteCount++;
                            }
                        }

                        if (isWriteCount > 1)
                        {
                            return new { status = false, message = "Only one Read Write terminal allowed per machine" };

                        }
                        else if (isWriteCount == 1)
                        {
                            var chkAlreadyMapped = cvcEntities.TerminalMachineMappings.Where(mtm => mtm.TerminalId == writeTerminalId && mtm.IsWrite == true).FirstOrDefault();
                            if (chkAlreadyMapped != null)
                            {
                                return new { status = false, message = "This terminal already mapped to another machine" };
                            }
                        }
                        int? userId = null;
                        if (HttpContext.Current.Session["CVCUserId"] != null)
                        {
                            userId = Convert.ToInt32(HttpContext.Current.Session["CVCUserId"].ToString());
                        }
                        foreach (var item in machineTerminalMapping.SelectedItemList)
                        {
                            var getTerminalId= Convert.ToInt32(item);
                            var isWrite = false;
                            if(getTerminalId==writeTerminalId)
                            {
                                isWrite = true;
                            }
                            var terminalMachineMapping = new TerminalMachineMapping()
                            {
                                MachineId = machineTerminalMapping.MachineId,
                                TerminalId = Convert.ToInt32(item),
                                IsRead = true,
                                IsWrite = isWrite,
                                CreatedOn = DateTime.Now,
                                CreatedBy = userId
                            };
                            cVCEntities.TerminalMachineMappings.Add(terminalMachineMapping);
                            cVCEntities.SaveChanges();

                            var terminalDetails = cvcEntities.MasterTerminals.FirstOrDefault(a => a.ID == getTerminalId);
                            new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Machine Terminal Mapping", "Machine Customization", "Terminal View", terminalDetails.TerminalName + "-" + "IsWrite", NewValue: (bool)terminalMachineMapping.IsWrite ? "True" : "False", MachineId: machineTerminalMapping.MachineId);
                            new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Machine Terminal Mapping", "Machine Customization", "Terminal View", terminalDetails.TerminalName + "-" + "IsRead", NewValue: (bool)terminalMachineMapping.IsRead ? "True" : "False", MachineId: machineTerminalMapping.MachineId);
                        }

                        //if (getAllTerminals.Count > 0)
                        //{
                        //    foreach (var item in getAllTerminals)
                        //    {
                        //        var writeTerminalId = 0;
                        //        var isWrite = false;
                        //        var isRead = false;
                        //        if (machineTerminalMapping.WriteArray != null)
                        //        {
                        //            writeTerminalId = Convert.ToInt32(machineTerminalMapping.WriteArray[0]);
                        //        }

                        //        if (writeTerminalId == item.TerminalId)
                        //        {
                        //            isWrite = true;
                        //        }

                        //        if (machineTerminalMapping.ReadArray != null)
                        //        {
                        //            isRead = Array.Exists(machineTerminalMapping.ReadArray, E => E == item.TerminalId.ToString());
                        //        }
                        //        var terminalMachineMapping = new TerminalMachineMapping()
                        //        {
                        //            MachineId = machineTerminalMapping.MachineId,
                        //            TerminalId = Convert.ToInt32(item.TerminalId),
                        //            IsRead = isRead,
                        //            IsWrite = isWrite,
                        //            CreatedOn = DateTime.Now,
                        //            CreatedBy = Convert.ToInt32(HttpContext.Current.Session["CVCUserId"].ToString())
                        //        };
                        //        cVCEntities.TerminalMachineMappings.Add(terminalMachineMapping);
                        //        cVCEntities.SaveChanges();

                        //        var terminalId = Convert.ToInt32(item.TerminalId);
                        //        var terminalDetails = cvcEntities.MasterTerminals.FirstOrDefault(a => a.ID == terminalId);
                        //        new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Machine Terminal Mapping", "Machine Customization", "Terminal View", terminalDetails.TerminalName + "-" + "IsWrite", NewValue: (bool)terminalMachineMapping.IsWrite ? "True" : "False", MachineId: machineTerminalMapping.MachineId);
                        //        new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Machine Terminal Mapping", "Machine Customization", "Terminal View", terminalDetails.TerminalName + "-" + "IsRead", NewValue: (bool)terminalMachineMapping.IsRead ? "True" : "False", MachineId: machineTerminalMapping.MachineId);

                        //    }

                        //    dbTran.Commit();
                        //}
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

        #region Get Machine Terminal Mapping Data
        public List<MachineTerminalMapping> GetMachineTerminalMappingData(int MachineId)
        {
            var listMachineTerminalMapping = new List<MachineTerminalMapping>();
            try
            {
                using (CVCEntities cVCEntities = new CVCEntities())
                {


                    //var results = (from mt in cVCEntities.MasterTerminals
                    //               where mt.IsActive && !(cVCEntities.TerminalMachineMappings.Any(tmm => tmm.TerminalId == mt.ID && tmm.IsWrite == true && tmm.MachineId != MachineId))
                    //               select mt).ToList();

                    var results = (from mt in cVCEntities.MasterTerminals
                                   where mt.IsActive
                                   select mt).ToList();



                    listMachineTerminalMapping = results.Select((item, index) => new MachineTerminalMapping
                    {
                        Id = index + 1,
                        TerminalId = item.ID,
                        TerminalName = item.TerminalName,
                        MacAddress = item.MacAddress,
                        TerminalType = item.TerminalType.TerminalTypeName,
                        IsDisableWrite = cVCEntities.TerminalMachineMappings.Any(tmm => tmm.TerminalId == item.ID && tmm.IsWrite == true && tmm.MachineId != MachineId),
                        IsSelected= cvcEntities.TerminalMachineMappings.FirstOrDefault(tmm => tmm.MachineId == MachineId && tmm.TerminalId == item.ID)!=null?true:false,
                        IsWrite=item.TerminalType.IsWrite
                       // IsWrite = cvcEntities.ter.FirstOrDefault(tmm => tmm.MachineId == MachineId && tmm.TerminalId == a.ID)?.IsWrite ?? false,
                        // IsDisableWrite = cVCEntities.TerminalMachineMappings.Any(tmm => tmm.TerminalId == a.ID && tmm.IsWrite == true && tmm.MachineId != MachineId)
                    }).ToList();
                    return listMachineTerminalMapping;
                }
            }
            catch (System.Exception ex)
            {
                return listMachineTerminalMapping;
            }
        }
        #endregion

        #region Get Machine Terminal Mapped Data
        public List<MachineTerminalMapping> GetMachineTerminalMappedData(int MachineId)
        {
            var listMachineTerminalMapping = new List<MachineTerminalMapping>();
            try
            {
                using (CVCEntities cVCEntities = new CVCEntities())
                {

                    var results = (from mt in cVCEntities.TerminalMachineMappings
                                   where mt.MachineId==MachineId
                                   select mt).ToList();



                    listMachineTerminalMapping = results.Select((item, index) => new MachineTerminalMapping
                    {
                        Id = index + 1,
                        TerminalName = item.MasterTerminal.TerminalName,
                        MacAddress = item.MasterTerminal.MacAddress,
                        TerminalType = item.MasterTerminal.TerminalType.TerminalTypeName,
                        IsRead = item.IsRead,
                        IsWrite = item.IsWrite
                        // IsRead = cvcEntities.TerminalMachineMappings.FirstOrDefault(tmm => tmm.MachineId == MachineId && tmm.TerminalId == a.ID)?.IsRead ?? false,
                        // IsWrite = cvcEntities.TerminalMachineMappings.FirstOrDefault(tmm => tmm.MachineId == MachineId && tmm.TerminalId == a.ID)?.IsWrite ?? false,
                        // IsDisableWrite = cVCEntities.TerminalMachineMappings.Any(tmm => tmm.TerminalId == a.ID && tmm.IsWrite == true && tmm.MachineId != MachineId)
                    }).ToList();
                    return listMachineTerminalMapping;
                }
            }
            catch (System.Exception ex)
            {
                return listMachineTerminalMapping;
            }
        }
        #endregion

        public List<TerminalTypeViewModel> GetAllTerminalType()
        {
            var lstterminalTypeViewModel = new List<TerminalTypeViewModel>();
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var terminalTypes = cvcEntities.TerminalTypes.ToList();

                    lstterminalTypeViewModel = terminalTypes.Select((item, index) => new TerminalTypeViewModel
                    {
                        Id = index + 1,
                        TerminalTypeId = item.TerminalTypeId,
                        TerminalTypeName = item.TerminalTypeName,
                        Description = item.Description,
                        IsActive = item.IsActive,
                        IsRead = item.IsRead,
                        IsWrite = item.IsWrite

                    }).ToList();
                }
                return lstterminalTypeViewModel;
            }
            catch (System.Exception ex)
            {
                return lstterminalTypeViewModel;
            }
        }


        //public string validata()
        //{
        //    string macAddresses = "";

        //    foreach (System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
        //    {
        //        if (nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
        //        {
        //            macAddresses += nic.GetPhysicalAddress().ToString();
        //            break;
        //        }
        //    }
        //    return macAddresses;
        //}
    }
}