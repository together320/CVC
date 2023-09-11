// Decompiled with JetBrains decompiler
// Type: CVC.Modules.Common.BaseClass.AuditRowBehavior
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Web;
using CVC.BusinessServices.Common;
using CVC.Data.EDMX;
using System.Linq;
using CVC.Administration.Repositories;
using CVC.ViewModels;

namespace CVC.Modules.Common.BaseClass
{
    public class AuditRowBehavior : IImplicitBehavior, ISaveBehavior, IDeleteBehavior
    {
        private const string FieldSeperator = "; ";
        private string IdFieldName;

        public bool ActivateFor(Row row)
        {
            if (!(row is IAuditLog))
            {
                IExAuditLog exAuditLog = row as IExAuditLog;
                if (exAuditLog == null)
                    return false;
                this.IdFieldName = exAuditLog.IdField.PropertyName;
            }
            return true;
        }

        public void OnAfterSave(ISaveRequestHandler handler)
        {
        }

        public void OnAudit(ISaveRequestHandler handler)
        {
           
            bool IsSaveRecordToPasswordTable = true;
            var table ="";
            if (handler.Old!=null)
            {
                table = handler.Old.Table;
            }
            else
            {
                table = handler.Row.Table;
            }

           
            if (table == "Users")
            {
                if (handler.IsUpdate)
                {
                    var PasswordHash = Convert.ToString(handler.Old.GetType().GetProperty("PasswordHash").GetValue((object)handler.Old));
                    var PasswordSalt = Convert.ToString(handler.Old.GetType().GetProperty("PasswordSalt").GetValue((object)handler.Old));
                    var Password = (Convert.ToString(handler.Row.GetType().GetProperty("Password").GetValue((object)handler.Row)));

                    if (string.IsNullOrEmpty(Password))
                    {
                        IsSaveRecordToPasswordTable = false;

                    }
                    else
                    {
                        //var NewPasswordHash = UserRepository.CalculateHash(Password, PasswordSalt);
                        //if (NewPasswordHash == PasswordHash)
                        //{
                        //    IsSaveRecordToPasswordTable = true;
                        //}

                    }
                }
                if (IsSaveRecordToPasswordTable)
                {
                    var PasswordHash = Convert.ToString(handler.Row.GetType().GetProperty("PasswordHash").GetValue((object)handler.Row));
                    var PasswordSalt = Convert.ToString(handler.Row.GetType().GetProperty("PasswordSalt").GetValue((object)handler.Row));

                    //CVC.BusinessServices.Common.CommonServices objCommonServices = new CVC.BusinessServices.Common.CommonServices();
                    using (CVC.BusinessServices.Common.CommonServices objCommonServices = new CVC.BusinessServices.Common.CommonServices())
                    {
                        PasswordViewModel objPasswordViewModel = new PasswordViewModel
                        {
                            UserId = Convert.ToInt32(handler.Row.GetType().GetProperty("UserId").GetValue((object)handler.Row)),
                            PasswordHash = PasswordHash,
                            PasswordSalt = PasswordSalt,
                            CreatedOn = DateTime.Now

                        };
                        bool Response = objCommonServices.CreatePassword(objPasswordViewModel);
                    }
                }
            }

            string AuditLog = "";
                if (handler.IsCreate)
                {
                    AuditActionType AuditAction = AuditActionType.Insert;
                    this.ExecuteInsertAuditLogProc(handler.Connection, AuditAction, handler.Row, AuditLog);
                }
                if (!handler.IsUpdate)
                    return;
                AuditActionType AuditAction1 = AuditActionType.Update;
                this.ExecuteUpdateAuditLogProc(handler.Connection, AuditAction1, handler.Row, AuditLog, handler.Old);
           

        }

        public void OnBeforeSave(ISaveRequestHandler handler)
        {
        }

        public void OnPrepareQuery(ISaveRequestHandler handler, SqlQuery query)
        {
        }

        public void OnReturn(ISaveRequestHandler handler)
        {
        }

        public void OnSetInternalFields(ISaveRequestHandler handler)
        {
        }

        public void OnValidateRequest(ISaveRequestHandler handler)
        {
        }

        public void OnAfterDelete(IDeleteRequestHandler handler)
        {
        }

