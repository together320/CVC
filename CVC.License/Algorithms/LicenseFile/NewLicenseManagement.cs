using System.Data;

namespace CVC.License.Algorithms.License
{
    public class NewLicenseManagement
    {

        private LicenseFile licenseFile;
        public NewLicenseManagement()
        {

        }
        public LicenseFile GenerateLicense(DataTable dt, string UID, string StartDate, string EndDate, string FileName, string FilePath, string FileType, string LicenseType)
        {
            EncryptionKeyManagement keyManagement = new EncryptionKeyManagement();
            FileContentForLicense licenseValue = new FileContentForLicense();
            licenseValue.Identifier = UID;
            licenseValue.LicenseType = LicenseType;
            licenseValue.ValidS = StartDate;
            licenseValue.ValidE = EndDate;
            licenseValue.key = keyManagement.AES_PassKey;
            licenseFile = new LicenseFile();
            licenseFile.FileName = FileName;
            licenseFile.FileType = FileType;
            licenseFile.FileLicenseDt = dt;
            licenseFile.FilePath_Private = keyManagement.RSA_FilePath_Private;
            licenseFile.FilePath_Public = keyManagement.RSA_FilePath_Public;
            licenseFile.FileSavePath = FilePath;
            licenseFile.FileContentLicense = licenseValue;
            NewLicense newLicense = new NewLicense(licenseFile);
            newLicense.Create();
            //newLicense.Read();
            //newLicense.Update();
            return licenseFile;
        }

    }
}