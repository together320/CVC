// Decompiled with JetBrains decompiler
// Type: CVC.Migrations.DefaultDB.DefaultDB_20141111_113000_Permissions
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using FluentMigrator;
using FluentMigrator.Builders.Create.Table;
using System;

namespace CVC.Migrations.DefaultDB
{
  [Migration(20141111113000)]
  public class DefaultDB_20141111_113000_Permissions : AutoReversingMigration
  {
    public override void Up()
    {
      string table1 = "UserPermissions";
      string idField1 = "UserPermissionId";
      // ISSUE: variable of the null type
      __Null local1 = null;
      int num1 = 0;
      this.CreateTableWithId64(table1, idField1, (Action<ICreateTableColumnOptionOrWithColumnSyntax>) (s => s.WithColumn("UserId").AsInt32().NotNullable().ForeignKey("FK_UserPermissions_UserId", "Users", "UserId").WithColumn("PermissionKey").AsString(100).NotNullable().WithColumn("Granted").AsBoolean().NotNullable().WithDefaultValue((object) true)), (string) local1, num1 != 0);
      this.Create.Index("UQ_UserPerm_UserId_PermKey").OnTable("UserPermissions").OnColumn("UserId").Ascending().OnColumn("PermissionKey").Ascending().WithOptions().Unique();
      string table2 = "Roles";
      string idField2 = "RoleId";
      // ISSUE: variable of the null type
      __Null local2 = null;
      int num2 = 0;
      this.CreateTableWithId32(table2, idField2, (Action<ICreateTableColumnOptionOrWithColumnSyntax>) (s => s.WithColumn("RoleName").AsString(100).NotNullable()), (string) local2, num2 != 0);
      string table3 = "RolePermissions";
      string idField3 = "RolePermissionId";
      // ISSUE: variable of the null type
      __Null local3 = null;
      int num3 = 0;
      this.CreateTableWithId64(table3, idField3, (Action<ICreateTableColumnOptionOrWithColumnSyntax>) (s => s.WithColumn("RoleId").AsInt32().NotNullable().ForeignKey("FK_RolePermissions_RoleId", "Roles", "RoleId").WithColumn("PermissionKey").AsString(100).NotNullable()), (string) local3, num3 != 0);
      this.Create.Index("UQ_RolePerm_RoleId_PermKey").OnTable("RolePermissions").OnColumn("RoleId").Ascending().OnColumn("PermissionKey").Ascending().WithOptions().Unique();
      string table4 = "UserRoles";
      string idField4 = "UserRoleId";
      // ISSUE: variable of the null type
      __Null local4 = null;
      int num4 = 0;
      this.CreateTableWithId64(table4, idField4, (Action<ICreateTableColumnOptionOrWithColumnSyntax>) (s => s.WithColumn("UserId").AsInt32().NotNullable().ForeignKey("FK_UserRoles_UserId", "Users", "UserId").WithColumn("RoleId").AsInt32().NotNullable().ForeignKey("FK_UserRoles_RoleId", "Roles", "RoleId")), (string) local4, num4 != 0);
      this.Create.Index("UQ_UserRoles_UserId_RoleId").OnTable("UserRoles").OnColumn("UserId").Ascending().OnColumn("RoleId").Ascending().WithOptions().Unique();
      this.Create.Index("IX_UserRoles_RoleId_UserId").OnTable("UserRoles").OnColumn("RoleId").Ascending().OnColumn("UserId").Ascending();
    }
  }
}
