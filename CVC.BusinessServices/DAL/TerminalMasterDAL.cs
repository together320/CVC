 using CVC.BusinessServices.Interface;
using CVC.Data.EDMX;
using CVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;


namespace CVC.BusinessServices.DAL
{
    public class TerminalMasterDAL
    {
        Common.CommonServices commonServices;
        public TerminalMasterDAL()
        {
            commonServices = new Common.CommonServices();
        }

        public List<MasterTerminlsModel> GetAllTerminal()
        {
            var lstterminalViewModel = new List<MasterTerminlsModel>();
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var terminal = cvcEntities.MasterTerminals.ToList();

                    lstterminalViewModel = terminal.Select((item, index) => new MasterTerminlsModel
                    {
                       Index=index+1,
                       ID=item.ID,
                       TerminalName=item.TerminalName,
                       MacAddress=item.MacAddress,
                       TerminalType=item.TerminalType.TerminalTypeName,
                       IsActive=item.IsActive?1:2,

                    }).ToList();
                }
                return lstterminalViewModel;
            }
            catch (System.Exception ex)
            {
                return lstterminalViewModel;
            }
        }

        public List<TerminalTypeViewModel> GetAllActiveTerminalType(TerminalTypeViewModel terminalTypeViewModel)
        {
            var lstterminalTypeViewModel = new List<TerminalTypeViewModel>();
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var terminalTypes = cvcEntities.TerminalTypes.Where(tt => tt.IsActive == terminalTypeViewModel.IsActive).ToList();

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


        public MasterTerminlsModel GetTerminal(MasterTerminlsModel masterTerminlsModel)
        {
            var terminlsModel = new MasterTerminlsModel();
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var terminalDetails = cvcEntities.MasterTerminals.FirstOrDefault(t => t.ID == masterTerminlsModel.ID);

                    terminlsModel.ID = terminalDetails.ID;
                    terminlsModel.TerminalName = terminalDetails.TerminalName;
                    terminlsModel.MacAddress = terminalDetails.MacAddress;
                    terminlsModel.SerialNumber = terminalDetails.SerialNumber;
                    terminlsModel.ModelNumber = terminalDetails.ModelNumber;
                    terminlsModel.TerminalTypeId =(int) terminalDetails.TerminalTypeId;
                    terminlsModel.IsActive = terminalDetails.IsActive?1:2;

                }
                return terminlsModel;
            }
            catch (System.Exception ex)
            {
                return terminlsModel;
            }
        }

        public object SaveTerminalType(MasterTerminlsModel masterTerminlsModel)
        {
            try
            {
                if (!string.IsNullOrEmpty(masterTerminlsModel.MacAddress))
                {
                    if (masterTerminlsModel.MacAddress.Length > 17)
                    {
                        //return new { errMsg = "test" };
                        return new { status = false, message = "InValid Mac Address" };

                    }
                    else
                    {
                        if (IsValidMacAddress(masterTerminlsModel.MacAddress) == false)
                        {
                            return new { status = false, message = "InValid Mac Address" };

                        }
                    }

                }
                if (IsExistTerminal(masterTerminlsModel.TerminalName, masterTerminlsModel.ID) == true)
                {
                    return new { status = false, message = "Terminal Name already exist." };


                }
                if (IsExistMacAddress(masterTerminlsModel.MacAddress, masterTerminlsModel.ID) == true)
                {
                    return new { status = false, message = "Mac Address already exist." };

                }
                // if (ModelState.IsValid)
                int? userId = null;
                if (HttpContext.Current.Session["CVCUserId"] != null)
                {
                    userId = Convert.ToInt32(HttpContext.Current.Session["CVCUserId"].ToString());
                }
                {
                    if (masterTerminlsModel.ID == null)
                    {
                        
                        var Saveterminal = new MasterTerminal();
                        using (var cVCEntities = new CVCEntities())
                        {
                            Saveterminal.CreatedOn = DateTime.Now;
                            Saveterminal.CreatedBy = userId;
                            Saveterminal.TerminalName = masterTerminlsModel.TerminalName;
                            Saveterminal.MacAddress = masterTerminlsModel.MacAddress.ToUpper();
                            Saveterminal.IsActive = masterTerminlsModel.IsActive == 1 ? true : false;
                            Saveterminal.SerialNumber = masterTerminlsModel.SerialNumber;
                            Saveterminal.ModelNumber = masterTerminlsModel.ModelNumber;
                            Saveterminal.TerminalTypeId = masterTerminlsModel.TerminalTypeId;
                            cVCEntities.MasterTerminals.Add(Saveterminal);
                            cVCEntities.SaveChanges();
                        }
                        AddAuditLog(masterTerminlsModel);
                        //new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Add Terminal", "Machine Customization", "Terminal View", "TerminalName", NewValue: Saveterminal.TerminalName);
                        //new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Add Terminal", "Machine Customization", "Terminal View", "MacAddress", NewValue: Saveterminal.MacAddress);
                        //new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Add Terminal", "Machine Customization", "Terminal View", "IsActive", NewValue: Saveterminal.IsActive ? "Active" : "In-Active");
                        return new { status = true, message = "Data Saved Successfully" };


                    }
                    else
                    {
                        using (var update = new CVCEntities())
                        {

                            var result = update.MasterTerminals.Where(x => x.ID == masterTerminlsModel.ID).FirstOrDefault();
                            masterTerminlsModel.OldTerminalName = result.TerminalName;
                            masterTerminlsModel.OldMacAddress = result.MacAddress;
                            masterTerminlsModel.OldSerialNumber = result.SerialNumber;
                            masterTerminlsModel.OldModelNumber = result.ModelNumber;
                            masterTerminlsModel.OldIsActive = result.IsActive?1:2;
                            masterTerminlsModel.OldTerminalTypeId =(int) result.TerminalTypeId;
                           // var oldDataMacAddress = result.MacAddress;
                           // var oldDataIsActive = result.IsActive;
                            if (result != null)
                            {
                                result.TerminalName = masterTerminlsModel.TerminalName;
                                result.MacAddress = masterTerminlsModel.MacAddress.ToUpper();
                                result.EditedOn = DateTime.Now;
                                result.EditedBy = userId;
                                result.IsActive = masterTerminlsModel.IsActive == 1 ? true : false;
                                result.SerialNumber = masterTerminlsModel.SerialNumber;
                                result.ModelNumber = masterTerminlsModel.ModelNumber;
                                result.TerminalTypeId = masterTerminlsModel.TerminalTypeId;
                                update.SaveChanges();
                            }
                            AddAuditLog(masterTerminlsModel);

                            //new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Update Terminal", "Machine Customization", "Terminal View", "TerminalName", OldValue: oldDataTerminalName, NewValue: result.TerminalName);
                            //new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Update Terminal", "Machine Customization", "Terminal View", "MacAddress", OldValue: oldDataMacAddress, NewValue: result.MacAddress);
                            //new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Update Terminal", "Machine Customization", "Terminal View", "IsActive", OldValue: oldDataIsActive ? "Active" : "In-Active", NewValue: result.IsActive ? "Active" : "In-Active");
                            return new { status = true, message = "Data Saved Successfully" };

                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                return new { status = false, message = "Error while saving data" };

            }
        }


        #region Check Is Exist Terminal
        public bool IsExistTerminal(string TerminalName, int? TerminalId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
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
        }
        #endregion

        #region Check Is Exist Mac Address
        public bool IsExistMacAddress(string MacAddress, int? TerminalId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
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
        }
        #endregion

        #region Check Valid Mac Address
        public bool IsValidMacAddress(string input)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var alphabatesCount = Regex.Matches(input, @"[a-fA-F]").Count;
                var numberCount = Regex.Matches(input, @"[0-9]").Count;
                if (alphabatesCount > 0 && numberCount > 0)
                {
                    return  Regex.IsMatch(input, "^[a-fA-F0-9-]*$");
                    //return Regex.IsMatch(input, "^([a-fA-F])[a-fA-F0-9-]*$");
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
        }
        #endregion

        public List<MachineTerminalMapping> GetMachineTerminalMappedData(MachineTerminalMapping machineTerminalMapping)
        {
            var listMachineTerminalMapping = new List<MachineTerminalMapping>();
            try
            {
                using (CVCEntities cVCEntities = new CVCEntities())
                {
                    var results = cVCEntities.TerminalMachineMappings.Where(mtm => mtm.MachineId == machineTerminalMapping.MachineId).ToList();

                    listMachineTerminalMapping = results.Select((item,index) => new MachineTerminalMapping
                    {
                        Id=index+1,
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

        private void AddAuditLog(MasterTerminlsModel masterTerminlsModel)
        {
            var propertyInfos = masterTerminlsModel.GetType().GetProperties();
            int userId = HttpContext.Current.Session["CVCUserId"] != null ? Convert.ToInt32(HttpContext.Current.Session["CVCUserId"].ToString()) : 0;
            var userDetails = commonServices.GetUserDetailsByUserId(userId); List<AuditLog> lstAuditLog = new List<AuditLog>();
            foreach (PropertyInfo pInfo in propertyInfos)
            {
                string propertyName = pInfo.Name;
                var propertyValue = (pInfo.GetValue(masterTerminlsModel, null));
                var oldValue = "";
                if (masterTerminlsModel.ID > 0)
                {
                    if (propertyName == "TerminalName")
                    {
                        oldValue = masterTerminlsModel.OldTerminalName;
                    }
                    if (propertyName == "MacAddress")
                    {
                        oldValue = masterTerminlsModel.OldMacAddress;

                    }
                    if (propertyName == "SerialNumber")
                    {
                        oldValue = masterTerminlsModel.OldSerialNumber;
                    }
                    if (propertyName == "ModelNumber")
                    {
                        oldValue = masterTerminlsModel.OldModelNumber;
                    }
                    if (propertyName == "TerminalTypeId")
                    {
                        using (CVCEntities cVCEntities = new CVCEntities())
                        {
                            oldValue = cVCEntities.TerminalTypes.FirstOrDefault(tt => tt.TerminalTypeId == masterTerminlsModel.OldTerminalTypeId).TerminalTypeName;
                        }
                            
                    }
                   
                   
                }

                if (propertyName == "TerminalTypeId" || propertyName == "TerminalName" || propertyName == "MacAddress" || propertyName == "SerialNumber" || propertyName == "ModelNumber" || propertyName == "IsActive")
                {
                    if (propertyName == "TerminalTypeId")
                    {
                        using (CVCEntities cVCEntities = new CVCEntities())
                        {
                            propertyValue = cVCEntities.TerminalTypes.FirstOrDefault(tt => tt.TerminalTypeId == masterTerminlsModel.TerminalTypeId).TerminalTypeName;
                        }
                        propertyName = "TerminalType";
                    }
                    if (masterTerminlsModel.ID > 0)
                    {

                        if (propertyName == "IsActive")
                        {
                            oldValue = masterTerminlsModel.OldIsActive == 1 ? "Active" : "In-Active";
                            propertyName = "ActiveStatus";
                            propertyValue = masterTerminlsModel.IsActive == 1 ? "Active" : "In-Active";


                        }
                    }
                    else
                    {
                        if (propertyName == "IsActive")
                        {
                            propertyValue = masterTerminlsModel.IsActive == 1 ? "Active" : "In-Active";
                            propertyName = "ActiveStatus";

                        }

                    }

                    AuditLog auditLog = new AuditLog
                    {
                        Action = "Add Terminal Master",
                        Module = "Machine Customization",
                        Page = "Terminal Master",
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

        public object GetTerminalDetails(MasterTerminlsModel masterTerminlsModel)
        {
            var terminlsModel = new MasterTerminlsModel();
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var terminalDetails = cvcEntities.MasterTerminals.FirstOrDefault(t => t.MacAddress.ToUpper() == masterTerminlsModel.MacAddress.ToUpper());
                    if(terminalDetails==null)
                    {
                        return new { status = false, message = "This Terminal is not registered",data="" };
                    }

                    terminlsModel.ID = terminalDetails.ID;
                    terminlsModel.TerminalName = terminalDetails.TerminalName;
                    terminlsModel.MacAddress = terminalDetails.MacAddress;
                    terminlsModel.SerialNumber = terminalDetails.SerialNumber; 
                    terminlsModel.ModelNumber = terminalDetails.ModelNumber;
                    terminlsModel.TerminalTypeId = (int)terminalDetails.TerminalTypeId;
                    terminlsModel.IsActive = terminalDetails.IsActive ? 1 : 2;
                    terminlsModel.TerminalType = terminalDetails.TerminalType.TerminalTypeName;
                    terminlsModel.IsActiveTerminalType = terminalDetails.TerminalType.IsActive;

                }

                return new { status = true, message = "",data=terminlsModel };
            }
            catch (System.Exception ex)
            {
                return terminlsModel;
            }
       }

        public List<MachineTerminalMapping> GetMachinesByTerminalId(MachineTerminalMapping machineTerminalMapping)
        {
            var listMachineTerminalMapping = new List<MachineTerminalMapping>();
            try
            {
                using (CVCEntities cVCEntities = new CVCEntities())
                {
                    var results = cVCEntities.TerminalMachineMappings.Where(mtm => mtm.TerminalId == machineTerminalMapping.TerminalId).ToList();

                    listMachineTerminalMapping = results.Select((item, index) => new MachineTerminalMapping
                    {
                        Id = index + 1,
                        TerminalName = item.MasterTerminal.TerminalName,
                        MacAddress = item.MasterTerminal.MacAddress,
                        IsRead = item.IsRead,
                        IsWrite = item.IsWrite,
                        ModuleId=(cVCEntities.Modules.FirstOrDefault(m=>m.MachineId==item.MachineId && m.StatusId==1)?.ModuleId??0)
                        
                    }).ToList();
                    return listMachineTerminalMapping;
                }
            }
            catch (System.Exception ex)
            {
                return listMachineTerminalMapping;
            }
        }


    }

}
