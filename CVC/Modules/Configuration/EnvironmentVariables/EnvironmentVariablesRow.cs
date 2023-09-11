// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Entities.EnvironmentVariablesRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.Configuration.Entities
{
    [ConnectionKey("Default")]
    [TableName("EnvironmentVariable")]
    [DisplayName("Environment Variables")]
    [InstanceName("Environment Variables")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Configuration:EnvironmentVariable:Read")]
    [ModifyPermission("Configuration:EnvironmentVariable:Modify")]
    public sealed class EnvironmentVariablesRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly EnvironmentVariablesRow.RowFields Fields = new EnvironmentVariablesRow.RowFields().Init<EnvironmentVariablesRow.RowFields>();

        [DisplayName("Env Variable Id")]
        [Identity]
        public int? EnvVariableId
        {
            get
            {
                return EnvironmentVariablesRow.Fields.EnvVariableId[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.EnvVariableId[(Row)this] = value;
            }
        }

        [DisplayName("Report Location")]
        [Size(500)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string ReportLocation
        {
            get
            {
                return EnvironmentVariablesRow.Fields.ReportLocation[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.ReportLocation[(Row)this] = value;
            }
        }

        [DisplayName("Backup Folder")]
        [Size(500)]
        public string BackupFolder
        {
            get
            {
                return EnvironmentVariablesRow.Fields.BackupFolder[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.BackupFolder[(Row)this] = value;
            }
        }

        [DisplayName("Backup Frequency In Days")]
       

        public int? BackupFrequencyNoOfDaya
        {
            get
            {
                return EnvironmentVariablesRow.Fields.BackupFrequencyNoOfDaya[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.BackupFrequencyNoOfDaya[(Row)this] = value;
            }
        }



        public int? BackupTime
        {
            get
            {
                return EnvironmentVariablesRow.Fields.BackupTime[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.BackupTime[(Row)this] = value;
            }
        }

        [DisplayName("Time Zone Id")]
        [Size(50)]
        public string TimeZoneId
        {
            get
            {
                return EnvironmentVariablesRow.Fields.TimeZoneId[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.TimeZoneId[(Row)this] = value;
            }
        }

        [DisplayName("Time Zone Name")]
        [Size(500)]
        public string TimeZoneName
        {
            get
            {
                return EnvironmentVariablesRow.Fields.TimeZoneName[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.TimeZoneName[(Row)this] = value;
            }
        }

        [DisplayName("Screen Time Out (In Mins.)")]
        public int? ScreenTimeOut
        {
            get
            {
                return EnvironmentVariablesRow.Fields.ScreenTimeOut[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.ScreenTimeOut[(Row)this] = value;
            }
        }

        [DisplayName("Is Password Change Required")]
        public bool? IsPasswordChangeRequired
        {
            get
            {
                return EnvironmentVariablesRow.Fields.IsPasswordChangeRequired[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.IsPasswordChangeRequired[(Row)this] = value;
            }
        }

        [DisplayName("Password Min Length")]
        public int? PasswordMinLength
        {
            get
            {
                return EnvironmentVariablesRow.Fields.PasswordMinLength[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.PasswordMinLength[(Row)this] = value;
            }
        }

        [DisplayName("Password Max Length")]
        public int? PasswordMaxLength
        {
            get
            {
                return EnvironmentVariablesRow.Fields.PasswordMaxLength[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.PasswordMaxLength[(Row)this] = value;
            }
        }

        [DisplayName("Min Alpha Chars")]
        public int? MinAlphaChars
        {
            get
            {
                return EnvironmentVariablesRow.Fields.MinAlphaChars[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.MinAlphaChars[(Row)this] = value;
            }
        }

        [DisplayName("Min Numeric Chars")]
        public int? MinNumericChars
        {
            get
            {
                return EnvironmentVariablesRow.Fields.MinNumericChars[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.MinNumericChars[(Row)this] = value;
            }
        }

        [DisplayName("Min Special Chars")]
        public int? MinSpecialChars
        {
            get
            {
                return EnvironmentVariablesRow.Fields.MinSpecialChars[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.MinSpecialChars[(Row)this] = value;
            }
        }

        [DisplayName("Min Capital Letter")]
        public int? MinCapitalLetter
        {
            get
            {
                return EnvironmentVariablesRow.Fields.MinCapitalLetter[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.MinCapitalLetter[(Row)this] = value;
            }
        }

        [DisplayName("Password Expiry In Days")]
        public int? PasswordExpiryInDays
        {
            get
            {
                return EnvironmentVariablesRow.Fields.PasswordExpiryInDays[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.PasswordExpiryInDays[(Row)this] = value;
            }
        }

        [DisplayName("Currency Id")]
        public int? CurrencyId
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CurrencyId[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CurrencyId[(Row)this] = value;
            }
        }

        [DisplayName("Language Id")]
        public int? LanguageId
        {
            get
            {
                return EnvironmentVariablesRow.Fields.LanguageId[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.LanguageId[(Row)this] = value;
            }
        }

        [DisplayName("Screen Time Out ")]
        public int? SessionTimeOut
        {
            get
            {
                return EnvironmentVariablesRow.Fields.SessionTimeOut[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.SessionTimeOut[(Row)this] = value;
            }
        }

        [DisplayName("Date Time Format")]
        [Size(50)]
        public string DateTimeFormat
        {
            get
            {
                return EnvironmentVariablesRow.Fields.DateTimeFormat[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.DateTimeFormat[(Row)this] = value;
            }
        }

        [DisplayName("Number Format")]
        [Size(50)]
        public string NumberFormat
        {
            get
            {
                return EnvironmentVariablesRow.Fields.NumberFormat[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.NumberFormat[(Row)this] = value;
            }
        }


        public int? LockInAttempt
        {
            get
            {
                return EnvironmentVariablesRow.Fields.LockInAttempt[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.LockInAttempt[(Row)this] = value;
            }
        }


        public bool? IsUnLockAfterTime
        {
            get
            {
                return EnvironmentVariablesRow.Fields.IsUnLockAfterTime[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.IsUnLockAfterTime[(Row)this] = value;
            }
        }

        public int? UnLockTime
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UnLockTime[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UnLockTime[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [ForeignKey("Users", "UserId")]
        [LeftJoin("jCreatedBy")]
        [TextualField("CreatedByEmployeeId")]
        public int? CreatedBy
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [ForeignKey("Users", "UserId")]
        [LeftJoin("jUpdatedBy")]
        [TextualField("UpdatedByEmployeeId")]
        public int? UpdatedBy
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        //[DisplayName("Created By Is Password Change On Login")]
        //[Expression("jCreatedBy.[IsPasswordChangeRequired]")]
        //public bool? CreatedByIsPasswordChangeRequired
        //{
        //  get
        //  {
        //    return EnvironmentVariablesRow.Fields.CreatedByIsPasswordChangeRequired[(Row) this];
        //  }
        //  set
        //  {
        //    EnvironmentVariablesRow.Fields.CreatedByIsPasswordChangeRequired[(Row) this] = value;
        //  }
        //}

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return EnvironmentVariablesRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        //[DisplayName("Updated By Is Password Change On Login")]
        //[Expression("jUpdatedBy.[IsPasswordChangeRequired]")]
        //public bool? UpdatedByIsPasswordChangeRequired
        //{
        //  get
        //  {
        //    return EnvironmentVariablesRow.Fields.UpdatedByIsPasswordChangeRequired[(Row) this];
        //  }
        //  set
        //  {
        //    EnvironmentVariablesRow.Fields.UpdatedByIsPasswordChangeRequired[(Row) this] = value;
        //  }
        //}

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return EnvironmentVariablesRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Date Format Type")]
        [ForeignKey("DateFormatType", "DateFormatTypeID")]
        [LeftJoin("jDateFormatType")]
        [TextualField("DateFormatTypeValue")]
        [NotNull]
        //To make status as default "Active"
        public int? DateFormatTypeID
        {
            get
            {
                return EnvironmentVariablesRow.Fields.DateFormatTypeID[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.DateFormatTypeID[(Row)this] = value;
            }
        }

        [DisplayName("Date Format Type")]
        [Expression("jDateFormatType.[DateFormatTypeValue]")]
        public string DateFormatTypeValue
        {
            get
            {
                return EnvironmentVariablesRow.Fields.DateFormatTypeValue[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.DateFormatTypeValue[(Row)this] = value;
            }
        }
        [DisplayName("Time Format Type")]
        [ForeignKey("TimeFormatType", "TimeFormatTypeID")]
        [LeftJoin("jTimeFormatType")]
        [TextualField("TimeFormatValue")]
        [NotNull]
        //To make status as default "Active"
        public int? TimeFormatTypeID
        {
            get
            {
                return EnvironmentVariablesRow.Fields.TimeFormatTypeID[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.TimeFormatTypeID[(Row)this] = value;
            }
        }

        [DisplayName("Time Format Type")]
        [Expression("jTimeFormatType.[TimeFormatValue]")]
        public string TimeFormatValue
        {
            get
            {
                return EnvironmentVariablesRow.Fields.TimeFormatValue[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.TimeFormatValue[(Row)this] = value;
            }
        }

        [DisplayName("Hour Format Type")]
        [ForeignKey("HourFormatType", "HourFormatTypeID")]
        [LeftJoin("jHourFormatType")]
        [TextualField("HourFormatValue")]
        [NotNull]
        //To make status as default "Active"
        public int? HourFormatTypeID
        {
            get
            {
                return EnvironmentVariablesRow.Fields.HourFormatTypeID[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.HourFormatTypeID[(Row)this] = value;
            }
        }

        [DisplayName("Hour Format Type")]
        [Expression("jHourFormatType.[HourFormatTypeValue]")]
        public string HourFormatTypeValue
        {
            get
            {
                return EnvironmentVariablesRow.Fields.HourFormatTypeValue[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.HourFormatTypeValue[(Row)this] = value;
            }
        }
        [DisplayName("ArchivalPath")]
        public string ArchivalPath
        {
            get
            {
                return EnvironmentVariablesRow.Fields.ArchivalPath[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.ArchivalPath[(Row)this] = value;
            }
        }
        [DisplayName("LastPeriodRetained")]
        public int? LastPeriodRetained
        {
            get
            {
                return EnvironmentVariablesRow.Fields.LastPeriodRetained[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.LastPeriodRetained[(Row)this] = value;
            }
        }
        [DisplayName("IsOverWriteBackup")]
        public bool? IsOverWriteBackup
        {
            get
            {
                return EnvironmentVariablesRow.Fields.IsOverWriteBackup[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.IsOverWriteBackup[(Row)this] = value;
            }
        }
        [DisplayName("PasswordExpiryNotification")]
        public int? PasswordExpiryNotification
        {
            get
            {
                return EnvironmentVariablesRow.Fields.PasswordExpiryNotification[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.PasswordExpiryNotification[(Row)this] = value;
            }
        }

        [DisplayName("PreviousPasswordLimit")]
        public int? PreviousPasswordLimit
        {
            get
            {
                return EnvironmentVariablesRow.Fields.PreviousPasswordLimit[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.PreviousPasswordLimit[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)EnvironmentVariablesRow.Fields.EnvVariableId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return EnvironmentVariablesRow.Fields.ReportLocation;
            }
        }


        [DisplayName("DatabaseLimit")]
        public int? DatabaseLimit
        {
            get
            {
                return EnvironmentVariablesRow.Fields.DatabaseLimit[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.DatabaseLimit[(Row)this] = value;
            }
        }

        [DisplayName("License Expiry")]
        public int? LicenseExpiryNotification
        {
            get
            {
                return EnvironmentVariablesRow.Fields.LicenseExpiryNotification[(Row)this];
            }
            set
            {
                EnvironmentVariablesRow.Fields.LicenseExpiryNotification[(Row)this] = value;
            }
        }

        public EnvironmentVariablesRow()
          : base((RowFieldsBase)EnvironmentVariablesRow.Fields)
        {
        }
        public class RowFields : LoggingRow.LoggingRowFields

        // public class RowFields : RowFieldsBase
        {
            public Int32Field EnvVariableId;
            public StringField ReportLocation;
            public StringField BackupFolder;
            public Int32Field BackupFrequencyNoOfDaya;
            public Int32Field BackupTime;
            public StringField TimeZoneId;
            public StringField TimeZoneName;
            public Int32Field ScreenTimeOut;
            public BooleanField IsPasswordChangeRequired;
            public Int32Field PasswordMinLength;
            public Int32Field PasswordMaxLength;
            public Int32Field MinAlphaChars;
            public Int32Field MinNumericChars;
            public Int32Field MinSpecialChars;
            public Int32Field MinCapitalLetter;
            public Int32Field PasswordExpiryInDays;
            public Int32Field CurrencyId;
            public Int32Field LanguageId;
            public Int32Field SessionTimeOut;
            public StringField DateTimeFormat;
            public StringField NumberFormat;
           // public Int32Field CreatedBy;
            public Int32Field LockInAttempt;
            public Int32Field UnLockTime;
            public BooleanField IsUnLockAfterTime;
           /* public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;*/
            public StringField CreatedByEmployeeId;
            public StringField CreatedByFirstName;
            public StringField CreatedByLastName;
            public Int32Field CreatedByDepartmentId;
            public StringField CreatedByDesignation;
            public Int32Field CreatedByMobileCode;
            public Int32Field CreatedByMobileNumber;
            public StringField CreatedByEmail;
            public StringField CreatedByUsername;
            public StringField CreatedByPasswordHash;
            public StringField CreatedByPasswordSalt;
            public StringField CreatedByUserImage;
            public StringField CreatedByAddress;
            public Int32Field CreatedByCityId;
            public StringField CreatedByPinCode;
            public Int32Field CreatedByRoleId;
            public DateTimeField CreatedByPasswordExpiryDate;
            public Int16Field CreatedByIsForgotPassword;
            //public BooleanField CreatedByIsPasswordChangeRequired;
            public Int16Field CreatedByIsUserHidden;
            public Int32Field CreatedByStatusId;
            public Int32Field CreatedBy1;
            public DateTimeField CreatedByCreatedDate;
            public Int32Field CreatedByUpdatedBy;
            public DateTimeField CreatedByUpdatedDate;
            public StringField UpdatedByEmployeeId;
            public StringField UpdatedByFirstName;
            public StringField UpdatedByLastName;
            public Int32Field UpdatedByDepartmentId;
            public StringField UpdatedByDesignation;
            public Int32Field UpdatedByMobileCode;
            public Int32Field UpdatedByMobileNumber;
            public StringField UpdatedByEmail;
            public StringField UpdatedByUsername;
            public StringField UpdatedByPasswordHash;
            public StringField UpdatedByPasswordSalt;
            public StringField UpdatedByUserImage;
            public StringField UpdatedByAddress;
            public Int32Field UpdatedByCityId;
            public StringField UpdatedByPinCode;
            public Int32Field UpdatedByRoleId;
            public DateTimeField UpdatedByPasswordExpiryDate;
            public Int16Field UpdatedByIsForgotPassword;
            // public BooleanField UpdatedByIsPasswordChangeRequired;
            public Int16Field UpdatedByIsUserHidden;
            public Int32Field UpdatedByStatusId;
            public Int32Field UpdatedByCreatedBy;
            public DateTimeField UpdatedByCreatedDate;
            public Int32Field UpdatedBy1;
            public DateTimeField UpdatedByUpdatedDate;
            public Int32Field DateFormatTypeID;
            public StringField DateFormatTypeValue;
            public Int32Field TimeFormatTypeID;
            public StringField TimeFormatValue;
            public Int32Field HourFormatTypeID;
            public StringField HourFormatTypeValue;
            public StringField ArchivalPath;
            public Int32Field LastPeriodRetained;
            public BooleanField IsOverWriteBackup;
            public Int32Field PasswordExpiryNotification;
            public Int32Field PreviousPasswordLimit;
            public Int32Field DatabaseLimit;
            public Int32Field LicenseExpiryNotification;
            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Configuration.EnvironmentVariables";
            }
        }
    }
}
