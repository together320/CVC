// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Entities.ViewsAccessRow
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
    [TableName("ViewsAccess")]
    [DisplayName("Views Access")]
    [InstanceName("Views Access")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("")]

    // [ReadPermission("Administration:ViewsAccess:Read")]
    // [ModifyPermission("Administration:ViewsAccess:Modify")]
    public sealed class ViewsAccessRow : Row, IIdRow, IEntity, IAuditLog
    {
        public static readonly ViewsAccessRow.RowFields Fields = new ViewsAccessRow.RowFields().Init<ViewsAccessRow.RowFields>();

        [DisplayName("Views Access Id")]
        [Identity]
        public int? ViewsAccessId
        {
            get
            {
                return ViewsAccessRow.Fields.ViewsAccessId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.ViewsAccessId[(Row)this] = value;
            }
        }

        [DisplayName("Views")]
        [ForeignKey("Views", "ViewsId")]
        [LeftJoin("jViews")]
        [TextualField("ViewsViewName")]
        public int? ViewsId
        {
            get
            {
                return ViewsAccessRow.Fields.ViewsId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.ViewsId[(Row)this] = value;
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
                return ViewsAccessRow.Fields.RoleId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.RoleId[(Row)this] = value;
            }
        }

        [DisplayName("Is View")]
        public bool? IsView
        {
            get
            {
                return ViewsAccessRow.Fields.IsView[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.IsView[(Row)this] = value;
            }
        }

        [DisplayName("Is Modify")]
        public bool? IsModify
        {
            get
            {
                return ViewsAccessRow.Fields.IsModify[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.IsModify[(Row)this] = value;
            }
        }

        //[DisplayName("Is Add")]
        //public short? IsAdd
        //{
        //  get
        //  {
        //    return ViewsAccessRow.Fields.IsAdd[(Row) this];
        //  }
        //  set
        //  {
        //    ViewsAccessRow.Fields.IsAdd[(Row) this] = value;
        //  }
        //}

        //[DisplayName("Is Delete")]
        //public short? IsDelete
        //{
        //  get
        //  {
        //    return ViewsAccessRow.Fields.IsDelete[(Row) this];
        //  }
        //  set
        //  {
        //    ViewsAccessRow.Fields.IsDelete[(Row) this] = value;
        //  }
        //}

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
                return ViewsAccessRow.Fields.StatusId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.StatusId[(Row)this] = value;
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
                return ViewsAccessRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedDate[(Row)this] = value;
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
                return ViewsAccessRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Views Module Id")]
        [Expression("jViews.[ModuleId]")]
        public int? ViewsModuleId
        {
            get
            {
                return ViewsAccessRow.Fields.ViewsModuleId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.ViewsModuleId[(Row)this] = value;
            }
        }

        [DisplayName("Views View Name")]
        [Expression("jViews.[ViewName]")]
        public string ViewsViewName
        {
            get
            {
                return ViewsAccessRow.Fields.ViewsViewName[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.ViewsViewName[(Row)this] = value;
            }
        }

        [DisplayName("Views Is Access Field Wise")]
        [Expression("jViews.[IsAccessFieldWise]")]
        public short? ViewsIsAccessFieldWise
        {
            get
            {
                return ViewsAccessRow.Fields.ViewsIsAccessFieldWise[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.ViewsIsAccessFieldWise[(Row)this] = value;
            }
        }

        [DisplayName("Views Status Id")]
        [Expression("jViews.[StatusId]")]
        public int? ViewsStatusId
        {
            get
            {
                return ViewsAccessRow.Fields.ViewsStatusId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.ViewsStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Views Created By")]
        [Expression("jViews.[CreatedBy]")]
        public int? ViewsCreatedBy
        {
            get
            {
                return ViewsAccessRow.Fields.ViewsCreatedBy[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.ViewsCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Views Created Date")]
        [Expression("jViews.[CreatedDate]")]
        public DateTime? ViewsCreatedDate
        {
            get
            {
                return ViewsAccessRow.Fields.ViewsCreatedDate[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.ViewsCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Views Updated By")]
        [Expression("jViews.[UpdatedBy]")]
        public int? ViewsUpdatedBy
        {
            get
            {
                return ViewsAccessRow.Fields.ViewsUpdatedBy[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.ViewsUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Views Updated Date")]
        [Expression("jViews.[UpdatedDate]")]
        public DateTime? ViewsUpdatedDate
        {
            get
            {
                return ViewsAccessRow.Fields.ViewsUpdatedDate[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.ViewsUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Role Role Name")]
        [Expression("jRole.[RoleName]")]
        public string RoleRoleName
        {
            get
            {
                return ViewsAccessRow.Fields.RoleRoleName[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.RoleRoleName[(Row)this] = value;
            }
        }

        [DisplayName("Role Status Id")]
        [Expression("jRole.[StatusId]")]
        public int? RoleStatusId
        {
            get
            {
                return ViewsAccessRow.Fields.RoleStatusId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.RoleStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Role Is Hidden")]
        [Expression("jRole.[IsHidden]")]
        public short? RoleIsHidden
        {
            get
            {
                return ViewsAccessRow.Fields.RoleIsHidden[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.RoleIsHidden[(Row)this] = value;
            }
        }

        [DisplayName("Role Parent Role Id")]
        [Expression("jRole.[ParentRoleId]")]
        public int? RoleParentRoleId
        {
            get
            {
                return ViewsAccessRow.Fields.RoleParentRoleId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.RoleParentRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Role Created By")]
        [Expression("jRole.[CreatedBy]")]
        public int? RoleCreatedBy
        {
            get
            {
                return ViewsAccessRow.Fields.RoleCreatedBy[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.RoleCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Role Created Date")]
        [Expression("jRole.[CreatedDate]")]
        public DateTime? RoleCreatedDate
        {
            get
            {
                return ViewsAccessRow.Fields.RoleCreatedDate[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.RoleCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Role Updated By")]
        [Expression("jRole.[UpdatedBy]")]
        public int? RoleUpdatedBy
        {
            get
            {
                return ViewsAccessRow.Fields.RoleUpdatedBy[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.RoleUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Role Updated Date")]
        [Expression("jRole.[UpdatedDate]")]
        public DateTime? RoleUpdatedDate
        {
            get
            {
                return ViewsAccessRow.Fields.RoleUpdatedDate[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.RoleUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return ViewsAccessRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return ViewsAccessRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return ViewsAccessRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                ViewsAccessRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)ViewsAccessRow.Fields.ViewsAccessId;
            }
        }

        public ViewsAccessRow()
          : base((RowFieldsBase)ViewsAccessRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ViewsAccessId;
            public Int32Field ViewsId;
            public Int32Field RoleId;
            public BooleanField IsView;
            public BooleanField IsModify;

            public Int32Field StatusId;
            public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;
            public Int32Field ViewsModuleId;
            public StringField ViewsViewName;
            public Int16Field ViewsIsAccessFieldWise;
            public Int32Field ViewsStatusId;
            public Int32Field ViewsCreatedBy;
            public DateTimeField ViewsCreatedDate;
            public Int32Field ViewsUpdatedBy;
            public DateTimeField ViewsUpdatedDate;
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
                this.LocalTextPrefix = "Administration.ViewsAccess";
            }
        }
    }
}
