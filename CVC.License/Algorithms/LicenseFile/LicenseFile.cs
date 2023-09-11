using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;

namespace CVC.License.Algorithms.License
{
    public class FileContentForLicense
    {
        public string key{ get; set; }
        public string LicenseType{ get; set; }
        public string Identifier{ get; set; }
        public string data { get; set; }
        public string ValidS { get; set; }
        public string ValidE { get; set; }
        public string Metadata { get; set; }
        public string encryptedContent { get; set; }
    }
    public class LicenseFile
    {
        public string LicenseID { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileContent { get; set; }
        public FileContentForLicense FileContentLicense { get; set; }
        public string FileAbsoluteURL { get => FileSavePath + "\\" + FileName + FileType; }
        public string FileSavePath { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DataTable FileLicenseDt { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsFileCreated { get; set; }
        public bool IsFileUpdated { get; set; }
        public bool IsFileDeleted { get; set; }
        public string publicKeyString { get; set; }
        public string privateKeyString { get; set; }
        public string FilePath_Public { get; set; }
        public string FilePath_Private { get; set; }
    }
}