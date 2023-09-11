using CVC.License.Algorithms;
using CVC.License.Algorithms.DBCONNECTIONS;
using CVC.License.Algorithms.Forms.Common;
using CVC.License.Algorithms.Forms.Models;
using CVC.License.Algorithms.License;
using CVC.Modules.Licensing.LicenseUpload;
using Newtonsoft.Json.Linq;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
//using System.Web.SessionState;

namespace CVC.Controllers
{
    [RoutePrefix("LicenseUpload")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(LicenseUploadRow))]
    //[SessionState(SessionStateBehavior.Disabled)]

    public class LicenseUploadController : Controller
    {
        ErrorManagement errorManagement = new ErrorManagement();
        // GET: LicenseUpload
        [Route("Index")]
        public ActionResult Index(int? Code)
        {
            return View();
        }
        public ActionResult GetUID()
        {
            UIDManagement uIDManagement = new UIDManagement();
            ModelLicenseUpload modelLicenseUpload = new ModelLicenseUpload();
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Loading UID in Progress");
                modelLicenseUpload.UID = uIDManagement.CreateUID();
                Logic.db = null;
                Logic.GetLicenseData();
                modelLicenseUpload.IsActivated = Logic.isActivationValid;
                modelLicenseUpload.isLicenseFileValid = Logic.isLicenseFileValid;
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Loading UID Completed");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(modelLicenseUpload, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetLicenseExpiryCount()
        {
            int count = 0;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Loading License Count in Progress");
                count = Logic.LTypeValue;
                if (count < 10)
                {
                    count = 0;
                }
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Loading License Count Completed");
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(count, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCurrentLicenseInfo()
        {
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Loading Current License Info in Progress");
                //Logic.db = null;
                //Logic.LogicImplementation();
                Logic.db = Logic.GetLicenseData();
                DataTable ProcessesContent = new DataTable();
                JObject obj = new JObject();
                //obj["Key"] = Key;
                CommonData commonData = new CommonData();
                ProcessesContent = commonData.getCommonMethodBySPNAME("[CS_SP_GET_LICENSE_INFO]");
                if (ProcessesContent != null)
                {
                    using (ProcessesContent = ProcessLicenseInfo(ProcessesContent))
                    {
                        if (ProcessesContent != null)
                        {
                            lstPersons = GetTableRows(ProcessesContent);
                        }
                    }
                }
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Loading Current License Info Completed");
                return Json(lstPersons, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(lstPersons, JsonRequestBehavior.AllowGet);
        }
        private DataTable ProcessLicenseInfo(DataTable processesContent)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = Logic.db.Copy();
                if (dt != null)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        foreach (DataRow Displayitem in processesContent.Rows)
                        {
                            //Todo: Checking against Module ID
                            _ = int.TryParse(item["ModuleID"].ToString(), out int SourceControllerID);
                            _ = int.TryParse(Displayitem["MODULEID"].ToString(), out int DestControllerID);
                            if (SourceControllerID == DestControllerID)
                            {
                                item["CONTROLLER"] = Displayitem["MODULEDISPLAYNAME"];
                            }
                            //Todo: Checking against Action ID
                            _ = int.TryParse(item["ActionID"].ToString(), out int SourceActionID);
                            _ = int.TryParse(Displayitem["ACTIONID"].ToString(), out int DestActionID);
                            if (SourceActionID == DestActionID)
                            {
                                item["ACTION"] = Displayitem["ACTIONDISPLAYNAME"];
                            }
                        }
                    }
                    string[] selectedColumns = new[] { "Controller", "Action", "LicenseValue", "LicenseCurrentValue", "LicenseType" };
                    dt = new DataView(dt).ToTable(false, selectedColumns);
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dt;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UploadLicenseFile()
        {
            ModelFileUpload model = new ModelFileUpload();
            List<Dictionary<string, object>> lstPersons = null;
            try
            {
                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Uploading License File, Processing");
                HttpFileCollectionBase files = Request.Files;
                string type = Request.Form["type"].ToString();
                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFileBase httpPostedFileBase = files[i];
                    if (httpPostedFileBase != null)
                    {
                        model.File = httpPostedFileBase;
                        model.FileName = DateTime.Now.ToFileTimeUtc().ToString() + httpPostedFileBase.FileName;
                        model.ContentType = httpPostedFileBase.ContentType;
                        model.FileType = type;
                        //string serverPath = Path.Combine(Properties.Settings.Default.LicenseUploadPath + "\\", model.FileType.ToUpper(), model.FileName);
                        string serverPath = Path.Combine(Properties.Settings.Default.LicenseUploadPath + "\\", model.FileName);
                        model.FilePath = serverPath;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            httpPostedFileBase.InputStream.CopyTo(ms);
                            model.FileContent = ms.ToArray();
                        }
                        UploadLicense(model);
                        var dt = ReadDataFromFile(model);
                        if (dt == null)
                        {
                            errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Uploading License File is invalid");
                            //return RedirectToAction("LicenseActionInvalid", new RouteValueDictionary { { "Controller", "LicenseValidation" }, { "Action", "LicenseActionInvalid" }, { "ErrorCode", "1" } });
                            return RedirectToAction("GetMessageDetailsById", new RouteValueDictionary { { "Controller", "Common" }, { "Action", "GetMessageDetailsById" }, { "messageTypeId", "29" } });
                            //return RedirectToAction(new RouteValueDictionary { { "Controller", "Common" }, { "Action", "GetMessageDetailsById" }, { "messageTypeId", "29" } });

                        }
                        else
                        {
                            //UploadRebuildedLicense(model);
                            Logic.db = null;
                            Logic.GetLicenseData();
                            //Logic.db = null;
                            //Logic.LogicImplementation();
                            lstPersons = GetTableRows(Logic.db);
                            errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Uploading License File, Completed successfully");
                        }
                        return Json(lstPersons, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return null;
        }
        public ActionResult UploadActivationKey(string Key)
        {
            bool Flag_ActKey = false;
            try
            {
                if (!string.IsNullOrWhiteSpace(Key))
                {
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"New Activation Key: {Key}, Processing");
                    JObject obj = new JObject();
                    obj["Key"] = Key;
                    UIDManagement uIDManagement = new UIDManagement();
                    string CurrentUID = uIDManagement.CreateUID();
                    String ActKey = uIDManagement.DecryptUIDToJsonString(Key);
                    if (!string.IsNullOrWhiteSpace(ActKey))
                    {
                        var ActKeyJson = JObject.Parse(ActKey)["UID"];
                        if (ActKeyJson != null)
                        {
                            string ActKeyJsonUID = Convert.ToString(ActKeyJson);
                            if (!string.IsNullOrWhiteSpace(ActKeyJsonUID))
                            {
                                if (string.Compare(CurrentUID, ActKeyJsonUID) == 0)
                                {
                                    Flag_ActKey = true;
                                }
                                else
                                {
                                    Flag_ActKey = false;
                                }
                            }
                            else
                            {
                                Flag_ActKey = false;
                            }
                        }
                        else
                        {
                            Flag_ActKey = false;
                        }
                    }
                    if (Flag_ActKey)
                    {
                        CommonData commonData = new CommonData();
                        var dt = commonData.getCommonMethod(obj, "CS_SP_NEW_ACTIVATION");
                        ActivationManagement activationManagement = new ActivationManagement();
                        activationManagement.GetActivationKey();
                        Logic.isActivationValid = activationManagement.isActivationValid;
                        errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, "Application Activation Successful");
                    }
                    else
                    {
                        errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, "Application Activation Failed");
                    }
                    return Json(Flag_ActKey, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    throw new Exception("No Activation Key available");
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Json(null, JsonRequestBehavior.AllowGet);
        }
        private void UploadLicense(ModelFileUpload modelFileUpload)
        {
            try
            {
                UploadtoServer(modelFileUpload);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
        }
        private void UploadtoServer(ModelFileUpload modelFileUpload)
        {
            try
            {
                modelFileUpload.File.SaveAs(modelFileUpload.FilePath);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
        }
        private void UploadRebuildedLicense(ModelFileUpload modelFileUpload)
        {
            try
            {
                if (System.IO.File.Exists(modelFileUpload.FilePath))
                {
                    System.IO.File.Delete(modelFileUpload.FilePath);
                }
                System.IO.File.AppendAllText(modelFileUpload.FilePath, modelFileUpload.FileContentUpdated);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
        }
        private void UploadtoDB(ModelFileUpload modelFileUpload)
        {
            try
            {
                if (modelFileUpload != null)
                {
                    ModelFileUploadForDB model = new ModelFileUploadForDB();
                    model.ActivationKey = modelFileUpload.ActivationKey;
                    model.ContentType = modelFileUpload.ContentType;
                    model.FileContent = modelFileUpload.FileContent;
                    model.FileName = modelFileUpload.FileName;
                    model.FilePath = modelFileUpload.FilePath;
                    model.FileType = modelFileUpload.FileType;
                    model.LicenseID = modelFileUpload.LicenseID;
                    model.TempID = modelFileUpload.TempID;
                    model.ValidS = modelFileUpload.ValidS;
                    model.ValidE = modelFileUpload.ValidE;
                    model.LicenseType = modelFileUpload.LicenseType;
                    DBConnections dBConnections = new DBConnections();
                    dBConnections.SendData<ModelFileUploadForDB>(model, "CS_SP_LICENSE_UPLOAD_LICENSE_FILE_DETAILS");
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
        }
        private DataTable ReadDataFromFile(ModelFileUpload modelFileUpload)
        {
            LicenseFile NewLicenseFileData = null;
            bool Status = false;
            try
            {
                EncryptionKeyManagement keyManagement = new EncryptionKeyManagement();
                //FileContentForLicense licenseValue = new FileContentForLicense();
                //licenseValue.key = keyManagement.AES_PassKey;
                LicenseFile licenseFile = new LicenseFile();
                licenseFile.FileName = modelFileUpload.FileName;
                licenseFile.FileSavePath = modelFileUpload.FilePath;
                //licenseFile.FileContentLicense = licenseValue;
                licenseFile.FilePath_Private = keyManagement.RSA_FilePath_Private;
                licenseFile.FilePath_Public = keyManagement.RSA_FilePath_Public;
                NewLicense newLicense = new NewLicense(licenseFile);
                NewLicenseFileData = newLicense.Read();
                Status = Validate_LicenseFile(NewLicenseFileData);
                if (Status == true)
                {
                    //Todo: Combining Old License and New License
                    NewLicenseFileData = newLicense.Combine();
                    NewLicense UpdatedLicense = new NewLicense(NewLicenseFileData);
                    NewLicenseFileData = UpdatedLicense.Rebuid();
                    modelFileUpload.TempID = NewLicenseFileData.FileContentLicense.Metadata;
                    modelFileUpload.ValidS = NewLicenseFileData.FileContentLicense.ValidS;
                    modelFileUpload.ValidE = NewLicenseFileData.FileContentLicense.ValidE;
                    modelFileUpload.FileContentUpdated = NewLicenseFileData.FileContent;
                    modelFileUpload.LicenseType = NewLicenseFileData.FileContentLicense.LicenseType;
                    UploadtoDB(modelFileUpload);
                    return NewLicenseFileData.FileLicenseDt;
                }

            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return null;
        }
        public List<Dictionary<string, object>> GetTableRows(DataTable dtData)
        {
            List<Dictionary<string, object>>
            lstRows = new List<Dictionary<string, object>>();
            Dictionary<string, object> dictRow = null;
            try
            {
                if (dtData != null)
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
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return lstRows;
        }
        private bool Validate_LicenseFile(LicenseFile licenseFile)
        {
            bool Flag = false;
            try
            {
                // Validate Start and End date
                DateTime StartDate = Convert.ToDateTime(licenseFile.FileContentLicense.ValidS);
                DateTime EndDate = Convert.ToDateTime(licenseFile.FileContentLicense.ValidE);
                if (IsBewteenTwoDates(DateTime.Now, StartDate, EndDate))
                {
                    Flag = true;
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"{licenseFile.FileContentLicense.ValidS},{licenseFile.FileContentLicense.ValidE}, S Date: {StartDate}, EndDate {EndDate}, {IsBewteenTwoDates(DateTime.Now, StartDate, EndDate)}");
                }
                else
                {
                    Flag = false;
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"{licenseFile.FileContentLicense.ValidS},{licenseFile.FileContentLicense.ValidE}, S Date: {StartDate}, EndDate {EndDate}, {IsBewteenTwoDates(DateTime.Now, StartDate, EndDate)}");
                    return Flag;
                }
                // Validate UID
                string Identifier = licenseFile.FileContentLicense.Identifier;
                UIDManagement uIDManagement = new UIDManagement();
                string UID = uIDManagement.CreateUID();
                if (Identifier == UID)
                {
                    Flag = true;
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Identifier: {Identifier}, UID {UID}, {true}");

                }
                else
                {
                    Flag = false;
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Identifier: , UID , {false}");

                    return Flag;
                }
                // Validate Modules
                DataTable Modules = licenseFile.FileLicenseDt;
                if (Modules != null)
                {
                    if (Modules.Rows.Count > 0)
                    {
                        Flag = true;
                        errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Modules.Rows.Count: {Modules.Rows.Count},  {true}");

                    }
                    else
                    {
                        Flag = false;
                        errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Modules.Rows.Count: {Modules.Rows.Count},  {false}");

                        return Flag;
                    }
                }
                else
                {
                    Flag = false;
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Modules.Rows.Count: {null},  {true}");

                    return Flag;
                }
                //Validate MetaData
                string Metadata = licenseFile.FileContentLicense.Metadata;
                if (!string.IsNullOrWhiteSpace(Metadata))
                {
                    if (!ValidateMetadatasFromDB(Metadata))
                    {
                        Flag = true;
                        errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Metadata: {Metadata},  {true}");

                    }
                    else
                    {
                        Flag = false;
                        errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Metadata: {Metadata},  {false}");

                        return Flag;
                    }
                }
                else
                {
                    Flag = false;
                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, $"Metadata: {Metadata},  {false}");

                    return Flag;
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Flag;
        }
        private bool ValidateMetadatasFromDB(string CurrentMetadata)
        {
            DataSet dt = null; bool flagTempID = false; string TempID = null;
            DBConnections dBConnections = new DBConnections();
            UIDManagement uIDManagement = new UIDManagement();
            if (!string.IsNullOrWhiteSpace(CurrentMetadata))
            {
                using (dBConnections)
                {
                    dt = dBConnections.ReceiveData(null, "CS_SP_LICENSE_GET_UPLOAD_LICENSE_FILE_DETAILS");
                }
                if (dt != null)
                {
                    if (dt.Tables.Count > 0)
                    {
                        if (dt.Tables[0].Rows.Count > 0)
                        {
                            EncryptionKeyManagement keyManagement = new EncryptionKeyManagement();
                            for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                            {
                                //dt.Tables[0].Rows[i]["LicenseDataEncrypted"] = dt.Tables[0].Rows[i]["TempID"].ToString();
                                TempID = dt.Tables[0].Rows[i]["TempID"].ToString();
                                CVC.License.Algorithms.Forms.Common.CommonData commonData = new CommonData();
                                TempID = commonData.DecryptToJsonString(TempID, keyManagement.AES_PassKey);
                                if (!string.IsNullOrWhiteSpace(TempID))
                                {
                                    if (TempID == CurrentMetadata)
                                    {
                                        flagTempID = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return flagTempID;
        }
        private bool IsBewteenTwoDates(DateTime dt, DateTime start, DateTime end)
        {
            return dt >= start && dt <= end;
        }
    }
}