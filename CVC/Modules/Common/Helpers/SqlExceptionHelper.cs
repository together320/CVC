// Decompiled with JetBrains decompiler
// Type: CVC.SqlExceptionHelper
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using System;
using System.Data.SqlClient;

namespace CVC
{
  public static class SqlExceptionHelper
  {
    public static void HandleDeleteForeignKeyException(Exception e)
    {
      ForeignKeyExceptionInfo fk;
      if (SqlExceptionHelper.IsForeignKeyException(e, out fk))
        throw new Serenity.Services.ValidationError(string.Format((string) Texts.Validation.DeleteForeignKeyError, (object) fk.TableName));
    }

    public static void HandleSavePrimaryKeyException(Exception e, string fieldName = "ID")
    {
      PrimaryKeyExceptionInfo pk;
      if (SqlExceptionHelper.IsPrimaryKeyException(e, out pk))
        throw new Serenity.Services.ValidationError(string.Format((string) Texts.Validation.SavePrimaryKeyError, (object) pk.TableName, (object) fieldName));
    }

    public static bool IsForeignKeyException(Exception e, out ForeignKeyExceptionInfo fk)
    {
      SqlException sqlException = e as SqlException;
      if (sqlException != null && sqlException.Errors.Count > 0 && sqlException.Errors[0].Number == 547)
      {
        string message = sqlException.Errors[0].Message;
        fk = new ForeignKeyExceptionInfo();
        fk.TableName = "???";
        string str = ", table \"";
        int num1 = message.IndexOf(str);
        if (num1 >= 0)
        {
          int startIndex = num1 + str.Length;
          int num2 = message.IndexOf("\", column", startIndex + 1);
          if (num2 >= 0)
          {
            fk.TableName = message.Substring(startIndex, num2 - startIndex);
            if (fk.TableName.StartsWith("dbo."))
              fk.TableName = fk.TableName.Substring("dbo.".Length);
          }
        }
        return true;
      }
      fk = (ForeignKeyExceptionInfo) null;
      return false;
    }

    public static bool IsPrimaryKeyException(Exception e, out PrimaryKeyExceptionInfo pk)
    {
      SqlException sqlException = e as SqlException;
      if (sqlException != null && sqlException.Errors.Count > 0 && sqlException.Errors[0].Number == 2627)
      {
        string message = sqlException.Errors[0].Message;
        pk = new PrimaryKeyExceptionInfo();
        pk.TableName = "???";
        string str = "in object '";
        int num1 = message.IndexOf(str);
        if (num1 >= 0)
        {
          int startIndex = num1 + str.Length;
          int num2 = message.IndexOf("'.", startIndex + 1);
          if (num2 >= 0)
          {
            pk.TableName = message.Substring(startIndex, num2 - startIndex);
            if (pk.TableName.StartsWith("dbo."))
              pk.TableName = pk.TableName.Substring("dbo.".Length);
          }
        }
        return true;
      }
      pk = (PrimaryKeyExceptionInfo) null;
      return false;
    }
  }
}
