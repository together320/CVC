// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.MachineRecipeRow
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

namespace CVC.MachineCustomization.Entities
{
    [ConnectionKey("Default")]
    [TableName("MachineRecipe")]
    [DisplayName("Machine Recipe")]
    [InstanceName("Machine Recipe")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("MachineCustomization:MachineRecipe:Read")]
    [ModifyPermission("MachineCustomization:MachineRecipe:Modify")]

    [LookupScript("MachineCustomization.MachineRecipe", Permission = "Lookup")]

    public sealed class MachineRecipeRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly MachineRecipeRow.RowFields Fields = new MachineRecipeRow.RowFields().Init<MachineRecipeRow.RowFields>();

        [DisplayName("Machine Recipe Id")]
        [Identity]
        public int? MachineRecipeId
        {
            get
            {
                return MachineRecipeRow.Fields.MachineRecipeId[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.MachineRecipeId[(Row)this] = value;
            }
        }

        //[DisplayName("Machine Id")]
        //public int? MachineId
        //{
        //    get
        //    {
        //        return MachineRecipeRow.Fields.MachineId[(Row)this];
        //    }
        //    set
        //    {
        //        MachineRecipeRow.Fields.MachineId[(Row)this] = value;
        //    }
        //}
        [DisplayName("Pack Id")]
        public int? PackId
        {
            get
            {
                return MachineRecipeRow.Fields.PackId[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.PackId[(Row)this] = value;
            }
        }
        [DisplayName("Recipe Settings Id")]
        public int? RecipeSettingsId
        {
            get
            {
                return MachineRecipeRow.Fields.RecipeSettingsId[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.RecipeSettingsId[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
      //  [Expression("jMachineRecipe.[RecipeName]")]

        [NotNull]
       // [Unique(CheckBeforeSave =true)]
        public string RecipeName
        {
            get
            {
                return MachineRecipeRow.Fields.RecipeName[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.RecipeName[(Row)this] = value;
            }
        }

        [DisplayName("Description")]
        [Size(500)]
        [NotNull]
        public string Description
        {
            get
            {
                return MachineRecipeRow.Fields.Description[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.Description[(Row)this] = value;
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
                return MachineRecipeRow.Fields.StatusId[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return MachineRecipeRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Birth Date")]
        [Expression("jCreatedBy.[BirthDate]")]
        public DateTime? CreatedByBirthDate
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByBirthDate[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByBirthDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return MachineRecipeRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Birth Date")]
        [Expression("jUpdatedBy.[BirthDate]")]
        public DateTime? UpdatedByBirthDate
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByBirthDate[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByBirthDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return MachineRecipeRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }
       
        //changes added by Vinayak 

        public bool? IsDefaultRecipe
        {
            get
            {
                return MachineRecipeRow.Fields.IsDefaultRecipe[(Row)this];

              
            }
            set
            {
                MachineRecipeRow.Fields.IsDefaultRecipe[(Row)this] = value;

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
                return MachineRecipeRow.Fields.MachineId[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Business Entity")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return MachineRecipeRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                MachineRecipeRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }


        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)MachineRecipeRow.Fields.MachineRecipeId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return MachineRecipeRow.Fields.RecipeName;
            }
        }

        public MachineRecipeRow()
          : base((RowFieldsBase)MachineRecipeRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field MachineRecipeId;
            public Int32Field MachineId;
            public Int32Field PackId;
            public Int32Field RecipeSettingsId;
            public StringField RecipeName;
            public StringField Description;
            public Int32Field StatusId;
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
            public BooleanField IsDefaultRecipe;
            public StringField MachineMachineName;
            // public int? ModuleId;

            public RowFields()
        : base((string)null, (string)null)
            {
                this.LocalTextPrefix = "MachineCustomization.MachineRecipe";
            }
        }
    }
}
