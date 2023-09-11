// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Entities.PickListValueRoleAccessRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.Configuration.Entities
{
    [ConnectionKey("Default")]
    [TableName("PickListValueRoleAccess")]
    [DisplayName("Pick List Value Role Access")]
    [InstanceName("Pick List Value Role Access")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PickListValueRoleAccessRow : Row, IIdRow, IEntity, IAuditLog
    {
        public static readonly PickListValueRoleAccessRow.RowFields Fields = new PickListValueRoleAccessRow.RowFields().Init<PickListValueRoleAccessRow.RowFields>();

        [DisplayName("Pick List Value Role Access Id")]
        [Identity]
        public int? PickListValueRoleAccessId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.PickListValueRoleAccessId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.PickListValueRoleAccessId[(Row)this] = value;
            }
        }

        [DisplayName("Pick List Value")]
        [ForeignKey("PickListValue", "PickListValueId")]
        [LeftJoin("jPickListValue")]
        [TextualField("PickListValuePickListValueName")]
        public int? PickListValueId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.PickListValueId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.PickListValueId[(Row)this] = value;
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
                return PickListValueRoleAccessRow.Fields.RoleId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.RoleId[(Row)this] = value;
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
                return PickListValueRoleAccessRow.Fields.StatusId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.StatusId[(Row)this] = value;
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
                return PickListValueRoleAccessRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedDate[(Row)this] = value;
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
                return PickListValueRoleAccessRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Pick List Value Pick List Id")]
        [Expression("jPickListValue.[PickListId]")]
        public int? PickListValuePickListId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.PickListValuePickListId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.PickListValuePickListId[(Row)this] = value;
            }
        }

        [DisplayName("Pick List Value Pick List Value Name")]
        [Expression("jPickListValue.[PickListValueName]")]
        public string PickListValuePickListValueName
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.PickListValuePickListValueName[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.PickListValuePickListValueName[(Row)this] = value;
            }
        }

        [DisplayName("Pick List Value Status Id")]
        [Expression("jPickListValue.[StatusId]")]
        public int? PickListValueStatusId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.PickListValueStatusId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.PickListValueStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Pick List Value Created By")]
        [Expression("jPickListValue.[CreatedBy]")]
        public int? PickListValueCreatedBy
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.PickListValueCreatedBy[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.PickListValueCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Pick List Value Created Date")]
        [Expression("jPickListValue.[CreatedDate]")]
        public DateTime? PickListValueCreatedDate
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.PickListValueCreatedDate[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.PickListValueCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Pick List Value Updated By")]
        [Expression("jPickListValue.[UpdatedBy]")]
        public int? PickListValueUpdatedBy
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.PickListValueUpdatedBy[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.PickListValueUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Pick List Value Updated Date")]
        [Expression("jPickListValue.[UpdatedDate]")]
        public DateTime? PickListValueUpdatedDate
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.PickListValueUpdatedDate[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.PickListValueUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Role Role Name")]
        [Expression("jRole.[RoleName]")]
        public string RoleRoleName
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.RoleRoleName[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.RoleRoleName[(Row)this] = value;
            }
        }

        [DisplayName("Role Status Id")]
        [Expression("jRole.[StatusId]")]
        public int? RoleStatusId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.RoleStatusId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.RoleStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Role Is Hidden")]
        [Expression("jRole.[IsHidden]")]
        public short? RoleIsHidden
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.RoleIsHidden[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.RoleIsHidden[(Row)this] = value;
            }
        }

        [DisplayName("Role Parent Role Id")]
        [Expression("jRole.[ParentRoleId]")]
        public int? RoleParentRoleId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.RoleParentRoleId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.RoleParentRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Role Created By")]
        [Expression("jRole.[CreatedBy]")]
        public int? RoleCreatedBy
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.RoleCreatedBy[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.RoleCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Role Created Date")]
        [Expression("jRole.[CreatedDate]")]
        public DateTime? RoleCreatedDate
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.RoleCreatedDate[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.RoleCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Role Updated By")]
        [Expression("jRole.[UpdatedBy]")]
        public int? RoleUpdatedBy
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.RoleUpdatedBy[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.RoleUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Role Updated Date")]
        [Expression("jRole.[UpdatedDate]")]
        public DateTime? RoleUpdatedDate
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.RoleUpdatedDate[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.RoleUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return PickListValueRoleAccessRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                PickListValueRoleAccessRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)PickListValueRoleAccessRow.Fields.PickListValueRoleAccessId;
            }
        }

        public PickListValueRoleAccessRow()
          : base((RowFieldsBase)PickListValueRoleAccessRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field PickListValueRoleAccessId;
            public Int32Field PickListValueId;
            public Int32Field RoleId;
            public Int32Field StatusId;
            public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;
            public Int32Field PickListValuePickListId;
            public StringField PickListValuePickListValueName;
            public Int32Field PickListValueStatusId;
            public Int32Field PickListValueCreatedBy;
            public DateTimeField PickListValueCreatedDate;
            public Int32Field PickListValueUpdatedBy;
            public DateTimeField PickListValueUpdatedDate;
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
                this.LocalTextPrefix = "Configuration.PickListValueRoleAccess";
            }
        }
    }
}
