// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Entities.MachineLineRow
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
    [TableName("MachineLine")]
    [DisplayName("Machine Line")]
    [InstanceName("Machine Line")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("MachineCustomization:MachineLine:Read")]
    [ModifyPermission("MachineCustomization:MachineLine:Modify")]
    [LookupScript("MachineCustomization.MachineLine", Permission = "Lookup")]
    public sealed class MachineLineRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly MachineLineRow.RowFields Fields = new MachineLineRow.RowFields().Init<MachineLineRow.RowFields>();

        [DisplayName("Machine Line Id")]
        [Identity]
        public int? MachineLineId
        {
            get
            {
                return MachineLineRow.Fields.MachineLineId[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.MachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Line Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string LineName
        {
            get
            {
                return MachineLineRow.Fields.LineName[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.LineName[(Row)this] = value;
            }
        }

        [DisplayName("Line Rated Speed")]
        [Size(50)]
        public string LineRatedSpeed
        {
            get
            {
                return MachineLineRow.Fields.LineRatedSpeed[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.LineRatedSpeed[(Row)this] = value;
            }
        }

        [DisplayName("Number Of Machines")]
        public int? NumberOfMachines
        {
            get
            {
                return MachineLineRow.Fields.NumberOfMachines[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.NumberOfMachines[(Row)this] = value;
            }
        }

        [DisplayName("Installed Date")]
        public DateTime? InstalledDate
        {
            get
            {
                return MachineLineRow.Fields.InstalledDate[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.InstalledDate[(Row)this] = value;
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
                return MachineLineRow.Fields.StatusId[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return MachineLineRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.StatusStatusName[(Row)this] = value;
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
                return MachineLineRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return MachineLineRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedDate[(Row)this] = value;
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
                return MachineLineRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return MachineLineRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return MachineLineRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return MachineLineRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return MachineLineRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return MachineLineRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return MachineLineRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return MachineLineRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return MachineLineRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return MachineLineRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return MachineLineRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return MachineLineRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return MachineLineRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return MachineLineRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return MachineLineRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return MachineLineRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return MachineLineRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return MachineLineRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return MachineLineRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return MachineLineRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineLineRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return MachineLineRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return MachineLineRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return MachineLineRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return MachineLineRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return MachineLineRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return MachineLineRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return MachineLineRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return MachineLineRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                MachineLineRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)MachineLineRow.Fields.MachineLineId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return MachineLineRow.Fields.LineName;
            }
        }

        public MachineLineRow()
          : base((RowFieldsBase)MachineLineRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
       // public class RowFields : RowFieldsBase
        {
            public Int32Field MachineLineId;
            public StringField LineName;
            public StringField LineRatedSpeed;
            public Int32Field NumberOfMachines;
            public DateTimeField InstalledDate;
            public Int32Field StatusId;
            /*public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;*/
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
            public StringField StatusStatusName;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "MachineCustomization.MachineLine";
            }
        }
    }
}
