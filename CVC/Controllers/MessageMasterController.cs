using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVC.BusinessServices.DAL;
using CVC.BusinessServices.Interface;
using CVC.Modules.MachineCustomization.Message;
using CVC.Modules.MachineCustomization.TerminalType;
using CVC.ViewModels;
using Serenity.Web;

namespace CVC.Controllers
{
    [RoutePrefix("MessageMaster")]
    [PageAuthorize(typeof(MessageRow))]

    public class MessageMasterController : Controller
    {
        MessageMasterDAL messageMasterDAL;
        CVC.BusinessServices.Common.CommonServices commonServices = new BusinessServices.Common.CommonServices();

        public MessageMasterController()
        {
            messageMasterDAL = new MessageMasterDAL();
        }
        // GET: TerminalType
        [Route("Index")]
        public ActionResult Index()
        {
            CVC.Data.EDMX.PickList pickList = new Data.EDMX.PickList();
            pickList.PickListId = 19;
            ViewBag.MessageTypeList = commonServices.GetPickListValue_ByPickListId(pickList);
            return View();
        }

        [Route("GetAllMessageMaster")]
        public PartialViewResult GetAll_MessageMaster(MessageMasterViewModel messageMasterViewModel)
        {
            var response = messageMasterDAL.GetAll_MessageMaster(messageMasterViewModel);
            if (response.Count > 0)
            {
                ViewBag.DefaultMessageMasterId = response.FirstOrDefault().MessageMasterId;
            }
            return PartialView("MessageList_PartialView", response);
        }

        [Route("GetByIdMessageMaster")]
        public JsonResult GetById_MessageMaster(MessageMasterViewModel messageMasterViewModel)
        {
            var response = messageMasterDAL.GetById_MessageMaster(messageMasterViewModel);           
            return Json(response,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("CreateMessageMaster")]
        public JsonResult Create_MessageMaster(MessageMasterViewModel messageMasterViewModel)
        {
            object response = "";
            if (ModelState.IsValid)
            {
                response = messageMasterDAL.Create_MessageMaster(messageMasterViewModel);
            }
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("UpdateMessageMaster")]
        public JsonResult Update_MessageMaster(MessageMasterViewModel messageMasterViewModel)
        {
            object response = "";
            if (ModelState.IsValid)
            {
                response = messageMasterDAL.Update_MessageMaster(messageMasterViewModel);
            }
            return Json(response, JsonRequestBehavior.AllowGet);
        }

     
    }
}