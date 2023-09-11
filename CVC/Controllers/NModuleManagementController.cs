using CVC.ModuleManagement.Columns;
using CVC.ModuleManagement.Entities;
using CVC.Modules.Common.Dashboard;
using CVC.Modules.NModuleManagement;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVC.Controllers
{
    [RoutePrefix("NModuleManagement/Module")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(ModuleViewRow))]

    public class NModuleManagementController : Controller
    {
        NModuleManagementViewModel _objNModuleManagementViewModel;
        NModuleRepository _repo;
        public NModuleManagementController()
        {
            //_objNModuleManagementViewModel = new NModuleManagementViewModel();            
            _repo = new NModuleRepository();
        }
        // GET: NModuleManagement
        public ActionResult Index()
        {
            _objNModuleManagementViewModel = new NModuleManagementViewModel();
            if (TempData["activeTab"] != null)
            {
                _objNModuleManagementViewModel.selectedView = Convert.ToString(TempData["activeTab"]);
                if (_objNModuleManagementViewModel.selectedView == "isView")
                {
                    _objNModuleManagementViewModel.isView = true;
                    _objNModuleManagementViewModel.isModule = false;
                    _objNModuleManagementViewModel.isViewField = false;
                }
                else if (_objNModuleManagementViewModel.selectedView == "isModule")
                {
                    _objNModuleManagementViewModel.isView = false;
                    _objNModuleManagementViewModel.isModule = true;
                    _objNModuleManagementViewModel.isViewField = false;
                }
                else
                {
                    _objNModuleManagementViewModel.isView = false;
                    _objNModuleManagementViewModel.isModule = false;
                    _objNModuleManagementViewModel.isViewField = true;
                }
            }
            else
            {
                _objNModuleManagementViewModel.selectedView = "isModule";
                _objNModuleManagementViewModel.isModule = true;
            }
            getModuleList();
            getMachineDropDown();
            getStatusDropDown();
            return View(_objNModuleManagementViewModel);
        }

        public void getModuleList()
        {
            _objNModuleManagementViewModel.ModuleColumnsList = _repo.getModuleList();
        }

        public void getViewsList()
        {
            _objNModuleManagementViewModel.ViewsColumnsList = _repo.getViewsList();
        }

        public void getViewFieldList()
        {
            _objNModuleManagementViewModel.ViewFieldColumnsList = _repo.getViewFieldList();
        }

        public void getMachineDropDown()
        {
            _objNModuleManagementViewModel.MachineListInfo = _repo.getMachineDropDown();
        }

        public void getStatusDropDown()
        {
            _objNModuleManagementViewModel.StatusInfoList = _repo.getStatusDropDown();
        }

        public void getMachineParameterDropDown(int id)
        {
            _objNModuleManagementViewModel.MachineParameterInfo = _repo.getMachineParameterDropDown(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult PostModuleForm(NModuleForm ModuleFormInfo)
        {
            if (ModelState.IsValid)
            {

                try
                {
                   // var resonse = _repo.CheckMachineAlreadyMappedToModule(ModuleFormInfo.MachineId);
                    //if (resonse == false)
                    {
                        if (_repo.AddUpdateModule(ModuleFormInfo))
                        {
                            TempData["activeTab"] = "isModule";
                        }
                    }
                    //else
                    //{
                    //    TempData["activeTab"] = "isModule";
                    //    TempData["message"] = "Machine already mapped to other module";


                    //}

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult DeleteModule(string IDToDelete)
        {
            try
            {
                int id = Convert.ToInt32(IDToDelete);
                if (_repo.deleteModule(id))
                {
                    TempData["activeTab"] = "isModule";
                }
                //_objTransporterManagerViewModel.FriendlyMessage.Add(MessageStore.Get("TRM03"));
            }
            catch (Exception ex)
            {
                //_objTransporterManagerViewModel.FriendlyMessage.Add(MessageStore.Get("SYS01"));
            }
            //TempData["FriendlyMessage"] = (List<FriendlyMessageInfo>)_objTransporterManagerViewModel.FriendlyMessage;
            return RedirectToAction("Index");
        }

        public JsonResult getSelectedModule(int id)
        {
            NModuleForm ModuleFormInfo = new NModuleForm();
            ModuleFormInfo = _repo.getSelectedModule(id);
            //ModuleFormInfo.SerialNumber = new DashboardCommon().GetSerialNumber(ModuleFormInfo.MachineId);//ModuleFormInfo.SerialNumber ?? new DashboardCommon().GetSerialNumber(ModuleFormInfo.MachineId);
            //ModuleFormInfo.EquipmentId = new DashboardCommon().GetEquipmentId(ModuleFormInfo.MachineId);//ModuleFormInfo.EquipmentId ?? new DashboardCommon().GetEquipmentId(ModuleFormInfo.MachineId);
            return Json(ModuleFormInfo, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult PostViewForm(NViewsForm ViewsFormInfo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (_repo.AddUpdateView(ViewsFormInfo))
                    {

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return getPartailViewsBasedOnModuleId(ViewsFormInfo.ModuleId);
        }

        [HttpPost]
        public PartialViewResult PostViewFieldForm(NViewFieldForm ViewFieldFormInfo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (_repo.AddUpdateViewField(ViewFieldFormInfo))
                    {

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return getPartailViewsBasedOnViewId(ViewFieldFormInfo.ModuleId, ViewFieldFormInfo.ViewsId, 0);
        }

        [HttpPost]
        //public ActionResult AddUpdateViewFieldAuthentication(int ViewFieldId, string RoleIds) {
        public ActionResult AddUpdateViewFieldAuthentication(NViewFieldRoleIds viewFieldRoleIds)
        {
            var result = _repo.AddUpdateViewFieldAuthentication(viewFieldRoleIds.ViewFieldId, viewFieldRoleIds.RoleIds);
            if (result)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            else
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.InternalServerError);
        }

        [HttpDelete]
        public JsonResult DeleteView(int id)
        {
            bool isdelete = _repo.deleteView(id);
            return Json(isdelete, JsonRequestBehavior.AllowGet);
        }

        public JsonResult checkModuleInView(int id)
        {
            bool isView = _repo.checkModuleInView(id);
            return Json(isView, JsonRequestBehavior.AllowGet);
        }

        public JsonResult checkViewInViewField(int id)
        {
            bool isViewField = _repo.checkViewInViewField(id);
            return Json(isViewField, JsonRequestBehavior.AllowGet);
        }

        [HttpDelete]
        public JsonResult DeleteViewField(int id)
        {
            bool isdelete = _repo.deleteViewField(id);
            return Json(isdelete, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getSelectedView(int id)
        {
            NViewsForm ViewsFormInfo = new NViewsForm();
            ViewsFormInfo = _repo.getSelectedView(id);
            return Json(ViewsFormInfo, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getSelectedViewField(int id)
        {
            NViewFieldForm ViewFieldFormInfo = new NViewFieldForm();
            ViewFieldFormInfo = _repo.getSelectedViewField(id);
            ViewFieldFormInfo.RoleList = _repo.PopulatRoleList();
            var RoleIdArray = _repo.GetRoleViewFieldWise(id);
            ViewFieldFormInfo.RoleIdsArray = string.Join(",", RoleIdArray.Select(x => x.ToString()).ToArray());
            return Json(ViewFieldFormInfo, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getViewsBasedOnModuleId(int id)
        {
            List<ViewsColumns> ViewsColumnsList = new List<ViewsColumns>();
            ViewsColumnsList = _repo.getViewsBasedOnModuleId(id);
            return Json(ViewsColumnsList, JsonRequestBehavior.AllowGet);
        }

        public PartialViewResult getPartailViewsBasedOnModuleId(int id)
        {
            _objNModuleManagementViewModel = new NModuleManagementViewModel();
            getModuleList();
            getMachineDropDown();
            getStatusDropDown();
            _objNModuleManagementViewModel.ViewsColumnsList = _repo.getViewsBasedOnModuleId(id);
            return PartialView("_View", _objNModuleManagementViewModel);
        }

        public PartialViewResult getPartailViewsBasedOnViewId(int moduleId, int viewId, int machineId)
        {
            _objNModuleManagementViewModel = new NModuleManagementViewModel();
            if(machineId<=0)
            {
                DashboardCommon dashboardCommon = new DashboardCommon();
                machineId=(int)dashboardCommon.GetMachineId(moduleId.ToString());
            }
            getMachineParameterDropDown(machineId);
            getStatusDropDown();
            _objNModuleManagementViewModel.ViewsColumnsList = _repo.getViewsBasedOnModuleId(moduleId);
            _objNModuleManagementViewModel.ViewFieldColumnsList = _repo.getViewFieldListBasedOnViewId(viewId);
            _objNModuleManagementViewModel.ViewFieldFormInfo.ViewsId = viewId;
            return PartialView("_ViewField", _objNModuleManagementViewModel);
        }
    }
}