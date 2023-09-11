// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.MachineParameterRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Configuration.Scripts;
using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.MachineCustomization.Entities
{
    [ConnectionKey("Default")]
    [TableName("MachineParameter")]
    [DisplayName("Entity Field")]
    [InstanceName("Machine Parameter")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("MachineCustomization:MachineParameter:Read")]
    [ModifyPermission("MachineCustomization:MachineParameter:Modify")]
    [LookupScript("MachineCustomization.MachineParameter", Permission = "Lookup")]
    public sealed class MachineParameterRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        
        public static readonly MachineParameterRow.RowFields Fields = new MachineParameterRow.RowFields().Init<MachineParameterRow.RowFields>();

        [DisplayName("Machine Parameter Id")]
        [Identity]
        public int? MachineParameterId
        {
            get
            {
                return MachineParameterRow.Fields.MachineParameterId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.MachineParameterId[(Row)this] = value;
            }
        }

        [DisplayName("Business Entity")]
        [ForeignKey("Machine", "MachineId")]
        [LeftJoin("jMachine")]
        [TextualField("MachineMachineName")]
        [NotNull]
        [LookupInclude]
        public int? MachineId
        {
            get
            {
                return MachineParameterRow.Fields.MachineId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [Expression("jMachine.[IsRealTime]")]
        public bool? IsRealTime
        {
            get
            {
                return MachineParameterRow.Fields.IsRealTime[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.IsRealTime[(Row)this] = value;
            }
        }

        // added by Denis for RS 3.7 dated 7/20/2021
        /*NOTE
         *Author: JSGURU
         * 
         * For toggle of mandatory validation
         * When I use [NotNull], it did not work.
         * But [Required] works instead.
         * **/
        [DisplayName("Column Name")]
        //[NotNull]
        [Required]
        public string ColumnName
        {
            get
            {
                return MachineParameterRow.Fields.ColumnName[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.ColumnName[(Row)this] = value;
            }
        }

        // added by Denis for RS 3.8 dated 7/20/2021
        [DisplayName("Pick List"), ForeignKey("PickList", "PickListId"), LeftJoin("pl")]
        [LookupEditor("Configuration.PickList")]
        public int? PickListId
        {
            get
            {
                return MachineParameterRow.Fields.PickListId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.PickListId[(Row)this] = value;
            }
        }

        // added by Denis for RS 3.8 dated 7/20/2021
        [DisplayName("Pick List"), Expression("pl.PickListName")]
        public string PickListName
        {
            get
            {
                return MachineParameterRow.Fields.PickListName[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.PickListName[(Row)this] = value;
            }
        }

        [DisplayName("Business Entity")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return MachineParameterRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [DisplayName("Field Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        public string ParameterName
        {
            get
            {
                return MachineParameterRow.Fields.ParameterName[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.ParameterName[(Row)this] = value;
            }
        }

        [DisplayName("Plc Address")]
        [Column("PLCAddress")]
        [Size(20)]
        //[NotNull]
        public string PlcAddress
        {
            get
            {
                return MachineParameterRow.Fields.PlcAddress[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.PlcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Description")]
        [Size(100)]
        public string Description
        {
            get
            {
                return MachineParameterRow.Fields.Description[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.Description[(Row)this] = value;
            }
        }

        [DisplayName("Data Type")]
        [ForeignKey("DataType", "DataTypeId")]
        [LeftJoin("jDataType")]
        [TextualField("DataTypeName")]
        [Required]
        public int? DataTypeId
        {
            get
            {
                return MachineParameterRow.Fields.DataTypeId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.DataTypeId[(Row)this] = value;
            }
        }

        [DisplayName("Data Type")]
        [Expression("jDataType.[DataTypeName]")]
        public string DataTypeName
        {
            get
            {
                return MachineParameterRow.Fields.DataTypeName[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.DataTypeName[(Row)this] = value;
            }
        }

        [DisplayName("Is Range Unlimited")]
        public bool? IsRangeUnlimited
        {
            get
            {
                return MachineParameterRow.Fields.IsRangeUnlimited[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.IsRangeUnlimited[(Row)this] = value;
            }
        }

        [DisplayName("Min")]
        [Size(18)]
        [Scale(2)]
        public Decimal? Min
        {
            get
            {
                return MachineParameterRow.Fields.Min[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.Min[(Row)this] = value;
            }
        }

        [DisplayName("Max")]
        [Size(18)]
        [Scale(2)]
        public Decimal? Max
        {
            get
            {
                return MachineParameterRow.Fields.Max[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.Max[(Row)this] = value;
            }
        }

        [DisplayName("Is Use Unit")]
        public bool? IsUseUnit
        {
            get
            {
                return MachineParameterRow.Fields.IsUseUnit[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.IsUseUnit[(Row)this] = value;
            }
        }

        [DisplayName("Unit")]
        [ForeignKey("PickListValue", "PickListValueId")]
        [LeftJoin("jUnit")]
        [TextualField("UnitPickListValueName")]
        public int? UnitId
        {
            get
            {
                return MachineParameterRow.Fields.UnitId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UnitId[(Row)this] = value;
            }
        }

        [DisplayName("Unit")]
        [Expression("jUnit.[PickListValueName]")]
        public string UnitPickListValueName
        {
            get
            {
                return MachineParameterRow.Fields.UnitPickListValueName[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UnitPickListValueName[(Row)this] = value;
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
                return MachineParameterRow.Fields.StatusId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return MachineParameterRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.StatusStatusName[(Row)this] = value;
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
                return MachineParameterRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return MachineParameterRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedDate[(Row)this] = value;
            }
        }


      
        public bool? IsResetOnBatchCreate
        {
            get
            {
                return MachineParameterRow.Fields.IsResetOnBatchCreate[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.IsResetOnBatchCreate[(Row)this] = value;
            }
        }

        public bool? IsBatchStartRequired
        {
            get
            {
                return MachineParameterRow.Fields.IsBatchStartRequired[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.IsBatchStartRequired[(Row)this] = value;
            }
        }

        public bool? AllowDecimalPoint
        {
            get
            {
                return MachineParameterRow.Fields.AllowDecimalPoint[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.AllowDecimalPoint[(Row)this] = value;
            }
        }

        public bool? IsLabelRoll
        {
            get
            {
                return MachineParameterRow.Fields.IsLabelRoll[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.IsLabelRoll[(Row)this] = value;
            }
        }

        public bool? IsStopOnBatchStop
        {
            get
            {
                return MachineParameterRow.Fields.IsStopOnBatchStop[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.IsStopOnBatchStop[(Row)this] = value;
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
                return MachineParameterRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return MachineParameterRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return MachineParameterRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return MachineParameterRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }



        [DisplayName("Type")]
        public int? Type
        {
            get
            {
                return MachineParameterRow.Fields.Type[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.Type[(Row)this] = value;
            }

        }

        [DisplayName("Read Machine Parameter")]
        public int? ReadMachineParameterId
        {
            get
            {
                return MachineParameterRow.Fields.ReadMachineParameterId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.ReadMachineParameterId[(Row)this] = value;
            }

        }

        [DisplayName("Reload Machine Parameter")]
        public int? ReloadMachineParameterId
        {
            get
            {
                return MachineParameterRow.Fields.ReloadMachineParameterId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.ReloadMachineParameterId[(Row)this] = value;
            }
        }


      
        public int? DisableParameterId
        {
            get
            {
                return MachineParameterRow.Fields.DisableParameterId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.DisableParameterId[(Row)this] = value;
            }
        }

        public string DisableParameterValue
        {
            get
            {
                return MachineParameterRow.Fields.DisableParameterValue[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.DisableParameterValue[(Row)this] = value;
            }
        }

        [DisplayName("Is Show As Message")]
        public bool? IsShowAsMessage
        {
            get
            {
                return MachineParameterRow.Fields.IsShowAsMessage[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.IsShowAsMessage[(Row)this] = value;
            }

        }



      


        [DisplayName("Is Read")]
        [ReadOnly(true)]
        [DefaultValue(true)]
        public bool? IsRead
        {
            get
            {
                return MachineParameterRow.Fields.IsRead[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.IsRead[(Row)this] = value;
            }
        }

        [DisplayName("Is Write")]
        public bool? IsWrite
        {
            get
            {
                return MachineParameterRow.Fields.IsWrite[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.IsWrite[(Row)this] = value;
            }
        }

        [DisplayName("Row Id")]
        public int? RowId
        {
            get
            {
                return MachineParameterRow.Fields.RowId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.RowId[(Row)this] = value;
            }
        }

        [DisplayName("Is BitWise")]
        public bool? IsBitWise
        {
            get
            {
                return MachineParameterRow.Fields.IsBitWise[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.IsBitWise[(Row)this] = value;
            }
        }




        [DisplayName("BitWise Index")]
        public int? BitWiseIndex
        {
            get
            {
                return MachineParameterRow.Fields.BitWiseIndex[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.BitWiseIndex[(Row)this] = value;
            }
        }

        [DisplayName("Query Type RowId")]
        public int? QueryTypeRowId
        {
            get
            {
                return MachineParameterRow.Fields.QueryTypeRowId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.QueryTypeRowId[(Row)this] = value;
            }
        }

        [DisplayName("Operation Type")]
        public int? OperationType
        {
            get
            {
                return MachineParameterRow.Fields.OperationType[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.OperationType[(Row)this] = value;
            }
        }


        [DisplayName("Operation Value")]
        [Size(18)]
        [Scale(2)]
        public Decimal? OperationValue
        {
            get
            {
                return MachineParameterRow.Fields.OperationValue[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.OperationValue[(Row)this] = value;
            }
        }

        [DisplayName("Is 32 Bit")]
        public bool? Is32Bit
        {
            get
            {
                return MachineParameterRow.Fields.Is32Bit[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.Is32Bit[(Row)this] = value;
            }
        }




        [DisplayName("32 Bit Row Id")]
        public int? Bit32RowId
        {
            get
            {
                return MachineParameterRow.Fields.Bit32RowId[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.Bit32RowId[(Row)this] = value;
            }
        }

        [DisplayName("Is Stop At")]
        public bool? IsStopAt
        {
            get
            {
                return MachineParameterRow.Fields.IsStopAt[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.IsStopAt[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return MachineParameterRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                MachineParameterRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }


        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)MachineParameterRow.Fields.MachineParameterId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return MachineParameterRow.Fields.ParameterName;
            }
        }

        public MachineParameterRow()
          : base((RowFieldsBase)MachineParameterRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        //public class RowFields : RowFieldsBase
        {
            public Int32Field MachineParameterId;
            public Int32Field MachineId;
            public BooleanField IsRealTime;                     // added by JSGURU It comes from Machine table.
            public StringField ColumnName;                      // added by JSGURU
            public Int32Field PickListId;                       // added by JSGURU
            public StringField PickListName;                    // added by JSGURU
            public StringField ParameterName;
            public StringField PlcAddress;
            public StringField Description;
            public Int32Field DataTypeId;
            public BooleanField IsRangeUnlimited;
            public BooleanField IsResetOnBatchCreate;
            public BooleanField IsBatchStartRequired;
            public BooleanField AllowDecimalPoint;
            public BooleanField IsLabelRoll;
            public BooleanField IsStopOnBatchStop;
            public DecimalField Min;
            public DecimalField Max;
            public BooleanField IsUseUnit;
            public Int32Field UnitId;
            public Int32Field StatusId;
           /* public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;*/
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
            public StringField StatusStatusName;
            public StringField DataTypeName;
            public StringField UnitPickListValueName;
            public StringField MachineMachineName;

            public Int32Field Type;
            public Int32Field ReadMachineParameterId;
            public Int32Field ReloadMachineParameterId;
            public BooleanField IsRead;            
            public BooleanField IsWrite;
            public Int32Field RowId;
            public BooleanField IsBitWise;
            public Int32Field BitWiseIndex;
            public Int32Field QueryTypeRowId;
            public Int32Field OperationType;
            public DecimalField OperationValue;
            public BooleanField Is32Bit;
            public Int32Field Bit32RowId;
            public BooleanField IsStopAt;
            public BooleanField IsShowAsMessage;
            public Int32Field DisableParameterId;
            public StringField DisableParameterValue;
            public StringField RecordAddedSource;



            public RowFields()
        : base((string)null, "")
            {
                this.LocalTextPrefix = "MachineCustomization.MachineParameter";
            }
        }
    }
}
