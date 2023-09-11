// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.MachineVideoRow
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
    [TableName("MachineVideo")]
    [DisplayName("Machine Video")]
    [InstanceName("Machine Video")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MachineVideoRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly MachineVideoRow.RowFields Fields = new MachineVideoRow.RowFields().Init<MachineVideoRow.RowFields>();

        [DisplayName("Machine Video Id")]
        [Identity]
        public int? MachineVideoId
        {
            get
            {
                return MachineVideoRow.Fields.MachineVideoId[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineVideoId[(Row)this] = value;
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
                return MachineVideoRow.Fields.MachineId[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("File Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string FileName
        {
            get
            {
                return MachineVideoRow.Fields.FileName[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.FileName[(Row)this] = value;
            }
        }

        [DisplayName("File Content")]
        public Stream FileContent
        {
            get
            {
                return MachineVideoRow.Fields.FileContent[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.FileContent[(Row)this] = value;
            }
        }

        [DisplayName("File Length")]
        public int? FileLength
        {
            get
            {
                return MachineVideoRow.Fields.FileLength[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.FileLength[(Row)this] = value;
            }
        }

        [DisplayName("File Extension")]
        [Size(5)]
        public string FileExtension
        {
            get
            {
                return MachineVideoRow.Fields.FileExtension[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.FileExtension[(Row)this] = value;
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
                return MachineVideoRow.Fields.StatusId[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.StatusId[(Row)this] = value;
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
                return MachineVideoRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return MachineVideoRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedDate[(Row)this] = value;
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
                return MachineVideoRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Line Id")]
        [Expression("jMachine.[MachineLineId]")]
        public int? MachineMachineLineId
        {
            get
            {
                return MachineVideoRow.Fields.MachineMachineLineId[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Name")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return MachineVideoRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [DisplayName("Machine Model Number")]
        [Expression("jMachine.[ModelNumber]")]
        public string MachineModelNumber
        {
            get
            {
                return MachineVideoRow.Fields.MachineModelNumber[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Serial Number")]
        [Expression("jMachine.[SerialNumber]")]
        public string MachineSerialNumber
        {
            get
            {
                return MachineVideoRow.Fields.MachineSerialNumber[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Make")]
        [Expression("jMachine.[Make]")]
        public string MachineMake
        {
            get
            {
                return MachineVideoRow.Fields.MachineMake[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Year")]
        [Expression("jMachine.[Year]")]
        public int? MachineYear
        {
            get
            {
                return MachineVideoRow.Fields.MachineYear[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineYear[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Make")]
        [Expression("jMachine.[PlcMake]")]
        public string MachinePlcMake
        {
            get
            {
                return MachineVideoRow.Fields.MachinePlcMake[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachinePlcMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Model Number")]
        [Expression("jMachine.[PlcModelNumber]")]
        public string MachinePlcModelNumber
        {
            get
            {
                return MachineVideoRow.Fields.MachinePlcModelNumber[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachinePlcModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Serial Number")]
        [Expression("jMachine.[PlcSerialNumber]")]
        public string MachinePlcSerialNumber
        {
            get
            {
                return MachineVideoRow.Fields.MachinePlcSerialNumber[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachinePlcSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Address")]
        [Expression("jMachine.[PLCAddress]")]
        public string MachinePlcAddress
        {
            get
            {
                return MachineVideoRow.Fields.MachinePlcAddress[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachinePlcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Access Ip Address")]
        [Expression("jMachine.[AccessIPAddress]")]
        public string MachineAccessIpAddress
        {
            get
            {
                return MachineVideoRow.Fields.MachineAccessIpAddress[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineAccessIpAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Sequence")]
        [Expression("jMachine.[MachineSequence]")]
        public int? MachineMachineSequence
        {
            get
            {
                return MachineVideoRow.Fields.MachineMachineSequence[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineMachineSequence[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Image")]
        [Expression("jMachine.[MachineImage]")]
        public Stream MachineMachineImage
        {
            get
            {
                return MachineVideoRow.Fields.MachineMachineImage[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineMachineImage[(Row)this] = value;
            }
        }

        [DisplayName("Machine Status Id")]
        [Expression("jMachine.[StatusId]")]
        public int? MachineStatusId
        {
            get
            {
                return MachineVideoRow.Fields.MachineStatusId[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Description")]
        [Expression("jMachine.[Description]")]
        public string MachineDescription
        {
            get
            {
                return MachineVideoRow.Fields.MachineDescription[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineDescription[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created By")]
        [Expression("jMachine.[CreatedBy]")]
        public int? MachineCreatedBy
        {
            get
            {
                return MachineVideoRow.Fields.MachineCreatedBy[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created Date")]
        [Expression("jMachine.[CreatedDate]")]
        public DateTime? MachineCreatedDate
        {
            get
            {
                return MachineVideoRow.Fields.MachineCreatedDate[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated By")]
        [Expression("jMachine.[UpdatedBy]")]
        public int? MachineUpdatedBy
        {
            get
            {
                return MachineVideoRow.Fields.MachineUpdatedBy[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated Date")]
        [Expression("jMachine.[UpdatedDate]")]
        public DateTime? MachineUpdatedDate
        {
            get
            {
                return MachineVideoRow.Fields.MachineUpdatedDate[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.MachineUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return MachineVideoRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return MachineVideoRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return MachineVideoRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return MachineVideoRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineVideoRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)MachineVideoRow.Fields.MachineVideoId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return MachineVideoRow.Fields.FileName;
            }
        }

        public MachineVideoRow()
          : base((RowFieldsBase)MachineVideoRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MachineVideoId;
            public Int32Field MachineId;
            public StringField FileName;
            public StreamField FileContent;
            public Int32Field FileLength;
            public StringField FileExtension;
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
                this.LocalTextPrefix = "MachineCustomization.MachineVideo";
            }
        }
    }
}
