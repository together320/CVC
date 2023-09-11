
using CVC.BusinessServices.Common;
using CVC.Data.EDMX;
using CVC.Models;
using CVC.Modules.MachineCustomization.TerminalView;
using CVC.Repository;
using Serenity.Web;
//using CVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVC.BusinessServices.DAL;
using  vm=CVC.ViewModels;

namespace CVC.Controllers
{
    [RoutePrefix("terminaltab")]
    [PageAuthorize(typeof(TerminalViewRow))]
    public class TerminalTabController : Controller
    {
        CommonServices objCommonServices;
        TerminalRepository _repo;
        MachineDAL machineDAL;
        TerminalTypeDAL terminalTypeDAL;
        TerminalMasterDAL terminalMasterDAL;
        public TerminalTabController()
        {
            _repo = new TerminalRepository();
            objCommonServices = new CommonServices();
            machineDAL = new MachineDAL();
            terminalTypeDAL = new TerminalTypeDAL();
            terminalMasterDAL = new TerminalMasterDAL();
        }

        [HttpGet] 
        [Route("Index")]
        public ActionResult Index()
        {
            return RedirectToAction("TerminalView");
        }

        [HttpGet]
        [Route("TerminalView")]
        public ActionResult TerminalView()
        {
           CVC.ViewModels.TerminalViewModel terminalViewModel = new CVC.ViewModels.TerminalViewModel();
           //var StatusId= (int)ClsConstants.StatusType.Active;
            var machines= objCommonServices.GetAllMachine(0);
            terminalViewModel.machineList = machines.Select((item,index) => new CVC.ViewModels.MachineList {
                Id= index+1,
                MachineId=item.MachineId,
                MachineName = item.MachineName,
                Status= item.StatusId==1?"Active":"In-Active"
            }).ToList();

            if (machines.Count > 0)
            {
                ViewBag.DefaultMachineId = machines.FirstOrDefault().MachineId;
            }

            var roleId = Session["CVCRoleId"]!=null?Convert.ToInt32(Session["CVCRoleId"]):0;

            var rolePermissions = objCommonServices.GetRolePermission(roleId);
            var machineDetails = rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "MachineCustomization:MachineDetails:Modify");
            var machineTerminalMapping = rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "MachineCustomization:MachineTerminalMapping:Modify");
            var machineUserMapping = rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "MachineCustomization:MachineUserMapping:Modify");

            if(machineDetails!=null)
            {
                terminalViewModel.IsModifyMachineDetails = true;
            }
            if (machineTerminalMapping != null)
            {
                terminalViewModel.IsModifyMachineTerminalMapping = true;
            }
            if (machineUserMapping != null)
            {
                terminalViewModel.IsModifyMachineUserMapping = true;
            }
            if (roleId == 1)
            {
                terminalViewModel.IsModifyMachineDetails = true;
                terminalViewModel.IsModifyMachineTerminalMapping = true;
                terminalViewModel.IsModifyMachineUserMapping = true;
            }
            return View(terminalViewModel);
        }

        [HttpGet]
        [Route("GetMachineDetails")]
        public JsonResult GetMachineDetails(int MachineId)
        {
            try
            {
                CVC.ViewModels.TerminalViewModel terminalViewModel = new CVC.ViewModels.TerminalViewModel();
                var machineDetails = objCommonServices.GetMachineDetails(MachineId);
                  return Json(machineDetails, JsonRequestBehavior.AllowGet);
               // return Json(MachineId, JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        [HttpPost]
        [Route("UpdateMachineDetails")]
        public JsonResult UpdateMachineDetails(CVC.ViewModels.MachineDetails machineDetails)
        {
            try
            {
                var response = machineDAL.UpdateMachineDetails(machineDetails);
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        [HttpPost]
        [Route("SaveMachineDetails")]
        public JsonResult SaveMachineDetails(CVC.ViewModels.MachineDetails machineDetails)
        {
            try
            {
                var response = machineDAL.SaveMachineDetails(machineDetails);
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        [HttpPost]
        [Route("GetMachineTerminalMappedData")]
        public JsonResult GetMachineTerminalMappedData(CVC.ViewModels.MachineTerminalMapping machineTerminalMapping)
        {
            try
            {
                var response = terminalMasterDAL.GetMachineTerminalMappedData(machineTerminalMapping);
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("mainTab")]
        public ActionResult MainTab()
        {
            var _dataobject = new TerminalMappingVM();
            try
            {

                if (TempData["message"] != null)
                {
                    ViewBag.status = TempData["message"].ToString();
                }
                StatusList();
                TerminalTypeList();
                ViewBag.ActiveTerminalName = "second";
               
                return View(_dataobject);
            }
            catch(System.Exception ex)
            {

            }
            return View(_dataobject);
        }

        [HttpPost]
        [Route("SaveTerminal")]
        public JsonResult SaveTerminal(MasterTerminlsModel Model)
        {
            try
            {
                if (!string.IsNullOrEmpty(Model.MacAddress))
                {
                    if (Model.MacAddress.Length > 17)
                    {
                        return Json(new { status = false, message = "InValid Mac Address" }, JsonRequestBehavior.AllowGet);

                    }
                    else
                    {
                        if (_repo.IsValidMacAddress(Model.MacAddress) == false)
                        {
                            return Json(new { status = false, message = "InValid Mac Address" }, JsonRequestBehavior.AllowGet);

                        }
                    }

                }
                if (_repo.IsExistTerminal(Model.TerminalName, Model.ID) == true)
                {
                    return Json(new { status = false, message = "Terminal Name already exist." }, JsonRequestBehavior.AllowGet);

                }
                if (_repo.IsExistMacAddress(Model.MacAddress, Model.ID) == true)
                {
                    return Json(new { status = false, message = "Mac Address already exist." }, JsonRequestBehavior.AllowGet);

                }
                //if (ModelState.IsValid)

                {
                    if (Model.ID == null)
                    {
                        var Saveterminal = new MasterTerminal();
                        using (var cVCEntities = new CVCEntities())
                        {
                            Saveterminal.CreatedOn = DateTime.Now;
                            Saveterminal.CreatedBy = Convert.ToInt32(Session["CVCUserId"].ToString());
                            Saveterminal.TerminalName = Model.TerminalName;
                            Saveterminal.MacAddress = Model.MacAddress.ToUpper();
                          //  Saveterminal.UserID = Convert.ToInt32(Session["CVCUserId"].ToString());
                            Saveterminal.IsActive = Model.IsActive == 1 ? true : false;
                            Saveterminal.SerialNumber = Model.SerialNumber;
                            Saveterminal.ModelNumber = Model.ModelNumber;
                            Saveterminal.TerminalTypeId = Model.TerminalTypeId;
                            cVCEntities.MasterTerminals.Add(Saveterminal);
                            cVCEntities.SaveChanges();
                        }

                        new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Add Terminal", "Machine Customization", "Terminal View", "TerminalName", NewValue: Saveterminal.TerminalName);
                        new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Add Terminal", "Machine Customization", "Terminal View", "MacAddress", NewValue: Saveterminal.MacAddress);
                        new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Add Terminal", "Machine Customization", "Terminal View", "IsActive", NewValue: Saveterminal.IsActive ? "Active" : "In-Active");

                        return Json(new { status = true, message = "Record Saved Successfully" }, JsonRequestBehavior.AllowGet);

                    }
                    else
                    {
                        using (var update = new CVCEntities())
                        {

                            var result = update.MasterTerminals.Where(x => x.ID == Model.ID).FirstOrDefault();
                            var oldDataTerminalName = result.TerminalName;
                            var oldDataMacAddress = result.MacAddress;
                            var oldDataIsActive = result.IsActive;
                            if (result != null)
                            {
                                result.TerminalName = Model.TerminalName;
                                result.MacAddress = Model.MacAddress.ToUpper();
                                result.EditedOn = DateTime.Now;
                                result.EditedBy = Convert.ToInt32(Session["CVCUserId"].ToString());
                                result.IsActive = Model.IsActive == 1 ? true : false;
                                result.SerialNumber = Model.SerialNumber;
                                result.ModelNumber = Model.ModelNumber;
                                result.TerminalTypeId = Model.TerminalTypeId;
                                update.SaveChanges();
                            }
                            new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Update Terminal", "Machine Customization", "Terminal View", "TerminalName", OldValue: oldDataTerminalName, NewValue: result.TerminalName);
                            new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Update Terminal", "Machine Customization", "Terminal View", "MacAddress", OldValue: oldDataMacAddress, NewValue: result.MacAddress);
                            new CVC.Modules.Common.Dashboard.DashboardCommon().AddAuditLog("Update Terminal", "Machine Customization", "Terminal View", "IsActive", OldValue: oldDataIsActive ? "Active" : "In-Active", NewValue: result.IsActive ? "Active" : "In-Active");

                            return Json(new { status = true, message = "Record Updated Successfully" }, JsonRequestBehavior.AllowGet);

                        }
                    }
                }
            }
            catch(System.Exception ex)
            {
                return Json(new { status = false, message = "Error while saving data" }, JsonRequestBehavior.AllowGet);

            }

        }


        [Route("CheckTerminalName/{terminalname}")]
        public JsonResult CheckTerminalName1(string terminalname)
        {
            bool searchdata;
            using (var db = new CVCEntities())
            {
                searchdata = db.MasterTerminals.Any(o => o.TerminalName.ToLower() == terminalname.ToLower());
            }
            return Json(searchdata, JsonRequestBehavior.AllowGet);
        }

        [Route("CheckMackaddress/{mackname}")]
        public JsonResult CheckMackaddress(string mackname)
        {
            bool IsExist;
            using (var db = new CVCEntities())
            {
                IsExist = db.MasterTerminals.Any(o => o.MacAddress == mackname);
            }
            return Json(IsExist, JsonRequestBehavior.AllowGet);
        }


        [Route("GetAllTerminal")]
        public ActionResult GetAllTerminal()
        {
            try
            {
                using (CVCEntities db = new CVCEntities())
                {
                    var lstterminalTypeViewModel = db.MasterTerminals.ToList();
                    var response = lstterminalTypeViewModel.Select((item, index) => new MasterTerminlsModel

                    {
                        Index=index+1,
                        ID = item.ID,
                        TerminalName = item.TerminalName,
                        MacAddress = item.MacAddress,
                        SerialNumber=item.SerialNumber,
                        ModelNumber=item.ModelNumber,
                       // TerminalTypeName=item.TerminalType.TerminalTypeName,
                       // IsActive = item.IsActive,
                       
                    }).OrderByDescending(m => m.ID).ToList();
                    return PartialView("TerminalList_PartialView", response);
                   // return Json("hhhh", JsonRequestBehavior.AllowGet);
                  
                }
            }
            catch (System.Exception ex)
            {

            }
            return null;
        }

        #region Get Terminal Details
        [Route("update-terminal")]
        [HttpGet]
        public ActionResult GetTerminalDetails(int ID)
        {
            using (CVCEntities db = new CVCEntities())
            {
                var result = db.MasterTerminals.SingleOrDefault(b => b.ID == ID);
                var model = new TerminalMappingVM();
                model.AddEditTermial = new MasterTerminlsModel();
                model.AddEditTermial.ID = result.ID;
                model.AddEditTermial.IsActive = result.IsActive == true ? 1 : 2;
                model.AddEditTermial.MacAddress = result.MacAddress;
                model.AddEditTermial.TerminalName = result.TerminalName;
                model.AddEditTermial.SerialNumber = result.SerialNumber;
                model.AddEditTermial.ModelNumber = result.ModelNumber;
                model.AddEditTermial.TerminalTypeId =(int)result.TerminalTypeId;
                StatusList();
                TerminalTypeList();
                //  return  RedirectToAction("mainTab");
                return View("MainTab", model);
            }
        }
        #endregion

        #region Get Machine
        [Route("getmachine")]
        [HttpGet]
        public JsonResult GetallMachineName()
        {
            using (CVCEntities db = new CVCEntities())
            {
                var model = from m in db.Machines
                            join p in db.Modules on m.MachineId equals p.MachineId
                            select new MachineModel
                            {
                                ID = m.MachineId,
                                MachineName = m.MachineName,
                                ModuleName = p.ModuleName
                            };
                model.ToList();
                return Json(new { data = model.ToList() }, JsonRequestBehavior.AllowGet);
            }
        }
        #endregion

        #region Get Machine Terminal Mapping Data
        [Route("GetMachineTerminalMappingData")]
        public PartialViewResult GetMachineTerminalMappingData(int MachineId)
        {
            var data = _repo.GetMachineTerminalMappingData(MachineId);
            return PartialView("MachineTerminalMapping_Partial", data);

            // return Json(data, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region Get Machine Terminal Mapped Data
        [Route("GetMachineTerminalMappedData")]
        public PartialViewResult GetMachGetMachineTerminalMappedDataineTerminalMappingData(int MachineId)
        {
            var data = _repo.GetMachineTerminalMappedData(MachineId);
            return PartialView("MachineTerminalMappedList_PartialView", data);

            // return Json(data, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region Save Machine Terminal Mapping
        [Route("SaveMachineTerminalMapping")]
        public JsonResult SaveMachineTerminalMapping(CVC.ViewModels.MachineTerminalMapping machineTerminalMapping)
         {
            var data = _repo.SaveMachineTerminalMapping(machineTerminalMapping);
            return Json(data, JsonRequestBehavior.AllowGet);

        }
        #endregion

        #region Get Machine User Mapping Data
        [Route("GetMachineUserMappingData")]
        public PartialViewResult GetMachineUserMappingData(CVC.ViewModels.MachineUserMapping machineUserMapping)
        {
            var data = machineDAL.GetMachineUserMappingData(machineUserMapping);
            return PartialView("MachineUserMapping_PartialView", data);
        }
        #endregion

        #region Get Machine User Mapped Data
        [Route("GetMachineUserMappedData")]
        public PartialViewResult GetMachineUserMappedData(CVC.ViewModels.MachineUserMapping machineUserMapping)
        {
            var data = machineDAL.GetMachineUserMappedData(machineUserMapping);
            return PartialView("MachineUserMappedList_PartialView", data);
        }
        #endregion

        #region Save Machine User Mapping
        [Route("SaveMachineUserMapping")]
        public JsonResult SaveMachineUserMapping(CVC.ViewModels.MachineUserMapping machineUserMapping)
        {
            var data = machineDAL.SaveMachineUerMapping(machineUserMapping);
            return Json(data, JsonRequestBehavior.AllowGet);

        }
        #endregion

        public void StatusList()
        {
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                ViewBag.StatusList = objCommonServices.GetAllStatus();
            }
        }

        public void TerminalTypeList()
        {
            vm.TerminalTypeViewModel terminalTypeViewModel = new vm.TerminalTypeViewModel
            {
                IsActive = true
            };
            ViewBag.TerminalTypeList= terminalTypeDAL.GetAllActiveTerminalType(terminalTypeViewModel);
            
        }
    }
}