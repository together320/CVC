// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Entities.BottleRow
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
using System.Linq;

namespace CVC.PackSettings.Entities
{

    public class BottleDisplayNameAttribute:DisplayNameAttribute
    {
        public BottleDisplayNameAttribute(string value):base(GetBottleNamefromPicklist(value))
        { }

        private static string GetBottleNamefromPicklist(string value)
        {
            string strBottle = string.Empty;
            using (CVC.Data.EDMX.CVCEntities cvcEntities = new CVC.Data.EDMX.CVCEntities())
            {
                var PickListId = cvcEntities.PickLists?.FirstOrDefault(pl => pl.PickListName.ToUpper() == "BOTTLE")?.PickListId ?? null;
                if (PickListId != null)
                {
                    strBottle = cvcEntities.PickListValues?.FirstOrDefault(pl => pl.PickListId == PickListId)?.PickListValueName ?? "Bottle";
                }
            }
            return strBottle + " " + value;
        }
    }

    public class PackDisplayNameAttribute : DisplayNameAttribute
    {
        public PackDisplayNameAttribute(string value) : base(GetPackNamefromPicklist(value))
        { }

        private static string GetPackNamefromPicklist(string value)
        {
            string strPack = string.Empty;
            using (CVC.Data.EDMX.CVCEntities cvcEntities = new CVC.Data.EDMX.CVCEntities())
            {
                var PickListId = cvcEntities.PickLists?.FirstOrDefault(pl => pl.PickListName.ToUpper() == "PACK")?.PickListId ?? null;
                if (PickListId != null)
                {
                    strPack = cvcEntities.PickListValues?.FirstOrDefault(pl => pl.PickListId == PickListId)?.PickListValueName ?? "Pack ID";
                }
            }
            return strPack + " " + value;
        }
    }

    public class BottleInstanceNameAttribute : InstanceNameAttribute
    {
        public BottleInstanceNameAttribute(string value) : base(GetBottleNameInstancefromPicklist(value))
        { }

        private static string GetBottleNameInstancefromPicklist(string value)
        {
            string strBottle = string.Empty;
            using (CVC.Data.EDMX.CVCEntities cvcEntities = new CVC.Data.EDMX.CVCEntities())
            {
                var PickListId = cvcEntities.PickLists?.FirstOrDefault(pl => pl.PickListName.ToUpper() == "BOTTLE")?.PickListId ?? null;
                if (PickListId != null)
                {
                    strBottle = cvcEntities.PickListValues?.FirstOrDefault(pl => pl.PickListId == PickListId)?.PickListValueName ?? "Bottle";
                }
            }
            return strBottle + " " + value;
        }
    }

    [ConnectionKey("Default")]
    [TableName("Bottle")]
    //[DisplayName("Bottle")]
    [BottleDisplayName("")]
   // [InstanceName("Bottle")]
    [BottleInstanceName("")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("PackSettings:Bottle:Read")]
    [ModifyPermission("PackSettings:Bottle:Modify")]
    [LookupScript("PackSettings.Bottle", Permission = "Lookup")]
    public sealed class BottleRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly BottleRow.RowFields Fields = new BottleRow.RowFields().Init<BottleRow.RowFields>();

        [DisplayName("Bottle Id")]
        [Identity]
        public int? BottleId
        {
            get
            {
                return BottleRow.Fields.BottleId[(Row)this];
            }
            set
            {
                BottleRow.Fields.BottleId[(Row)this] = value;
            }
        }