        public void OnAudit(IDeleteRequestHandler handler)
        {
            string insertAuditLog = this.GetInsertAuditLog(handler.Row);
            this.ExecuteAuditLogProc(handler.Connection, AuditActionType.Delete, handler.Row, insertAuditLog);
        }

        public void OnBeforeDelete(IDeleteRequestHandler handler)
        {
        }

        public void OnPrepareQuery(IDeleteRequestHandler handler, SqlQuery query)
        {
        }

        public void OnReturn(IDeleteRequestHandler handler)
        {
        }

        public void OnValidateRequest(IDeleteRequestHandler handler)
        {
        }

        private string GetUpdateAuditLog(Row CurrentRow, Row OldRow)
        {
            List<UpdateField> updateFieldList1 = new List<UpdateField>();
            foreach (Field tableField in CurrentRow.GetTableFields())
            {
                PropertyInfo property = CurrentRow.GetType().GetProperty(tableField.ColumnAlias);
                if (property.GetCustomAttribute(typeof(IgnoreAuditLog)) == null)
                {
                    if (property.GetCustomAttribute(typeof(IdentityAttribute)) != null)
                        this.IdFieldName = property.Name;
                    if (property.PropertyType == typeof(DateTime?))
                    {
                        DateTime? dateTime1 = (DateTime?)property.GetValue((object)CurrentRow);
                        DateTime? dateTime2 = (DateTime?)property.GetValue((object)OldRow);
                        if (dateTime2.HasValue || dateTime1.HasValue)
                        {
                            DateTime? nullable1 = dateTime2;
                            DateTime? nullable2 = dateTime1;
                            if ((nullable1.HasValue == nullable2.HasValue ? (nullable1.HasValue ? (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ? 1 : 0) : 0) : 1) != 0)
                                updateFieldList1.Add(new UpdateField()
                                {
                                    F = property.Name,
                                    V = dateTime1.HasValue ? dateTime1.ToIndianDateFormat() : "<empty>",
                                    O = dateTime2.HasValue ? dateTime2.ToIndianDateFormat() : "<empty>"
                                });
                        }
                    }
                    else if (property.PropertyType == typeof(Decimal?))
                    {
                        Decimal? nullable1 = (Decimal?)property.GetValue((object)CurrentRow);
                        Decimal? nullable2 = (Decimal?)property.GetValue((object)OldRow);
                        if ((nullable1.HasValue || nullable2.HasValue) && Convert.ToDecimal((object)nullable1) - Convert.ToDecimal((object)nullable2) != Decimal.Zero)
                        {
                            List<UpdateField> updateFieldList2 = updateFieldList1;
                            /* UpdateField updateField = new UpdateField();
                             updateField.F = property.Name;*/
                            UpdateField updateField = new UpdateField
                            {
                                F = property.Name
                            };
                            Decimal num;
                            string str1;
                            if (!nullable2.HasValue)
                            {
                                str1 = "<empty>";
                            }
                            else
                            {
                                num = nullable2.Value;
                                str1 = num.ToString();
                            }
                            updateField.O = str1;
                            string str2;
                            if (!nullable1.HasValue)
                            {
                                str2 = "<empty>";
                            }
                            else
                            {
                                num = nullable1.Value;
                                str2 = num.ToString();
                            }
                            updateField.V = str2;
                            updateFieldList2.Add(updateField);
                        }
                    }
                    else
                    {
                        string str1 = Convert.ToString(property.GetValue((object)CurrentRow));
                        string str2 = Convert.ToString(property.GetValue((object)OldRow));
                        if (str1 != str2)
                            updateFieldList1.Add(new UpdateField()
                            {
                                F = property.Name,
                                O = str2.IsNullOrEmpty() ? "<empty>" : str2,
                                V = str1.IsNullOrEmpty() ? "<empty>" : str1
                            });
                    }
                }
            }
            return updateFieldList1.ToJson();
        }

