namespace CVC.License.Algorithms.License
{
    public class EncryptionKeyManagement
    {
        public string AES_PassKey { get; set; }
        public string RSA_FilePath_Private { get; set; }
        public string RSA_FilePath_Public { get; set; }
        public EncryptionKeyManagement()
        {
            AES_PassKey = Properties.Settings.Default.AESKEY;
            RSA_FilePath_Private = Properties.Settings.Default.RSAPrivateFile;
            RSA_FilePath_Public = Properties.Settings.Default.RSAPublicFile;
        }
    }
}