using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVC.BusinessServices.Common
{
    public class ClsConstants
    {
        public static class ProtocolType
        {
            public static string MDB = "MDB";
            public static string OPCUaClient = "OPC Ua Client";
            public static string Modbus = "Modbus";
            public static string SiemensS7Net = "SiemensS7Net";


        }

        public enum StatusType
        {
            Active = 1, InActive = 2
        }

        public enum RoleType
        {
            Administrator = 1
        }

        public static class StatusMessage
        {
            public static string DataInsertedSuccessfully = "Data Inserted Successfully.";
            public static string DataUpdatedSuccessfully = "Data Updated Successfully.";
            public static string DataDeletedSuccessfully = "Data Deleted Successfully.";
            public static string Valid = "Valid";
            public static string InValid = "InValid";
            public static string DataNotFound = "Data not found.";
            public static string DataFound = "Data found.";
            public static string Exist = "Exist.";
            public static string NonRegisteredTerminal = "The Terminal you are using is not registered for accessing the application. Please inform your Administrator.";
            public static string NonRegisteredUser = "You do not have access to the application. Please inform your administrator";
            public static string WrongPassword = "You have provided wrong login credentials. Please provide Valid Login Credentials.If you have forgotten your password please contact the administrator or use the Forgot Password Option";
            public static string InActiveTerminal = "The Terminal you are using is Inactive and cannot be used to access the application. Please contact your administrator";
            public static string InActiveTerminalType = "This type of Terminal is not supported by the Application. Please contact your Administrator";
            public static string NoMachineMappedToTerminal = "The Terminal you are using is is not mapped to any Machine. Please allocate one machine to this Terminal before Logging in again. Please contact your administrator";
            public static string NoUserMappedToTerminal = "The Terminal you are using is is not mapped to this user. Please allocate user to this Terminal before Logging in again. Please contact your administrator";
            public static string NoMachineAccess="role don't have any machine access. Please contact your administrator.";
            public static string DataNotFoundInUploadedFile = "Data not found in uploaded file.";
            public static string HeaderNotFoundInUploadedFile = "Header not found in uploaded file.";


        }

        public  class StatusMessage1
        {
            public static string DataInsertedSuccessfully = "Data Inserted Successfully.";
            public static string DataUpdatedSuccessfully = "Data Updated Successfully.";
           
        }

        public enum FileType
        {
            Csv = 1, Excel = 2
        }

        public static class ArchiveTableName
        {
            public static string AlarmLog = "AlarmLog";
            public static string AuditLog = "AuditLog";
            public static string UserLog = "UserLog";
            public static string BatchLog = "BatchLog";
            public static string AuditLogMiscellaneous = "AuditLogMiscellaneous";

        }

        public static class UploadArchivalFolderPath
        {
            public static string UploadArchivalPath = "~/Upload/Archival/";
            public static string UploadMiscellaneousPath = "~/Upload/Miscellaneous/";

        }

        public static class GetIpAddress
        {
            public static string LocalIpAddress = "::1";
            public static string LocalIpAddress1 = "127.0.0.1";
            public static string LocalIpAddress2 ="localhost";



        }

        public enum MessageType
        {
            NonRegisteredTerminal=1,
            InActiveTerminalType = 2,
            InActiveTerminal = 3,
            NoMachineMappedToTerminal = 4,
            NoUserMappedToTerminal = 5,
            NoMachineAccessToRole = 6,
            UnknownUser = 7,
            InActiveUser=8,
            WrongPassword = 9,
            PasswordExpired=10,
            ChangePasswordOnFirstLogin=11,
            LockAccount=12,
            PasswordExpiryNotification=13,
            DatabaseLimitNotification=14,
            InvalidCredentials=15,
            FileUploadedSuccessfully = 16,
            BrowseFileFirst = 17,
            NoDataInUploadedFile = 18,
            NoHeadersFoundInUploadedFile = 19,
            DataFound=23,
            NoAceesToRestartPC = 24,
            NameDoesNotExist= 25,
            NameCanNotBeBlank= 26,
            NoAceesToShutDownPC = 27,
            LicenseExpired=37,
            LicenseExpiredSoon = 38,
            LicenseValidityExpired=40



            //ShutDownPCConfirmation=16,
            //RestartPCConfirmation=17,
            //NewBatchConfirmation=18,
            //ReloadBatchConfirmation=19,
            //StartBatchConfirmation=20,
            //EditBatchConfirmation=21,
            //StopBatchConfirmation=22,
            //EndBatchConfirmation = 23,
            //SelectRecipeConfirmation = 24,
            //SaveRecipeConfirmation = 25,
            //UpdateRecipeConfirmation = 26,
            //LogOutConfirmation=27,

        }

        public enum PickListType
        {
            MessageType=19
        }

        public static class GraphFolderPath
        {
            public static string GraphPath = "~/Content/images/Graph";

        }

        public static class OpcUaClientSecurityMode
        {
            public static string None = "None";
            public static string Sign = "Sign";
            public static string SignAndEncrypt = "SignAndEncrypt";

        }

        public static class OpcUaClientUserIdentity
        {
            public static string Anonymous = "Anonymous";
            public static string UserName = "UserName";

        }

        public static class OpcUaClientCertificateType
        {
            public static string TrustedIssuer = "TrustedIssuer";
            public static string Rejected = "Rejected";

        }

        public enum OpcUaClientDataType
        {
            Boolean=1,
            SByte=2,
            Byte=3,
            Int16=4,
            UInt16=5,
            Int32=6,
            UInt32=7,
            Int64=8,
            UInt64=9,
            Float=10,
            Double=11,
            String=12

        }

        public static class UploadImportFolderPath
        {
            public static string UploadImportPath = "~/Upload/Import/";

        }


    }


}