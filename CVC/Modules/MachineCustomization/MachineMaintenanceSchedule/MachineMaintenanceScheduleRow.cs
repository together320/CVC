// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.MachineMaintenanceScheduleRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.MachineCustomization.Entities
{
    [ConnectionKey("Default")]
    [TableName("MachineMaintenanceSchedule")]
    [DisplayName("Machine Maintenance Schedule")]
    [InstanceName("Machine Maintenance Schedule")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MachineMaintenanceScheduleRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly MachineMaintenanceScheduleRow.RowFields Fields = new MachineMaintenanceScheduleRow.RowFields().Init<MachineMaintenanceScheduleRow.RowFields>();

        [DisplayName("Machine Main Sch Id")]
        [Identity]
        public int? MachineMainSchId
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineMainSchId[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineMainSchId[(Row)this] = value;
            }
        }

        [DisplayName("Business Entity")]
        [ForeignKey("Machine", "MachineId")]
        [LeftJoin("jMachine")]
        [TextualField("MachineMachineName")]
        public int? MachineId
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineId[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Start Date Time")]
        public DateTime? StartDateTime
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.StartDateTime[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.StartDateTime[(Row)this] = value;
            }
        }

        [DisplayName("End Date Time")]
        public DateTime? EndDateTime
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.EndDateTime[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.EndDateTime[(Row)this] = value;
            }
        }

        [DisplayName("Description")]
        [Size(500)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string Description
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.Description[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.Description[(Row)this] = value;
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
                return MachineMaintenanceScheduleRow.Fields.StatusId[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.StatusId[(Row)this] = value;
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
                return MachineMaintenanceScheduleRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedDate[(Row)this] = value;
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
                return MachineMaintenanceScheduleRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Line Id")]
        [Expression("jMachine.[MachineLineId]")]
        public int? MachineMachineLineId
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineMachineLineId[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Name")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [DisplayName("Machine Model Number")]
        [Expression("jMachine.[ModelNumber]")]
        public string MachineModelNumber
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineModelNumber[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Serial Number")]
        [Expression("jMachine.[SerialNumber]")]
        public string MachineSerialNumber
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineSerialNumber[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Make")]
        [Expression("jMachine.[Make]")]
        public string MachineMake
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineMake[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Year")]
        [Expression("jMachine.[Year]")]
        public int? MachineYear
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineYear[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineYear[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Make")]
        [Expression("jMachine.[PlcMake]")]
        public string MachinePlcMake
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachinePlcMake[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachinePlcMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Model Number")]
        [Expression("jMachine.[PlcModelNumber]")]
        public string MachinePlcModelNumber
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachinePlcModelNumber[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachinePlcModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Serial Number")]
        [Expression("jMachine.[PlcSerialNumber]")]
        public string MachinePlcSerialNumber
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachinePlcSerialNumber[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachinePlcSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Address")]
        [Expression("jMachine.[PLCAddress]")]
        public string MachinePlcAddress
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachinePlcAddress[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachinePlcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Access Ip Address")]
        [Expression("jMachine.[AccessIPAddress]")]
        public string MachineAccessIpAddress
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineAccessIpAddress[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineAccessIpAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Sequence")]
        [Expression("jMachine.[MachineSequence]")]
        public int? MachineMachineSequence
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineMachineSequence[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineMachineSequence[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Image")]
        [Expression("jMachine.[MachineImage]")]
        public Stream MachineMachineImage
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineMachineImage[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineMachineImage[(Row)this] = value;
            }
        }

        [DisplayName("Machine Status Id")]
        [Expression("jMachine.[StatusId]")]
        public int? MachineStatusId
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineStatusId[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Description")]
        [Expression("jMachine.[Description]")]
        public string MachineDescription
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineDescription[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineDescription[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created By")]
        [Expression("jMachine.[CreatedBy]")]
        public int? MachineCreatedBy
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineCreatedBy[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created Date")]
        [Expression("jMachine.[CreatedDate]")]
        public DateTime? MachineCreatedDate
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineCreatedDate[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated By")]
        [Expression("jMachine.[UpdatedBy]")]
        public int? MachineUpdatedBy
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineUpdatedBy[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated Date")]
        [Expression("jMachine.[UpdatedDate]")]
        public DateTime? MachineUpdatedDate
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.MachineUpdatedDate[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.MachineUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineMaintenanceScheduleRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)MachineMaintenanceScheduleRow.Fields.MachineMainSchId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return MachineMaintenanceScheduleRow.Fields.Description;
            }
        }

        public MachineMaintenanceScheduleRow()
          : base((RowFieldsBase)MachineMaintenanceScheduleRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MachineMainSchId;
            public Int32Field MachineId;
            public DateTimeField StartDateTime;
            public DateTimeField EndDateTime;
            public StringField Description;
            public Int32Field StatusId;
            public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;
            public Int32Field MachineMachineLineId;
            public StringField MachineMachineName;
            public StringField MachineModelNumber;
            public StringField MachineSerialNumber;
            public StringField MachineMake;
            public Int32Field MachineYear;
            public StringField MachinePlcMake;
            public StringField MachinePlcModelNumber;
            public StringField MachinePlcSerialNumber;
            public StringField MachinePlcAddress;
            public StringField MachineAccessIpAddress;
            public Int32Field MachineMachineSequence;
            public StreamField MachineMachineImage;
            public Int32Field MachineStatusId;
            public StringField MachineDescription;
            public Int32Field MachineCreatedBy;
            public DateTimeField MachineCreatedDate;
            public Int32Field MachineUpdatedBy;
            public DateTimeField MachineUpdatedDate;
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
              : base((string)null, "")
            {
                this.LocalTextPrefix = "MachineCustomization.MachineMaintenanceSchedule";
            }
        }
    }
}
