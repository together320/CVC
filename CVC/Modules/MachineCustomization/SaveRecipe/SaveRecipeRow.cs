//using Serenity.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace CVC.Modules.MachineCustomization.SaveRecipe
//{
//    [ReadPermission("MachineCustomization:SaveRecipe:Read")]
//    [ModifyPermission("MachineCustomization:SaveRecipe:Modify")]
//    public sealed class SaveRecipeRow
//    {
//    }
//}


// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.SaveRecipeRow
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

namespace CVC.Modules.MachineCustomization.SaveRecipe
{
    [ConnectionKey("Default")]
    [TableName("MachineRecipe")]
    [DisplayName("Machine Recipe")]
    [InstanceName("Machine Recipe")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("MachineCustomization:SaveRecipe:Read")]
    [ModifyPermission("MachineCustomization:SaveRecipe:Modify")]

    [LookupScript("MachineCustomization.SaveRecipe", Permission = "Lookup")]

    public sealed class SaveRecipeRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly SaveRecipeRow.RowFields Fields = new SaveRecipeRow.RowFields().Init<SaveRecipeRow.RowFields>();

        [DisplayName("Machine Recipe Id")]
        [Identity]
        public int? MachineRecipeId
        {
            get
            {
                return SaveRecipeRow.Fields.MachineRecipeId[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.MachineRecipeId[(Row)this] = value;
            }
        }

        //[DisplayName("Machine Id")]
        //public int? MachineId
        //{
        //    get
        //    {
        //        return SaveRecipeRow.Fields.MachineId[(Row)this];
        //    }
        //    set
        //    {
        //        SaveRecipeRow.Fields.MachineId[(Row)this] = value;
        //    }
        //}
        [DisplayName("Pack Id")]
        public int? PackId
        {
            get
            {
                return SaveRecipeRow.Fields.PackId[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.PackId[(Row)this] = value;
            }
        }
        [DisplayName("Recipe Settings Id")]
        public int? RecipeSettingsId
        {
            get
            {
                return SaveRecipeRow.Fields.RecipeSettingsId[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.RecipeSettingsId[(Row)this] = value;
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
                return SaveRecipeRow.Fields.RecipeName[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.RecipeName[(Row)this] = value;
            }
        }

        [DisplayName("Description")]
        [Size(500)]
        [NotNull]
        public string Description
        {
            get
            {
                return SaveRecipeRow.Fields.Description[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.Description[(Row)this] = value;
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
                return SaveRecipeRow.Fields.StatusId[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return SaveRecipeRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Birth Date")]
        [Expression("jCreatedBy.[BirthDate]")]
        public DateTime? CreatedByBirthDate
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByBirthDate[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByBirthDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return SaveRecipeRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Birth Date")]
        [Expression("jUpdatedBy.[BirthDate]")]
        public DateTime? UpdatedByBirthDate
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByBirthDate[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByBirthDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return SaveRecipeRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        //changes added by Vinayak 

        public bool? IsDefaultRecipe
        {
            get
            {
                return SaveRecipeRow.Fields.IsDefaultRecipe[(Row)this];


            }
            set
            {
                SaveRecipeRow.Fields.IsDefaultRecipe[(Row)this] = value;

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
                return SaveRecipeRow.Fields.MachineId[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Business Entity")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return SaveRecipeRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                SaveRecipeRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }


        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)SaveRecipeRow.Fields.MachineRecipeId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return SaveRecipeRow.Fields.RecipeName;
            }
        }

        public SaveRecipeRow()
          : base((RowFieldsBase)SaveRecipeRow.Fields)
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
                this.LocalTextPrefix = "MachineCustomization.SaveRecipe";
            }
        }
    }
}
