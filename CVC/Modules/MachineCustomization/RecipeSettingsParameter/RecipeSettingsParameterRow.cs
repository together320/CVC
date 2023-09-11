// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.RecipeSettingsParameterRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.MachineCustomization.Entities
{
    [ConnectionKey("Default")]
    [TableName("RecipeSettingsParameter")]
    [DisplayName("Recipe Settings Parameter")]
    [InstanceName("Recipe Settings Parameter")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class RecipeSettingsParameterRow : Row, IIdRow, IEntity, IAuditLog
    {
        public static readonly RecipeSettingsParameterRow.RowFields Fields = new RecipeSettingsParameterRow.RowFields().Init<RecipeSettingsParameterRow.RowFields>();

        [DisplayName("Recipe Parameter Id")]
        [Identity]
        public int? RecipeParameterId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.RecipeParameterId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.RecipeParameterId[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings")]
        [ForeignKey("RecipeSettings", "RecipeSettingsId")]
        [LeftJoin("jRecipeSettings")]
        [TextualField("RecipeSettingsRecipeSettingsName")]
        public int? RecipeSettingsId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.RecipeSettingsId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.RecipeSettingsId[(Row)this] = value;
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
                return RecipeSettingsParameterRow.Fields.IpcParameterId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.IpcParameterId[(Row)this] = value;
            }
        }

        [DisplayName("Is Fetch On Self Set")]
        public short? IsFetchOnSelfSet
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.IsFetchOnSelfSet[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.IsFetchOnSelfSet[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [ForeignKey("Status", "StatusId")]
        [LeftJoin("jStatus")]
        [TextualField("StatusStatusName")]
        //To make status as default "Active"
        [DefaultValue(1)]
        public int? StatusId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.StatusId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [ForeignKey("Users", "UserId")]
        [LeftJoin("jCreatedBy")]
        [TextualField("CreatedByEmployeeId")]
        public int? CreatedBy
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedDate[(Row)this] = value;
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
                return RecipeSettingsParameterRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings Recipe Settings Name")]
        [Expression("jRecipeSettings.[RecipeSettingsName]")]
        public string RecipeSettingsRecipeSettingsName
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.RecipeSettingsRecipeSettingsName[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.RecipeSettingsRecipeSettingsName[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings Machine Id")]
        [Expression("jRecipeSettings.[MachineId]")]
        public int? RecipeSettingsMachineId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.RecipeSettingsMachineId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.RecipeSettingsMachineId[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings Status Id")]
        [Expression("jRecipeSettings.[StatusId]")]
        public int? RecipeSettingsStatusId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.RecipeSettingsStatusId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.RecipeSettingsStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings Created By")]
        [Expression("jRecipeSettings.[CreatedBy]")]
        public int? RecipeSettingsCreatedBy
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.RecipeSettingsCreatedBy[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.RecipeSettingsCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings Created Date")]
        [Expression("jRecipeSettings.[CreatedDate]")]
        public DateTime? RecipeSettingsCreatedDate
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.RecipeSettingsCreatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.RecipeSettingsCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings Updated By")]
        [Expression("jRecipeSettings.[UpdatedBy]")]
        public int? RecipeSettingsUpdatedBy
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.RecipeSettingsUpdatedBy[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.RecipeSettingsUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings Updated Date")]
        [Expression("jRecipeSettings.[UpdatedDate]")]
        public DateTime? RecipeSettingsUpdatedDate
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.RecipeSettingsUpdatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.RecipeSettingsUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Ipc Parameter Machine Id")]
        [Expression("jIpcParameter.[MachineId]")]
        public int? IpcParameterMachineId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.IpcParameterMachineId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.IpcParameterMachineId[(Row)this] = value;
            }
        }

        [DisplayName("Ipc Parameter Ipc Parameter Name")]
        [Expression("jIpcParameter.[IPCParameterName]")]
        public string IpcParameterIpcParameterName
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.IpcParameterIpcParameterName[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.IpcParameterIpcParameterName[(Row)this] = value;
            }
        }

        [DisplayName("Ipc Parameter Machine Parameter Id")]
        [Expression("jIpcParameter.[MachineParameterId]")]
        public int? IpcParameterMachineParameterId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.IpcParameterMachineParameterId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.IpcParameterMachineParameterId[(Row)this] = value;
            }
        }

        [DisplayName("Ipc Parameter Ipc Address")]
        [Expression("jIpcParameter.[IPCAddress]")]
        public string IpcParameterIpcAddress
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.IpcParameterIpcAddress[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.IpcParameterIpcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Ipc Parameter Is Change In Runtime")]
        [Expression("jIpcParameter.[IsChangeInRuntime]")]
        public short? IpcParameterIsChangeInRuntime
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.IpcParameterIsChangeInRuntime[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.IpcParameterIsChangeInRuntime[(Row)this] = value;
            }
        }

        [DisplayName("Ipc Parameter Status Id")]
        [Expression("jIpcParameter.[StatusId]")]
        public int? IpcParameterStatusId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.IpcParameterStatusId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.IpcParameterStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Ipc Parameter Created By")]
        [Expression("jIpcParameter.[CreatedBy]")]
        public int? IpcParameterCreatedBy
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.IpcParameterCreatedBy[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.IpcParameterCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Ipc Parameter Created Date")]
        [Expression("jIpcParameter.[CreatedDate]")]
        public DateTime? IpcParameterCreatedDate
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.IpcParameterCreatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.IpcParameterCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Ipc Parameter Updated By")]
        [Expression("jIpcParameter.[UpdatedBy]")]
        public int? IpcParameterUpdatedBy
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.IpcParameterUpdatedBy[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.IpcParameterUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Ipc Parameter Updated Date")]
        [Expression("jIpcParameter.[UpdatedDate]")]
        public DateTime? IpcParameterUpdatedDate
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.IpcParameterUpdatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.IpcParameterUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return RecipeSettingsParameterRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsParameterRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)RecipeSettingsParameterRow.Fields.RecipeParameterId;
            }
        }

        public RecipeSettingsParameterRow()
          : base((RowFieldsBase)RecipeSettingsParameterRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field RecipeParameterId;
            public Int32Field RecipeSettingsId;
            public Int32Field IpcParameterId;
            public Int16Field IsFetchOnSelfSet;
            public Int32Field StatusId;
            public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;
            public StringField RecipeSettingsRecipeSettingsName;
            public Int32Field RecipeSettingsMachineId;
            public Int32Field RecipeSettingsStatusId;
            public Int32Field RecipeSettingsCreatedBy;
            public DateTimeField RecipeSettingsCreatedDate;
            public Int32Field RecipeSettingsUpdatedBy;
            public DateTimeField RecipeSettingsUpdatedDate;
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
            public StringField StatusStatusName;
            public StringField CreatedByEmployeeId;
            public StringField CreatedByFirstName;
            public StringField CreatedByLastName;
            public Int32Field CreatedByDepartmentId;
            public StringField CreatedByDesignation;
            public Int32Field CreatedByMobileCode;
            public Int32Field CreatedByMobileNumber;
            public StringField CreatedByEmail;
            public StringField CreatedByUsername;
            public StringField CreatedByPasswordHash;
            public StringField CreatedByPasswordSalt;
            public StringField CreatedByUserImage;
            public StringField CreatedByAddress;
            public Int32Field CreatedByCityId;
            public StringField CreatedByPinCode;
            public Int32Field CreatedByRoleId;
            public DateTimeField CreatedByPasswordExpiryDate;
            public Int16Field CreatedByIsForgotPassword;
            public BooleanField CreatedByIsPasswordChangeOnLogin;
            public Int16Field CreatedByIsUserHidden;
            public Int32Field CreatedByStatusId;
            public Int32Field CreatedBy1;
            public DateTimeField CreatedByCreatedDate;
            public Int32Field CreatedByUpdatedBy;
            public DateTimeField CreatedByUpdatedDate;
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
              : base((string)null, "")
            {
                this.LocalTextPrefix = "MachineCustomization.RecipeSettingsParameter";
            }
        }
    }
}
