// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Entities.DesiccantRow
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
    [TableName("Desiccant")]
    [DisplayName("Desiccant")]
    [InstanceName("Desiccant")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("PackSettings:Desiccant:Read")]
    [ModifyPermission("PackSettings:Desiccant:Modify")]
    [LookupScript("PackSettings.Desiccant", Permission = "Lookup")]
    public sealed class DesiccantRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly DesiccantRow.RowFields Fields = new DesiccantRow.RowFields().Init<DesiccantRow.RowFields>();

        [DisplayName("Desiccant Id")]
        [Identity]
        public int? DesiccantId
        {
            get
            {
                return DesiccantRow.Fields.DesiccantId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.DesiccantId[(Row)this] = value;
            }
        }

        [DisplayName("Desiccant Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        public string DesiccantName
        {
            get
            {
                return DesiccantRow.Fields.DesiccantName[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.DesiccantName[(Row)this] = value;
            }
        }

        [DisplayName("Desiccant Type")]
        [ForeignKey("PickListValue", "PickListValueId")]
        [LeftJoin("jDesiccantType")]
        [TextualField("DesiccantTypePickListValueName")]
        [NotNull]
        public int? DesiccantTypeId
        {
            get
            {
                return DesiccantRow.Fields.DesiccantTypeId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.DesiccantTypeId[(Row)this] = value;
            }
        }

        [DisplayName("Desiccant Type")]
        [Expression("jDesiccantType.[PickListValueName]")]
        public string DesiccantTypePickListValueName
        {
            get
            {
                return DesiccantRow.Fields.DesiccantTypePickListValueName[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.DesiccantTypePickListValueName[(Row)this] = value;
            }
        }

        [DisplayName("Desiccant Type Status Id")]
        [Expression("jDesiccantType.[StatusId]")]
        public int? DesiccantTypeStatusId
        {
            get
            {
                return DesiccantRow.Fields.DesiccantTypeStatusId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.DesiccantTypeStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Grammage")]
        [Size(50)]
        [NotNull]
        public string Grammage
        {
            get
            {
                return DesiccantRow.Fields.Grammage[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.Grammage[(Row)this] = value;
            }
        }

        [DisplayName("Length Or Height")]
        [Size(50)]
        [NotNull]
        public string LengthOrHeight
        {
            get
            {
                return DesiccantRow.Fields.LengthOrHeight[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.LengthOrHeight[(Row)this] = value;
            }
        }

        [DisplayName("Diameter Or Width")]
        [Size(50)]
        [NotNull]
        public string DiameterOrWidth
        {
            get
            {
                return DesiccantRow.Fields.DiameterOrWidth[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.DiameterOrWidth[(Row)this] = value;
            }
        }

        [DisplayName("Identification")]
        [ForeignKey("PickListValue", "PickListValueId")]
        [LeftJoin("jIdentification")]
        [TextualField("IdentificationPickListValueName")]
        [NotNull]
        public int? Identification
        {
            get
            {
                return DesiccantRow.Fields.Identification[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.Identification[(Row)this] = value;
            }
        }

        [DisplayName("Identification")]
        [Expression("jIdentification.[PickListValueName]")]
        public string IdentificationPickListValueName
        {
            get
            {
                return DesiccantRow.Fields.IdentificationPickListValueName[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.IdentificationPickListValueName[(Row)this] = value;
            }
        }

        [DisplayName("Identification Status Id")]
        [Expression("jDesiccantType.[StatusId]")]
        public int? IdentificationStatusId
        {
            get
            {
                return DesiccantRow.Fields.IdentificationStatusId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.IdentificationStatusId[(Row)this] = value;
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
                return DesiccantRow.Fields.SupplierId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.SupplierId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier")]
        [Expression("jSupplier.[SupplierName]")]
        public string SupplierSupplierName
        {
            get
            {
                return DesiccantRow.Fields.SupplierSupplierName[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.SupplierSupplierName[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Supplier Address")]
        [Expression("jSupplier.[SupplierAddress]")]
        public string SupplierSupplierAddress
        {
            get
            {
                return DesiccantRow.Fields.SupplierSupplierAddress[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.SupplierSupplierAddress[(Row)this] = value;
            }
        }

        [DisplayName("Supplier City Id")]
        [Expression("jSupplier.[CityId]")]
        public int? SupplierCityId
        {
            get
            {
                return DesiccantRow.Fields.SupplierCityId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.SupplierCityId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Pin Code")]
        [Expression("jSupplier.[PinCode]")]
        public string SupplierPinCode
        {
            get
            {
                return DesiccantRow.Fields.SupplierPinCode[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.SupplierPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Mobile Code")]
        [Expression("jSupplier.[MobileCode]")]
        public int? SupplierMobileCode
        {
            get
            {
                return DesiccantRow.Fields.SupplierMobileCode[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.SupplierMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Mobile Number")]
        [Expression("jSupplier.[MobileNumber]")]
        public long? SupplierMobileNumber
        {
            get
            {
                return DesiccantRow.Fields.SupplierMobileNumber[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.SupplierMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Status Id")]
        [Expression("jSupplier.[StatusId]")]
        public int? SupplierStatusId
        {
            get
            {
                return DesiccantRow.Fields.SupplierStatusId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.SupplierStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Created By")]
        [Expression("jSupplier.[CreatedBy]")]
        public int? SupplierCreatedBy
        {
            get
            {
                return DesiccantRow.Fields.SupplierCreatedBy[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.SupplierCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Created Date")]
        [Expression("jSupplier.[CreatedDate]")]
        public DateTime? SupplierCreatedDate
        {
            get
            {
                return DesiccantRow.Fields.SupplierCreatedDate[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.SupplierCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Updated By")]
        [Expression("jSupplier.[UpdatedBy]")]
        public int? SupplierUpdatedBy
        {
            get
            {
                return DesiccantRow.Fields.SupplierUpdatedBy[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.SupplierUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Updated Date")]
        [Expression("jSupplier.[UpdatedDate]")]
        public DateTime? SupplierUpdatedDate
        {
            get
            {
                return DesiccantRow.Fields.SupplierUpdatedDate[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.SupplierUpdatedDate[(Row)this] = value;
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
                return DesiccantRow.Fields.StatusId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return DesiccantRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return DesiccantRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return DesiccantRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return DesiccantRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return DesiccantRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return DesiccantRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return DesiccantRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return DesiccantRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return DesiccantRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return DesiccantRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return DesiccantRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return DesiccantRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return DesiccantRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return DesiccantRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return DesiccantRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return DesiccantRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return DesiccantRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return DesiccantRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return DesiccantRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return DesiccantRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return DesiccantRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return DesiccantRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return DesiccantRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return DesiccantRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return DesiccantRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return DesiccantRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return DesiccantRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return DesiccantRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return DesiccantRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                DesiccantRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }


        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)DesiccantRow.Fields.DesiccantId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return DesiccantRow.Fields.DesiccantName;
            }
        }

        public DesiccantRow()
          : base((RowFieldsBase)DesiccantRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field DesiccantId;
            public StringField DesiccantName;
            public Int32Field DesiccantTypeId;
            public StringField Grammage;
            public StringField LengthOrHeight;
            public StringField DiameterOrWidth;
            public Int32Field Identification;
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
            public StringField DesiccantTypePickListValueName;
            public Int32Field DesiccantTypeStatusId;
            public StringField IdentificationPickListValueName;
            public Int32Field IdentificationStatusId;
            public StringField RecordAddedSource;

            public RowFields()
              : base((string)null, (string)null)
            {
                this.LocalTextPrefix = "PackSettings.Desiccant";
            }
        }
    }
}
