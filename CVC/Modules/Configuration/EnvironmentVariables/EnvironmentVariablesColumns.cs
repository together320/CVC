// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Columns.EnvironmentVariablesColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace CVC.Configuration.Columns
{
    [ColumnsScript("Configuration.EnvironmentVariables")]
    [BasedOnRow(typeof(EnvironmentVariablesRow))]
    public class EnvironmentVariablesColumns
    {
        [EditLink]
        [DisplayName("Db.Shared.RecordId")]
        [AlignRight]
        public int EnvVariableId { get; set; }

        [EditLink]
        public string ReportLocation { get; set; }

        public string BackupFolder { get; set; }
        [Hint("Site")]
        [Placeholder("Número da Agência")]
        public int BackupFrequencyNoOfDaya { get; set; }

        public string TimeZoneId { get; set; }

        public string TimeZoneName { get; set; }

        public int ScreenTimeOut { get; set; }

        public short IsPasswordChangeRequired { get; set; }

        public int PasswordMinLength { get; set; }

        public int PasswordMaxLength { get; set; }

        public int MinAlphaChars { get; set; }

        public int MinNumericChars { get; set; }

        public int MinSpecialChars { get; set; }

        public int MinCapitalLetter { get; set; } 

        public int PasswordExpiryInDays { get; set; }

        public int CurrencyId { get; set; }

        public int LanguageId { get; set; }

        public int SessionTimeOut { get; set; }

        public string DateTimeFormat { get; set; }

        public string NumberFormat { get; set; }

        public string DateFormatTypeValue { get; set; }

        public string TimeFormatValue { get; set; }

        public string ArchivalPath { get; set; }

        public int LastPeriodRetained { get; set; }

        public bool? IsOverWriteBackup { get; set; }

        public int? PasswordExpiryNotification { get; set; }

        public int? PreviousPasswordLimit { get; set; }

        public int? DatabaseLimit { get; set; }


    }
}
