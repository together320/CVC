// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Entities.CityDetailsRow
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
    [TableName("CityDetails")]
    [DisplayName("City Details")]
    [InstanceName("City Details")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Configuration:CityDetails:Read")]
    [ModifyPermission("Configuration:CityDetails:Modify")]
    [LookupScript("Configuration.CityDetails", Permission = "Lookup")]
    public sealed class CityDetailsRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly CityDetailsRow.RowFields Fields = new CityDetailsRow.RowFields().Init<CityDetailsRow.RowFields>();

        [DisplayName("City Details Id")]
        [Identity]
        public int? CityDetailsId
        {
            get
            {
                return CityDetailsRow.Fields.CityDetailsId[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CityDetailsId[(Row)this] = value;
            }
        }

        [DisplayName("City")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        public string City
        {
            get
            {
                return CityDetailsRow.Fields.City[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.City[(Row)this] = value;
            }
        }

        [DisplayName("Country")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        public string Country
        {
            get
            {
                return CityDetailsRow.Fields.Country[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.Country[(Row)this] = value;
            }
        }

        [DisplayName("State")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        public string State
        {
            get
            {
                return CityDetailsRow.Fields.State[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.State[(Row)this] = value;
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
                return CityDetailsRow.Fields.StatusId[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.StatusId[(Row)this] = value;
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
                return CityDetailsRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return CityDetailsRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedDate[(Row)this] = value;
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
                return CityDetailsRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return CityDetailsRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return CityDetailsRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return CityDetailsRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return CityDetailsRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                CityDetailsRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return CityDetailsRow.Fields.RecordAddedSource[(Row)this];

            }
            set
            {
                CityDetailsRow.Fields.RecordAddedSource[(Row)this] = value;

            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)CityDetailsRow.Fields.CityDetailsId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return CityDetailsRow.Fields.City;
            }
        }

        public CityDetailsRow()
          : base((RowFieldsBase)CityDetailsRow.Fields)
        {
        }
        public class RowFields : LoggingRow.LoggingRowFields
       // public class RowFields : RowFieldsBase
        {
            public Int32Field CityDetailsId;
            public StringField Country;
            public StringField State;
            public StringField City;
            public Int32Field StatusId;
          /*  public Int32Field CreatedBy;
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
            public StringField RecordAddedSource;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Configuration.CityDetails";
            }
        }
    }
}
