// Decompiled with JetBrains decompiler
// Type: CVC.ExternalApplicationInterface.Repositories.MachineCommunicationRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.ExternalApplicationInterface.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.ExternalApplicationInterface.Repositories
{
    public class MachineCommunicationRepository
    {
        private static MachineCommunicationRow.RowFields fld
        {
            get
            {
                return MachineCommunicationRow.Fields;
            }
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineCommunicationRow> request)
        {
            return new MachineCommunicationRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineCommunicationRow> request)
        {
            return new MachineCommunicationRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MachineCommunicationRepository.MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MachineCommunicationRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MachineCommunicationRepository.MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MachineCommunicationRow> List(IDbConnection connection, ListRequest request)
        {
            return new MachineCommunicationRepository.MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<MachineCommunicationRow>
        {
            protected override void ValidateRequest()
            {
                base.ValidateRequest();

            }
        }

        private class MyDeleteHandler : DeleteRequestHandler<MachineCommunicationRow>
        {
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<MachineCommunicationRow>
        {
        }

        private class MyListHandler : ListRequestHandler<MachineCommunicationRow>
        {
        }
    }
}
