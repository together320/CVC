//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CVC.Data.EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class EnvironmentVariable
    {
        public int EnvVariableId { get; set; }
        public string ReportLocation { get; set; }
        public string BackupFolder { get; set; }
        public Nullable<int> BackupFrequencyNoOfDaya { get; set; }
        public string TimeZoneId { get; set; }
        public string TimeZoneName { get; set; }
        public Nullable<int> ScreenTimeOut { get; set; }
        public Nullable<bool> IsPasswordChangeRequired { get; set; }
        public Nullable<int> PasswordMinLength { get; set; }
        public Nullable<int> PasswordMaxLength { get; set; }
        public Nullable<int> MinAlphaChars { get; set; }
        public Nullable<int> MinNumericChars { get; set; }
        public Nullable<int> MinSpecialChars { get; set; }
        public Nullable<int> PasswordExpiryInDays { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> LanguageId { get; set; }
        public Nullable<int> SessionTimeOut { get; set; }
        public string DateTimeFormat { get; set; }
        public string NumberFormat { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> BackupTime { get; set; }
        public Nullable<System.DateTime> LastBackupDate { get; set; }
        public Nullable<int> LockInAttempt { get; set; }
        public Nullable<bool> IsUnLockAfterTime { get; set; }
        public Nullable<int> UnLockTime { get; set; }
        public Nullable<int> MinCapitalLetter { get; set; }
        public Nullable<int> HourFormatTypeID { get; set; }
        public Nullable<int> DateFormatTypeID { get; set; }
        public Nullable<int> TimeFormatTypeID { get; set; }
        public string ArchivalPath { get; set; }
        public Nullable<int> LastPeriodRetained { get; set; }
        public Nullable<bool> IsOverWriteBackup { get; set; }
        public Nullable<int> PasswordExpiryNotification { get; set; }
        public Nullable<int> PreviousPasswordLimit { get; set; }
        public Nullable<int> DatabaseLimit { get; set; }
        public Nullable<int> LicenseExpiryNotification { get; set; }
        public string ScreenshotCapturePath { get; set; }
    
        public virtual DateFormatType DateFormatType { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual HourFormatType HourFormatType { get; set; }
        public virtual TimeFormatType TimeFormatType { get; set; }
    }
}
