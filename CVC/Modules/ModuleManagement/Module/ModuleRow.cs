// Decompiled with JetBrains decompiler
// Type: CVC.ModuleManagement.Entities.ModuleRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.ModuleManagement.Entities
{
    [ConnectionKey("Default")]
    [TableName("Module")]
    [DisplayName("Module")]
    [InstanceName("Module")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("ModuleManagement:Module:Read")]
    [ModifyPermission("ModuleManagement:Module:Modify")]
    [LookupScript("ModuleManagement.Module", Permission = "Lookup")]
    public sealed class ModuleRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly ModuleRow.RowFields Fields = new ModuleRow.RowFields().Init<ModuleRow.RowFields>();

        [DisplayName("Module Id")]
        [Identity]
        public int? ModuleId
        {
            get
            {
                return ModuleRow.Fields.ModuleId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.ModuleId[(Row)this] = value;
            }
        }

        [DisplayName("Module Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string ModuleName
        {
            get
            {
                return ModuleRow.Fields.ModuleName[(Row)this];
            }
            set
            {
                ModuleRow.Fields.ModuleName[(Row)this] = value;
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
                return ModuleRow.Fields.MachineId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineId[(Row)this] = value;
            }
        }

        public int? Sequence
        {
            get
            {
                return ModuleRow.Fields.Sequence[(Row)this];
            }
            set
            {
                ModuleRow.Fields.Sequence[(Row)this] = value;
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
                return ModuleRow.Fields.StatusId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.StatusId[(Row)this] = value;
            }
        }

        public string EquipmentId
        {
            get
            {
                return ModuleRow.Fields.EquipmentId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.EquipmentId[(Row)this] = value;
            }
        }

        [DisplayName("Serial Number")]
        [Updatable(false)]
        public string SerialNumber
        {
            get
            {
                return ModuleRow.Fields.SerialNumber[(Row)this];
            }
            set
            {
                ModuleRow.Fields.SerialNumber[(Row)this] = value;
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
                return ModuleRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return ModuleRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedDate[(Row)this] = value;
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
                return ModuleRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return ModuleRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Line Id")]
        [Expression("jMachine.[MachineLineId]")]
        public int? MachineMachineLineId
        {
            get
            {
                return ModuleRow.Fields.MachineMachineLineId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Name")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return ModuleRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [DisplayName("Machine Model Number")]
        [Expression("jMachine.[ModelNumber]")]
        public string MachineModelNumber
        {
            get
            {
                return ModuleRow.Fields.MachineModelNumber[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Serial Number")]
        [Expression("jMachine.[SerialNumber]")]
        public string MachineSerialNumber
        {
            get
            {
                return ModuleRow.Fields.MachineSerialNumber[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Make")]
        [Expression("jMachine.[Make]")]
        public string MachineMake
        {
            get
            {
                return ModuleRow.Fields.MachineMake[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Year")]
        [Expression("jMachine.[Year]")]
        public int? MachineYear
        {
            get
            {
                return ModuleRow.Fields.MachineYear[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineYear[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Make")]
        [Expression("jMachine.[PlcMake]")]
        public string MachinePlcMake
        {
            get
            {
                return ModuleRow.Fields.MachinePlcMake[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachinePlcMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Model Number")]
        [Expression("jMachine.[PlcModelNumber]")]
        public string MachinePlcModelNumber
        {
            get
            {
                return ModuleRow.Fields.MachinePlcModelNumber[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachinePlcModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Serial Number")]
        [Expression("jMachine.[PlcSerialNumber]")]
        public string MachinePlcSerialNumber
        {
            get
            {
                return ModuleRow.Fields.MachinePlcSerialNumber[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachinePlcSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Address")]
        [Expression("jMachine.[PLCAddress]")]
        public string MachinePlcAddress
        {
            get
            {
                return ModuleRow.Fields.MachinePlcAddress[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachinePlcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Access Ip Address")]
        [Expression("jMachine.[AccessIPAddress]")]
        public string MachineAccessIpAddress
        {
            get
            {
                return ModuleRow.Fields.MachineAccessIpAddress[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineAccessIpAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Sequence")]
        [Expression("jMachine.[MachineSequence]")]
        public int? MachineMachineSequence
        {
            get
            {
                return ModuleRow.Fields.MachineMachineSequence[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineMachineSequence[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Image")]
        [Expression("jMachine.[MachineImage]")]
        public Stream MachineMachineImage
        {
            get
            {
                return ModuleRow.Fields.MachineMachineImage[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineMachineImage[(Row)this] = value;
            }
        }

        [DisplayName("Machine Status Id")]
        [Expression("jMachine.[StatusId]")]
        public int? MachineStatusId
        {
            get
            {
                return ModuleRow.Fields.MachineStatusId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Description")]
        [Expression("jMachine.[Description]")]
        public string MachineDescription
        {
            get
            {
                return ModuleRow.Fields.MachineDescription[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineDescription[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created By")]
        [Expression("jMachine.[CreatedBy]")]
        public int? MachineCreatedBy
        {
            get
            {
                return ModuleRow.Fields.MachineCreatedBy[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created Date")]
        [Expression("jMachine.[CreatedDate]")]
        public DateTime? MachineCreatedDate
        {
            get
            {
                return ModuleRow.Fields.MachineCreatedDate[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated By")]
        [Expression("jMachine.[UpdatedBy]")]
        public int? MachineUpdatedBy
        {
            get
            {
                return ModuleRow.Fields.MachineUpdatedBy[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated Date")]
        [Expression("jMachine.[UpdatedDate]")]
        public DateTime? MachineUpdatedDate
        {
            get
            {
                return ModuleRow.Fields.MachineUpdatedDate[(Row)this];
            }
            set
            {
                ModuleRow.Fields.MachineUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return ModuleRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                ModuleRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return ModuleRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return ModuleRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return ModuleRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return ModuleRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return ModuleRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return ModuleRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return ModuleRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return ModuleRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return ModuleRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return ModuleRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return ModuleRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return ModuleRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return ModuleRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return ModuleRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return ModuleRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return ModuleRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return ModuleRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return ModuleRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return ModuleRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return ModuleRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return ModuleRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return ModuleRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return ModuleRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return ModuleRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return ModuleRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                ModuleRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return ModuleRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return ModuleRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return ModuleRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return ModuleRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return ModuleRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return ModuleRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return ModuleRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return ModuleRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return ModuleRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return ModuleRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return ModuleRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return ModuleRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return ModuleRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return ModuleRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return ModuleRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return ModuleRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return ModuleRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return ModuleRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return ModuleRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return ModuleRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return ModuleRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return ModuleRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return ModuleRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return ModuleRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return ModuleRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                ModuleRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)ModuleRow.Fields.ModuleId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return ModuleRow.Fields.ModuleName;
            }
        }

        public ModuleRow()
          : base((RowFieldsBase)ModuleRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ModuleId;
            public StringField ModuleName;
            public Int32Field MachineId;
            public Int32Field Sequence;
            public Int32Field StatusId;
            public StringField EquipmentId;
            public StringField SerialNumber;
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
                this.LocalTextPrefix = "ModuleManagement.Module";
            }
        }
    }
}
