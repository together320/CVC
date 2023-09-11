using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CVC.License.Algorithms.Forms.Common;
using CVC.License.Algorithms.Transforming;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CVC.License.Algorithms
{
    public class WhitelistManagement
    {
        public bool AddWhitelist(List<Whitelist> whitelists)
        {
            try
            {
                var AES_KEY = Properties.Settings.Default.AESKEY;
                var json = JsonConvert.SerializeObject(whitelists);
                var encryptedJsonString = EncryptFromJsonString(json, AES_KEY);
                CommonData commonData = new CommonData();
                JObject obj = new JObject();
                obj["EncryptedData"] = encryptedJsonString;
                commonData.getCommonMethod(obj, "CS_SP_NEW_WHITELIST");
                return true;
            }
            catch(Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
            }
            return false;
        }
        private string EncryptFromJsonString(string text, string aeskey)
        {
            //Check Here
            string encryptedText;
            try
            {
                string plainText = text;
                string key = aeskey;
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
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                Console.WriteLine(ex.InnerException);
                encryptedText = null;
            }
            return encryptedText;
        }
        public DataTable GetWhitelistData()
        {
            var AES_KEY = Properties.Settings.Default.AESKEY;
            DataTable dt = null;
            try
            {
                CommonData commonData = new CommonData();
                dt = commonData.getCommonMethodBySPNAME("SP_GET_WHITELIST_DATA");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        var plaintext = commonData.DecryptToJsonString(dt.Rows[0]["WHITELISTDATA"].ToString(), AES_KEY);
                        dt = commonData.ConvertJsonToDt(plaintext);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dt;
        }
    }
}