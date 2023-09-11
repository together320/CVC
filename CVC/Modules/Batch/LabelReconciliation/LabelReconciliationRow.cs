// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Entities.LabelReconciliationRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.Batch.Entities
{
    [ConnectionKey("Default")]
    [TableName("LabelReconciliation")]
    [DisplayName("Label Reconciliation")]
    [InstanceName("Label Reconciliation")]
    [TwoLevelCached(new string[] { })]
    //[ReadPermission("Administration:General")]
    //[ModifyPermission("Administration:General")]
    [ReadPermission("")]
    [ModifyPermission("")]

    public sealed class LabelReconciliationRow : Row, IIdRow, IEntity, IAuditLog
    {
        public static readonly LabelReconciliationRow.RowFields Fields = new LabelReconciliationRow.RowFields().Init<LabelReconciliationRow.RowFields>();

        [DisplayName("Label Rec Id")]
        [Identity]
        public int? LabelRecId
        {
            get
            {
                return LabelReconciliationRow.Fields.LabelRecId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.LabelRecId[(Row)this] = value;
            }
        }

        [DisplayName("Batch")]
        [ForeignKey("Batch", "BatchId")]
        [LeftJoin("jBatch")]
        [TextualField("BatchBatchName")]
        public int? BatchId
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchId[(Row)this] = value;
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
                return LabelReconciliationRow.Fields.MachineId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Label Roll")]
        [ForeignKey("LabelRoll", "LabelRollId")]
        [LeftJoin("jLabelRoll")]
        [TextualField("LabelRollRemark")]
        public int? LabelRollId
        {
            get
            {
                return LabelReconciliationRow.Fields.LabelRollId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.LabelRollId[(Row)this] = value;
            }
        }

        [DisplayName("Rejected Labels")]
        public int? RejectedLabels
        {
            get
            {
                return LabelReconciliationRow.Fields.RejectedLabels[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.RejectedLabels[(Row)this] = value;
            }
        }

        [DisplayName("Label Lost")]
        public int? LabelLost
        {
            get
            {
                return LabelReconciliationRow.Fields.LabelLost[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.LabelLost[(Row)this] = value;
            }
        }

        [DisplayName("No Label On Roll")]
        public int? NoLabelOnRoll
        {
            get
            {
                return LabelReconciliationRow.Fields.NoLabelOnRoll[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.NoLabelOnRoll[(Row)this] = value;
            }
        }

        [DisplayName("Label Balance")]
        public int? LabelBalance
        {
            get
            {
                return LabelReconciliationRow.Fields.LabelBalance[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.LabelBalance[(Row)this] = value;
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
                return LabelReconciliationRow.Fields.StatusId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.StatusId[(Row)this] = value;
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
                return LabelReconciliationRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedDate[(Row)this] = value;
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
                return LabelReconciliationRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Name")]
        [Expression("jBatch.[BatchName]")]
        public string BatchBatchName
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchBatchName[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchBatchName[(Row)this] = value;
            }
        }

        [DisplayName("Batch Pack Id")]
        [Expression("jBatch.[PackId]")]
        public int? BatchPackId
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchPackId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchPackId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Start Date Time")]
        [Expression("jBatch.[BatchStartDateTime]")]
        public DateTime? BatchBatchStartDateTime
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchBatchStartDateTime[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchBatchStartDateTime[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch End Date Time")]
        [Expression("jBatch.[BatchEndDateTime]")]
        public DateTime? BatchBatchEndDateTime
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchBatchEndDateTime[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchBatchEndDateTime[(Row)this] = value;
            }
        }

        [DisplayName("Batch Machine Line Id")]
        [Expression("jBatch.[MachineLineId]")]
        public int? BatchMachineLineId
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchMachineLineId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Status")]
        [Expression("jBatch.[BatchStatus]")]
        public string BatchBatchStatus
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchBatchStatus[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchBatchStatus[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Size")]
        [Expression("jBatch.[BatchSize]")]
        public int? BatchBatchSize
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchBatchSize[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchBatchSize[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch For")]
        [Expression("jBatch.[BatchFor]")]
        public string BatchBatchFor
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchBatchFor[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchBatchFor[(Row)this] = value;
            }
        }

        [DisplayName("Batch Number Of Bottles")]
        [Expression("jBatch.[NumberOfBottles]")]
        public int? BatchNumberOfBottles
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchNumberOfBottles[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchNumberOfBottles[(Row)this] = value;
            }
        }

        [DisplayName("Batch Total Good Bottles")]
        [Expression("jBatch.[TotalGoodBottles]")]
        public int? BatchTotalGoodBottles
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchTotalGoodBottles[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchTotalGoodBottles[(Row)this] = value;
            }
        }

        [DisplayName("Batch Total Rejected Bottles")]
        [Expression("jBatch.[TotalRejectedBottles]")]
        public int? BatchTotalRejectedBottles
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchTotalRejectedBottles[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchTotalRejectedBottles[(Row)this] = value;
            }
        }

        [DisplayName("Batch Production Speed")]
        [Expression("jBatch.[ProductionSpeed]")]
        public string BatchProductionSpeed
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchProductionSpeed[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchProductionSpeed[(Row)this] = value;
            }
        }

        [DisplayName("Batch Expiry Date")]
        [Expression("jBatch.[ExpiryDate]")]
        public DateTime? BatchExpiryDate
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchExpiryDate[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Batch Status Id")]
        [Expression("jBatch.[StatusId]")]
        public int? BatchStatusId
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchStatusId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Created By")]
        [Expression("jBatch.[CreatedBy]")]
        public int? BatchCreatedBy
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchCreatedBy[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Batch Created Date")]
        [Expression("jBatch.[CreatedDate]")]
        public DateTime? BatchCreatedDate
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchCreatedDate[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Batch Updated By")]
        [Expression("jBatch.[UpdatedBy]")]
        public int? BatchUpdatedBy
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchUpdatedBy[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Batch Updated Date")]
        [Expression("jBatch.[UpdatedDate]")]
        public DateTime? BatchUpdatedDate
        {
            get
            {
                return LabelReconciliationRow.Fields.BatchUpdatedDate[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.BatchUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Line Id")]
        [Expression("jMachine.[MachineLineId]")]
        public int? MachineMachineLineId
        {
            get
            {
                return LabelReconciliationRow.Fields.MachineMachineLineId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Name")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return LabelReconciliationRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [DisplayName("Machine Model Number")]
        [Expression("jMachine.[ModelNumber]")]
        public string MachineModelNumber
        {
            get
            {
                return LabelReconciliationRow.Fields.MachineModelNumber[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Serial Number")]
        [Expression("jMachine.[SerialNumber]")]
        public string MachineSerialNumber
        {
            get
            {
                return LabelReconciliationRow.Fields.MachineSerialNumber[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Make")]
        [Expression("jMachine.[Make]")]
        public string MachineMake
        {
            get
            {
                return LabelReconciliationRow.Fields.MachineMake[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Year")]
        [Expression("jMachine.[Year]")]
        public int? MachineYear
        {
            get
            {
                return LabelReconciliationRow.Fields.MachineYear[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineYear[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Make")]
        [Expression("jMachine.[PlcMake]")]
        public string MachinePlcMake
        {
            get
            {
                return LabelReconciliationRow.Fields.MachinePlcMake[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachinePlcMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Model Number")]
        [Expression("jMachine.[PlcModelNumber]")]
        public string MachinePlcModelNumber
        {
            get
            {
                return LabelReconciliationRow.Fields.MachinePlcModelNumber[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachinePlcModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Serial Number")]
        [Expression("jMachine.[PlcSerialNumber]")]
        public string MachinePlcSerialNumber
        {
            get
            {
                return LabelReconciliationRow.Fields.MachinePlcSerialNumber[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachinePlcSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Address")]
        [Expression("jMachine.[PLCAddress]")]
        public string MachinePlcAddress
        {
            get
            {
                return LabelReconciliationRow.Fields.MachinePlcAddress[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachinePlcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Access Ip Address")]
        [Expression("jMachine.[AccessIPAddress]")]
        public string MachineAccessIpAddress
        {
            get
            {
                return LabelReconciliationRow.Fields.MachineAccessIpAddress[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineAccessIpAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Sequence")]
        [Expression("jMachine.[MachineSequence]")]
        public int? MachineMachineSequence
        {
            get
            {
                return LabelReconciliationRow.Fields.MachineMachineSequence[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineMachineSequence[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Image")]
        [Expression("jMachine.[MachineImage]")]
        public Stream MachineMachineImage
        {
            get
            {
                return LabelReconciliationRow.Fields.MachineMachineImage[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineMachineImage[(Row)this] = value;
            }
        }

        [DisplayName("Machine Status Id")]
        [Expression("jMachine.[StatusId]")]
        public int? MachineStatusId
        {
            get
            {
                return LabelReconciliationRow.Fields.MachineStatusId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Description")]
        [Expression("jMachine.[Description]")]
        public string MachineDescription
        {
            get
            {
                return LabelReconciliationRow.Fields.MachineDescription[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineDescription[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created By")]
        [Expression("jMachine.[CreatedBy]")]
        public int? MachineCreatedBy
        {
            get
            {
                return LabelReconciliationRow.Fields.MachineCreatedBy[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created Date")]
        [Expression("jMachine.[CreatedDate]")]
        public DateTime? MachineCreatedDate
        {
            get
            {
                return LabelReconciliationRow.Fields.MachineCreatedDate[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated By")]
        [Expression("jMachine.[UpdatedBy]")]
        public int? MachineUpdatedBy
        {
            get
            {
                return LabelReconciliationRow.Fields.MachineUpdatedBy[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated Date")]
        [Expression("jMachine.[UpdatedDate]")]
        public DateTime? MachineUpdatedDate
        {
            get
            {
                return LabelReconciliationRow.Fields.MachineUpdatedDate[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.MachineUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Label Roll Batch Id")]
        [Expression("jLabelRoll.[BatchId]")]
        public int? LabelRollBatchId
        {
            get
            {
                return LabelReconciliationRow.Fields.LabelRollBatchId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.LabelRollBatchId[(Row)this] = value;
            }
        }

        [DisplayName("Label Roll Machine Id")]
        [Expression("jLabelRoll.[MachineId]")]
        public int? LabelRollMachineId
        {
            get
            {
                return LabelReconciliationRow.Fields.LabelRollMachineId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.LabelRollMachineId[(Row)this] = value;
            }
        }

        [DisplayName("Label Roll Label Roll Number")]
        [Expression("jLabelRoll.[LabelRollNumber]")]
        public int? LabelRollLabelRollNumber
        {
            get
            {
                return LabelReconciliationRow.Fields.LabelRollLabelRollNumber[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.LabelRollLabelRollNumber[(Row)this] = value;
            }
        }

        [DisplayName("Label Roll Number Of Labels")]
        [Expression("jLabelRoll.[NumberOfLabels]")]
        public int? LabelRollNumberOfLabels
        {
            get
            {
                return LabelReconciliationRow.Fields.LabelRollNumberOfLabels[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.LabelRollNumberOfLabels[(Row)this] = value;
            }
        }

        [DisplayName("Label Roll Remark")]
        [Expression("jLabelRoll.[Remark]")]
        public string LabelRollRemark
        {
            get
            {
                return LabelReconciliationRow.Fields.LabelRollRemark[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.LabelRollRemark[(Row)this] = value;
            }
        }

        [DisplayName("Label Roll Status Id")]
        [Expression("jLabelRoll.[StatusId]")]
        public int? LabelRollStatusId
        {
            get
            {
                return LabelReconciliationRow.Fields.LabelRollStatusId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.LabelRollStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Label Roll Created By")]
        [Expression("jLabelRoll.[CreatedBy]")]
        public int? LabelRollCreatedBy
        {
            get
            {
                return LabelReconciliationRow.Fields.LabelRollCreatedBy[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.LabelRollCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Label Roll Created Date")]
        [Expression("jLabelRoll.[CreatedDate]")]
        public DateTime? LabelRollCreatedDate
        {
            get
            {
                return LabelReconciliationRow.Fields.LabelRollCreatedDate[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.LabelRollCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Label Roll Updated By")]
        [Expression("jLabelRoll.[UpdatedBy]")]
        public int? LabelRollUpdatedBy
        {
            get
            {
                return LabelReconciliationRow.Fields.LabelRollUpdatedBy[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.LabelRollUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Label Roll Updated Date")]
        [Expression("jLabelRoll.[UpdatedDate]")]
        public DateTime? LabelRollUpdatedDate
        {
            get
            {
                return LabelReconciliationRow.Fields.LabelRollUpdatedDate[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.LabelRollUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return LabelReconciliationRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return LabelReconciliationRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return LabelReconciliationRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                LabelReconciliationRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)LabelReconciliationRow.Fields.LabelRecId;
            }
        }

        public LabelReconciliationRow()
          : base((RowFieldsBase)LabelReconciliationRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field LabelRecId;
            public Int32Field BatchId;
            public Int32Field MachineId;
            public Int32Field LabelRollId;
            public Int32Field RejectedLabels;
            public Int32Field LabelLost;
            public Int32Field NoLabelOnRoll;
            public Int32Field LabelBalance;
            public Int32Field StatusId;
            public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;
            public StringField BatchBatchName;
            public Int32Field BatchPackId;
            public DateTimeField BatchBatchStartDateTime;
            public DateTimeField BatchBatchEndDateTime;
            public Int32Field BatchMachineLineId;
            public StringField BatchBatchStatus;
            public Int32Field BatchBatchSize;
            public StringField BatchBatchFor;
            public Int32Field BatchNumberOfBottles;
            public Int32Field BatchTotalGoodBottles;
            public Int32Field BatchTotalRejectedBottles;
            public StringField BatchProductionSpeed;
            public DateTimeField BatchExpiryDate;
            public Int32Field BatchStatusId;
            public Int32Field BatchCreatedBy;
            public DateTimeField BatchCreatedDate;
            public Int32Field BatchUpdatedBy;
            public DateTimeField BatchUpdatedDate;
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
            public Int32Field LabelRollBatchId;
            public Int32Field LabelRollMachineId;
            public Int32Field LabelRollLabelRollNumber;
            public Int32Field LabelRollNumberOfLabels;
            public StringField LabelRollRemark;
            public Int32Field LabelRollStatusId;
            public Int32Field LabelRollCreatedBy;
            public DateTimeField LabelRollCreatedDate;
            public Int32Field LabelRollUpdatedBy;
            public DateTimeField LabelRollUpdatedDate;
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
                this.LocalTextPrefix = "Batch.LabelReconciliation";
            }
        }
    }
}
