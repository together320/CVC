// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.LineMaintenanceScheduleRow
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
    [TableName("LineMaintenanceSchedule")]
    [DisplayName("Line Maintenance Schedule")]
    [InstanceName("Line Maintenance Schedule")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class LineMaintenanceScheduleRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly LineMaintenanceScheduleRow.RowFields Fields = new LineMaintenanceScheduleRow.RowFields().Init<LineMaintenanceScheduleRow.RowFields>();

        [DisplayName("Line Main Sch Id")]
        [Identity]
        public int? LineMainSchId
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.LineMainSchId[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.LineMainSchId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Line Id")]
        public int? MachineLineId
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.MachineLineId[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.MachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Start Date Time")]
        public DateTime? StartDateTime
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.StartDateTime[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.StartDateTime[(Row)this] = value;
            }
        }

        [DisplayName("End Date Time")]
        public DateTime? EndDateTime
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.EndDateTime[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.EndDateTime[(Row)this] = value;
            }
        }

        [DisplayName("Description")]
        [Size(500)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string Description
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.Description[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.Description[(Row)this] = value;
            }
        }

        [DisplayName("Remark")]
        [Size(500)]
        public string Remark
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.Remark[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.Remark[(Row)this] = value;
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
                return LineMaintenanceScheduleRow.Fields.StatusId[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.StatusId[(Row)this] = value;
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
                return LineMaintenanceScheduleRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedDate[(Row)this] = value;
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
                return LineMaintenanceScheduleRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                LineMaintenanceScheduleRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)LineMaintenanceScheduleRow.Fields.LineMainSchId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return LineMaintenanceScheduleRow.Fields.Description;
            }
        }

        public LineMaintenanceScheduleRow()
          : base((RowFieldsBase)LineMaintenanceScheduleRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field LineMainSchId;
            public Int32Field MachineLineId;
            public DateTimeField StartDateTime;
            public DateTimeField EndDateTime;
            public StringField Description;
            public StringField Remark;
            public Int32Field StatusId;
            public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;
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
                this.LocalTextPrefix = "MachineCustomization.LineMaintenanceSchedule";
            }
        }
    }
}
