using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVC.BusinessServices.Common;
using CVC.ViewModels;
using CVC.Data.EDMX;
using CVC.Modules.Common.CommonServices;
using Serenity.Web;
using CVC.ModuleManagement.Entities;

namespace CVC.Controllers
{
    [RoutePrefix("NAdministration/RoleAccess")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(ModuleAccessRow))]
    public class RoleViewAccessController : Controller
    {
       // BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices();
        // GET: RoleViewAccess

        #region Role
        public ActionResult Index()
        {
            RoleViewModel objRoleViewModel = new RoleViewModel();
            objRoleViewModel = GetAllRole(objRoleViewModel);
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                ViewBag.StatusList = objCommonServices.GetAllStatus();
            }

            return View(objRoleViewModel);
        }
        public RoleViewModel GetAllRole(RoleViewModel objRoleViewModel)
        {
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                objRoleViewModel = objCommonServices.GetAllRoles(objRoleViewModel, Serenity.Authorization.UserId);
            }
            return objRoleViewModel;
        }
        public JsonResult RoleById(int RoleId)
        {
            RoleViewModel objRoleViewModel = new RoleViewModel();
            objRoleViewModel.RoleId = RoleId;
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                objRoleViewModel = objCommonServices.GetRoleById(objRoleViewModel);
            }
            return Json(objRoleViewModel, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Create(RoleViewModel objRoleViewModel)
        {
            RoleViewModel roleViewModel = new RoleViewModel();
            objRoleViewModel.CreatedBy = Convert.ToInt32(Session["CVCUserId"]);
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                roleViewModel = objCommonServices.CreateRole(objRoleViewModel);
            }

            if (roleViewModel.IsStatus)
            {
                roleViewModel = GetAllRole(roleViewModel);
                return PartialView("RoleList_Partial", roleViewModel);
            }
            else
            {
                return Json(roleViewModel, JsonRequestBehavior.AllowGet);
            }

        }
        public ActionResult Update(RoleViewModel objRoleViewModel)
        {
            RoleViewModel roleViewModel = new RoleViewModel();
            objRoleViewModel.UpdatedBy = Convert.ToInt32(Session["CVCUserId"]);
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                roleViewModel = objCommonServices.UpdateRole(objRoleViewModel);
            }

            if (roleViewModel.IsStatus)
            {
                roleViewModel = GetAllRole(roleViewModel);
                return PartialView("RoleList_Partial", roleViewModel);
            }
            else
            {
                return Json(roleViewModel, JsonRequestBehavior.AllowGet);
            }

        }
        #endregion

        #region Module
        public ActionResult GetAllModule(int RoleId)
        {
            ModuleViewModel objModuleViewModel = new ModuleViewModel();
            objModuleViewModel.RoleId = RoleId;
            objModuleViewModel.StatusId = (int)BusinessServices.Common.ClsConstants.StatusType.Active;
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                ResponseListViewModel<ModuleViewModel> lstModuleViewModel = (ResponseListViewModel<ModuleViewModel>)objCommonServices.GetAllModules(objModuleViewModel);
                ViewBag.StatusList = objCommonServices.GetAllStatus();
                return PartialView("ModuleList_Partial", lstModuleViewModel.Data);
            }

        }
        public JsonResult GetModuleByRoleIdAjax(int RoleId)
        {
            ModuleAccessViewModel objModuleAccessViewModel = new ModuleAccessViewModel();
            objModuleAccessViewModel = GetModuleByRoleId(RoleId);
            return Json(objModuleAccessViewModel.lstModuleViewModel, JsonRequestBehavior.AllowGet);
        }
        public ModuleAccessViewModel GetModuleByRoleId(int RoleId)
        {
            ModuleAccessViewModel objModuleAccessViewModel = new ModuleAccessViewModel();
            objModuleAccessViewModel.RoleId = RoleId;
            objModuleAccessViewModel.StatusId = (int)BusinessServices.Common.ClsConstants.StatusType.Active;
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                ResponseViewModel<ModuleAccessViewModel> responseentityModuleAccess = (ResponseViewModel<ModuleAccessViewModel>)objCommonServices.GetAllModuleAccess(objModuleAccessViewModel);
                if (responseentityModuleAccess.IsStatus)
                {
                    return objModuleAccessViewModel;
                }
            }
            return objModuleAccessViewModel;
        }
        #endregion

        #region Module Access
        public ActionResult ModuleAccessList(int RoleId)
        {
            List<ModuleAccessViewModel> lstModuleAccessViewModel = new List<ModuleAccessViewModel>();
            ModuleAccessViewModel objModuleAccessViewModel = new ModuleAccessViewModel();
            objModuleAccessViewModel.RoleId = RoleId;
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                ResponseViewModel<ModuleAccessViewModel> responseentity = (ResponseViewModel<ModuleAccessViewModel>)objCommonServices.GetAllModuleAccess(objModuleAccessViewModel);
                if (responseentity.IsStatus)
                {
                    RoleViewModel objRoleViewModel = new RoleViewModel();
                    objRoleViewModel.IsStatus = true;
                    objRoleViewModel = GetAllRole(objRoleViewModel);
                    ViewBag.RoleList = objRoleViewModel.lstRoleViewModel;
                    return View(responseentity.Data);
                }
            }
            return View(lstModuleAccessViewModel);
        }

        public ActionResult CreateModuleAccess(ModuleAccessViewModel objModuleAccessViewModel)
        {
            objModuleAccessViewModel.CreatedBy = Convert.ToInt32(Session["CVCUserId"]);
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                objCommonServices.CreateModuleAccess(objModuleAccessViewModel);
            }
            return null;
        }
        #endregion

        #region View
        public ActionResult GetAllView(int ModuleId, int RoleId)
        {
            ViewsViewModel objViewsViewModel = new ViewsViewModel();
            objViewsViewModel.ModuleId = ModuleId;
            objViewsViewModel.RoleId = RoleId;
            objViewsViewModel.StatusId = (int)BusinessServices.Common.ClsConstants.StatusType.Active;
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                ResponseListViewModel<ViewsViewModel> lstModuleViewModel = (ResponseListViewModel<ViewsViewModel>)objCommonServices.GetAllViews(objViewsViewModel);
                ViewBag.StatusList = objCommonServices.GetAllStatus();

                return PartialView("ViewList_Partial", lstModuleViewModel.Data);
            }

        }
        public JsonResult GetViewByModuleIdAjax(int ModuleId, int RoleId)
        {
            ViewAccessViewModel objViewAccessViewModel = new ViewAccessViewModel();
            objViewAccessViewModel = GetViewByModuleId(ModuleId, RoleId);
            return Json(objViewAccessViewModel.lstViewsViewModel, JsonRequestBehavior.AllowGet);
        }

        public ViewAccessViewModel GetViewByModuleId(int ModuleId, int RoleId)
        {
            ViewAccessViewModel objViewAccessViewModel = new ViewAccessViewModel();
            objViewAccessViewModel.ModuleId = ModuleId;
            objViewAccessViewModel.RoleId = RoleId;
            objViewAccessViewModel.StatusId = (int)BusinessServices.Common.ClsConstants.StatusType.Active;
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                ResponseViewModel<ViewAccessViewModel> responseentityModuleAccess = (ResponseViewModel<ViewAccessViewModel>)objCommonServices.GetAllViewAccess(objViewAccessViewModel);
                if (responseentityModuleAccess.IsStatus)
                {
                    return objViewAccessViewModel;
                }
            }
            return objViewAccessViewModel;
        }
        #endregion

        #region View Access
        public ActionResult ViewAccessList(int RoleId, int ModuleId)
        {
            List<ViewAccessViewModel> lstViewAccessViewModel = new List<ViewAccessViewModel>();
            ViewAccessViewModel objViewAccessViewModel = new ViewAccessViewModel();
            objViewAccessViewModel.RoleId = RoleId;
            objViewAccessViewModel.ModuleId = ModuleId;
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                ResponseViewModel<ViewAccessViewModel> responseentity = (ResponseViewModel<ViewAccessViewModel>)objCommonServices.GetAllViewAccess(objViewAccessViewModel);
                if (responseentity.IsStatus)
                {
                    RoleViewModel objRoleViewModel = new RoleViewModel();
                    objRoleViewModel.IsStatus = true;
                    objRoleViewModel = GetAllRole(objRoleViewModel);
                    ViewBag.RoleList = objRoleViewModel.lstRoleViewModel;

                    ModuleAccessViewModel objModuleAccessViewModel = new ModuleAccessViewModel();
                    objModuleAccessViewModel = GetModuleByRoleId(RoleId);
                    ViewBag.ModuleList = objModuleAccessViewModel.lstModuleViewModel;

                    return View(responseentity.Data);
                }
            }
            return View(lstViewAccessViewModel);
        }

        public ActionResult CreateViewAccess(ViewAccessViewModel objViewAccessViewModel)
        {
            objViewAccessViewModel.CreatedBy = Convert.ToInt32(Session["CVCUserId"]);
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                objCommonServices.CreateViewAccess(objViewAccessViewModel);
            }

            return null;
        }
        #endregion

        #region View Field
        public ActionResult GetAllViewField(int ViewsId, int RoleId)
        {
            ViewFieldViewModel objViewFieldViewModel = new ViewFieldViewModel();
            objViewFieldViewModel.ViewsId = ViewsId;
            objViewFieldViewModel.RoleId = RoleId;
            objViewFieldViewModel.StatusId = (int)BusinessServices.Common.ClsConstants.StatusType.Active;
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                ViewBag.StatusList = objCommonServices.GetAllStatus();

                ResponseListViewModel<ViewFieldViewModel> lstViewFieldViewModel = (ResponseListViewModel<ViewFieldViewModel>)objCommonServices.GetAllViewField(objViewFieldViewModel);

                return PartialView("ViewFieldList_Partial", lstViewFieldViewModel.Data);
            }

        }
        #endregion

        #region View Field Access
        public ActionResult ViewFieldAccessList(int RoleId, int ViewsId, int ModuleId)
        {
            List<ViewFieldAccessViewModel> lstViewFieldAccessViewModel = new List<ViewFieldAccessViewModel>();
            ViewFieldAccessViewModel objViewFieldAccessViewModel = new ViewFieldAccessViewModel();
            objViewFieldAccessViewModel.RoleId = RoleId;
            objViewFieldAccessViewModel.ViewId = ViewsId;
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                ResponseViewModel<ViewFieldAccessViewModel> responseentity = (ResponseViewModel<ViewFieldAccessViewModel>)objCommonServices.GetAllViewFieldAccess(objViewFieldAccessViewModel);
                if (responseentity.IsStatus)
                {
                    RoleViewModel objRoleViewModel = new RoleViewModel();
                    objRoleViewModel.IsStatus = true;
                    objRoleViewModel = GetAllRole(objRoleViewModel);
                    ViewBag.RoleList = objRoleViewModel.lstRoleViewModel;

                    ModuleAccessViewModel objModuleAccessViewModel = new ModuleAccessViewModel();
                    objModuleAccessViewModel = GetModuleByRoleId(RoleId);
                    ViewBag.ModuleList = objModuleAccessViewModel.lstModuleViewModel;

                    ViewAccessViewModel objViewAccessViewModel = new ViewAccessViewModel();
                    objViewAccessViewModel = GetViewByModuleId(ModuleId, RoleId);
                    ViewBag.ViewList = objViewAccessViewModel.lstViewsViewModel;

                    responseentity.Data.ModuleId = ModuleId;
                    responseentity.Data.ViewId = ViewsId;
                    return View(responseentity.Data);
                }
            }
            return View(lstViewFieldAccessViewModel);
        }

        public ActionResult CreateViewFieldAccess(ViewFieldAccessViewModel objViewFieldAccessViewModel)
        {
            objViewFieldAccessViewModel.CreatedBy = Convert.ToInt32(Session["CVCUserId"]);
            using (BusinessServices.Common.CommonServices objCommonServices = new BusinessServices.Common.CommonServices())
            {
                objCommonServices.CreateViewFieldAccess(objViewFieldAccessViewModel);
            }

            return null;
        }
        #endregion

        #region test
        //public ActionResult test()
        //{
        //    return View();
        //}
        #endregion

    }
}