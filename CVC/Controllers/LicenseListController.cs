using CVC.License.Algorithms;
using CVC.License.Algorithms.Forms.Common;
using CVC.License.Algorithms.Forms.License_New;
using CVC.License.Algorithms.Models;
using CVC.License.Algorithms.Template;
using CVC.Modules.Licensing.LicenseList;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CVC.Controllers
{
    [RoutePrefix("LicenseList")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(LicenseListRow))]

    public class LicenseListController : Controller
    {
        // GET: LicenseList
        ErrorManagement errorManagement = new ErrorManagement();
        [Route("Index")]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetLicenseById(string LicenseID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting license details using ID {LicenseID}, Processing");
                JObject obj = new JObject();
                obj["ID"] = LicenseID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_LICENSE_GET_BY_LICENSEID");
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting license details using ID {LicenseID}, Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAllModulesByLicenseID(string LicenseID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all Module using ID with license id  {LicenseID}, Processing");
                JObject obj = new JObject();
                obj["LicenseID"] = LicenseID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_LICENSE_GET_ALL_MODULES_BY_LICENSE_ID");
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all Module using ID with license id  {LicenseID}, Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAllModulesByTemplateID(string TemplateId)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all Module using ID with Template id  {TemplateId}, Processing");
                JObject obj = new JObject();
                obj["TemplateId"] = TemplateId;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_TEMPLATE_GET_ALL_MODULES_BY_TEMPLATE_ID_V1");
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all Module using ID with Template id  {TemplateId}, Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAllModules()
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request, Processing");
                CommonData commonData = new CommonData();
                var dt = commonData.getAllModulesForDropDown();
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request, Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAllTemplates()
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request to get al templates, Processing");
                CommonData commonData = new CommonData();
                var dt = commonData.getAllTemplateForDropDown();
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request to get al templates, Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetMasterLicenseType()
        {
            //add object data
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get master license type , Processing");
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethodBySPNAME("SP_LICENSE_GET_MASTER_LICENSE_TYPE");
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get master license type , Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult getUIDByCustomerId(string COMPANYID, string CUSTOMERID, string LINEID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting UID by customer id {COMPANYID},{CUSTOMERID},{LINEID} , Processing");
                JObject obj = new JObject();
                obj["ID"] = COMPANYID;
                obj["CUSTOMERID"] = CUSTOMERID;
                obj["LINEID"] = LINEID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_UID_BY_CUSTOMERID");
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting UID by customer id {COMPANYID},{CUSTOMERID},{LINEID} , Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult getLocationByCompany(string ID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting location by company id {ID}, Processing");
                JObject obj = new JObject();
                obj["ID"] = ID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_LOCATION_BY_COMPANY");
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting location by company id {ID}, Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult getLineIdByCustomerid(string COMPANYID, string CUSTOMERID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting line id by customer id {COMPANYID},{CUSTOMERID}, Processing");
                JObject obj = new JObject();
                obj["ID"] = COMPANYID;
                obj["CUSTOMERID"] = CUSTOMERID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_LINEID_BY_CUSTOMERID");
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting line id by customer id {COMPANYID},{CUSTOMERID}, Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult getCustomerByCompany(string ID, string LOCATION, string ADDRESSTYPE)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting customer by company id {ID},{LOCATION},{ADDRESSTYPE}, Processing");
                JObject obj = new JObject();
                obj["ID"] = ID;
                obj["LOCATION"] = LOCATION;
                obj["ADDRESSTYPE"] = ADDRESSTYPE;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_CUSTOMER_BY_COMPANY");
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting customer by company id {ID},{LOCATION},{ADDRESSTYPE}, Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult getCompany()
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting company list, Processing");
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethodBySPNAME("SP_CUSTOMER_GET_COMPANY");
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting company list, Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult getAddressTypeByCompany(string ID, string LOCATION)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting address type by company,{ID},{LOCATION} Processing");
                JObject obj = new JObject();
                obj["ID"] = ID;
                obj["LOCATION"] = LOCATION;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_ADDRESSTYPE_BY_COMPANY");
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting address type by company,{ID},{LOCATION} Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAllLicenses()
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all licenses ,Processing");
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethodBySPNAME("SP_LICENSE_GET_ALL_LICENSES");
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all licenses ,Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult DownloadLicenseFile(string ID)
        {
            byte[] filedata = null;
            string contentType = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Download license file,Processing");
                JObject obj = new JObject();
                obj["ID"] = ID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_LICENSE_GET_FILE_URL_BY_FILEID");
                string filepath = "", filename = "";
                var cd = new System.Net.Mime.ContentDisposition();
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        filepath = dt.Rows[0]["FILEURL"].ToString();
                        filename = dt.Rows[0]["FILENAME"].ToString();
                    }
                }
                if (filepath.Trim().Length > 0)
                {
                    filedata = System.IO.File.ReadAllBytes(filepath);
                    contentType = MimeMapping.GetMimeMapping(filepath);
                    cd = new System.Net.Mime.ContentDisposition
                    {
                        FileName = filename,
                        Inline = true,
                    };
                }
                else
                {
                    filedata = null;
                    contentType = null;
                }
                Response.AppendHeader("Content-Disposition", cd.ToString());
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Download license file,Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return File(filedata, System.Net.Mime.MediaTypeNames.Application.Octet, contentType);
        }
        public List<Dictionary<string, object>> GetTableRows(DataTable dtData)
        {
            List<Dictionary<string, object>>
            lstRows = new List<Dictionary<string, object>>();
            Dictionary<string, object> dictRow = null;
            try
            {
                foreach (DataRow dr in dtData.Rows)
                {
                    dictRow = new Dictionary<string, object>();
                    foreach (DataColumn col in dtData.Columns)
                    {
                        dictRow.Add(col.ColumnName, dr[col]);
                    }
                    lstRows.Add(dictRow);
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return lstRows;
        }
    }
}