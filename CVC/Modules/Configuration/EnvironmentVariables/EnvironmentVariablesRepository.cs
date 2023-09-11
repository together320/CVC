// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Repositories.EnvironmentVariablesRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web;

namespace CVC.Configuration.Repositories
{
    public class EnvironmentVariablesRepository
    {
        private static EnvironmentVariablesRow.RowFields fld
        {
            get
            {
                return EnvironmentVariablesRow.Fields;
            }
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<EnvironmentVariablesRow> request)
        {
            var requestEntity = request.Entity;
            if ((requestEntity?.PasswordMinLength ?? 0) > (requestEntity?.PasswordMaxLength ?? 0))
            {
                throw new Serenity.Services.ValidationError("Error", "Password minimum length cannot be more than Max length ");
            }

            var sumOfPasswordComplexityLength = ((requestEntity?.MinAlphaChars ?? 0) + (requestEntity?.MinCapitalLetter ?? 0) + (requestEntity?.MinNumericChars ?? 0) + (requestEntity?.MinSpecialChars ?? 0));

            if (sumOfPasswordComplexityLength > (requestEntity?.PasswordMaxLength ?? 0))
            {
                throw new Serenity.Services.ValidationError("Error", "Total number of Password complexity cannot be more than Password max length");
            }

            if (sumOfPasswordComplexityLength < (requestEntity?.PasswordMinLength ?? 0))
            {
                throw new Serenity.Services.ValidationError("Error", "Total number of Password complexity cannot be less than Password min length");
            }


            // HttpContext.Current.Session["CVCUserName_ForSessionTimeOut"] = HttpContext.Current.Session["CVCUserName_ForSessionTimeOut"].ToString();
            // HttpContext.Current.Session.Timeout = request.Entity?.SessionTimeOut ?? 20;
            return new EnvironmentVariablesRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<EnvironmentVariablesRow> request)
        {
            var requestEntity = request.Entity;
            if ((requestEntity?.PasswordMinLength??0) > (requestEntity?.PasswordMaxLength??0))
            {
                throw new Serenity.Services.ValidationError("Error", "Password minimum length cannot be more than Max length ");
            }

            var sumOfPasswordComplexityLength = ((requestEntity?.MinAlphaChars??0) + (requestEntity?.MinCapitalLetter??0) + (requestEntity?.MinNumericChars??0) + (requestEntity?.MinSpecialChars??0));

            if (sumOfPasswordComplexityLength > (requestEntity?.PasswordMaxLength??0))
            {
                throw new Serenity.Services.ValidationError("Error", "Total number of Password complexity cannot be more than Password max length");
            }

            if (sumOfPasswordComplexityLength < (requestEntity?.PasswordMinLength??0))
            {
                throw new Serenity.Services.ValidationError("Error", "Total number of Password complexity cannot be less than Password min length");
            }

            // HttpContext.Current.Session["CVCUserName_ForSessionTimeOut"] = HttpContext.Current.Session["CVCUserName_ForSessionTimeOut"].ToString();
            // HttpContext.Current.Session.Timeout = request.Entity?.SessionTimeOut ?? 20;
            return new EnvironmentVariablesRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new EnvironmentVariablesRepository.MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<EnvironmentVariablesRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new EnvironmentVariablesRepository.MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<EnvironmentVariablesRow> List(IDbConnection connection, ListRequest request)
        {
            return new EnvironmentVariablesRepository.MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<EnvironmentVariablesRow>
        {
        }

        private class MyDeleteHandler : DeleteRequestHandler<EnvironmentVariablesRow>
        {
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<EnvironmentVariablesRow>
        {
        }

        private class MyListHandler : ListRequestHandler<EnvironmentVariablesRow>
        {

        }



    }
}
