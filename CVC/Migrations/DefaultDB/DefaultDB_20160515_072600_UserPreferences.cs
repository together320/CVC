// Decompiled with JetBrains decompiler
// Type: CVC.Migrations.DefaultDB.DefaultDB_20160515_072600_UserPreferences
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using FluentMigrator;
using FluentMigrator.Builders.Create.Table;
using System;

namespace CVC.Migrations.DefaultDB
{
  [Migration(20160515072600)]
  public class DefaultDB_20160515_072600_UserPreferences : AutoReversingMigration
  {
    public override void Up()
    {
      string table = "UserPreferences";
      string idField = "UserPreferenceId";
      // ISSUE: variable of the null type
      __Null local = null;
      int num = 0;
      this.CreateTableWithId32(table, idField, (Action<ICreateTableColumnOptionOrWithColumnSyntax>) (s => s.WithColumn("UserId").AsInt64().NotNullable().WithColumn("PreferenceType").AsString(100).NotNullable().WithColumn("Name").AsString(200).NotNullable().WithColumn("Value").AsString(int.MaxValue).Nullable()), (string) local, num != 0);
      this.Create.Index("IX_UserPref_UID_PrefType_Name").OnTable("UserPreferences").OnColumn("UserId").Ascending().OnColumn("PreferenceType").Ascending().OnColumn("Name").Ascending().WithOptions().Unique();
    }
  }
}
