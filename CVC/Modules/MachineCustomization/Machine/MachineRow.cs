// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.MachineRow
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

namespace CVC.MachineCustomization.Entities
{
    [ConnectionKey("Default")]
    [TableName("Machine")]
    [DisplayName("Business Entity")]
    [InstanceName("Machine")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("MachineCustomization:Machine:Read")]
    [ModifyPermission("MachineCustomization:Machine:Modify")]
    [LookupScript("MachineCustomization.Machine", Permission = "Lookup")]

    public sealed class MachineRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly MachineRow.RowFields Fields = new MachineRow.RowFields().Init<MachineRow.RowFields>();

        [DisplayName("Machine Id"), LookupInclude]
        [Identity]

        public int? MachineId
        {
            get
            {
                return MachineRow.Fields.MachineId[(Row)this];
            }
            set
            {
                MachineRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Line Id")]
        public int? MachineLineId
        {
            get
            {
                return MachineRow.Fields.MachineLineId[(Row)this];
            }
            set
            {
                MachineRow.Fields.MachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Entity Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [Required]
        //[NotNull]
        [Unique]
        public string MachineName
        {
            get
            {
                return MachineRow.Fields.MachineName[(Row)this];
            }
            set
            {
                MachineRow.Fields.MachineName[(Row)this] = value;
            }
        }

        [DisplayName("Model Number")]
        [Size(50)]
        public string ModelNumber
        {
            get
            {
                return MachineRow.Fields.ModelNumber[(Row)this];
            }
            set
            {
                MachineRow.Fields.ModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Serial Number")]
        [Size(50)]
        public string SerialNumber
        {
            get
            {
                return MachineRow.Fields.SerialNumber[(Row)this];
            }
            set
            {
                MachineRow.Fields.SerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Make")]
        [Size(50)]
        public string Make
        {
            get
            {
                return MachineRow.Fields.Make[(Row)this];
            }
            set
            {
                MachineRow.Fields.Make[(Row)this] = value;
            }
        }

        [DisplayName("Year")]
        public int? Year
        {
            get
            {
                return MachineRow.Fields.Year[(Row)this];
            }
            set
            {
                MachineRow.Fields.Year[(Row)this] = value;
            }
        }

        [DisplayName("Plc Make")]
        [Size(50)]
        [Required]
        //[NotNull]
        public string PlcMake
        {
            get
            {
                return MachineRow.Fields.PlcMake[(Row)this];
            }
            set
            {
                MachineRow.Fields.PlcMake[(Row)this] = value;
            }
        }

        [DisplayName("Plc Model Number")]
        [Size(50)]
        public string PlcModelNumber
        {
            get
            {
                return MachineRow.Fields.PlcModelNumber[(Row)this];
            }
            set
            {
                MachineRow.Fields.PlcModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Plc Serial Number")]
        [Size(50)]
        public string PlcSerialNumber
        {
            get
            {
                return MachineRow.Fields.PlcSerialNumber[(Row)this];
            }
            set
            {
                MachineRow.Fields.PlcSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Plc Address")]
        [Column("PLCAddress")]
        [Size(50)]
        public string PlcAddress
        {
            get
            {
                return MachineRow.Fields.PlcAddress[(Row)this];
            }
            set
            {
                MachineRow.Fields.PlcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Access Ip Address")]
        [Column("AccessIPAddress")]
        [Size(50)]
        [Required]
        //[NotNull]
        public string AccessIpAddress
        {
            get
            {
                return MachineRow.Fields.AccessIpAddress[(Row)this];
            }
            set
            {
                MachineRow.Fields.AccessIpAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Sequence")]
        [Required]
        //[NotNull]
        public int? MachineSequence
        {
            get
            {
                return MachineRow.Fields.MachineSequence[(Row)this];
            }
            set
            {
                MachineRow.Fields.MachineSequence[(Row)this] = value;
            }
        }

        [DisplayName("Entity Image")]
        public Stream MachineImage
        {
            get
            {
                return MachineRow.Fields.MachineImage[(Row)this];
            }
            set
            {
                MachineRow.Fields.MachineImage[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [ForeignKey("Status", "StatusId")]
        [LeftJoin("jStatus")]
        [TextualField("StatusStatusName")]
        //To make status as default "Active"
        [DefaultValue(1)]
        [Required]
        //[NotNull]
        public int? StatusId
        {
            get
            {
                return MachineRow.Fields.StatusId[(Row)this];
            }
            set
            {
                MachineRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return MachineRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                MachineRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Description")]
        [Size(100)]
        public string Description
        {
            get
            {
                return MachineRow.Fields.Description[(Row)this];
            }
            set
            {
                MachineRow.Fields.Description[(Row)this] = value;
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
                return MachineRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return MachineRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedDate[(Row)this] = value;
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
                return MachineRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return MachineRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return MachineRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return MachineRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return MachineRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return MachineRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return MachineRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return MachineRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return MachineRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return MachineRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return MachineRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return MachineRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return MachineRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return MachineRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return MachineRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return MachineRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return MachineRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return MachineRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return MachineRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return MachineRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return MachineRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return MachineRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return MachineRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return MachineRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return MachineRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return MachineRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return MachineRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return MachineRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return MachineRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return MachineRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return MachineRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return MachineRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return MachineRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return MachineRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return MachineRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return MachineRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return MachineRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return MachineRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return MachineRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return MachineRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return MachineRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return MachineRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return MachineRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return MachineRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return MachineRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return MachineRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return MachineRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return MachineRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return MachineRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return MachineRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }
        [DisplayName("Timer For Alarm (In Seconds)")]
        public int? TimerForAlarm
        {
            get
            {
                return MachineRow.Fields.TimerForAlarm[(Row)this];
            }
            set
            {
                MachineRow.Fields.TimerForAlarm[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return MachineRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                MachineRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }

        // added by Denis for RS 3.4 dated 7/20/2021
        [DisplayName("Table Name")]
        public int? TableId
        {
            get { return Fields.TableId[this]; }
            set { Fields.TableId[this] = value; }
        }

        // added by Denis for RS 3.4 dated 7/20/2021
        [DisplayName("Table Name")]
        public string TableName
        {
            get { return Fields.TableName[this]; }
            set { Fields.TableName[this] = value; }
        }

        // added by Denis for RS 3.3 dated 7/20/2021
        [DisplayName("Is Realtime"), DefaultValue(true)]
        public Boolean? IsRealTime
        {
            get { return Fields.IsRealTime[this]; }
            set { Fields.IsRealTime[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)MachineRow.Fields.MachineId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return MachineRow.Fields.MachineName;
            }
        }

        public MachineRow()
          : base((RowFieldsBase)MachineRow.Fields)
        {

        }
        public class RowFields : LoggingRow.LoggingRowFields
        // public class RowFields : RowFieldsBase
        {
            public Int32Field MachineId;
            public Int32Field MachineLineId;
            public StringField MachineName;
            public StringField ModelNumber;
            public StringField SerialNumber;
            public StringField Make;
            public Int32Field Year;
            public StringField PlcMake;
            public StringField PlcModelNumber;
            public StringField PlcSerialNumber;
            public StringField PlcAddress;
            public StringField AccessIpAddress;
            public Int32Field MachineSequence;
            public StreamField MachineImage;
            public Int32Field StatusId;
            public StringField Description;
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
            public Int32Field TimerForAlarm;
            public StringField RecordAddedSource;
            public BooleanField IsRealTime;         // determines whether the signal is coming in Real Time or coming from the Assigned Table.
            public Int32Field TableId;              // Table Object ID assigned to the Business Entity (BE).
            public StringField TableName;           // Table Name assigned to the Business Entity (BE).

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "MachineCustomization.Machine";
            }
        }
    }
}
