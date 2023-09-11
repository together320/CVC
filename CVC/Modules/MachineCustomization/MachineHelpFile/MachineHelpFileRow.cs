// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.MachineHelpFileRow
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
    [TableName("MachineHelpFile")]
    [DisplayName("Machine Help File")]
    [InstanceName("Machine Help File")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MachineHelpFileRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly MachineHelpFileRow.RowFields Fields = new MachineHelpFileRow.RowFields().Init<MachineHelpFileRow.RowFields>();

        [DisplayName("Machine Help File Id")]
        [Identity]
        public int? MachineHelpFileId
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineHelpFileId[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineHelpFileId[(Row)this] = value;
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
                return MachineHelpFileRow.Fields.MachineId[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("File Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string FileName
        {
            get
            {
                return MachineHelpFileRow.Fields.FileName[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.FileName[(Row)this] = value;
            }
        }

        [DisplayName("File Content")]
        public Stream FileContent
        {
            get
            {
                return MachineHelpFileRow.Fields.FileContent[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.FileContent[(Row)this] = value;
            }
        }

        [DisplayName("File Length")]
        public int? FileLength
        {
            get
            {
                return MachineHelpFileRow.Fields.FileLength[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.FileLength[(Row)this] = value;
            }
        }

        [DisplayName("File Extension")]
        [Size(5)]
        public string FileExtension
        {
            get
            {
                return MachineHelpFileRow.Fields.FileExtension[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.FileExtension[(Row)this] = value;
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
                return MachineHelpFileRow.Fields.StatusId[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.StatusId[(Row)this] = value;
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
                return MachineHelpFileRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedDate[(Row)this] = value;
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
                return MachineHelpFileRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Line Id")]
        [Expression("jMachine.[MachineLineId]")]
        public int? MachineMachineLineId
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineMachineLineId[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Name")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [DisplayName("Machine Model Number")]
        [Expression("jMachine.[ModelNumber]")]
        public string MachineModelNumber
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineModelNumber[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Serial Number")]
        [Expression("jMachine.[SerialNumber]")]
        public string MachineSerialNumber
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineSerialNumber[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Make")]
        [Expression("jMachine.[Make]")]
        public string MachineMake
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineMake[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Year")]
        [Expression("jMachine.[Year]")]
        public int? MachineYear
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineYear[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineYear[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Make")]
        [Expression("jMachine.[PlcMake]")]
        public string MachinePlcMake
        {
            get
            {
                return MachineHelpFileRow.Fields.MachinePlcMake[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachinePlcMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Model Number")]
        [Expression("jMachine.[PlcModelNumber]")]
        public string MachinePlcModelNumber
        {
            get
            {
                return MachineHelpFileRow.Fields.MachinePlcModelNumber[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachinePlcModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Serial Number")]
        [Expression("jMachine.[PlcSerialNumber]")]
        public string MachinePlcSerialNumber
        {
            get
            {
                return MachineHelpFileRow.Fields.MachinePlcSerialNumber[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachinePlcSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Address")]
        [Expression("jMachine.[PLCAddress]")]
        public string MachinePlcAddress
        {
            get
            {
                return MachineHelpFileRow.Fields.MachinePlcAddress[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachinePlcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Access Ip Address")]
        [Expression("jMachine.[AccessIPAddress]")]
        public string MachineAccessIpAddress
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineAccessIpAddress[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineAccessIpAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Sequence")]
        [Expression("jMachine.[MachineSequence]")]
        public int? MachineMachineSequence
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineMachineSequence[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineMachineSequence[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Image")]
        [Expression("jMachine.[MachineImage]")]
        public Stream MachineMachineImage
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineMachineImage[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineMachineImage[(Row)this] = value;
            }
        }

        [DisplayName("Machine Status Id")]
        [Expression("jMachine.[StatusId]")]
        public int? MachineStatusId
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineStatusId[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Description")]
        [Expression("jMachine.[Description]")]
        public string MachineDescription
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineDescription[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineDescription[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created By")]
        [Expression("jMachine.[CreatedBy]")]
        public int? MachineCreatedBy
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineCreatedBy[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created Date")]
        [Expression("jMachine.[CreatedDate]")]
        public DateTime? MachineCreatedDate
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineCreatedDate[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated By")]
        [Expression("jMachine.[UpdatedBy]")]
        public int? MachineUpdatedBy
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineUpdatedBy[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated Date")]
        [Expression("jMachine.[UpdatedDate]")]
        public DateTime? MachineUpdatedDate
        {
            get
            {
                return MachineHelpFileRow.Fields.MachineUpdatedDate[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.MachineUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return MachineHelpFileRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return MachineHelpFileRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return MachineHelpFileRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineHelpFileRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)MachineHelpFileRow.Fields.MachineHelpFileId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return MachineHelpFileRow.Fields.FileName;
            }
        }

        public MachineHelpFileRow()
          : base((RowFieldsBase)MachineHelpFileRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MachineHelpFileId;
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
                this.LocalTextPrefix = "MachineCustomization.MachineHelpFile";
            }
        }
    }
}
