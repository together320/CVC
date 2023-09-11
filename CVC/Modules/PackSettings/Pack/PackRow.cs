// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Entities.PackRow
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
    [TableName("Pack")]
    [DisplayName("Pack")]
    [InstanceName("Pack")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("PackSettings:Pack:Read")]
    [ModifyPermission("PackSettings:Pack:Modify")]
    [LookupScript("PackSettings.Pack", Permission = "Lookup")]
    public sealed class PackRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly PackRow.RowFields Fields = new PackRow.RowFields().Init<PackRow.RowFields>();

        [DisplayName("Pack Id")]
        [Identity]
        public int? PackId
        {
            get
            {
                return PackRow.Fields.PackId[(Row)this];
            }
            set
            {
                PackRow.Fields.PackId[(Row)this] = value;
            }
        }

        // [DisplayName("Pack Name")]
        [PackDisplayName("")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        [Unique]
        public string PackName
        {
            get
            {
                return PackRow.Fields.PackName[(Row)this];
            }
            set
            {
                PackRow.Fields.PackName[(Row)this] = value;
            }
        }

        [DisplayName("Product")]
        [ForeignKey("TabletDetails", "TabletDetailsId")]
        [LeftJoin("jTablet")]
        [TextualField("TabletName")]
        [NotNull]
        public int? TabletId
        {
            get
            {
                return PackRow.Fields.TabletId[(Row)this];
            }
            set
            {
                PackRow.Fields.TabletId[(Row)this] = value;
            }
        }

        [DisplayName("Product Name")]
        [Expression("jTablet.[TabletName]")]
        public string TabletName
        {
            get
            {
                return PackRow.Fields.TabletName[(Row)this];
            }
            set
            {
                PackRow.Fields.TabletName[(Row)this] = value;
            }
        }

        [DisplayName("Product Quantity")]
       // [NotNull]
        public int? TabletCount
        {
            get
            {
                return PackRow.Fields.TabletCount[(Row)this];
            }
            set
            {
                PackRow.Fields.TabletCount[(Row)this] = value;
            }
        }

        // [DisplayName("Bottle")]
        [BottleDisplayName("")]
        [ForeignKey("Bottle", "BottleId")]
        [LeftJoin("jBottle")]
        [TextualField("BottleName")]
      //  [NotNull]
        public int? BottleId
        {
            get
            {
                return PackRow.Fields.BottleId[(Row)this];
            }
            set
            {
                PackRow.Fields.BottleId[(Row)this] = value;
            }
        }

        //[DisplayName("Bottle")]
        [BottleDisplayName("")]
        [Expression("jBottle.[BottleName]")]
        public string BottleName
        {
            get
            {
                return PackRow.Fields.BottleName[(Row)this];
            }
            set
            {
                PackRow.Fields.BottleName[(Row)this] = value;
            }
        }

        [DisplayName("Cap")]
        [ForeignKey("Cap", "CapId")]
        [LeftJoin("jCap")]
        [TextualField("CapName")]
       // [NotNull]
        public int? CapId
        {
            get
            {
                return PackRow.Fields.CapId[(Row)this];
            }
            set
            {
                PackRow.Fields.CapId[(Row)this] = value;
            }
        }

        [DisplayName("Cap")]
        [Expression("jCap.[CapName]")]
        public string CapName
        {
            get
            {
                return PackRow.Fields.CapName[(Row)this];
            }
            set
            {
                PackRow.Fields.CapName[(Row)this] = value;
            }
        }

        [DisplayName("Cotton")]
        [ForeignKey("Cotton", "CottonId")]
        [LeftJoin("jCotton")]
        [TextualField("CottonName")]
        //commntednted on 25.07.2018 by Vinayak to remove required
        //[NotNull]
        public int? CottonId
        {
            get
            {
                return PackRow.Fields.CottonId[(Row)this];
            }
            set
            {
                PackRow.Fields.CottonId[(Row)this] = value;
            }
        }

        [DisplayName("Cotton")]
        [Expression("jCotton.[CottonName]")]
        public string CottonName
        {
            get
            {
                return PackRow.Fields.CottonName[(Row)this];
            }
            set
            {
                PackRow.Fields.CottonName[(Row)this] = value;
            }
        }

        [DisplayName("Cotton Length")]
        [Size(50)]
        public string CottonLength
        {
            get
            {
                return PackRow.Fields.CottonLength[(Row)this];
            }
            set
            {
                PackRow.Fields.CottonLength[(Row)this] = value;
            }
        }

        [DisplayName("Number Of Cotton Pieces")]
        //commntednted on 25.07.2018 by Vinayak to remove required
        //[NotNull]
        public int? NumberOfCottonPieces
        {
            get
            {
                return PackRow.Fields.NumberOfCottonPieces[(Row)this];
            }
            set
            {
                PackRow.Fields.NumberOfCottonPieces[(Row)this] = value;
            }
        }

        [DisplayName("Desiccant")]
        [ForeignKey("Desiccant", "DesiccantId")]
        [LeftJoin("jDesiccant")]
        [TextualField("DesiccantName")]
        //commntednted on 25.07.2018 by Vinayak to remove required
        //[NotNull]
        public int? DesiccantId
        {
            get
            {
                return PackRow.Fields.DesiccantId[(Row)this];
            }
            set
            {
                PackRow.Fields.DesiccantId[(Row)this] = value;
            }
        }

        [DisplayName("Desiccant")]
        [Expression("jDesiccant.[DesiccantName]")]
        public string DesiccantName
        {
            get
            {
                return PackRow.Fields.DesiccantName[(Row)this];
            }
            set
            {
                PackRow.Fields.DesiccantName[(Row)this] = value;
            }
        }

        [DisplayName("Number Of Desicant Pieces")]
        //commntednted on 25.07.2018 by Vinayak to remove required
        //[NotNull]
        public int? NumberOfDesicantPieces
        {
            get
            {
                return PackRow.Fields.NumberOfDesicantPieces[(Row)this];
            }
            set
            {
                PackRow.Fields.NumberOfDesicantPieces[(Row)this] = value;
            }
        }

        [DisplayName("Outsert")]
        [ForeignKey("Outsert", "OutsertId")]
        [LeftJoin("jOutsert")]
        [TextualField("OutsertName")]
        //commntednted on 25.07.2018 by Vinayak to remove required
        // [NotNull]
        public int? OutsertId
        {
            get
            {
                return PackRow.Fields.OutsertId[(Row)this];
            }
            set
            {
                PackRow.Fields.OutsertId[(Row)this] = value;
            }
        }

        [DisplayName("Outsert")]
        [Expression("jOutsert.[OutsertName]")]
        public string OutsertName
        {
            get
            {
                return PackRow.Fields.OutsertName[(Row)this];
            }
            set
            {
                PackRow.Fields.OutsertName[(Row)this] = value;
            }
        }

        [DisplayName("Label")]
        [ForeignKey("Label", "LabelId")]
        [LeftJoin("jLabel")]
        [TextualField("LabelLabelName")]
        //[NotNull]
        public int? LabelId
        {
            get
            {
                return PackRow.Fields.LabelId[(Row)this];
            }
            set
            {
                PackRow.Fields.LabelId[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [ForeignKey("Status", "StatusId")]
        [LeftJoin("jStatus")]
        [TextualField("StatusStatusName")]
        [NotNull]
        //To make status as default "Active"
        [DefaultValue(1)]
        public int? StatusId
        {
            get
            {
                return PackRow.Fields.StatusId[(Row)this];
            }
            set
            {
                PackRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line")]
        [ForeignKey("EndOfLine", "EndOfLineId")]
        [LeftJoin("jEndOfLine")]
        [TextualField("EndOfLineEndOfLineName")]
        public int? EndOfLineId
        {
            get
            {
                return PackRow.Fields.EndOfLineId[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineId[(Row)this] = value;
            }
        }

        [DisplayName("Label")]
        [Expression("jLabel.[LabelName]")]
        public string LabelLabelName
        {
            get
            {
                return PackRow.Fields.LabelLabelName[(Row)this];
            }
            set
            {
                PackRow.Fields.LabelLabelName[(Row)this] = value;
            }
        }

        [DisplayName("Label Label Length")]
        [Expression("jLabel.[LabelLength]")]
        public string LabelLabelLength
        {
            get
            {
                return PackRow.Fields.LabelLabelLength[(Row)this];
            }
            set
            {
                PackRow.Fields.LabelLabelLength[(Row)this] = value;
            }
        }

        [DisplayName("Label Label Height")]
        [Expression("jLabel.[LabelHeight]")]
        public string LabelLabelHeight
        {
            get
            {
                return PackRow.Fields.LabelLabelHeight[(Row)this];
            }
            set
            {
                PackRow.Fields.LabelLabelHeight[(Row)this] = value;
            }
        }

        [DisplayName("Label Label Type")]
        [Expression("jLabel.[LabelType]")]
        public string LabelLabelType
        {
            get
            {
                return PackRow.Fields.LabelLabelType[(Row)this];
            }
            set
            {
                PackRow.Fields.LabelLabelType[(Row)this] = value;
            }
        }

        [DisplayName("Label Label Image")]
        [Expression("jLabel.[LabelImage]")]
        public string LabelLabelImage
        {
            get
            {
                return PackRow.Fields.LabelLabelImage[(Row)this];
            }
            set
            {
                PackRow.Fields.LabelLabelImage[(Row)this] = value;
            }
        }

        [DisplayName("Label Supplier Id")]
        [Expression("jLabel.[SupplierId]")]
        public int? LabelSupplierId
        {
            get
            {
                return PackRow.Fields.LabelSupplierId[(Row)this];
            }
            set
            {
                PackRow.Fields.LabelSupplierId[(Row)this] = value;
            }
        }

        [DisplayName("Label Status Id")]
        [Expression("jLabel.[StatusId]")]
        public int? LabelStatusId
        {
            get
            {
                return PackRow.Fields.LabelStatusId[(Row)this];
            }
            set
            {
                PackRow.Fields.LabelStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Label Created By")]
        [Expression("jLabel.[CreatedBy]")]
        public int? LabelCreatedBy
        {
            get
            {
                return PackRow.Fields.LabelCreatedBy[(Row)this];
            }
            set
            {
                PackRow.Fields.LabelCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Label Created Date")]
        [Expression("jLabel.[CreatedDate]")]
        public DateTime? LabelCreatedDate
        {
            get
            {
                return PackRow.Fields.LabelCreatedDate[(Row)this];
            }
            set
            {
                PackRow.Fields.LabelCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Label Updated By")]
        [Expression("jLabel.[UpdatedBy]")]
        public int? LabelUpdatedBy
        {
            get
            {
                return PackRow.Fields.LabelUpdatedBy[(Row)this];
            }
            set
            {
                PackRow.Fields.LabelUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Label Updated Date")]
        [Expression("jLabel.[UpdatedDate]")]
        public DateTime? LabelUpdatedDate
        {
            get
            {
                return PackRow.Fields.LabelUpdatedDate[(Row)this];
            }
            set
            {
                PackRow.Fields.LabelUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return PackRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                PackRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line")]
        [Expression("jEndOfLine.[EndOfLineName]")]
        public string EndOfLineEndOfLineName
        {
            get
            {
                return PackRow.Fields.EndOfLineEndOfLineName[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineEndOfLineName[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Carton Length")]
        [Expression("jEndOfLine.[CartonLength]")]
        public string EndOfLineCartonLength
        {
            get
            {
                return PackRow.Fields.EndOfLineCartonLength[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineCartonLength[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Carton Height")]
        [Expression("jEndOfLine.[CartonHeight]")]
        public string EndOfLineCartonHeight
        {
            get
            {
                return PackRow.Fields.EndOfLineCartonHeight[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineCartonHeight[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Carton Width")]
        [Expression("jEndOfLine.[CartonWidth]")]
        public string EndOfLineCartonWidth
        {
            get
            {
                return PackRow.Fields.EndOfLineCartonWidth[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineCartonWidth[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Carton Type")]
        [Expression("jEndOfLine.[CartonType]")]
        public string EndOfLineCartonType
        {
            get
            {
                return PackRow.Fields.EndOfLineCartonType[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineCartonType[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Bottle Configuration")]
        [Expression("jEndOfLine.[BottleConfiguration]")]
        public string EndOfLineBottleConfiguration
        {
            get
            {
                return PackRow.Fields.EndOfLineBottleConfiguration[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineBottleConfiguration[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Medication Length")]
        [Expression("jEndOfLine.[MedicationLength]")]
        public string EndOfLineMedicationLength
        {
            get
            {
                return PackRow.Fields.EndOfLineMedicationLength[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineMedicationLength[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Medication Width")]
        [Expression("jEndOfLine.[MedicationWidth]")]
        public string EndOfLineMedicationWidth
        {
            get
            {
                return PackRow.Fields.EndOfLineMedicationWidth[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineMedicationWidth[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line No Of Medication")]
        [Expression("jEndOfLine.[NoOfMedication]")]
        public string EndOfLineNoOfMedication
        {
            get
            {
                return PackRow.Fields.EndOfLineNoOfMedication[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineNoOfMedication[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Inner Shipper Box Type")]
        [Expression("jEndOfLine.[InnerShipperBoxType]")]
        public string EndOfLineInnerShipperBoxType
        {
            get
            {
                return PackRow.Fields.EndOfLineInnerShipperBoxType[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineInnerShipperBoxType[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Inner Shipper Box Length")]
        [Expression("jEndOfLine.[InnerShipperBoxLength]")]
        public string EndOfLineInnerShipperBoxLength
        {
            get
            {
                return PackRow.Fields.EndOfLineInnerShipperBoxLength[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineInnerShipperBoxLength[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Inner Shipper Box Width")]
        [Expression("jEndOfLine.[InnerShipperBoxWidth]")]
        public string EndOfLineInnerShipperBoxWidth
        {
            get
            {
                return PackRow.Fields.EndOfLineInnerShipperBoxWidth[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineInnerShipperBoxWidth[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Inner Shipper Box Height")]
        [Expression("jEndOfLine.[InnerShipperBoxHeight]")]
        public string EndOfLineInnerShipperBoxHeight
        {
            get
            {
                return PackRow.Fields.EndOfLineInnerShipperBoxHeight[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineInnerShipperBoxHeight[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Outer Shipper Box Length")]
        [Expression("jEndOfLine.[OuterShipperBoxLength]")]
        public string EndOfLineOuterShipperBoxLength
        {
            get
            {
                return PackRow.Fields.EndOfLineOuterShipperBoxLength[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineOuterShipperBoxLength[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Outer Shipper Box Width")]
        [Expression("jEndOfLine.[OuterShipperBoxWidth]")]
        public string EndOfLineOuterShipperBoxWidth
        {
            get
            {
                return PackRow.Fields.EndOfLineOuterShipperBoxWidth[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineOuterShipperBoxWidth[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Outer Shipper Box Height")]
        [Expression("jEndOfLine.[OuterShipperBoxHeight]")]
        public string EndOfLineOuterShipperBoxHeight
        {
            get
            {
                return PackRow.Fields.EndOfLineOuterShipperBoxHeight[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineOuterShipperBoxHeight[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Inner Shipper Matrix")]
        [Expression("jEndOfLine.[InnerShipperMatrix]")]
        public string EndOfLineInnerShipperMatrix
        {
            get
            {
                return PackRow.Fields.EndOfLineInnerShipperMatrix[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineInnerShipperMatrix[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Outer Shipper Quantity")]
        [Expression("jEndOfLine.[OuterShipperQuantity]")]
        public string EndOfLineOuterShipperQuantity
        {
            get
            {
                return PackRow.Fields.EndOfLineOuterShipperQuantity[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineOuterShipperQuantity[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Status Id")]
        [Expression("jEndOfLine.[StatusId]")]
        public int? EndOfLineStatusId
        {
            get
            {
                return PackRow.Fields.EndOfLineStatusId[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineStatusId[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Created By")]
        [Expression("jEndOfLine.[CreatedBy]")]
        public int? EndOfLineCreatedBy
        {
            get
            {
                return PackRow.Fields.EndOfLineCreatedBy[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Created Date")]
        [Expression("jEndOfLine.[CreatedDate]")]
        public DateTime? EndOfLineCreatedDate
        {
            get
            {
                return PackRow.Fields.EndOfLineCreatedDate[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Updated By")]
        [Expression("jEndOfLine.[UpdatedBy]")]
        public int? EndOfLineUpdatedBy
        {
            get
            {
                return PackRow.Fields.EndOfLineUpdatedBy[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Updated Date")]
        [Expression("jEndOfLine.[UpdatedDate]")]
        public DateTime? EndOfLineUpdatedDate
        {
            get
            {
                return PackRow.Fields.EndOfLineUpdatedDate[(Row)this];
            }
            set
            {
                PackRow.Fields.EndOfLineUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return PackRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return PackRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return PackRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return PackRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return PackRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return PackRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return PackRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return PackRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return PackRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return PackRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return PackRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return PackRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return PackRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return PackRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return PackRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return PackRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return PackRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return PackRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return PackRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return PackRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return PackRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return PackRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return PackRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return PackRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return PackRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                PackRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return PackRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return PackRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return PackRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return PackRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return PackRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return PackRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return PackRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return PackRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return PackRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return PackRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return PackRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return PackRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return PackRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return PackRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return PackRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return PackRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return PackRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return PackRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return PackRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return PackRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return PackRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return PackRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return PackRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return PackRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return PackRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                PackRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return PackRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                PackRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }


        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)PackRow.Fields.PackId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return PackRow.Fields.PackName;
            }
        }

        public PackRow()
          : base((RowFieldsBase)PackRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field PackId;
            public StringField PackName;
            public Int32Field TabletId;
            public Int32Field TabletCount;
            public Int32Field BottleId;
            public Int32Field CapId;
            public Int32Field CottonId;
            public StringField CottonLength;
            public Int32Field NumberOfCottonPieces;
            public Int32Field DesiccantId;
            public Int32Field NumberOfDesicantPieces;
            public Int32Field OutsertId;
            public Int32Field LabelId;
            public Int32Field StatusId;
            public Int32Field EndOfLineId;
            public StringField LabelLabelName;
            public StringField LabelLabelLength;
            public StringField LabelLabelHeight;
            public StringField LabelLabelType;
            public StringField LabelLabelImage;
            public Int32Field LabelSupplierId;
            public Int32Field LabelStatusId;
            public Int32Field LabelCreatedBy;
            public DateTimeField LabelCreatedDate;
            public Int32Field LabelUpdatedBy;
            public DateTimeField LabelUpdatedDate;
            public StringField StatusStatusName;
            public StringField EndOfLineEndOfLineName;
            public StringField EndOfLineCartonLength;
            public StringField EndOfLineCartonHeight;
            public StringField EndOfLineCartonWidth;
            public StringField EndOfLineCartonType;
            public StringField EndOfLineBottleConfiguration;
            public StringField EndOfLineMedicationLength;
            public StringField EndOfLineMedicationWidth;
            public StringField EndOfLineNoOfMedication;
            public StringField EndOfLineInnerShipperBoxType;
            public StringField EndOfLineInnerShipperBoxLength;
            public StringField EndOfLineInnerShipperBoxWidth;
            public StringField EndOfLineInnerShipperBoxHeight;
            public StringField EndOfLineOuterShipperBoxLength;
            public StringField EndOfLineOuterShipperBoxWidth;
            public StringField EndOfLineOuterShipperBoxHeight;
            public StringField EndOfLineInnerShipperMatrix;
            public StringField EndOfLineOuterShipperQuantity;
            public Int32Field EndOfLineStatusId;
            public Int32Field EndOfLineCreatedBy;
            public DateTimeField EndOfLineCreatedDate;
            public Int32Field EndOfLineUpdatedBy;
            public DateTimeField EndOfLineUpdatedDate;
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
            public StringField TabletName;
            public StringField BottleName;
            public StringField CapName;
            public StringField CottonName;
            public StringField DesiccantName;
            public StringField OutsertName;
            public StringField RecordAddedSource;



            public RowFields()
              : base((string)null, (string)null)
            {
                this.LocalTextPrefix = "PackSettings.Pack";
            }
        }
    }
}
