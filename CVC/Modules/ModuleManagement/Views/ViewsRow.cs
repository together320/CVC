// Decompiled with JetBrains decompiler
// Type: CVC.ModuleManagement.Entities.ViewsRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.ModuleManagement.Entities
{
    [ConnectionKey("Default")]
    [TableName("Views")]
    [DisplayName("Views")]
    [InstanceName("Views")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("ModuleManagement:Views:Read")]
    [ModifyPermission("ModuleManagement:Views:Modify")]
    [LookupScript("ModuleManagement.Views", Permission = "Lookup")]
    public sealed class ViewsRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly ViewsRow.RowFields Fields = new ViewsRow.RowFields().Init<ViewsRow.RowFields>();

        [DisplayName("Views Id")]
        [Identity]
        public int? ViewsId
        {
            get
            {
                return ViewsRow.Fields.ViewsId[(Row)this];
            }
            set
            {
                ViewsRow.Fields.ViewsId[(Row)this] = value;
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
                return ViewsRow.Fields.ModuleId[(Row)this];
            }
            set
            {
                ViewsRow.Fields.ModuleId[(Row)this] = value;
            }
        }

        public bool? IsMachineSettings
        {
            get
            {
                return ViewsRow.Fields.IsMachineSettings[(Row)this];
            }
            set
            {
                ViewsRow.Fields.IsMachineSettings[(Row)this] = value;
            }
        }

        public bool? IsMachineSummary
        {
            get
            {
                return ViewsRow.Fields.IsMachineSummary[(Row)this];
            }
            set
            {
                ViewsRow.Fields.IsMachineSummary[(Row)this] = value;
            }
        }


        public bool? IslabelRoll
        {
            get
            {
                return ViewsRow.Fields.IslabelRoll[(Row)this];
            }
            set
            {
                ViewsRow.Fields.IslabelRoll[(Row)this] = value;
            }
        }

        public bool? IsCommandPanel
        {
            get
            {
                return ViewsRow.Fields.IsCommandPanel[(Row)this];
            }
            set
            {
                ViewsRow.Fields.IsCommandPanel[(Row)this] = value;
            }
        }

        [DisplayName("View Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string ViewName
        {
            get
            {
                return ViewsRow.Fields.ViewName[(Row)this];
            }
            set
            {
                ViewsRow.Fields.ViewName[(Row)this] = value;
            }
        }

        [DisplayName("Is Access Field Wise")]
        public short? IsAccessFieldWise
        {
            get
            {
                return ViewsRow.Fields.IsAccessFieldWise[(Row)this];
            }
            set
            {
                ViewsRow.Fields.IsAccessFieldWise[(Row)this] = value;
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
                return ViewsRow.Fields.StatusId[(Row)this];
            }
            set
            {
                ViewsRow.Fields.StatusId[(Row)this] = value;
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
                return ViewsRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return ViewsRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedDate[(Row)this] = value;
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
                return ViewsRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return ViewsRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Module Module Name")]
        [Expression("jModule.[ModuleName]")]
        public string ModuleModuleName
        {
            get
            {
                return ViewsRow.Fields.ModuleModuleName[(Row)this];
            }
            set
            {
                ViewsRow.Fields.ModuleModuleName[(Row)this] = value;
            }
        }

        [DisplayName("Module Machine Id")]
        [Expression("jModule.[MachineId]")]
        public int? ModuleMachineId
        {
            get
            {
                return ViewsRow.Fields.ModuleMachineId[(Row)this];
            }
            set
            {
                ViewsRow.Fields.ModuleMachineId[(Row)this] = value;
            }
        }

        [DisplayName("Module Status Id")]
        [Expression("jModule.[StatusId]")]
        public int? ModuleStatusId
        {
            get
            {
                return ViewsRow.Fields.ModuleStatusId[(Row)this];
            }
            set
            {
                ViewsRow.Fields.ModuleStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Module Created By")]
        [Expression("jModule.[CreatedBy]")]
        public int? ModuleCreatedBy
        {
            get
            {
                return ViewsRow.Fields.ModuleCreatedBy[(Row)this];
            }
            set
            {
                ViewsRow.Fields.ModuleCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Module Created Date")]
        [Expression("jModule.[CreatedDate]")]
        public DateTime? ModuleCreatedDate
        {
            get
            {
                return ViewsRow.Fields.ModuleCreatedDate[(Row)this];
            }
            set
            {
                ViewsRow.Fields.ModuleCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Module Updated By")]
        [Expression("jModule.[UpdatedBy]")]
        public int? ModuleUpdatedBy
        {
            get
            {
                return ViewsRow.Fields.ModuleUpdatedBy[(Row)this];
            }
            set
            {
                ViewsRow.Fields.ModuleUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Module Updated Date")]
        [Expression("jModule.[UpdatedDate]")]
        public DateTime? ModuleUpdatedDate
        {
            get
            {
                return ViewsRow.Fields.ModuleUpdatedDate[(Row)this];
            }
            set
            {
                ViewsRow.Fields.ModuleUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return ViewsRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                ViewsRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return ViewsRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return ViewsRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return ViewsRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return ViewsRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return ViewsRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return ViewsRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return ViewsRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return ViewsRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return ViewsRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return ViewsRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return ViewsRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return ViewsRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return ViewsRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return ViewsRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return ViewsRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return ViewsRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return ViewsRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return ViewsRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return ViewsRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return ViewsRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return ViewsRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return ViewsRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return ViewsRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return ViewsRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return ViewsRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                ViewsRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return ViewsRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return ViewsRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return ViewsRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return ViewsRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return ViewsRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return ViewsRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return ViewsRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return ViewsRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return ViewsRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return ViewsRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return ViewsRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return ViewsRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return ViewsRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return ViewsRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return ViewsRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return ViewsRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return ViewsRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return ViewsRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return ViewsRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return ViewsRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return ViewsRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return ViewsRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return ViewsRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return ViewsRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return ViewsRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                ViewsRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)ViewsRow.Fields.ViewsId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return ViewsRow.Fields.ViewName;
            }
        }

        public ViewsRow()
          : base((RowFieldsBase)ViewsRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ViewsId;
            public Int32Field ModuleId;
            public StringField ViewName;
            public BooleanField IsMachineSettings;
            public BooleanField IsMachineSummary;
            public BooleanField IslabelRoll;
            public BooleanField IsCommandPanel;
            public Int16Field IsAccessFieldWise;
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
                this.LocalTextPrefix = "ModuleManagement.Views";
            }
        }
    }
}
