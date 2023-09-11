// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Entities.DepartmentRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.Configuration.Entities
{
    [ConnectionKey("Default")]
    [TableName("Department")]
    [DisplayName("Department")]
    [InstanceName("Department")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Configuration:Department:Read")]
    [ModifyPermission("Configuration:Department:Modify")]
    [LookupScript("Configuration.Department", Permission = "Lookup")]
    public sealed class DepartmentRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly DepartmentRow.RowFields Fields = new DepartmentRow.RowFields().Init<DepartmentRow.RowFields>();

        [DisplayName("Department Id")]
        [Identity]
        public int? DepartmentId
        {
            get
            {
                return DepartmentRow.Fields.DepartmentId[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.DepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Department Code")]
        [Size(20)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        public string DepartmentCode
        {
            get
            {
                return DepartmentRow.Fields.DepartmentCode[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.DepartmentCode[(Row)this] = value;
            }
        }

        [DisplayName("Department Name")]
        [Size(100)]
        [NotNull]
        public string DepartmentName
        {
            get
            {
                return DepartmentRow.Fields.DepartmentName[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.DepartmentName[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [ForeignKey("Status", "StatusId")]
        [LeftJoin("jStatus")]
        [TextualField("StatusStatusName")]
        //To make status as default "Active"
        [DefaultValue(1)]
        [NotNull]
        public int? StatusId
        {
            get
            {
                return DepartmentRow.Fields.StatusId[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return DepartmentRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return DepartmentRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return DepartmentRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return DepartmentRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return DepartmentRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return DepartmentRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return DepartmentRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return DepartmentRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return DepartmentRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return DepartmentRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return DepartmentRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return DepartmentRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return DepartmentRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return DepartmentRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return DepartmentRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return DepartmentRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return DepartmentRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return DepartmentRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return DepartmentRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return DepartmentRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return DepartmentRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return DepartmentRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return DepartmentRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return DepartmentRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return DepartmentRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return DepartmentRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return DepartmentRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return DepartmentRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                DepartmentRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return DepartmentRow.Fields.RecordAddedSource[(Row)this];

            }
            set
            {
                DepartmentRow.Fields.RecordAddedSource[(Row)this] = value;

            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)DepartmentRow.Fields.DepartmentId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return DepartmentRow.Fields.DepartmentCode;
            }
        }

        public DepartmentRow()
          : base((RowFieldsBase)DepartmentRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field DepartmentId;
            public StringField DepartmentCode;
            public StringField DepartmentName;
            public Int32Field StatusId;
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
            public StringField RecordAddedSource;

            public RowFields()
              : base((string)null, (string)null)
            {
                this.LocalTextPrefix = "Configuration.Department";
            }
        }
    }
}
