
using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.Modules.ExternalApplicationInterface.IpcParameter
{
    [ConnectionKey("Default")]
    [TableName("MachineCommunication")]
    [DisplayName("Machine Communication")]
    [InstanceName("Machine Communication")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("EAI:MachineCommunication:Read")]
    [ModifyPermission("EAI:MachineCommunication:Modify")]
    [LookupScript("ExternalApplicationInterface.MachineProtocolCommunication", Permission = "Lookup")]
    public sealed class MachineProtocolCommunication : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly MachineProtocolCommunication.RowFields Fields = new MachineProtocolCommunication.RowFields().Init<MachineProtocolCommunication.RowFields>();

        [DisplayName("Machine Communicaton Id")]
        [Identity]
        public int? MachineCommunicatonId
        {
            get
            {
                return MachineProtocolCommunication.Fields.MachineCommunicatonId[(Row)this];
            }
            set
            {
                MachineProtocolCommunication.Fields.MachineCommunicatonId[(Row)this] = value;
            }
        }

        [DisplayName("Protocol")]
        [ForeignKey("Protocol", "ProtocolId")]
        [LeftJoin("jProtocol")]
        [TextualField("ProtocolName")]
        [NotNull]
        public int? ProtocolTypeId
        {
            get
            {
                return MachineProtocolCommunication.Fields.ProtocolTypeId[(Row)this];
            }
            set
            {
                MachineProtocolCommunication.Fields.ProtocolTypeId[(Row)this] = value;
            }
        }

        [DisplayName("Protocol")]
        [Expression("jProtocol.[ProtocolName]")]
        public string ProtocolName
        {
            get
            {
                return MachineProtocolCommunication.Fields.ProtocolName[(Row)this];
            }
            set
            {
                MachineProtocolCommunication.Fields.ProtocolName[(Row)this] = value;
            }
        }

        [DisplayName("Business Entity")]
        [ForeignKey("Machine", "MachineId")]
        [LeftJoin("jMachine")]
        [TextualField("MachineMachineName")]
        [NotNull]
        [LookupInclude]
        public int? MachineId
        {
            get
            {
                return MachineProtocolCommunication.Fields.MachineId[(Row)this];
            }
            set
            {
                MachineProtocolCommunication.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Business Entity")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return MachineProtocolCommunication.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                MachineProtocolCommunication.Fields.MachineMachineName[(Row)this] = value;
            }
        }



        [DisplayName("Ip Address")]
        [Column("IPAddress")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string IpAddress
        {
            get
            {
                return MachineProtocolCommunication.Fields.IpAddress[(Row)this];
            }
            set
            {
                MachineProtocolCommunication.Fields.IpAddress[(Row)this] = value;
            }
        }


        [DisplayName("MDBPath")]
        [Column("MDBPath")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string MDBPath
        {
            get
            {
                return MachineProtocolCommunication.Fields.MDBPath[(Row)this];
            }
            set
            {
                MachineProtocolCommunication.Fields.MDBPath[(Row)this] = value;
            }
        }

        [DisplayName("Tcpip Port")]
        [Column("TCPIPPort")]
        public int? TcpipPort
        {
            get
            {
                return MachineProtocolCommunication.Fields.TcpipPort[(Row)this];
            }
            set
            {
                MachineProtocolCommunication.Fields.TcpipPort[(Row)this] = value;
            }
        }

        [DisplayName("Poll Rate")]
        public int? PollRate
        {
            get
            {
                return MachineProtocolCommunication.Fields.PollRate[(Row)this];
            }
            set
            {
                MachineProtocolCommunication.Fields.PollRate[(Row)this] = value;
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
                return MachineProtocolCommunication.Fields.StatusId[(Row)this];
            }
            set
            {
                MachineProtocolCommunication.Fields.StatusId[(Row)this] = value;
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
                return MachineProtocolCommunication.Fields.CreatedBy[(Row)this];
            }
            set
            {
                MachineProtocolCommunication.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return MachineProtocolCommunication.Fields.CreatedDate[(Row)this];
            }
            set
            {
                MachineProtocolCommunication.Fields.CreatedDate[(Row)this] = value;
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
                return MachineProtocolCommunication.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                MachineProtocolCommunication.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return MachineProtocolCommunication.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                MachineProtocolCommunication.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        //[DisplayName("Status")]
        //[Expression("jStatus.[StatusName]")]
        //public string StatusStatusName
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.StatusStatusName[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.StatusStatusName[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Employee Id")]
        //[Expression("jCreatedBy.[EmployeeId]")]
        //public string CreatedByEmployeeId
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByEmployeeId[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByEmployeeId[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By First Name")]
        //[Expression("jCreatedBy.[FirstName]")]
        //public string CreatedByFirstName
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByFirstName[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByFirstName[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Last Name")]
        //[Expression("jCreatedBy.[LastName]")]
        //public string CreatedByLastName
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByLastName[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByLastName[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Department Id")]
        //[Expression("jCreatedBy.[DepartmentId]")]
        //public int? CreatedByDepartmentId
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByDepartmentId[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByDepartmentId[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Designation")]
        //[Expression("jCreatedBy.[Designation]")]
        //public string CreatedByDesignation
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByDesignation[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByDesignation[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Mobile Code")]
        //[Expression("jCreatedBy.[MobileCode]")]
        //public int? CreatedByMobileCode
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByMobileCode[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByMobileCode[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Mobile Number")]
        //[Expression("jCreatedBy.[MobileNumber]")]
        //public int? CreatedByMobileNumber
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByMobileNumber[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByMobileNumber[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Email")]
        //[Expression("jCreatedBy.[Email]")]
        //public string CreatedByEmail
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByEmail[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByEmail[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Username")]
        //[Expression("jCreatedBy.[Username]")]
        //public string CreatedByUsername
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByUsername[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByUsername[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Password Hash")]
        //[Expression("jCreatedBy.[PasswordHash]")]
        //public string CreatedByPasswordHash
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByPasswordHash[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByPasswordHash[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Password Salt")]
        //[Expression("jCreatedBy.[PasswordSalt]")]
        //public string CreatedByPasswordSalt
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByPasswordSalt[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By User Image")]
        //[Expression("jCreatedBy.[UserImage]")]
        //public string CreatedByUserImage
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByUserImage[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByUserImage[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Address")]
        //[Expression("jCreatedBy.[Address]")]
        //public string CreatedByAddress
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByAddress[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByAddress[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By City Id")]
        //[Expression("jCreatedBy.[CityId]")]
        //public int? CreatedByCityId
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByCityId[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByCityId[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Pin Code")]
        //[Expression("jCreatedBy.[PinCode]")]
        //public string CreatedByPinCode
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByPinCode[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByPinCode[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Role Id")]
        //[Expression("jCreatedBy.[RoleId]")]
        //public int? CreatedByRoleId
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByRoleId[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByRoleId[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Password Expiry Date")]
        //[Expression("jCreatedBy.[PasswordExpiryDate]")]
        //public DateTime? CreatedByPasswordExpiryDate
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Is Forgot Password")]
        //[Expression("jCreatedBy.[IsForgotPassword]")]
        //public short? CreatedByIsForgotPassword
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByIsForgotPassword[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Is Password Change On Login")]
        //[Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        //public bool? CreatedByIsPasswordChangeOnLogin
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Is User Hidden")]
        //[Expression("jCreatedBy.[IsUserHidden]")]
        //public short? CreatedByIsUserHidden
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByIsUserHidden[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Status Id")]
        //[Expression("jCreatedBy.[StatusId]")]
        //public int? CreatedByStatusId
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByStatusId[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByStatusId[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By")]
        //[Expression("jCreatedBy.[CreatedBy]")]
        //public int? CreatedBy1
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedBy1[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedBy1[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Created Date")]
        //[Expression("jCreatedBy.[CreatedDate]")]
        //public DateTime? CreatedByCreatedDate
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByCreatedDate[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByCreatedDate[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Updated By")]
        //[Expression("jCreatedBy.[UpdatedBy]")]
        //public int? CreatedByUpdatedBy
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByUpdatedBy[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Created By Updated Date")]
        //[Expression("jCreatedBy.[UpdatedDate]")]
        //public DateTime? CreatedByUpdatedDate
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.CreatedByUpdatedDate[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Employee Id")]
        //[Expression("jUpdatedBy.[EmployeeId]")]
        //public string UpdatedByEmployeeId
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByEmployeeId[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By First Name")]
        //[Expression("jUpdatedBy.[FirstName]")]
        //public string UpdatedByFirstName
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByFirstName[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByFirstName[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Last Name")]
        //[Expression("jUpdatedBy.[LastName]")]
        //public string UpdatedByLastName
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByLastName[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByLastName[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Department Id")]
        //[Expression("jUpdatedBy.[DepartmentId]")]
        //public int? UpdatedByDepartmentId
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByDepartmentId[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Designation")]
        //[Expression("jUpdatedBy.[Designation]")]
        //public string UpdatedByDesignation
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByDesignation[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByDesignation[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Mobile Code")]
        //[Expression("jUpdatedBy.[MobileCode]")]
        //public int? UpdatedByMobileCode
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByMobileCode[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByMobileCode[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Mobile Number")]
        //[Expression("jUpdatedBy.[MobileNumber]")]
        //public int? UpdatedByMobileNumber
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByMobileNumber[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Email")]
        //[Expression("jUpdatedBy.[Email]")]
        //public string UpdatedByEmail
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByEmail[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByEmail[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Username")]
        //[Expression("jUpdatedBy.[Username]")]
        //public string UpdatedByUsername
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByUsername[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByUsername[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Password Hash")]
        //[Expression("jUpdatedBy.[PasswordHash]")]
        //public string UpdatedByPasswordHash
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByPasswordHash[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Password Salt")]
        //[Expression("jUpdatedBy.[PasswordSalt]")]
        //public string UpdatedByPasswordSalt
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByPasswordSalt[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By User Image")]
        //[Expression("jUpdatedBy.[UserImage]")]
        //public string UpdatedByUserImage
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByUserImage[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByUserImage[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Address")]
        //[Expression("jUpdatedBy.[Address]")]
        //public string UpdatedByAddress
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByAddress[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByAddress[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By City Id")]
        //[Expression("jUpdatedBy.[CityId]")]
        //public int? UpdatedByCityId
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByCityId[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByCityId[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Pin Code")]
        //[Expression("jUpdatedBy.[PinCode]")]
        //public string UpdatedByPinCode
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByPinCode[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByPinCode[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Role Id")]
        //[Expression("jUpdatedBy.[RoleId]")]
        //public int? UpdatedByRoleId
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByRoleId[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByRoleId[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Password Expiry Date")]
        //[Expression("jUpdatedBy.[PasswordExpiryDate]")]
        //public DateTime? UpdatedByPasswordExpiryDate
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Is Forgot Password")]
        //[Expression("jUpdatedBy.[IsForgotPassword]")]
        //public short? UpdatedByIsForgotPassword
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByIsForgotPassword[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Is Password Change On Login")]
        //[Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        //public bool? UpdatedByIsPasswordChangeOnLogin
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Is User Hidden")]
        //[Expression("jUpdatedBy.[IsUserHidden]")]
        //public short? UpdatedByIsUserHidden
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByIsUserHidden[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Status Id")]
        //[Expression("jUpdatedBy.[StatusId]")]
        //public int? UpdatedByStatusId
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByStatusId[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByStatusId[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Created By")]
        //[Expression("jUpdatedBy.[CreatedBy]")]
        //public int? UpdatedByCreatedBy
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByCreatedBy[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Created Date")]
        //[Expression("jUpdatedBy.[CreatedDate]")]
        //public DateTime? UpdatedByCreatedDate
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByCreatedDate[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By")]
        //[Expression("jUpdatedBy.[UpdatedBy]")]
        //public int? UpdatedBy1
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedBy1[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedBy1[(Row)this] = value;
        //    }
        //}

        //[DisplayName("Updated By Updated Date")]
        //[Expression("jUpdatedBy.[UpdatedDate]")]
        //public DateTime? UpdatedByUpdatedDate
        //{
        //    get
        //    {
        //        return MachineCommunicationRow.Fields.UpdatedByUpdatedDate[(Row)this];
        //    }
        //    set
        //    {
        //        MachineCommunicationRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
        //    }
        //}

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)MachineProtocolCommunication.Fields.ProtocolTypeId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return MachineProtocolCommunication.Fields.ProtocolName;
            }
        }

        public MachineProtocolCommunication()
          : base((RowFieldsBase)MachineProtocolCommunication.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MachineCommunicatonId;
            public Int32Field ProtocolTypeId;
            public Int32Field MachineId;
            public StringField IpAddress;
            public StringField MDBPath;
            public Int32Field TcpipPort;
            public Int32Field PollRate;
            public Int32Field StatusId;
            public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;
            //public StringField StatusStatusName;
            //public StringField CreatedByEmployeeId;
            //public StringField CreatedByFirstName;
            //public StringField CreatedByLastName;
            //public Int32Field CreatedByDepartmentId;
            //public StringField CreatedByDesignation;
            //public Int32Field CreatedByMobileCode;
            //public Int32Field CreatedByMobileNumber;
            //public StringField CreatedByEmail;
            //public StringField CreatedByUsername;
            //public StringField CreatedByPasswordHash;
            //public StringField CreatedByPasswordSalt;
            //public StringField CreatedByUserImage;
            //public StringField CreatedByAddress;
            //public Int32Field CreatedByCityId;
            //public StringField CreatedByPinCode;
            //public Int32Field CreatedByRoleId;
            //public DateTimeField CreatedByPasswordExpiryDate;
            //public Int16Field CreatedByIsForgotPassword;
            //public BooleanField CreatedByIsPasswordChangeOnLogin;
            //public Int16Field CreatedByIsUserHidden;
            //public Int32Field CreatedByStatusId;
            //public Int32Field CreatedBy1;
            //public DateTimeField CreatedByCreatedDate;
            //public Int32Field CreatedByUpdatedBy;
            //public DateTimeField CreatedByUpdatedDate;
            //public StringField UpdatedByEmployeeId;
            //public StringField UpdatedByFirstName;
            //public StringField UpdatedByLastName;
            //public Int32Field UpdatedByDepartmentId;
            //public StringField UpdatedByDesignation;
            //public Int32Field UpdatedByMobileCode;
            //public Int32Field UpdatedByMobileNumber;
            //public StringField UpdatedByEmail;
            //public StringField UpdatedByUsername;
            //public StringField UpdatedByPasswordHash;
            //public StringField UpdatedByPasswordSalt;
            //public StringField UpdatedByUserImage;
            //public StringField UpdatedByAddress;
            //public Int32Field UpdatedByCityId;
            //public StringField UpdatedByPinCode;
            //public Int32Field UpdatedByRoleId;
            //public DateTimeField UpdatedByPasswordExpiryDate;
            //public Int16Field UpdatedByIsForgotPassword;
            //public BooleanField UpdatedByIsPasswordChangeOnLogin;
            //public Int16Field UpdatedByIsUserHidden;
            //public Int32Field UpdatedByStatusId;
            //public Int32Field UpdatedByCreatedBy;
            //public DateTimeField UpdatedByCreatedDate;
            //public Int32Field UpdatedBy1;
            //public DateTimeField UpdatedByUpdatedDate;
            public StringField ProtocolName;
            public StringField MachineMachineName;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "ExternalApplicationInterface.MachineCommunication";
            }
        }
    }
}
