// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Entities.LabelRollRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Modules.Common.BaseClass;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;
using Serenity.ComponentModel;

namespace CVC.Batch.Entities
{
    [ConnectionKey("Default")]
    [TableName("LabelRoll")]
    [DisplayName("Label Roll")]
    [InstanceName("Label Roll")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("?")]
    [ModifyPermission("?")]
    [LookupScript("Batch.LabelRollId", Permission = "Lookup")]
    public sealed class LabelRollRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly LabelRollRow.RowFields Fields = new LabelRollRow.RowFields().Init<LabelRollRow.RowFields>();

        [DisplayName("Label Roll Id")]
        [Identity]
        public int? LabelRollId
        {
            get
            {
                return LabelRollRow.Fields.LabelRollId[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.LabelRollId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Id")]
        public int? BatchId
        {
            get
            {
                return LabelRollRow.Fields.BatchId[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.BatchId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Id")]
        public int? MachineId
        {
            get
            {
                return LabelRollRow.Fields.MachineId[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Label Roll Number")]
        public int? LabelRollNumber
        {
            get
            {
                return LabelRollRow.Fields.LabelRollNumber[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.LabelRollNumber[(Row)this] = value;
            }
        }

        [DisplayName("Labels On Roll")]
        public long? NumberOfLabels
        {
            get
            {
                return LabelRollRow.Fields.NumberOfLabels[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.NumberOfLabels[(Row)this] = value;
            }
        }

        [DisplayName("Labels Used")]
        public long? NumberOfLabelsUsed
        {
            get
            {
                return LabelRollRow.Fields.NumberOfLabelsUsed[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.NumberOfLabelsUsed[(Row)this] = value;
            }
        }

        [DisplayName("Labels Remaining")]
        public long? LabelRemaining
        {
            get
            {
                return LabelRollRow.Fields.LabelRemaining[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.LabelRemaining[(Row)this] = value;
            }
        }

        [DisplayName("Remarks")]
        [Size(100)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string Remark
        {
            get
            {
                return LabelRollRow.Fields.Remark[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.Remark[(Row)this] = value;
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
                return LabelRollRow.Fields.StatusId[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return LabelRollRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return LabelRollRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return LabelRollRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return LabelRollRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return LabelRollRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return LabelRollRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return LabelRollRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return LabelRollRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        public bool? IsApplied
        {
            get
            {
                return LabelRollRow.Fields.IsApplied[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.IsApplied[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return LabelRollRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return LabelRollRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return LabelRollRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return LabelRollRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return LabelRollRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return LabelRollRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return LabelRollRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return LabelRollRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return LabelRollRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return LabelRollRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return LabelRollRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return LabelRollRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return LabelRollRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return LabelRollRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return LabelRollRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return LabelRollRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return LabelRollRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return LabelRollRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return LabelRollRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return LabelRollRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                LabelRollRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)LabelRollRow.Fields.LabelRollId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return LabelRollRow.Fields.Remark;
            }
        }

        public LabelRollRow()
          : base((RowFieldsBase)LabelRollRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field LabelRollId;
            public Int32Field BatchId;
            public Int32Field MachineId;
            public Int32Field LabelRollNumber;
            public Int64Field NumberOfLabels;
            public Int64Field NumberOfLabelsUsed;
            public Int64Field LabelRemaining;
            public StringField Remark;
            public Int32Field StatusId;
            public StringField StatusStatusName;
            public StringField CreatedByEmployeeId;
            public StringField CreatedByFirstName;
            public StringField CreatedByLastName;
            public Int32Field CreatedByDepartmentId;
            public StringField CreatedByDesignation;
            public Int32Field CreatedByMobileCode;
            public Int32Field CreatedByMobileNumber;
            public BooleanField IsApplied;
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
              : base((string)null, (string)null)
            {
                this.LocalTextPrefix = "Batch.LabelRoll";
            }
        }
    }
}
