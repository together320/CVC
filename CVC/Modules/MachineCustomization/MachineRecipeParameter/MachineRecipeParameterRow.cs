// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.MachineRecipeParameterRow
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
    [TableName("MachineRecipeParameter")]
    [DisplayName("Machine Recipe Parameter")]
    [InstanceName("Machine Recipe Parameter")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("MachineCustomization:MachineRecipeParameter:Read")]
    [ModifyPermission("MachineCustomization:MachineRecipeParameter:Modify")]
    public sealed class MachineRecipeParameterRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly MachineRecipeParameterRow.RowFields Fields = new MachineRecipeParameterRow.RowFields().Init<MachineRecipeParameterRow.RowFields>();

        [DisplayName("Machine Recipe Parameter Id")]
        [Identity]
        public long? MachineRecipeParameterId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.MachineRecipeParameterId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.MachineRecipeParameterId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Recipe Id")]
        [ForeignKey("MachineRecipe", "MachineRecipeId")]
        [LeftJoin("jMachineRecipe")]
        public int? MachineRecipeId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.MachineRecipeId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.MachineRecipeId[(Row)this] = value;
            }
        }

        [Expression("jMachineRecipe.[RecipeName]")]
        public string MachineRecipeName
        {
            get
            {
                return MachineRecipeParameterRow.Fields.MachineRecipeName[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.MachineRecipeName[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings Parameter")]
        [ForeignKey("RecipeSettingsParameter", "RecipeParameterId")]
        [LeftJoin("jRecipeSettingsParameter")]
        public int? RecipeSettingsParameterId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.RecipeSettingsParameterId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.RecipeSettingsParameterId[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Parameter Value")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string RecipeParameterValue
        {
            get
            {
                return MachineRecipeParameterRow.Fields.RecipeParameterValue[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.RecipeParameterValue[(Row)this] = value;
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
                return MachineRecipeParameterRow.Fields.StatusId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.StatusId[(Row)this] = value;
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
                return MachineRecipeParameterRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedDate[(Row)this] = value;
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
                return MachineRecipeParameterRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings Parameter Recipe Settings Id")]
        [Expression("jRecipeSettingsParameter.[RecipeSettingsId]")]
        public int? RecipeSettingsParameterRecipeSettingsId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.RecipeSettingsParameterRecipeSettingsId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.RecipeSettingsParameterRecipeSettingsId[(Row)this] = value;
            }
        }

     
        [DisplayName("Recipe Settings Parameter Is Fetch On Self Set")]
        [Expression("jRecipeSettingsParameter.[IsFetchOnSelfSet]")]
        public short? RecipeSettingsParameterIsFetchOnSelfSet
        {
            get
            {
                return MachineRecipeParameterRow.Fields.RecipeSettingsParameterIsFetchOnSelfSet[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.RecipeSettingsParameterIsFetchOnSelfSet[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings Parameter Status Id")]
        [Expression("jRecipeSettingsParameter.[StatusId]")]
        public int? RecipeSettingsParameterStatusId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.RecipeSettingsParameterStatusId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.RecipeSettingsParameterStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings Parameter Created By")]
        [Expression("jRecipeSettingsParameter.[CreatedBy]")]
        public int? RecipeSettingsParameterCreatedBy
        {
            get
            {
                return MachineRecipeParameterRow.Fields.RecipeSettingsParameterCreatedBy[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.RecipeSettingsParameterCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings Parameter Created Date")]
        [Expression("jRecipeSettingsParameter.[CreatedDate]")]
        public DateTime? RecipeSettingsParameterCreatedDate
        {
            get
            {
                return MachineRecipeParameterRow.Fields.RecipeSettingsParameterCreatedDate[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.RecipeSettingsParameterCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings Parameter Updated By")]
        [Expression("jRecipeSettingsParameter.[UpdatedBy]")]
        public int? RecipeSettingsParameterUpdatedBy
        {
            get
            {
                return MachineRecipeParameterRow.Fields.RecipeSettingsParameterUpdatedBy[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.RecipeSettingsParameterUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Recipe Settings Parameter Updated Date")]
        [Expression("jRecipeSettingsParameter.[UpdatedDate]")]
        public DateTime? RecipeSettingsParameterUpdatedDate
        {
            get
            {
                return MachineRecipeParameterRow.Fields.RecipeSettingsParameterUpdatedDate[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.RecipeSettingsParameterUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return MachineRecipeParameterRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }


        //[ForeignKey("MachineParameter", "MachineParameterId")]
        //[LeftJoin("jMachineParameter")]
        [ForeignKey("ViewField", "MachineParameterId")]
        [LeftJoin("jViewField")]

        public int? MachineParameterId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.MachineParameterId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.MachineParameterId[(Row)this] = value;
            }
        }

        //[DisplayName("MachineParameter Name")]
        //[Expression("jMachineParameter.[ParameterName]")]
        [DisplayName("MachineParameter Name")]
        [Expression("jViewField.[ViewFieldName]")]
        public string MachineParameterName
        {
            get
            {
                return MachineRecipeParameterRow.Fields.MachineParameterName[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.MachineParameterName[(Row)this] = value;
            }
        }

        public string MachineParameterValue
        {
            get
            {
                return MachineRecipeParameterRow.Fields.MachineParameterValue[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.MachineParameterValue[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Birth Date")]
        [Expression("jCreatedBy.[BirthDate]")]
        public DateTime? CreatedByBirthDate
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByBirthDate[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByBirthDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return MachineRecipeParameterRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Birth Date")]
        [Expression("jUpdatedBy.[BirthDate]")]
        public DateTime? UpdatedByBirthDate
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByBirthDate[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByBirthDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return MachineRecipeParameterRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineRecipeParameterRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)MachineRecipeParameterRow.Fields.MachineRecipeParameterId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return MachineRecipeParameterRow.Fields.RecipeParameterValue;
            }
        }

        public MachineRecipeParameterRow()
          : base((RowFieldsBase)MachineRecipeParameterRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field MachineRecipeParameterId;
            public Int32Field MachineRecipeId;
            public StringField MachineRecipeName;
            public Int32Field RecipeSettingsParameterId;
            public StringField RecipeParameterValue;
            public Int32Field StatusId;
            public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;
            public Int32Field RecipeSettingsParameterRecipeSettingsId;
         
            public Int16Field RecipeSettingsParameterIsFetchOnSelfSet;
            public Int32Field RecipeSettingsParameterStatusId;
            public Int32Field RecipeSettingsParameterCreatedBy;
            public DateTimeField RecipeSettingsParameterCreatedDate;
            public Int32Field RecipeSettingsParameterUpdatedBy;
            public DateTimeField RecipeSettingsParameterUpdatedDate;
            public StringField StatusStatusName;
            public StringField MachineParameterValue;
            public Int32Field MachineParameterId;
            public StringField MachineParameterName;
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

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "MachineCustomization.MachineRecipeParameter";
            }
        }
    }
}
