// Decompiled with JetBrains decompiler
// Type: CVC.Migrations.Utils
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using FluentMigrator;
using FluentMigrator.Builders.Create.Table;
using System;

namespace CVC.Migrations
{
  public static class Utils
  {
    public static string[] AllExceptOracle = new string[9]
    {
      "SqlServer",
      "SqlServer2000",
      "SqlServerCe",
      "Postgres",
      "MySql",
      "Firebird",
      "Jet",
      "Sqlite",
      "SAP HANA"
    };

    public static void CreateTableWithId32(this MigrationBase migration, string table, string idField, Action<ICreateTableColumnOptionOrWithColumnSyntax> addColumns, string schema = null, bool checkExists = false)
    {
      Utils.CreateTableWithId(migration, table, idField, addColumns, schema, 32, checkExists);
    }

    public static void CreateTableWithId64(this MigrationBase migration, string table, string idField, Action<ICreateTableColumnOptionOrWithColumnSyntax> addColumns, string schema = null, bool checkExists = false)
    {
      Utils.CreateTableWithId(migration, table, idField, addColumns, schema, 64, checkExists);
    }

    private static void CreateTableWithId(MigrationBase migration, string table, string idField, Action<ICreateTableColumnOptionOrWithColumnSyntax> addColumns, string schema, int size, bool checkExists = false)
    {
      Func<ICreateTableColumnAsTypeSyntax, ICreateTableColumnOptionOrWithColumnSyntax> func1 = (Func<ICreateTableColumnAsTypeSyntax, ICreateTableColumnOptionOrWithColumnSyntax>) (col =>
      {
        if (size == 64)
          return col.AsInt64();
        if (size == 16)
          return col.AsInt16();
        return col.AsInt32();
      });
      Func<ICreateTableWithColumnOrSchemaOrDescriptionSyntax, ICreateTableWithColumnSyntax> func2 = (Func<ICreateTableWithColumnOrSchemaOrDescriptionSyntax, ICreateTableWithColumnSyntax>) (syntax =>
      {
        if (schema != null)
          return syntax.InSchema(schema);
        return (ICreateTableWithColumnSyntax) syntax;
      });
      if (checkExists && (schema != null && migration.Schema.Schema(schema).Table(table).Exists() || schema == null && migration.Schema.Table(table).Exists()))
        return;
      addColumns(func1(func2(migration.IfDatabase(Utils.AllExceptOracle).Create.Table(table)).WithColumn(idField)).Identity().PrimaryKey().NotNullable());
      addColumns(func1(func2(migration.IfDatabase("Oracle").Create.Table(table)).WithColumn(idField)).PrimaryKey().NotNullable());
      Utils.AddOracleIdentity(migration, table, idField);
    }

    public static void AddOracleIdentity(MigrationBase migration, string table, string id)
    {
      string str1 = table.Replace(" ", "_").Replace("\"", "");
      string str2 = str1.Substring(0, Math.Min(20, str1.Length)) + "_SEQ";
      migration.IfDatabase("Oracle").Execute.Sql("CREATE SEQUENCE " + str2);
      migration.IfDatabase("Oracle").Execute.Sql(string.Format("\r\nCREATE OR REPLACE TRIGGER {2}_TRG\r\nBEFORE INSERT ON {0}\r\nFOR EACH ROW\r\nBEGIN\r\n\tIF :new.{1} IS NULL THEN\r\n\t\tSELECT {2}.nextval INTO :new.{1} FROM DUAL;\r\n\tEND IF;\r\nEND;", (object) table, (object) id, (object) str2));
      migration.IfDatabase("Oracle").Execute.Sql("ALTER TRIGGER " + str2 + "_TRG ENABLE");
    }
  }
}
