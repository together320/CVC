// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Forms.EnvironmentVariablesForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.Modules.Configuration.EnvironmentVariables;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace CVC.Configuration.Forms
{
    [FormScript("Configuration.EnvironmentVariables")]
    [BasedOnRow(typeof(EnvironmentVariablesRow))]
    public class EnvironmentVariablesForm
    {
        //[Category("General")]
        //[LabelWidth(190)]
        //[HalfWidth]
        //public string ReportLocation { get; set; }

        [Category("Database Backup / Archival Settings ")]
        [LabelWidth(190)]
        [HalfWidth]
        [Required]
        public string BackupFolder { get; set; }

        [Category("Database Backup / Archival Settings ")]
        [LabelWidth(190)]
        [HalfWidth]
        [Required]
     
        public int BackupFrequencyNoOfDaya { get; set; }

        [Category("Database Backup / Archival Settings ")]
        [DisplayName("Backup Hour(In 24 Hours)")]
        [LabelWidth(190)]
        [HalfWidth]
        [Required]
        public int BackupTime { get; set; }


        [Category("Database Backup / Archival Settings ")]
        [DisplayName("OverWrite Backup")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsOverWriteBackup { get; set; }


        [Category("Database Backup / Archival Settings ")]
        [DisplayName("Database Limit for Notification (In MB)")]
        [LabelWidth(190)]
        [HalfWidth]
        [MaxLength(5)]
        public int? DatabaseLimit { get; set; }

        [Category("Database Backup / Archival Settings ")]
        [DisplayName("Archival Path")]
        [LabelWidth(190)]
        [HalfWidth]
        [Required]
        public string ArchivalPath { get; set; }

        [Category("Database Backup / Archival Settings ")]
        [DisplayName("Last Period Retained (In Days)")]
        [LabelWidth(190)]
        [HalfWidth]
        [Required]
        public int LastPeriodRetained { get; set; }

        //[LabelWidth(190)]
        //[HalfWidth]
        //public string TimeZoneName { get; set; }

        //[LabelWidth(190)]
        //[HalfWidth]
        //public int ScreenTimeOut { get; set; }

        //[LookupEditor(typeof (CurrencyRow), FilterField = "StatusId", FilterValue = "1")]
        //[HalfWidth]
        //[LabelWidth(190)]
        //public int CurrencyId { get; set; }

        //[LookupEditor(typeof (LanguageRow), FilterField = "StatusId", FilterValue = "1")]
        //[HalfWidth]
        //[LabelWidth(190)]
        //public int LanguageId { get; set; }
        [Category("Database Backup / Archival Settings ")]

        [LabelWidth(190)]
        [HalfWidth]
        [DisplayName("Screen TimeOut (In Minutes)")]

        public int SessionTimeOut { get; set; }

        //[LabelWidth(190)]
        //[HalfWidth]
        //public string DateTimeFormat { get; set; }

        //[LabelWidth(190)]
        //[HalfWidth]
        //public string NumberFormat { get; set; }
        [Category("Password Expiry and Lockin Settings")]

        [LabelWidth(190)]
        [HalfWidth]
        [DisplayName("Password change on First Login")]
        public bool IsPasswordChangeRequired { get; set; }

        [Category("Password  Complexity Settings ")]

        [LabelWidth(190)]
        [HalfWidth]
        public int PasswordMaxLength { get; set; }

        [Category("Password  Complexity Settings ")]

        [LabelWidth(190)]
        [HalfWidth]
        public int PasswordMinLength { get; set; }
        
        [Category("Password  Complexity Settings ")]

        [LabelWidth(190)]
        [HalfWidth]
        public int MinAlphaChars { get; set; }
        [Category("Password  Complexity Settings ")]

        [LabelWidth(190)]
        [HalfWidth]
        public int MinNumericChars { get; set; }
        [Category("Password  Complexity Settings ")]

        [LabelWidth(190)]
        [HalfWidth]
        public int MinSpecialChars { get; set; }

        [Category("Password  Complexity Settings ")]

        [LabelWidth(190)]
        [HalfWidth]
        public int MinCapitalLetter { get; set; }


        [Category("Password  Complexity Settings ")]
        [DisplayName("Previous Password Limit")]
        [LabelWidth(190)]
        [HalfWidth]
        [MaxLength(5)]
        [Required]
        public int? PreviousPasswordLimit { get; set; }

        [Category("Password Expiry and Lockin Settings")]

        [LabelWidth(190)]
        [HalfWidth]
        [Required]

        public int PasswordExpiryInDays { get; set; }

        [Category("Password Expiry and Lockin Settings")]
        [DisplayName("Password Expiry Notification (In Days)")]
        [LabelWidth(190)]
        [HalfWidth]
        [Required]

        public int? PasswordExpiryNotification { get; set; }


        [Category("Password Expiry and Lockin Settings")]
        [DisplayName("Lock In-Attempt")]
        [LabelWidth(190)]
        [HalfWidth]
        [Required]
        public int LockInAttempt { get; set; }

        [Category("Password Expiry and Lockin Settings")]
        [DisplayName("Is UnLock After Time")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool IsUnLockAfterTime { get; set; }

        [Category("Password Expiry and Lockin Settings")]
        [DisplayName("Un LockTime(In Minutes)")]
        [LabelWidth(190)]
        [HalfWidth]
        [Required]

        public int UnLockTime { get; set; }

        [Category("Date / Time Settings")]

        [LookupEditor(typeof(DateFormatTypeLookUp))]
        [LabelWidth(190)]
        [HalfWidth]
        public int DateFormatTypeID { get; set; }
        [Category("Date / Time Settings")]

        [LookupEditor(typeof(TimeFormatTypeLookUp))]
        [LabelWidth(190)]
        [HalfWidth]
        public int TimeFormatTypeID { get; set; }

        [Category("Date / Time Settings")]

        [LookupEditor(typeof(HourFormatTypeLookUp))]
        [LabelWidth(190)]
        [HalfWidth]
        public int HourFormatTypeID { get; set; }

        [Category("License")]
        [LabelWidth(190)]
        [HalfWidth]
        public int LicenseExpiryNotification { get; set; }
        







    }
}
