using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVC.BusinessServices.DAL;
using CVC.BusinessServices.Interface;
using CVC.Modules.MachineCustomization.TerminalMaster;
using CVC.ViewModels;
using Serenity.Web;

namespace CVC.Controllers
{
    [RoutePrefix("TerminalMaster")]
    [PageAuthorize(typeof(TerminalMasterRow))]

    public class TerminalMasterController : Controller
    {

        TerminalMasterDAL terminalMasterDAL;
        TerminalTypeDAL terminalTypeDAL;
        public TerminalMasterController()
        {
            // _terminalType = terminalType;
            terminalMasterDAL = new TerminalMasterDAL();
            terminalTypeDAL = new TerminalTypeDAL();
        }
        // GET: TerminalType
        [Route("Index")]
        public ActionResult Index()
        {
            TerminalTypeList();
            return View();
        }

        public void TerminalTypeList()
        {
            TerminalTypeViewModel terminalTypeViewModel = new TerminalTypeViewModel
            {
                IsActive = true
            };
            ViewBag.TerminalTypeList = terminalTypeDAL.GetAllActiveTerminalType(terminalTypeViewModel);

        }
        [HttpPost]
        [Route("SaveUpdateTerminal")]
        public JsonResult SaveUpdateTerminal(MasterTerminlsModel masterTerminlsModel)
        {
            object response = "";
           // if (ModelState.IsValid)
            {
                response = terminalMasterDAL.SaveTerminalType(masterTerminlsModel);
            }
            return Json(response, JsonRequestBehavior.AllowGet);
        }


        [Route("GetAllTerminal")]
        public PartialViewResult GetAllTerminal()
        {
            try
            {
                var response = terminalMasterDAL.GetAllTerminal();
                if (response.Count > 0)
                {
                    ViewBag.DefaultTerminaId = response.FirstOrDefault().ID;
                }
                return PartialView("TerminalList_PartialView", response);
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        [Route("GetTerminalDetails")]
        public JsonResult GetTerminalDetails(MasterTerminlsModel masterTerminlsModel)
        {
            var response = terminalMasterDAL.GetTerminal(masterTerminlsModel);
            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}