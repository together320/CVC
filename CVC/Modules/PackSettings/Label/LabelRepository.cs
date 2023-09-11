// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Repositories.LabelRepository
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
  public class LabelRepository
  {
    private static LabelRow.RowFields fld
    {
      get
      {
        return LabelRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<LabelRow> request)
    {
            CheckLabelNameExist(request.Entity.LabelName, request.Entity.LabelId, "Create");

            return new LabelRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<LabelRow> request)
    {
            CheckLabelNameExist(request.Entity.LabelName, request.Entity.LabelId, "Update");

            return new LabelRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new LabelRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<LabelRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new LabelRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<LabelRow> List(IDbConnection connection, ListRequest request)
    {
      return new LabelRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<LabelRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<LabelRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<LabelRow>
    {
    }

    private class MyListHandler : ListRequestHandler<LabelRow>
    {
    }

        private void CheckLabelNameExist(string labelName, int? labelId, string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check Label Name exist
                var label = new Label();
                if (requestType == "Create")
                {
                    label = cvcEntities?.Labels?.FirstOrDefault(l => l.LabelName.ToLower() == labelName.ToLower());
                }
                else
                {
                    label = cvcEntities?.Labels?.FirstOrDefault(l => l.LabelName.ToLower() == labelName.ToLower() && l.LabelId != labelId);
                }
                if (label != null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'Label Name' value(s) exists!");
                }

                #endregion
            }
        }

    }
}
