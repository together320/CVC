// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Entities.BatchMachineWiseRow
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
    [TableName("BatchMachineWise")]
    [DisplayName("Batch Machine Wise")]
    [InstanceName("Batch Machine Wise")]
    [TwoLevelCached(new string[] { })]
   // [ReadPermission("Administration:General")]
   // [ModifyPermission("Administration:General")]
    [ReadPermission("")]
    [ModifyPermission("")]

    public sealed class BatchMachineWiseRow : Row, IIdRow, IEntity, IAuditLog
    {
        public static readonly BatchMachineWiseRow.RowFields Fields = new BatchMachineWiseRow.RowFields().Init<BatchMachineWiseRow.RowFields>();

        [DisplayName("Batch Machine Id")]
        [Identity]
        public int? BatchMachineId
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchMachineId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchMachineId[(Row)this] = value;
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
                return BatchMachineWiseRow.Fields.MachineId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineId[(Row)this] = value;
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
                return BatchMachineWiseRow.Fields.BatchId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchId[(Row)this] = value;
            }
        }

        [DisplayName("Recipe")]
        [ForeignKey("MachineRecipe", "MachineRecipeId")]
        [LeftJoin("jRecipe")]
        [TextualField("RecipeRecipeName")]
        public int? RecipeId
        {
            get
            {
                return BatchMachineWiseRow.Fields.RecipeId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.RecipeId[(Row)this] = value;
            }
        }

        [DisplayName("Is Machine In Use")]
        public short? IsMachineInUse
        {
            get
            {
                return BatchMachineWiseRow.Fields.IsMachineInUse[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.IsMachineInUse[(Row)this] = value;
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
                return BatchMachineWiseRow.Fields.StatusId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.StatusId[(Row)this] = value;
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
                return BatchMachineWiseRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedDate[(Row)this] = value;
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
                return BatchMachineWiseRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Line Id")]
        [Expression("jMachine.[MachineLineId]")]
        public int? MachineMachineLineId
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachineMachineLineId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Name")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [DisplayName("Machine Model Number")]
        [Expression("jMachine.[ModelNumber]")]
        public string MachineModelNumber
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachineModelNumber[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Serial Number")]
        [Expression("jMachine.[SerialNumber]")]
        public string MachineSerialNumber
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachineSerialNumber[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Make")]
        [Expression("jMachine.[Make]")]
        public string MachineMake
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachineMake[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Year")]
        [Expression("jMachine.[Year]")]
        public int? MachineYear
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachineYear[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineYear[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Make")]
        [Expression("jMachine.[PlcMake]")]
        public string MachinePlcMake
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachinePlcMake[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachinePlcMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Model Number")]
        [Expression("jMachine.[PlcModelNumber]")]
        public string MachinePlcModelNumber
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachinePlcModelNumber[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachinePlcModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Serial Number")]
        [Expression("jMachine.[PlcSerialNumber]")]
        public string MachinePlcSerialNumber
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachinePlcSerialNumber[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachinePlcSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Address")]
        [Expression("jMachine.[PLCAddress]")]
        public string MachinePlcAddress
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachinePlcAddress[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachinePlcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Access Ip Address")]
        [Expression("jMachine.[AccessIPAddress]")]
        public string MachineAccessIpAddress
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachineAccessIpAddress[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineAccessIpAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Sequence")]
        [Expression("jMachine.[MachineSequence]")]
        public int? MachineMachineSequence
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachineMachineSequence[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineMachineSequence[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Image")]
        [Expression("jMachine.[MachineImage]")]
        public Stream MachineMachineImage
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachineMachineImage[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineMachineImage[(Row)this] = value;
            }
        }

        [DisplayName("Machine Status Id")]
        [Expression("jMachine.[StatusId]")]
        public int? MachineStatusId
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachineStatusId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Description")]
        [Expression("jMachine.[Description]")]
        public string MachineDescription
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachineDescription[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineDescription[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created By")]
        [Expression("jMachine.[CreatedBy]")]
        public int? MachineCreatedBy
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachineCreatedBy[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created Date")]
        [Expression("jMachine.[CreatedDate]")]
        public DateTime? MachineCreatedDate
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachineCreatedDate[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated By")]
        [Expression("jMachine.[UpdatedBy]")]
        public int? MachineUpdatedBy
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachineUpdatedBy[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated Date")]
        [Expression("jMachine.[UpdatedDate]")]
        public DateTime? MachineUpdatedDate
        {
            get
            {
                return BatchMachineWiseRow.Fields.MachineUpdatedDate[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.MachineUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Name")]
        [Expression("jBatch.[BatchName]")]
        public string BatchBatchName
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchBatchName[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchBatchName[(Row)this] = value;
            }
        }

        [DisplayName("Batch Pack Id")]
        [Expression("jBatch.[PackId]")]
        public int? BatchPackId
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchPackId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchPackId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Start Date Time")]
        [Expression("jBatch.[BatchStartDateTime]")]
        public DateTime? BatchBatchStartDateTime
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchBatchStartDateTime[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchBatchStartDateTime[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch End Date Time")]
        [Expression("jBatch.[BatchEndDateTime]")]
        public DateTime? BatchBatchEndDateTime
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchBatchEndDateTime[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchBatchEndDateTime[(Row)this] = value;
            }
        }

        [DisplayName("Batch Machine Line Id")]
        [Expression("jBatch.[MachineLineId]")]
        public int? BatchMachineLineId
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchMachineLineId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Status")]
        [Expression("jBatch.[BatchStatus]")]
        public string BatchBatchStatus
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchBatchStatus[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchBatchStatus[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Size")]
        [Expression("jBatch.[BatchSize]")]
        public int? BatchBatchSize
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchBatchSize[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchBatchSize[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch For")]
        [Expression("jBatch.[BatchFor]")]
        public string BatchBatchFor
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchBatchFor[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchBatchFor[(Row)this] = value;
            }
        }

        [DisplayName("Batch Number Of Bottles")]
        [Expression("jBatch.[NumberOfBottles]")]
        public int? BatchNumberOfBottles
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchNumberOfBottles[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchNumberOfBottles[(Row)this] = value;
            }
        }

        [DisplayName("Batch Total Good Bottles")]
        [Expression("jBatch.[TotalGoodBottles]")]
        public int? BatchTotalGoodBottles
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchTotalGoodBottles[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchTotalGoodBottles[(Row)this] = value;
            }
        }

        [DisplayName("Batch Total Rejected Bottles")]
        [Expression("jBatch.[TotalRejectedBottles]")]
        public int? BatchTotalRejectedBottles
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchTotalRejectedBottles[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchTotalRejectedBottles[(Row)this] = value;
            }
        }

        [DisplayName("Batch Production Speed")]
        [Expression("jBatch.[ProductionSpeed]")]
        public string BatchProductionSpeed
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchProductionSpeed[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchProductionSpeed[(Row)this] = value;
            }
        }

        [DisplayName("Batch Expiry Date")]
        [Expression("jBatch.[ExpiryDate]")]
        public DateTime? BatchExpiryDate
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchExpiryDate[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Batch Status Id")]
        [Expression("jBatch.[StatusId]")]
        public int? BatchStatusId
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchStatusId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Created By")]
        [Expression("jBatch.[CreatedBy]")]
        public int? BatchCreatedBy
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchCreatedBy[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Batch Created Date")]
        [Expression("jBatch.[CreatedDate]")]
        public DateTime? BatchCreatedDate
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchCreatedDate[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Batch Updated By")]
        [Expression("jBatch.[UpdatedBy]")]
        public int? BatchUpdatedBy
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchUpdatedBy[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Batch Updated Date")]
        [Expression("jBatch.[UpdatedDate]")]
        public DateTime? BatchUpdatedDate
        {
            get
            {
                return BatchMachineWiseRow.Fields.BatchUpdatedDate[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.BatchUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Machine Id")]
        [Expression("jRecipe.[MachineId]")]
        public int? RecipeMachineId
        {
            get
            {
                return BatchMachineWiseRow.Fields.RecipeMachineId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.RecipeMachineId[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Recipe Settings Id")]
        [Expression("jRecipe.[RecipeSettingsId]")]
        public int? RecipeRecipeSettingsId
        {
            get
            {
                return BatchMachineWiseRow.Fields.RecipeRecipeSettingsId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.RecipeRecipeSettingsId[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Recipe Name")]
        [Expression("jRecipe.[RecipeName]")]
        public string RecipeRecipeName
        {
            get
            {
                return BatchMachineWiseRow.Fields.RecipeRecipeName[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.RecipeRecipeName[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Status Id")]
        [Expression("jRecipe.[StatusId]")]
        public int? RecipeStatusId
        {
            get
            {
                return BatchMachineWiseRow.Fields.RecipeStatusId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.RecipeStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Created By")]
        [Expression("jRecipe.[CreatedBy]")]
        public int? RecipeCreatedBy
        {
            get
            {
                return BatchMachineWiseRow.Fields.RecipeCreatedBy[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.RecipeCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Created Date")]
        [Expression("jRecipe.[CreatedDate]")]
        public DateTime? RecipeCreatedDate
        {
            get
            {
                return BatchMachineWiseRow.Fields.RecipeCreatedDate[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.RecipeCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Updated By")]
        [Expression("jRecipe.[UpdatedBy]")]
        public int? RecipeUpdatedBy
        {
            get
            {
                return BatchMachineWiseRow.Fields.RecipeUpdatedBy[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.RecipeUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Updated Date")]
        [Expression("jRecipe.[UpdatedDate]")]
        public DateTime? RecipeUpdatedDate
        {
            get
            {
                return BatchMachineWiseRow.Fields.RecipeUpdatedDate[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.RecipeUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return BatchMachineWiseRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return BatchMachineWiseRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return BatchMachineWiseRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                BatchMachineWiseRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)BatchMachineWiseRow.Fields.BatchMachineId;
            }
        }

        public BatchMachineWiseRow()
          : base((RowFieldsBase)BatchMachineWiseRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field BatchMachineId;
            public Int32Field MachineId;
            public Int32Field BatchId;
            public Int32Field RecipeId;
            public Int16Field IsMachineInUse;
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
            public Int32Field RecipeMachineId;
            public Int32Field RecipeRecipeSettingsId;
            public StringField RecipeRecipeName;
            public Int32Field RecipeStatusId;
            public Int32Field RecipeCreatedBy;
            public DateTimeField RecipeCreatedDate;
            public Int32Field RecipeUpdatedBy;
            public DateTimeField RecipeUpdatedDate;
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
                this.LocalTextPrefix = "Batch.BatchMachineWise";
            }
        }
    }
}