        //[DisplayName("Bottle Name")]
        [BottleDisplayName("Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        public string BottleName
        {
            get
            {
                return BottleRow.Fields.BottleName[(Row)this];
            }
            set
            {
                BottleRow.Fields.BottleName[(Row)this] = value;
            }
        }

        //[DisplayName("Bottle Cc")]
        [BottleDisplayName("Cc")]
        [Column("BottleCC")]
        [Size(50)]
       // [NotNull]
        public string BottleCc
        {
            get
            {
                return BottleRow.Fields.BottleCc[(Row)this];
            }
            set
            {
                BottleRow.Fields.BottleCc[(Row)this] = value;
            }
        }

        [DisplayName("Container Type")]
        [ForeignKey("PickListValue", "PickListValueId")]
        [LeftJoin("jContainerType")]
        [TextualField("ContainerTypePickListValueName")]
       // [NotNull]
        public int? ContainerTypeId
        {
            get
            {
                return BottleRow.Fields.ContainerTypeId[(Row)this];
            }
            set
            {
                BottleRow.Fields.ContainerTypeId[(Row)this] = value;
            }
        }

        [DisplayName("ContainerType Pick List Id")]
        [Expression("jContainerType.[PickListId]")]
        public int? ContainerTypePickListId
        {
            get
            {
                return BottleRow.Fields.ContainerTypePickListId[(Row)this];
            }
            set
            {
                BottleRow.Fields.ContainerTypePickListId[(Row)this] = value;
            }
        }

        [DisplayName("Container Type")]
        [Expression("jContainerType.[PickListValueName]")]
        public string ContainerTypePickListValueName
        {
            get
            {
                return BottleRow.Fields.ContainerTypePickListValueName[(Row)this];
            }
            set
            {
                BottleRow.Fields.ContainerTypePickListValueName[(Row)this] = value;
            }
        }

        [DisplayName("ContainerType Status Id")]
        [Expression("jContainerType.[StatusId]")]
        public int? ContainerTypeStatusId
        {
            get
            {
                return BottleRow.Fields.ContainerTypeStatusId[(Row)this];
            }
            set
            {
                BottleRow.Fields.ContainerTypeStatusId[(Row)this] = value;
            }
        }

        [DisplayName("ContainerType Created By")]
        [Expression("jContainerType.[CreatedBy]")]
        public int? ContainerTypeCreatedBy
        {
            get
            {
                return BottleRow.Fields.ContainerTypeCreatedBy[(Row)this];
            }
            set
            {
                BottleRow.Fields.ContainerTypeCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("ContainerType Created Date")]
        [Expression("jContainerType.[CreatedDate]")]
        public DateTime? ContainerTypeCreatedDate
        {
            get
            {
                return BottleRow.Fields.ContainerTypeCreatedDate[(Row)this];
            }
            set
            {
                BottleRow.Fields.ContainerTypeCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("ContainerType Updated By")]
        [Expression("jContainerType.[UpdatedBy]")]
        public int? ContainerTypeUpdatedBy
        {
            get
            {
                return BottleRow.Fields.ContainerTypeUpdatedBy[(Row)this];
            }
            set
            {
                BottleRow.Fields.ContainerTypeUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("ContainerType Updated Date")]
        [Expression("jContainerType.[UpdatedDate]")]
        public DateTime? ContainerTypeUpdatedDate
        {
            get
            {
                return BottleRow.Fields.ContainerTypeUpdatedDate[(Row)this];
            }
            set
            {
                BottleRow.Fields.ContainerTypeUpdatedDate[(Row)this] = value;
            }
        }

        // [DisplayName("Bottle Height")]
        [BottleDisplayName("Height")]
        [Size(50)]
       // [NotNull]
        public string BottleHeight
        {
            get
            {
                return BottleRow.Fields.BottleHeight[(Row)this];
            }
            set
            {
                BottleRow.Fields.BottleHeight[(Row)this] = value;
            }
        }

        //[DisplayName("Bottle Diameter")]
        [BottleDisplayName("Diameter")]
        [Size(50)]
        //[NotNull]
        public string BottleDiameter
        {
            get
            {
                return BottleRow.Fields.BottleDiameter[(Row)this];
            }
            set
            {
                BottleRow.Fields.BottleDiameter[(Row)this] = value;
            }
        }

        //[DisplayName("Bottle Mouth Opening (I/D)")]
        [BottleDisplayName("Mouth Opening (I/D)")]
        [Column("BottleMouthOpening_ID")]
        [Size(50)]
         //[NotNull]
        public string BottleMouthOpeningId
        {
            get
            {
                return BottleRow.Fields.BottleMouthOpeningId[(Row)this];
            }
            set
            {
                BottleRow.Fields.BottleMouthOpeningId[(Row)this] = value;
            }
        }

        //[DisplayName("Bottle Mouth Opening (O/D)")]
        [BottleDisplayName("Mouth Opening (O/D)")]
        [Column("BottleMouthOpening_OD")]
        [Size(50)]
       // [NotNull]
        public string BottleMouthOpeningOd
        {
            get
            {
                return BottleRow.Fields.BottleMouthOpeningOd[(Row)this];
            }
            set
            {
                BottleRow.Fields.BottleMouthOpeningOd[(Row)this] = value;
            }
        }

        [DisplayName("Supplier")]
        [ForeignKey("Supplier", "SupplierId")]
        [LeftJoin("jSupplier")]
        [TextualField("SupplierSupplierName")]
        //commntednted on 25.07.2018 by Vinayak to remove required
        //  [NotNull]
        public int? SupplierId
        {
            get
            {
                return BottleRow.Fields.SupplierId[(Row)this];
            }
            set
            {
                BottleRow.Fields.SupplierId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier")]
        [Expression("jSupplier.[SupplierName]")]
        public string SupplierSupplierName
        {
            get
            {
                return BottleRow.Fields.SupplierSupplierName[(Row)this];
            }
            set
            {
                BottleRow.Fields.SupplierSupplierName[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Supplier Address")]
        [Expression("jSupplier.[SupplierAddress]")]
        public string SupplierSupplierAddress
        {
            get
            {
                return BottleRow.Fields.SupplierSupplierAddress[(Row)this];
            }
            set
            {
                BottleRow.Fields.SupplierSupplierAddress[(Row)this] = value;
            }
        }

        [DisplayName("Supplier City Id")]
        [Expression("jSupplier.[CityId]")]
        public int? SupplierCityId
        {
            get
            {
                return BottleRow.Fields.SupplierCityId[(Row)this];
            }
            set
            {
                BottleRow.Fields.SupplierCityId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Pin Code")]
        [Expression("jSupplier.[PinCode]")]
        public string SupplierPinCode
        {
            get
            {
                return BottleRow.Fields.SupplierPinCode[(Row)this];
            }
            set
            {
                BottleRow.Fields.SupplierPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Mobile Code")]
        [Expression("jSupplier.[MobileCode]")]
        public int? SupplierMobileCode
        {
            get
            {
                return BottleRow.Fields.SupplierMobileCode[(Row)this];
            }
            set
            {
                BottleRow.Fields.SupplierMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Mobile Number")]
        [Expression("jSupplier.[MobileNumber]")]
        public long? SupplierMobileNumber
        {
            get
            {
                return BottleRow.Fields.SupplierMobileNumber[(Row)this];
            }
            set
            {
                BottleRow.Fields.SupplierMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Status Id")]
        [Expression("jSupplier.[StatusId]")]
        public int? SupplierStatusId
        {
            get
            {
                return BottleRow.Fields.SupplierStatusId[(Row)this];
            }
            set
            {
                BottleRow.Fields.SupplierStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Created By")]
        [Expression("jSupplier.[CreatedBy]")]
        public int? SupplierCreatedBy
        {
            get
            {
                return BottleRow.Fields.SupplierCreatedBy[(Row)this];
            }
            set
            {
                BottleRow.Fields.SupplierCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Created Date")]
        [Expression("jSupplier.[CreatedDate]")]
        public DateTime? SupplierCreatedDate
        {
            get
            {
                return BottleRow.Fields.SupplierCreatedDate[(Row)this];
            }
            set
            {
                BottleRow.Fields.SupplierCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Updated By")]
        [Expression("jSupplier.[UpdatedBy]")]
        public int? SupplierUpdatedBy
        {
            get
            {
                return BottleRow.Fields.SupplierUpdatedBy[(Row)this];
            }
            set
            {
                BottleRow.Fields.SupplierUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Updated Date")]
        [Expression("jSupplier.[UpdatedDate]")]
        public DateTime? SupplierUpdatedDate
        {
            get
            {
                return BottleRow.Fields.SupplierUpdatedDate[(Row)this];
            }
            set
            {
                BottleRow.Fields.SupplierUpdatedDate[(Row)this] = value;
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
                return BottleRow.Fields.StatusId[(Row)this];
            }
            set
            {
                BottleRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return BottleRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                BottleRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return BottleRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return BottleRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return BottleRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return BottleRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return BottleRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return BottleRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return BottleRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return BottleRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return BottleRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return BottleRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return BottleRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return BottleRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return BottleRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return BottleRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return BottleRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return BottleRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return BottleRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return BottleRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return BottleRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return BottleRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return BottleRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return BottleRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return BottleRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return BottleRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return BottleRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                BottleRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return BottleRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("(jUpdatedBy.[FirstName] + ' ' + jUpdatedBy.[Lastname])")]
        public string UpdatedByFullName
        {
            get
            {
                return BottleRow.Fields.UpdatedByFullName[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByFullName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return BottleRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return BottleRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return BottleRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return BottleRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return BottleRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return BottleRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return BottleRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return BottleRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return BottleRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return BottleRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return BottleRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return BottleRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return BottleRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return BottleRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return BottleRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return BottleRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return BottleRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return BottleRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return BottleRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return BottleRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return BottleRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return BottleRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return BottleRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return BottleRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                BottleRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return BottleRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                BottleRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }


        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)BottleRow.Fields.BottleId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return BottleRow.Fields.BottleName;
            }
        }

        public BottleRow()
          : base((RowFieldsBase)BottleRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field BottleId;
            public StringField BottleName;
            public StringField BottleCc;
            public Int32Field ContainerTypeId;
            public StringField BottleHeight;
            public StringField BottleDiameter;
            public StringField BottleMouthOpeningId;
            public StringField BottleMouthOpeningOd;
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
            public Int32Field ContainerTypePickListId;
            public StringField ContainerTypePickListValueName;
            public Int32Field ContainerTypeStatusId;
            public Int32Field ContainerTypeCreatedBy;
            public DateTimeField ContainerTypeCreatedDate;
            public Int32Field ContainerTypeUpdatedBy;
            public DateTimeField ContainerTypeUpdatedDate;
            public StringField UpdatedByFullName { get; set; }
            public StringField RecordAddedSource;



            public RowFields()
              : base((string)null, (string)null)
            {
                this.LocalTextPrefix = "PackSettings.Bottle";
            }
        }
    }
}
