using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
namespace CVC.License.Algorithms.Transforming
{
    public class KeyManagement
    {
        ErrorManagement errorManagement = new ErrorManagement();
        public KeyManagement()
        {

        }
        public string GetKeyString(RSAParameters publicKey)
        {
            var stringWriter = new System.IO.StringWriter();
            try { 
           
            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xmlSerializer.Serialize(stringWriter, publicKey);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);

            }
            return stringWriter.ToString();
        }
        public string Encrypt(string textToEncrypt, string publicKeyString)
        {
            string base64Encrypted = null;
            
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    var bytesToEncrypt = Encoding.UTF8.GetBytes(textToEncrypt);
                    rsa.FromXmlString(publicKeyString.ToString());
                    var encryptedData = rsa.Encrypt(bytesToEncrypt, true);
                    base64Encrypted = Convert.ToBase64String(encryptedData);

                }
                catch (Exception ex)
                {
                    errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
                return base64Encrypted;
            }
        }
        public string Decrypt(string textToDecrypt, string privateKeyString)
        {
            string decryptedData = null;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    var bytesToDescrypt = Encoding.UTF8.GetBytes(textToDecrypt);

                    // server decrypting data with private key
                    rsa.FromXmlString(privateKeyString);
                    var resultBytes = Convert.FromBase64String(textToDecrypt);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                }
                catch (Exception ex)
                {
                    errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
                return decryptedData.ToString();
            }
        }
        private string GenerateTestString()
        {
            Guid opportinityId = Guid.NewGuid();
            Guid systemUserId = Guid.NewGuid();
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("opportunityid={0}", opportinityId.ToString());
            sb.AppendFormat("&systemuserid={0}", systemUserId.ToString());
            sb.AppendFormat("&currenttime={0}", currentTime);
            return sb.ToString();
        }

    }
}