        private string GetInsertAuditLog(Row CurrentRow)
        {
            List<InsertField> insertFieldList = new List<InsertField>();
            foreach (Field tableField in CurrentRow.GetTableFields())
            {
                PropertyInfo property = CurrentRow.GetType().GetProperty(tableField.ColumnAlias);
                if (property.GetCustomAttribute(typeof(IgnoreAuditLog)) == null)
                {
                    if (property.GetCustomAttribute(typeof(IdentityAttribute)) != null)
                        this.IdFieldName = property.Name;
                    if (property.PropertyType == typeof(DateTime?))
                    {
                        DateTime? dateTime = (DateTime?)property.GetValue((object)CurrentRow);
                        if (dateTime.HasValue)
                            insertFieldList.Add(new InsertField()
                            {
                                F = property.Name,
                                V = dateTime.ToIndianDateFormat()
                            });
                    }
                    else
                    {
                        string str = Convert.ToString(property.GetValue((object)CurrentRow));
                        if (!str.IsNullOrEmpty())
                            insertFieldList.Add(new InsertField()
                            {
                                F = property.Name,
                                V = str
                            });
                    }
                }
            }
            return insertFieldList.ToJson();
        }

        public string GetIPAddress(HttpRequest Request)
        {
            if (Request.Headers["CF-CONNECTING-IP"] != null)
                return Request.Headers["CF-CONNECTING-IP"].ToString();
            if (Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
            {
                string serverVariable = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (!string.IsNullOrEmpty(serverVariable))
                {
                    string[] strArray = serverVariable.Split(',');
                    if (strArray.Length != 0)
                        return strArray[0];
                }
            }
            return Request.UserHostAddress;
        }

        public void ExecuteInsertAuditLogProc(IDbConnection Connection, AuditActionType AuditAction, Row CurrentRow, string AuditLog)
        {
            List<InsertField> insertFieldList = new List<InsertField>();
            foreach (Field tableField in CurrentRow.GetTableFields())
            {
                
                   PropertyInfo property = CurrentRow.GetType().GetProperty(tableField.ColumnAlias);
                if (property.GetCustomAttribute(typeof(IgnoreAuditLog)) == null)
                {
                   
                    if (property.GetCustomAttribute(typeof(IdentityAttribute)) != null)
                        this.IdFieldName = property.Name;
                    using (IDbCommand command = Connection.CreateCommand())
                    {
                        IDbDataParameter parameter1 = command.CreateParameter();
                        parameter1.ParameterName = "_UserId";
                        parameter1.Value = (object)((UserDefinition)Authorization.UserDefinition).UserId;
                        command.Parameters.Add((object)parameter1);
                        IDbDataParameter parameter2 = command.CreateParameter();
                        parameter2.ParameterName = "_UserName";
                        parameter2.Value = (object)((UserDefinition)Authorization.UserDefinition).Username;
                        command.Parameters.Add((object)parameter2);
                        IDbDataParameter parameter3 = command.CreateParameter();
                        parameter3.ParameterName = "_Action";
                        parameter3.Value = (object)AuditAction.GetEnumText();
                        command.Parameters.Add((object)parameter3);
                        IDbDataParameter parameter4 = command.CreateParameter();
                        parameter4.ParameterName = "_TableName";
                        parameter4.Value = (object)CurrentRow.Table;
                        command.Parameters.Add((object)parameter4);
                        IDbDataParameter parameter5 = command.CreateParameter();
                        parameter5.ParameterName = "_RowId";
                        parameter5.Value = (object)Convert.ToString(CurrentRow.GetType().GetProperty(this.IdFieldName == null ? "Id" : this.IdFieldName).GetValue((object)CurrentRow));
                        command.Parameters.Add((object)parameter5);
                        IDbDataParameter parameter6 = command.CreateParameter();
                        parameter6.ParameterName = "_Module";
                        parameter6.Value = (object)CurrentRow.GetType().Name.Replace("Row", "");
                        command.Parameters.Add((object)parameter6);
                        IDbDataParameter parameter7 = command.CreateParameter();
                        parameter7.ParameterName = "_Page";
                        parameter7.Value = (object)this.GetPageUrl();
                        command.Parameters.Add((object)parameter7);
                        IDbDataParameter parameter8 = command.CreateParameter();
                        parameter8.ParameterName = "_FieldName";
                        parameter8.Value = (object)property.Name;
                        command.Parameters.Add((object)parameter8);
                        string str1 = "";
                        if (property.PropertyType == typeof(DateTime?))
                        {
                            DateTime? dateTime = (DateTime?)property.GetValue((object)CurrentRow);
                            if (dateTime.HasValue)
                                str1 = dateTime.ToIndianDateFormat();
                        }
                        else
                        {
                            string str2 = Convert.ToString(property.GetValue((object)CurrentRow));
                            if (!str2.IsNullOrEmpty())
                                str1 = str2;
                        }
                        IDbDataParameter parameter9 = command.CreateParameter();
                        parameter9.ParameterName = "_OldValue";
                        parameter9.Value = (object)"";
                        command.Parameters.Add((object)parameter9);
                        IDbDataParameter parameter10 = command.CreateParameter();
                        parameter10.ParameterName = "_NewValue";
                        if (property.Name == "RoleId")
                        {
                            var table = CurrentRow.Table;
                            if (table.ToUpper() == "USERS")
                                if (!string.IsNullOrEmpty(str1))
                            {
                                using (CVCEntities ObjCVCEntities = new CVCEntities())
                                {
                                    int RoleId = Convert.ToInt32(str1);
                                    str1 = ObjCVCEntities.Roles.FirstOrDefault(r => r.RoleId == RoleId).RoleName;
                                }

                            }
                        }

                        parameter10.Value = (object)str1;
                        command.Parameters.Add((object)parameter10);
                        IDbDataParameter parameter11 = command.CreateParameter();
                        parameter11.ParameterName = "_Comments";
                        parameter11.Value = (object)"";
                        command.Parameters.Add((object)parameter11);
                        IDbDataParameter parameter12 = command.CreateParameter();
                        parameter12.ParameterName = "_PCIPAddress";
                        parameter12.Value = (object)"";
                        command.Parameters.Add((object)parameter12);
                        IDbDataParameter parameter13 = command.CreateParameter();
                        parameter13.ParameterName = "_BatchId";
                        parameter13.Value = (object)0;
                        command.Parameters.Add((object)parameter13);
                        IDbDataParameter parameter14 = command.CreateParameter();
                        parameter14.ParameterName = "_BatchName";
                        parameter14.Value = (object)"";
                        command.Parameters.Add((object)parameter14);
                        IDbDataParameter parameter15 = command.CreateParameter();
                        parameter15.ParameterName = "_MachineId";
                        parameter15.Value = (object)0;
                        command.Parameters.Add((object)parameter15);
                        IDbDataParameter parameter16 = command.CreateParameter();
                        parameter16.ParameterName = "_MachineName";
                        parameter16.Value = (object)"";
                        command.Parameters.Add((object)parameter16);
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "Common_AuditLog";
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public void ExecuteUpdateAuditLogProc(IDbConnection Connection, AuditActionType AuditAction, Row CurrentRow, string AuditLog, Row OldRow)
        {
            List<InsertField> insertFieldList = new List<InsertField>();
            foreach (Field tableField in CurrentRow.GetTableFields())
            {
                PropertyInfo property = CurrentRow.GetType().GetProperty(tableField.ColumnAlias);
                if (property.GetCustomAttribute(typeof(IgnoreAuditLog)) == null)
                {
                    if (property.GetCustomAttribute(typeof(IdentityAttribute)) != null)
                        this.IdFieldName = property.Name;
                    using (IDbCommand command = Connection.CreateCommand())
                    {
                        IDbDataParameter parameter1 = command.CreateParameter();
                        parameter1.ParameterName = "_UserId";
                        parameter1.Value = (object)((UserDefinition)Authorization.UserDefinition).UserId;
                        command.Parameters.Add((object)parameter1);
                        IDbDataParameter parameter2 = command.CreateParameter();
                        parameter2.ParameterName = "_UserName";
                        parameter2.Value = (object)((UserDefinition)Authorization.UserDefinition).Username;
                        command.Parameters.Add((object)parameter2);
                        IDbDataParameter parameter3 = command.CreateParameter();
                        parameter3.ParameterName = "_Action";
                        parameter3.Value = (object)AuditAction.GetEnumText();
                        command.Parameters.Add((object)parameter3);
                        IDbDataParameter parameter4 = command.CreateParameter();
                        parameter4.ParameterName = "_TableName";
                        parameter4.Value = (object)CurrentRow.Table;
                        command.Parameters.Add((object)parameter4);
                        IDbDataParameter parameter5 = command.CreateParameter();
                        parameter5.ParameterName = "_RowId";
                        parameter5.Value = (object)Convert.ToString(CurrentRow.GetType().GetProperty(this.IdFieldName == null ? "Id" : this.IdFieldName).GetValue((object)CurrentRow));
                        command.Parameters.Add((object)parameter5);
                        IDbDataParameter parameter6 = command.CreateParameter();
                        parameter6.ParameterName = "_Module";
                        parameter6.Value = (object)CurrentRow.GetType().Name.Replace("Row", "");
                        command.Parameters.Add((object)parameter6);
                        IDbDataParameter parameter7 = command.CreateParameter();
                        parameter7.ParameterName = "_Page";
                        parameter7.Value = (object)this.GetPageUrl();
                        command.Parameters.Add((object)parameter7);
                        IDbDataParameter parameter8 = command.CreateParameter();
                        parameter8.ParameterName = "_FieldName";
                        parameter8.Value = (object)property.Name;
                        command.Parameters.Add((object)parameter8);
                        string str1 = "";
                        string str2 = "";
                        if (property.PropertyType == typeof(DateTime?))
                        {
                            DateTime? dateTime1 = (DateTime?)property.GetValue((object)CurrentRow);
                            DateTime? dateTime2 = (DateTime?)property.GetValue((object)OldRow);
                            if (dateTime2.HasValue || dateTime1.HasValue)
                            {
                                DateTime? nullable1 = dateTime2;
                                DateTime? nullable2 = dateTime1;
                                if ((nullable1.HasValue == nullable2.HasValue ? (nullable1.HasValue ? (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ? 1 : 0) : 0) : 1) != 0)
                                {
                                    str1 = dateTime1.HasValue ? dateTime1.ToIndianDateFormat() : "<empty>";
                                    str2 = dateTime2.HasValue ? dateTime2.ToIndianDateFormat() : "<empty>";
                                }
                            }
                        }
                        else if (property.PropertyType == typeof(Decimal?))
                        {
                            Decimal? nullable1 = (Decimal?)property.GetValue((object)CurrentRow);
                            Decimal? nullable2 = (Decimal?)property.GetValue((object)OldRow);
                            if ((nullable1.HasValue || nullable2.HasValue) && Convert.ToDecimal((object)nullable1) - Convert.ToDecimal((object)nullable2) != Decimal.Zero)
                            {
                                str2 = nullable2.HasValue ? nullable2.Value.ToString() : "<empty>";
                                str1 = nullable1.HasValue ? nullable1.Value.ToString() : "<empty>";
                            }
                        }
                        else
                        {
                            string str3 = Convert.ToString(property.GetValue((object)CurrentRow));
                            string str4 = Convert.ToString(property.GetValue((object)OldRow));
                            if (str3 != str4)
                            {
                                str2 = str4.IsNullOrEmpty() ? "<empty>" : str4;
                                str1 = str3.IsNullOrEmpty() ? "<empty>" : str3;
                            }
                        }
                        if (str1 == "" && str2 == "")
                            continue;

                        IDbDataParameter parameter9 = command.CreateParameter();
                        parameter9.ParameterName = "_OldValue";
                        if(!string.IsNullOrEmpty(str2))
                        {
                            if (property.Name =="RoleId")
                            {
                                using (CVCEntities ObjCVCEntities = new CVCEntities())
                                {
                                    int RoleId = Convert.ToInt32(str2);
                                    str2 = ObjCVCEntities.Roles.FirstOrDefault(r => r.RoleId == RoleId).RoleName;
                                }
                            }
                           
                        }
                       
                        parameter9.Value = (object)str2;
                        command.Parameters.Add((object)parameter9);
                        IDbDataParameter parameter10 = command.CreateParameter();
                        parameter10.ParameterName = "_NewValue";
                        if (!string.IsNullOrEmpty(str1))
                        {
                            if (property.Name =="RoleId")
                            {
                                using (CVCEntities ObjCVCEntities = new CVCEntities())
                                {
                                    int RoleId = Convert.ToInt32(str1);
                                    str1 = ObjCVCEntities.Roles.FirstOrDefault(r => r.RoleId == RoleId).RoleName;
                                }
                            }

                        }
                        parameter10.Value = (object)str1;
                        command.Parameters.Add((object)parameter10);
                        IDbDataParameter parameter11 = command.CreateParameter();
                        parameter11.ParameterName = "_Comments";
                        parameter11.Value = (object)"";
                        command.Parameters.Add((object)parameter11);
                        IDbDataParameter parameter12 = command.CreateParameter();
                        parameter12.ParameterName = "_PCIPAddress";
                        parameter12.Value = (object)this.GetIPAddress(HttpContext.Current.Request);
                        command.Parameters.Add((object)parameter12);
                        IDbDataParameter parameter13 = command.CreateParameter();
                        parameter13.ParameterName = "_BatchId";
                        parameter13.Value = (object)0;
                        command.Parameters.Add((object)parameter13);
                        IDbDataParameter parameter14 = command.CreateParameter();
                        parameter14.ParameterName = "_BatchName";
                        parameter14.Value = (object)"";
                        command.Parameters.Add((object)parameter14);
                        IDbDataParameter parameter15 = command.CreateParameter();
                        parameter15.ParameterName = "_MachineId";
                        parameter15.Value = (object)0;
                        command.Parameters.Add((object)parameter15);
                        IDbDataParameter parameter16 = command.CreateParameter();
                        parameter16.ParameterName = "_MachineName";
                        parameter16.Value = (object)"";
                        command.Parameters.Add((object)parameter16);
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "Common_AuditLog";
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public void ExecuteAuditLogProc(IDbConnection Connection, AuditActionType AuditAction, Row CurrentRow, string AuditLog)
        {
            using (IDbCommand command = Connection.CreateCommand())
            {
                IDbDataParameter parameter1 = command.CreateParameter();
                parameter1.ParameterName = "_UserId";
                parameter1.Value = (object)((UserDefinition)Authorization.UserDefinition).UserId;
                command.Parameters.Add((object)parameter1);
                IDbDataParameter parameter2 = command.CreateParameter();
                parameter2.ParameterName = "_UserName";
                parameter2.Value = (object)((UserDefinition)Authorization.UserDefinition).Username;
                command.Parameters.Add((object)parameter2);
                IDbDataParameter parameter3 = command.CreateParameter();
                parameter3.ParameterName = "_Action";
                parameter3.Value = (object)AuditAction.GetEnumText();
                command.Parameters.Add((object)parameter3);
                IDbDataParameter parameter4 = command.CreateParameter();
                parameter4.ParameterName = "_TableName";
                parameter4.Value = (object)CurrentRow.Table;
                command.Parameters.Add((object)parameter4);
                IDbDataParameter parameter5 = command.CreateParameter();
                parameter5.ParameterName = "_RowId";
                parameter5.Value = (object)Convert.ToString(CurrentRow.GetType().GetProperty(this.IdFieldName == null ? "Id" : this.IdFieldName).GetValue((object)CurrentRow));
                command.Parameters.Add((object)parameter5);
                IDbDataParameter parameter6 = command.CreateParameter();
                parameter6.ParameterName = "_Module";
                parameter6.Value = (object)CurrentRow.GetType().Name.Replace("Row", "");
                command.Parameters.Add((object)parameter6);
                IDbDataParameter parameter7 = command.CreateParameter();
                parameter7.ParameterName = "_Page";
                parameter7.Value = (object)this.GetPageUrl();
                command.Parameters.Add((object)parameter7);
                IDbDataParameter parameter8 = command.CreateParameter();
                parameter8.ParameterName = "_Comments";
                parameter8.Value = (object)AuditLog;
                command.Parameters.Add((object)parameter8);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "Common_AuditLog";
                command.ExecuteNonQuery();
            }
        }

        private string GetPageUrl()
        {
            string str = "";
            if (HttpContext.Current != null && HttpContext.Current.Request != null)
            {
                HttpRequest request = HttpContext.Current.Request;
                if (request.UrlReferrer != (Uri)null)
                    str = request.UrlReferrer.PathAndQuery;
                else if (request.Url != (Uri)null)
                    str = request.Url.PathAndQuery;
            }
            return str;
        }
    }
}
