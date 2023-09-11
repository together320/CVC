// Decompiled with JetBrains decompiler
// Type: CVC.Migrations.DefaultDB.DefaultDB_20141103_140000_Initial
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using FluentMigrator;
using FluentMigrator.Builders.Create.Table;
using System;

namespace CVC.Migrations.DefaultDB
{
  [Migration(20141103140000)]
  public class DefaultDB_20141103_140000_Initial : AutoReversingMigration
  {
    public override void Up()
    {
      string table1 = "Users";
      string idField1 = "UserId";
      // ISSUE: variable of the null type
      __Null local1 = null;
      int num1 = 0;
      this.CreateTableWithId32(table1, idField1, (Action<ICreateTableColumnOptionOrWithColumnSyntax>) (s => s.WithColumn("Username").AsString(100).NotNullable().WithColumn("DisplayName").AsString(100).NotNullable().WithColumn("Email").AsString(100).Nullable().WithColumn("Source").AsString(4).NotNullable().WithColumn("PasswordHash").AsString(86).NotNullable().WithColumn("PasswordSalt").AsString(10).NotNullable().WithColumn("LastDirectoryUpdate").AsDateTime().Nullable().WithColumn("UserImage").AsString(100).Nullable().WithColumn("InsertDate").AsDateTime().NotNullable().WithColumn("InsertUserId").AsInt32().NotNullable().WithColumn("UpdateDate").AsDateTime().Nullable().WithColumn("UpdateUserId").AsInt32().Nullable().WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue((object) 1)), (string) local1, num1 != 0);
      this.Insert.IntoTable("Users").Row((object) new
      {
        Username = "admin",
        DisplayName = "admin",
        Email = "admin@dummy.com",
        Source = "site",
        PasswordHash = "rfqpSPYs0ekFlPyvIRTXsdhE/qrTHFF+kKsAUla7pFkXL4BgLGlTe89GDX5DBysenMDj8AqbIZPybqvusyCjwQ",
        PasswordSalt = "hJf_F",
        InsertDate = new DateTime(2014, 1, 1),
        InsertUserId = 1,
        IsActive = 1
      });
      string table2 = "Languages";
      string idField2 = "Id";
      // ISSUE: variable of the null type
      __Null local2 = null;
      int num2 = 0;
      this.CreateTableWithId32(table2, idField2, (Action<ICreateTableColumnOptionOrWithColumnSyntax>) (s => s.WithColumn("LanguageId").AsString(10).NotNullable().WithColumn("LanguageName").AsString(50).NotNullable()), (string) local2, num2 != 0);
      this.Insert.IntoTable("Languages").Row((object) new
      {
        LanguageId = "en",
        LanguageName = "English"
      });
      this.Insert.IntoTable("Languages").Row((object) new
      {
        LanguageId = "ru",
        LanguageName = "Russian"
      });
      this.Insert.IntoTable("Languages").Row((object) new
      {
        LanguageId = "es",
        LanguageName = "Spanish"
      });
      this.Insert.IntoTable("Languages").Row((object) new
      {
        LanguageId = "tr",
        LanguageName = "Turkish"
      });
      this.Insert.IntoTable("Languages").Row((object) new
      {
        LanguageId = "de",
        LanguageName = "German"
      });
      this.Insert.IntoTable("Languages").Row((object) new
      {
        LanguageId = "zh-CN",
        LanguageName = "Chinese (Simplified)"
      });
      this.Insert.IntoTable("Languages").Row((object) new
      {
        LanguageId = "it",
        LanguageName = "Italian"
      });
      this.Insert.IntoTable("Languages").Row((object) new
      {
        LanguageId = "pt",
        LanguageName = "Portuguese"
      });
      this.Insert.IntoTable("Languages").Row((object) new
      {
        LanguageId = "pt-BR",
        LanguageName = "Portuguese (Brazil)"
      });
      this.Insert.IntoTable("Languages").Row((object) new
      {
        LanguageId = "fa",
        LanguageName = "Farsi"
      });
      this.Insert.IntoTable("Languages").Row((object) new
      {
        LanguageId = "vi-VN",
        LanguageName = "Vietnamese (Vietnam)"
      });
    }
  }
}
