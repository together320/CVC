// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.MachineHistoryRow
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
    [TableName("MachineHistory")]
    [DisplayName("Machine History")]
    [InstanceName("Machine History")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MachineHistoryRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly MachineHistoryRow.RowFields Fields = new MachineHistoryRow.RowFields().Init<MachineHistoryRow.RowFields>();

        [DisplayName("Machine History Id")]
        [Identity]
        public int? MachineHistoryId
        {
            get
            {
                return MachineHistoryRow.Fields.MachineHistoryId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineHistoryId[(Row)this] = value;
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
                return MachineHistoryRow.Fields.MachineId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Issue Start Date")]
        public DateTime? IssueStartDate
        {
            get
            {
                return MachineHistoryRow.Fields.IssueStartDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.IssueStartDate[(Row)this] = value;
            }
        }

        [DisplayName("Issue Close Date")]
        public DateTime? IssueCloseDate
        {
            get
            {
                return MachineHistoryRow.Fields.IssueCloseDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.IssueCloseDate[(Row)this] = value;
            }
        }

        [DisplayName("Problem Nature")]
        [ForeignKey("PickListValue", "PickListValueId")]
        [LeftJoin("jProblemNature")]
        [TextualField("ProblemNaturePickListValueName")]
        public int? ProblemNatureId
        {
            get
            {
                return MachineHistoryRow.Fields.ProblemNatureId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.ProblemNatureId[(Row)this] = value;
            }
        }

        [DisplayName("Spare Part")]
        [ForeignKey("MachineSparePart", "MachineSparePartId")]
        [LeftJoin("jSparePart")]
        [TextualField("SparePartPartNumber")]
        public int? SparePartId
        {
            get
            {
                return MachineHistoryRow.Fields.SparePartId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.SparePartId[(Row)this] = value;
            }
        }

        [DisplayName("Problem Description")]
        [Size(500)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string ProblemDescription
        {
            get
            {
                return MachineHistoryRow.Fields.ProblemDescription[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.ProblemDescription[(Row)this] = value;
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
                return MachineHistoryRow.Fields.StatusId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.StatusId[(Row)this] = value;
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
                return MachineHistoryRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedDate[(Row)this] = value;
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
                return MachineHistoryRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Line Id")]
        [Expression("jMachine.[MachineLineId]")]
        public int? MachineMachineLineId
        {
            get
            {
                return MachineHistoryRow.Fields.MachineMachineLineId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Name")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return MachineHistoryRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [DisplayName("Machine Model Number")]
        [Expression("jMachine.[ModelNumber]")]
        public string MachineModelNumber
        {
            get
            {
                return MachineHistoryRow.Fields.MachineModelNumber[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Serial Number")]
        [Expression("jMachine.[SerialNumber]")]
        public string MachineSerialNumber
        {
            get
            {
                return MachineHistoryRow.Fields.MachineSerialNumber[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Make")]
        [Expression("jMachine.[Make]")]
        public string MachineMake
        {
            get
            {
                return MachineHistoryRow.Fields.MachineMake[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Year")]
        [Expression("jMachine.[Year]")]
        public int? MachineYear
        {
            get
            {
                return MachineHistoryRow.Fields.MachineYear[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineYear[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Make")]
        [Expression("jMachine.[PlcMake]")]
        public string MachinePlcMake
        {
            get
            {
                return MachineHistoryRow.Fields.MachinePlcMake[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachinePlcMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Model Number")]
        [Expression("jMachine.[PlcModelNumber]")]
        public string MachinePlcModelNumber
        {
            get
            {
                return MachineHistoryRow.Fields.MachinePlcModelNumber[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachinePlcModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Serial Number")]
        [Expression("jMachine.[PlcSerialNumber]")]
        public string MachinePlcSerialNumber
        {
            get
            {
                return MachineHistoryRow.Fields.MachinePlcSerialNumber[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachinePlcSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Address")]
        [Expression("jMachine.[PLCAddress]")]
        public string MachinePlcAddress
        {
            get
            {
                return MachineHistoryRow.Fields.MachinePlcAddress[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachinePlcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Access Ip Address")]
        [Expression("jMachine.[AccessIPAddress]")]
        public string MachineAccessIpAddress
        {
            get
            {
                return MachineHistoryRow.Fields.MachineAccessIpAddress[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineAccessIpAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Sequence")]
        [Expression("jMachine.[MachineSequence]")]
        public int? MachineMachineSequence
        {
            get
            {
                return MachineHistoryRow.Fields.MachineMachineSequence[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineMachineSequence[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Image")]
        [Expression("jMachine.[MachineImage]")]
        public Stream MachineMachineImage
        {
            get
            {
                return MachineHistoryRow.Fields.MachineMachineImage[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineMachineImage[(Row)this] = value;
            }
        }

        [DisplayName("Machine Status Id")]
        [Expression("jMachine.[StatusId]")]
        public int? MachineStatusId
        {
            get
            {
                return MachineHistoryRow.Fields.MachineStatusId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Description")]
        [Expression("jMachine.[Description]")]
        public string MachineDescription
        {
            get
            {
                return MachineHistoryRow.Fields.MachineDescription[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineDescription[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created By")]
        [Expression("jMachine.[CreatedBy]")]
        public int? MachineCreatedBy
        {
            get
            {
                return MachineHistoryRow.Fields.MachineCreatedBy[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created Date")]
        [Expression("jMachine.[CreatedDate]")]
        public DateTime? MachineCreatedDate
        {
            get
            {
                return MachineHistoryRow.Fields.MachineCreatedDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated By")]
        [Expression("jMachine.[UpdatedBy]")]
        public int? MachineUpdatedBy
        {
            get
            {
                return MachineHistoryRow.Fields.MachineUpdatedBy[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated Date")]
        [Expression("jMachine.[UpdatedDate]")]
        public DateTime? MachineUpdatedDate
        {
            get
            {
                return MachineHistoryRow.Fields.MachineUpdatedDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.MachineUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Problem Nature Pick List Id")]
        [Expression("jProblemNature.[PickListId]")]
        public int? ProblemNaturePickListId
        {
            get
            {
                return MachineHistoryRow.Fields.ProblemNaturePickListId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.ProblemNaturePickListId[(Row)this] = value;
            }
        }

        [DisplayName("Problem Nature Pick List Value Name")]
        [Expression("jProblemNature.[PickListValueName]")]
        public string ProblemNaturePickListValueName
        {
            get
            {
                return MachineHistoryRow.Fields.ProblemNaturePickListValueName[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.ProblemNaturePickListValueName[(Row)this] = value;
            }
        }

        [DisplayName("Problem Nature Status Id")]
        [Expression("jProblemNature.[StatusId]")]
        public int? ProblemNatureStatusId
        {
            get
            {
                return MachineHistoryRow.Fields.ProblemNatureStatusId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.ProblemNatureStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Problem Nature Created By")]
        [Expression("jProblemNature.[CreatedBy]")]
        public int? ProblemNatureCreatedBy
        {
            get
            {
                return MachineHistoryRow.Fields.ProblemNatureCreatedBy[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.ProblemNatureCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Problem Nature Created Date")]
        [Expression("jProblemNature.[CreatedDate]")]
        public DateTime? ProblemNatureCreatedDate
        {
            get
            {
                return MachineHistoryRow.Fields.ProblemNatureCreatedDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.ProblemNatureCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Problem Nature Updated By")]
        [Expression("jProblemNature.[UpdatedBy]")]
        public int? ProblemNatureUpdatedBy
        {
            get
            {
                return MachineHistoryRow.Fields.ProblemNatureUpdatedBy[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.ProblemNatureUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Problem Nature Updated Date")]
        [Expression("jProblemNature.[UpdatedDate]")]
        public DateTime? ProblemNatureUpdatedDate
        {
            get
            {
                return MachineHistoryRow.Fields.ProblemNatureUpdatedDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.ProblemNatureUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Spare Part Machine Id")]
        [Expression("jSparePart.[MachineId]")]
        public int? SparePartMachineId
        {
            get
            {
                return MachineHistoryRow.Fields.SparePartMachineId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.SparePartMachineId[(Row)this] = value;
            }
        }

        [DisplayName("Spare Part Part Number")]
        [Expression("jSparePart.[PartNumber]")]
        public string SparePartPartNumber
        {
            get
            {
                return MachineHistoryRow.Fields.SparePartPartNumber[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.SparePartPartNumber[(Row)this] = value;
            }
        }

        [DisplayName("Spare Part Part Name")]
        [Expression("jSparePart.[PartName]")]
        public string SparePartPartName
        {
            get
            {
                return MachineHistoryRow.Fields.SparePartPartName[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.SparePartPartName[(Row)this] = value;
            }
        }

        [DisplayName("Spare Part Part Description")]
        [Expression("jSparePart.[PartDescription]")]
        public string SparePartPartDescription
        {
            get
            {
                return MachineHistoryRow.Fields.SparePartPartDescription[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.SparePartPartDescription[(Row)this] = value;
            }
        }

        [DisplayName("Spare Part No Of Units Required")]
        [Expression("jSparePart.[NoOfUnitsRequired]")]
        public int? SparePartNoOfUnitsRequired
        {
            get
            {
                return MachineHistoryRow.Fields.SparePartNoOfUnitsRequired[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.SparePartNoOfUnitsRequired[(Row)this] = value;
            }
        }

        [DisplayName("Spare Part Part Image")]
        [Expression("jSparePart.[PartImage]")]
        public Stream SparePartPartImage
        {
            get
            {
                return MachineHistoryRow.Fields.SparePartPartImage[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.SparePartPartImage[(Row)this] = value;
            }
        }

        [DisplayName("Spare Part Status Id")]
        [Expression("jSparePart.[StatusId]")]
        public int? SparePartStatusId
        {
            get
            {
                return MachineHistoryRow.Fields.SparePartStatusId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.SparePartStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Spare Part Created By")]
        [Expression("jSparePart.[CreatedBy]")]
        public int? SparePartCreatedBy
        {
            get
            {
                return MachineHistoryRow.Fields.SparePartCreatedBy[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.SparePartCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Spare Part Created Date")]
        [Expression("jSparePart.[CreatedDate]")]
        public DateTime? SparePartCreatedDate
        {
            get
            {
                return MachineHistoryRow.Fields.SparePartCreatedDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.SparePartCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Spare Part Updated By")]
        [Expression("jSparePart.[UpdatedBy]")]
        public int? SparePartUpdatedBy
        {
            get
            {
                return MachineHistoryRow.Fields.SparePartUpdatedBy[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.SparePartUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Spare Part Updated Date")]
        [Expression("jSparePart.[UpdatedDate]")]
        public DateTime? SparePartUpdatedDate
        {
            get
            {
                return MachineHistoryRow.Fields.SparePartUpdatedDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.SparePartUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return MachineHistoryRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return MachineHistoryRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return MachineHistoryRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineHistoryRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)MachineHistoryRow.Fields.MachineHistoryId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return MachineHistoryRow.Fields.ProblemDescription;
            }
        }

        public MachineHistoryRow()
          : base((RowFieldsBase)MachineHistoryRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MachineHistoryId;
            public Int32Field MachineId;
            public DateTimeField IssueStartDate;
            public DateTimeField IssueCloseDate;
            public Int32Field ProblemNatureId;
            public Int32Field SparePartId;
            public StringField ProblemDescription;
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
            public Int32Field ProblemNaturePickListId;
            public StringField ProblemNaturePickListValueName;
            public Int32Field ProblemNatureStatusId;
            public Int32Field ProblemNatureCreatedBy;
            public DateTimeField ProblemNatureCreatedDate;
            public Int32Field ProblemNatureUpdatedBy;
            public DateTimeField ProblemNatureUpdatedDate;
            public Int32Field SparePartMachineId;
            public StringField SparePartPartNumber;
            public StringField SparePartPartName;
            public StringField SparePartPartDescription;
            public Int32Field SparePartNoOfUnitsRequired;
            public StreamField SparePartPartImage;
            public Int32Field SparePartStatusId;
            public Int32Field SparePartCreatedBy;
            public DateTimeField SparePartCreatedDate;
            public Int32Field SparePartUpdatedBy;
            public DateTimeField SparePartUpdatedDate;
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
                this.LocalTextPrefix = "MachineCustomization.MachineHistory";
            }
        }
    }
}
