// Decompiled with JetBrains decompiler
// Type: CVC.ExternalApplicationInterface.Entities.IpcParameterRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.ExternalApplicationInterface.Entities
{
    [ConnectionKey("Default")]
    [TableName("IPCParameter")]
    [DisplayName("Ipc Parameter")]
    [InstanceName("Ipc Parameter")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("EAI:IPCParameter:Read")]
    [ModifyPermission("EAI:IPCParameter:Modify")]
    [LookupScript("ExternalApplicationInterface.IpcParameter", Permission = "Lookup")]
   // [LookupEditor(typeof(MachineCustomization.Scripts.MachineLookUp))]

    public sealed class IpcParameterRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly IpcParameterRow.RowFields Fields = new IpcParameterRow.RowFields().Init<IpcParameterRow.RowFields>();

        [DisplayName("Ipc Parameter Id")]
        [Column("IPCParameterId")]
        [Identity]
        public int? IpcParameterId
        {
            get
            {
                return IpcParameterRow.Fields.IpcParameterId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IpcParameterId[(Row)this] = value;
            }
        }

        [DisplayName("Business Entity")]
        [ForeignKey("Machine", "MachineId")]
        [LeftJoin("jMachine")]
        [TextualField("MachineMachineName")]
        [NotNull]
       // [LookupEditor(typeof(MachineCustomization.Scripts.MachineLookUp)),filtert]
         [LookupInclude]
        public int? MachineId
        {
            get
            {
                return IpcParameterRow.Fields.MachineId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Protocol")]
       // [NotNull]   
        public int? ProtocolId
        {
            get
            {
                return IpcParameterRow.Fields.ProtocolId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.ProtocolId[(Row)this] = value;
            }
        }


        [DisplayName("Business Entity")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return IpcParameterRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [DisplayName("Ipc Parameter Name")]
        [Column("IPCParameterName")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        public string IpcParameterName
        {
            get
            {
                return IpcParameterRow.Fields.IpcParameterName[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IpcParameterName[(Row)this] = value;
            }
        }

        [DisplayName("Machine Parameter Id")]
        [ForeignKey("MachineParameter", "MachineParameterId")]
        [LeftJoin("jMachineParameter")]
        [TextualField("MachineParameterName")]
        [NotNull]
        public int? MachineParameterId
        {
            get
            {
                return IpcParameterRow.Fields.MachineParameterId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.MachineParameterId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Parameter")]
        [Expression("jMachineParameter.[ParameterName]")]
        public string MachineParameterName
        {
            get
            {
                return IpcParameterRow.Fields.MachineParameterName[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.MachineParameterName[(Row)this] = value;
            }
        }


        [DisplayName("Is BitWise")]
        public bool? IsBitWise
        {
            get
            {
                return IpcParameterRow.Fields.IsBitWise[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsBitWise[(Row)this] = value;
            }
        }




        [DisplayName("BitWise Index")]
        public int? BitWiseIndex
        {
            get
            {
                return IpcParameterRow.Fields.BitWiseIndex[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.BitWiseIndex[(Row)this] = value;
            }
        }



        [DisplayName("Is 32 Bit")]
        public bool? Is32Bit
        {
            get
            {
                return IpcParameterRow.Fields.Is32Bit[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.Is32Bit[(Row)this] = value;
            }
        }


        [DisplayName("Is Word Swap")]
        public bool? IsWordSwap
        {
            get
            {
                return IpcParameterRow.Fields.IsWordSwap[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsWordSwap[(Row)this] = value;
            }
        }

        [DisplayName("Is Byte Swap")]
        public bool? IsByteSwap
        {
            get
            {
                return IpcParameterRow.Fields.IsByteSwap[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsByteSwap[(Row)this] = value;
            }
        }

        //changes added by Vinayak on 17.07.2018

        [DisplayName("Is Stop AT")]
        public bool? IsStopATIPC
        {
            get
            {
                return IpcParameterRow.Fields.IsStopATIPC[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsStopATIPC[(Row)this] = value;
            }
        }

        [DisplayName("Is Show As Message")]
        public bool? IsShowAsMessageIPC
        {
            get
            {
                return IpcParameterRow.Fields.IsShowAsMessageIPC[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsShowAsMessageIPC[(Row)this] = value;
            }
        }

        [DisplayName("Is Batch Start Required")]
        public bool? IsBatchStartRequiredIPC
        {
            get
            {
                return IpcParameterRow.Fields.IsBatchStartRequiredIPC[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsBatchStartRequiredIPC[(Row)this] = value;
            }
        }

        [DisplayName("Is Reset On Batch Create")]
        public bool? IsResetOnBatchCreateIPC
        {
            get
            {
                return IpcParameterRow.Fields.IsResetOnBatchCreateIPC[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsResetOnBatchCreateIPC[(Row)this] = value;
            }
        }

        [DisplayName("Is Label Roll")]
        public bool? IsLabelRollIPC
        {
            get
            {
                return IpcParameterRow.Fields.IsLabelRollIPC[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsLabelRollIPC[(Row)this] = value;
            }
        }

        [DisplayName("Disable ParameterId")]
        public int? DisableParameterIdIPC
        {
            get
            {
                return IpcParameterRow.Fields.DisableParameterIdIPC[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.DisableParameterIdIPC[(Row)this] = value;
            }
        }

        [DisplayName("Disable Parameter Value")]
        [Expression("jMachineParameter.[ParameterName]")]
        public string DisableParameterValueIPC
        {
            get
            {
                return IpcParameterRow.Fields.DisableParameterValueIPC[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.DisableParameterValueIPC[(Row)this] = value;
            }
        }

        [DisplayName("Is Stop On Batch Stop")]
        public bool? IsStopOnBatchStopIPC
        {
            get
            {
                return IpcParameterRow.Fields.IsStopOnBatchStopIPC[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsStopOnBatchStopIPC[(Row)this] = value;
            }
        }


        //ended by Vinayak on 17.07.2018

        [DisplayName("32 Bit Address")]
        public string Bit32Address
        {
            get
            {
                return IpcParameterRow.Fields.Bit32Address[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.Bit32Address[(Row)this] = value;
            }
        }

        [DisplayName("Operation Type")]
        public int? OperationTypeIPC
        {
            get
            {
                return IpcParameterRow.Fields.OperationTypeIPC[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.OperationTypeIPC[(Row)this] = value;
            }
        }


        [DisplayName("Operation Value")]
        [Size(18)]
        [Scale(2)]
        public Decimal? OperationValueIPC
        {
            get
            {
                return IpcParameterRow.Fields.OperationValueIPC[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.OperationValueIPC[(Row)this] = value;
            }
        }

        [DisplayName("Ipc Address")]
        [Column("IPCAddress")]
        [Size(50)]
        public string IpcAddress
        {
            get
            {
                return IpcParameterRow.Fields.IpcAddress[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IpcAddress[(Row)this] = value;
            }
        }

        [DisplayName("Is Change In Runtime")]
        public short? IsChangeInRuntime
        {
            get
            {
                return IpcParameterRow.Fields.IsChangeInRuntime[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsChangeInRuntime[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [ForeignKey("Status", "StatusId")]
        [LeftJoin("jStatus")]
        [TextualField("StatusStatusName")]
        //To make status as default "Active"
        [DefaultValue(1)]
        [NotNull]
        public int? StatusId
        {
            get
            {
                return IpcParameterRow.Fields.StatusId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.StatusId[(Row)this] = value;
            }
        }
        [DisplayName("Attribute")]
        [ForeignKey("Attribute", "AttributeId")]
        [LeftJoin("jAttribute")]
        [TextualField("AttributeAttributeName")]
        //To make status as default "Active"
        [DefaultValue(13)]
        //[NotNull]
        [ReadOnly(true)]
        public int? AttributeId
        {
            get
            {
                return IpcParameterRow.Fields.AttributeId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.AttributeId[(Row)this] = value;
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
                return IpcParameterRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return IpcParameterRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedDate[(Row)this] = value;
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
                return IpcParameterRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return IpcParameterRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return IpcParameterRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return IpcParameterRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return IpcParameterRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }


        [DisplayName("Is Alarm")]
        public bool? IsAlarm
        {
            get
            {
                return IpcParameterRow.Fields.IsAlarm[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsAlarm[(Row)this] = value;
            }
        }

        [DisplayName("Is Refresh Machine Settings")]
        public bool? IsRefreshMachineSettings
        {
            get
            {
                return IpcParameterRow.Fields.IsRefreshMachineSettings[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsRefreshMachineSettings[(Row)this] = value;
            }
        }

        [DisplayName("Is Machine Speed")]
        public bool? IsMachineSpeed
        {
            get
            {
                return IpcParameterRow.Fields.IsMachineSpeed[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsMachineSpeed[(Row)this] = value;
            }
        }



        [DisplayName("Is HeartBeat")]
        public bool? IsHeartBeat
        {
            get
            {
                return IpcParameterRow.Fields.IsHeartBeat[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsHeartBeat[(Row)this] = value;
            }
        }


        [DisplayName("Is HeartBeat Send")]
        public bool? IsHeartBeatSend
        {
            get
            {
                return IpcParameterRow.Fields.IsHeartBeatSend[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsHeartBeatSend[(Row)this] = value;
            }
        }


        [DisplayName("Heart Beat Failed Time")]
        public int? HeartBeatFailedTime
        {
            get
            {
                return IpcParameterRow.Fields.HeartBeatFailedTime[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.HeartBeatFailedTime[(Row)this] = value;
            }
        }
        public int? IncrementalNumber
        {
            get
            {
                return IpcParameterRow.Fields.IncrementalNumber[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IncrementalNumber[(Row)this] = value;
            }
        }
      
        public int? StartNumber
        {
            get
            {
                return IpcParameterRow.Fields.StartNumber[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.StartNumber[(Row)this] = value;
            }
        }
     
        public int? EndNumber
        {
            get
            {
                return IpcParameterRow.Fields.EndNumber[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.EndNumber[(Row)this] = value;
            }
        }

        [DisplayName("Is Write To PLC")]
        public bool? IsWriteToPLC
        {
            get
            {
                return IpcParameterRow.Fields.IsWriteToPLC[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsWriteToPLC[(Row)this] = value;
            }
        }

        [DisplayName("Is Indicator Parameter")]
        public bool? IsIndicatorParameter
        {
            get
            {
                return IpcParameterRow.Fields.IsIndicatorParameter[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsIndicatorParameter[(Row)this] = value;
            }
        }

        [DisplayName("Indicator ParameterId")]
        public int? IndicatorParameterId
        {
            get
            {
                return IpcParameterRow.Fields.IndicatorParameterId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IndicatorParameterId[(Row)this] = value;
            }
        }
       
        public bool? IsGoodBottles
        {
            get
            {
                return IpcParameterRow.Fields.IsGoodBottles[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsGoodBottles[(Row)this] = value;
            }
        }
      
        public bool? IsRejectBottles
        {
            get
            {
                return IpcParameterRow.Fields.IsRejectBottles[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsRejectBottles[(Row)this] = value;
            }
        }
      
        public bool? IsBatchSize
        {
            get
            {
                return IpcParameterRow.Fields.IsBatchSize[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsBatchSize[(Row)this] = value;
            }
        }

        public bool? IsCounterReset
        {
            get
            {
                return IpcParameterRow.Fields.IsCounterReset[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsCounterReset[(Row)this] = value;
            }
        }
        public bool? IsConveyer
        {
            get
            {
                return IpcParameterRow.Fields.IsConveyer[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsConveyer[(Row)this] = value;
            }
        }
        [DisplayName("Is Counter for Alarm")]
        public bool? IsMissingLabelCounter
        {
            get
            {
                return IpcParameterRow.Fields.IsMissingLabelCounter[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.IsMissingLabelCounter[(Row)this] = value;
            }
        }
        [DisplayName("Node Id")]
        [Column("NodeId")]
        [Size(50)]
        public string NodeId
        {
            get
            {
                return IpcParameterRow.Fields.NodeId[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.NodeId[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return IpcParameterRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                IpcParameterRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }


        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)IpcParameterRow.Fields.IpcParameterId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return IpcParameterRow.Fields.IpcParameterName;
            }
        }

        public IpcParameterRow()
          : base((RowFieldsBase)IpcParameterRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
      //  public class RowFields : RowFieldsBase
        {
            public Int32Field IpcParameterId;
            public Int32Field MachineId;
            public Int32Field ProtocolId;
            public StringField IpcParameterName;
            public Int32Field MachineParameterId;
            public StringField IpcAddress;
            public Int16Field IsChangeInRuntime;
            public Int32Field StatusId;
           /* public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;*/
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
            public StringField MachineMachineName;
            public StringField MachineParameterName;

            public BooleanField IsBitWise;
            public Int32Field BitWiseIndex;

            public BooleanField Is32Bit;
            public BooleanField IsAlarm;
            public BooleanField IsRefreshMachineSettings;
            public BooleanField IsMachineSpeed;
            public StringField Bit32Address;
            public BooleanField IsWordSwap;
            public BooleanField IsByteSwap;
            //changes added By Vinayak on 17.07.2018
            public BooleanField IsStopATIPC;
            public BooleanField IsShowAsMessageIPC;
            public BooleanField IsBatchStartRequiredIPC;
            public BooleanField IsResetOnBatchCreateIPC;
            public BooleanField IsLabelRollIPC;
            public Int32Field DisableParameterIdIPC;
            public StringField DisableParameterValueIPC;
            public BooleanField IsStopOnBatchStopIPC;
            //ended added By Vinayak on 17.07.2018
            public Int32Field OperationTypeIPC;
            public DecimalField OperationValueIPC;
            public BooleanField IsHeartBeat;
            public BooleanField IsHeartBeatSend;
            public Int32Field HeartBeatFailedTime;
            public Int32Field IncrementalNumber;
            public Int32Field StartNumber;
            public Int32Field EndNumber;
            public BooleanField IsWriteToPLC;
            public BooleanField IsIndicatorParameter;
            public Int32Field IndicatorParameterId;
            public BooleanField IsGoodBottles;
            public BooleanField IsRejectBottles;
            public BooleanField IsBatchSize;
            public BooleanField IsCounterReset;
            public BooleanField IsConveyer;
            public BooleanField IsMissingLabelCounter;
            public StringField NodeId;
            public Int32Field AttributeId;
            public StringField RecordAddedSource;



            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "ExternalApplicationInterface.IpcParameter";
            }
        }
    }
}
