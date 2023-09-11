// Decompiled with JetBrains decompiler
// Type: CVC.Report.Entities.AuditLogRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration;
using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.Report.Entities
{
    [ConnectionKey("Default")]
    [Serenity.Data.Mapping.TableName("AuditLog")]
    [DisplayName("Audit Log")]
    [InstanceName("Audit Log")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Report:AuditLog:Read")]
    [LookupEditor(typeof(MachineCustomization.Scripts.MachineLookUp))]
    public sealed class AuditLogRow : Row, IIdRow, IEntity, INameRow
    {
        public static readonly AuditLogRow.RowFields Fields = new AuditLogRow.RowFields().Init<AuditLogRow.RowFields>();

        [DisplayName("Audit Log Id")]
        [Identity]
        public long? AuditLogId
        {
            get
            {
                return AuditLogRow.Fields.AuditLogId[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.AuditLogId[(Row)this] = value;
            }
        }

        [DisplayName("User")]
        [ForeignKey("Users", "UserId")]
        [LeftJoin("jUser")]
        [TextualField("UserEmployeeId")]
        public int? UserId
        {
            get
            {
                return AuditLogRow.Fields.UserId[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserId[(Row)this] = value;
            }
        }

        [DisplayName("User Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string UserName
        {
            get
            {
                return AuditLogRow.Fields.UserName[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserName[(Row)this] = value;
            }
        }

        [DisplayName("Action")]
        [Size(50)]
        public string Action
        {
            get
            {
                return AuditLogRow.Fields.Action[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.Action[(Row)this] = value;
            }
        }

        [DisplayName("Changed On")]
        public DateTime? ChangedOn
        {
            get
            {
                return AuditLogRow.Fields.ChangedOn[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.ChangedOn[(Row)this] = value;
            }
        }

        [DisplayName("Table Name")]
        [Size(50)]
        public string TableName
        {
            get
            {
                return AuditLogRow.Fields.TableName[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.TableName[(Row)this] = value;
            }
        }

        [DisplayName("Row Id")]
        public int? RowId
        {
            get
            {
                return AuditLogRow.Fields.RowId[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.RowId[(Row)this] = value;
            }
        }

        [DisplayName("Module")]
        [Size(500)]
        public string Module
        {
            get
            {
                return AuditLogRow.Fields.Module[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.Module[(Row)this] = value;
            }
        }

        [DisplayName("Page")]
        [Size(500)]
        public string Page
        {
            get
            {
                return AuditLogRow.Fields.Page[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.Page[(Row)this] = value;
            }
        }

        [DisplayName("Field Name")]
        [Size(50)]
        public string FieldName
        {
            get
            {
                return AuditLogRow.Fields.FieldName[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.FieldName[(Row)this] = value;
            }
        }

        [DisplayName("Old Value")]
        [Size(1000)]
        public string OldValue
        {
            get
            {
                return AuditLogRow.Fields.OldValue[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.OldValue[(Row)this] = value;
            }
        }

        [DisplayName("New Value")]
        [Size(1000)]
        public string NewValue
        {
            get
            {
                return AuditLogRow.Fields.NewValue[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.NewValue[(Row)this] = value;
            }
        }

        [DisplayName("Comments")]
        [Size(500)]
        public string Comments
        {
            get
            {
                return AuditLogRow.Fields.Comments[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.Comments[(Row)this] = value;
            }
        }

        [DisplayName("Pcip Address")]
        [Column("PCIPAddress")]
        [Size(50)]
        public string PcipAddress
        {
            get
            {
                return AuditLogRow.Fields.PcipAddress[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.PcipAddress[(Row)this] = value;
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
                return AuditLogRow.Fields.BatchId[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Number")]
        [Size(50)]
        public string BatchName
        {
            get
            {
                return AuditLogRow.Fields.BatchName[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchName[(Row)this] = value;
            }
        }

        [DisplayName("Business Entity")]
        [ForeignKey("Machine", "MachineId")]
        [LeftJoin("jMachine")]
        [TextualField("MachineMachineName")]

        //[DisplayName("Sales Person"), ForeignKey("[dbo].[Machine]", "MachineId"), LeftJoin("jMachine"), TextualField("MachineName")]
       [LookupEditor(typeof(MachineRow), FilterField = "StatusId", FilterValue = 1)]
        //[Width(100), QuickSearch, QuickFilter(true), Placeholder("Admin Can Modify.")]
        public int? MachineId
        {
            get
            {
                return AuditLogRow.Fields.MachineId[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Entity Name")]
        [Size(50)]
        public string MachineName
        {
            get
            {
                return AuditLogRow.Fields.MachineName[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineName[(Row)this] = value;
            }
        }

        [DisplayName("User Employee Id")]
        [Expression("jUser.[EmployeeId]")]
        public string UserEmployeeId
        {
            get
            {
                return AuditLogRow.Fields.UserEmployeeId[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("User First Name")]
        [Expression("jUser.[FirstName]")]
        public string UserFirstName
        {
            get
            {
                return AuditLogRow.Fields.UserFirstName[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserFirstName[(Row)this] = value;
            }
        }

        [DisplayName("User Last Name")]
        [Expression("jUser.[LastName]")]
        public string UserLastName
        {
            get
            {
                return AuditLogRow.Fields.UserLastName[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserLastName[(Row)this] = value;
            }
        }

        [DisplayName("User Department Id")]
        [Expression("jUser.[DepartmentId]")]
        public int? UserDepartmentId
        {
            get
            {
                return AuditLogRow.Fields.UserDepartmentId[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("User Designation")]
        [Expression("jUser.[Designation]")]
        public string UserDesignation
        {
            get
            {
                return AuditLogRow.Fields.UserDesignation[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserDesignation[(Row)this] = value;
            }
        }

        [DisplayName("User Mobile Code")]
        [Expression("jUser.[MobileCode]")]
        public int? UserMobileCode
        {
            get
            {
                return AuditLogRow.Fields.UserMobileCode[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("User Mobile Number")]
        [Expression("jUser.[MobileNumber]")]
        public int? UserMobileNumber
        {
            get
            {
                return AuditLogRow.Fields.UserMobileNumber[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("User Email")]
        [Expression("jUser.[Email]")]
        public string UserEmail
        {
            get
            {
                return AuditLogRow.Fields.UserEmail[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserEmail[(Row)this] = value;
            }
        }

        [DisplayName("User Username")]
        [Expression("jUser.[Username]")]
        public string UserUsername
        {
            get
            {
                return AuditLogRow.Fields.UserUsername[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserUsername[(Row)this] = value;
            }
        }

        [DisplayName("User Password Hash")]
        [Expression("jUser.[PasswordHash]")]
        public string UserPasswordHash
        {
            get
            {
                return AuditLogRow.Fields.UserPasswordHash[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("User Password Salt")]
        [Expression("jUser.[PasswordSalt]")]
        public string UserPasswordSalt
        {
            get
            {
                return AuditLogRow.Fields.UserPasswordSalt[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("User User Image")]
        [Expression("jUser.[UserImage]")]
        public Stream UserUserImage
        {
            get
            {
                return AuditLogRow.Fields.UserUserImage[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserUserImage[(Row)this] = value;
            }
        }

        [DisplayName("User Address")]
        [Expression("jUser.[Address]")]
        public string UserAddress
        {
            get
            {
                return AuditLogRow.Fields.UserAddress[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserAddress[(Row)this] = value;
            }
        }

        [DisplayName("User City Id")]
        [Expression("jUser.[CityId]")]
        public int? UserCityId
        {
            get
            {
                return AuditLogRow.Fields.UserCityId[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserCityId[(Row)this] = value;
            }
        }

        [DisplayName("User Pin Code")]
        [Expression("jUser.[PinCode]")]
        public string UserPinCode
        {
            get
            {
                return AuditLogRow.Fields.UserPinCode[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserPinCode[(Row)this] = value;
            }
        }

        [DisplayName("User Role Id")]
        [Expression("jUser.[RoleId]")]
        public int? UserRoleId
        {
            get
            {
                return AuditLogRow.Fields.UserRoleId[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserRoleId[(Row)this] = value;
            }
        }

        [DisplayName("User Password Expiry Date")]
        [Expression("jUser.[PasswordExpiryDate]")]
        public DateTime? UserPasswordExpiryDate
        {
            get
            {
                return AuditLogRow.Fields.UserPasswordExpiryDate[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("User Is Forgot Password")]
        [Expression("jUser.[IsForgotPassword]")]
        public short? UserIsForgotPassword
        {
            get
            {
                return AuditLogRow.Fields.UserIsForgotPassword[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("User Is Password Change On Login")]
        [Expression("jUser.[IsPasswordChangeOnLogin]")]
        public bool? UserIsPasswordChangeOnLogin
        {
            get
            {
                return AuditLogRow.Fields.UserIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("User Is User Hidden")]
        [Expression("jUser.[IsUserHidden]")]
        public short? UserIsUserHidden
        {
            get
            {
                return AuditLogRow.Fields.UserIsUserHidden[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("User Status Id")]
        [Expression("jUser.[StatusId]")]
        public int? UserStatusId
        {
            get
            {
                return AuditLogRow.Fields.UserStatusId[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserStatusId[(Row)this] = value;
            }
        }

        [DisplayName("User Created By")]
        [Expression("jUser.[CreatedBy]")]
        public int? UserCreatedBy
        {
            get
            {
                return AuditLogRow.Fields.UserCreatedBy[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("User Created Date")]
        [Expression("jUser.[CreatedDate]")]
        public DateTime? UserCreatedDate
        {
            get
            {
                return AuditLogRow.Fields.UserCreatedDate[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("User Updated By")]
        [Expression("jUser.[UpdatedBy]")]
        public int? UserUpdatedBy
        {
            get
            {
                return AuditLogRow.Fields.UserUpdatedBy[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("User Updated Date")]
        [Expression("jUser.[UpdatedDate]")]
        public DateTime? UserUpdatedDate
        {
            get
            {
                return AuditLogRow.Fields.UserUpdatedDate[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.UserUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Name")]
        [Expression("jBatch.[BatchName]")]
        public string BatchBatchName
        {
            get
            {
                return AuditLogRow.Fields.BatchBatchName[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchBatchName[(Row)this] = value;
            }
        }

        [DisplayName("Batch Pack Id")]
        [Expression("jBatch.[PackId]")]
        public int? BatchPackId
        {
            get
            {
                return AuditLogRow.Fields.BatchPackId[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchPackId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Start Date Time")]
        [Expression("jBatch.[BatchStartDateTime]")]
        public DateTime? BatchBatchStartDateTime
        {
            get
            {
                return AuditLogRow.Fields.BatchBatchStartDateTime[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchBatchStartDateTime[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch End Date Time")]
        [Expression("jBatch.[BatchEndDateTime]")]
        public DateTime? BatchBatchEndDateTime
        {
            get
            {
                return AuditLogRow.Fields.BatchBatchEndDateTime[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchBatchEndDateTime[(Row)this] = value;
            }
        }

        [DisplayName("Batch Machine Line Id")]
        [Expression("jBatch.[MachineLineId]")]
        public int? BatchMachineLineId
        {
            get
            {
                return AuditLogRow.Fields.BatchMachineLineId[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Status")]
        [Expression("jBatch.[BatchStatus]")]
        public string BatchBatchStatus
        {
            get
            {
                return AuditLogRow.Fields.BatchBatchStatus[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchBatchStatus[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Size")]
        [Expression("jBatch.[BatchSize]")]
        public int? BatchBatchSize
        {
            get
            {
                return AuditLogRow.Fields.BatchBatchSize[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchBatchSize[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch For")]
        [Expression("jBatch.[BatchFor]")]
        public string BatchBatchFor
        {
            get
            {
                return AuditLogRow.Fields.BatchBatchFor[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchBatchFor[(Row)this] = value;
            }
        }

        [DisplayName("Batch Number Of Bottles")]
        [Expression("jBatch.[NumberOfBottles]")]
        public int? BatchNumberOfBottles
        {
            get
            {
                return AuditLogRow.Fields.BatchNumberOfBottles[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchNumberOfBottles[(Row)this] = value;
            }
        }

        [DisplayName("Batch Total Good Bottles")]
        [Expression("jBatch.[TotalGoodBottles]")]
        public int? BatchTotalGoodBottles
        {
            get
            {
                return AuditLogRow.Fields.BatchTotalGoodBottles[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchTotalGoodBottles[(Row)this] = value;
            }
        }

        [DisplayName("Batch Total Rejected Bottles")]
        [Expression("jBatch.[TotalRejectedBottles]")]
        public int? BatchTotalRejectedBottles
        {
            get
            {
                return AuditLogRow.Fields.BatchTotalRejectedBottles[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchTotalRejectedBottles[(Row)this] = value;
            }
        }

        [DisplayName("Batch Production Speed")]
        [Expression("jBatch.[ProductionSpeed]")]
        public string BatchProductionSpeed
        {
            get
            {
                return AuditLogRow.Fields.BatchProductionSpeed[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchProductionSpeed[(Row)this] = value;
            }
        }

        [DisplayName("Batch Expiry Date")]
        [Expression("jBatch.[ExpiryDate]")]
        public DateTime? BatchExpiryDate
        {
            get
            {
                return AuditLogRow.Fields.BatchExpiryDate[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Batch Status Id")]
        [Expression("jBatch.[StatusId]")]
        public int? BatchStatusId
        {
            get
            {
                return AuditLogRow.Fields.BatchStatusId[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Created By")]
        [Expression("jBatch.[CreatedBy]")]
        public int? BatchCreatedBy
        {
            get
            {
                return AuditLogRow.Fields.BatchCreatedBy[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Batch Created Date")]
        [Expression("jBatch.[CreatedDate]")]
        public DateTime? BatchCreatedDate
        {
            get
            {
                return AuditLogRow.Fields.BatchCreatedDate[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Batch Updated By")]
        [Expression("jBatch.[UpdatedBy]")]
        public int? BatchUpdatedBy
        {
            get
            {
                return AuditLogRow.Fields.BatchUpdatedBy[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Batch Updated Date")]
        [Expression("jBatch.[UpdatedDate]")]
        public DateTime? BatchUpdatedDate
        {
            get
            {
                return AuditLogRow.Fields.BatchUpdatedDate[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.BatchUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Line Id")]
        [Expression("jMachine.[MachineLineId]")]
        public int? MachineMachineLineId
        {
            get
            {
                return AuditLogRow.Fields.MachineMachineLineId[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Name")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return AuditLogRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [DisplayName("Machine Model Number")]
        [Expression("jMachine.[ModelNumber]")]
        public string MachineModelNumber
        {
            get
            {
                return AuditLogRow.Fields.MachineModelNumber[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Serial Number")]
        [Expression("jMachine.[SerialNumber]")]
        public string MachineSerialNumber
        {
            get
            {
                return AuditLogRow.Fields.MachineSerialNumber[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Make")]
        [Expression("jMachine.[Make]")]
        public string MachineMake
        {
            get
            {
                return AuditLogRow.Fields.MachineMake[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Year")]
        [Expression("jMachine.[Year]")]
        public int? MachineYear
        {
            get
            {
                return AuditLogRow.Fields.MachineYear[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineYear[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Make")]
        [Expression("jMachine.[PlcMake]")]
        public string MachinePlcMake
        {
            get
            {
                return AuditLogRow.Fields.MachinePlcMake[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachinePlcMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Model Number")]
        [Expression("jMachine.[PlcModelNumber]")]
        public string MachinePlcModelNumber
        {
            get
            {
                return AuditLogRow.Fields.MachinePlcModelNumber[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachinePlcModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Serial Number")]
        [Expression("jMachine.[PlcSerialNumber]")]
        public string MachinePlcSerialNumber
        {
            get
            {
                return AuditLogRow.Fields.MachinePlcSerialNumber[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachinePlcSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Address")]
        [Expression("jMachine.[PLCAddress]")]
        public string MachinePlcAddress
        {
            get
            {
                return AuditLogRow.Fields.MachinePlcAddress[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachinePlcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Access Ip Address")]
        [Expression("jMachine.[AccessIPAddress]")]
        public string MachineAccessIpAddress
        {
            get
            {
                return AuditLogRow.Fields.MachineAccessIpAddress[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineAccessIpAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Sequence")]
        [Expression("jMachine.[MachineSequence]")]
        public int? MachineMachineSequence
        {
            get
            {
                return AuditLogRow.Fields.MachineMachineSequence[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineMachineSequence[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Image")]
        [Expression("jMachine.[MachineImage]")]
        public Stream MachineMachineImage
        {
            get
            {
                return AuditLogRow.Fields.MachineMachineImage[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineMachineImage[(Row)this] = value;
            }
        }

        [DisplayName("Machine Status Id")]
        [Expression("jMachine.[StatusId]")]
        public int? MachineStatusId
        {
            get
            {
                return AuditLogRow.Fields.MachineStatusId[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Description")]
        [Expression("jMachine.[Description]")]
        public string MachineDescription
        {
            get
            {
                return AuditLogRow.Fields.MachineDescription[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineDescription[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created By")]
        [Expression("jMachine.[CreatedBy]")]
        public int? MachineCreatedBy
        {
            get
            {
                return AuditLogRow.Fields.MachineCreatedBy[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created Date")]
        [Expression("jMachine.[CreatedDate]")]
        public DateTime? MachineCreatedDate
        {
            get
            {
                return AuditLogRow.Fields.MachineCreatedDate[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated By")]
        [Expression("jMachine.[UpdatedBy]")]
        public int? MachineUpdatedBy
        {
            get
            {
                return AuditLogRow.Fields.MachineUpdatedBy[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated Date")]
        [Expression("jMachine.[UpdatedDate]")]
        public DateTime? MachineUpdatedDate
        {
            get
            {
                return AuditLogRow.Fields.MachineUpdatedDate[(Row)this];
            }
            set
            {
                AuditLogRow.Fields.MachineUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)AuditLogRow.Fields.AuditLogId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return AuditLogRow.Fields.UserName;
            }
        }

        public AuditLogRow()
          : base((RowFieldsBase)AuditLogRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field AuditLogId;
            public Int32Field UserId;
            public StringField UserName;
            public StringField Action;
            public DateTimeField ChangedOn;
            public StringField TableName;
            public Int32Field RowId;
            public StringField Module;
            public StringField Page;
            public StringField FieldName;
            public StringField OldValue;
            public StringField NewValue;
            public StringField Comments;
            public StringField PcipAddress;
            public Int32Field BatchId;
            public StringField BatchName;
            public Int32Field MachineId;
            public StringField MachineName;
            public StringField UserEmployeeId;
            public StringField UserFirstName;
            public StringField UserLastName;
            public Int32Field UserDepartmentId;
            public StringField UserDesignation;
            public Int32Field UserMobileCode;
            public Int32Field UserMobileNumber;
            public StringField UserEmail;
            public StringField UserUsername;
            public StringField UserPasswordHash;
            public StringField UserPasswordSalt;
            public StreamField UserUserImage;
            public StringField UserAddress;
            public Int32Field UserCityId;
            public StringField UserPinCode;
            public Int32Field UserRoleId;
            public DateTimeField UserPasswordExpiryDate;
            public Int16Field UserIsForgotPassword;
            public BooleanField UserIsPasswordChangeOnLogin;
            public Int16Field UserIsUserHidden;
            public Int32Field UserStatusId;
            public Int32Field UserCreatedBy;
            public DateTimeField UserCreatedDate;
            public Int32Field UserUpdatedBy;
            public DateTimeField UserUpdatedDate;
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

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Report.AuditLog";
            }
        }
    }
}
