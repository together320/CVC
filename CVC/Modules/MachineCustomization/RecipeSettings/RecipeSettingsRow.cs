// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.RecipeSettingsRow
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
    [TableName("RecipeSettings")]
    [DisplayName("Recipe Settings")]
    [InstanceName("Recipe Settings")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class RecipeSettingsRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly RecipeSettingsRow.RowFields Fields = new RecipeSettingsRow.RowFields().Init<RecipeSettingsRow.RowFields>();

        [DisplayName("Recipe Settings Id")]
        [Identity]
        public int? RecipeSettingsId
        {
            get
            {
                return RecipeSettingsRow.Fields.RecipeSettingsId[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.RecipeSettingsId[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string RecipeSettingsName
        {
            get
            {
                return RecipeSettingsRow.Fields.RecipeSettingsName[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.RecipeSettingsName[(Row)this] = value;
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
                return RecipeSettingsRow.Fields.MachineId[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineId[(Row)this] = value;
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
                return RecipeSettingsRow.Fields.StatusId[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.StatusId[(Row)this] = value;
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
                return RecipeSettingsRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedDate[(Row)this] = value;
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
                return RecipeSettingsRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Line Id")]
        [Expression("jMachine.[MachineLineId]")]
        public int? MachineMachineLineId
        {
            get
            {
                return RecipeSettingsRow.Fields.MachineMachineLineId[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Name")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return RecipeSettingsRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [DisplayName("Machine Model Number")]
        [Expression("jMachine.[ModelNumber]")]
        public string MachineModelNumber
        {
            get
            {
                return RecipeSettingsRow.Fields.MachineModelNumber[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Serial Number")]
        [Expression("jMachine.[SerialNumber]")]
        public string MachineSerialNumber
        {
            get
            {
                return RecipeSettingsRow.Fields.MachineSerialNumber[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Make")]
        [Expression("jMachine.[Make]")]
        public string MachineMake
        {
            get
            {
                return RecipeSettingsRow.Fields.MachineMake[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Year")]
        [Expression("jMachine.[Year]")]
        public int? MachineYear
        {
            get
            {
                return RecipeSettingsRow.Fields.MachineYear[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineYear[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Make")]
        [Expression("jMachine.[PlcMake]")]
        public string MachinePlcMake
        {
            get
            {
                return RecipeSettingsRow.Fields.MachinePlcMake[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachinePlcMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Model Number")]
        [Expression("jMachine.[PlcModelNumber]")]
        public string MachinePlcModelNumber
        {
            get
            {
                return RecipeSettingsRow.Fields.MachinePlcModelNumber[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachinePlcModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Serial Number")]
        [Expression("jMachine.[PlcSerialNumber]")]
        public string MachinePlcSerialNumber
        {
            get
            {
                return RecipeSettingsRow.Fields.MachinePlcSerialNumber[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachinePlcSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Address")]
        [Expression("jMachine.[PLCAddress]")]
        public string MachinePlcAddress
        {
            get
            {
                return RecipeSettingsRow.Fields.MachinePlcAddress[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachinePlcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Access Ip Address")]
        [Expression("jMachine.[AccessIPAddress]")]
        public string MachineAccessIpAddress
        {
            get
            {
                return RecipeSettingsRow.Fields.MachineAccessIpAddress[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineAccessIpAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Sequence")]
        [Expression("jMachine.[MachineSequence]")]
        public int? MachineMachineSequence
        {
            get
            {
                return RecipeSettingsRow.Fields.MachineMachineSequence[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineMachineSequence[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Image")]
        [Expression("jMachine.[MachineImage]")]
        public Stream MachineMachineImage
        {
            get
            {
                return RecipeSettingsRow.Fields.MachineMachineImage[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineMachineImage[(Row)this] = value;
            }
        }

        [DisplayName("Machine Status Id")]
        [Expression("jMachine.[StatusId]")]
        public int? MachineStatusId
        {
            get
            {
                return RecipeSettingsRow.Fields.MachineStatusId[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Description")]
        [Expression("jMachine.[Description]")]
        public string MachineDescription
        {
            get
            {
                return RecipeSettingsRow.Fields.MachineDescription[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineDescription[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created By")]
        [Expression("jMachine.[CreatedBy]")]
        public int? MachineCreatedBy
        {
            get
            {
                return RecipeSettingsRow.Fields.MachineCreatedBy[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created Date")]
        [Expression("jMachine.[CreatedDate]")]
        public DateTime? MachineCreatedDate
        {
            get
            {
                return RecipeSettingsRow.Fields.MachineCreatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated By")]
        [Expression("jMachine.[UpdatedBy]")]
        public int? MachineUpdatedBy
        {
            get
            {
                return RecipeSettingsRow.Fields.MachineUpdatedBy[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated Date")]
        [Expression("jMachine.[UpdatedDate]")]
        public DateTime? MachineUpdatedDate
        {
            get
            {
                return RecipeSettingsRow.Fields.MachineUpdatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.MachineUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return RecipeSettingsRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return RecipeSettingsRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return RecipeSettingsRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                RecipeSettingsRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)RecipeSettingsRow.Fields.RecipeSettingsId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return RecipeSettingsRow.Fields.RecipeSettingsName;
            }
        }

        public RecipeSettingsRow()
          : base((RowFieldsBase)RecipeSettingsRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field RecipeSettingsId;
            public StringField RecipeSettingsName;
            public Int32Field MachineId;
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
                this.LocalTextPrefix = "MachineCustomization.RecipeSettings";
            }
        }
    }
}
