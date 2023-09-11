﻿// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Endpoints.OutsertController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.PackSettings.Entities;
using CVC.PackSettings.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.PackSettings.Endpoints
{
  [RoutePrefix("Services/PackSettings/Outsert")]
  [Route("{action}")]
  [ConnectionKey(typeof (OutsertRow))]
  [ServiceAuthorize(typeof (OutsertRow))]
  public class OutsertController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (OutsertRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<OutsertRow> request)
    {
      return new OutsertRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (OutsertRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<OutsertRow> request)
    {
      return new OutsertRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (OutsertRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new OutsertRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<OutsertRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new OutsertRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<OutsertRow> List(IDbConnection connection, ListRequest request)
    {
      return new OutsertRepository().List(connection, request);
    }
  }
}
