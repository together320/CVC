// Decompiled with JetBrains decompiler
// Type: CVC.GetNextNumberHelper
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity;
using Serenity.Data;
using System.Data;
using System.Linq;

namespace CVC
{
  public static class GetNextNumberHelper
  {
    public static GetNextNumberResponse GetNextNumber(IDbConnection connection, GetNextNumberRequest request, Field field)
    {
      string mask = request.Prefix ?? "";
      string str = connection.Query<string>((ISqlQuery) new SqlQuery().From((IAlias) field.Fields).Select(Sql.Max(field.Expression)).Where<SqlQuery>((ICriteria) (field.StartsWith(mask) && field >= mask.PadRight(request.Length, '0') && field <= mask.PadRight(request.Length, '9'))), (IDbTransaction) null, true, new int?(), new CommandType?()).FirstOrDefault<string>();
      GetNextNumberResponse nextNumberResponse = new GetNextNumberResponse();
      long result;
      nextNumberResponse.Number = str == null || !long.TryParse(str.Substring(mask.Length), out result) ? 1L : result + 1L;
      nextNumberResponse.Serial = mask + nextNumberResponse.Number.ToString().PadLeft(request.Length - mask.Length, '0');
      return nextNumberResponse;
    }
  }
}
