// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Entities.LabelRow
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

namespace CVC.PackSettings.Entities
{
    [ConnectionKey("Default")]
    [TableName("Label")]
    [DisplayName("Label")]
    [InstanceName("Label")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("PackSettings:Label:Read")]
    [ModifyPermission("PackSettings:Label:Modify")]
    [LookupScript("PackSettings.Label", Permission = "Lookup")]
    public sealed class LabelRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly LabelRow.RowFields Fields = new LabelRow.RowFields().Init<LabelRow.RowFields>();

        [DisplayName("Label Id")]
        [Identity]
        public int? LabelId
        {
            get
            {
                return LabelRow.Fields.LabelId[(Row)this];
            }
            set
            {
                LabelRow.Fields.LabelId[(Row)this] = value;
            }
        }

        [DisplayName("Label Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        public string LabelName
        {
            get
            {
                return LabelRow.Fields.LabelName[(Row)this];
            }
            set
            {
                LabelRow.Fields.LabelName[(Row)this] = value;
            }
        }

        [DisplayName("Label Length")]
        [Size(50)]
        [NotNull]
        public string LabelLength
        {
            get
            {
                return LabelRow.Fields.LabelLength[(Row)this];
            }
            set
            {
                LabelRow.Fields.LabelLength[(Row)this] = value;
            }
        }

        [DisplayName("Label Height")]
        [Size(50)]
        [NotNull]
        public string LabelHeight
        {
            get
            {
                return LabelRow.Fields.LabelHeight[(Row)this];
            }
            set
            {
                LabelRow.Fields.LabelHeight[(Row)this] = value;
            }
        }

        [DisplayName("Label Type")]
        [Size(50)]
        [NotNull]
        public string LabelType
        {
            get
            {
                return LabelRow.Fields.LabelType[(Row)this];
            }
            set
            {
                LabelRow.Fields.LabelType[(Row)this] = value;
            }
        }

        [DisplayName("Label Image")]
        [Size(500)]
        [ImageUploadEditor(CopyToHistory = true, FilenameFormat = "LabelImage/~")]
        public string LabelImage
        {
            get
            {
                return LabelRow.Fields.LabelImage[(Row)this];
            }
            set
            {
                LabelRow.Fields.LabelImage[(Row)this] = value;
            }
        }

        [DisplayName("Supplier")]
        [ForeignKey("Supplier", "SupplierId")]
        [LeftJoin("jSupplier")]
        [TextualField("SupplierSupplierName")]
        //commntednted on 25.07.2018 by Vinayak to remove required
        //[NotNull]
        public int? SupplierId
        {
            get
            {
                return LabelRow.Fields.SupplierId[(Row)this];
            }
            set
            {
                LabelRow.Fields.SupplierId[(Row)this] = value;
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
                return LabelRow.Fields.StatusId[(Row)this];
            }
            set
            {
                LabelRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier")]
        [Expression("jSupplier.[SupplierName]")]
        public string SupplierSupplierName
        {
            get
            {
                return LabelRow.Fields.SupplierSupplierName[(Row)this];
            }
            set
            {
                LabelRow.Fields.SupplierSupplierName[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Supplier Address")]
        [Expression("jSupplier.[SupplierAddress]")]
        public string SupplierSupplierAddress
        {
            get
            {
                return LabelRow.Fields.SupplierSupplierAddress[(Row)this];
            }
            set
            {
                LabelRow.Fields.SupplierSupplierAddress[(Row)this] = value;
            }
        }

        [DisplayName("Supplier City Id")]
        [Expression("jSupplier.[CityId]")]
        public int? SupplierCityId
        {
            get
            {
                return LabelRow.Fields.SupplierCityId[(Row)this];
            }
            set
            {
                LabelRow.Fields.SupplierCityId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Pin Code")]
        [Expression("jSupplier.[PinCode]")]
        public string SupplierPinCode
        {
            get
            {
                return LabelRow.Fields.SupplierPinCode[(Row)this];
            }
            set
            {
                LabelRow.Fields.SupplierPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Mobile Code")]
        [Expression("jSupplier.[MobileCode]")]
        public int? SupplierMobileCode
        {
            get
            {
                return LabelRow.Fields.SupplierMobileCode[(Row)this];
            }
            set
            {
                LabelRow.Fields.SupplierMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Mobile Number")]
        [Expression("jSupplier.[MobileNumber]")]
        public long? SupplierMobileNumber
        {
            get
            {
                return LabelRow.Fields.SupplierMobileNumber[(Row)this];
            }
            set
            {
                LabelRow.Fields.SupplierMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Status Id")]
        [Expression("jSupplier.[StatusId]")]
        public int? SupplierStatusId
        {
            get
            {
                return LabelRow.Fields.SupplierStatusId[(Row)this];
            }
            set
            {
                LabelRow.Fields.SupplierStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Created By")]
        [Expression("jSupplier.[CreatedBy]")]
        public int? SupplierCreatedBy
        {
            get
            {
                return LabelRow.Fields.SupplierCreatedBy[(Row)this];
            }
            set
            {
                LabelRow.Fields.SupplierCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Created Date")]
        [Expression("jSupplier.[CreatedDate]")]
        public DateTime? SupplierCreatedDate
        {
            get
            {
                return LabelRow.Fields.SupplierCreatedDate[(Row)this];
            }
            set
            {
                LabelRow.Fields.SupplierCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Updated By")]
        [Expression("jSupplier.[UpdatedBy]")]
        public int? SupplierUpdatedBy
        {
            get
            {
                return LabelRow.Fields.SupplierUpdatedBy[(Row)this];
            }
            set
            {
                LabelRow.Fields.SupplierUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Updated Date")]
        [Expression("jSupplier.[UpdatedDate]")]
        public DateTime? SupplierUpdatedDate
        {
            get
            {
                return LabelRow.Fields.SupplierUpdatedDate[(Row)this];
            }
            set
            {
                LabelRow.Fields.SupplierUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return LabelRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                LabelRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return LabelRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return LabelRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return LabelRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return LabelRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return LabelRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return LabelRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return LabelRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return LabelRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return LabelRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return LabelRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return LabelRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return LabelRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return LabelRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return LabelRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return LabelRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return LabelRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return LabelRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return LabelRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return LabelRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return LabelRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return LabelRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return LabelRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return LabelRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return LabelRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return LabelRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                LabelRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return LabelRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return LabelRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return LabelRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return LabelRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return LabelRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return LabelRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return LabelRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return LabelRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return LabelRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return LabelRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return LabelRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return LabelRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return LabelRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return LabelRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return LabelRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return LabelRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return LabelRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return LabelRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return LabelRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return LabelRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return LabelRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return LabelRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return LabelRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return LabelRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return LabelRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                LabelRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return LabelRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                LabelRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)LabelRow.Fields.LabelId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return LabelRow.Fields.LabelName;
            }
        }

        public LabelRow()
          : base((RowFieldsBase)LabelRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field LabelId;
            public StringField LabelName;
            public StringField LabelLength;
            public StringField LabelHeight;
            public StringField LabelType;
            public StringField LabelImage;
            public Int32Field SupplierId;
            public Int32Field StatusId;
            public StringField SupplierSupplierName;
            public StringField SupplierSupplierAddress;
            public Int32Field SupplierCityId;
            public StringField SupplierPinCode;
            public Int32Field SupplierMobileCode;
            public Int64Field SupplierMobileNumber;
            public Int32Field SupplierStatusId;
            public Int32Field SupplierCreatedBy;
            public DateTimeField SupplierCreatedDate;
            public Int32Field SupplierUpdatedBy;
            public DateTimeField SupplierUpdatedDate;
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
                this.LocalTextPrefix = "PackSettings.Label";
            }
        }
    }
}
