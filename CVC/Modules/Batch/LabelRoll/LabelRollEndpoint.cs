// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Endpoints.LabelRollController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using CVC.Batch.Repositories;
using CVC.Modules.Common.Dashboard;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Batch.Endpoints
{
    [RoutePrefix("Services/Batch/LabelRoll")]
    [Route("{action}")]
    [ConnectionKey(typeof(LabelRollRow))]
    //commeneted by Vinayak Ok 23.07.2018
    //[ServiceAuthorize(typeof(LabelRollRow))]
    public class LabelRollController : ServiceEndpoint
    {
        [HttpPost]
       // [AuthorizeCreate(typeof(LabelRollRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<LabelRollRow> request)
        {
            return new LabelRollRepository().Create(uow, request);
        }

        [HttpPost]
      //  [AuthorizeUpdate(typeof(LabelRollRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<LabelRollRow> request)
        {
            return new LabelRollRepository().Update(uow, request);
        }

        [HttpPost]
        //[AuthorizeDelete(typeof(LabelRollRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new LabelRollRepository().Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<LabelRollRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new LabelRollRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<LabelRollRow> List(IDbConnection connection, ListRequest request)
        {
            return new LabelRollRepository().List(connection, request);
        }

    }
}
