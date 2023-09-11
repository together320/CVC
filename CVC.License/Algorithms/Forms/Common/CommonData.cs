using CVC.License.Algorithms.DBCONNECTIONS;
using CVC.License.Algorithms.Transforming;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

namespace CVC.License.Algorithms.Forms.Common
{
    public class CommonData
    {
        private DBConnections dBConnections;
        ErrorManagement errorManagement = new ErrorManagement();
        #region Template
        public DataTable getAllModules(string TemplateID)
        {
            bool flag = false;
            string SPNAME;

            if (!string.IsNullOrWhiteSpace(TemplateID))
            {
                SPNAME = "SP_TEMPLATE_GET_ALL_MODULES_BY_TEMPLATE_ID";
            }
            else
            {
                SPNAME = "SP_TEMPLATE_GET_ALL_MODULES";
            }
            DataTable dataTable = new DataTable();
            try
            {
                //Need to Validate Object code missing
                dBConnections = new DBConnections();

                DataSet ds = dBConnections.ReceiveData(TemplateID, SPNAME);
                if (ds != null)
                {
                    int index = 0;
                    foreach (DataTable table in ds.Tables)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (index == 0)
                            {
                                dataTable = table;
                                return dataTable;

                            }

                        }
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {

                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        public DataTable getAllTemplates()
        {
            bool flag = false;

            string SPNAME;
            SPNAME = "SP_TEMPLATE_GET_ALL_TEMPLATES";

            DataTable dataTable = new DataTable();
            try
            {
                //Need to Validate Object code missing
                dBConnections = new DBConnections();

                DataSet ds = dBConnections.ReceiveData(null, SPNAME);
                if (ds != null)
                {
                    int index = 0;
                    foreach (DataTable table in ds.Tables)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (index == 0)
                            {
                                dataTable = table;
                                return dataTable;

                            }

                        }
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {

                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        public DataTable getModuleDetailsByIDS(string ModuleID, string ActionId, string TemplateID)
        {
            bool flag = false;
            string SPNAME;
            DataTable dataTable = new DataTable();
            try
            {
                if (!string.IsNullOrWhiteSpace(ModuleID) && !string.IsNullOrWhiteSpace(ActionId) && !string.IsNullOrWhiteSpace(TemplateID))
                {
                    SPNAME = "SP_TEMPLATE_GET_MODULE_BY_TEMPLATE_ID";
                }
                else
                {
                    //SPNAME = "SP_TEMPLATE_GET_ALL_MODULES";
                    return dataTable;
                }
                JObject obj = new JObject();
                obj["ModuleID"] = ModuleID;
                obj["ActionId"] = ActionId;
                obj["TemplateID"] = TemplateID;
                //Need to Validate Object code missing
                dBConnections = new DBConnections();

                DataSet ds = dBConnections.ReceiveDataUsingObject(obj, SPNAME);
                if (ds != null)
                {
                    int index = 0;
                    foreach (DataTable table in ds.Tables)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (index == 0)
                            {
                                dataTable = table;
                                return dataTable;

                            }

                        }
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {

                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        public DataTable getTemplateByTemplateId(string TemplateID)
        {
            bool flag = false;
            string SPNAME;
            if (!string.IsNullOrWhiteSpace(TemplateID))
            {
                SPNAME = "SP_TEMPLATE_GET_TEMPLATE_BY_TEMPLATE_ID";
            }
            else
            {
                SPNAME = "SP_TEMPLATE_GET_ALL_MODULES";
            }
            DataTable dataTable = new DataTable();
            try
            {
                //Need to Validate Object code missing
                JObject obj = new JObject();
                obj["TemplateID"] = TemplateID;
                dBConnections = new DBConnections();

                DataSet ds = dBConnections.ReceiveDataUsingObject(obj, SPNAME);
                if (ds != null)
                {
                    int index = 0;
                    foreach (DataTable table in ds.Tables)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (index == 0)
                            {
                                dataTable = table;
                                return dataTable;

                            }

                        }
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {

                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        public DataTable CheckValueIsUnique(string value, string type)
        {
            bool flag = false;
            string SPNAME;

            SPNAME = "SP_COMMON_FIND_VALUE_UNIQUE";

            DataTable dataTable = new DataTable();
            try
            {
                //Need to Validate Object code missing
                JObject obj = new JObject();
                obj["Value"] = value;
                obj["Name"] = type;

                dBConnections = new DBConnections();

                DataSet ds = dBConnections.ReceiveDataUsingObject(obj, SPNAME);
                if (ds != null)
                {
                    int index = 0;
                    foreach (DataTable table in ds.Tables)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (index == 0)
                            {
                                dataTable = table;
                                return dataTable;

                            }

                        }
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {

                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        public DataTable LicenseDownloadedFlag(string ID)
        {
            bool flag = false;
            string SPNAME;
            if (!string.IsNullOrWhiteSpace(ID))
            {
                SPNAME = "SP_LICENSE_UPDATE_DOWNLOADED";
            }    
            else
            {
                SPNAME = null;
            }
            DataTable dataTable = new DataTable();
            try
            {
                //Need to Validate Object code missing
                JObject obj = new JObject();
                obj["DownloadID"] = ID;
                dBConnections = new DBConnections();
                DataSet ds = dBConnections.ReceiveDataUsingObject(obj, SPNAME);
                if (ds != null)
                {
                    int index = 0;
                    foreach (DataTable table in ds.Tables)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (index == 0)
                            {
                                dataTable = table;
                                return dataTable;
                            }
                        }
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {

                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        #region DropDowns
        public DataTable getAllTemplateForDropDown()
        {
            bool flag = false;

            string SPNAME;
            SPNAME = "SP_TEMPLATE_GET_ALL_TEMPLATES_FOR_DROPDOWN";

            DataTable dataTable = new DataTable();
            try
            {
                //Need to Validate Object code missing
                dBConnections = new DBConnections();

                DataSet ds = dBConnections.ReceiveData(null, SPNAME);
                if (ds != null)
                {
                    int index = 0;
                    foreach (DataTable table in ds.Tables)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (index == 0)
                            {
                                dataTable = table;
                                return dataTable;

                            }
                        }
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {

                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        public DataTable getAllModulesForDropDown()
        {
            bool flag = false;

            string SPNAME;
            SPNAME = "SP_TEMPLATE_GET_ALL_MODULES_FOR_DROPDOWN";

            DataTable dataTable = new DataTable();
            try
            {
                //Need to Validate Object code missing
                dBConnections = new DBConnections();

                DataSet ds = dBConnections.ReceiveData(null, SPNAME);
                if (ds != null)
                {
                    int index = 0;
                    foreach (DataTable table in ds.Tables)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (index == 0)
                            {
                                dataTable = table;
                                return dataTable;

                            }

                        }
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {

                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        public DataTable getActionsByModuleID(string ModuleID)
        {
            bool flag = false;
            string SPNAME;
            if (!string.IsNullOrWhiteSpace(ModuleID))
            {
                SPNAME = "SP_TEMPLATE_GET_ALL_ACTIONS_BY_MODULE_ID_FOR_DROPDOWN";
            }
            else
            {
                SPNAME = "SP_TEMPLATE_GET_ALL_MODULES";
            }
            DataTable dataTable = new DataTable();
            try
            {
                //Need to Validate Object code missing
                dBConnections = new DBConnections();

                DataSet ds = dBConnections.ReceiveData(ModuleID, SPNAME);
                if (ds != null)
                {
                    int index = 0;
                    foreach (DataTable table in ds.Tables)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (index == 0)
                            {
                                dataTable = table;
                                return dataTable;

                            }

                        }
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {

                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        public DataTable getLicenseType(string ModuleID, string ActionID)
        {
            bool flag = false;
            string SPNAME;
            DataTable dataTable = new DataTable();
            try
            {
                if (!string.IsNullOrWhiteSpace(ModuleID) && !string.IsNullOrWhiteSpace(ActionID))
                {
                    SPNAME = "SP_TEMPLATE_GET_LICENSE_TYPE_BY_IDS_FOR_DROPDOWN";
                }
                else
                {
                    //SPNAME = "SP_TEMPLATE_GET_ALL_MODULES";
                    return dataTable;
                }
                JObject obj = new JObject();
                obj["ModuleID"] = ModuleID;
                obj["ActionId"] = ActionID;
                //Need to Validate Object code missing
                dBConnections = new DBConnections();

                DataSet ds = dBConnections.ReceiveDataUsingObject(obj, SPNAME);
                if (ds != null)
                {
                    int index = 0;
                    foreach (DataTable table in ds.Tables)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (index == 0)
                            {
                                dataTable = table;
                                return dataTable;

                            }

                        }
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {

                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        public DataTable getLicenseValue(string ModuleID, string ActionId, string TemplateID, string LicenseType)
        {
            bool flag = false;
            string SPNAME;
            DataTable dataTable = new DataTable();
            try
            {
                if (!string.IsNullOrWhiteSpace(ModuleID) && !string.IsNullOrWhiteSpace(ActionId) && !string.IsNullOrWhiteSpace(TemplateID) && !string.IsNullOrWhiteSpace(LicenseType))
                {
                    SPNAME = "SP_TEMPLATE_GET_LICENSE_VALUE";
                }
                else
                {
                    //SPNAME = "SP_TEMPLATE_GET_ALL_MODULES";
                    return dataTable;
                }
                JObject obj = new JObject();
                obj["ModuleID"] = ModuleID;
                obj["ActionId"] = ActionId;
                obj["TemplateID"] = TemplateID;
                obj["LicenseType"] = LicenseType;
                //Need to Validate Object code missing
                dBConnections = new DBConnections();

                DataSet ds = dBConnections.ReceiveDataUsingObject(obj, SPNAME);
                if (ds != null)
                {
                    int index = 0;
                    foreach (DataTable table in ds.Tables)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (index == 0)
                            {
                                dataTable = table;
                                return dataTable;

                            }

                        }
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {

                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        #endregion
        #endregion
        #region License
        public DataTable getCommonMethod(JObject jObject, string SPNAME)
        {
            bool flag = false;
            //string SPNAME;
            //SPNAME = "SP_CUSTOMER_GET_UID_BY_CUSTOMERID";
            DataTable dataTable = new DataTable();
            try
            {
                dBConnections = new DBConnections();

                DataSet ds = dBConnections.ReceiveDataUsingObject(jObject, SPNAME);
                if (ds != null)
                {
                    int index = 0;
                    foreach (DataTable table in ds.Tables)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (index == 0)
                            {
                                dataTable = table;
                                return dataTable;

                            }

                        }
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {

                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        public DataTable getCommonMethodBySPNAME(string SPNAME)
        {
            bool flag = false;
            DataTable dataTable = new DataTable();
            try
            {
                //Need to Validate Object code missing
                dBConnections = new DBConnections();

                DataSet ds = dBConnections.ReceiveData(null, SPNAME);
                if (ds != null)
                {
                    int index = 0;
                    foreach (DataTable table in ds.Tables)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (index == 0)
                            {
                                dataTable = table;
                                return dataTable;

                            }

                        }
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {

                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        public string DecryptToJsonString(string cipherText, string AESKEY)
        {
            //Check Here
            string decryptedText;
            try
            {
                //DECLARATION
                SecurityController keyManagement = new SecurityController();
                if (cipherText != null)
                {
                    if (cipherText.Length > 0)
                    {
                        decryptedText = keyManagement.Decrypt(AESKEY, cipherText);
                    }
                    else
                    {
                        decryptedText = null;
                    }
                }
                else
                {
                    decryptedText = null;
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
                decryptedText = null;
            }
            return decryptedText;
        }
        public DataTable ConvertJsonToDt(string json)
        {
            //Check Here
            DataTable dataTable;
            try
            {
                if (json != null)
                {
                    if (json.Length > 0)
                    {
                        dataTable = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
                    }
                    else
                    {
                        Console.WriteLine("rewrite content");
                        dataTable = null;
                    }
                }
                else
                {
                    Console.WriteLine("rewrite content");
                    dataTable = null;
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
                dataTable = null;
            }
            return dataTable;
        }
        #endregion
    }
}