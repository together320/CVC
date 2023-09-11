// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.MachineLineUserRow
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
    [TableName("MachineLineUser")]
    [DisplayName("Machine Line User")]
    [InstanceName("Machine Line User")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MachineLineUserRow : Row, IIdRow, IEntity, IAuditLog
    {
        public static readonly MachineLineUserRow.RowFields Fields = new MachineLineUserRow.RowFields().Init<MachineLineUserRow.RowFields>();

        [DisplayName("Machine Line User Id")]
        [Identity]
        public int? MachineLineUserId
        {
            get
            {
                return MachineLineUserRow.Fields.MachineLineUserId[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.MachineLineUserId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Line Id")]
        public int? MachineLineId
        {
            get
            {
                return MachineLineUserRow.Fields.MachineLineId[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.MachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("User Id")]
        public int? UserId
        {
            get
            {
                return MachineLineUserRow.Fields.UserId[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UserId[(Row)this] = value;
            }
        }

        [DisplayName("Shift Id")]
        public int? ShiftId
        {
            get
            {
                return MachineLineUserRow.Fields.ShiftId[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.ShiftId[(Row)this] = value;
            }
        }

        [DisplayName("Status Id")]
        //To make status as default "Active"
        [DefaultValue(1)]
        public int? StatusId
        {
            get
            {
                return MachineLineUserRow.Fields.StatusId[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.StatusId[(Row)this] = value;
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
                return MachineLineUserRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedDate[(Row)this] = value;
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
                return MachineLineUserRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return MachineLineUserRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return MachineLineUserRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineLineUserRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)MachineLineUserRow.Fields.MachineLineUserId;
            }
        }

        public MachineLineUserRow()
          : base((RowFieldsBase)MachineLineUserRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MachineLineUserId;
            public Int32Field MachineLineId;
            public Int32Field UserId;
            public Int32Field ShiftId;
            public Int32Field StatusId;
            public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;
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
                this.LocalTextPrefix = "MachineCustomization.MachineLineUser";
            }
        }
    }
}
