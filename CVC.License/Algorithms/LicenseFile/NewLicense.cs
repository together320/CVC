using CVC.License.Algorithms.Transforming;
using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Web.Configuration;
using System.Web.Script.Serialization;
namespace CVC.License.Algorithms.License
{
    public class NewLicense
    {
        private LicenseFile licenseFile;
        ErrorManagement errorManagement = new ErrorManagement();
        public NewLicense(LicenseFile _licenseFile)
        {
            licenseFile = _licenseFile;
        }
        public void Create()
        {
            LicenseFileCreate(licenseFile);
        }
        public LicenseFile Rebuid()
        {
            return LicenseFileRebuild(licenseFile);
        }
        public LicenseFile Read()
        {
            return LicenseFileRead(licenseFile);
        }
        public LicenseFile Combine()
        {
            //return CombineLicense(licenseFile);
            return CombineLicenseV1(licenseFile);
        }

        public void Update()
        {
            LicenseFileUpdate(licenseFile);
        }
        public void Delete()
        {
            LicenseFileDelete(licenseFile);
        }
        private LicenseFile LicenseFileCreate(LicenseFile licenseFile)
        {
            bool isSuccessfull = false;
            try
            {
                string filePath = null;
                string FileSavePath = licenseFile.FileSavePath;
                string FileName = licenseFile.FileName + licenseFile.FileType;
                if (FileSavePath != null && FileName != null)
                {
                    filePath = Path.Combine(FileSavePath, FileName);
                }
                ConvertDtToJson(licenseFile);
                //EncryptFromJsonString(licenseFile);
                licenseFile.FileContentLicense.data = EncryptTextwithAESKey(licenseFile.FileContent);
                licenseFile.FileContentLicense.LicenseType = EncryptTextwithAESKey(licenseFile.FileContentLicense.LicenseType);
                licenseFile.FileContentLicense.Identifier = EncryptTextwithAESKey(licenseFile.FileContentLicense.Identifier);
                licenseFile.FileContentLicense.ValidS = EncryptTextwithAESKey(licenseFile.FileContentLicense.ValidS);
                licenseFile.FileContentLicense.ValidE = EncryptTextwithAESKey(licenseFile.FileContentLicense.ValidE);
                licenseFile.FileContentLicense.Metadata = EncryptTextwithAESKey(Guid.NewGuid().ToString());
                EncryptAESKeyUsingRSA(licenseFile.FileContentLicense.key);
                licenseFile.FileContent = SerializetoJSON(licenseFile.FileContentLicense);
                string fileContent = licenseFile.FileContent;
                if (filePath != null)
                {
                    if (fileContent != null)
                    {
                        // Check if file already exists. If yes, delete it.
                        if (File.Exists(filePath))
                        {
                            File.Delete(filePath);
                        }
                        File.AppendAllText(filePath, fileContent);
                        isSuccessfull = true;
                    }
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.ToString());
            }
            licenseFile.IsFileCreated = isSuccessfull;
            return licenseFile;
        }
        private LicenseFile LicenseFileRebuild(LicenseFile licenseFile)
        {
            bool isSuccessfull = false;
            try
            {
                string filePath = null;
                string FileSavePath = licenseFile.FileSavePath;
                string FileName = licenseFile.FileName + licenseFile.FileType;
                if (!string.IsNullOrWhiteSpace(FileSavePath))
                {
                    filePath = FileSavePath;
                }
                ConvertDtToJson(licenseFile);
                //EncryptFromJsonString(licenseFile);
                licenseFile.FileContentLicense.data = EncryptTextwithAESKey(licenseFile.FileContent);
                licenseFile.FileContentLicense.Identifier = licenseFile.FileContentLicense.Identifier;
                licenseFile.FileContentLicense.LicenseType = EncryptTextwithAESKey(licenseFile.FileContentLicense.LicenseType);
                licenseFile.FileContentLicense.ValidS = EncryptTextwithAESKey(licenseFile.FileContentLicense.ValidS);
                licenseFile.FileContentLicense.ValidE = EncryptTextwithAESKey(licenseFile.FileContentLicense.ValidE);
                licenseFile.FileContentLicense.Metadata = EncryptTextwithAESKey(licenseFile.FileContentLicense.Metadata.ToString());
                EncryptAESKeyUsingRSA(licenseFile.FileContentLicense.key);
                licenseFile.FileContent = SerializetoJSON(licenseFile.FileContentLicense);
                string fileContent = licenseFile.FileContent;
                if (filePath != null)
                {
                    if (fileContent != null)
                    {
                        // Check if file already exists. If yes, delete it.
                        if (File.Exists(filePath))
                        {
                            File.Delete(filePath);
                        }
                        File.AppendAllText(filePath, fileContent);
                        isSuccessfull = true;
                    }
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.ToString());
            }
            licenseFile.IsFileCreated = isSuccessfull;
            return licenseFile;
        }
        private LicenseFile LicenseFileDelete(LicenseFile licenseFile)
        {
            bool isSuccessfull = false;
            try
            {
                string fileAbsoluteURL = licenseFile.FileAbsoluteURL;
                if (File.Exists(fileAbsoluteURL))
                {
                    File.Delete(fileAbsoluteURL);
                    isSuccessfull = true;
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.ToString());
            }
            licenseFile.IsFileDeleted = isSuccessfull;
            return licenseFile;
        }
        private LicenseFile LicenseFileUpdate(LicenseFile licenseFile)
        {
            try
            {
                //licenseFile.FileLicenseDt.Rows.Add("test1", "index", true, "Pack", "10", "2", false, false);
                licenseFile = LicenseFileCreate(licenseFile);
                licenseFile.IsFileUpdated = true;
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return licenseFile;
        }
        private LicenseFile LicenseFileRead(LicenseFile licenseFile)
        {
            string filePath = null;
            string encryptedContent = null;
            try
            {
                string FileSavePath = licenseFile.FileSavePath;
                string FileName = licenseFile.FileName + licenseFile.FileType;
                filePath = FileSavePath;
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = File.OpenText(filePath))
                    {
                        encryptedContent = sr.ReadToEnd();
                        if (!string.IsNullOrWhiteSpace(encryptedContent))
                        {
                            licenseFile.FileContentLicense = SerializeFromJSON<FileContentForLicense>(encryptedContent);
                            if (licenseFile.FileContentLicense != null)
                            {
                                if (!string.IsNullOrWhiteSpace(licenseFile.FileContentLicense.key))
                                {
                                    DecryptAESKEYUsingRSAKey(licenseFile.FileContentLicense.key);
                                }
                                licenseFile.FileContentLicense.data = DecryptToJsonString(licenseFile.FileContentLicense.data);
                                licenseFile.FileContentLicense.Identifier = DecryptToJsonString(licenseFile.FileContentLicense.Identifier);
                                licenseFile.FileContentLicense.LicenseType = DecryptToJsonString(licenseFile.FileContentLicense.LicenseType);
                                licenseFile.FileContentLicense.ValidS = DecryptToJsonString(licenseFile.FileContentLicense.ValidS);
                                licenseFile.FileContentLicense.ValidE = DecryptToJsonString(licenseFile.FileContentLicense.ValidE);
                                licenseFile.FileContentLicense.Metadata = DecryptToJsonString(licenseFile.FileContentLicense.Metadata);
                                licenseFile.FileLicenseDt = FormatLicenseData(ConvertJsonToDt(licenseFile.FileContentLicense.data));
                            }
                            else
                            {
                                throw new Exception("License Content bind to License Objects");
                            }
                        }
                        else
                        {
                            throw new Exception("License Content is not found");
                        }
                    }
                }
                else
                {
                    throw new Exception("License File is not found");
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.ToString());
            }
            licenseFile.FileContent = licenseFile.FileContentLicense.data;
            return licenseFile;
        }
        private LicenseFile ConvertDtToJson(LicenseFile licenseFile)
        {
            string JSONresult;
            try
            {
                DataTable dataTable = licenseFile.FileLicenseDt;
                if (dataTable != null)
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        JSONresult = JsonConvert.SerializeObject(dataTable);
                    }
                    else
                    {
                        JSONresult = null;
                    }
                }
                else
                {
                    JSONresult = null;
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
                JSONresult = null;
            }
            licenseFile.FileContent = JSONresult;
            return licenseFile;
        }
        private LicenseFile CombineLicense(LicenseFile licenseFile)
        {
            int Total = 0, Old_Actual = 0, OldVal_Used = 0, NewVal = 0;
            //Get Existing License
            DataTable OldLicenseData;
            try
            {
                OldLicenseData = Logic.GetLicenseData();
                //Run a for each Loop
                if (OldLicenseData != null)
                {
                    if (OldLicenseData.Rows.Count > 0)
                    {
                        if (licenseFile.FileLicenseDt != null)
                        {
                            if (licenseFile.FileLicenseDt.Rows.Count > 0)
                            {
                                foreach (DataRow Old_item in OldLicenseData.Rows)
                                {
                                    if (!string.IsNullOrWhiteSpace(Old_item["LicenseType"].ToString()))
                                    {
                                        if (Old_item["LicenseType"].ToString() == "Pack")
                                        {
                                            if (!string.IsNullOrWhiteSpace(Old_item["ModuleID"].ToString()) && !string.IsNullOrWhiteSpace(Old_item["ActionID"].ToString()))
                                            {
                                                foreach (DataRow New_item in licenseFile.FileLicenseDt.Rows)
                                                {
                                                    if (!string.IsNullOrWhiteSpace(New_item["LicenseType"].ToString()))
                                                    {
                                                        //Todo: Implentaion on License type Pack
                                                        if (New_item["LicenseType"].ToString() == "Pack")
                                                        {
                                                            if (!string.IsNullOrWhiteSpace(New_item["ModuleID"].ToString()) && !string.IsNullOrWhiteSpace(New_item["ActionID"].ToString()))
                                                            {
                                                                if (int.Parse(Old_item["ModuleID"].ToString()) == int.Parse(New_item["ModuleID"].ToString())
                                                                    &&
                                                                    int.Parse(Old_item["ActionID"].ToString()) == int.Parse(New_item["ActionID"].ToString())
                                                                    )
                                                                {
                                                                    _ = int.TryParse(Old_item["LicenseValue"].ToString(), out Old_Actual);
                                                                    _ = int.TryParse(Old_item["LicenseCurrentValue"].ToString(), out OldVal_Used);
                                                                    _ = int.TryParse(New_item["LicenseValue"].ToString(), out NewVal);

                                                                    Total = (Old_Actual - OldVal_Used) + NewVal;
                                                                    if (Total > 0)
                                                                    {
                                                                        New_item["LicenseValue"] = Total.ToString();
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return licenseFile;
        }
        private LicenseFile CombineLicenseV1(LicenseFile licenseFile)
        {
            int Total = 0, Old_Actual = 0, OldVal_Used = 0, NewVal = 0, EndDateDiffCount = 0;
            int ModuleID = 0, ActionID = 0;
            string Old_LicenseType = null, New_LicenseType = null;
            DateTime Old_EndDate, New_EndDate;
            DataTable NewModules = new DataTable();
            //Get Existing License
            DataTable OldLicenseData;
            try
            {
                OldLicenseData = Logic.GetLicenseData();
                //Run a for each Loop
                if (OldLicenseData != null)
                {
                    if (OldLicenseData.Rows.Count > 0)
                    {
                        if (licenseFile.FileLicenseDt != null)
                        {
                            if (licenseFile.FileLicenseDt.Rows.Count > 0)
                            {
                                //OldLicense Loop
                                foreach (DataRow Old_item in OldLicenseData.Rows)
                                {
                                    if (!string.IsNullOrWhiteSpace(Old_item["LicenseType"].ToString()))
                                    {
                                        //if (Old_item["LicenseType"].ToString() == "Pack")
                                        //{
                                        if (!string.IsNullOrWhiteSpace(Old_item["ModuleID"].ToString()) && !string.IsNullOrWhiteSpace(Old_item["ActionID"].ToString()))
                                        {
                                            _ = int.TryParse(Old_item["ModuleID"].ToString(), out ModuleID);
                                            _ = int.TryParse(Old_item["ActionID"].ToString(), out ActionID);
                                            Old_LicenseType = Old_item["LicenseType"].ToString().ToLower().Replace("\n", "").Replace("\r", "").Trim();
                                            //Filter Module ID and Controller ID from NewLicense
                                            DataRow[] FilteredNewLicenseItems = licenseFile.FileLicenseDt.Select("ModuleID = '" + Convert.ToInt64(ModuleID) + "' AND ActionID ='" + Convert.ToInt64(ActionID) + "'");
                                            if (FilteredNewLicenseItems != null)
                                            {
                                                if (FilteredNewLicenseItems.Length > 0)
                                                {
                                                    if (FilteredNewLicenseItems.Length < 2)
                                                    {
                                                        //Check Old License Type(P, T, PA)
                                                        //Check New License Type(P, T, PA)
                                                        foreach (DataRow FilteredNewLicenseItems_Item in FilteredNewLicenseItems)
                                                        {
                                                            New_LicenseType = FilteredNewLicenseItems_Item["LicenseType"].ToString().ToLower().Replace("\n", "").Replace("\r", "").Trim();
                                                            // if both are same
                                                            if (Old_LicenseType == New_LicenseType)
                                                            {
                                                                //================================
                                                                //if = Pack, Copy Value and add to existing Value
                                                                if (Old_LicenseType == "pack" && New_LicenseType == "pack")
                                                                {
                                                                    _ = int.TryParse(Old_item["LicenseValue"].ToString(), out Old_Actual);
                                                                    _ = int.TryParse(Old_item["LicenseCurrentValue"].ToString(), out OldVal_Used);
                                                                    _ = int.TryParse(FilteredNewLicenseItems_Item["LicenseValue"].ToString(), out NewVal);
                                                                    Total = (Old_Actual - OldVal_Used) + NewVal;
                                                                    if (Total > 0)
                                                                    {
                                                                        Old_item["LicenseValue"] = Total;
                                                                        Old_item["LicenseCurrentValue"] = 0;
                                                                    }
                                                                    else
                                                                    {
                                                                        errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, "No New Packs");
                                                                    }
                                                                }
                                                                //================================
                                                                //if = Time, Update old with new value
                                                                else if (Old_LicenseType == "timebound" && New_LicenseType == "timebound")// what about remaining time in old license ajo
                                                                {
                                                                    _ = DateTime.TryParse(Old_item["ControllerValidEndDate"].ToString(), out Old_EndDate);
                                                                    //_ = DateTime.TryParse(FilteredNewLicenseItems_Item["ControllerValidEndDate"].ToString(), out New_EndDate);
                                                                    _ = int.TryParse(FilteredNewLicenseItems_Item["LicenseValue"].ToString(), out NewVal);
                                                                    EndDateDiffCount = (Old_EndDate - DateTime.Now).Days;
                                                                    if (EndDateDiffCount > 0)
                                                                    {
                                                                        Old_EndDate = Old_EndDate.AddDays(EndDateDiffCount);
                                                                    }
                                                                    Old_EndDate = Old_EndDate.AddDays(NewVal);
                                                                    if (EndDateDiffCount > 0)
                                                                    {
                                                                        NewVal = NewVal + EndDateDiffCount;
                                                                    }
                                                                    //Old_item["ControllerValidStartDate"] = FilteredNewLicenseItems_Item["ControllerValidStartDate"];
                                                                    Old_item["ControllerValidEndDate"] = Old_EndDate;
                                                                    Old_item["LicenseValue"] = NewVal;
                                                                    Old_item["LicenseCurrentValue"] = 0;
                                                                }
                                                                //================================
                                                                //if = perpectual, NA
                                                                else if (Old_LicenseType == "perpectual" && New_LicenseType == "perpectual")
                                                                {

                                                                }
                                                            }
                                                            //================================
                                                            //if old perpectual = new pack, Copy new property
                                                            else if (Old_LicenseType == "perpectual" && New_LicenseType == "pack")
                                                            {
                                                                NewVal = 0;
                                                                _ = int.TryParse(FilteredNewLicenseItems_Item["LicenseValue"].ToString(), out NewVal);
                                                                Old_item["LicenseValue"] = NewVal.ToString();
                                                                Old_item["LicenseCurrentValue"] = 0;
                                                            }
                                                            //================================
                                                            //if old perpectual = new TimeBound, Copy new property
                                                            else if (Old_LicenseType == "perpectual" && New_LicenseType == "timebound")
                                                            {
                                                                NewVal = 0;
                                                                _ = int.TryParse(FilteredNewLicenseItems_Item["LicenseValue"].ToString(), out NewVal);
                                                                Old_item["ControllerValidStartDate"] = DateTime.Now;
                                                                Old_item["ControllerValidEndDate"] = DateTime.Now.AddDays(NewVal);
                                                                //Old_item["LicenseValue"] = 1;
                                                                Old_item["LicenseValue"] = NewVal;
                                                                Old_item["LicenseCurrentValue"] = 0;

                                                            }
                                                            //================================
                                                            //if old Pack = Perpectual Copy new property
                                                            else if (Old_LicenseType == "pack" && New_LicenseType == "perpectual")
                                                            {
                                                                NewVal = 0;
                                                                _ = int.TryParse(FilteredNewLicenseItems_Item["LicenseValue"].ToString(), out NewVal);
                                                                Old_item["LicenseValue"] = NewVal.ToString();
                                                                Old_item["LicenseCurrentValue"] = 0;

                                                            }
                                                            //if old Pack = Time Copy new property
                                                            else if (Old_LicenseType == "pack" && New_LicenseType == "timebound")
                                                            {
                                                                NewVal = 0;
                                                                _ = int.TryParse(FilteredNewLicenseItems_Item["LicenseValue"].ToString(), out NewVal);
                                                                Old_item["ControllerValidStartDate"] = DateTime.Now;
                                                                Old_item["ControllerValidEndDate"] = DateTime.Now.AddDays(NewVal);
                                                                Old_item["LicenseValue"] = NewVal;
                                                                Old_item["LicenseCurrentValue"] = 0;
                                                            }
                                                            //================================
                                                            //if old Time = new pack ,Copy new property
                                                            else if (Old_LicenseType == "timebound" && New_LicenseType == "pack")
                                                            {
                                                                NewVal = 0;
                                                                _ = int.TryParse(FilteredNewLicenseItems_Item["LicenseValue"].ToString(), out NewVal);
                                                                Old_item["LicenseValue"] = NewVal.ToString();
                                                                Old_item["ControllerValidStartDate"] = null;
                                                                Old_item["ControllerValidEndDate"] = null;
                                                                Old_item["LicenseCurrentValue"] = 0;
                                                            }
                                                            //================================
                                                            //if old Time = new perpectual, Copy new property
                                                            else if (Old_LicenseType == "timebound" && New_LicenseType == "perpectual")
                                                            {
                                                                NewVal = 0;
                                                                _ = int.TryParse(FilteredNewLicenseItems_Item["LicenseValue"].ToString(), out NewVal);
                                                                Old_item["LicenseValue"] = NewVal.ToString();
                                                                Old_item["LicenseCurrentValue"] = 0;
                                                                Old_item["ControllerValidStartDate"] = null;
                                                                Old_item["ControllerValidEndDate"] = null;
                                                            }
                                                            else
                                                            {
                                                                Old_item["ControllerValidStartDate"] = string.Empty;
                                                                Old_item["ControllerValidEndDate"] = string.Empty;
                                                            }

                                                            // Common Values for License meta data
                                                            Old_item["LicenseType"] = FilteredNewLicenseItems_Item["LicenseType"];

                                                            NewVal = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, "Duplicate License Modules");
                                                    }

                                                }
                                                else
                                                {
                                                    errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, "License Modules not found");
                                                }
                                            }
                                            else
                                            {
                                                errorManagement.LogMessage(MethodBase.GetCurrentMethod().Name, "License Modules not found");
                                            }
                                        }
                                        //}
                                    }
                                    Old_item["IsLicensed"] = true;
                                    Old_item["IsExpiredController"] = false;
                                    Old_item["IsExpiredAction"] = false;
                                }
                                // Find New Licensed Modules not in Old License Collection
                                foreach (DataRow New_item in licenseFile.FileLicenseDt.Rows)
                                {
                                    _ = int.TryParse(New_item["ModuleID"].ToString(), out ModuleID);
                                    _ = int.TryParse(New_item["ActionID"].ToString(), out ActionID);
                                    DataRow[] FilteredNewLicenseItems = OldLicenseData.Select("ModuleID = '" + Convert.ToInt64(ModuleID) + "' AND ActionID ='" + Convert.ToInt64(ActionID) + "'");
                                    if (FilteredNewLicenseItems == null)
                                    {
                                        DataRow row = OldLicenseData.NewRow();
                                        row["ModuleID"] = New_item["ModuleID"];
                                        row["Controller"] = New_item["Controller"];
                                        row["ActionID"] = New_item["ActionID"];
                                        row["Action"] = New_item["Action"];
                                        row["LicenseType"] = New_item["LicenseType"];
                                        row["LicenseValue"] = New_item["LicenseValue"];
                                        row["Status"] = New_item["Status"];
                                        row["LicenseCurrentValue"] = New_item["LicenseCurrentValue"];
                                        row["ControllerValidStartDate"] = New_item["ControllerValidStartDate"];
                                        row["ControllerValidEndDate"] = New_item["ControllerValidEndDate"];
                                        row["IsLicensed"] = true;
                                        row["IsExpiredController"] = false;
                                        row["IsExpiredAction"] = false;
                                        OldLicenseData.Rows.Add(row);
                                    }
                                }
                            }
                        }
                        licenseFile.FileLicenseDt = OldLicenseData;
                    }
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return licenseFile;
        }
        private DataTable ConvertJsonToDt(string json)
        {
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
                        Console.WriteLine("License File is Invalid");
                        dataTable = null;
                    }
                }
                else
                {
                    Console.WriteLine("License File is Invalid");
                    dataTable = null;
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
                dataTable = null;
            }

            return dataTable;
        }
        private LicenseFile EncryptAESKeyUsingRSA(string plainText)
        {
            string encryptedText;
            //string plainText = licenseFile.FileContent;
            try
            {
                if (licenseFile.publicKeyString == null)
                {
                    getPublicKey();
                }
                //DECLARATION
                KeyManagement keyManagement = new KeyManagement();
                if (plainText != null)
                {
                    if (plainText.Length > 0)
                    {
                        encryptedText = keyManagement.Encrypt(plainText, licenseFile.publicKeyString);
                    }
                    else
                    {
                        encryptedText = null;
                    }
                }
                else
                {
                    encryptedText = null;
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
                encryptedText = null;
            }
            //licenseFile.FileContent = encryptedText;
            licenseFile.FileContentLicense.key = encryptedText;
            return licenseFile;
        }
        private string DecryptAESKEYUsingRSAKey(string cipherText)
        {
            string decryptedText;
            try
            {
                if (licenseFile.privateKeyString == null)
                {
                    getPrivateKey();
                }
                //DECLARATION
                KeyManagement keyManagement = new KeyManagement();
                if (cipherText != null)
                {
                    if (cipherText.Length > 0)
                    {
                        decryptedText = keyManagement.Decrypt(cipherText, licenseFile.privateKeyString);
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
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
                decryptedText = null;
            }
            // licenseFile.FileContent = decryptedText;
            licenseFile.FileContentLicense.key = decryptedText;
            return decryptedText;
        }
        private string EncryptTextwithAESKey(string plainText)
        {
            string encryptedText;
            try
            {
                string key = licenseFile.FileContentLicense.key;
                //DECLARATION
                SecurityController keyManagement = new SecurityController();
                if (plainText != null)
                {
                    if (plainText.Length > 0)
                    {
                        encryptedText = keyManagement.Encrypt(key, plainText);
                    }
                    else
                    {
                        encryptedText = null;
                    }
                }
                else
                {
                    encryptedText = null;
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
                encryptedText = null;
            }
            return encryptedText;
        }
        private DataTable FormatLicenseData(DataTable dataTable)
        {
            try
            {
                if (dataTable != null)
                {
                    foreach (DataRow item in dataTable.Rows)
                    {
                        item["ModuleName"] = item["ModuleName"].ToString().ToLower().Replace("\n", "").Replace("\r", "").Trim();
                        item["ActionName"] = item["ActionName"].ToString().ToLower().Replace("\n", "").Replace("\r", "").Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dataTable;
        }
        private string DecryptToJsonString(string cipherText)
        {
            string decryptedText;
            try
            {
                if (licenseFile.privateKeyString == null)
                {
                    getPrivateKey();
                }
                //DECLARATION
                SecurityController keyManagement = new SecurityController();
                if (cipherText != null)
                {
                    if (cipherText.Length > 0)
                    {
                        decryptedText = keyManagement.Decrypt(licenseFile.FileContentLicense.key, cipherText);
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
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
                decryptedText = null;
            }
            // licenseFile.FileContent = decryptedText;

            return decryptedText;
        }
        private void getPublicKey()
        {
            try
            {
                //RSA PUBLIC KEYS
                //===========================================================================================
                if (File.Exists(licenseFile.FilePath_Public))
                    licenseFile.publicKeyString = File.ReadAllText(licenseFile.FilePath_Public);
                else
                {
                    Console.WriteLine("RSA PUBLIC KEY IS NOT AVAILABLE");
                }
                if (licenseFile.publicKeyString == null || licenseFile.publicKeyString.Trim().Length < 10)
                {
                    Console.WriteLine("Public key is not valid");
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
            }
        }
        private void getPrivateKey()
        {
            try
            {
                //===========================================================================================
                //RSA PRIVATE KEY
                //===========================================================================================
                if (File.Exists(licenseFile.FilePath_Private))
                    licenseFile.privateKeyString = File.ReadAllText(licenseFile.FilePath_Private);
                else
                {
                    Console.WriteLine("RSA PRIVATE KEY IS NOT AVAILABLE");
                }
                if (licenseFile.privateKeyString == null || licenseFile.privateKeyString.Trim().Length < 10)
                {
                    Console.WriteLine("Private key is not valid");
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
            }
        }
        private string SerializetoJSON(FileContentForLicense dataToSerialize)
        {
            try
            {
                var json = new JavaScriptSerializer().Serialize(dataToSerialize);
                return json.ToString();
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                throw;
            }
        }
        private T SerializeFromJSON<T>(string jsonString)
        {
            try
            {
                var json = new JavaScriptSerializer().Deserialize<T>(jsonString);
                return json;
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                throw;
            }
        }
    }
}
