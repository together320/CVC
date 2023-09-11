// Decompiled with JetBrains decompiler
// Type: CVC.Report.Entities.AuditLogArchiveRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.Report.Entities
{
    [ConnectionKey("Default")]
    [Serenity.Data.Mapping.TableName("AuditLogArchive")]
    [DisplayName("Audit Log Archive")]
    [InstanceName("Audit Log Archive")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Report:AuditLogArchive:Read")]
    public sealed class AuditLogArchiveRow : Row, IIdRow, IEntity, INameRow
    {
        public static readonly AuditLogArchiveRow.RowFields Fields = new AuditLogArchiveRow.RowFields().Init<AuditLogArchiveRow.RowFields>();

        [DisplayName("Audit Log Archive Id")]
        [Identity]
        public long? AuditLogArchiveId
        {
            get => AuditLogArchiveRow.Fields.AuditLogArchiveId[(Row)this];
            set
            {
                AuditLogArchiveRow.Fields.AuditLogArchiveId[(Row)this] = value;
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
                return AuditLogArchiveRow.Fields.UserId[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserId[(Row)this] = value;
            }
        }

        [DisplayName("User Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string UserName
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserName[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserName[(Row)this] = value;
            }
        }

        [DisplayName("Action")]
        [Size(50)]
        public string Action
        {
            get
            {
                return AuditLogArchiveRow.Fields.Action[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.Action[(Row)this] = value;
            }
        }

        [DisplayName("Changed On")]
        public DateTime? ChangedOn
        {
            get
            {
                return AuditLogArchiveRow.Fields.ChangedOn[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.ChangedOn[(Row)this] = value;
            }
        }

        [DisplayName("Table Name")]
        [Size(50)]
        public string TableName
        {
            get
            {
                return AuditLogArchiveRow.Fields.TableName[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.TableName[(Row)this] = value;
            }
        }

        [DisplayName("Row Id")]
        public int? RowId
        {
            get
            {
                return AuditLogArchiveRow.Fields.RowId[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.RowId[(Row)this] = value;
            }
        }

        [DisplayName("Module")]
        [Size(500)]
        public string Module
        {
            get
            {
                return AuditLogArchiveRow.Fields.Module[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.Module[(Row)this] = value;
            }
        }

        [DisplayName("Page")]
        [Size(500)]
        public string Page
        {
            get
            {
                return AuditLogArchiveRow.Fields.Page[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.Page[(Row)this] = value;
            }
        }

        [DisplayName("Field Name")]
        [Size(50)]
        public string FieldName
        {
            get
            {
                return AuditLogArchiveRow.Fields.FieldName[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.FieldName[(Row)this] = value;
            }
        }

        [DisplayName("Old Value")]
        [Size(1000)]
        public string OldValue
        {
            get
            {
                return AuditLogArchiveRow.Fields.OldValue[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.OldValue[(Row)this] = value;
            }
        }

        [DisplayName("New Value")]
        [Size(1000)]
        public string NewValue
        {
            get
            {
                return AuditLogArchiveRow.Fields.NewValue[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.NewValue[(Row)this] = value;
            }
        }

        [DisplayName("Comments")]
        [Size(500)]
        public string Comments
        {
            get
            {
                return AuditLogArchiveRow.Fields.Comments[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.Comments[(Row)this] = value;
            }
        }

        [DisplayName("Pcip Address")]
        [Column("PCIPAddress")]
        [Size(50)]
        public string PcipAddress
        {
            get
            {
                return AuditLogArchiveRow.Fields.PcipAddress[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.PcipAddress[(Row)this] = value;
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
                return AuditLogArchiveRow.Fields.BatchId[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Name")]
        [Size(50)]
        public string BatchName
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchName[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchName[(Row)this] = value;
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
                return AuditLogArchiveRow.Fields.MachineId[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Entity Name")]
        [Size(50)]
        public string MachineName
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineName[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineName[(Row)this] = value;
            }
        }

        [DisplayName("User Employee Id")]
        [Expression("jUser.[EmployeeId]")]
        public string UserEmployeeId
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserEmployeeId[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("User First Name")]
        [Expression("jUser.[FirstName]")]
        public string UserFirstName
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserFirstName[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserFirstName[(Row)this] = value;
            }
        }

        [DisplayName("User Last Name")]
        [Expression("jUser.[LastName]")]
        public string UserLastName
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserLastName[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserLastName[(Row)this] = value;
            }
        }

        [DisplayName("User Department Id")]
        [Expression("jUser.[DepartmentId]")]
        public int? UserDepartmentId
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserDepartmentId[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("User Designation")]
        [Expression("jUser.[Designation]")]
        public string UserDesignation
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserDesignation[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserDesignation[(Row)this] = value;
            }
        }

        [DisplayName("User Mobile Code")]
        [Expression("jUser.[MobileCode]")]
        public int? UserMobileCode
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserMobileCode[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("User Mobile Number")]
        [Expression("jUser.[MobileNumber]")]
        public int? UserMobileNumber
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserMobileNumber[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("User Email")]
        [Expression("jUser.[Email]")]
        public string UserEmail
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserEmail[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserEmail[(Row)this] = value;
            }
        }

        [DisplayName("User Username")]
        [Expression("jUser.[Username]")]
        public string UserUsername
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserUsername[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserUsername[(Row)this] = value;
            }
        }

        [DisplayName("User Password Hash")]
        [Expression("jUser.[PasswordHash]")]
        public string UserPasswordHash
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserPasswordHash[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("User Password Salt")]
        [Expression("jUser.[PasswordSalt]")]
        public string UserPasswordSalt
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserPasswordSalt[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("User User Image")]
        [Expression("jUser.[UserImage]")]
        public Stream UserUserImage
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserUserImage[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserUserImage[(Row)this] = value;
            }
        }

        [DisplayName("User Address")]
        [Expression("jUser.[Address]")]
        public string UserAddress
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserAddress[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserAddress[(Row)this] = value;
            }
        }

        [DisplayName("User City Id")]
        [Expression("jUser.[CityId]")]
        public int? UserCityId
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserCityId[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserCityId[(Row)this] = value;
            }
        }

        [DisplayName("User Pin Code")]
        [Expression("jUser.[PinCode]")]
        public string UserPinCode
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserPinCode[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserPinCode[(Row)this] = value;
            }
        }

        [DisplayName("User Role Id")]
        [Expression("jUser.[RoleId]")]
        public int? UserRoleId
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserRoleId[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserRoleId[(Row)this] = value;
            }
        }

        [DisplayName("User Password Expiry Date")]
        [Expression("jUser.[PasswordExpiryDate]")]
        public DateTime? UserPasswordExpiryDate
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserPasswordExpiryDate[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("User Is Forgot Password")]
        [Expression("jUser.[IsForgotPassword]")]
        public short? UserIsForgotPassword
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserIsForgotPassword[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("User Is Password Change On Login")]
        [Expression("jUser.[IsPasswordChangeOnLogin]")]
        public bool? UserIsPasswordChangeOnLogin
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("User Is User Hidden")]
        [Expression("jUser.[IsUserHidden]")]
        public short? UserIsUserHidden
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserIsUserHidden[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("User Status Id")]
        [Expression("jUser.[StatusId]")]
        public int? UserStatusId
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserStatusId[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserStatusId[(Row)this] = value;
            }
        }

        [DisplayName("User Created By")]
        [Expression("jUser.[CreatedBy]")]
        public int? UserCreatedBy
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserCreatedBy[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("User Created Date")]
        [Expression("jUser.[CreatedDate]")]
        public DateTime? UserCreatedDate
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserCreatedDate[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("User Updated By")]
        [Expression("jUser.[UpdatedBy]")]
        public int? UserUpdatedBy
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserUpdatedBy[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("User Updated Date")]
        [Expression("jUser.[UpdatedDate]")]
        public DateTime? UserUpdatedDate
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserUpdatedDate[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.UserUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Name")]
        [Expression("jBatch.[BatchName]")]
        public string BatchBatchName
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchBatchName[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchBatchName[(Row)this] = value;
            }
        }

        [DisplayName("Batch Pack Id")]
        [Expression("jBatch.[PackId]")]
        public int? BatchPackId
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchPackId[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchPackId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Start Date Time")]
        [Expression("jBatch.[BatchStartDateTime]")]
        public DateTime? BatchBatchStartDateTime
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchBatchStartDateTime[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchBatchStartDateTime[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch End Date Time")]
        [Expression("jBatch.[BatchEndDateTime]")]
        public DateTime? BatchBatchEndDateTime
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchBatchEndDateTime[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchBatchEndDateTime[(Row)this] = value;
            }
        }

        [DisplayName("Batch Machine Line Id")]
        [Expression("jBatch.[MachineLineId]")]
        public int? BatchMachineLineId
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchMachineLineId[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Status")]
        [Expression("jBatch.[BatchStatus]")]
        public string BatchBatchStatus
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchBatchStatus[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchBatchStatus[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch Size")]
        [Expression("jBatch.[BatchSize]")]
        public int? BatchBatchSize
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchBatchSize[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchBatchSize[(Row)this] = value;
            }
        }

        [DisplayName("Batch Batch For")]
        [Expression("jBatch.[BatchFor]")]
        public string BatchBatchFor
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchBatchFor[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchBatchFor[(Row)this] = value;
            }
        }

        [DisplayName("Batch Number Of Bottles")]
        [Expression("jBatch.[NumberOfBottles]")]
        public int? BatchNumberOfBottles
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchNumberOfBottles[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchNumberOfBottles[(Row)this] = value;
            }
        }

        [DisplayName("Batch Total Good Bottles")]
        [Expression("jBatch.[TotalGoodBottles]")]
        public int? BatchTotalGoodBottles
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchTotalGoodBottles[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchTotalGoodBottles[(Row)this] = value;
            }
        }

        [DisplayName("Batch Total Rejected Bottles")]
        [Expression("jBatch.[TotalRejectedBottles]")]
        public int? BatchTotalRejectedBottles
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchTotalRejectedBottles[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchTotalRejectedBottles[(Row)this] = value;
            }
        }

        [DisplayName("Batch Production Speed")]
        [Expression("jBatch.[ProductionSpeed]")]
        public string BatchProductionSpeed
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchProductionSpeed[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchProductionSpeed[(Row)this] = value;
            }
        }

        [DisplayName("Batch Expiry Date")]
        [Expression("jBatch.[ExpiryDate]")]
        public DateTime? BatchExpiryDate
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchExpiryDate[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Batch Status Id")]
        [Expression("jBatch.[StatusId]")]
        public int? BatchStatusId
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchStatusId[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Created By")]
        [Expression("jBatch.[CreatedBy]")]
        public int? BatchCreatedBy
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchCreatedBy[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Batch Created Date")]
        [Expression("jBatch.[CreatedDate]")]
        public DateTime? BatchCreatedDate
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchCreatedDate[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Batch Updated By")]
        [Expression("jBatch.[UpdatedBy]")]
        public int? BatchUpdatedBy
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchUpdatedBy[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Batch Updated Date")]
        [Expression("jBatch.[UpdatedDate]")]
        public DateTime? BatchUpdatedDate
        {
            get
            {
                return AuditLogArchiveRow.Fields.BatchUpdatedDate[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.BatchUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Line Id")]
        [Expression("jMachine.[MachineLineId]")]
        public int? MachineMachineLineId
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineMachineLineId[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineMachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Name")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [DisplayName("Machine Model Number")]
        [Expression("jMachine.[ModelNumber]")]
        public string MachineModelNumber
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineModelNumber[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Serial Number")]
        [Expression("jMachine.[SerialNumber]")]
        public string MachineSerialNumber
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineSerialNumber[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Make")]
        [Expression("jMachine.[Make]")]
        public string MachineMake
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineMake[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Year")]
        [Expression("jMachine.[Year]")]
        public int? MachineYear
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineYear[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineYear[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Make")]
        [Expression("jMachine.[PlcMake]")]
        public string MachinePlcMake
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachinePlcMake[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachinePlcMake[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Model Number")]
        [Expression("jMachine.[PlcModelNumber]")]
        public string MachinePlcModelNumber
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachinePlcModelNumber[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachinePlcModelNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Serial Number")]
        [Expression("jMachine.[PlcSerialNumber]")]
        public string MachinePlcSerialNumber
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachinePlcSerialNumber[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachinePlcSerialNumber[(Row)this] = value;
            }
        }

        [DisplayName("Machine Plc Address")]
        [Expression("jMachine.[PLCAddress]")]
        public string MachinePlcAddress
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachinePlcAddress[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachinePlcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Access Ip Address")]
        [Expression("jMachine.[AccessIPAddress]")]
        public string MachineAccessIpAddress
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineAccessIpAddress[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineAccessIpAddress[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Sequence")]
        [Expression("jMachine.[MachineSequence]")]
        public int? MachineMachineSequence
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineMachineSequence[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineMachineSequence[(Row)this] = value;
            }
        }

        [DisplayName("Machine Machine Image")]
        [Expression("jMachine.[MachineImage]")]
        public Stream MachineMachineImage
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineMachineImage[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineMachineImage[(Row)this] = value;
            }
        }

        [DisplayName("Machine Status Id")]
        [Expression("jMachine.[StatusId]")]
        public int? MachineStatusId
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineStatusId[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Description")]
        [Expression("jMachine.[Description]")]
        public string MachineDescription
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineDescription[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineDescription[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created By")]
        [Expression("jMachine.[CreatedBy]")]
        public int? MachineCreatedBy
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineCreatedBy[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Created Date")]
        [Expression("jMachine.[CreatedDate]")]
        public DateTime? MachineCreatedDate
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineCreatedDate[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated By")]
        [Expression("jMachine.[UpdatedBy]")]
        public int? MachineUpdatedBy
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineUpdatedBy[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Machine Updated Date")]
        [Expression("jMachine.[UpdatedDate]")]
        public DateTime? MachineUpdatedDate
        {
            get
            {
                return AuditLogArchiveRow.Fields.MachineUpdatedDate[(Row)this];
            }
            set
            {
                AuditLogArchiveRow.Fields.MachineUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)AuditLogArchiveRow.Fields.AuditLogArchiveId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return AuditLogArchiveRow.Fields.UserName;
            }
        }

        public AuditLogArchiveRow()
          : base((RowFieldsBase)AuditLogArchiveRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field AuditLogArchiveId;
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
                this.LocalTextPrefix = "Report.AuditLogArchive";
            }
        }
    }
}
