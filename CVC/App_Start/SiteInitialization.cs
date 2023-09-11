// Decompiled with JetBrains decompiler
// Type: CVC.SiteInitialization
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration;
using FluentMigrator.Runner;
using FluentMigrator.Runner.Announcers;
using FluentMigrator.Runner.Initialization;
using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Web;
using StackExchange.Exceptional;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Hosting;
using System.Web.Security;

namespace CVC
{
  public static class SiteInitialization
  {
    private static string[] databaseKeys = new string[1]
    {
      "Default"
    };

    private static void InitializeExceptionLog()
    {
      ErrorStore.Setup("CVC", (ErrorStore) new SqlErrorStore((string) null, "Default", 200, 600));
      ErrorStore.GetCustomData = (Action<Exception, HttpContext, Dictionary<string, string>>) ((exception, context, data) =>
      {
        foreach (object key in (IEnumerable) exception.Data.Keys)
        {
          string str1 = key as string;
          if (str1 != null && str1.StartsWith("log:", StringComparison.OrdinalIgnoreCase))
          {
            object obj = exception.Data[key];
            string str2 = obj != null ? obj.ToString() : "[null]";
            data.Add(str1.Substring(4), str2);
          }
        }
      });
      ErrorStore.OnBeforeLog += (EventHandler<ErrorBeforeLogEventArgs>) ((sender, args) =>
      {
        if (args.Error.Exception != null && args.Error is INotLoggedException)
          args.Abort = true;
        args.Error.Cookies.Remove(FormsAuthentication.FormsCookieName);
        SiteInitialization.ReplaceKey(args.Error.Form, "Password");
        SiteInitialization.ReplaceKey(args.Error.Form, "PasswordConfirm");
      });
      Dependency.Resolve<IDependencyRegistrar>().RegisterInstance<IExceptionLogger>((IExceptionLogger) new SiteInitialization.ErrorStoreLogger());
    }

    private static void ReplaceKey(NameValueCollection collection, string key)
    {
      string index = collection[key];
      if (index == null)
        return;
      collection[index] = "***";
    }

    private static void EnsureDatabase(string databaseKey)
    {
      ConnectionStringInfo connectionString = SqlConnections.GetConnectionString(databaseKey);
      string serverType = connectionString.Dialect.ServerType;
      bool flag1 = serverType.StartsWith("SqlServer", StringComparison.OrdinalIgnoreCase);
      bool flag2 = !flag1 & serverType.StartsWith("Postgres", StringComparison.OrdinalIgnoreCase);
      bool flag3 = !flag1 && !flag2 && serverType.StartsWith("MySql", StringComparison.OrdinalIgnoreCase);
      bool flag4 = !flag1 && !flag2 && !flag3 && serverType.StartsWith("Sqlite", StringComparison.OrdinalIgnoreCase);
      if (!flag1 && !flag2 && (!flag3 && !flag4))
        return;
      DbConnectionStringBuilder connectionStringBuilder = connectionString.ProviderFactory.CreateConnectionStringBuilder();
      connectionStringBuilder.ConnectionString = connectionString.ConnectionString;
      string index = "?";
      if (flag4)
      {
        string keyword = "Data Source";
        if (!connectionStringBuilder.ContainsKey(keyword))
          return;
        string str = connectionStringBuilder[keyword] as string;
        if (string.IsNullOrEmpty(str))
          return;
        string path = str.Replace("|DataDirectory|", HostingEnvironment.MapPath("~/App_Data/"));
        if (File.Exists(path))
          return;
        Directory.CreateDirectory(Path.GetDirectoryName(path));
        using (IDbConnection dbConnection = SqlConnections.New(connectionStringBuilder.ConnectionString, connectionString.ProviderName))
        {
          MethodInfo method = ((WrappedConnection) dbConnection).ActualConnection.GetType().GetMethod("CreateFile", BindingFlags.Static);
          if (method != (MethodInfo) null)
            method.Invoke((object) null, new object[1]
            {
              (object) path
            });
        }
        SqlConnection.ClearAllPools();
      }
      else
      {
        string[] strArray = new string[3]
        {
          "Initial Catalog",
          "Database",
          "AttachDBFilename"
        };
        foreach (string keyword in strArray)
        {
          if (connectionStringBuilder.ContainsKey(keyword))
          {
            index = keyword;
            break;
          }
        }
        string path2 = connectionStringBuilder[index] as string;
        connectionStringBuilder[index] = (object) null;
        using (IDbConnection cnn = SqlConnections.New(connectionStringBuilder.ConnectionString, connectionString.ProviderName))
        {
          try
          {
            cnn.Open();
          }
          catch (SqlException ex)
          {
            if (ex.ErrorCode != -2146232060)
            {
              throw;
            }
            else
            {
              if (connectionStringBuilder.ConnectionString.IndexOf("\\v11.0") >= 0)
                throw new Exception("You don't seem to have SQL Express LocalDB 2012 installed.\r\n\r\nIf you have Visual Studio 2015 (with SQL LocalDB 2014) try changing '" + databaseKey + "' connection string in WEB.CONFIG to:\r\n\r\n" + connectionString.ConnectionString.Replace("\\v11.0", "\\MSSqlLocalDB") + "\r\n\r\nor:\r\n\r\n" + connectionString.ConnectionString.Replace("\\v11.0", "\\v12.0") + "';\r\n\r\nYou can also try another SQL server type like .\\SQLExpress.");
              throw;
            }
          }
          string sql1 = "SELECT * FROM sys.databases WHERE NAME = @name";
          string format = "CREATE DATABASE [{0}]";
          if (flag2)
          {
            sql1 = "select * from postgres.pg_catalog.pg_database where datname = @name";
            format = "CREATE DATABASE \"{0}\"";
          }
          else if (flag3)
          {
            sql1 = "SELECT * FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @name";
            format = "CREATE DATABASE `{0}`";
          }
          if (cnn.Query(sql1, (object) new{ name = path2 }, (IDbTransaction) null, true, new int?(), new CommandType?()).Any<object>())
            return;
          string sql2;
          if ((!flag1 || cnn.ConnectionString.IndexOf("(localdb)\\", StringComparison.OrdinalIgnoreCase) < 0 ? (cnn.ConnectionString.IndexOf(".\\") >= 0 ? 1 : 0) : 1) != 0)
          {
            string str = Path.Combine(HostingEnvironment.MapPath("~/App_Data"), path2);
            sql2 = string.Format("CREATE DATABASE [{0}] ON PRIMARY (Name = N'{0}', FILENAME = '{1}.mdf') LOG ON (NAME = N'{0}_log', FILENAME = '{1}.ldf')", (object) path2, (object) str);
            if (File.Exists(str + ".mdf"))
              sql2 += " FOR ATTACH";
          }
          else
            sql2 = string.Format(format, (object) path2);
          cnn.Execute(sql2, (object) null, (IDbTransaction) null, new int?(), new CommandType?());
          SqlConnection.ClearAllPools();
        }
      }
    }

