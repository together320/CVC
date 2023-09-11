// Decompiled with JetBrains decompiler
// Type: CVC.Data.EnvironmentVariable
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class EnvironmentVariable
  {
    public int EnvVariableId { get; set; }

    public string ReportLocation { get; set; }

    public string BackupFolder { get; set; }

    public int? BackupFrequencyNoOfDaya { get; set; }

    public string TimeZoneId { get; set; }

    public string TimeZoneName { get; set; }

    public int? ScreenTimeOut { get; set; }

    public bool? IsPasswordChangeRequired { get; set; }

    public int? PasswordMinLength { get; set; }

    public int? PasswordMaxLength { get; set; }

    public int? MinAlphaChars { get; set; }

    public int? MinNumericChars { get; set; }

    public int? MinSpecialChars { get; set; }

    public int? PasswordExpiryInDays { get; set; }

    public int? CurrencyId { get; set; }

    public int? LanguageId { get; set; }

    public int? SessionTimeOut { get; set; }

    public string DateTimeFormat { get; set; }

    public string NumberFormat { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }
  }
}
