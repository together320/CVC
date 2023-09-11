﻿// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.MachineSpecificationRow
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
    [TableName("MachineSpecification")]
    [DisplayName("Machine Specification")]
    [InstanceName("Machine Specification")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MachineSpecificationRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly MachineSpecificationRow.RowFields Fields = new MachineSpecificationRow.RowFields().Init<MachineSpecificationRow.RowFields>();

        [DisplayName("Machine Spec Id")]
        [Identity]
        public int? MachineSpecId
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineSpecId[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineSpecId[(Row)this] = value;
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
                return MachineSpecificationRow.Fields.MachineId[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Description")]
        [Size(5000)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string Description
        {
            get
            {
                return MachineSpecificationRow.Fields.Description[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.Description[(Row)this] = value;
            }
        }

        [DisplayName("Details")]
        [Size(5000)]
        public string Details
        {
            get
            {
                return MachineSpecificationRow.Fields.Details[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.Details[(Row)this] = value;
            }
        }

        [DisplayName("Machine Image")]
        public Stream MachineImage
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineImage[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineImage[(Row)this] = value;
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
                return MachineSpecificationRow.Fields.StatusId[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.StatusId[(Row)this] = value;
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
                return MachineSpecificationRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedDate[(Row)this] = value;
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
                return MachineSpecificationRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Line Id")]
        [Expression("jMachine.[MachineLineId]")]
        public int? MachineMachineLineId
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineMachineLineId[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Name")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [DisplayName("Machine Model Number")]
        [Expression("jMachine.[ModelNumber]")]
        public string MachineModelNumber
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineModelNumber[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Serial Number")]
        [Expression("jMachine.[SerialNumber]")]
        public string MachineSerialNumber
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineSerialNumber[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Make")]
        [Expression("jMachine.[Make]")]
        public string MachineMake
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineMake[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Year")]
        [Expression("jMachine.[Year]")]
        public int? MachineYear
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineYear[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineYear[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Make")]
        [Expression("jMachine.[PlcMake]")]
        public string MachinePlcMake
        {
            get
            {
                return MachineSpecificationRow.Fields.MachinePlcMake[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachinePlcMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Model Number")]
        [Expression("jMachine.[PlcModelNumber]")]
        public string MachinePlcModelNumber
        {
            get
            {
                return MachineSpecificationRow.Fields.MachinePlcModelNumber[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachinePlcModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Serial Number")]
        [Expression("jMachine.[PlcSerialNumber]")]
        public string MachinePlcSerialNumber
        {
            get
            {
                return MachineSpecificationRow.Fields.MachinePlcSerialNumber[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachinePlcSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Address")]
        [Expression("jMachine.[PLCAddress]")]
        public string MachinePlcAddress
        {
            get
            {
                return MachineSpecificationRow.Fields.MachinePlcAddress[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachinePlcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Access Ip Address")]
        [Expression("jMachine.[AccessIPAddress]")]
        public string MachineAccessIpAddress
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineAccessIpAddress[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineAccessIpAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Sequence")]
        [Expression("jMachine.[MachineSequence]")]
        public int? MachineMachineSequence
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineMachineSequence[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineMachineSequence[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Image")]
        [Expression("jMachine.[MachineImage]")]
        public Stream MachineMachineImage
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineMachineImage[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineMachineImage[(Row)this] = value;
            }
        }

        [DisplayName("Machine Status Id")]
        [Expression("jMachine.[StatusId]")]
        public int? MachineStatusId
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineStatusId[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Description")]
        [Expression("jMachine.[Description]")]
        public string MachineDescription
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineDescription[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineDescription[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created By")]
        [Expression("jMachine.[CreatedBy]")]
        public int? MachineCreatedBy
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineCreatedBy[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created Date")]
        [Expression("jMachine.[CreatedDate]")]
        public DateTime? MachineCreatedDate
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineCreatedDate[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated By")]
        [Expression("jMachine.[UpdatedBy]")]
        public int? MachineUpdatedBy
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineUpdatedBy[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated Date")]
        [Expression("jMachine.[UpdatedDate]")]
        public DateTime? MachineUpdatedDate
        {
            get
            {
                return MachineSpecificationRow.Fields.MachineUpdatedDate[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.MachineUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return MachineSpecificationRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return MachineSpecificationRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return MachineSpecificationRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineSpecificationRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)MachineSpecificationRow.Fields.MachineSpecId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return MachineSpecificationRow.Fields.Description;
            }
        }

        public MachineSpecificationRow()
          : base((RowFieldsBase)MachineSpecificationRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MachineSpecId;
            public Int32Field MachineId;
            public StringField Description;
            public StringField Details;
            public StreamField MachineImage;
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
                this.LocalTextPrefix = "MachineCustomization.MachineSpecification";
            }
        }
    }
}
