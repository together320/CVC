// Decompiled with JetBrains decompiler
// Type: CVC.ModuleManagement.Entities.ViewFieldRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.ModuleManagement.Entities
{
    [ConnectionKey("Default")]
    [TableName("ViewField")]
    [DisplayName("View Field")]
    [InstanceName("View Field")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("ModuleManagement:ViewField:Read")]
    [ModifyPermission("ModuleManagement:ViewField:Modify")]
    [LookupScript("ModuleManagement.ViewField", Permission = "Lookup")]
    public sealed class ViewFieldRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly ViewFieldRow.RowFields Fields = new ViewFieldRow.RowFields().Init<ViewFieldRow.RowFields>();

        [DisplayName("View Field")]
        [Identity]
        public int? ViewField
        {
            get
            {
                return ViewFieldRow.Fields.ViewField[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.ViewField[(Row)this] = value;
            }
        }

        [DisplayName("Views")]
        [ForeignKey("Views", "ViewsId")]
        [LeftJoin("jViews")]
        [TextualField("ViewsViewName")]
        public int? ViewsId
        {
            get
            {
                return ViewFieldRow.Fields.ViewsId[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.ViewsId[(Row)this] = value;
            }
        }

        [DisplayName("View Field Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string ViewFieldName
        {
            get
            {
                return ViewFieldRow.Fields.ViewFieldName[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.ViewFieldName[(Row)this] = value;
            }
        }

        [DisplayName("Machine Parameter")]
        [Column("MachineParameterId")]
        [ForeignKey("MachineParameter", "MachineParameterId")]
        [LeftJoin("jMachineParameter")]
        [TextualField("MachineParameterMachineParameterName")]
        public int? MachineParameterId
        {
            get
            {
                return ViewFieldRow.Fields.MachineParameterId[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.MachineParameterId[(Row)this] = value;
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
                return ViewFieldRow.Fields.StatusId[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.StatusId[(Row)this] = value;
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
                return ViewFieldRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return ViewFieldRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedDate[(Row)this] = value;
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
                return ViewFieldRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Views Module Id")]
        [Expression("jViews.[ModuleId]")]
        public int? ViewsModuleId
        {
            get
            {
                return ViewFieldRow.Fields.ViewsModuleId[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.ViewsModuleId[(Row)this] = value;
            }
        }

        [DisplayName("Views View Name")]
        [Expression("jViews.[ViewName]")]
        public string ViewsViewName
        {
            get
            {
                return ViewFieldRow.Fields.ViewsViewName[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.ViewsViewName[(Row)this] = value;
            }
        }

        [DisplayName("Views Is Access Field Wise")]
        [Expression("jViews.[IsAccessFieldWise]")]
        public short? ViewsIsAccessFieldWise
        {
            get
            {
                return ViewFieldRow.Fields.ViewsIsAccessFieldWise[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.ViewsIsAccessFieldWise[(Row)this] = value;
            }
        }

        [DisplayName("Views Status Id")]
        [Expression("jViews.[StatusId]")]
        public int? ViewsStatusId
        {
            get
            {
                return ViewFieldRow.Fields.ViewsStatusId[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.ViewsStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Views Created By")]
        [Expression("jViews.[CreatedBy]")]
        public int? ViewsCreatedBy
        {
            get
            {
                return ViewFieldRow.Fields.ViewsCreatedBy[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.ViewsCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Views Created Date")]
        [Expression("jViews.[CreatedDate]")]
        public DateTime? ViewsCreatedDate
        {
            get
            {
                return ViewFieldRow.Fields.ViewsCreatedDate[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.ViewsCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Views Updated By")]
        [Expression("jViews.[UpdatedBy]")]
        public int? ViewsUpdatedBy
        {
            get
            {
                return ViewFieldRow.Fields.ViewsUpdatedBy[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.ViewsUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Views Updated Date")]
        [Expression("jViews.[UpdatedDate]")]
        public DateTime? ViewsUpdatedDate
        {
            get
            {
                return ViewFieldRow.Fields.ViewsUpdatedDate[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.ViewsUpdatedDate[(Row)this] = value;
            }
        }


        public int? Sequence
        {
            get
            {
                return ViewFieldRow.Fields.Sequence[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.Sequence[(Row)this] = value;
            }
        }



        [DisplayName("Machine Parameter")]
        [Expression("jMachineParameter.[ParameterName]")]
        public string MachineParameterMachineParameterName
        {
            get
            {
                return ViewFieldRow.Fields.MachineParameterMachineParameterName[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.MachineParameterMachineParameterName[(Row)this] = value;
            }
        }







        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return ViewFieldRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Birth Date")]
        [Expression("jCreatedBy.[BirthDate]")]
        public DateTime? CreatedByBirthDate
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByBirthDate[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByBirthDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return ViewFieldRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return ViewFieldRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Birth Date")]
        [Expression("jUpdatedBy.[BirthDate]")]
        public DateTime? UpdatedByBirthDate
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByBirthDate[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByBirthDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return ViewFieldRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                ViewFieldRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)ViewFieldRow.Fields.ViewField;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return ViewFieldRow.Fields.ViewFieldName;
            }
        }

        public ViewFieldRow()
          : base((RowFieldsBase)ViewFieldRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ViewField;
            public Int32Field ViewsId;
            public StringField ViewFieldName;
            public Int32Field MachineParameterId;
            public Int32Field StatusId;
            public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;
            public Int32Field ViewsModuleId;
            public StringField ViewsViewName;
            public Int16Field ViewsIsAccessFieldWise;
            public Int32Field ViewsStatusId;
            public Int32Field ViewsCreatedBy;
            public DateTimeField ViewsCreatedDate;
            public Int32Field ViewsUpdatedBy;
            public DateTimeField ViewsUpdatedDate;

            public Int32Field Sequence;
            public StringField MachineParameterMachineParameterName;


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

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "ModuleManagement.ViewField";
            }
        }
    }
}
