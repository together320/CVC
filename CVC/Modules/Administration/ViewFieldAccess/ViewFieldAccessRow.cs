// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Entities.ViewFieldAccessRow
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
    [TableName("ViewFieldAccess")]
    [DisplayName("View Field Access")]
    [InstanceName("View Field Access")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("")]
    //[ReadPermission("Administration:ViewFieldAccess:Read")]
    //[ModifyPermission("Administration:ViewFieldAccess:Modify")]
    public sealed class ViewFieldAccessRow : Row, IIdRow, IEntity, IAuditLog
    {
        public static readonly ViewFieldAccessRow.RowFields Fields = new ViewFieldAccessRow.RowFields().Init<ViewFieldAccessRow.RowFields>();

        [DisplayName("View Field Access Id")]
        [Identity]
        public int? ViewFieldAccessId
        {
            get
            {
                return ViewFieldAccessRow.Fields.ViewFieldAccessId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.ViewFieldAccessId[(Row)this] = value;
            }
        }

        [DisplayName("View Field")]
        [ForeignKey("ViewField", "ViewField")]
        [LeftJoin("jViewField")]
        [TextualField("ViewFieldViewFieldName")]
        public int? ViewFieldId
        {
            get
            {
                return ViewFieldAccessRow.Fields.ViewFieldId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.ViewFieldId[(Row)this] = value;
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
                return ViewFieldAccessRow.Fields.RoleId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.RoleId[(Row)this] = value;
            }
        }

        [DisplayName("Is View")]
        public bool? IsView
        {
            get
            {
                return ViewFieldAccessRow.Fields.IsView[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.IsView[(Row)this] = value;
            }
        }

        [DisplayName("Is Modify")]
        public bool? IsModify
        {
            get
            {
                return ViewFieldAccessRow.Fields.IsModify[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.IsModify[(Row)this] = value;
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
                return ViewFieldAccessRow.Fields.StatusId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.StatusId[(Row)this] = value;
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
                return ViewFieldAccessRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedDate[(Row)this] = value;
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
                return ViewFieldAccessRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("View Field Views Id")]
        [Expression("jViewField.[ViewsId]")]
        public int? ViewFieldViewsId
        {
            get
            {
                return ViewFieldAccessRow.Fields.ViewFieldViewsId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.ViewFieldViewsId[(Row)this] = value;
            }
        }

        [DisplayName("View Field View Field Name")]
        [Expression("jViewField.[ViewFieldName]")]
        public string ViewFieldViewFieldName
        {
            get
            {
                return ViewFieldAccessRow.Fields.ViewFieldViewFieldName[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.ViewFieldViewFieldName[(Row)this] = value;
            }
        }

        // changes done by Vinayak On 19.07.2018
        //[DisplayName("View Field Ipc Parameter Id")]
        //[Expression("jViewField.[IPCParameterId]")]
        //public int? ViewFieldIpcParameterId
        //{
        //    get
        //    {
        //        return ViewFieldAccessRow.Fields.ViewFieldIpcParameterId[(Row)this];
        //    }
        //    set
        //    {
        //        ViewFieldAccessRow.Fields.ViewFieldIpcParameterId[(Row)this] = value;
        //    }
        //}
        // ended by Vinayak On 19.07.2018

        [DisplayName("View Field Status Id")]
        [Expression("jViewField.[StatusId]")]
        public int? ViewFieldStatusId
        {
            get
            {
                return ViewFieldAccessRow.Fields.ViewFieldStatusId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.ViewFieldStatusId[(Row)this] = value;
            }
        }

        [DisplayName("View Field Created By")]
        [Expression("jViewField.[CreatedBy]")]
        public int? ViewFieldCreatedBy
        {
            get
            {
                return ViewFieldAccessRow.Fields.ViewFieldCreatedBy[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.ViewFieldCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("View Field Created Date")]
        [Expression("jViewField.[CreatedDate]")]
        public DateTime? ViewFieldCreatedDate
        {
            get
            {
                return ViewFieldAccessRow.Fields.ViewFieldCreatedDate[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.ViewFieldCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("View Field Updated By")]
        [Expression("jViewField.[UpdatedBy]")]
        public int? ViewFieldUpdatedBy
        {
            get
            {
                return ViewFieldAccessRow.Fields.ViewFieldUpdatedBy[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.ViewFieldUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("View Field Updated Date")]
        [Expression("jViewField.[UpdatedDate]")]
        public DateTime? ViewFieldUpdatedDate
        {
            get
            {
                return ViewFieldAccessRow.Fields.ViewFieldUpdatedDate[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.ViewFieldUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Role Role Name")]
        [Expression("jRole.[RoleName]")]
        public string RoleRoleName
        {
            get
            {
                return ViewFieldAccessRow.Fields.RoleRoleName[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.RoleRoleName[(Row)this] = value;
            }
        }

        [DisplayName("Role Status Id")]
        [Expression("jRole.[StatusId]")]
        public int? RoleStatusId
        {
            get
            {
                return ViewFieldAccessRow.Fields.RoleStatusId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.RoleStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Role Is Hidden")]
        [Expression("jRole.[IsHidden]")]
        public short? RoleIsHidden
        {
            get
            {
                return ViewFieldAccessRow.Fields.RoleIsHidden[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.RoleIsHidden[(Row)this] = value;
            }
        }

        [DisplayName("Role Parent Role Id")]
        [Expression("jRole.[ParentRoleId]")]
        public int? RoleParentRoleId
        {
            get
            {
                return ViewFieldAccessRow.Fields.RoleParentRoleId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.RoleParentRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Role Created By")]
        [Expression("jRole.[CreatedBy]")]
        public int? RoleCreatedBy
        {
            get
            {
                return ViewFieldAccessRow.Fields.RoleCreatedBy[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.RoleCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Role Created Date")]
        [Expression("jRole.[CreatedDate]")]
        public DateTime? RoleCreatedDate
        {
            get
            {
                return ViewFieldAccessRow.Fields.RoleCreatedDate[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.RoleCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Role Updated By")]
        [Expression("jRole.[UpdatedBy]")]
        public int? RoleUpdatedBy
        {
            get
            {
                return ViewFieldAccessRow.Fields.RoleUpdatedBy[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.RoleUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Role Updated Date")]
        [Expression("jRole.[UpdatedDate]")]
        public DateTime? RoleUpdatedDate
        {
            get
            {
                return ViewFieldAccessRow.Fields.RoleUpdatedDate[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.RoleUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return ViewFieldAccessRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return ViewFieldAccessRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return ViewFieldAccessRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                ViewFieldAccessRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)ViewFieldAccessRow.Fields.ViewFieldAccessId;
            }
        }

        public ViewFieldAccessRow()
          : base((RowFieldsBase)ViewFieldAccessRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ViewFieldAccessId;
            public Int32Field ViewFieldId;
            public Int32Field RoleId;
            public BooleanField IsView;
            public BooleanField IsModify;
            public Int32Field StatusId;
            public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;
            public Int32Field ViewFieldViewsId;
            public StringField ViewFieldViewFieldName;
            // changes done by Vinayak On 19.07.2018
            //public Int32Field ViewFieldIpcParameterId; 
            // ended by Vinayak On 19.07.2018
            public Int32Field ViewFieldStatusId;
            public Int32Field ViewFieldCreatedBy;
            public DateTimeField ViewFieldCreatedDate;
            public Int32Field ViewFieldUpdatedBy;
            public DateTimeField ViewFieldUpdatedDate;
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
                this.LocalTextPrefix = "Administration.ViewFieldAccess";
            }
        }
    }
}