    public static bool SkippedMigrations { get; private set; }

    private static void RunMigrations(string databaseKey)
    {
      ConnectionStringInfo connectionString1 = SqlConnections.GetConnectionString(databaseKey);
      string connectionString2 = connectionString1.ConnectionString;
      string serverType = connectionString1.Dialect.ServerType;
      bool flag = !serverType.StartsWith("SqlServer", StringComparison.OrdinalIgnoreCase) && serverType.StartsWith("Oracle", StringComparison.OrdinalIgnoreCase);
      if (!flag && connectionString1.ConnectionString.IndexOf(typeof (SiteInitialization).Namespace + "_" + databaseKey + "_v1", StringComparison.OrdinalIgnoreCase) < 0)
      {
        SiteInitialization.SkippedMigrations = true;
      }
      else
      {
        string str = flag ? "OracleManaged" : serverType;
        string connectionString3 = connectionString1.ConnectionString;
        using (StringWriter stringWriter = new StringWriter())
        {
          TextWriterAnnouncer textWriterAnnouncer;
          if (!flag)
          {
            TextWriterWithGoAnnouncer writerWithGoAnnouncer = new TextWriterWithGoAnnouncer((TextWriter) stringWriter);
            writerWithGoAnnouncer.ShowSql = true;
            textWriterAnnouncer = (TextWriterAnnouncer) writerWithGoAnnouncer;
          }
          else
          {
            textWriterAnnouncer = new TextWriterAnnouncer((TextWriter) stringWriter);
            textWriterAnnouncer.ShowSql = true;
          }
          RunnerContext runnerContext = new RunnerContext((IAnnouncer) textWriterAnnouncer)
          {
            Database = str,
            Connection = connectionString3,
            Targets = new string[1]
            {
              typeof (SiteInitialization).Assembly.Location
            },
            Task = "migrate:up",
            WorkingDirectory = Path.GetDirectoryName(typeof (SiteInitialization).Assembly.Location),
            Namespace = "CVC.Migrations." + databaseKey + "DB",
            Timeout = 90
          };
          try
          {
            new TaskExecutor((IRunnerContext) runnerContext).Execute();
          }
          catch (Exception ex)
          {
            throw new Exception("Error executing migration:\r\n" + stringWriter.ToString(), ex);
          }
        }
      }
    }

    public static void ApplicationStart()
    {
      try
      {
        SqlSettings.AutoQuotedIdentifiers = true;
        CommonInitialization.Run();
        IDependencyRegistrar dependencyRegistrar = Dependency.Resolve<IDependencyRegistrar>();
        dependencyRegistrar.RegisterInstance<IAuthorizationService>((IAuthorizationService) new AuthorizationService());
        dependencyRegistrar.RegisterInstance<IAuthenticationService>((IAuthenticationService) new AuthenticationService());
        dependencyRegistrar.RegisterInstance<IPermissionService>((IPermissionService) new LogicOperatorPermissionService((IPermissionService) new PermissionService()));
        dependencyRegistrar.RegisterInstance<IUserRetrieveService>((IUserRetrieveService) new UserRetrieveService());
        if (!ConfigurationManager.AppSettings["LDAP"].IsTrimmedEmpty())
          dependencyRegistrar.RegisterInstance<IDirectoryService>((IDirectoryService) new LdapDirectoryService());
        if (!ConfigurationManager.AppSettings["ActiveDirectory"].IsTrimmedEmpty())
          dependencyRegistrar.RegisterInstance<IDirectoryService>((IDirectoryService) new ActiveDirectoryService());
        SiteInitialization.InitializeExceptionLog();
      }
      catch (Exception ex)
      {
        ex.Log();
        throw;
      }
            foreach (string databaseKey in SiteInitialization.databaseKeys)
                SiteInitialization.EnsureDatabase(databaseKey);
        }

    public static void ApplicationEnd()
    {
    }

    private class ErrorStoreLogger : IExceptionLogger
    {
      public void Log(Exception exception)
      {
        ErrorStore.LogException(exception, HttpContext.Current, false, false, (Dictionary<string, string>) null, (string) null);
      }
    }
  }
}
