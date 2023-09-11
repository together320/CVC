// Decompiled with JetBrains decompiler
// Type: CVC.ExternalApplicationInterface.Entities.ProtocolRow
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

namespace CVC.ExternalApplicationInterface.Entities
{
    [ConnectionKey("Default")]
    [TableName("Protocol")]
    [DisplayName("Protocol")]
    [InstanceName("Protocol")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("EAI:Protocol:Read")]
    [ModifyPermission("EAI:Protocol:Modify")]
    [LookupScript("ExternalApplicationInterface.Protocol", Permission = "Lookup")]
    public sealed class ProtocolRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly ProtocolRow.RowFields Fields = new ProtocolRow.RowFields().Init<ProtocolRow.RowFields>();

        [DisplayName("Protocol Id")]
        [Identity]
        public int? ProtocolId
        {
            get
            {
                return ProtocolRow.Fields.ProtocolId[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.ProtocolId[(Row)this] = value;
            }
        }

        [DisplayName("Protocol Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [Unique]
        [Required]
        public string ProtocolName
        {
            get
            {
                return ProtocolRow.Fields.ProtocolName[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.ProtocolName[(Row)this] = value;
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
                return ProtocolRow.Fields.StatusId[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.StatusId[(Row)this] = value;
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
                return ProtocolRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return ProtocolRow.Fields.CreatedDate[(Row)this];
            }

            set
            {
                ProtocolRow.Fields.CreatedDate[(Row)this] = value;
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
                return ProtocolRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return ProtocolRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return ProtocolRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return ProtocolRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return ProtocolRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return ProtocolRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return ProtocolRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return ProtocolRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return ProtocolRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return ProtocolRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return ProtocolRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return ProtocolRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return ProtocolRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return ProtocolRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return ProtocolRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return ProtocolRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return ProtocolRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return ProtocolRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return ProtocolRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return ProtocolRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return ProtocolRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return ProtocolRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return ProtocolRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return ProtocolRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return ProtocolRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return ProtocolRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return ProtocolRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return ProtocolRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return ProtocolRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return ProtocolRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return ProtocolRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                ProtocolRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }


        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)ProtocolRow.Fields.ProtocolId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return ProtocolRow.Fields.ProtocolName;
            }
        }

        public ProtocolRow()
          : base((RowFieldsBase)ProtocolRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        // public class RowFields : RowFieldsBase
        {
            public Int32Field ProtocolId;
            public StringField ProtocolName;
            public Int32Field StatusId;
           // public Int32Field CreatedBy;
          //  public DateTimeField CreatedDate;
            //public Int32Field UpdatedBy;
           // public DateTimeField UpdatedDate;
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
              : base((string)null, "")
            {
                this.LocalTextPrefix = "ExternalApplicationInterface.Protocol";
            }
        }
    }
}
