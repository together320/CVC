using CVC.License.Algorithms.Forms.Common;
using CVC.License.Algorithms.License;
using CVC.License.Algorithms.Transforming;
using Newtonsoft.Json.Linq;
using System;
using System.Reflection;

namespace CVC.License.Algorithms
{
    public class ActivationManagement
    {
        private string ActivationKey;
        public bool isActivationValid = false;
        ErrorManagement errorManagement = new ErrorManagement();
        public ActivationManagement()
        {
            //if (GetActivationKey())
            //{
            //    isActivationValid = true;
            //}
        }
        public bool GetActivationKey()
        {
            isActivationValid = false;
            try
            {
                CommonData commonData = new CommonData();
                var dt = commonData.getCommonMethodBySPNAME("SP_LICENSE_GET_ACTIVATION_KEY");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ActivationKey = dt.Rows[0]["ActivationKey"].ToString();
                        var data = DecryptActivationKey(ActivationKey);
                        if (data != null)
                            if (data.Length > 0)
                            {
                                var ActivationData = JObject.Parse(data);
                                UIDManagement uIDManagement = new UIDManagement();
                                var CurrentUID = uIDManagement.CreateUID();
                                if (ActivationData["UID"].ToString() == CurrentUID)
                                {
                                    isActivationValid = true;
                                }
                            }
                            else
                            {
                                isActivationValid = false;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                isActivationValid = false;
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return isActivationValid;
        }
        public string CreateActivationKey(string UID)
        {
            string encryptedText = null;
            try
            {
                EncryptionKeyManagement keyManagement = new EncryptionKeyManagement();
                string plainText = "{'UID':'" + UID + "'}";

                SecurityController securityController = new SecurityController();
                if (plainText != null)
                {
                    if (plainText.Length > 0)
                    {
                        encryptedText = securityController.Encrypt(keyManagement.AES_PassKey, plainText);
                        //SaveToDatabase(encryptedText);
                    }
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return encryptedText;
        }
        private bool SaveToDatabase(string encryptedActivationKey)
        {
            try
            {
                // NOT IMPLEMENTED COMPLETELY WAITING FOR THE CUSTOMER FORM TO BE COMPLETED
                if (!string.IsNullOrWhiteSpace(encryptedActivationKey))
                {
                    JObject obj = new JObject();
                    obj["EncryptedActivationKey"] = encryptedActivationKey;
                    CommonData commonData = new CommonData();
                    commonData.getCommonMethod(obj, "SP_CUSTOMER_NEW_ACTIVATION");
                    return true;
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return false;
        }
        private string DecryptActivationKey(string encryptedString)
        {
            string plainText = null;
            try
            {
                EncryptionKeyManagement keyManagement = new EncryptionKeyManagement();
                SecurityController securityController = new SecurityController();
                if (encryptedString != null)
                {
                    if (encryptedString.Length > 0)
                    {
                        plainText = securityController.Decrypt(keyManagement.AES_PassKey, encryptedString);
                    }
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return plainText;
        }
    }
}
