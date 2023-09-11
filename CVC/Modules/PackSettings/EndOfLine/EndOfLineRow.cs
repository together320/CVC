// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Entities.EndOfLineRow
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
    [TableName("EndOfLine")]
    [DisplayName("End Of Line")]
    [InstanceName("End Of Line")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("PackSettings:EndOfLine:Read")]
    [ModifyPermission("PackSettings:EndOfLine:Modify")]
    [LookupScript("PackSettings.EndOfLine", Permission = "Lookup")]
    public sealed class EndOfLineRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly EndOfLineRow.RowFields Fields = new EndOfLineRow.RowFields().Init<EndOfLineRow.RowFields>();

        [DisplayName("End Of Line Id")]
        [Identity]
        public int? EndOfLineId
        {
            get
            {
                return EndOfLineRow.Fields.EndOfLineId[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.EndOfLineId[(Row)this] = value;
            }
        }

        [DisplayName("End Of Line Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        public string EndOfLineName
        {
            get
            {
                return EndOfLineRow.Fields.EndOfLineName[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.EndOfLineName[(Row)this] = value;
            }
        }

        [DisplayName("Carton Length")]
        [Size(50)]
        [NotNull]
        public string CartonLength
        {
            get
            {
                return EndOfLineRow.Fields.CartonLength[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CartonLength[(Row)this] = value;
            }
        }

        [DisplayName("Carton Height")]
        [Size(50)]
        [NotNull]
        public string CartonHeight
        {
            get
            {
                return EndOfLineRow.Fields.CartonHeight[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CartonHeight[(Row)this] = value;
            }
        }

        [DisplayName("Carton Width")]
        [Size(50)]
        [NotNull]
        public string CartonWidth
        {
            get
            {
                return EndOfLineRow.Fields.CartonWidth[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CartonWidth[(Row)this] = value;
            }
        }

        [DisplayName("Carton Type")]
        [Size(50)]
        [NotNull]
        public string CartonType
        {
            get
            {
                return EndOfLineRow.Fields.CartonType[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CartonType[(Row)this] = value;
            }
        }

        [DisplayName("Bottle Configuration")]
        [Size(50)]
        public string BottleConfiguration
        {
            get
            {
                return EndOfLineRow.Fields.BottleConfiguration[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.BottleConfiguration[(Row)this] = value;
            }
        }

        [DisplayName("Medication Length")]
        [Size(50)]
        public string MedicationLength
        {
            get
            {
                return EndOfLineRow.Fields.MedicationLength[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.MedicationLength[(Row)this] = value;
            }
        }

        [DisplayName("Medication Width")]
        [Size(50)]
        public string MedicationWidth
        {
            get
            {
                return EndOfLineRow.Fields.MedicationWidth[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.MedicationWidth[(Row)this] = value;
            }
        }

        [DisplayName("No Of Medication")]
        [Size(50)]
        public string NoOfMedication
        {
            get
            {
                return EndOfLineRow.Fields.NoOfMedication[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.NoOfMedication[(Row)this] = value;
            }
        }

        [DisplayName("Inner Shipper Box Type")]
        [Size(50)]
        public string InnerShipperBoxType
        {
            get
            {
                return EndOfLineRow.Fields.InnerShipperBoxType[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.InnerShipperBoxType[(Row)this] = value;
            }
        }

        [DisplayName("Inner Shipper Box Length")]
        [Size(50)]
        public string InnerShipperBoxLength
        {
            get
            {
                return EndOfLineRow.Fields.InnerShipperBoxLength[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.InnerShipperBoxLength[(Row)this] = value;
            }
        }

        [DisplayName("Inner Shipper Box Width")]
        [Size(50)]
        public string InnerShipperBoxWidth
        {
            get
            {
                return EndOfLineRow.Fields.InnerShipperBoxWidth[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.InnerShipperBoxWidth[(Row)this] = value;
            }
        }

        [DisplayName("Inner Shipper Box Height")]
        [Size(50)]
        public string InnerShipperBoxHeight
        {
            get
            {
                return EndOfLineRow.Fields.InnerShipperBoxHeight[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.InnerShipperBoxHeight[(Row)this] = value;
            }
        }

        [DisplayName("Outer Shipper Box Length")]
        [Size(50)]
        public string OuterShipperBoxLength
        {
            get
            {
                return EndOfLineRow.Fields.OuterShipperBoxLength[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.OuterShipperBoxLength[(Row)this] = value;
            }
        }

        [DisplayName("Outer Shipper Box Width")]
        [Size(50)]
        public string OuterShipperBoxWidth
        {
            get
            {
                return EndOfLineRow.Fields.OuterShipperBoxWidth[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.OuterShipperBoxWidth[(Row)this] = value;
            }
        }

        [DisplayName("Outer Shipper Box Height")]
        [Size(50)]
        public string OuterShipperBoxHeight
        {
            get
            {
                return EndOfLineRow.Fields.OuterShipperBoxHeight[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.OuterShipperBoxHeight[(Row)this] = value;
            }
        }

        [DisplayName("Inner Shipper Matrix")]
        [Size(50)]
        public string InnerShipperMatrix
        {
            get
            {
                return EndOfLineRow.Fields.InnerShipperMatrix[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.InnerShipperMatrix[(Row)this] = value;
            }
        }

        [DisplayName("Outer Shipper Quantity")]
        [Size(50)]
        public string OuterShipperQuantity
        {
            get
            {
                return EndOfLineRow.Fields.OuterShipperQuantity[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.OuterShipperQuantity[(Row)this] = value;
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
                return EndOfLineRow.Fields.StatusId[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return EndOfLineRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return EndOfLineRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return EndOfLineRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return EndOfLineRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                EndOfLineRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)EndOfLineRow.Fields.EndOfLineId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return EndOfLineRow.Fields.EndOfLineName;
            }
        }

        public EndOfLineRow()
          : base((RowFieldsBase)EndOfLineRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field EndOfLineId;
            public StringField EndOfLineName;
            public StringField CartonLength;
            public StringField CartonHeight;
            public StringField CartonWidth;
            public StringField CartonType;
            public StringField BottleConfiguration;
            public StringField MedicationLength;
            public StringField MedicationWidth;
            public StringField NoOfMedication;
            public StringField InnerShipperBoxType;
            public StringField InnerShipperBoxLength;
            public StringField InnerShipperBoxWidth;
            public StringField InnerShipperBoxHeight;
            public StringField OuterShipperBoxLength;
            public StringField OuterShipperBoxWidth;
            public StringField OuterShipperBoxHeight;
            public StringField InnerShipperMatrix;
            public StringField OuterShipperQuantity;
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

            public RowFields()
              : base((string)null, (string)null)
            {
                this.LocalTextPrefix = "PackSettings.EndOfLine";
            }
        }
    }
}
