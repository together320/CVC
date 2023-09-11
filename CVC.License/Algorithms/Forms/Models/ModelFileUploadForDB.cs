namespace CVC.License.Algorithms.Forms.Models
{
    public class ModelFileUploadForDB
    {
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
        public string FileType { get; set; }
        public string LicenseType { get; set; }
        public string FilePath { get; set; }
        //Todo: Metadata info from License File
        public string TempID { get; set; }
        //Todo: Start Date  from License File
        public string ValidS { get; set; }
        //Todo: End Date  from License File
        public string ValidE { get; set; }
        public string ActivationKey { get; set; }
        public string ContentType { get; set; }
        public string LicenseID { get; set; }
    }
}