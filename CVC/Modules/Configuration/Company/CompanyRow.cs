// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Entities.CompanyRow
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
    [TableName("Company")]
    [DisplayName("Company")]
    [InstanceName("Company")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Configuration:Company:Read")]
    [ModifyPermission("Configuration:Company:Modify")]
    public sealed class CompanyRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly CompanyRow.RowFields Fields = new CompanyRow.RowFields().Init<CompanyRow.RowFields>();

        [DisplayName("Company Id")]
        [Identity]
        public int? CompanyId
        {
            get
            {
                return CompanyRow.Fields.CompanyId[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CompanyId[(Row)this] = value;
            }
        }

        [DisplayName("Company Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        [Unique]
        public string CompanyName
        {
            get
            {
                return CompanyRow.Fields.CompanyName[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CompanyName[(Row)this] = value;
            }
        }

        [DisplayName("Address")]
        [Size(200)]
        [NotNull]
        public string Address
        {
            get
            {
                return CompanyRow.Fields.Address[(Row)this];
            }
            set
            {
                CompanyRow.Fields.Address[(Row)this] = value;
            }
        }

        [DisplayName("City")]
        [ForeignKey("CityDetails", "CityDetailsId")]
        [LeftJoin("jCity")]
        [TextualField("CityCountry")]
        [NotNull]
        public int? CityId
        {
            get
            {
                return CompanyRow.Fields.CityId[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CityId[(Row)this] = value;
            }
        }

        [DisplayName("Pin Code")]
        [Size(10)]
        [NotNull]
        public string PinCode
        {
            get
            {
                return CompanyRow.Fields.PinCode[(Row)this];
            }
            set
            {
                CompanyRow.Fields.PinCode[(Row)this] = value;
            }
        }

        [DisplayName("Website")]
        [Size(75)]
        public string Website
        {
            get
            {
                return CompanyRow.Fields.Website[(Row)this];
            }
            set
            {
                CompanyRow.Fields.Website[(Row)this] = value;
            }
        }

        [DisplayName("Company Logo")]
        [NotNull]
        [ImageUploadEditor(CopyToHistory = true, FilenameFormat = "CompanyImage/~")]
        public string CompanyLogo
        {
            get
            {
                return CompanyRow.Fields.CompanyLogo[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CompanyLogo[(Row)this] = value;
            }
        }

        [DisplayName("City Country")]
        [Expression("jCity.[Country]")]
        public string CityCountry
        {
            get
            {
                return CompanyRow.Fields.CityCountry[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CityCountry[(Row)this] = value;
            }
        }

        [DisplayName("City State")]
        [Expression("jCity.[State]")]
        public string CityState
        {
            get
            {
                return CompanyRow.Fields.CityState[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CityState[(Row)this] = value;
            }
        }

        [DisplayName("City")]
        [Expression("jCity.[City]")]
        public string City
        {
            get
            {
                return CompanyRow.Fields.City[(Row)this];
            }
            set
            {
                CompanyRow.Fields.City[(Row)this] = value;
            }
        }

        [DisplayName("City Status Id")]
        [Expression("jCity.[StatusId]")]
        //To make status as default "Active"
        [DefaultValue(1)]
        public int? CityStatusId
        {
            get
            {
                return CompanyRow.Fields.CityStatusId[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CityStatusId[(Row)this] = value;
            }
        }

        [DisplayName("City Created By")]
        [Expression("jCity.[CreatedBy]")]
        public int? CityCreatedBy
        {
            get
            {
                return CompanyRow.Fields.CityCreatedBy[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CityCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("City Created Date")]
        [Expression("jCity.[CreatedDate]")]
        public DateTime? CityCreatedDate
        {
            get
            {
                return CompanyRow.Fields.CityCreatedDate[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CityCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("City Updated By")]
        [Expression("jCity.[UpdatedBy]")]
        public int? CityUpdatedBy
        {
            get
            {
                return CompanyRow.Fields.CityUpdatedBy[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CityUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("City Updated Date")]
        [Expression("jCity.[UpdatedDate]")]
        public DateTime? CityUpdatedDate
        {
            get
            {
                return CompanyRow.Fields.CityUpdatedDate[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CityUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return CompanyRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return CompanyRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return CompanyRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[FirstName] + ' ' + jCreatedBy.[LastName]")]
        public string CreatedByFullName
        {
            get
            {
                return CompanyRow.Fields.CreatedByFullName[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByFullName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return CompanyRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return CompanyRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return CompanyRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return CompanyRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return CompanyRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return CompanyRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return CompanyRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return CompanyRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return CompanyRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return CompanyRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return CompanyRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return CompanyRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return CompanyRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return CompanyRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return CompanyRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return CompanyRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return CompanyRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return CompanyRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return CompanyRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return CompanyRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return CompanyRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return CompanyRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                CompanyRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return CompanyRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return CompanyRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[FirstName] + ' ' + jUpdatedBy.[LastName]")]
        public string UpdatedByFullName
        {
            get
            {
                return CompanyRow.Fields.UpdatedByFullName[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByFullName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return CompanyRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return CompanyRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return CompanyRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return CompanyRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return CompanyRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return CompanyRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return CompanyRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return CompanyRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return CompanyRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return CompanyRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return CompanyRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return CompanyRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return CompanyRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return CompanyRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return CompanyRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return CompanyRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return CompanyRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return CompanyRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return CompanyRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return CompanyRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return CompanyRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return CompanyRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return CompanyRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                CompanyRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)CompanyRow.Fields.CompanyId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return CompanyRow.Fields.CompanyName;
            }
        }

        public CompanyRow()
          : base((RowFieldsBase)CompanyRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field CompanyId;
            public StringField CompanyName;
            public StringField Address;
            public Int32Field CityId;
            public StringField PinCode;
            public StringField Website;
            public StringField CompanyLogo;
            public StringField CityCountry;
            public StringField CityState;
            public StringField City;
            public Int32Field CityStatusId;
            public Int32Field CityCreatedBy;
            public DateTimeField CityCreatedDate;
            public Int32Field CityUpdatedBy;
            public DateTimeField CityUpdatedDate;
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
            public StringField CreatedByFullName;
            public StringField UpdatedByFullName;

            public RowFields()
              : base((string)null, (string)null)
            {
                this.LocalTextPrefix = "Configuration.Company";
            }
        }
    }
}
