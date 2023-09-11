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
    [RoutePrefix("License")]
    [Route("{action=Index}")]
    [PageAuthorize(typeof(LicenseListRow))]

    public class LicenseController : Controller
    {
        ErrorManagement errorManagement = new ErrorManagement();
        // GET: LicenseTemplate

        [Route("Index")]
        public ActionResult Index()
        {
            return View();
        }
        #region License
        public ActionResult GetLicenseById(string LicenseID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting license details using ID {LicenseID}, Processing");
                JObject obj = new JObject();
                obj["ID"] = LicenseID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_LICENSE_GET_BY_LICENSEID");
                lstPersons = GetTableRows(dt);
                // errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting license details using ID {LicenseID}, Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        //public ActionResult DeleteLicenseById(string LicenseID)
        //{
        //    List<Dictionary<string, object>> lstPersons = null;
        //    if (!string.IsNullOrWhiteSpace(LicenseID))
        //    {
        //        try
        //        {
        //            DataTable dtPersons = GetTable();
        //            lstPersons = GetTableRows(dtPersons);
        //        }
        //        catch (Exception ex)
        //        {
        //            errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
        //        }
        //        return Json(lstPersons, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(null, JsonRequestBehavior.AllowGet);
        //    }
        //}
        //Based on License ID
        public ActionResult GetModuleById(string ModuleID, string ActionId, string LicenseID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting Module details using ID with license,module,action id  {LicenseID},{ModuleID}, {ActionId}, Processing");
                JObject obj = new JObject();
                obj["ModuleID"] = ModuleID;
                obj["ActionId"] = ActionId;
                obj["LicenseID"] = LicenseID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_LICENSE_GET_MODULE_BY_LICENSE_ID");
                lstPersons = GetTableRows(dt);
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting Module details using ID with license,module,action id  {LicenseID},{ModuleID}, {ActionId}, Success");
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
                //   errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all Module using ID with license id  {LicenseID}, Processing");
                JObject obj = new JObject();
                obj["LicenseID"] = LicenseID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_LICENSE_GET_ALL_MODULES_BY_LICENSE_ID");
                lstPersons = GetTableRows(dt);
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all Module using ID with license id  {LicenseID}, Success");
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
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all Module using ID with Template id  {TemplateId}, Processing");
                JObject obj = new JObject();
                obj["TemplateId"] = TemplateId;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_TEMPLATE_GET_ALL_MODULES_BY_TEMPLATE_ID_V1");
                lstPersons = GetTableRows(dt);
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all Module using ID with Template id  {TemplateId}, Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LicenseCreate(string LicenseValue)
        {
            ModelNewLicense abc = new ModelNewLicense();
            try
            {
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Create new license , Processing");
                var jsonq = JsonConvert.DeserializeObject<ModelNewLicense>(LicenseValue);
                NewLicenseManage newLicenseManage = new NewLicenseManage(jsonq);
                abc = newLicenseManage.Create();
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Created new license , Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(abc, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LicenseUpdate(string LicenseValue)
        {
            ModelNewLicense abc = new ModelNewLicense();
            try
            {
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Update license , Processing");
                var jsonq = JsonConvert.DeserializeObject<ModelNewLicense>(LicenseValue);
                NewLicenseManage newLicenseManage = new NewLicenseManage(jsonq);
                abc = newLicenseManage.Update();
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Updated license , Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(abc, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LicenseDelete(string LicenseValue)
        {
            ModelNewLicense abc = new ModelNewLicense();
            try
            {
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Delete license , Processing");
                var jsonq = JsonConvert.DeserializeObject<ModelNewLicense>(LicenseValue);
                NewLicenseManage newLicenseManage = new NewLicenseManage(jsonq);
                abc = newLicenseManage.Delete();
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Update license , Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(abc, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #region Common
        public ActionResult GetAllModulesData()
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                // errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all modules license, Processing");
                CommonData commonData = new CommonData();
                var dt = commonData.getAllModules(null);
                // DataTable dtPersons = GetTable();
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all modules license, Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #region Dropdown
        public ActionResult GetAllModules()
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request, Processing");
                CommonData commonData = new CommonData();
                var dt = commonData.getAllModulesForDropDown();
                lstPersons = GetTableRows(dt);
                // errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request, Success");
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
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request to get al templates, Processing");
                CommonData commonData = new CommonData();
                var dt = commonData.getAllTemplateForDropDown();
                lstPersons = GetTableRows(dt);
                // errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request to get al templates, Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetActionsByModuleID(string ModuleID)
        {
            if (!string.IsNullOrWhiteSpace(ModuleID))
            {
                List<Dictionary<string, object>> lstPersons = null;
                try
                {
                    // errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get actions by module id  {ModuleID}, Processing");
                    CommonData commonData = new CommonData();
                    var dt = commonData.getActionsByModuleID(ModuleID);
                    lstPersons = GetTableRows(dt);
                    //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get actions by module id  {ModuleID}, Success");
                }
                catch (Exception ex)
                {
                    errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                }
                return Json(lstPersons, JsonRequestBehavior.AllowGet);
            }
            else
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get actions by module id  {ModuleID}, Error-Missing Module ID");
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult GetLicenseType(string ModuleID, string ActionID)
        {
            if (!string.IsNullOrWhiteSpace(ModuleID) && !string.IsNullOrWhiteSpace(ActionID))
            {
                List<Dictionary<string, object>> lstPersons = null;
                try
                {
                    //   errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get license type  {ModuleID},{ActionID}, Processing");
                    CommonData commonData = new CommonData();
                    var dt = commonData.getLicenseType(ModuleID, ActionID);
                    lstPersons = GetTableRows(dt);
                    //   errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get license type  {ModuleID},{ActionID}, Success");
                }
                catch (Exception ex)
                {
                    errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                }
                return Json(lstPersons, JsonRequestBehavior.AllowGet);
            }
            else
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get license type  {ModuleID},{ActionID}, Error- Missing Module id or Action id");
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult GetLicenseValue(string ModuleID, string ActionID, string LicenseTypeID, string LicenseID)
        {
            if (!string.IsNullOrWhiteSpace(ModuleID) && !string.IsNullOrWhiteSpace(ActionID) && !string.IsNullOrWhiteSpace(LicenseTypeID))
            {
                List<Dictionary<string, object>> lstPersons = null;
                try
                {
                    //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get license value  {ModuleID},{ActionID}, {LicenseTypeID}, Processing");
                    CommonData commonData = new CommonData();
                    var dt = commonData.getLicenseValue(ModuleID, ActionID, LicenseID, LicenseTypeID);
                    lstPersons = GetTableRows(dt);
                    //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get license value  {ModuleID},{ActionID}, {LicenseTypeID}, Success");
                }
                catch (Exception ex)
                {
                    errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                }
                return Json(lstPersons, JsonRequestBehavior.AllowGet);
            }
            else
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get license value  {ModuleID},{ActionID}, {LicenseTypeID}, Error-Missing ID");
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult GetMasterLicenseType()
        {
            //add object data
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                //   errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get master license type , Processing");
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
        #endregion
        public DataTable GetTable()
        {
            DataTable dtTable = new DataTable();
            dtTable.Columns.Add("UserID", typeof(int));
            dtTable.Columns.Add("FirstName", typeof(string));
            dtTable.Columns.Add("LastName", typeof(string));
            dtTable.Rows.Add(25, "Ave", "Maria");
            dtTable.Rows.Add(50, "Bill", "Doe");
            dtTable.Rows.Add(75, "John", "Gates");
            dtTable.Rows.Add(99, "Julia", "Griffith");
            dtTable.Rows.Add(100, "Mylie", "Spears");
            return dtTable;
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
        #region license
        public ActionResult getUIDByCustomerId(string COMPANYID, string CUSTOMERID, string LINEID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting UID by customer id {COMPANYID},{CUSTOMERID},{LINEID} , Processing");
                JObject obj = new JObject();
                obj["ID"] = COMPANYID;
                obj["CUSTOMERID"] = CUSTOMERID;
                obj["LINEID"] = LINEID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_UID_BY_CUSTOMERID");
                lstPersons = GetTableRows(dt);
                // errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting UID by customer id {COMPANYID},{CUSTOMERID},{LINEID} , Success");
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
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting location by company id {ID}, Processing");
                JObject obj = new JObject();
                obj["ID"] = ID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_LOCATION_BY_COMPANY");
                lstPersons = GetTableRows(dt);
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting location by company id {ID}, Success");
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
                //   errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting line id by customer id {COMPANYID},{CUSTOMERID}, Processing");
                JObject obj = new JObject();
                obj["ID"] = COMPANYID;
                obj["CUSTOMERID"] = CUSTOMERID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_LINEID_BY_CUSTOMERID");
                lstPersons = GetTableRows(dt);
                // errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting line id by customer id {COMPANYID},{CUSTOMERID}, Success");
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
                //   errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting customer by company id {ID},{LOCATION},{ADDRESSTYPE}, Processing");
                JObject obj = new JObject();
                obj["ID"] = ID;
                obj["LOCATION"] = LOCATION;
                obj["ADDRESSTYPE"] = ADDRESSTYPE;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_CUSTOMER_BY_COMPANY");
                lstPersons = GetTableRows(dt);
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting customer by company id {ID},{LOCATION},{ADDRESSTYPE}, Success");
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
                //   errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting company list, Processing");
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethodBySPNAME("SP_CUSTOMER_GET_COMPANY");
                lstPersons = GetTableRows(dt);
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting company list, Success");
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
                //    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting address type by company,{ID},{LOCATION} Processing");
                JObject obj = new JObject();
                obj["ID"] = ID;
                obj["LOCATION"] = LOCATION;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_ADDRESSTYPE_BY_COMPANY");
                lstPersons = GetTableRows(dt);
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting address type by company,{ID},{LOCATION} Success");
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
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all licenses ,Processing");
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethodBySPNAME("SP_LICENSE_GET_ALL_LICENSES");
                lstPersons = GetTableRows(dt);
                //  errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all licenses ,Success");
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
            string filepath = "", filename = "";
            try
            {
                //   errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Download license file,Processing");
                JObject obj = new JObject();
                obj["ID"] = ID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_LICENSE_GET_FILE_URL_BY_FILEID");

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
                filename = filename.Replace(",", "_").Replace(";", "_");
                //Response.ContentType = contentType;
                Response.AddHeader("Content-Disposition", string.Format("attachment; filename=\"{0}\"", filename));

            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            if (filedata == null || string.IsNullOrWhiteSpace(filename))
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Download license file is either empty or file name is blank,Error ");
                Response.ClearHeaders();
                Response.ClearContent();
                Response.Clear();
                return new EmptyResult();
            }
            else
            {
                LicenseDownloaded(ID);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Download license file,Success");
                return File(filedata, System.Net.Mime.MediaTypeNames.Text.Plain);
            }

        }
        #endregion       
        private bool LicenseDownloaded(string ID)
        {
            bool Flag_Status = false;
            if (!string.IsNullOrWhiteSpace(ID))
            {
                List<Dictionary<string, object>> lstPersons = null;
                try
                {
                    CommonData commonData = new CommonData();
                    var dt = commonData.LicenseDownloadedFlag(ID);
                    lstPersons = GetTableRows(dt);
                    Flag_Status = true;
                }
                catch (Exception ex)
                {
                    errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Null", ex);
                }
            }
            else
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Values supplied is not valid {ID}");
            }
            return Flag_Status;
        }
         
    }
}