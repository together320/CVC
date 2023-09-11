using CVC.BusinessServices.Common;
using CVC.BusinessServices.DAL;
using CVC.Data.EDMX;
using CVC.OpcUaClient;
using CVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static CVC.BusinessServices.Common.ClsConstants;
using ms = CVC.Modules.Common.CommonServices;

namespace CVC.Controllers
{
    [RoutePrefix("OpcUaClient")]
    [Route("{action=index}")]

    public class OpcUaClientController : Controller
    {
        CommonServices objCommonServices = new CommonServices();
        OPCUaClientDAL oPCUaClientDAL = new OPCUaClientDAL();
        const string requestType = "AddressSpace";
        // GET: OpcUaClient
        public ActionResult Index()
        {       
            ViewBag.MachineList = objCommonServices.GetAllMachine(1,ProtocolType.OPCUaClient);         
            return View();
        }

        [HttpGet]
        public JsonResult ConnectToOpcUaClient(int machineId, string certificateType)
        {
            ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
            var machineCommunicationDetails = objCommonServices.GetMachineCommunicationDetailsByMachineId(machineId);
            machineCommunicationDetails.CertificateType = certificateType;
            var response = clsOpcUaClient.ConnetoOPCUaClient(machineCommunicationDetails);

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetChildNode(int machineId, string nodeId)
        {
            ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
            var machineCommunicationDetails = objCommonServices.GetMachineCommunicationDetailsByMachineId(machineId);
            machineCommunicationDetails.NodeId = nodeId;
            machineCommunicationDetails.RequestType =requestType;
            var addressSpace = clsOpcUaClient.GetAddressSpace(machineCommunicationDetails);
           // var addressSpace = clsOpcUaClient.GetAddressSpace(machineId, machineCommunicationDetails.IPAddress, machineCommunicationDetails.TCPIPPort.ToString(), nodeId, "addressSpace", machineCommunicationDetails.UserName, machineCommunicationDetails.Password);

            return Json(addressSpace, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("GetAddressSpace")]
        public ActionResult GetAddressSpace(int machineId)
        {
            ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
            var machineCommunicationDetails = objCommonServices.GetMachineCommunicationDetailsByMachineId(machineId);
            machineCommunicationDetails.RequestType = requestType;
            var addressSpace = clsOpcUaClient.GetAddressSpace(machineCommunicationDetails);

            //var addressSpace = clsOpcUaClient.GetAddressSpace(machineId,machineCommunicationDetails.IPAddress,machineCommunicationDetails.TCPIPPort.ToString(),"","addressSpace",machineCommunicationDetails.UserName,machineCommunicationDetails.Password);
            if (string.IsNullOrEmpty(addressSpace.Message))
            {
                addressSpace.machineParameterList = objCommonServices.GetAllMachineParaeter(machineId);
                addressSpace.machineParameterList.Insert(0, new MachineParameterList { MachineParameterId = 0, ParameterName = "New Parameter" });
                return PartialView("~/Views/PartialViews/AddressSpace_PartialView.cshtml", addressSpace);
            }
            else
            {
                return Json(new { message ="er", ff =addressSpace.Message },JsonRequestBehavior.AllowGet);
            }
            // return PartialView("AddressSpace_PartialView", addressSpace);
        }

        public JsonResult SaveAddressSpace(AddressSpaceModel addressSpaceModel)
        {           
            var response =oPCUaClientDAL.SaveAddressSpace(addressSpaceModel);
            return Json(response, JsonRequestBehavior.AllowGet);

        }
    }
}