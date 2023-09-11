using CVC.License.Algorithms;
using CVC.License.Algorithms.Forms.Common;
using CVC.License.Algorithms.Models;
using CVC.License.Algorithms.Template;
using CVC.Modules.Licensing.Template;
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
    [RoutePrefix("LicenseTemplate")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(TemplateRow))]

    public class LicenseTemplateController : Controller
    {
        ErrorManagement errorManagement = new ErrorManagement();
        // GET: LicenseTemplate
        [Route("Index")]
        public ActionResult Index()
        {
            return View();
        }
        #region Templates
        public ActionResult GetTemplateById(string TemplateID)
        {
            if (!string.IsNullOrWhiteSpace(TemplateID))
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting template details using ID {TemplateID}, Processing");
                List<Dictionary<string, object>> lstPersons = null;
                try
                {
                    CommonData commonData = new CommonData();
                    var dt = commonData.getTemplateByTemplateId(TemplateID);
                    lstPersons = GetTableRows(dt);
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting template details using ID {TemplateID}, Success");
                }
                catch (Exception ex)
                {
                    errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                }
                return Json(lstPersons, JsonRequestBehavior.AllowGet);
            }
            else
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting template details using ID {TemplateID}, Error-Template ID Missing");
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult DeleteTemplateById(string TemplateID)
        {
            if (!string.IsNullOrWhiteSpace(TemplateID))
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Delete template using ID {TemplateID}, Processing");
                List<Dictionary<string, object>> lstPersons = null;
                try
                {
                    DataTable dtPersons = GetTable();
                    lstPersons = GetTableRows(dtPersons);
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Delete template using ID {TemplateID}, Success");
                }
                catch (Exception ex)
                {
                    errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                }
                return Json(lstPersons, JsonRequestBehavior.AllowGet);
            }
            else
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Delete template using ID {TemplateID}, Error-Template ID Missing");
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        //Based on Template ID
        public ActionResult GetModuleById(string ModuleID, string ActionId, string TemplateID)
        {
            if (!string.IsNullOrWhiteSpace(ModuleID))
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting Module details using ID {TemplateID},{ModuleID}, {ActionId}, Processing");
                List<Dictionary<string, object>> lstPersons = null;
                try
                {
                    CommonData commonData = new CommonData();
                    var dt = commonData.getModuleDetailsByIDS(ModuleID, ActionId, TemplateID);
                    lstPersons = GetTableRows(dt);
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting Module details using ID {TemplateID},{ModuleID}, {ActionId}, Success");
                }
                catch (Exception ex)
                {
                    errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                }
                return Json(lstPersons, JsonRequestBehavior.AllowGet);
            }
            else
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting Module details using ID {ModuleID}, error-Module id missing");
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult GetAllModulesByTemplateID(string TemplateID)
        {
            if (!string.IsNullOrWhiteSpace(TemplateID))
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting All Module using ID {TemplateID}, Processing");
                List<Dictionary<string, object>> lstPersons = null;
                try
                {
                    CommonData commonData = new CommonData();
                    var dt = commonData.getAllModules(TemplateID);
                    lstPersons = GetTableRows(dt);
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting All Module using ID {TemplateID}, Success");
                }
                catch (Exception ex)
                {
                    errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                }
                return Json(lstPersons, JsonRequestBehavior.AllowGet);
            }
            else
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting All Module using ID {TemplateID}, Error-Missing TemplateID");
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TemplateCreate(string TemplateValue)
        {
            string abc = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Create new template , Processing");
                var jsonq = JsonConvert.DeserializeObject<ModelTemplate>(TemplateValue);
                TemplateManage templateManage = new TemplateManage(jsonq);
                abc = templateManage.Create();
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Create new template {abc} , Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(abc, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TemplateUpdate(string TemplateValue)
        {
            string abc = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Update template , Processing");
                var jsonq = JsonConvert.DeserializeObject<ModelTemplate>(TemplateValue);
                TemplateManage templateManage = new TemplateManage(jsonq);
                abc = templateManage.Update();
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Update template {abc}, Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(abc, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TemplateDelete(string TemplateValue)
        {
            string abc = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Delete template , Processing");
                var jsonq = JsonConvert.DeserializeObject<ModelTemplate>(TemplateValue);
                TemplateManage templateManage = new TemplateManage(jsonq);
                abc = templateManage.Delete();
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Delete template {abc}, Success");
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
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all modules, Processing");
                CommonData commonData = new CommonData();
                var dt = commonData.getAllModules(null);
                // DataTable dtPersons = GetTable();
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all modules, Success");
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
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all templates, Processing");
                CommonData commonData = new CommonData();
                var dt = commonData.getAllTemplates();
                lstPersons = GetTableRows(dt);
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Getting all templates, Success");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult CheckValueIsUnique(string value, string name)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                List<Dictionary<string, object>> lstPersons = null;
                try
                {
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Check a template name is unique {value}{name}, Processing");
                    CommonData commonData = new CommonData();
                    var dt = commonData.CheckValueIsUnique(value, name);
                    lstPersons = GetTableRows(dt);
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Check a template name is unique {value}{name}{lstPersons}, Success");
                }
                catch (Exception ex)
                {
                    errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                }
                return Json(lstPersons, JsonRequestBehavior.AllowGet);
            }
            else
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Check a template name is unique {value}{name}, Error-Missing Value");
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        #endregion
        #region Dropdown
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
        public ActionResult GetActionsByModuleID(string ModuleID)
        {
            if (!string.IsNullOrWhiteSpace(ModuleID))
            {
                List<Dictionary<string, object>> lstPersons = null;
                try
                {
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get actions by module id  {ModuleID}, Processing");
                    CommonData commonData = new CommonData();
                    var dt = commonData.getActionsByModuleID(ModuleID);
                    lstPersons = GetTableRows(dt);
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get actions by module id  {ModuleID}, Success");
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
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get license type  {ModuleID},{ActionID}, Processing");
                    CommonData commonData = new CommonData();
                    var dt = commonData.getLicenseType(ModuleID, ActionID);
                    lstPersons = GetTableRows(dt);
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get license type  {ModuleID},{ActionID}, Success");
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
        public ActionResult GetLicenseValue(string ModuleID, string ActionID, string LicenseTypeID, string TemplateID)
        {
            if (!string.IsNullOrWhiteSpace(ModuleID) && !string.IsNullOrWhiteSpace(ActionID) && !string.IsNullOrWhiteSpace(LicenseTypeID))
            {
                List<Dictionary<string, object>> lstPersons = null;
                try
                {
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get license value  {ModuleID},{ActionID}, {LicenseTypeID}, Processing");
                    CommonData commonData = new CommonData();
                    var dt = commonData.getLicenseValue(ModuleID, ActionID, TemplateID, LicenseTypeID);
                    lstPersons = GetTableRows(dt);
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Dropdown request get license value  {ModuleID},{ActionID}, {LicenseTypeID}, Success");
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
        #endregion
        public DataTable GetTable()
        {
            DataTable dtTable = new DataTable();
            //dtTable.Columns.Add("UserID", typeof(int));
            //dtTable.Columns.Add("FirstName", typeof(string));
            //dtTable.Columns.Add("LastName", typeof(string));
            //dtTable.Rows.Add(25, "Ave", "Maria");
            //dtTable.Rows.Add(50, "Bill", "Doe")=
            //dtTable.Rows.Add(75, "John", "Gates");
            //dtTable.Rows.Add(99, "Julia", "Griffith");
            //dtTable.Rows.Add(100, "Mylie", "Spears");
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
    }
}