// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Entities.UserRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CVC.Administration.Entities
{
    [ConnectionKey("Default")]
    [TableName("Users")]
    [DisplayName("Users")]
    [InstanceName("User")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Administration:User:Read")]
    [ModifyPermission("Administration:User:Modify")]
    [LookupScript("Administration.User", Permission = "Lookup")]
    public sealed class UserRow : LoggingRow, IIdRow, IEntity, INameRow, IIsActiveRow, IAuditLog
    {
        public static readonly UserRow.RowFields Fields = new UserRow.RowFields().Init<UserRow.RowFields>();

        [DisplayName("User Id")]
        [Identity]
        public int? UserId
        {
            get
            {
                return UserRow.Fields.UserId[(Row)this];
            }
            set
            {
                UserRow.Fields.UserId[(Row)this] = value;
            }
        }

        [DisplayName("Employee Id")]
        [Size(15)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string EmployeeId
        {
            get
            {
                return UserRow.Fields.EmployeeId[(Row)this];
            }
            set
            {
                UserRow.Fields.EmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Department Id")]
        [ForeignKey("Department", "DepartmentId")]
        [LeftJoin("jDepartment")]
        [TextualField("DepartmentName")]
        [NotNull]
        public int? DepartmentId
        {
            get
            {
                return UserRow.Fields.DepartmentId[(Row)this];
            }
            set
            {
                UserRow.Fields.DepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Department")]
        [Expression("jDepartment.[DepartmentName]")]
        public string DepartmentName
        {
            get
            {
                return UserRow.Fields.DepartmentName[(Row)this];
            }
            set
            {
                UserRow.Fields.DepartmentName[(Row)this] = value;
            }
        }

        [DisplayName("Designation")]
        [Size(50)]
        public string Designation
        {
            get
            {
                return UserRow.Fields.Designation[(Row)this];
            }
            set
            {
                UserRow.Fields.Designation[(Row)this] = value;
            }
        }

        [DisplayName("Mobile Code")]
        [Size(5)]
        public int? MobileCode
        {
            get
            {
                return UserRow.Fields.MobileCode[(Row)this];
            }
            set
            {
                UserRow.Fields.MobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Mobile Number")]
        [Size(10)]
        public Int64? MobileNumber
        {
            get
            {
                return UserRow.Fields.MobileNumber[(Row)this];
            }
            set
            {
                UserRow.Fields.MobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Mobile Number")]
        [Expression("(CAST(MobileCode as varchar) + ' ' + CAST(MobileNumber as varchar))")]
        public string MobileNumberString
        {
            get
            {
                return UserRow.Fields.MobileNumberString[(Row)this];
            }
            set
            {
                UserRow.Fields.MobileNumberString[(Row)this] = value;
            }
        }

        [DisplayName("Username")]
        [Size(50)]
        [NotNull]
        [QuickSearch(SearchType.Auto, -1, false)]
        [LookupInclude]
        [Unique]
        [Updatable(false)]
        public string Username
        {

            get
            {

                return UserRow.Fields.Username[(Row)this];


            }
            set
            {
                UserRow.Fields.Username[(Row)this] = value;
            }
        }

        [DisplayName("Password Hash")]
        [Size(86)]
        [NotNull]
        [Insertable(false)]
        [Updatable(false)]
        [MinSelectLevel(SelectLevel.Never)]
        public string PasswordHash
        {
            get
            {
                return UserRow.Fields.PasswordHash[(Row)this];
            }
            set
            {
                UserRow.Fields.PasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Password Salt")]
        [Size(10)]
        [NotNull]
        [Insertable(false)]
        [Updatable(false)]
        [MinSelectLevel(SelectLevel.Never)]
        public string PasswordSalt
        {
            get
            {
                return UserRow.Fields.PasswordSalt[(Row)this];
            }
            set
            {
                UserRow.Fields.PasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("First Name")]
        [Size(25)]
        [NotNull]
        [LookupInclude]
        public string FirstName
        {
            get
            {
                return UserRow.Fields.FirstName[(Row)this];
            }
            set
            {
                UserRow.Fields.FirstName[(Row)this] = value;
            }
        }

        [DisplayName("Last Name")]
        [Size(25)]
        [NotNull]
        [LookupInclude]
        public string LastName
        {
            get
            {
                return UserRow.Fields.LastName[(Row)this];
            }
            set
            {
                UserRow.Fields.LastName[(Row)this] = value;
            }
        }

        [DisplayName("Email")]
        [Size(100)]
        public string Email
        {
            get
            {
                return UserRow.Fields.Email[(Row)this];
            }
            set
            {
                UserRow.Fields.Email[(Row)this] = value;
            }
        }

        [DisplayName("User Image")]
        [Size(100)]
        [ImageUploadEditor(CopyToHistory = true, FilenameFormat = "UserImage/~")]
        public string UserImage
        {
            get
            {
                return UserRow.Fields.UserImage[(Row)this];
            }
            set
            {
                UserRow.Fields.UserImage[(Row)this] = value;
            }
        }

        [DisplayName("Password")]
        [Size(50)]
        [NotMapped]
        public string Password
        {
            get
            {
                return UserRow.Fields.Password[(Row)this];
            }
            set
            {
                UserRow.Fields.Password[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [ForeignKey("Status", "StatusId")]
        [LeftJoin("jStatus")]
        [TextualField("StatusStatusName")]
        //To make status as default "Active"
        [DefaultValue(1)]
        [NotNull]
        public short? StatusId
        {
            get
            {
                return UserRow.Fields.StatusId[(Row)this];
            }
            set
            {
                UserRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return UserRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                UserRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Confirm Password")]
        [Size(50)]
        [NotMapped]
        public string PasswordConfirm
        {
            get
            {
                return UserRow.Fields.PasswordConfirm[(Row)this];
            }
            set
            {
                UserRow.Fields.PasswordConfirm[(Row)this] = value;
            }
        }

        [DisplayName("Address")]
        [Size(500)]
        public string Address
        {
            get
            {
                return UserRow.Fields.Address[(Row)this];
            }
            set
            {
                UserRow.Fields.Address[(Row)this] = value;
            }
        }

        [DisplayName("City")]
        [ForeignKey("CityDetails", "CityDetailsId")]
        [LeftJoin("jCity")]
        [TextualField("CityCountry")]
        [NotNull]
        public int? CityId
        {
            get
            {
                return UserRow.Fields.CityId[(Row)this];
            }
            set
            {
                UserRow.Fields.CityId[(Row)this] = value;
            }
        }

        [DisplayName("Country")]
        [Expression("jCity.[Country]")]
        public string CityCountry
        {
            get
            {
                return UserRow.Fields.CityCountry[(Row)this];
            }
            set
            {
                UserRow.Fields.CityCountry[(Row)this] = value;
            }
        }

        [DisplayName("City State")]
        [Expression("jCity.[State]")]
        public string CityState
        {
            get
            {
                return UserRow.Fields.CityState[(Row)this];
            }
            set
            {
                UserRow.Fields.CityState[(Row)this] = value;
            }
        }

        [DisplayName("City")]
        [Expression("jCity.[City]")]
        public string City
        {
            get
            {
                return UserRow.Fields.City[(Row)this];
            }
            set
            {
                UserRow.Fields.City[(Row)this] = value;
            }
        }

        public bool? IsLockOut
        {
            get
            {
                return UserRow.Fields.IsLockOut[(Row)this];
            }
            set
            {
                UserRow.Fields.IsLockOut[(Row)this] = value;
            }
        }

        [DisplayName("Pin Code")]
        [Size(50)]
        public string PinCode
        {
            get
            {
                return UserRow.Fields.PinCode[(Row)this];
            }
            set
            {
                UserRow.Fields.PinCode[(Row)this] = value;
            }
        }

        [DisplayName("Role")]
        [Column("RoleId")]
        [ForeignKey("Roles", "RoleId")]
        [LeftJoin("jRoles")]
        [TextualField("RolesRoleName")]
        [NotNull]
        public int? RoleId
        {
            get
            {
                return UserRow.Fields.RoleId[(Row)this];
            }
            set
            {
                UserRow.Fields.RoleId[(Row)this] = value;
            }
        }

        [DisplayName("Role")]
        [Expression("jRoles.[RoleName]")]
        public string RolesRoleName
        {
            get
            {
                return UserRow.Fields.RolesRoleName[(Row)this];
            }
            set
            {
                UserRow.Fields.RolesRoleName[(Row)this] = value;
            }
        }

        [DisplayName("Password Expiry Date")]
        public DateTime? PasswordExpiryDate
        {
            get
            {
                return UserRow.Fields.PasswordExpiryDate[(Row)this];
            }
            set
            {
                UserRow.Fields.PasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Is Forgot Password")]
        public short? IsForgotPassword
        {
            get
            {
                return UserRow.Fields.IsForgotPassword[(Row)this];
            }
            set
            {
                UserRow.Fields.IsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Is Password Change On Login")]
        public bool? IsPasswordChangeOnLogin
        {
            get
            {
                return UserRow.Fields.IsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                UserRow.Fields.IsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Is User Hidden")]
        public short? IsUserHidden
        {
            get
            {
                return UserRow.Fields.IsUserHidden[(Row)this];
            }
            set
            {
                UserRow.Fields.IsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("IsActiveDirectory")]


        [DefaultValue(0)]
        public bool? IsActiveDirectory
        {
            get
            {
                return UserRow.Fields.IsActiveDirectory[(Row)this];
            }
            set
            {
                UserRow.Fields.IsActiveDirectory[(Row)this] = value;
            }
        }




        [DisplayName("Birth Date")]
        public DateTime? BirthDate
        {
            get
            {
                return UserRow.Fields.BirthDate[(Row)this];
            }
            set
            {
                UserRow.Fields.BirthDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        public int? CreatedBy
        {
            get
            {
                return UserRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                UserRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return UserRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                UserRow.Fields.CreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        public int? UpdatedBy
        {
            get
            {
                return UserRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                UserRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Question")]
        [ForeignKey("PickListValue", "PickListValueId")]
        [NotNull]
        public int? QuestionId
        {
            get
            {
                return UserRow.Fields.QuestionId[(Row)this];
            }
            set
            {
                UserRow.Fields.QuestionId[(Row)this] = value;
            }
        }

        [DisplayName("Answer")]
        [Size(50)]
        [NotNull]
        public string QuestionAns
        {
            get
            {
                return UserRow.Fields.QuestionAns[(Row)this];
            }
            set
            {
                UserRow.Fields.QuestionAns[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return UserRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                UserRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return UserRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                UserRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }

        //[DisplayName("Business Entity")]
        //[ForeignKey("Machine", "MachineId")]
        //[LeftJoin("jMachine")]
        //[TextualField("MachineMachineName")]
        //[NotNull]
        //[LookupInclude]
        //public string MachineId
        //{
        //    get
        //    {
        //        return UserRow.Fields.MachineId[(Row)this];
        //    }
        //    set
        //    {
        //        UserRow.Fields.MachineId[(Row)this] = value;
        //    }
        //}

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)UserRow.Fields.UserId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return UserRow.Fields.Username;
            }
        }

        Int16Field IIsActiveRow.IsActiveField
        {
            get
            {
                return UserRow.Fields.StatusId;
            }
        }

        public UserRow()
          : base((RowFieldsBase)UserRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        // public class RowFields : RowFieldsBase
        {
            public Int32Field UserId;
            public StringField EmployeeId;
            public StringField Username;
            public StringField FirstName;
            public StringField LastName;
            public Int32Field DepartmentId;
            public StringField Designation;
            public Int32Field MobileCode;
            public Int64Field MobileNumber;
            public StringField PasswordHash;
            public StringField PasswordSalt;
            public StringField Email;
            public StringField UserImage;
            public Int16Field StatusId;
            public StringField Password;
            public StringField PasswordConfirm;
            public StringField Address;
            public Int32Field CityId;
            public StringField PinCode;
            public Int32Field RoleId;
            public DateTimeField PasswordExpiryDate;
            public Int16Field IsForgotPassword;
            public BooleanField IsPasswordChangeOnLogin;
            public Int16Field IsUserHidden;
            public DateTimeField BirthDate;
           /* public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;*/
            public StringField StatusStatusName;
            public StringField DepartmentName;
            public StringField CityState;
            public StringField City;
            public BooleanField IsLockOut;
            public StringField CityCountry;
            public StringField MobileNumberString;
            public StringField RolesRoleName;
            public Int32Field QuestionId;
            public StringField QuestionAns;
            public BooleanField IsActiveDirectory;
            public StringField RecordAddedSource;



            // public StringField MachineId;
            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Administration.User";
            }
        }
    }
}
