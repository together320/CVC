// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Entities.CapRow
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
    [TableName("Cap")]
    [DisplayName("Cap")]
    [InstanceName("Cap")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("PackSettings:Cap:Read")]
    [ModifyPermission("PackSettings:Cap:Modify")]
    [LookupScript("PackSettings.Cap", Permission = "Lookup")]
    public sealed class CapRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly CapRow.RowFields Fields = new CapRow.RowFields().Init<CapRow.RowFields>();

        [DisplayName("Cap Id")]
        [Identity]
        public int? CapId
        {
            get
            {
                return CapRow.Fields.CapId[(Row)this];
            }
            set
            {
                CapRow.Fields.CapId[(Row)this] = value;
            }
        }

        [DisplayName("Cap Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        public string CapName
        {
            get
            {
                return CapRow.Fields.CapName[(Row)this];
            }
            set
            {
                CapRow.Fields.CapName[(Row)this] = value;
            }
        }

        [DisplayName("Cap Cc")]
        [Column("CapCC")]
        [Size(50)]
        //[NotNull]
        public string CapCc
        {
            get
            {
                return CapRow.Fields.CapCc[(Row)this];
            }
            set
            {
                CapRow.Fields.CapCc[(Row)this] = value;
            }
        }

        [DisplayName("Cap Type")]
        [ForeignKey("PickListValue", "PickListValueId")]
        [LeftJoin("jCapType")]
        [TextualField("CapTypePickListValueName")]
        [NotNull]
        public int? CapTypeId
        {
            get
            {
                return CapRow.Fields.CapTypeId[(Row)this];
            }
            set
            {
                CapRow.Fields.CapTypeId[(Row)this] = value;
            }
        }

        [DisplayName("Cap Diameter")]
        [Size(50)]
        [NotNull]
        public string CapDiameter
        {
            get
            {
                return CapRow.Fields.CapDiameter[(Row)this];
            }
            set
            {
                CapRow.Fields.CapDiameter[(Row)this] = value;
            }
        }

        [DisplayName("Cap Height")]
        [Size(50)]
        [NotNull]
        public string CapHeight
        {
            get
            {
                return CapRow.Fields.CapHeight[(Row)this];
            }
            set
            {
                CapRow.Fields.CapHeight[(Row)this] = value;
            }
        }

        [DisplayName("Supplier")]
        [ForeignKey("Supplier", "SupplierId")]
        [LeftJoin("jSupplier")]
        [TextualField("SupplierSupplierName")]
        //commntednted on 25.07.2018 by Vinayak to remove required
        // [NotNull]
        public int? SupplierId
        {
            get
            {
                return CapRow.Fields.SupplierId[(Row)this];
            }
            set
            {
                CapRow.Fields.SupplierId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier")]
        [Expression("jSupplier.[SupplierName]")]
        public string SupplierSupplierName
        {
            get
            {
                return CapRow.Fields.SupplierSupplierName[(Row)this];
            }
            set
            {
                CapRow.Fields.SupplierSupplierName[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Supplier Address")]
        [Expression("jSupplier.[SupplierAddress]")]
        public string SupplierSupplierAddress
        {
            get
            {
                return CapRow.Fields.SupplierSupplierAddress[(Row)this];
            }
            set
            {
                CapRow.Fields.SupplierSupplierAddress[(Row)this] = value;
            }
        }

        [DisplayName("Supplier City Id")]
        [Expression("jSupplier.[CityId]")]
        public int? SupplierCityId
        {
            get
            {
                return CapRow.Fields.SupplierCityId[(Row)this];
            }
            set
            {
                CapRow.Fields.SupplierCityId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Pin Code")]
        [Expression("jSupplier.[PinCode]")]
        public string SupplierPinCode
        {
            get
            {
                return CapRow.Fields.SupplierPinCode[(Row)this];
            }
            set
            {
                CapRow.Fields.SupplierPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Mobile Code")]
        [Expression("jSupplier.[MobileCode]")]
        public int? SupplierMobileCode
        {
            get
            {
                return CapRow.Fields.SupplierMobileCode[(Row)this];
            }
            set
            {
                CapRow.Fields.SupplierMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Mobile Number")]
        [Expression("jSupplier.[MobileNumber]")]
        public long? SupplierMobileNumber
        {
            get
            {
                return CapRow.Fields.SupplierMobileNumber[(Row)this];
            }
            set
            {
                CapRow.Fields.SupplierMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Status Id")]
        [Expression("jSupplier.[StatusId]")]
        public int? SupplierStatusId
        {
            get
            {
                return CapRow.Fields.SupplierStatusId[(Row)this];
            }
            set
            {
                CapRow.Fields.SupplierStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Created By")]
        [Expression("jSupplier.[CreatedBy]")]
        public int? SupplierCreatedBy
        {
            get
            {
                return CapRow.Fields.SupplierCreatedBy[(Row)this];
            }
            set
            {
                CapRow.Fields.SupplierCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Created Date")]
        [Expression("jSupplier.[CreatedDate]")]
        public DateTime? SupplierCreatedDate
        {
            get
            {
                return CapRow.Fields.SupplierCreatedDate[(Row)this];
            }
            set
            {
                CapRow.Fields.SupplierCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Updated By")]
        [Expression("jSupplier.[UpdatedBy]")]
        public int? SupplierUpdatedBy
        {
            get
            {
                return CapRow.Fields.SupplierUpdatedBy[(Row)this];
            }
            set
            {
                CapRow.Fields.SupplierUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Updated Date")]
        [Expression("jSupplier.[UpdatedDate]")]
        public DateTime? SupplierUpdatedDate
        {
            get
            {
                return CapRow.Fields.SupplierUpdatedDate[(Row)this];
            }
            set
            {
                CapRow.Fields.SupplierUpdatedDate[(Row)this] = value;
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
                return CapRow.Fields.StatusId[(Row)this];
            }
            set
            {
                CapRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Cap Type Pick List Id")]
        [Expression("jCapType.[PickListId]")]
        public int? CapTypePickListId
        {
            get
            {
                return CapRow.Fields.CapTypePickListId[(Row)this];
            }
            set
            {
                CapRow.Fields.CapTypePickListId[(Row)this] = value;
            }
        }

        [DisplayName("Cap Type")]
        [Expression("jCapType.[PickListValueName]")]
        public string CapTypePickListValueName
        {
            get
            {
                return CapRow.Fields.CapTypePickListValueName[(Row)this];
            }
            set
            {
                CapRow.Fields.CapTypePickListValueName[(Row)this] = value;
            }
        }

        [DisplayName("Cap Type Status Id")]
        [Expression("jCapType.[StatusId]")]
        public int? CapTypeStatusId
        {
            get
            {
                return CapRow.Fields.CapTypeStatusId[(Row)this];
            }
            set
            {
                CapRow.Fields.CapTypeStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Cap Type Created By")]
        [Expression("jCapType.[CreatedBy]")]
        public int? CapTypeCreatedBy
        {
            get
            {
                return CapRow.Fields.CapTypeCreatedBy[(Row)this];
            }
            set
            {
                CapRow.Fields.CapTypeCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Cap Type Created Date")]
        [Expression("jCapType.[CreatedDate]")]
        public DateTime? CapTypeCreatedDate
        {
            get
            {
                return CapRow.Fields.CapTypeCreatedDate[(Row)this];
            }
            set
            {
                CapRow.Fields.CapTypeCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Cap Type Updated By")]
        [Expression("jCapType.[UpdatedBy]")]
        public int? CapTypeUpdatedBy
        {
            get
            {
                return CapRow.Fields.CapTypeUpdatedBy[(Row)this];
            }
            set
            {
                CapRow.Fields.CapTypeUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Cap Type Updated Date")]
        [Expression("jCapType.[UpdatedDate]")]
        public DateTime? CapTypeUpdatedDate
        {
            get
            {
                return CapRow.Fields.CapTypeUpdatedDate[(Row)this];
            }
            set
            {
                CapRow.Fields.CapTypeUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return CapRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                CapRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return CapRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return CapRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return CapRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return CapRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return CapRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return CapRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return CapRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return CapRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return CapRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return CapRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return CapRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return CapRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return CapRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return CapRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return CapRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return CapRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return CapRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return CapRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return CapRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return CapRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return CapRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return CapRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return CapRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return CapRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return CapRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                CapRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return CapRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return CapRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return CapRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return CapRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return CapRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return CapRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return CapRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return CapRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return CapRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return CapRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return CapRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return CapRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return CapRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return CapRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return CapRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return CapRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return CapRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return CapRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return CapRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return CapRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return CapRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return CapRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return CapRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return CapRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return CapRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                CapRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return CapRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                CapRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }


        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)CapRow.Fields.CapId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return CapRow.Fields.CapName;
            }
        }

        public CapRow()
          : base((RowFieldsBase)CapRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field CapId;
            public StringField CapName;
            public StringField CapCc;
            public Int32Field CapTypeId;
            public StringField CapDiameter;
            public StringField CapHeight;
            public Int32Field SupplierId;
            public Int32Field StatusId;
            public Int32Field CapTypePickListId;
            public StringField CapTypePickListValueName;
            public Int32Field CapTypeStatusId;
            public Int32Field CapTypeCreatedBy;
            public DateTimeField CapTypeCreatedDate;
            public Int32Field CapTypeUpdatedBy;
            public DateTimeField CapTypeUpdatedDate;
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
                this.LocalTextPrefix = "PackSettings.Cap";
            }
        }
    }
}
