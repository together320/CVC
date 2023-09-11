// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.MachineUserRow
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
    [TableName("MachineUser")]
    [DisplayName("Machine User")]
    [InstanceName("Machine User")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MachineUserRow : Row, IIdRow, IEntity, IAuditLog
    {
        public static readonly MachineUserRow.RowFields Fields = new MachineUserRow.RowFields().Init<MachineUserRow.RowFields>();

        [DisplayName("Machine User Id")]
        [Identity]
        public int? MachineUserId
        {
            get
            {
                return MachineUserRow.Fields.MachineUserId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.MachineUserId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Id")]
        public int? MachineId
        {
            get
            {
                return MachineUserRow.Fields.MachineId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.MachineId[(Row)this] = value;
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
                return MachineUserRow.Fields.UserId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserId[(Row)this] = value;
            }
        }

        [DisplayName("Shift")]
        [ForeignKey("Shift", "ShiftId")]
        [LeftJoin("jShift")]
        [TextualField("ShiftShiftName")]
        public int? ShiftId
        {
            get
            {
                return MachineUserRow.Fields.ShiftId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.ShiftId[(Row)this] = value;
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
                return MachineUserRow.Fields.StatusId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.StatusId[(Row)this] = value;
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
                return MachineUserRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return MachineUserRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedDate[(Row)this] = value;
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
                return MachineUserRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return MachineUserRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("User Employee Id")]
        [Expression("jUser.[EmployeeId]")]
        public string UserEmployeeId
        {
            get
            {
                return MachineUserRow.Fields.UserEmployeeId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("User First Name")]
        [Expression("jUser.[FirstName]")]
        public string UserFirstName
        {
            get
            {
                return MachineUserRow.Fields.UserFirstName[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserFirstName[(Row)this] = value;
            }
        }

        [DisplayName("User Last Name")]
        [Expression("jUser.[LastName]")]
        public string UserLastName
        {
            get
            {
                return MachineUserRow.Fields.UserLastName[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserLastName[(Row)this] = value;
            }
        }

        [DisplayName("User Department Id")]
        [Expression("jUser.[DepartmentId]")]
        public int? UserDepartmentId
        {
            get
            {
                return MachineUserRow.Fields.UserDepartmentId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("User Designation")]
        [Expression("jUser.[Designation]")]
        public string UserDesignation
        {
            get
            {
                return MachineUserRow.Fields.UserDesignation[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserDesignation[(Row)this] = value;
            }
        }

        [DisplayName("User Mobile Code")]
        [Expression("jUser.[MobileCode]")]
        public int? UserMobileCode
        {
            get
            {
                return MachineUserRow.Fields.UserMobileCode[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("User Mobile Number")]
        [Expression("jUser.[MobileNumber]")]
        public int? UserMobileNumber
        {
            get
            {
                return MachineUserRow.Fields.UserMobileNumber[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("User Email")]
        [Expression("jUser.[Email]")]
        public string UserEmail
        {
            get
            {
                return MachineUserRow.Fields.UserEmail[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserEmail[(Row)this] = value;
            }
        }

        [DisplayName("User Username")]
        [Expression("jUser.[Username]")]
        public string UserUsername
        {
            get
            {
                return MachineUserRow.Fields.UserUsername[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserUsername[(Row)this] = value;
            }
        }

        [DisplayName("User Password Hash")]
        [Expression("jUser.[PasswordHash]")]
        public string UserPasswordHash
        {
            get
            {
                return MachineUserRow.Fields.UserPasswordHash[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("User Password Salt")]
        [Expression("jUser.[PasswordSalt]")]
        public string UserPasswordSalt
        {
            get
            {
                return MachineUserRow.Fields.UserPasswordSalt[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("User User Image")]
        [Expression("jUser.[UserImage]")]
        public Stream UserUserImage
        {
            get
            {
                return MachineUserRow.Fields.UserUserImage[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserUserImage[(Row)this] = value;
            }
        }

        [DisplayName("User Address")]
        [Expression("jUser.[Address]")]
        public string UserAddress
        {
            get
            {
                return MachineUserRow.Fields.UserAddress[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserAddress[(Row)this] = value;
            }
        }

        [DisplayName("User City Id")]
        [Expression("jUser.[CityId]")]
        public int? UserCityId
        {
            get
            {
                return MachineUserRow.Fields.UserCityId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserCityId[(Row)this] = value;
            }
        }

        [DisplayName("User Pin Code")]
        [Expression("jUser.[PinCode]")]
        public string UserPinCode
        {
            get
            {
                return MachineUserRow.Fields.UserPinCode[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserPinCode[(Row)this] = value;
            }
        }

        [DisplayName("User Role Id")]
        [Expression("jUser.[RoleId]")]
        public int? UserRoleId
        {
            get
            {
                return MachineUserRow.Fields.UserRoleId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserRoleId[(Row)this] = value;
            }
        }

        [DisplayName("User Password Expiry Date")]
        [Expression("jUser.[PasswordExpiryDate]")]
        public DateTime? UserPasswordExpiryDate
        {
            get
            {
                return MachineUserRow.Fields.UserPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("User Is Forgot Password")]
        [Expression("jUser.[IsForgotPassword]")]
        public short? UserIsForgotPassword
        {
            get
            {
                return MachineUserRow.Fields.UserIsForgotPassword[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("User Is Password Change On Login")]
        [Expression("jUser.[IsPasswordChangeOnLogin]")]
        public bool? UserIsPasswordChangeOnLogin
        {
            get
            {
                return MachineUserRow.Fields.UserIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("User Is User Hidden")]
        [Expression("jUser.[IsUserHidden]")]
        public short? UserIsUserHidden
        {
            get
            {
                return MachineUserRow.Fields.UserIsUserHidden[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("User Status Id")]
        [Expression("jUser.[StatusId]")]
        public int? UserStatusId
        {
            get
            {
                return MachineUserRow.Fields.UserStatusId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserStatusId[(Row)this] = value;
            }
        }

        [DisplayName("User Created By")]
        [Expression("jUser.[CreatedBy]")]
        public int? UserCreatedBy
        {
            get
            {
                return MachineUserRow.Fields.UserCreatedBy[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("User Created Date")]
        [Expression("jUser.[CreatedDate]")]
        public DateTime? UserCreatedDate
        {
            get
            {
                return MachineUserRow.Fields.UserCreatedDate[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("User Updated By")]
        [Expression("jUser.[UpdatedBy]")]
        public int? UserUpdatedBy
        {
            get
            {
                return MachineUserRow.Fields.UserUpdatedBy[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("User Updated Date")]
        [Expression("jUser.[UpdatedDate]")]
        public DateTime? UserUpdatedDate
        {
            get
            {
                return MachineUserRow.Fields.UserUpdatedDate[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UserUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Shift Shift Name")]
        [Expression("jShift.[ShiftName]")]
        public string ShiftShiftName
        {
            get
            {
                return MachineUserRow.Fields.ShiftShiftName[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.ShiftShiftName[(Row)this] = value;
            }
        }

        [DisplayName("Shift Start Time")]
        [Expression("jShift.[StartTime]")]
        public string ShiftStartTime
        {
            get
            {
                return MachineUserRow.Fields.ShiftStartTime[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.ShiftStartTime[(Row)this] = value;
            }
        }

        [DisplayName("Shift End Time")]
        [Expression("jShift.[EndTime]")]
        public string ShiftEndTime
        {
            get
            {
                return MachineUserRow.Fields.ShiftEndTime[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.ShiftEndTime[(Row)this] = value;
            }
        }

        [DisplayName("Shift Status Id")]
        [Expression("jShift.[StatusId]")]
        public int? ShiftStatusId
        {
            get
            {
                return MachineUserRow.Fields.ShiftStatusId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.ShiftStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Shift Created By")]
        [Expression("jShift.[CreatedBy]")]
        public int? ShiftCreatedBy
        {
            get
            {
                return MachineUserRow.Fields.ShiftCreatedBy[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.ShiftCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Shift Created Date")]
        [Expression("jShift.[CreatedDate]")]
        public DateTime? ShiftCreatedDate
        {
            get
            {
                return MachineUserRow.Fields.ShiftCreatedDate[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.ShiftCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Shift Updated By")]
        [Expression("jShift.[UpdatedBy]")]
        public int? ShiftUpdatedBy
        {
            get
            {
                return MachineUserRow.Fields.ShiftUpdatedBy[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.ShiftUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Shift Updated Date")]
        [Expression("jShift.[UpdatedDate]")]
        public DateTime? ShiftUpdatedDate
        {
            get
            {
                return MachineUserRow.Fields.ShiftUpdatedDate[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.ShiftUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return MachineUserRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return MachineUserRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return MachineUserRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return MachineUserRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return MachineUserRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return MachineUserRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return MachineUserRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return MachineUserRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return MachineUserRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return MachineUserRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return MachineUserRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return MachineUserRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return MachineUserRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return MachineUserRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return MachineUserRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return MachineUserRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return MachineUserRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return MachineUserRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return MachineUserRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineUserRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return MachineUserRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return MachineUserRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return MachineUserRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return MachineUserRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return MachineUserRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return MachineUserRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return MachineUserRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return MachineUserRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineUserRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)MachineUserRow.Fields.MachineUserId;
            }
        }

        public MachineUserRow()
          : base((RowFieldsBase)MachineUserRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MachineUserId;
            public Int32Field MachineId;
            public Int32Field UserId;
            public Int32Field ShiftId;
            public Int32Field StatusId;
            public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;
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
            public StringField ShiftShiftName;
            public StringField ShiftStartTime;
            public StringField ShiftEndTime;
            public Int32Field ShiftStatusId;
            public Int32Field ShiftCreatedBy;
            public DateTimeField ShiftCreatedDate;
            public Int32Field ShiftUpdatedBy;
            public DateTimeField ShiftUpdatedDate;
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
                this.LocalTextPrefix = "MachineCustomization.MachineUser";
            }
        }
    }
}
