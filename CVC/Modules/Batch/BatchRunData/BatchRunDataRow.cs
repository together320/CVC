// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Entities.BatchRunDataRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.Batch.Entities
{
  [ConnectionKey("Default")]
  [TableName("BatchRunData")]
  [DisplayName("Batch Run Data")]
  [InstanceName("Batch Run Data")]
  [TwoLevelCached(new string[] {})]
    // [ReadPermission("Administration:General")]
    // [ModifyPermission("Administration:General")]
    [ReadPermission("")]
    [ModifyPermission("")]

    public sealed class BatchRunDataRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
    public static readonly BatchRunDataRow.RowFields Fields = new BatchRunDataRow.RowFields().Init<BatchRunDataRow.RowFields>();

    [DisplayName("Batch Run Data Id")]
    [Identity]
    public long? BatchRunDataId
    {
      get
      {
        return BatchRunDataRow.Fields.BatchRunDataId[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.BatchRunDataId[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Wise")]
    [ForeignKey("BatchMachineWise", "BatchMachineId")]
    [LeftJoin("jBatchMachineWise")]
    public int? BatchMachineWiseId
    {
      get
      {
        return BatchRunDataRow.Fields.BatchMachineWiseId[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.BatchMachineWiseId[(Row) this] = value;
      }
    }

    [DisplayName("Ipc Parameter")]
    [Column("IPCParameterId")]
    [ForeignKey("IPCParameter", "IPCParameterId")]
    [LeftJoin("jIpcParameter")]
    [TextualField("IpcParameterIpcParameterName")]
    public int? IpcParameterId
    {
      get
      {
        return BatchRunDataRow.Fields.IpcParameterId[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.IpcParameterId[(Row) this] = value;
      }
    }

    [DisplayName("Ipc Parameter Value")]
    [Column("IPCParameterValue")]
    [Size(50)]
    [QuickSearch(SearchType.Auto, -1, false)]
    public string IpcParameterValue
    {
      get
      {
        return BatchRunDataRow.Fields.IpcParameterValue[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.IpcParameterValue[(Row) this] = value;
      }
    }

    [DisplayName("Updated Date Time")]
    public DateTime? UpdatedDateTime
    {
      get
      {
        return BatchRunDataRow.Fields.UpdatedDateTime[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.UpdatedDateTime[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User")]
    [ForeignKey("Users", "UserId")]
    [LeftJoin("jLoggedInUser")]
    [TextualField("LoggedInUserEmployeeId")]
    public int? LoggedInUser
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUser[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUser[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Wise Machine Id")]
    [Expression("jBatchMachineWise.[MachineId]")]
    public int? BatchMachineWiseMachineId
    {
      get
      {
        return BatchRunDataRow.Fields.BatchMachineWiseMachineId[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.BatchMachineWiseMachineId[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Wise Batch Id")]
    [Expression("jBatchMachineWise.[BatchId]")]
    public int? BatchMachineWiseBatchId
    {
      get
      {
        return BatchRunDataRow.Fields.BatchMachineWiseBatchId[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.BatchMachineWiseBatchId[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Wise Recipe Id")]
    [Expression("jBatchMachineWise.[RecipeId]")]
    public int? BatchMachineWiseRecipeId
    {
      get
      {
        return BatchRunDataRow.Fields.BatchMachineWiseRecipeId[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.BatchMachineWiseRecipeId[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Wise Is Machine In Use")]
    [Expression("jBatchMachineWise.[IsMachineInUse]")]
    public short? BatchMachineWiseIsMachineInUse
    {
      get
      {
        return BatchRunDataRow.Fields.BatchMachineWiseIsMachineInUse[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.BatchMachineWiseIsMachineInUse[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Wise Status Id")]
    [Expression("jBatchMachineWise.[StatusId]")]
    public int? BatchMachineWiseStatusId
    {
      get
      {
        return BatchRunDataRow.Fields.BatchMachineWiseStatusId[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.BatchMachineWiseStatusId[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Wise Created By")]
    [Expression("jBatchMachineWise.[CreatedBy]")]
    public int? BatchMachineWiseCreatedBy
    {
      get
      {
        return BatchRunDataRow.Fields.BatchMachineWiseCreatedBy[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.BatchMachineWiseCreatedBy[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Wise Created Date")]
    [Expression("jBatchMachineWise.[CreatedDate]")]
    public DateTime? BatchMachineWiseCreatedDate
    {
      get
      {
        return BatchRunDataRow.Fields.BatchMachineWiseCreatedDate[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.BatchMachineWiseCreatedDate[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Wise Updated By")]
    [Expression("jBatchMachineWise.[UpdatedBy]")]
    public int? BatchMachineWiseUpdatedBy
    {
      get
      {
        return BatchRunDataRow.Fields.BatchMachineWiseUpdatedBy[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.BatchMachineWiseUpdatedBy[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Wise Updated Date")]
    [Expression("jBatchMachineWise.[UpdatedDate]")]
    public DateTime? BatchMachineWiseUpdatedDate
    {
      get
      {
        return BatchRunDataRow.Fields.BatchMachineWiseUpdatedDate[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.BatchMachineWiseUpdatedDate[(Row) this] = value;
      }
    }

    [DisplayName("Ipc Parameter Machine Id")]
    [Expression("jIpcParameter.[MachineId]")]
    public int? IpcParameterMachineId
    {
      get
      {
        return BatchRunDataRow.Fields.IpcParameterMachineId[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.IpcParameterMachineId[(Row) this] = value;
      }
    }

    [DisplayName("Ipc Parameter Ipc Parameter Name")]
    [Expression("jIpcParameter.[IPCParameterName]")]
    public string IpcParameterIpcParameterName
    {
      get
      {
        return BatchRunDataRow.Fields.IpcParameterIpcParameterName[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.IpcParameterIpcParameterName[(Row) this] = value;
      }
    }

    [DisplayName("Ipc Parameter Machine Parameter Id")]
    [Expression("jIpcParameter.[MachineParameterId]")]
    public int? IpcParameterMachineParameterId
    {
      get
      {
        return BatchRunDataRow.Fields.IpcParameterMachineParameterId[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.IpcParameterMachineParameterId[(Row) this] = value;
      }
    }

    [DisplayName("Ipc Parameter Ipc Address")]
    [Expression("jIpcParameter.[IPCAddress]")]
    public string IpcParameterIpcAddress
    {
      get
      {
        return BatchRunDataRow.Fields.IpcParameterIpcAddress[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.IpcParameterIpcAddress[(Row) this] = value;
      }
    }

    [DisplayName("Ipc Parameter Is Change In Runtime")]
    [Expression("jIpcParameter.[IsChangeInRuntime]")]
    public short? IpcParameterIsChangeInRuntime
    {
      get
      {
        return BatchRunDataRow.Fields.IpcParameterIsChangeInRuntime[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.IpcParameterIsChangeInRuntime[(Row) this] = value;
      }
    }

    [DisplayName("Ipc Parameter Status Id")]
    [Expression("jIpcParameter.[StatusId]")]
    public int? IpcParameterStatusId
    {
      get
      {
        return BatchRunDataRow.Fields.IpcParameterStatusId[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.IpcParameterStatusId[(Row) this] = value;
      }
    }

    [DisplayName("Ipc Parameter Created By")]
    [Expression("jIpcParameter.[CreatedBy]")]
    public int? IpcParameterCreatedBy
    {
      get
      {
        return BatchRunDataRow.Fields.IpcParameterCreatedBy[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.IpcParameterCreatedBy[(Row) this] = value;
      }
    }

    [DisplayName("Ipc Parameter Created Date")]
    [Expression("jIpcParameter.[CreatedDate]")]
    public DateTime? IpcParameterCreatedDate
    {
      get
      {
        return BatchRunDataRow.Fields.IpcParameterCreatedDate[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.IpcParameterCreatedDate[(Row) this] = value;
      }
    }

    [DisplayName("Ipc Parameter Updated By")]
    [Expression("jIpcParameter.[UpdatedBy]")]
    public int? IpcParameterUpdatedBy
    {
      get
      {
        return BatchRunDataRow.Fields.IpcParameterUpdatedBy[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.IpcParameterUpdatedBy[(Row) this] = value;
      }
    }

    [DisplayName("Ipc Parameter Updated Date")]
    [Expression("jIpcParameter.[UpdatedDate]")]
    public DateTime? IpcParameterUpdatedDate
    {
      get
      {
        return BatchRunDataRow.Fields.IpcParameterUpdatedDate[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.IpcParameterUpdatedDate[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Employee Id")]
    [Expression("jLoggedInUser.[EmployeeId]")]
    public string LoggedInUserEmployeeId
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserEmployeeId[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserEmployeeId[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User First Name")]
    [Expression("jLoggedInUser.[FirstName]")]
    public string LoggedInUserFirstName
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserFirstName[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserFirstName[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Last Name")]
    [Expression("jLoggedInUser.[LastName]")]
    public string LoggedInUserLastName
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserLastName[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserLastName[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Department Id")]
    [Expression("jLoggedInUser.[DepartmentId]")]
    public int? LoggedInUserDepartmentId
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserDepartmentId[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserDepartmentId[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Designation")]
    [Expression("jLoggedInUser.[Designation]")]
    public string LoggedInUserDesignation
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserDesignation[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserDesignation[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Mobile Code")]
    [Expression("jLoggedInUser.[MobileCode]")]
    public int? LoggedInUserMobileCode
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserMobileCode[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserMobileCode[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Mobile Number")]
    [Expression("jLoggedInUser.[MobileNumber]")]
    public int? LoggedInUserMobileNumber
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserMobileNumber[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserMobileNumber[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Email")]
    [Expression("jLoggedInUser.[Email]")]
    public string LoggedInUserEmail
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserEmail[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserEmail[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Username")]
    [Expression("jLoggedInUser.[Username]")]
    public string LoggedInUserUsername
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserUsername[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserUsername[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Password Hash")]
    [Expression("jLoggedInUser.[PasswordHash]")]
    public string LoggedInUserPasswordHash
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserPasswordHash[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserPasswordHash[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Password Salt")]
    [Expression("jLoggedInUser.[PasswordSalt]")]
    public string LoggedInUserPasswordSalt
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserPasswordSalt[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserPasswordSalt[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User User Image")]
    [Expression("jLoggedInUser.[UserImage]")]
    public Stream LoggedInUserUserImage
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserUserImage[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserUserImage[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Address")]
    [Expression("jLoggedInUser.[Address]")]
    public string LoggedInUserAddress
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserAddress[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserAddress[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User City Id")]
    [Expression("jLoggedInUser.[CityId]")]
    public int? LoggedInUserCityId
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserCityId[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserCityId[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Pin Code")]
    [Expression("jLoggedInUser.[PinCode]")]
    public string LoggedInUserPinCode
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserPinCode[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserPinCode[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Role Id")]
    [Expression("jLoggedInUser.[RoleId]")]
    public int? LoggedInUserRoleId
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserRoleId[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserRoleId[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Password Expiry Date")]
    [Expression("jLoggedInUser.[PasswordExpiryDate]")]
    public DateTime? LoggedInUserPasswordExpiryDate
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserPasswordExpiryDate[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserPasswordExpiryDate[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Is Forgot Password")]
    [Expression("jLoggedInUser.[IsForgotPassword]")]
    public short? LoggedInUserIsForgotPassword
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserIsForgotPassword[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserIsForgotPassword[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Is Password Change On Login")]
    [Expression("jLoggedInUser.[IsPasswordChangeOnLogin]")]
    public short? LoggedInUserIsPasswordChangeOnLogin
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserIsPasswordChangeOnLogin[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserIsPasswordChangeOnLogin[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Is User Hidden")]
    [Expression("jLoggedInUser.[IsUserHidden]")]
    public short? LoggedInUserIsUserHidden
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserIsUserHidden[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserIsUserHidden[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Status Id")]
    [Expression("jLoggedInUser.[StatusId]")]
    public int? LoggedInUserStatusId
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserStatusId[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserStatusId[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Created By")]
    [Expression("jLoggedInUser.[CreatedBy]")]
    public int? LoggedInUserCreatedBy
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserCreatedBy[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserCreatedBy[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Created Date")]
    [Expression("jLoggedInUser.[CreatedDate]")]
    public DateTime? LoggedInUserCreatedDate
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserCreatedDate[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserCreatedDate[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Updated By")]
    [Expression("jLoggedInUser.[UpdatedBy]")]
    public int? LoggedInUserUpdatedBy
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserUpdatedBy[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserUpdatedBy[(Row) this] = value;
      }
    }

    [DisplayName("Logged In User Updated Date")]
    [Expression("jLoggedInUser.[UpdatedDate]")]
    public DateTime? LoggedInUserUpdatedDate
    {
      get
      {
        return BatchRunDataRow.Fields.LoggedInUserUpdatedDate[(Row) this];
      }
      set
      {
        BatchRunDataRow.Fields.LoggedInUserUpdatedDate[(Row) this] = value;
      }
    }

    IIdField IIdRow.IdField
    {
      get
      {
        return (IIdField) BatchRunDataRow.Fields.BatchRunDataId;
      }
    }

    StringField INameRow.NameField
    {
      get
      {
        return BatchRunDataRow.Fields.IpcParameterValue;
      }
    }

    public BatchRunDataRow()
      : base((RowFieldsBase) BatchRunDataRow.Fields)
    {
    }

    public class RowFields : RowFieldsBase
    {
      public Int64Field BatchRunDataId;
      public Int32Field BatchMachineWiseId;
      public Int32Field IpcParameterId;
      public StringField IpcParameterValue;
      public DateTimeField UpdatedDateTime;
      public Int32Field LoggedInUser;
      public Int32Field BatchMachineWiseMachineId;
      public Int32Field BatchMachineWiseBatchId;
      public Int32Field BatchMachineWiseRecipeId;
      public Int16Field BatchMachineWiseIsMachineInUse;
      public Int32Field BatchMachineWiseStatusId;
      public Int32Field BatchMachineWiseCreatedBy;
      public DateTimeField BatchMachineWiseCreatedDate;
      public Int32Field BatchMachineWiseUpdatedBy;
      public DateTimeField BatchMachineWiseUpdatedDate;
      public Int32Field IpcParameterMachineId;
      public StringField IpcParameterIpcParameterName;
      public Int32Field IpcParameterMachineParameterId;
      public StringField IpcParameterIpcAddress;
      public Int16Field IpcParameterIsChangeInRuntime;
      public Int32Field IpcParameterStatusId;
      public Int32Field IpcParameterCreatedBy;
      public DateTimeField IpcParameterCreatedDate;
      public Int32Field IpcParameterUpdatedBy;
      public DateTimeField IpcParameterUpdatedDate;
      public StringField LoggedInUserEmployeeId;
      public StringField LoggedInUserFirstName;
      public StringField LoggedInUserLastName;
      public Int32Field LoggedInUserDepartmentId;
      public StringField LoggedInUserDesignation;
      public Int32Field LoggedInUserMobileCode;
      public Int32Field LoggedInUserMobileNumber;
      public StringField LoggedInUserEmail;
      public StringField LoggedInUserUsername;
      public StringField LoggedInUserPasswordHash;
      public StringField LoggedInUserPasswordSalt;
      public StreamField LoggedInUserUserImage;
      public StringField LoggedInUserAddress;
      public Int32Field LoggedInUserCityId;
      public StringField LoggedInUserPinCode;
      public Int32Field LoggedInUserRoleId;
      public DateTimeField LoggedInUserPasswordExpiryDate;
      public Int16Field LoggedInUserIsForgotPassword;
      public Int16Field LoggedInUserIsPasswordChangeOnLogin;
      public Int16Field LoggedInUserIsUserHidden;
      public Int32Field LoggedInUserStatusId;
      public Int32Field LoggedInUserCreatedBy;
      public DateTimeField LoggedInUserCreatedDate;
      public Int32Field LoggedInUserUpdatedBy;
      public DateTimeField LoggedInUserUpdatedDate;

      public RowFields()
        : base((string) null, "")
      {
        this.LocalTextPrefix = "Batch.BatchRunData";
      }
    }
  }
}
