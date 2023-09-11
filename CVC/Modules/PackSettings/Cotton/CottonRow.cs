// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Entities.CottonRow
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
    [TableName("Cotton")]
    [DisplayName("Cotton")]
    [InstanceName("Cotton")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("PackSettings:Cotton:Read")]
    [ModifyPermission("PackSettings:Cotton:Modify")]
    [LookupScript("PackSettings.Cotton", Permission = "Lookup")]
    public sealed class CottonRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly CottonRow.RowFields Fields = new CottonRow.RowFields().Init<CottonRow.RowFields>();

        [DisplayName("Cotton")]
        [Identity]
        [ForeignKey("Status", "StatusId")]
        [LeftJoin("jCotton")]
        [TextualField("CottonStatusName")]
        public int? CottonId
        {
            get
            {
                return CottonRow.Fields.CottonId[(Row)this];
            }
            set
            {
                CottonRow.Fields.CottonId[(Row)this] = value;
            }
        }

        [DisplayName("Cotton Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string CottonName
        {
            get
            {
                return CottonRow.Fields.CottonName[(Row)this];
            }
            set
            {
                CottonRow.Fields.CottonName[(Row)this] = value;
            }
        }

        [DisplayName("Cotton Type Id")]
        [ForeignKey("PickListValue", "PickListValueId")]
        [LeftJoin("jCottonType")]
        [TextualField("CottonTypePickListValueName")]
        [NotNull]
        public int? CottonTypeId
        {
            get
            {
                return CottonRow.Fields.CottonTypeId[(Row)this];
            }
            set
            {
                CottonRow.Fields.CottonTypeId[(Row)this] = value;
            }
        }

        [DisplayName("Cotton Type Pick List Id")]
        [Expression("jCottonType.[PickListId]")]
        public int? CottonTypePickListId
        {
            get
            {
                return CottonRow.Fields.CottonTypePickListId[(Row)this];
            }
            set
            {
                CottonRow.Fields.CottonTypePickListId[(Row)this] = value;
            }
        }

        [DisplayName("Cotton Type")]
        [Expression("jCottonType.[PickListValueName]")]
        public string CottonTypePickListValueName
        {
            get
            {
                return CottonRow.Fields.CottonTypePickListValueName[(Row)this];
            }
            set
            {
                CottonRow.Fields.CottonTypePickListValueName[(Row)this] = value;
            }
        }

        [DisplayName("Cotton Type Status Id")]
        [Expression("jCottonType.[StatusId]")]
        public int? CottonTypeStatusId
        {
            get
            {
                return CottonRow.Fields.CottonTypeStatusId[(Row)this];
            }
            set
            {
                CottonRow.Fields.CottonTypeStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Cotton Type Created By")]
        [Expression("jCottonType.[CreatedBy]")]
        public int? CottonTypeCreatedBy
        {
            get
            {
                return CottonRow.Fields.CottonTypeCreatedBy[(Row)this];
            }
            set
            {
                CottonRow.Fields.CottonTypeCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Cotton Type Created Date")]
        [Expression("jCottonType.[CreatedDate]")]
        public DateTime? CottonTypeCreatedDate
        {
            get
            {
                return CottonRow.Fields.CottonTypeCreatedDate[(Row)this];
            }
            set
            {
                CottonRow.Fields.CottonTypeCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Cotton Type Updated By")]
        [Expression("jCottonType.[UpdatedBy]")]
        public int? CottonTypeUpdatedBy
        {
            get
            {
                return CottonRow.Fields.CottonTypeUpdatedBy[(Row)this];
            }
            set
            {
                CottonRow.Fields.CottonTypeUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Cotton Type Updated Date")]
        [Expression("jCottonType.[UpdatedDate]")]
        public DateTime? CottonTypeUpdatedDate
        {
            get
            {
                return CottonRow.Fields.CottonTypeUpdatedDate[(Row)this];
            }
            set
            {
                CottonRow.Fields.CottonTypeUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Gm Or Yard")]
        [Size(50)]
        [NotNull]
        public string GmOrYard
        {
            get
            {
                return CottonRow.Fields.GmOrYard[(Row)this];
            }
            set
            {
                CottonRow.Fields.GmOrYard[(Row)this] = value;
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
                return CottonRow.Fields.SupplierId[(Row)this];
            }
            set
            {
                CottonRow.Fields.SupplierId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier")]
        [Expression("jSupplier.[SupplierName]")]
        public string SupplierSupplierName
        {
            get
            {
                return CottonRow.Fields.SupplierSupplierName[(Row)this];
            }
            set
            {
                CottonRow.Fields.SupplierSupplierName[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Supplier Address")]
        [Expression("jSupplier.[SupplierAddress]")]
        public string SupplierSupplierAddress
        {
            get
            {
                return CottonRow.Fields.SupplierSupplierAddress[(Row)this];
            }
            set
            {
                CottonRow.Fields.SupplierSupplierAddress[(Row)this] = value;
            }
        }

        [DisplayName("Supplier City Id")]
        [Expression("jSupplier.[CityId]")]
        public int? SupplierCityId
        {
            get
            {
                return CottonRow.Fields.SupplierCityId[(Row)this];
            }
            set
            {
                CottonRow.Fields.SupplierCityId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Pin Code")]
        [Expression("jSupplier.[PinCode]")]
        public string SupplierPinCode
        {
            get
            {
                return CottonRow.Fields.SupplierPinCode[(Row)this];
            }
            set
            {
                CottonRow.Fields.SupplierPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Mobile Code")]
        [Expression("jSupplier.[MobileCode]")]
        public int? SupplierMobileCode
        {
            get
            {
                return CottonRow.Fields.SupplierMobileCode[(Row)this];
            }
            set
            {
                CottonRow.Fields.SupplierMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Mobile Number")]
        [Expression("jSupplier.[MobileNumber]")]
        public long? SupplierMobileNumber
        {
            get
            {
                return CottonRow.Fields.SupplierMobileNumber[(Row)this];
            }
            set
            {
                CottonRow.Fields.SupplierMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Status Id")]
        [Expression("jSupplier.[StatusId]")]
        public int? SupplierStatusId
        {
            get
            {
                return CottonRow.Fields.SupplierStatusId[(Row)this];
            }
            set
            {
                CottonRow.Fields.SupplierStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Created By")]
        [Expression("jSupplier.[CreatedBy]")]
        public int? SupplierCreatedBy
        {
            get
            {
                return CottonRow.Fields.SupplierCreatedBy[(Row)this];
            }
            set
            {
                CottonRow.Fields.SupplierCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Created Date")]
        [Expression("jSupplier.[CreatedDate]")]
        public DateTime? SupplierCreatedDate
        {
            get
            {
                return CottonRow.Fields.SupplierCreatedDate[(Row)this];
            }
            set
            {
                CottonRow.Fields.SupplierCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Updated By")]
        [Expression("jSupplier.[UpdatedBy]")]
        public int? SupplierUpdatedBy
        {
            get
            {
                return CottonRow.Fields.SupplierUpdatedBy[(Row)this];
            }
            set
            {
                CottonRow.Fields.SupplierUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Updated Date")]
        [Expression("jSupplier.[UpdatedDate]")]
        public DateTime? SupplierUpdatedDate
        {
            get
            {
                return CottonRow.Fields.SupplierUpdatedDate[(Row)this];
            }
            set
            {
                CottonRow.Fields.SupplierUpdatedDate[(Row)this] = value;
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
                return CottonRow.Fields.StatusId[(Row)this];
            }
            set
            {
                CottonRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return CottonRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                CottonRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Cotton Status Name")]
        [Expression("jCotton.[StatusName]")]
        public string CottonStatusName
        {
            get
            {
                return CottonRow.Fields.CottonStatusName[(Row)this];
            }
            set
            {
                CottonRow.Fields.CottonStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return CottonRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return CottonRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return CottonRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return CottonRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return CottonRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return CottonRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return CottonRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return CottonRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return CottonRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return CottonRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return CottonRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return CottonRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return CottonRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return CottonRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return CottonRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return CottonRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return CottonRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return CottonRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return CottonRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return CottonRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return CottonRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return CottonRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return CottonRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return CottonRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return CottonRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                CottonRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return CottonRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return CottonRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return CottonRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return CottonRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return CottonRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return CottonRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return CottonRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return CottonRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return CottonRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return CottonRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return CottonRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return CottonRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return CottonRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return CottonRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return CottonRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return CottonRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return CottonRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return CottonRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return CottonRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return CottonRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return CottonRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return CottonRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return CottonRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return CottonRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return CottonRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                CottonRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return CottonRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                CottonRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)CottonRow.Fields.CottonId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return CottonRow.Fields.CottonName;
            }
        }

        public CottonRow()
          : base((RowFieldsBase)CottonRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field CottonId;
            public StringField CottonName;
            public Int32Field CottonTypeId;
            public StringField GmOrYard;
            public Int32Field SupplierId;
            public Int32Field StatusId;
            public StringField CottonStatusName;
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
            public Int32Field CottonTypePickListId;
            public StringField CottonTypePickListValueName;
            public Int32Field CottonTypeStatusId;
            public Int32Field CottonTypeCreatedBy;
            public DateTimeField CottonTypeCreatedDate;
            public Int32Field CottonTypeUpdatedBy;
            public DateTimeField CottonTypeUpdatedDate;
            public StringField StatusStatusName;
            public StringField RecordAddedSource;

            public RowFields()
              : base((string)null, (string)null)
            {
                this.LocalTextPrefix = "PackSettings.Cotton";
            }
        }
    }
}
