// Decompiled with JetBrains decompiler
// Type: CVC.Common.Repositories.UserPreferenceRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Common.Entities;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Common.Repositories
{
  public class UserPreferenceRepository
  {
    private static UserPreferenceRow.RowFields fld
    {
      get
      {
        return UserPreferenceRow.Fields;
      }
    }

    public SaveResponse Update(IUnitOfWork uow, UserPreferenceUpdateRequest request)
    {
      Check.NotNull((object) request, nameof (request));
      Check.NotNull((object) request.Name, "name");
      Check.NotNull((object) request.PreferenceType, "preferenceType");
      int userId = (Authorization.UserDefinition as UserDefinition).UserId;
      BaseCriteria baseCriteria = (Field) UserPreferenceRepository.fld.UserId == userId & (Field) UserPreferenceRepository.fld.PreferenceType == request.PreferenceType & (Field) UserPreferenceRepository.fld.Name == request.Name;
      if (string.IsNullOrEmpty(request.Value))
      {
        new SqlDelete(UserPreferenceRepository.fld.TableName).Where<SqlDelete>((ICriteria) baseCriteria).Execute(uow.Connection, ExpectedRows.ZeroOrOne);
        return new SaveResponse();
      }
      if (new SqlUpdate(UserPreferenceRepository.fld.TableName).Set<SqlUpdate>((IField) UserPreferenceRepository.fld.Value, (object) request.Value).Where<SqlUpdate>((ICriteria) baseCriteria).Execute(uow.Connection, ExpectedRows.ZeroOrOne) == 0)
        new SqlInsert(UserPreferenceRepository.fld.TableName).Set<SqlInsert>((IField) UserPreferenceRepository.fld.UserId, (object) userId).Set<SqlInsert>((IField) UserPreferenceRepository.fld.PreferenceType, (object) request.PreferenceType).Set<SqlInsert>((IField) UserPreferenceRepository.fld.Name, (object) request.Name).Set<SqlInsert>((IField) UserPreferenceRepository.fld.Value, (object) request.Value).Execute(uow.Connection);
      return new SaveResponse();
    }

    public UserPreferenceRetrieveResponse Retrieve(IDbConnection connection, UserPreferenceRetrieveRequest request)
    {
      Check.NotNull((object) request, nameof (request));
      Check.NotNull((object) request.Name, "name");
      Check.NotNull((object) request.PreferenceType, "preferenceType");
      int userId = (Authorization.UserDefinition as UserDefinition).UserId;
      UserPreferenceRow userPreferenceRow = connection.TryFirst<UserPreferenceRow>((ICriteria) ((Field) UserPreferenceRepository.fld.UserId == userId & (Field) UserPreferenceRepository.fld.PreferenceType == request.PreferenceType & (Field) UserPreferenceRepository.fld.Name == request.Name));
      if (userPreferenceRow == null)
        return new UserPreferenceRetrieveResponse();
      return new UserPreferenceRetrieveResponse()
      {
        Value = userPreferenceRow.Value
      };
    }
  }
}
