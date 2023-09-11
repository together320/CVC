// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Entities.OutsertRow
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
    [TableName("Outsert")]
    [DisplayName("Outsert")]
    [InstanceName("Outsert")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("PackSettings:Outsert:Read")]
    [ModifyPermission("PackSettings:Outsert:Modify")]
    [LookupScript("PackSettings.Outsert", Permission = "Lookup")]
    public sealed class OutsertRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly OutsertRow.RowFields Fields = new OutsertRow.RowFields().Init<OutsertRow.RowFields>();

        [DisplayName("Outsert Id")]
        [Identity]
        public int? OutsertId
        {
            get
            {
                return OutsertRow.Fields.OutsertId[(Row)this];
            }
            set
            {
                OutsertRow.Fields.OutsertId[(Row)this] = value;
            }
        }

        [DisplayName("Outsert Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        public string OutsertName
        {
            get
            {
                return OutsertRow.Fields.OutsertName[(Row)this];
            }
            set
            {
                OutsertRow.Fields.OutsertName[(Row)this] = value;
            }
        }

        [DisplayName("Outsert Length")]
        [Size(50)]
        [NotNull]
        public string OutsertLength
        {
            get
            {
                return OutsertRow.Fields.OutsertLength[(Row)this];
            }
            set
            {
                OutsertRow.Fields.OutsertLength[(Row)this] = value;
            }
        }

        [DisplayName("Outsert Width")]
        [Size(50)]
        [NotNull]
        public string OutsertWidth
        {
            get
            {
                return OutsertRow.Fields.OutsertWidth[(Row)this];
            }
            set
            {
                OutsertRow.Fields.OutsertWidth[(Row)this] = value;
            }
        }

        [DisplayName("Outsert Thickness")]
        [Size(50)]
        [NotNull]
        public string OutsertThickness
        {
            get
            {
                return OutsertRow.Fields.OutsertThickness[(Row)this];
            }
            set
            {
                OutsertRow.Fields.OutsertThickness[(Row)this] = value;
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
                return OutsertRow.Fields.SupplierId[(Row)this];
            }
            set
            {
                OutsertRow.Fields.SupplierId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier")]
        [Expression("jSupplier.[SupplierName]")]
        public string SupplierSupplierName
        {
            get
            {
                return OutsertRow.Fields.SupplierSupplierName[(Row)this];
            }
            set
            {
                OutsertRow.Fields.SupplierSupplierName[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Supplier Address")]
        [Expression("jSupplier.[SupplierAddress]")]
        public string SupplierSupplierAddress
        {
            get
            {
                return OutsertRow.Fields.SupplierSupplierAddress[(Row)this];
            }
            set
            {
                OutsertRow.Fields.SupplierSupplierAddress[(Row)this] = value;
            }
        }

        [DisplayName("Supplier City Id")]
        [Expression("jSupplier.[CityId]")]
        public int? SupplierCityId
        {
            get
            {
                return OutsertRow.Fields.SupplierCityId[(Row)this];
            }
            set
            {
                OutsertRow.Fields.SupplierCityId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Pin Code")]
        [Expression("jSupplier.[PinCode]")]
        public string SupplierPinCode
        {
            get
            {
                return OutsertRow.Fields.SupplierPinCode[(Row)this];
            }
            set
            {
                OutsertRow.Fields.SupplierPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Mobile Code")]
        [Expression("jSupplier.[MobileCode]")]
        public int? SupplierMobileCode
        {
            get
            {
                return OutsertRow.Fields.SupplierMobileCode[(Row)this];
            }
            set
            {
                OutsertRow.Fields.SupplierMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Mobile Number")]
        [Expression("jSupplier.[MobileNumber]")]
        public long? SupplierMobileNumber
        {
            get
            {
                return OutsertRow.Fields.SupplierMobileNumber[(Row)this];
            }
            set
            {
                OutsertRow.Fields.SupplierMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Status Id")]
        [Expression("jSupplier.[StatusId]")]
        [NotNull]
        public int? SupplierStatusId
        {
            get
            {
                return OutsertRow.Fields.SupplierStatusId[(Row)this];
            }
            set
            {
                OutsertRow.Fields.SupplierStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Created By")]
        [Expression("jSupplier.[CreatedBy]")]
        public int? SupplierCreatedBy
        {
            get
            {
                return OutsertRow.Fields.SupplierCreatedBy[(Row)this];
            }
            set
            {
                OutsertRow.Fields.SupplierCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Created Date")]
        [Expression("jSupplier.[CreatedDate]")]
        public DateTime? SupplierCreatedDate
        {
            get
            {
                return OutsertRow.Fields.SupplierCreatedDate[(Row)this];
            }
            set
            {
                OutsertRow.Fields.SupplierCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Updated By")]
        [Expression("jSupplier.[UpdatedBy]")]
        public int? SupplierUpdatedBy
        {
            get
            {
                return OutsertRow.Fields.SupplierUpdatedBy[(Row)this];
            }
            set
            {
                OutsertRow.Fields.SupplierUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Updated Date")]
        [Expression("jSupplier.[UpdatedDate]")]
        public DateTime? SupplierUpdatedDate
        {
            get
            {
                return OutsertRow.Fields.SupplierUpdatedDate[(Row)this];
            }
            set
            {
                OutsertRow.Fields.SupplierUpdatedDate[(Row)this] = value;
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
                return OutsertRow.Fields.StatusId[(Row)this];
            }
            set
            {
                OutsertRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return OutsertRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                OutsertRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return OutsertRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return OutsertRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return OutsertRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return OutsertRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return OutsertRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return OutsertRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return OutsertRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return OutsertRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return OutsertRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return OutsertRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return OutsertRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return OutsertRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return OutsertRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return OutsertRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return OutsertRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return OutsertRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return OutsertRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return OutsertRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return OutsertRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return OutsertRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return OutsertRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return OutsertRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return OutsertRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return OutsertRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return OutsertRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                OutsertRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return OutsertRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return OutsertRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return OutsertRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return OutsertRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return OutsertRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return OutsertRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return OutsertRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return OutsertRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return OutsertRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return OutsertRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return OutsertRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return OutsertRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return OutsertRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return OutsertRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return OutsertRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return OutsertRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return OutsertRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return OutsertRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return OutsertRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return OutsertRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return OutsertRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return OutsertRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return OutsertRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return OutsertRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return OutsertRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                OutsertRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return OutsertRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                OutsertRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }


        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)OutsertRow.Fields.OutsertId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return OutsertRow.Fields.OutsertName;
            }
        }

        public OutsertRow()
          : base((RowFieldsBase)OutsertRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field OutsertId;
            public StringField OutsertName;
            public StringField OutsertLength;
            public StringField OutsertWidth;
            public StringField OutsertThickness;
            public Int32Field SupplierId;
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
            public StringField RecordAddedSource;

           
            public RowFields()
              : base((string)null, (string)null)
            {
                this.LocalTextPrefix = "PackSettings.Outsert";
            }
        }
    }
}
