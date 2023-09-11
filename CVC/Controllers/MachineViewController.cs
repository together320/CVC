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


namespace CVC.Controllers
{
    public class MachineViewController : Controller
    {

        CommonServices objCommonServices;
        TerminalRepository _repo;
        MachineDAL machineDAL;
        public MachineViewController()
        {
            _repo = new TerminalRepository();
            objCommonServices = new CommonServices();
            machineDAL = new MachineDAL();
        }


        // GET: MachineView
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("TerminalView")]
        public ActionResult TerminalView()
        {
            CVC.ViewModels.TerminalViewModel terminalViewModel = new CVC.ViewModels.TerminalViewModel();
            var StatusId = (int)ClsConstants.StatusType.Active;
            var machines = objCommonServices.GetAllMachine(StatusId);
            terminalViewModel.machineList = machines.Select((item, index) => new CVC.ViewModels.MachineList
            {
                Id = index + 1,
                MachineId = item.MachineId,
                MachineName = item.MachineName,
                Status = item.StatusId == 1 ? "Active" : "In-Active"
            }).ToList();

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

    }
}