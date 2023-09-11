// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.MachineSparePartRow
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
    [TableName("MachineSparePart")]
    [DisplayName("Machine Spare Part")]
    [InstanceName("Machine Spare Part")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MachineSparePartRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly MachineSparePartRow.RowFields Fields = new MachineSparePartRow.RowFields().Init<MachineSparePartRow.RowFields>();

        [DisplayName("Machine Spare Part Id")]
        [Identity]
        public int? MachineSparePartId
        {
            get
            {
                return MachineSparePartRow.Fields.MachineSparePartId[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineSparePartId[(Row)this] = value;
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
                return MachineSparePartRow.Fields.MachineId[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Part Number")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string PartNumber
        {
            get
            {
                return MachineSparePartRow.Fields.PartNumber[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.PartNumber[(Row)this] = value;
            }
        }

        [DisplayName("Part Name")]
        [Size(50)]
        public string PartName
        {
            get
            {
                return MachineSparePartRow.Fields.PartName[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.PartName[(Row)this] = value;
            }
        }

        [DisplayName("Part Description")]
        [Size(500)]
        public string PartDescription
        {
            get
            {
                return MachineSparePartRow.Fields.PartDescription[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.PartDescription[(Row)this] = value;
            }
        }

        [DisplayName("No Of Units Required")]
        public int? NoOfUnitsRequired
        {
            get
            {
                return MachineSparePartRow.Fields.NoOfUnitsRequired[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.NoOfUnitsRequired[(Row)this] = value;
            }
        }

        [DisplayName("Part Image")]
        public Stream PartImage
        {
            get
            {
                return MachineSparePartRow.Fields.PartImage[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.PartImage[(Row)this] = value;
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
                return MachineSparePartRow.Fields.StatusId[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.StatusId[(Row)this] = value;
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
                return MachineSparePartRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedDate[(Row)this] = value;
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
                return MachineSparePartRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Line Id")]
        [Expression("jMachine.[MachineLineId]")]
        public int? MachineMachineLineId
        {
            get
            {
                return MachineSparePartRow.Fields.MachineMachineLineId[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Name")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return MachineSparePartRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [DisplayName("Machine Model Number")]
        [Expression("jMachine.[ModelNumber]")]
        public string MachineModelNumber
        {
            get
            {
                return MachineSparePartRow.Fields.MachineModelNumber[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Serial Number")]
        [Expression("jMachine.[SerialNumber]")]
        public string MachineSerialNumber
        {
            get
            {
                return MachineSparePartRow.Fields.MachineSerialNumber[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Make")]
        [Expression("jMachine.[Make]")]
        public string MachineMake
        {
            get
            {
                return MachineSparePartRow.Fields.MachineMake[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Year")]
        [Expression("jMachine.[Year]")]
        public int? MachineYear
        {
            get
            {
                return MachineSparePartRow.Fields.MachineYear[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineYear[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Make")]
        [Expression("jMachine.[PlcMake]")]
        public string MachinePlcMake
        {
            get
            {
                return MachineSparePartRow.Fields.MachinePlcMake[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachinePlcMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Model Number")]
        [Expression("jMachine.[PlcModelNumber]")]
        public string MachinePlcModelNumber
        {
            get
            {
                return MachineSparePartRow.Fields.MachinePlcModelNumber[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachinePlcModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Serial Number")]
        [Expression("jMachine.[PlcSerialNumber]")]
        public string MachinePlcSerialNumber
        {
            get
            {
                return MachineSparePartRow.Fields.MachinePlcSerialNumber[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachinePlcSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Address")]
        [Expression("jMachine.[PLCAddress]")]
        public string MachinePlcAddress
        {
            get
            {
                return MachineSparePartRow.Fields.MachinePlcAddress[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachinePlcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Access Ip Address")]
        [Expression("jMachine.[AccessIPAddress]")]
        public string MachineAccessIpAddress
        {
            get
            {
                return MachineSparePartRow.Fields.MachineAccessIpAddress[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineAccessIpAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Sequence")]
        [Expression("jMachine.[MachineSequence]")]
        public int? MachineMachineSequence
        {
            get
            {
                return MachineSparePartRow.Fields.MachineMachineSequence[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineMachineSequence[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Image")]
        [Expression("jMachine.[MachineImage]")]
        public Stream MachineMachineImage
        {
            get
            {
                return MachineSparePartRow.Fields.MachineMachineImage[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineMachineImage[(Row)this] = value;
            }
        }

        [DisplayName("Machine Status Id")]
        [Expression("jMachine.[StatusId]")]
        public int? MachineStatusId
        {
            get
            {
                return MachineSparePartRow.Fields.MachineStatusId[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Description")]
        [Expression("jMachine.[Description]")]
        public string MachineDescription
        {
            get
            {
                return MachineSparePartRow.Fields.MachineDescription[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineDescription[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created By")]
        [Expression("jMachine.[CreatedBy]")]
        public int? MachineCreatedBy
        {
            get
            {
                return MachineSparePartRow.Fields.MachineCreatedBy[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created Date")]
        [Expression("jMachine.[CreatedDate]")]
        public DateTime? MachineCreatedDate
        {
            get
            {
                return MachineSparePartRow.Fields.MachineCreatedDate[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated By")]
        [Expression("jMachine.[UpdatedBy]")]
        public int? MachineUpdatedBy
        {
            get
            {
                return MachineSparePartRow.Fields.MachineUpdatedBy[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated Date")]
        [Expression("jMachine.[UpdatedDate]")]
        public DateTime? MachineUpdatedDate
        {
            get
            {
                return MachineSparePartRow.Fields.MachineUpdatedDate[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.MachineUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return MachineSparePartRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return MachineSparePartRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return MachineSparePartRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineSparePartRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)MachineSparePartRow.Fields.MachineSparePartId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return MachineSparePartRow.Fields.PartNumber;
            }
        }

        public MachineSparePartRow()
          : base((RowFieldsBase)MachineSparePartRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MachineSparePartId;
            public Int32Field MachineId;
            public StringField PartNumber;
            public StringField PartName;
            public StringField PartDescription;
            public Int32Field NoOfUnitsRequired;
            public StreamField PartImage;
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
                this.LocalTextPrefix = "MachineCustomization.MachineSparePart";
            }
        }
    }
}
