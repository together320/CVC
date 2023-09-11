// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Entities.LabelLostRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.Batch.Entities
{
    [ConnectionKey("Default")]
    [TableName("LabelLost")]
    [DisplayName("Label Lost")]
    [InstanceName("Label Lost")]
    [TwoLevelCached(new string[] { })]
    //[ReadPermission("Administration:General")]
    //[ModifyPermission("Administration:General")]
    [ReadPermission("")]
    [ModifyPermission("")]

    public sealed class LabelLostRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly LabelLostRow.RowFields Fields = new LabelLostRow.RowFields().Init<LabelLostRow.RowFields>();

        [DisplayName("Label Lost Id")]
        [Identity]
        public int? LabelLostId
        {
            get
            {
                return LabelLostRow.Fields.LabelLostId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.LabelLostId[(Row)this] = value;
            }
        }

        [DisplayName("Label Rec")]
        [ForeignKey("LabelReconciliation", "LabelRecId")]
        [LeftJoin("jLabelRec")]
        public int? LabelRecId
        {
            get
            {
                return LabelLostRow.Fields.LabelRecId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.LabelRecId[(Row)this] = value;
            }
        }

        [DisplayName("Activity")]
        [ForeignKey("PickListValue", "PickListValueId")]
        [LeftJoin("jActivity")]
        [TextualField("ActivityPickListValueName")]
        public int? ActivityId
        {
            get
            {
                return LabelLostRow.Fields.ActivityId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.ActivityId[(Row)this] = value;
            }
        }

        [DisplayName("Activity Text")]
        [Size(100)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string ActivityText
        {
            get
            {
                return LabelLostRow.Fields.ActivityText[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.ActivityText[(Row)this] = value;
            }
        }

        [DisplayName("Number Of Labels")]
        public int? NumberOfLabels
        {
            get
            {
                return LabelLostRow.Fields.NumberOfLabels[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.NumberOfLabels[(Row)this] = value;
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
                return LabelLostRow.Fields.StatusId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.StatusId[(Row)this] = value;
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
                return LabelLostRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return LabelLostRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedDate[(Row)this] = value;
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
                return LabelLostRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return LabelLostRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Label Rec Batch Id")]
        [Expression("jLabelRec.[BatchId]")]
        public int? LabelRecBatchId
        {
            get
            {
                return LabelLostRow.Fields.LabelRecBatchId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.LabelRecBatchId[(Row)this] = value;
            }
        }

        [DisplayName("Label Rec Machine Id")]
        [Expression("jLabelRec.[MachineId]")]
        public int? LabelRecMachineId
        {
            get
            {
                return LabelLostRow.Fields.LabelRecMachineId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.LabelRecMachineId[(Row)this] = value;
            }
        }

        [DisplayName("Label Rec Label Roll Id")]
        [Expression("jLabelRec.[LabelRollId]")]
        public int? LabelRecLabelRollId
        {
            get
            {
                return LabelLostRow.Fields.LabelRecLabelRollId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.LabelRecLabelRollId[(Row)this] = value;
            }
        }

        [DisplayName("Label Rec Rejected Labels")]
        [Expression("jLabelRec.[RejectedLabels]")]
        public int? LabelRecRejectedLabels
        {
            get
            {
                return LabelLostRow.Fields.LabelRecRejectedLabels[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.LabelRecRejectedLabels[(Row)this] = value;
            }
        }

        [DisplayName("Label Rec Label Lost")]
        [Expression("jLabelRec.[LabelLost]")]
        public int? LabelRecLabelLost
        {
            get
            {
                return LabelLostRow.Fields.LabelRecLabelLost[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.LabelRecLabelLost[(Row)this] = value;
            }
        }

        [DisplayName("Label Rec No Label On Roll")]
        [Expression("jLabelRec.[NoLabelOnRoll]")]
        public int? LabelRecNoLabelOnRoll
        {
            get
            {
                return LabelLostRow.Fields.LabelRecNoLabelOnRoll[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.LabelRecNoLabelOnRoll[(Row)this] = value;
            }
        }

        [DisplayName("Label Rec Label Balance")]
        [Expression("jLabelRec.[LabelBalance]")]
        public int? LabelRecLabelBalance
        {
            get
            {
                return LabelLostRow.Fields.LabelRecLabelBalance[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.LabelRecLabelBalance[(Row)this] = value;
            }
        }

        [DisplayName("Label Rec Status Id")]
        [Expression("jLabelRec.[StatusId]")]
        public int? LabelRecStatusId
        {
            get
            {
                return LabelLostRow.Fields.LabelRecStatusId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.LabelRecStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Label Rec Created By")]
        [Expression("jLabelRec.[CreatedBy]")]
        public int? LabelRecCreatedBy
        {
            get
            {
                return LabelLostRow.Fields.LabelRecCreatedBy[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.LabelRecCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Label Rec Created Date")]
        [Expression("jLabelRec.[CreatedDate]")]
        public DateTime? LabelRecCreatedDate
        {
            get
            {
                return LabelLostRow.Fields.LabelRecCreatedDate[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.LabelRecCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Label Rec Updated By")]
        [Expression("jLabelRec.[UpdatedBy]")]
        public int? LabelRecUpdatedBy
        {
            get
            {
                return LabelLostRow.Fields.LabelRecUpdatedBy[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.LabelRecUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Label Rec Updated Date")]
        [Expression("jLabelRec.[UpdatedDate]")]
        public DateTime? LabelRecUpdatedDate
        {
            get
            {
                return LabelLostRow.Fields.LabelRecUpdatedDate[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.LabelRecUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Activity Pick List Id")]
        [Expression("jActivity.[PickListId]")]
        public int? ActivityPickListId
        {
            get
            {
                return LabelLostRow.Fields.ActivityPickListId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.ActivityPickListId[(Row)this] = value;
            }
        }

        [DisplayName("Activity Pick List Value Name")]
        [Expression("jActivity.[PickListValueName]")]
        public string ActivityPickListValueName
        {
            get
            {
                return LabelLostRow.Fields.ActivityPickListValueName[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.ActivityPickListValueName[(Row)this] = value;
            }
        }

        [DisplayName("Activity Status Id")]
        [Expression("jActivity.[StatusId]")]
        public int? ActivityStatusId
        {
            get
            {
                return LabelLostRow.Fields.ActivityStatusId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.ActivityStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Activity Created By")]
        [Expression("jActivity.[CreatedBy]")]
        public int? ActivityCreatedBy
        {
            get
            {
                return LabelLostRow.Fields.ActivityCreatedBy[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.ActivityCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Activity Created Date")]
        [Expression("jActivity.[CreatedDate]")]
        public DateTime? ActivityCreatedDate
        {
            get
            {
                return LabelLostRow.Fields.ActivityCreatedDate[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.ActivityCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Activity Updated By")]
        [Expression("jActivity.[UpdatedBy]")]
        public int? ActivityUpdatedBy
        {
            get
            {
                return LabelLostRow.Fields.ActivityUpdatedBy[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.ActivityUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Activity Updated Date")]
        [Expression("jActivity.[UpdatedDate]")]
        public DateTime? ActivityUpdatedDate
        {
            get
            {
                return LabelLostRow.Fields.ActivityUpdatedDate[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.ActivityUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Status Name")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return LabelLostRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return LabelLostRow.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return LabelLostRow.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return LabelLostRow.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return LabelLostRow.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return LabelLostRow.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return LabelLostRow.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return LabelLostRow.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return LabelLostRow.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return LabelLostRow.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return LabelLostRow.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return LabelLostRow.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return LabelLostRow.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return LabelLostRow.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return LabelLostRow.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return LabelLostRow.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return LabelLostRow.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return LabelLostRow.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return LabelLostRow.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return LabelLostRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return LabelLostRow.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return LabelLostRow.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return LabelLostRow.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return LabelLostRow.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return LabelLostRow.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return LabelLostRow.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return LabelLostRow.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return LabelLostRow.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                LabelLostRow.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)LabelLostRow.Fields.LabelLostId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return LabelLostRow.Fields.ActivityText;
            }
        }

        public LabelLostRow()
          : base((RowFieldsBase)LabelLostRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field LabelLostId;
            public Int32Field LabelRecId;
            public Int32Field ActivityId;
            public StringField ActivityText;
            public Int32Field NumberOfLabels;
            public Int32Field StatusId;
            public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;
            public Int32Field LabelRecBatchId;
            public Int32Field LabelRecMachineId;
            public Int32Field LabelRecLabelRollId;
            public Int32Field LabelRecRejectedLabels;
            public Int32Field LabelRecLabelLost;
            public Int32Field LabelRecNoLabelOnRoll;
            public Int32Field LabelRecLabelBalance;
            public Int32Field LabelRecStatusId;
            public Int32Field LabelRecCreatedBy;
            public DateTimeField LabelRecCreatedDate;
            public Int32Field LabelRecUpdatedBy;
            public DateTimeField LabelRecUpdatedDate;
            public Int32Field ActivityPickListId;
            public StringField ActivityPickListValueName;
            public Int32Field ActivityStatusId;
            public Int32Field ActivityCreatedBy;
            public DateTimeField ActivityCreatedDate;
            public Int32Field ActivityUpdatedBy;
            public DateTimeField ActivityUpdatedDate;
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
                this.LocalTextPrefix = "Batch.LabelLost";
            }
        }
    }
}
