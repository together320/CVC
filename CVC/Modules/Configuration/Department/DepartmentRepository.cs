// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Repositories.DepartmentRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.Data.EDMX;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Linq;

namespace CVC.Configuration.Repositories
{
  public class DepartmentRepository
  {
    private static DepartmentRow.RowFields fld
    {
      get
      {
        return DepartmentRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<DepartmentRow> request)
    {
            CheckDepartmentNameExist(request.Entity.DepartmentName,request.Entity.DepartmentId, "Create");
            return new DepartmentRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<DepartmentRow> request)
        {
            CheckDepartmentNameExist(request.Entity.DepartmentName, request.Entity.DepartmentId, "Update");
            return new DepartmentRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new DepartmentRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<DepartmentRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new DepartmentRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<DepartmentRow> List(IDbConnection connection, ListRequest request)
    {
      return new DepartmentRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<DepartmentRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<DepartmentRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<DepartmentRow>
    {
    }

    private class MyListHandler : ListRequestHandler<DepartmentRow>
    {
    }

        private void CheckDepartmentNameExist(string departmentName, int? departmentId, string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check Department Name exist
                var department = new Department();
                if (requestType == "Create")
                {
                    department = cvcEntities?.Departments?.FirstOrDefault(d => d.DepartmentName.ToLower() == departmentName.ToLower());
                }
                else
                {
                    department = cvcEntities?.Departments?.FirstOrDefault(d => d.DepartmentName.ToLower() == departmentName.ToLower() && d.DepartmentId!=departmentId );
                }
                if (department != null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'Department Name' value(s) exists!");
                }

                #endregion
            }
        }

    }
}
