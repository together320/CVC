// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Entities.BatchRecipeModifyRow
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
  [TableName("BatchRecipeModify")]
  [DisplayName("Batch Recipe Modify")]
  [InstanceName("Batch Recipe Modify")]
  [TwoLevelCached(new string[] {})]
    //  [ReadPermission("Administration:General")]
    //  [ModifyPermission("Administration:General")]
    [ReadPermission("")]
    [ModifyPermission("")]

    public sealed class BatchRecipeModifyRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
    public static readonly BatchRecipeModifyRow.RowFields Fields = new BatchRecipeModifyRow.RowFields().Init<BatchRecipeModifyRow.RowFields>();

    [DisplayName("Batch Recipe Modify Id")]
    [NotNull]
    public int? BatchRecipeModifyId
    {
      get
      {
        return BatchRecipeModifyRow.Fields.BatchRecipeModifyId[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.BatchRecipeModifyId[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine")]
    [ForeignKey("BatchMachineWise", "BatchMachineId")]
    [LeftJoin("jBatchMachine")]
    public int? BatchMachineId
    {
      get
      {
        return BatchRecipeModifyRow.Fields.BatchMachineId[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.BatchMachineId[(Row) this] = value;
      }
    }

    [DisplayName("Recipe Settings Parameter")]
    [ForeignKey("RecipeSettingsParameter", "RecipeParameterId")]
    [LeftJoin("jRecipeSettingsParameter")]
    public int? RecipeSettingsParameterId
    {
      get
      {
        return BatchRecipeModifyRow.Fields.RecipeSettingsParameterId[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.RecipeSettingsParameterId[(Row) this] = value;
      }
    }

    [DisplayName("Old Value")]
    [Size(50)]
    [QuickSearch(SearchType.Auto, -1, false)]
    public string OldValue
    {
      get
      {
        return BatchRecipeModifyRow.Fields.OldValue[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.OldValue[(Row) this] = value;
      }
    }

    [DisplayName("New Value")]
    [Size(50)]
    public string NewValue
    {
      get
      {
        return BatchRecipeModifyRow.Fields.NewValue[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.NewValue[(Row) this] = value;
      }
    }

    [DisplayName("Updated By")]
    [ForeignKey("Users", "UserId")]
    [LeftJoin("jUpdatedBy")]
    [TextualField("UpdatedByEmployeeId")]
    public int? UpdatedBy
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedBy[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedBy[(Row) this] = value;
      }
    }

    [DisplayName("Updated Date")]
    public DateTime? UpdatedDate
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedDate[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedDate[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Machine Id")]
    [Expression("jBatchMachine.[MachineId]")]
    public int? BatchMachineMachineId
    {
      get
      {
        return BatchRecipeModifyRow.Fields.BatchMachineMachineId[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.BatchMachineMachineId[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Batch Id")]
    [Expression("jBatchMachine.[BatchId]")]
    public int? BatchMachineBatchId
    {
      get
      {
        return BatchRecipeModifyRow.Fields.BatchMachineBatchId[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.BatchMachineBatchId[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Recipe Id")]
    [Expression("jBatchMachine.[RecipeId]")]
    public int? BatchMachineRecipeId
    {
      get
      {
        return BatchRecipeModifyRow.Fields.BatchMachineRecipeId[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.BatchMachineRecipeId[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Is Machine In Use")]
    [Expression("jBatchMachine.[IsMachineInUse]")]
    public short? BatchMachineIsMachineInUse
    {
      get
      {
        return BatchRecipeModifyRow.Fields.BatchMachineIsMachineInUse[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.BatchMachineIsMachineInUse[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Status Id")]
    [Expression("jBatchMachine.[StatusId]")]
    public int? BatchMachineStatusId
    {
      get
      {
        return BatchRecipeModifyRow.Fields.BatchMachineStatusId[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.BatchMachineStatusId[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Created By")]
    [Expression("jBatchMachine.[CreatedBy]")]
    public int? BatchMachineCreatedBy
    {
      get
      {
        return BatchRecipeModifyRow.Fields.BatchMachineCreatedBy[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.BatchMachineCreatedBy[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Created Date")]
    [Expression("jBatchMachine.[CreatedDate]")]
    public DateTime? BatchMachineCreatedDate
    {
      get
      {
        return BatchRecipeModifyRow.Fields.BatchMachineCreatedDate[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.BatchMachineCreatedDate[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Updated By")]
    [Expression("jBatchMachine.[UpdatedBy]")]
    public int? BatchMachineUpdatedBy
    {
      get
      {
        return BatchRecipeModifyRow.Fields.BatchMachineUpdatedBy[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.BatchMachineUpdatedBy[(Row) this] = value;
      }
    }

    [DisplayName("Batch Machine Updated Date")]
    [Expression("jBatchMachine.[UpdatedDate]")]
    public DateTime? BatchMachineUpdatedDate
    {
      get
      {
        return BatchRecipeModifyRow.Fields.BatchMachineUpdatedDate[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.BatchMachineUpdatedDate[(Row) this] = value;
      }
    }

    [DisplayName("Recipe Settings Parameter Recipe Settings Id")]
    [Expression("jRecipeSettingsParameter.[RecipeSettingsId]")]
    public int? RecipeSettingsParameterRecipeSettingsId
    {
      get
      {
        return BatchRecipeModifyRow.Fields.RecipeSettingsParameterRecipeSettingsId[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.RecipeSettingsParameterRecipeSettingsId[(Row) this] = value;
      }
    }

    [DisplayName("Recipe Settings Parameter Ipc Parameter Id")]
    [Expression("jRecipeSettingsParameter.[IPCParameterId]")]
    public int? RecipeSettingsParameterIpcParameterId
    {
      get
      {
        return BatchRecipeModifyRow.Fields.RecipeSettingsParameterIpcParameterId[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.RecipeSettingsParameterIpcParameterId[(Row) this] = value;
      }
    }

    [DisplayName("Recipe Settings Parameter Is Fetch On Self Set")]
    [Expression("jRecipeSettingsParameter.[IsFetchOnSelfSet]")]
    public short? RecipeSettingsParameterIsFetchOnSelfSet
    {
      get
      {
        return BatchRecipeModifyRow.Fields.RecipeSettingsParameterIsFetchOnSelfSet[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.RecipeSettingsParameterIsFetchOnSelfSet[(Row) this] = value;
      }
    }

    [DisplayName("Recipe Settings Parameter Status Id")]
    [Expression("jRecipeSettingsParameter.[StatusId]")]
    public int? RecipeSettingsParameterStatusId
    {
      get
      {
        return BatchRecipeModifyRow.Fields.RecipeSettingsParameterStatusId[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.RecipeSettingsParameterStatusId[(Row) this] = value;
      }
    }

    [DisplayName("Recipe Settings Parameter Created By")]
    [Expression("jRecipeSettingsParameter.[CreatedBy]")]
    public int? RecipeSettingsParameterCreatedBy
    {
      get
      {
        return BatchRecipeModifyRow.Fields.RecipeSettingsParameterCreatedBy[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.RecipeSettingsParameterCreatedBy[(Row) this] = value;
      }
    }

    [DisplayName("Recipe Settings Parameter Created Date")]
    [Expression("jRecipeSettingsParameter.[CreatedDate]")]
    public DateTime? RecipeSettingsParameterCreatedDate
    {
      get
      {
        return BatchRecipeModifyRow.Fields.RecipeSettingsParameterCreatedDate[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.RecipeSettingsParameterCreatedDate[(Row) this] = value;
      }
    }

    [DisplayName("Recipe Settings Parameter Updated By")]
    [Expression("jRecipeSettingsParameter.[UpdatedBy]")]
    public int? RecipeSettingsParameterUpdatedBy
    {
      get
      {
        return BatchRecipeModifyRow.Fields.RecipeSettingsParameterUpdatedBy[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.RecipeSettingsParameterUpdatedBy[(Row) this] = value;
      }
    }

    [DisplayName("Recipe Settings Parameter Updated Date")]
    [Expression("jRecipeSettingsParameter.[UpdatedDate]")]
    public DateTime? RecipeSettingsParameterUpdatedDate
    {
      get
      {
        return BatchRecipeModifyRow.Fields.RecipeSettingsParameterUpdatedDate[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.RecipeSettingsParameterUpdatedDate[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Employee Id")]
    [Expression("jUpdatedBy.[EmployeeId]")]
    public string UpdatedByEmployeeId
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByEmployeeId[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByEmployeeId[(Row) this] = value;
      }
    }

    [DisplayName("Updated By First Name")]
    [Expression("jUpdatedBy.[FirstName]")]
    public string UpdatedByFirstName
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByFirstName[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByFirstName[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Last Name")]
    [Expression("jUpdatedBy.[LastName]")]
    public string UpdatedByLastName
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByLastName[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByLastName[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Department Id")]
    [Expression("jUpdatedBy.[DepartmentId]")]
    public int? UpdatedByDepartmentId
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByDepartmentId[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByDepartmentId[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Designation")]
    [Expression("jUpdatedBy.[Designation]")]
    public string UpdatedByDesignation
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByDesignation[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByDesignation[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Mobile Code")]
    [Expression("jUpdatedBy.[MobileCode]")]
    public int? UpdatedByMobileCode
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByMobileCode[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByMobileCode[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Mobile Number")]
    [Expression("jUpdatedBy.[MobileNumber]")]
    public int? UpdatedByMobileNumber
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByMobileNumber[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByMobileNumber[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Email")]
    [Expression("jUpdatedBy.[Email]")]
    public string UpdatedByEmail
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByEmail[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByEmail[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Username")]
    [Expression("jUpdatedBy.[Username]")]
    public string UpdatedByUsername
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByUsername[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByUsername[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Password Hash")]
    [Expression("jUpdatedBy.[PasswordHash]")]
    public string UpdatedByPasswordHash
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByPasswordHash[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByPasswordHash[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Password Salt")]
    [Expression("jUpdatedBy.[PasswordSalt]")]
    public string UpdatedByPasswordSalt
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByPasswordSalt[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByPasswordSalt[(Row) this] = value;
      }
    }

    [DisplayName("Updated By User Image")]
    [Expression("jUpdatedBy.[UserImage]")]
    public string UpdatedByUserImage
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByUserImage[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByUserImage[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Address")]
    [Expression("jUpdatedBy.[Address]")]
    public string UpdatedByAddress
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByAddress[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByAddress[(Row) this] = value;
      }
    }

    [DisplayName("Updated By City Id")]
    [Expression("jUpdatedBy.[CityId]")]
    public int? UpdatedByCityId
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByCityId[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByCityId[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Pin Code")]
    [Expression("jUpdatedBy.[PinCode]")]
    public string UpdatedByPinCode
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByPinCode[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByPinCode[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Role Id")]
    [Expression("jUpdatedBy.[RoleId]")]
    public int? UpdatedByRoleId
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByRoleId[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByRoleId[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Password Expiry Date")]
    [Expression("jUpdatedBy.[PasswordExpiryDate]")]
    public DateTime? UpdatedByPasswordExpiryDate
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByPasswordExpiryDate[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByPasswordExpiryDate[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Is Forgot Password")]
    [Expression("jUpdatedBy.[IsForgotPassword]")]
    public short? UpdatedByIsForgotPassword
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByIsForgotPassword[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByIsForgotPassword[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Is Password Change On Login")]
    [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
    public bool? UpdatedByIsPasswordChangeOnLogin
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Is User Hidden")]
    [Expression("jUpdatedBy.[IsUserHidden]")]
    public short? UpdatedByIsUserHidden
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByIsUserHidden[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByIsUserHidden[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Status Id")]
    [Expression("jUpdatedBy.[StatusId]")]
    public int? UpdatedByStatusId
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByStatusId[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByStatusId[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Created By")]
    [Expression("jUpdatedBy.[CreatedBy]")]
    public int? UpdatedByCreatedBy
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByCreatedBy[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByCreatedBy[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Created Date")]
    [Expression("jUpdatedBy.[CreatedDate]")]
    public DateTime? UpdatedByCreatedDate
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByCreatedDate[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByCreatedDate[(Row) this] = value;
      }
    }

    [DisplayName("Updated By")]
    [Expression("jUpdatedBy.[UpdatedBy]")]
    public int? UpdatedBy1
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedBy1[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedBy1[(Row) this] = value;
      }
    }

    [DisplayName("Updated By Updated Date")]
    [Expression("jUpdatedBy.[UpdatedDate]")]
    public DateTime? UpdatedByUpdatedDate
    {
      get
      {
        return BatchRecipeModifyRow.Fields.UpdatedByUpdatedDate[(Row) this];
      }
      set
      {
        BatchRecipeModifyRow.Fields.UpdatedByUpdatedDate[(Row) this] = value;
      }
    }

    IIdField IIdRow.IdField
    {
      get
      {
        return (IIdField) BatchRecipeModifyRow.Fields.BatchRecipeModifyId;
      }
    }

    StringField INameRow.NameField
    {
      get
      {
        return BatchRecipeModifyRow.Fields.OldValue;
      }
    }

    public BatchRecipeModifyRow()
      : base((RowFieldsBase) BatchRecipeModifyRow.Fields)
    {
    }

    public class RowFields : RowFieldsBase
    {
      public Int32Field BatchRecipeModifyId;
      public Int32Field BatchMachineId;
      public Int32Field RecipeSettingsParameterId;
      public StringField OldValue;
      public StringField NewValue;
      public Int32Field UpdatedBy;
      public DateTimeField UpdatedDate;
      public Int32Field BatchMachineMachineId;
      public Int32Field BatchMachineBatchId;
      public Int32Field BatchMachineRecipeId;
      public Int16Field BatchMachineIsMachineInUse;
      public Int32Field BatchMachineStatusId;
      public Int32Field BatchMachineCreatedBy;
      public DateTimeField BatchMachineCreatedDate;
      public Int32Field BatchMachineUpdatedBy;
      public DateTimeField BatchMachineUpdatedDate;
      public Int32Field RecipeSettingsParameterRecipeSettingsId;
      public Int32Field RecipeSettingsParameterIpcParameterId;
      public Int16Field RecipeSettingsParameterIsFetchOnSelfSet;
      public Int32Field RecipeSettingsParameterStatusId;
      public Int32Field RecipeSettingsParameterCreatedBy;
      public DateTimeField RecipeSettingsParameterCreatedDate;
      public Int32Field RecipeSettingsParameterUpdatedBy;
      public DateTimeField RecipeSettingsParameterUpdatedDate;
      public StringField UpdatedByEmployeeId;
      public StringField UpdatedByFirstName;
      public StringField UpdatedByLastName;
      public Int32Field UpdatedByDepartmentId;
      public StringField UpdatedByDesignation;
      public Int32Field UpdatedByMobileCode;
      public Int32Field UpdatedByMobileNumber;
      public StringField UpdatedByEmail;
      public StringField UpdatedByUsername;
      public StringField UpdatedByPasswordHash;
      public StringField UpdatedByPasswordSalt;
      public StringField UpdatedByUserImage;
      public StringField UpdatedByAddress;
      public Int32Field UpdatedByCityId;
      public StringField UpdatedByPinCode;
      public Int32Field UpdatedByRoleId;
      public DateTimeField UpdatedByPasswordExpiryDate;
      public Int16Field UpdatedByIsForgotPassword;
      public BooleanField UpdatedByIsPasswordChangeOnLogin;
      public Int16Field UpdatedByIsUserHidden;
      public Int32Field UpdatedByStatusId;
      public Int32Field UpdatedByCreatedBy;
      public DateTimeField UpdatedByCreatedDate;
      public Int32Field UpdatedBy1;
      public DateTimeField UpdatedByUpdatedDate;

      public RowFields()
        : base((string) null, "")
      {
        this.LocalTextPrefix = "Batch.BatchRecipeModify";
      }
    }
  }
}
