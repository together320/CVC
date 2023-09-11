// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Repositories.RoleRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Data.EDMX;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using System.Linq;
namespace CVC.Administration.Repositories
{
  public class RoleRepository
  {
    private static RoleRow.RowFields fld
    {
      get
      {
        return RoleRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<RoleRow> request)
    {
      return new RoleRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<RoleRow> request)
    {
      return new RoleRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new RoleRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<RoleRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new RoleRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<RoleRow> List(IDbConnection connection, ListRequest request)
        {
            // CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var GetUserId = Serenity.Authorization.UserId;
                var UserId = Convert.ToInt32(GetUserId);
                var RoleId = cvcEntities.Users.FirstOrDefault(u => u.UserId == UserId).RoleId;
                //Serenity.Services.ListResponse<CVC.Administration.Entities.RoleRow> lstRoleRow = new ListResponse<RoleRow>();
                // lstRoleRow.Entities = RoleId == 1 ? new RoleRepository.MyListHandler().Process(connection, request).Entities.ToList() : new RoleRepository.MyListHandler().Process(connection, request).Entities.Where(r => r.RoleId != 1).ToList();
                Serenity.Services.ListResponse<CVC.Administration.Entities.RoleRow> lstRoleRow = new ListResponse<RoleRow>
                {
                    Entities = RoleId == 1 ? new RoleRepository.MyListHandler().Process(connection, request).Entities.ToList() : new RoleRepository.MyListHandler().Process(connection, request).Entities.Where(r => r.RoleId != 1).ToList()
                };
                return lstRoleRow;
            }
            //return new RoleRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<RoleRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<RoleRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<RoleRow>
    {
    }

    private class MyListHandler : ListRequestHandler<RoleRow>
    {
    }
  }
}
