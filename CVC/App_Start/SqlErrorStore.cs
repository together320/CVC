// Decompiled with JetBrains decompiler
// Type: CVC.SqlErrorStore
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity;
using Serenity.Data;
using StackExchange.Exceptional;
using StackExchange.Exceptional.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CVC
{
  public sealed class SqlErrorStore : ErrorStore
  {
    private static readonly BaseCriteria hashMatch = (BaseCriteria) new Criteria("[ErrorHash]") == (BaseCriteria) new ParamCriteria("@ErrorHash") & (BaseCriteria) new Criteria("[ApplicationName]") == (BaseCriteria) new ParamCriteria("@ApplicationName") & new Criteria("[DeletionDate]").IsNull() & (BaseCriteria) new Criteria("[CreationDate]") >= (BaseCriteria) new ParamCriteria("@minDate");
    private readonly int displayCount = 200;
    private readonly string connectionString;
    private readonly string providerName;
    private readonly bool isSqlServer;
    public const int MaximumDisplayCount = 500;
    public const int DefaultDisplayCount = 200;

    public SqlErrorStore(ErrorStoreSettings settings)
      : this(settings.ConnectionString, settings.ConnectionStringName, settings.Size, settings.RollupSeconds)
    {
    }

    public SqlErrorStore(string connectionString, string connectionKey, int displayCount = 200, int rollupSeconds = 600)
      : base(rollupSeconds, 1000)
    {
      displayCount = Math.Min(displayCount, 500);
      if (ExtensionMethods.IsNullOrEmpty(connectionString))
      {
        ConnectionStringInfo connectionString1 = SqlConnections.GetConnectionString(connectionKey);
        this.connectionString = connectionString1.ConnectionString;
        this.providerName = connectionString1.ProviderName;
        this.isSqlServer = connectionString1.Dialect.ServerType.StartsWith("SqlServer", StringComparison.OrdinalIgnoreCase);
      }
      else
      {
        this.connectionString = connectionString;
        this.providerName = connectionKey;
        this.isSqlServer = this.providerName.IndexOf("SqlClient", StringComparison.OrdinalIgnoreCase) >= 0;
      }
      SqlConnections.GetFactory(this.providerName);
      if (ExtensionMethods.IsNullOrEmpty(this.connectionString))
        throw new ArgumentOutOfRangeException("settings", "A connection string or connection string name must be specified when using a SQL error store");
    }

    public override string Name
    {
      get
      {
        return "Serenity Sql Error Store";
      }
    }

    protected override bool ProtectError(Guid guid)
    {
      using (IDbConnection connection = this.GetConnection())
        return new SqlUpdate("Exceptions").Set<SqlUpdate>("IsProtected", (object) true).SetNull("DeletionDate").Where<SqlUpdate>((ICriteria) ((BaseCriteria) new Criteria("[GUID]") == guid)).Execute(connection, ExpectedRows.Ignore) > 0;
    }

    protected override bool ProtectErrors(IEnumerable<Guid> guids)
    {
      using (IDbConnection connection = this.GetConnection())
        return new SqlUpdate("Exceptions").Set<SqlUpdate>("IsProtected", (object) true).SetNull("DeletionDate").Where<SqlUpdate>((ICriteria) new Criteria("[GUID]").In<IEnumerable<Guid>>(new IEnumerable<Guid>[1]
        {
          guids
        })).Execute(connection, ExpectedRows.Ignore) > 0;
    }

    protected override bool DeleteError(Guid guid)
    {
      using (IDbConnection connection = this.GetConnection())
        return new SqlUpdate("Exceptions").Set<SqlUpdate>("DeletionDate", (object) DateTime.UtcNow).Where<SqlUpdate>((ICriteria) ((BaseCriteria) new Criteria("[GUID]") == guid & new Criteria("[DeletionDate]").IsNull())).Execute(connection, ExpectedRows.Ignore) > 0;
    }

    protected override bool DeleteErrors(IEnumerable<Guid> guids)
    {
      using (IDbConnection connection = this.GetConnection())
        return new SqlUpdate("Exceptions").Set<SqlUpdate>("DeletionDate", (object) DateTime.UtcNow).Where<SqlUpdate>((ICriteria) (new Criteria("[GUID]").In<IEnumerable<Guid>>(new IEnumerable<Guid>[1]
        {
          guids
        }) & new Criteria("[DeletionDate]").IsNull())).Execute(connection, ExpectedRows.Ignore) > 0;
    }

    protected override bool HardDeleteError(Guid guid)
    {
      using (IDbConnection connection = this.GetConnection())
        return new SqlDelete("Exceptions").Where<SqlDelete>((ICriteria) ((BaseCriteria) new Criteria("[GUID]") == guid & (BaseCriteria) new Criteria("[ApplicationName]") == ErrorStore.ApplicationName)).Execute(connection, ExpectedRows.Ignore) > 0;
    }

    protected override bool DeleteAllErrors(string applicationName = null)
    {
      using (IDbConnection connection = this.GetConnection())
        return new SqlUpdate("Exceptions").Set<SqlUpdate>("DeletionDate", (object) DateTime.UtcNow).Where<SqlUpdate>((ICriteria) (new Criteria("[DeletionDate]").IsNull() & (BaseCriteria) new Criteria("[IsProtected]") == 0 & (BaseCriteria) new Criteria("[ApplicationName]") == applicationName.IsNullOrEmptyReturn(ErrorStore.ApplicationName))).Execute(connection, ExpectedRows.Ignore) > 0;
    }

    protected override void LogError(Error error)
    {
      //using (IDbConnection connection = this.GetConnection())
      //{
      //  if (!this.RollupThreshold.HasValue)
      //    return;
      //  int? nullable = error.ErrorHash;
      //  if (!nullable.HasValue)
      //    return;
      //  DynamicParameters dynamicParameters1 = new DynamicParameters((object) new
      //  {
      //    DuplicateCount = error.DuplicateCount,
      //    ErrorHash = error.ErrorHash,
      //    ApplicationName = error.ApplicationName.Truncate(50),
      //    minDate = DateTime.UtcNow.Add(this.RollupThreshold.Value.Negate())
      //  });
      //  if (this.isSqlServer)
      //  {
      //    DynamicParameters dynamicParameters2 = dynamicParameters1;
      //    string name = "@newGUID";
      //    // ISSUE: variable of the null type
      //    __Null local1 = null;
      //    DbType? dbType = new DbType?(DbType.Guid);
      //    ParameterDirection? direction = new ParameterDirection?(ParameterDirection.Output);
      //    nullable = new int?();
      //    int? size = nullable;
      //    dynamicParameters2.Add(name, (object) local1, dbType, direction, size);
      //    IDbConnection cnn = connection;
      //    string sql = "\r\nUpdate Exceptions \r\n    Set DuplicateCount = DuplicateCount + @DuplicateCount,\r\n        @newGUID = GUID\r\n    Where Id In (Select Top 1 Id\r\n                From Exceptions \r\n                Where ErrorHash = @ErrorHash\r\n                    And ApplicationName = @ApplicationName\r\n                    And DeletionDate Is Null\r\n                    And CreationDate >= @minDate)";
      //    DynamicParameters dynamicParameters3 = dynamicParameters1;
      //    // ISSUE: variable of the null type
      //    __Null local2 = null;
      //    nullable = new int?();
      //    int? commandTimeout = nullable;
      //    CommandType? commandType = new CommandType?();
      //    if (cnn.Execute(sql, (object) dynamicParameters3, (IDbTransaction) local2, commandTimeout, commandType) > 0)
      //    {
      //      error.GUID = dynamicParameters1.Get<Guid>("@newGUID");
      //      return;
      //    }
      //  }
      //  else if (0 > 0)
      //  {
      //    Error error1 = error;
      //    IDbConnection cnn = connection;
      //    SqlQuery sqlQuery = new SqlQuery().Dialect(connection.GetDialect()).From("Exceptions").Select("GUID").Take(1).Where<SqlQuery>((ICriteria) SqlErrorStore.hashMatch);
      //    // ISSUE: variable of the null type
      //    __Null local = null;
      //    int num = 1;
      //    nullable = new int?();
      //    int? commandTimeout = nullable;
      //    CommandType? commandType = new CommandType?();
      //    Guid guid = cnn.Query<Guid>((ISqlQuery) sqlQuery, (IDbTransaction) local, num != 0, commandTimeout, commandType).First<Guid>();
      //    error1.GUID = guid;
      //    return;
      //  }
      //  error.FullJson = error.ToJson();
      //  IDbConnection cnn1 = connection;
      //  string sql1 = "\r\nInsert Into Exceptions ([GUID], [ApplicationName], [MachineName], [CreationDate], [Type], [IsProtected], [Host], [Url], [HTTPMethod], [IPAddress], [Source], [Message], [Detail], [StatusCode], [SQL], [FullJson], [ErrorHash], [DuplicateCount])\r\nValues (@GUID, @ApplicationName, @MachineName, @CreationDate, @Type, @IsProtected, @Host, @Url, @HTTPMethod, @IPAddress, @Source, @Message, @Detail, @StatusCode, @SQL, @FullJson, @ErrorHash, @DuplicateCount)";
      //  var data = new
      //  {
      //    GUID = error.GUID,
      //    ApplicationName = error.ApplicationName.Truncate(50),
      //    MachineName = error.MachineName.Truncate(50),
      //    CreationDate = error.CreationDate,
      //    Type = error.Type.Truncate(100),
      //    IsProtected = error.IsProtected,
      //    Host = error.Host.Truncate(100),
      //    Url = error.Url.Truncate(500),
      //    HTTPMethod = error.HTTPMethod.Truncate(10),
      //    IPAddress = error.IPAddress,
      //    Source = error.Source.Truncate(100),
      //    Message = error.Message.Truncate(1000),
      //    Detail = error.Detail,
      //    StatusCode = error.StatusCode,
      //    SQL = error.SQL,
      //    FullJson = error.FullJson.Truncate(1000),
      //    ErrorHash = error.ErrorHash,
      //    DuplicateCount = error.DuplicateCount
      //  };
      //  // ISSUE: variable of the null type
      //  __Null local3 = null;
      //  nullable = new int?();
      //  int? commandTimeout1 = nullable;
      //  CommandType? commandType1 = new CommandType?();
      //  cnn1.Execute(sql1, (object) data, (IDbTransaction) local3, commandTimeout1, commandType1);
      //}
    }

    protected override Error GetError(Guid guid)
    {
      Error error1;
      using (IDbConnection connection = this.GetConnection())
        error1 = connection.Query<Error>("\r\nSelect * \r\n  From [Exceptions] \r\n Where [GUID] = @guid", (object) new
        {
          guid = guid
        }, (IDbTransaction) null, true, new int?(), new CommandType?()).FirstOrDefault<Error>();
      if (error1 == null)
        return (Error) null;
      Error error2 = Error.FromJson(error1.FullJson);
      error2.DuplicateCount = error1.DuplicateCount;
      error2.DeletionDate = error1.DeletionDate;
      return error2;
    }

    protected override int GetAllErrors(List<Error> errors, string applicationName = null)
    {
      using (IDbConnection connection = this.GetConnection())
        errors.AddRange(connection.Query<Error>((ISqlQuery) new SqlQuery().Dialect(connection.GetDialect()).From("Exceptions").Take(this.displayCount).Select("*").Where<SqlQuery>((ICriteria) ((BaseCriteria) new Criteria("[ApplicationName]") == applicationName.IsNullOrEmptyReturn(ErrorStore.ApplicationName) & new Criteria("[DeletionDate]").IsNull())).OrderBy("CreationDate", true), (IDbTransaction) null, true, new int?(), new CommandType?()));
      return errors.Count;
    }

    protected override int GetErrorCount(DateTime? since = null, string applicationName = null)
    {
      using (IDbConnection connection = this.GetConnection())
        return connection.Query<int>((ISqlQuery) new SqlQuery().Dialect(connection.GetDialect()).From("Exceptions").Select("Count(*)").Where<SqlQuery>((ICriteria) ((BaseCriteria) new Criteria("[ApplicationName]") == applicationName.IsNullOrEmptyReturn(ErrorStore.ApplicationName) & new Criteria("[DeletionDate]").IsNull() & (since.HasValue ? (BaseCriteria) new Criteria("[CreationDate]") > since.Value : Criteria.Empty))).OrderBy("CreationDate", true), (IDbTransaction) null, true, new int?(), new CommandType?()).FirstOrDefault<int>();
    }

    private IDbConnection GetConnection()
    {
      return SqlConnections.New(this.connectionString, this.providerName);
    }
  }
}
