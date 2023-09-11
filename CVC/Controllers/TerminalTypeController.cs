using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVC.BusinessServices.DAL;
using CVC.BusinessServices.Interface;
using CVC.Modules.MachineCustomization.TerminalType;
using CVC.ViewModels;
using Serenity.Web;

namespace CVC.Controllers
{
    [RoutePrefix("TerminalType")]
    [PageAuthorize(typeof(TerminalTypeRow))]

    public class TerminalTypeController :Controller 
    {
        private readonly ITerminalType _terminalType;
         
        TerminalTypeDAL terminalTypeDAL;
        public TerminalTypeController()
        {
           // _terminalType = terminalType;
            terminalTypeDAL = new TerminalTypeDAL();
        }
        // GET: TerminalType
        [Route("Index")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("SaveTerminalType")]
        public JsonResult SaveTerminalType(TerminalTypeViewModel terminalTypeViewModel)
        {
            object response = "";
            if (ModelState.IsValid)
            {
                response = terminalTypeDAL.SaveTerminalType(terminalTypeViewModel);
            }
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("UpdateTerminalType")]
        public JsonResult UpdateTerminalType(TerminalTypeViewModel terminalTypeViewModel)
        {
            object response = "";
            if (ModelState.IsValid)
            {
                response = terminalTypeDAL.UpdateTerminalType(terminalTypeViewModel);
            }
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [Route("GetAllTerminalType")]
        public PartialViewResult GetAllTerminalType()
        {
            var response = terminalTypeDAL.GetAllTerminalType();
            if(response.Count>0)
            {
                ViewBag.DefaultTerminalTypeId = response.FirstOrDefault().TerminalTypeId;
            }
            return PartialView("TerminalTypeList_PartialView", response);
        }

        [Route("GetTerminalTypeDetails")]
        public JsonResult GetTerminalTypeDetails(TerminalTypeViewModel terminalTypeViewModel)
        {
            var response = terminalTypeDAL.GetTerminalType(terminalTypeViewModel);
            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}