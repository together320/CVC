// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Entities.ModuleAccessRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.Administration.Entities
{
    [ConnectionKey("Default")]
    [TableName("ModuleAccess")]
    [DisplayName("Module Access")]
    [InstanceName("Module Access")]
    [TwoLevelCached(new string[] { })]
    //[ReadPermission("Administration:General")]
    //[ModifyPermission("Administration:General")]
    [ReadPermission("")]
    [ModifyPermission("")]

    public sealed class ModuleAccessRow : Row, IIdRow, IEntity, IAuditLog
    {
        public static readonly ModuleAccessRow.RowFields Fields = new ModuleAccessRow.RowFields().Init<ModuleAccessRow.RowFields>();

        [DisplayName("Module Access Id")]
        [Identity]
        public int? ModuleAccessId
        {
            get
            {
                return ModuleAccessRow.Fields.ModuleAccessId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.ModuleAccessId[(Row)this] = value;
            }
        }

        [DisplayName("Module")]
        [ForeignKey("Module", "ModuleId")]
        [LeftJoin("jModule")]
        [TextualField("ModuleModuleName")]
        public int? ModuleId
        {
            get
            {
                return ModuleAccessRow.Fields.ModuleId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.ModuleId[(Row)this] = value;
            }
        }

        [DisplayName("Role")]
        [ForeignKey("Roles", "RoleId")]
        [LeftJoin("jRole")]
        [TextualField("RoleRoleName")]
        public int? RoleId
        {
            get
            {
                return ModuleAccessRow.Fields.RoleId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.RoleId[(Row)this] = value;
            }
        }

        [DisplayName("Is Access")]
        public short? IsAccess
        {
            get
            {
                return ModuleAccessRow.Fields.IsAccess[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.IsAccess[(Row)this] = value;
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
                return ModuleAccessRow.Fields.StatusId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.StatusId[(Row)this] = value;
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
                return ModuleAccessRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedDate[(Row)this] = value;
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
                return ModuleAccessRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Module Module Name")]
        [Expression("jModule.[ModuleName]")]
        public string ModuleModuleName
        {
            get
            {
                return ModuleAccessRow.Fields.ModuleModuleName[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.ModuleModuleName[(Row)this] = value;
            }
        }

        [DisplayName("Module Machine Id")]
        [Expression("jModule.[MachineId]")]
        public int? ModuleMachineId
        {
            get
            {
                return ModuleAccessRow.Fields.ModuleMachineId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.ModuleMachineId[(Row)this] = value;
            }
        }

        [DisplayName("Module Status Id")]
        [Expression("jModule.[StatusId]")]
        public int? ModuleStatusId
        {
            get
            {
                return ModuleAccessRow.Fields.ModuleStatusId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.ModuleStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Module Created By")]
        [Expression("jModule.[CreatedBy]")]
        public int? ModuleCreatedBy
        {
            get
            {
                return ModuleAccessRow.Fields.ModuleCreatedBy[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.ModuleCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Module Created Date")]
        [Expression("jModule.[CreatedDate]")]
        public DateTime? ModuleCreatedDate
        {
            get
            {
                return ModuleAccessRow.Fields.ModuleCreatedDate[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.ModuleCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Module Updated By")]
        [Expression("jModule.[UpdatedBy]")]
        public int? ModuleUpdatedBy
        {
            get
            {
                return ModuleAccessRow.Fields.ModuleUpdatedBy[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.ModuleUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Module Updated Date")]
        [Expression("jModule.[UpdatedDate]")]
        public DateTime? ModuleUpdatedDate
        {
            get
            {
                return ModuleAccessRow.Fields.ModuleUpdatedDate[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.ModuleUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Role Role Name")]
        [Expression("jRole.[RoleName]")]
        public string RoleRoleName
        {
            get
            {
                return ModuleAccessRow.Fields.RoleRoleName[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.RoleRoleName[(Row)this] = value;
            }
        }

        [DisplayName("Role Status Id")]
        [Expression("jRole.[StatusId]")]
        public int? RoleStatusId
        {
            get
            {
                return ModuleAccessRow.Fields.RoleStatusId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.RoleStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Role Is Hidden")]
        [Expression("jRole.[IsHidden]")]
        public short? RoleIsHidden
        {
            get
            {
                return ModuleAccessRow.Fields.RoleIsHidden[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.RoleIsHidden[(Row)this] = value;
            }
        }

        [DisplayName("Role Parent Role Id")]
        [Expression("jRole.[ParentRoleId]")]
        public int? RoleParentRoleId
        {
            get
            {
                return ModuleAccessRow.Fields.RoleParentRoleId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.RoleParentRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Role Created By")]
        [Expression("jRole.[CreatedBy]")]
        public int? RoleCreatedBy
        {
            get
            {
                return ModuleAccessRow.Fields.RoleCreatedBy[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.RoleCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Role Created Date")]
        [Expression("jRole.[CreatedDate]")]
        public DateTime? RoleCreatedDate
        {
            get
            {
                return ModuleAccessRow.Fields.RoleCreatedDate[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.RoleCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Role Updated By")]
        [Expression("jRole.[UpdatedBy]")]
        public int? RoleUpdatedBy
        {
            get
            {
                return ModuleAccessRow.Fields.RoleUpdatedBy[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.RoleUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Role Updated Date")]
        [Expression("jRole.[UpdatedDate]")]
        public DateTime? RoleUpdatedDate
        {
            get
            {
                return ModuleAccessRow.Fields.RoleUpdatedDate[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.RoleUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return ModuleAccessRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return ModuleAccessRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return ModuleAccessRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                ModuleAccessRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)ModuleAccessRow.Fields.ModuleAccessId;
            }
        }

        public ModuleAccessRow()
          : base((RowFieldsBase)ModuleAccessRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ModuleAccessId;
            public Int32Field ModuleId;
            public Int32Field RoleId;
            public Int16Field IsAccess;
            public Int32Field StatusId;
            public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;
            public StringField ModuleModuleName;
            public Int32Field ModuleMachineId;
            public Int32Field ModuleStatusId;
            public Int32Field ModuleCreatedBy;
            public DateTimeField ModuleCreatedDate;
            public Int32Field ModuleUpdatedBy;
            public DateTimeField ModuleUpdatedDate;
            public StringField RoleRoleName;
            public Int32Field RoleStatusId;
            public Int16Field RoleIsHidden;
            public Int32Field RoleParentRoleId;
            public Int32Field RoleCreatedBy;
            public DateTimeField RoleCreatedDate;
            public Int32Field RoleUpdatedBy;
            public DateTimeField RoleUpdatedDate;
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
                this.LocalTextPrefix = "Administration.ModuleAccess";
            }
        }
    }
}
