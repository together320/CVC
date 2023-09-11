// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Entities.PickListValueRow
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
    [TableName("PickListValue")]
    [DisplayName("Pick List Value")]
    [InstanceName("Pick List Value")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Configuration:PickListValue:Read")]
    [ModifyPermission("Configuration:PickListValue:Modify")]
    [LookupScript("Configuration.PickListValue", Permission = "Lookup")]
    public sealed class PickListValueRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly PickListValueRow.RowFields Fields = new PickListValueRow.RowFields().Init<PickListValueRow.RowFields>();

        [DisplayName("Pick List Value Id")]
        [Identity]
        public int? PickListValueId
        {
            get
            {
                return PickListValueRow.Fields.PickListValueId[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.PickListValueId[(Row)this] = value;
            }
        }

        [DisplayName("Pick List")]
        [ForeignKey("PickList", "PickListId")]
        [LeftJoin("jPickList")]
        [TextualField("PickListName")]
        public int? PickListId
        {
            get
            {
                return PickListValueRow.Fields.PickListId[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.PickListId[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jPickList.[PickListName]")]
        public string PickListName
        {
            get
            {
                return PickListValueRow.Fields.PickListName[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.PickListName[(Row)this] = value;
            }
        }

        [DisplayName("Pick List Value Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string PickListValueName
        {
            get
            {
                return PickListValueRow.Fields.PickListValueName[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.PickListValueName[(Row)this] = value;
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
                return PickListValueRow.Fields.StatusId[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.StatusId[(Row)this] = value;
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
                return PickListValueRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return PickListValueRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedDate[(Row)this] = value;
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
                return PickListValueRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return PickListValueRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return PickListValueRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return PickListValueRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return PickListValueRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return PickListValueRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return PickListValueRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return PickListValueRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return PickListValueRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return PickListValueRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return PickListValueRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return PickListValueRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return PickListValueRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return PickListValueRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return PickListValueRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return PickListValueRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return PickListValueRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return PickListValueRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return PickListValueRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return PickListValueRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return PickListValueRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return PickListValueRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return PickListValueRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return PickListValueRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return PickListValueRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return PickListValueRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return PickListValueRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return PickListValueRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return PickListValueRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return PickListValueRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return PickListValueRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                PickListValueRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }


        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)PickListValueRow.Fields.PickListValueId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return PickListValueRow.Fields.PickListValueName;
            }
        }

        public PickListValueRow()
          : base((RowFieldsBase)PickListValueRow.Fields)
        {
        }
        public class RowFields : LoggingRow.LoggingRowFields

        // public class RowFields : RowFieldsBase
        {
            public Int32Field PickListValueId;
            public Int32Field PickListId;
            public StringField PickListValueName;
            public Int32Field StatusId;
            /*public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;*/
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
            public StringField PickListName;
            public StringField RecordAddedSource;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Configuration.PickListValue";
            }
        }
    }
}
