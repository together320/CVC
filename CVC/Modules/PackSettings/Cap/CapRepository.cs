// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Repositories.CapRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data.EDMX;
using CVC.PackSettings.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Linq;

namespace CVC.PackSettings.Repositories
{
  public class CapRepository
  {
    private static CapRow.RowFields fld
    {
      get
      {
        return CapRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<CapRow> request)
        {
            CheckCapNameExist(request.Entity.CapName, request.Entity.CapId, "Create");

            return new CapRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<CapRow> request)
        {
            CheckCapNameExist(request.Entity.CapName, request.Entity.CapId, "Update");

            return new CapRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new CapRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<CapRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new CapRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<CapRow> List(IDbConnection connection, ListRequest request)
    {
      return new CapRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<CapRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<CapRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<CapRow>
    {
    }

    private class MyListHandler : ListRequestHandler<CapRow>
    {
    }

        private void CheckCapNameExist(string capName, int? capId, string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check Cap Name exist
                var cap = new Cap();
                if (requestType == "Create")
                {
                    cap = cvcEntities?.Caps?.FirstOrDefault(b => b.CapName.ToLower() == capName.ToLower());
                }
                else
                {
                    cap = cvcEntities?.Caps?.FirstOrDefault(b => b.CapName.ToLower() == capName.ToLower() && b.CapId != capId);
                }
                if (cap != null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'Cap Name' value(s) exists!");
                }

                #endregion
            }
        }

    }
}
