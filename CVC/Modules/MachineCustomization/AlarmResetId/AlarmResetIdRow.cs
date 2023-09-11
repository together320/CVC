// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.AlarmResetIdRow
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
    [TableName("AlarmResetId")]
    [DisplayName("Alarm Reset Id")]
    [InstanceName("Alarm Reset Id")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class AlarmResetIdRow : Row, IIdRow, IEntity, IAuditLog
    {
        public static readonly AlarmResetIdRow.RowFields Fields = new AlarmResetIdRow.RowFields().Init<AlarmResetIdRow.RowFields>();

        [DisplayName("Alarm Reset Role Id")]
        [Identity]
        public int? AlarmResetRoleId
        {
            get
            {
                return AlarmResetIdRow.Fields.AlarmResetRoleId[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.AlarmResetRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Alarm Id")]
        public int? AlarmId
        {
            get
            {
                return AlarmResetIdRow.Fields.AlarmId[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.AlarmId[(Row)this] = value;
            }
        }

        [DisplayName("Role Id")]
        public int? RoleId
        {
            get
            {
                return AlarmResetIdRow.Fields.RoleId[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.RoleId[(Row)this] = value;
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
                return AlarmResetIdRow.Fields.StatusId[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.StatusId[(Row)this] = value;
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
                return AlarmResetIdRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedDate[(Row)this] = value;
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
                return AlarmResetIdRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return AlarmResetIdRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return AlarmResetIdRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return AlarmResetIdRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                AlarmResetIdRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)AlarmResetIdRow.Fields.AlarmResetRoleId;
            }
        }

        public AlarmResetIdRow()
          : base((RowFieldsBase)AlarmResetIdRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field AlarmResetRoleId;
            public Int32Field AlarmId;
            public Int32Field RoleId;
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
                this.LocalTextPrefix = "MachineCustomization.AlarmResetId";
            }
        }
    }
}
