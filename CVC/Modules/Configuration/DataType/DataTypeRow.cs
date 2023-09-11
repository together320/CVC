// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Entities.DataTypeRow
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
    [TableName("DataType")]
    [DisplayName("Data Type")]
    [InstanceName("Data Type")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Lookup")]
    [ModifyPermission("Lookup")]
    [LookupScript("Configuration.DataType", Permission = "Lookup")]
    public sealed class DataTypeRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly DataTypeRow.RowFields Fields = new DataTypeRow.RowFields().Init<DataTypeRow.RowFields>();

        [DisplayName("Data Type Id")]
        [Identity]
        public int? DataTypeId
        {
            get
            {
                return DataTypeRow.Fields.DataTypeId[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.DataTypeId[(Row)this] = value;
            }
        }

        [DisplayName("Data Type Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string DataTypeName
        {
            get
            {
                return DataTypeRow.Fields.DataTypeName[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.DataTypeName[(Row)this] = value;
            }
        }

        [DisplayName("Type Id")]
        public int? TypeId
        {
            get
            {
                return DataTypeRow.Fields.TypeId[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.TypeId[(Row)this] = value;
            }
        }

        [DisplayName("Bit")]
        public int? Bit
        {
            get
            {
                return DataTypeRow.Fields.Bit[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.Bit[(Row)this] = value;
            }
        }

        [DisplayName("Is Signed")]
        [Column("isSigned")]
        public bool? IsSigned
        {
            get
            {
                return DataTypeRow.Fields.IsSigned[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.IsSigned[(Row)this] = value;
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
                return DataTypeRow.Fields.StatusId[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.StatusId[(Row)this] = value;
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
                return DataTypeRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return DataTypeRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedDate[(Row)this] = value;
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
                return DataTypeRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return DataTypeRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return DataTypeRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return DataTypeRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return DataTypeRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return DataTypeRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return DataTypeRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return DataTypeRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return DataTypeRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return DataTypeRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return DataTypeRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return DataTypeRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return DataTypeRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return DataTypeRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return DataTypeRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return DataTypeRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return DataTypeRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return DataTypeRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return DataTypeRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return DataTypeRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return DataTypeRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return DataTypeRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return DataTypeRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return DataTypeRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return DataTypeRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return DataTypeRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return DataTypeRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return DataTypeRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return DataTypeRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return DataTypeRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                DataTypeRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)DataTypeRow.Fields.DataTypeId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return DataTypeRow.Fields.DataTypeName;
            }
        }

        public DataTypeRow()
          : base((RowFieldsBase)DataTypeRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field DataTypeId;
            public StringField DataTypeName;
            public Int32Field TypeId;
            public Int32Field Bit;
            public BooleanField IsSigned;
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

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "MachineCustomization.DataType";
            }
        }
    }
}
