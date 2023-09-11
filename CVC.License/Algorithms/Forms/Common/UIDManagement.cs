using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Web;
using CVC.License.Algorithms.License;
using CVC.License.Algorithms.Transforming;
using Newtonsoft.Json.Linq;

namespace CVC.License.Algorithms.Forms.Common
{
    public class UIDManagement
    {
        ErrorManagement errorManagement = new ErrorManagement();
        private string AppName;
        public UIDManagement()
        {
            string ApplicationName = "CVCAPP";
            //string HardDiskSerialID = Get_HarddiskID();
            //string CPUID = Get_CPUID();
            //string MotherBoardID = Get_MotherBoardID();
            AppName = ApplicationName;
        }

        #region Getting Internal Values

        public string Get_HarddiskID()
        {
            string HardDiskSerialID = null;
            try
            {
                ManagementObjectSearcher moSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

                foreach (ManagementObject wmi_HD in moSearcher.Get())
                {
                    HardDiskSerialID = wmi_HD["SerialNumber"].ToString(); //Serial Number
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);

            }
            return HardDiskSerialID;
        }
        public string Get_MotherBoardID()
        {
            string MotherBoardID = null;
            try
            {
                ManagementObjectSearcher moSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");

                foreach (ManagementObject wmi_HD in moSearcher.Get())
                {
                    MotherBoardID = wmi_HD.GetPropertyValue("SerialNumber").ToString(); //Serial Number
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);

            }
            return MotherBoardID;
        }
        public string Get_CPUID()
        {
            string cpuInfo = string.Empty;
            try
            {
                ManagementClass mc = new ManagementClass("win32_processor");
                ManagementObjectCollection moc = mc.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    if (cpuInfo == "")
                    {
                        //Get only the first CPU's ID
                        cpuInfo = mo.Properties["processorID"].Value.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);

            }
            return cpuInfo;
        }

        #endregion

        public string CreateUID()
        {
            string AESText = null;
            try
            {
                JObject uidStructure = new JObject();
                uidStructure["ApplicationName"] = AppName;
                uidStructure["ProcessorID"] = Get_CPUID();
                uidStructure["MotherboardSN"] = Get_MotherBoardID();
                uidStructure["DiskVolumeSN"] = Get_HarddiskID();
                AESText = EncryptUIDFromJsonString(uidStructure.ToString());
                //JObject obj= DecryptUIDToJsonString(AESText);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return AESText;
        }

        #region UID Encryption
        public string EncryptUIDFromJsonString(string plainText)
        {

            string encryptedText;

            try
            {
                string key = Properties.Settings.Default.AESKEY;
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
        //RSA ENCRYPTION NOT NEEDED
        private string EncryptUIDAESKey(string plainText)
        {
            string encryptedText, publicKeyString;
            try
            {
                publicKeyString = getPublicKey();
                //DECLARATION
                KeyManagement keyManagement = new KeyManagement();
                if (plainText != null)
                {
                    if (plainText.Length > 0)
                    {
                        encryptedText = keyManagement.Encrypt(plainText, publicKeyString);
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
        #endregion

        #region UID Decryption
        //CAN USE THIS FUNCTION TO DECRYPT UID - RETURNS A JOBJECT WITH INTERNAL UID VALUES
        public string DecryptUIDToJsonString(string cipherText)
        {
            string decryptedText;

            try
            {
                string key = Properties.Settings.Default.AESKEY;
                //DECLARATION
                SecurityController keyManagement = new SecurityController();
                if (cipherText != null)
                {
                    if (cipherText.Length > 0)
                    {
                        decryptedText = keyManagement.Decrypt(key, cipherText);
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
            return decryptedText;
        }
        //RSA DECRYPTION NOT NEEDED
        private string DecryptUIDAESKEY(string cipherText)
        {
            string decryptedText, privateKeyString;

            try
            {
                privateKeyString = getPrivateKey();
                //DECLARATION
                KeyManagement keyManagement = new KeyManagement();
                if (cipherText != null)
                {
                    if (cipherText.Length > 0)
                    {
                        decryptedText = keyManagement.Decrypt(cipherText, privateKeyString);
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
        #endregion

        #region RSA Key
        // RSA KEY COLLECION NOT NEEDED
        private string getPublicKey()
        {
            string publicKey = null;

            try
            {
                string RSA_Public_File_path = Properties.Settings.Default.RSAPublicFile;

                if (RSA_Public_File_path == null)
                {
                    Console.WriteLine("RSA PUBLIC KEY FILE PATH IS NOT AVAILABLE");
                    return null;
                }
                //RSA PUBLIC KEYS
                //===========================================================================================
                if (File.Exists(RSA_Public_File_path))
                    publicKey = File.ReadAllText(RSA_Public_File_path);
                else
                {
                    Console.WriteLine("RSA PUBLIC KEY IS NOT AVAILABLE");
                }

                if (publicKey == null || publicKey.Trim().Length < 10)
                {
                    Console.WriteLine("Public key is not valid");
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
            }
            return publicKey;
        }
        private string getPrivateKey()
        {
            string privateKey = null;

            try
            {
                string RSA_Private_File_path = Properties.Settings.Default.RSAPrivateFile;

                //===========================================================================================
                //RSA PRIVATE KEY
                //===========================================================================================
                if (File.Exists(RSA_Private_File_path))
                    privateKey = File.ReadAllText(RSA_Private_File_path);
                else
                {
                    Console.WriteLine("RSA PRIVATE KEY IS NOT AVAILABLE");
                }
                if (privateKey == null || privateKey.Trim().Length < 10)
                {
                    Console.WriteLine("Private key is not valid");
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
            }
            return privateKey;
        }
        #endregion
    }
}