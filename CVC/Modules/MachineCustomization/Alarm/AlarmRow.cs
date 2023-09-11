// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.AlarmRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Modules.Common.BaseClass;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.MachineCustomization.Entities
{
    [ConnectionKey("Default")]
    [TableName("Alarm")]
    [DisplayName("Alarm")]
    [InstanceName("Alarm")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("MachineCustomization:Alarm:Read")]
    [ModifyPermission("MachineCustomization:Alarm:Modify")]
    public sealed class AlarmRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly AlarmRow.RowFields Fields = new AlarmRow.RowFields().Init<AlarmRow.RowFields>();

        [DisplayName("Alarm Id")]
        [Identity]
        public int? AlarmId
        {
            get
            {
                return AlarmRow.Fields.AlarmId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.AlarmId[(Row)this] = value;
            }
        }

        [DisplayName("Alarm Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        public string AlarmName
        {
            get
            {
                return AlarmRow.Fields.AlarmName[(Row)this];
            }
            set
            {
                AlarmRow.Fields.AlarmName[(Row)this] = value;
            }
        }

        [DisplayName("Business Entity")]
        [ForeignKey("Machine", "MachineId")]
        [LeftJoin("jMachine")]
        [TextualField("MachineMachineName")]
        [NotNull]
        public int? MachineId
        {
            get
            {
                return AlarmRow.Fields.MachineId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Business Entity")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return AlarmRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                AlarmRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [DisplayName("Machine Parameter")]
        [Column("MachineParameterId")]
        [ForeignKey("MachineParameter", "MachineParameterId")]
        [LeftJoin("jMachineParameter")]
        [TextualField("MachineParameterMachineParameterName")]
        [NotNull]
        public int? MachineParameterId
        {
            get
            {
                return AlarmRow.Fields.MachineParameterId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.MachineParameterId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Parameter")]
        [Expression("jMachineParameter.[ParameterName]")]
        public string MachineParameterMachineParameterName
        {
            get
            {
                return AlarmRow.Fields.MachineParameterMachineParameterName[(Row)this];
            }
            set
            {
                AlarmRow.Fields.MachineParameterMachineParameterName[(Row)this] = value;
            }
        }

        [DisplayName("Message")]
        [Size(100)]
        [NotNull]
        public string Message
        {
            get
            {
                return AlarmRow.Fields.Message[(Row)this];
            }
            set
            {
                AlarmRow.Fields.Message[(Row)this] = value;
            }
        }

        [DisplayName("Description")]
        [Size(500)]
        public string Description
        {
            get
            {
                return AlarmRow.Fields.Description[(Row)this];
            }
            set
            {
                AlarmRow.Fields.Description[(Row)this] = value;
            }
        }

        [DisplayName("Is Reset Required")]
        public bool? IsResetRequired
        {
            get
            {
                return AlarmRow.Fields.IsResetRequired[(Row)this];
            }
            set
            {
                AlarmRow.Fields.IsResetRequired[(Row)this] = value;
            }
        }

        [NotMapped]
        [DisplayName("Reset Required")]
        //[Expression("case IsResetRequired when true then 'Yes' else 'No' end")]
        public string IsResetRequiredString
        {
            get
            {
                return AlarmRow.Fields.IsResetRequiredString[(Row)this];
            }
            set
            {
                AlarmRow.Fields.IsResetRequiredString[(Row)this] = value;
            }
        }

        [DisplayName("Is Comment Required")]
        public bool? IsCommentRequired
        {
            get
            {
                return AlarmRow.Fields.IsCommentRequired[(Row)this];
            }
            set
            {
                AlarmRow.Fields.IsCommentRequired[(Row)this] = value;
            }
        }

        [NotMapped]
        [DisplayName("Comment Required")]
      //  [Expression("case IsCommentRequired when true then 'Yes' else 'No' end")]
        public string IsCommentRequiredString
        {
            get
            {
                return AlarmRow.Fields.IsCommentRequiredString[(Row)this];
            }
            set
            {
                AlarmRow.Fields.IsCommentRequiredString[(Row)this] = value;
            }
        }

        [DisplayName("Is Machine Required To Stop")]
        public bool? IsMachineRequiredToStop
        {
            get
            {
                return AlarmRow.Fields.IsMachineRequiredToStop[(Row)this];
            }
            set
            {
                AlarmRow.Fields.IsMachineRequiredToStop[(Row)this] = value;
            }
        }

        [NotMapped]
        [DisplayName("Machine Required To Stop")]
      //  [Expression("case IsMachineRequiredToStop when true then 'Yes' else 'No' end")]
        public string IsMachineRequiredToStopString
        {
            get
            {
                return AlarmRow.Fields.IsMachineRequiredToStopString[(Row)this];
            }
            set
            {
                AlarmRow.Fields.IsMachineRequiredToStopString[(Row)this] = value;
            }
        }

        [DisplayName("Machine Stop Machine Parameter")]
        [Column("MachineStopMachineParameterId")]
        [ForeignKey("MachineParameter", "MachineParameterId")]
        [LeftJoin("jMachineStopMachineParameter")]
        [TextualField("MachineStopMachineParameterMachineParameterName")]
        public int? MachineStopMachineParameterId
        {
            get
            {
                return AlarmRow.Fields.MachineStopMachineParameterId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.MachineStopMachineParameterId[(Row)this] = value;
            }
        }

        [DisplayName("Is Count For Reject")]
        public bool? IsCountForReject
        {
            get
            {
                return AlarmRow.Fields.IsCountForReject[(Row)this];
            }
            set
            {
                AlarmRow.Fields.IsCountForReject[(Row)this] = value;
            }
        }

        [NotMapped]
        [DisplayName("Count For Reject")]
      //  [Expression("case IsCountForReject when true then 'Yes' else 'No' end")]
        public string IsCountForRejectString
        {
            get
            {
                return AlarmRow.Fields.IsCountForRejectString[(Row)this];
            }
            set
            {
                AlarmRow.Fields.IsCountForRejectString[(Row)this] = value;
            }
        }

        [DisplayName("Bit Value")]
        [NotNull]
        public bool? BitValue
        {
            get
            {
                return AlarmRow.Fields.BitValue[(Row)this];
            }
            set
            {
                AlarmRow.Fields.BitValue[(Row)this] = value;
            }
        }

        [NotMapped]
        [DisplayName("Bit Value")]
      //  [Expression("case BitValue when true then '1' else '0' end")]
        public string BitValueString
        {
            get
            {
                return AlarmRow.Fields.BitValueString[(Row)this];
            }
            set
            {
                AlarmRow.Fields.BitValueString[(Row)this] = value;
            }
        }

        [DisplayName("Is Check At Machine Start")]
        public bool? IsCheckAtMachineStart
        {
            get
            {
                return AlarmRow.Fields.IsCheckAtMachineStart[(Row)this];
            }
            set
            {
                AlarmRow.Fields.IsCheckAtMachineStart[(Row)this] = value;
            }
        }

        [NotMapped]
        [DisplayName("Check At Machine Start")]
      //  [Expression("case IsCheckAtMachineStart when true then 'Yes' else 'No' end")]
        public string IsCheckAtMachineStartString
        {
            get
            {
                return AlarmRow.Fields.IsCheckAtMachineStartString[(Row)this];
            }
            set
            {
                AlarmRow.Fields.IsCheckAtMachineStartString[(Row)this] = value;
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
                return AlarmRow.Fields.StatusId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.StatusId[(Row)this] = value;
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
                return AlarmRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return AlarmRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedDate[(Row)this] = value;
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
                return AlarmRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return AlarmRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Machine Stop Machine Parameter Machine Id")]
        [Expression("jMachineStopMachineParameter.[MachineId]")]
        public int? MachineStopMachineParameterMachineId
        {
            get
            {
                return AlarmRow.Fields.MachineStopMachineParameterMachineId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.MachineStopMachineParameterMachineId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Stop Parameter")]
        [Expression("jMachineStopMachineParameter.[ParameterName]")]
        public string MachineStopMachineParameterMachineParameterName
        {
            get
            {
                return AlarmRow.Fields.MachineStopMachineParameterMachineParameterName[(Row)this];
            }
            set
            {
                AlarmRow.Fields.MachineStopMachineParameterMachineParameterName[(Row)this] = value;
            }
        }

      

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return AlarmRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                AlarmRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return AlarmRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return AlarmRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return AlarmRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return AlarmRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return AlarmRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return AlarmRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return AlarmRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return AlarmRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return AlarmRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return AlarmRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return AlarmRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return AlarmRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return AlarmRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return AlarmRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return AlarmRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return AlarmRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return AlarmRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return AlarmRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return AlarmRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return AlarmRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Birth Date")]
        [Expression("jCreatedBy.[BirthDate]")]
        public DateTime? CreatedByBirthDate
        {
            get
            {
                return AlarmRow.Fields.CreatedByBirthDate[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByBirthDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return AlarmRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return AlarmRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return AlarmRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return AlarmRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return AlarmRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                AlarmRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return AlarmRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return AlarmRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return AlarmRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return AlarmRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return AlarmRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return AlarmRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return AlarmRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return AlarmRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return AlarmRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return AlarmRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return AlarmRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return AlarmRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return AlarmRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return AlarmRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return AlarmRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return AlarmRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return AlarmRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return AlarmRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return AlarmRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return AlarmRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Birth Date")]
        [Expression("jUpdatedBy.[BirthDate]")]
        public DateTime? UpdatedByBirthDate
        {
            get
            {
                return AlarmRow.Fields.UpdatedByBirthDate[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByBirthDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return AlarmRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return AlarmRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return AlarmRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return AlarmRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return AlarmRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                AlarmRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Is Refresh Machine Settings")]
        public bool? IsRefreshMachineSettings
        {
            get
            {
                return AlarmRow.Fields.IsRefreshMachineSettings[(Row)this];
            }
            set
            {
                AlarmRow.Fields.IsRefreshMachineSettings[(Row)this] = value;
            }
        }


        [DisplayName("Is Hide Edit")]
        public bool? IsHideEdit
        {
            get
            {
                return AlarmRow.Fields.IsHideEdit[(Row)this];
            }
            set
            {
                AlarmRow.Fields.IsHideEdit[(Row)this] = value;
            }
        }

        [DisplayName("Is Alarm for Counter")]
        public bool? IsAlarmForCounter
        {
            get
            {
                return AlarmRow.Fields.IsAlarmForCounter[(Row)this];
            }
            set
            {
                AlarmRow.Fields.IsAlarmForCounter[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return AlarmRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                AlarmRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }


        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)AlarmRow.Fields.AlarmId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return AlarmRow.Fields.AlarmName;
            }
        }

        public AlarmRow()
          : base((RowFieldsBase)AlarmRow.Fields)
        {
        }
        public class RowFields : LoggingRow.LoggingRowFields
        //public class RowFields : RowFieldsBase
        {
            public Int32Field AlarmId;
            public StringField AlarmName;
            public Int32Field MachineId;
            public Int32Field MachineParameterId;
            public StringField Message;
            public StringField Description;
            public BooleanField IsResetRequired;
            public BooleanField IsCommentRequired;
            public BooleanField IsMachineRequiredToStop;
            public Int32Field MachineStopMachineParameterId;
            public BooleanField IsCountForReject;
            public BooleanField BitValue;
            public BooleanField IsCheckAtMachineStart;
            public Int32Field StatusId;
           /* public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;*/
            public Int32Field MachineStopMachineParameterMachineId;
            public StringField MachineStopMachineParameterMachineParameterName;
           // public Int32Field MachineStopMachineParameterMachineParameterId;
          
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
            public DateTimeField CreatedByBirthDate;
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
            public DateTimeField UpdatedByBirthDate;
            public Int32Field UpdatedByStatusId;
            public Int32Field UpdatedByCreatedBy;
            public DateTimeField UpdatedByCreatedDate;
            public Int32Field UpdatedBy1;
            public DateTimeField UpdatedByUpdatedDate;
            public StringField MachineMachineName;
            public StringField MachineParameterMachineParameterName;
            public StringField IsResetRequiredString;
            public StringField IsCommentRequiredString;
            public StringField IsMachineRequiredToStopString;
            public StringField IsCountForRejectString;
            public StringField BitValueString;
            public StringField IsCheckAtMachineStartString;
            public BooleanField IsRefreshMachineSettings;
            public BooleanField IsHideEdit;
            public BooleanField IsAlarmForCounter;
            public StringField RecordAddedSource;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "MachineCustomization.Alarm";
            }
        }
    }
}
