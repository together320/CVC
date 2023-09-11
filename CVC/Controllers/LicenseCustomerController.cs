using CVC.License.Algorithms;
using CVC.License.Algorithms.Forms.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Serenity.Web;
using CVC.Modules.Licensing.Customers;

namespace CVC.Controllers
{
    [RoutePrefix("LicenseCustomer")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(CustomersRow))]

    public class LicenseCustomerController : Controller
    {
        ErrorManagement errorManagement = new ErrorManagement();
        // GET: Customer
        [Route("Index")]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetActivationkey(string UID)
        {
            string ACT_KEY = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading Activation Key");
                if (!string.IsNullOrWhiteSpace(UID))
                {
                    ActivationManagement activationManagement = new ActivationManagement();
                    ACT_KEY = activationManagement.CreateActivationKey(UID);
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(ACT_KEY, JsonRequestBehavior.AllowGet);
        }
        #region Drop down
        public ActionResult GetContactId()
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading Contact Info");
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethodBySPNAME("SP_CUSTOMER_GET_CONTACT_ID_FOR_DROPDOWN");
                lstPersons = GetTableRows(dt);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetContactNumberByContactID(string ContactID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading Contact Number by Contact ID");
                JObject obj = new JObject();
                obj["ID"] = ContactID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_CONTACT_NO_FROM_CONTACT_ID");
                lstPersons = GetTableRows(dt);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetLineId()
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading Line Info");
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethodBySPNAME("SP_CUSTOMER_GET_LINE_ID_FOR_DROPDOWN");
                lstPersons = GetTableRows(dt);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetLocation()
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading Location Info");
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethodBySPNAME("SP_CUSTOMER_GET_LOCATION_FOR_DROPDOWN");
                lstPersons = GetTableRows(dt);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAddressType()
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading Address Type Info");
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethodBySPNAME("SP_CUSTOMER_GET_ADDRESS_TYPE_FOR_DROPDOWN");
                lstPersons = GetTableRows(dt);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAddressTypeCustomer()
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading Address Type Info for Customer");
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethodBySPNAME("[SP_CUSTOMER_GET_ADDRESS_TYPE_CUSTOMER_FOR_DROPDOWN]");
                lstPersons = GetTableRows(dt);
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        #endregion
        public ActionResult GetAllCompanies()
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading Companies Info");
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethodBySPNAME("SP_CUSTOMER_GET_All_COMPANY_Info");
                lstPersons = GetTableRows(dt);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAllCustomers(string CompanyID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading Customer Info");
                JObject obj = new JObject();
                obj["CompanyID"] = CompanyID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_CUSTOMER_BY_ID");
                lstPersons = GetTableRows(dt);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCompanyInfoById(string CompanyID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading Company Info by ID");
                JObject obj = new JObject();
                obj["CompanyID"] = CompanyID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_COMPANY_INFO_BY_ID");
                lstPersons = GetTableRows(dt);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCustomerInfoById(string CompanyID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading Customer Info by ID");
                JObject obj = new JObject();
                obj["CustomerID"] = CompanyID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_CUSTOMER_INFO_BY_ID");
                lstPersons = GetTableRows(dt);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCustomerAllContactInfoById(String CompanyID, string CustomerID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading All Customer Contact Info by ID");
                JObject obj = new JObject();
                obj["CompanyID"] = CompanyID;
                obj["CustomerID"] = CustomerID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_CUSTOMER_ALL_CONTACT_INFO_BY_ID");
                lstPersons = GetTableRows(dt);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCustomerContactInfoById(String CompanyID, string CustomerID, string ContactID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading Customer Contact Info by ID");
                JObject obj = new JObject();
                obj["CompanyID"] = CompanyID;
                obj["CustomerID"] = CustomerID;
                obj["ContactID"] = ContactID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "[SP_CUSTOMER_GET_CUSTOMER_CONTACT_INFO_BY_ID]");
                lstPersons = GetTableRows(dt);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCompanyContactInfoById(String CompanyID, string ContactID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading Company Contact Info by ID");
                JObject obj = new JObject();
                obj["CompanyID"] = CompanyID;
                obj["ContactID"] = ContactID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "[SP_CUSTOMER_GET_COMPANY_CONTACT_INFO_BY_ID]");
                lstPersons = GetTableRows(dt);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCompanyAllContactInfoById(String CompanyID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading All Company Contact Info by ID");
                JObject obj = new JObject();
                obj["CompanyID"] = CompanyID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_COMPANY_ALL_CONTACT_INFO_BY_ID");
                lstPersons = GetTableRows(dt);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCustomerAllUIDById(String CompanyID, string CustomerID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading Customer All UID Contact Info by ID");
                JObject obj = new JObject();
                obj["CompanyID"] = CompanyID;
                obj["CustomerID"] = CustomerID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_CUSTOMER_ALL_UID_INFO_BY_ID");
                lstPersons = GetTableRows(dt);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCustomerUIDById(String CompanyID, string CustomerID, string UIDItemID)
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"loading Customer UID Contact Info by ID");
                JObject obj = new JObject();
                obj["CompanyID"] = CompanyID;
                obj["CustomerID"] = CustomerID;
                obj["UIDItemID"] = UIDItemID;
                //add object data
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethod(obj, "SP_CUSTOMER_GET_CUSTOMER_UID_INFO_BY_ID");
                lstPersons = GetTableRows(dt);
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
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Checking for Unique Info");
                List<Dictionary<string, object>> lstPersons = null;
                try
                {
                    CommonData commonData = new CommonData();
                    var dt = commonData.CheckValueIsUnique(value, name);
                    lstPersons = GetTableRows(dt);
                }
                catch (Exception ex)
                {
                    errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                }
                return Json(lstPersons, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        #region CustomerActions
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CustomerCreate(string LicenseValue)
        {
            ModelCompany abc = new ModelCompany();
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"New Company creation process initiated");
                var jsonq = JsonConvert.DeserializeObject<ModelCompany>(LicenseValue);
                CustomerManage customerManage = new CustomerManage(jsonq);
                abc = customerManage.Create();
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"New Company creation process completed");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(abc, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CustomerUpdate(string LicenseValue)
        {
            ModelCompany abc = new ModelCompany();
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Company update process initiated");
                var jsonq = JsonConvert.DeserializeObject<ModelCompany>(LicenseValue);
                CustomerManage customerManage = new CustomerManage(jsonq);
                abc = customerManage.Update();
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Company update process completed");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(abc, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CustomerDelete(string LicenseValue)
        {
            ModelCompany abc = new ModelCompany();
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Company deletion process initiated");
                var jsonq = JsonConvert.DeserializeObject<ModelCompany>(LicenseValue);
                CustomerManage customerManage = new CustomerManage(jsonq);
                abc = customerManage.Delete();
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Company deletion process completed");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(abc, JsonRequestBehavior.AllowGet);
        }
        #endregion
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