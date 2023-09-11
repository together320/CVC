// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Entities.CurrencyRow
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

namespace CVC.Configuration.Entities
{
    [ConnectionKey("Default")]
    [TableName("Currency")]
    [DisplayName("Currency")]
    [InstanceName("Currency")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Lookup")]
    [ModifyPermission("Lookup")]
    [LookupScript("Configuration.Currency", Permission = "Lookup")]
    public sealed class CurrencyRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly CurrencyRow.RowFields Fields = new CurrencyRow.RowFields().Init<CurrencyRow.RowFields>();



        [DisplayName("Currency Id")]
        [Identity]
        public int? CurrencyId
        {
            get
            {


                return CurrencyRow.Fields.CurrencyId[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CurrencyId[(Row)this] = value;
            }
        }

        [DisplayName("Country Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string CountryName
        {
            get
            {
                return CurrencyRow.Fields.CountryName[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CountryName[(Row)this] = value;
            }
        }

        [DisplayName("Currency Type")]
        [Size(50)]
        public string CurrencyType
        {
            get
            {
                return CurrencyRow.Fields.CurrencyType[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CurrencyType[(Row)this] = value;
            }
        }

        [DisplayName("Symbol")]
        [Size(100)]
        public string Symbol
        {
            get
            {
                return CurrencyRow.Fields.Symbol[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.Symbol[(Row)this] = value;
            }
        }

        [DisplayName("Description")]
        [Size(50)]
        public string Description
        {
            get
            {
                return CurrencyRow.Fields.Description[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.Description[(Row)this] = value;
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
                return CurrencyRow.Fields.StatusId[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.StatusId[(Row)this] = value;
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
                return CurrencyRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return CurrencyRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedDate[(Row)this] = value;
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
                return CurrencyRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return CurrencyRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return CurrencyRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return CurrencyRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return CurrencyRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return CurrencyRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("(jCreatedBy.FirstName)")]
        public string CreatedByFullName
        {
            get
            {
                return CurrencyRow.Fields.CreatedByFullName[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByFullName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return CurrencyRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return CurrencyRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return CurrencyRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return CurrencyRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return CurrencyRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return CurrencyRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return CurrencyRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return CurrencyRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return CurrencyRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return CurrencyRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return CurrencyRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return CurrencyRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return CurrencyRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return CurrencyRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return CurrencyRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return CurrencyRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return CurrencyRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return CurrencyRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return CurrencyRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return CurrencyRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return CurrencyRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return CurrencyRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return CurrencyRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return CurrencyRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                CurrencyRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)CurrencyRow.Fields.CurrencyId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return CurrencyRow.Fields.CountryName;
            }
        }

        public CurrencyRow()
          : base((RowFieldsBase)CurrencyRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CurrencyId;
            public StringField CountryName;
            public StringField CurrencyType;
            public StringField Symbol;
            public StringField Description;
            public Int32Field StatusId;
            public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;
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
            public StringField CreatedByFullName;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Configuration.Currency";
            }
        }
    }
}
