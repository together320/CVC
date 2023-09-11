// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Endpoints.CompanyController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.Configuration.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Configuration.Endpoints
{
    [RoutePrefix("Services/Configuration/Company")]
    [Route("{action}")]
    [ConnectionKey(typeof(CompanyRow))]
    [ServiceAuthorize(typeof(CompanyRow))]
    public class CompanyController : ServiceEndpoint
    {
        [HttpPost]
        [AuthorizeCreate(typeof(CompanyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<CompanyRow> request)
        {
            return new CompanyRepository().Create(uow, request);
        }

        [HttpPost]
        [AuthorizeUpdate(typeof(CompanyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<CompanyRow> request)
        {
            return new CompanyRepository().Update(uow, request);
        }

        [HttpPost]
        [AuthorizeDelete(typeof(CompanyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new CompanyRepository().Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<CompanyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new CompanyRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<CompanyRow> List(IDbConnection connection, ListRequest request)
        {
            return new CompanyRepository().List(connection, request);
        }
    }
}
