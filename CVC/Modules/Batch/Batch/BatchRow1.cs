// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Entities.BatchRow1
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
using System.Linq;
using System.Web.Http;

namespace CVC.Batch.Entities
{
    public class PackDisplayNameAttribute1 : DisplayNameAttribute
    {
        public PackDisplayNameAttribute1(string value) : base(GetPackNamefromPicklist(value))
        { }

        private static string GetPackNamefromPicklist(string value)
        {
            string strPack = string.Empty;
            using (CVC.Data.EDMX.CVCEntities cvcEntities = new CVC.Data.EDMX.CVCEntities())
            {
                var PickListId = cvcEntities.PickLists?.FirstOrDefault(pl => pl.PickListName.ToUpper() == "PACK")?.PickListId ?? null;
                if (PickListId != null)
                {
                    strPack = cvcEntities.PickListValues?.FirstOrDefault(pl => pl.PickListId == PickListId)?.PickListValueName ?? "Pack ID";
                }
            }
            return strPack + " " + value;
        }
    }
    [ConnectionKey("Default")]
    [TableName("Batch")]
    [DisplayName("Batch Summary")]
    [InstanceName("Batch")]
    [TwoLevelCached(new string[] { })]
    // [ReadPermission("Batch:Modify")]
    // [ReadPermission("Report:BatchLog:Read")]
    [ReadPermission("")]
  // [ModifyPermission("Report:BatchLog:Read")]
    [LookupScript("Batch1", Permission = "Lookup")]
    public sealed class BatchRow1 : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly BatchRow1.RowFields Fields = new BatchRow1.RowFields().Init<BatchRow1.RowFields>();

        [DisplayName("Batch Id")]
        [Identity]
        public int? BatchId
        {
            get
            {
                return BatchRow1.Fields.BatchId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Number")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
      //  [Unique(CheckBeforeSave = true)]
        public string BatchName
        {
            get
            {
                return BatchRow1.Fields.BatchName[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchName[(Row)this] = value;
            }
        }

        //[DisplayName("Pack Id")]
        //[PackDisplayName("")]
        //[NotNull]
        //public int? PackId
        //{
        //    get
        //    {
        //        return BatchRow1.Fields.PackId[(Row)this];
        //    }
        //    set
        //    {
        //        BatchRow1.Fields.PackId[(Row)this] = value;
        //    }
        //}
        [PackDisplayName("")]
        [NotNull]
        public int? PackId
        {
            get
            {
                return BatchRow1.Fields.PackId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.PackId[(Row)this] = value;
            }
        }


        [DisplayName("Batch Start Date Time")]
        public DateTime? BatchStartDateTime
        {
            get
            {
                return BatchRow1.Fields.BatchStartDateTime[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchStartDateTime[(Row)this] = value;
            }
        }

        [DisplayName("Batch End Date Time")]
        public DateTime? BatchEndDateTime
        {
            get
            {
                return BatchRow1.Fields.BatchEndDateTime[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchEndDateTime[(Row)this] = value;
            }
        }


        [DisplayName("Machine Line Id")]
        public int? MachineLineId
        {
            get
            {
                return BatchRow1.Fields.MachineLineId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.MachineLineId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Status")]
        [NotNull]
        [Size(20)]
        public string BatchStatus
        {
            get
            {
                return BatchRow1.Fields.BatchStatus[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchStatus[(Row)this] = value;
            }
        }

        [DisplayName("Batch Size")]
        [NotNull]
        public int? BatchSize
        {
            get
            {
                return BatchRow1.Fields.BatchSize[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchSize[(Row)this] = value;
            }
        }

        [DisplayName("Batch For")]
        [ForeignKey("PickListValue", "PickListValueId")]
        [LeftJoin("jBatchFor")]
        [TextualField("BatchForPickListValueName")]
       // [NotNull]
        public int? BatchFor
        {
            get
            {
                return BatchRow1.Fields.BatchFor[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchFor[(Row)this] = value;
            }
        }

        [DisplayName("Number Of Bottles")]
        //[NotNull]
        public int? NumberOfBottles
        {
            get
            {
                return BatchRow1.Fields.NumberOfBottles[(Row)this];
            }
            set
            {
                BatchRow1.Fields.NumberOfBottles[(Row)this] = value;
            }
        }
        [DisplayName("Batch Version")]
        [Size(1000)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string BatchVersion
        {
            get
            {
                return BatchRow1.Fields.BatchVersion[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchVersion[(Row)this] = value;
            }
        }
        [DisplayName("Batch Latest Version")]
        [Size(1000)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string BatchLatestVersion
        {
            get
            {
                return BatchRow1.Fields.BatchLatestVersion[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchLatestVersion[(Row)this] = value;
            }
        }
        [DisplayName("ParentId")]
        [Size(1000)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public int? ParentId
        {
            get
            {
                return BatchRow1.Fields.ParentId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.ParentId[(Row)this] = value;
            }
        }

        [DisplayName("Total Good Bottles")]
        public int? TotalGoodBottles
        {
            get
            {
                return BatchRow1.Fields.TotalGoodBottles[(Row)this];
            }
            set
            {
                BatchRow1.Fields.TotalGoodBottles[(Row)this] = value;
            }
        }

        [DisplayName("Total Rejected Bottles")]
        public int? TotalRejectedBottles
        {
            get
            {
                return BatchRow1.Fields.TotalRejectedBottles[(Row)this];
            }
            set
            {
                BatchRow1.Fields.TotalRejectedBottles[(Row)this] = value;
            }
        }

        [DisplayName("Production Speed")]
        [Size(50)]
        public string ProductionSpeed
        {
            get
            {
                return BatchRow1.Fields.ProductionSpeed[(Row)this];
            }
            set
            {
                BatchRow1.Fields.ProductionSpeed[(Row)this] = value;
            }
        }

        [DisplayName("Expiry Date")]
        //[NotNull]
        public DateTime? ExpiryDate
        {
            get
            {
                return BatchRow1.Fields.ExpiryDate[(Row)this];
            }
            set
            {
                BatchRow1.Fields.ExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Status Id")]
        //To make status as default "Active"
        [DefaultValue(1)]
        public int? StatusId
        {
            get
            {
                return BatchRow1.Fields.StatusId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Batch For Pick List Id")]
        [Expression("jBatchFor.[PickListId]")]
        public int? BatchForPickListId
        {
            get
            {
                return BatchRow1.Fields.BatchForPickListId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchForPickListId[(Row)this] = value;
            }
        }

        [DisplayName("Batch For Pick List Value Name")]
        [Expression("jBatchFor.[PickListValueName]")]
        public string BatchForPickListValueName
        {
            get
            {
                return BatchRow1.Fields.BatchForPickListValueName[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchForPickListValueName[(Row)this] = value;
            }
        }

        [DisplayName("Batch For Status Id")]
        [Expression("jBatchFor.[StatusId]")]
        public int? BatchForStatusId
        {
            get
            {
                return BatchRow1.Fields.BatchForStatusId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchForStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Batch For Created By")]
        [Expression("jBatchFor.[CreatedBy]")]
        public int? BatchForCreatedBy
        {
            get
            {
                return BatchRow1.Fields.BatchForCreatedBy[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchForCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Batch For Created Date")]
        [Expression("jBatchFor.[CreatedDate]")]
        public DateTime? BatchForCreatedDate
        {
            get
            {
                return BatchRow1.Fields.BatchForCreatedDate[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchForCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Batch For Updated By")]
        [Expression("jBatchFor.[UpdatedBy]")]
        public int? BatchForUpdatedBy
        {
            get
            {
                return BatchRow1.Fields.BatchForUpdatedBy[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchForUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Batch For Updated Date")]
        [Expression("jBatchFor.[UpdatedDate]")]
        public DateTime? BatchForUpdatedDate
        {
            get
            {
                return BatchRow1.Fields.BatchForUpdatedDate[(Row)this];
            }
            set
            {
                BatchRow1.Fields.BatchForUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Employee Id")]
        [Expression("jCreatedBy.[EmployeeId]")]
        public string CreatedByEmployeeId
        {
            get
            {
                return BatchRow1.Fields.CreatedByEmployeeId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Created By First Name")]
        [Expression("jCreatedBy.[FirstName]")]
        public string CreatedByFirstName
        {
            get
            {
                return BatchRow1.Fields.CreatedByFirstName[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Last Name")]
        [Expression("jCreatedBy.[LastName]")]
        public string CreatedByLastName
        {
            get
            {
                return BatchRow1.Fields.CreatedByLastName[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Created By Department Id")]
        [Expression("jCreatedBy.[DepartmentId]")]
        public int? CreatedByDepartmentId
        {
            get
            {
                return BatchRow1.Fields.CreatedByDepartmentId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Designation")]
        [Expression("jCreatedBy.[Designation]")]
        public string CreatedByDesignation
        {
            get
            {
                return BatchRow1.Fields.CreatedByDesignation[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Code")]
        [Expression("jCreatedBy.[MobileCode]")]
        public int? CreatedByMobileCode
        {
            get
            {
                return BatchRow1.Fields.CreatedByMobileCode[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Mobile Number")]
        [Expression("jCreatedBy.[MobileNumber]")]
        public int? CreatedByMobileNumber
        {
            get
            {
                return BatchRow1.Fields.CreatedByMobileNumber[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Created By Email")]
        [Expression("jCreatedBy.[Email]")]
        public string CreatedByEmail
        {
            get
            {
                return BatchRow1.Fields.CreatedByEmail[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Created By Username")]
        [Expression("jCreatedBy.[Username]")]
        public string CreatedByUsername
        {
            get
            {
                return BatchRow1.Fields.CreatedByUsername[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Hash")]
        [Expression("jCreatedBy.[PasswordHash]")]
        public string CreatedByPasswordHash
        {
            get
            {
                return BatchRow1.Fields.CreatedByPasswordHash[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Salt")]
        [Expression("jCreatedBy.[PasswordSalt]")]
        public string CreatedByPasswordSalt
        {
            get
            {
                return BatchRow1.Fields.CreatedByPasswordSalt[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Created By User Image")]
        [Expression("jCreatedBy.[UserImage]")]
        public string CreatedByUserImage
        {
            get
            {
                return BatchRow1.Fields.CreatedByUserImage[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Created By Address")]
        [Expression("jCreatedBy.[Address]")]
        public string CreatedByAddress
        {
            get
            {
                return BatchRow1.Fields.CreatedByAddress[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Created By City Id")]
        [Expression("jCreatedBy.[CityId]")]
        public int? CreatedByCityId
        {
            get
            {
                return BatchRow1.Fields.CreatedByCityId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Pin Code")]
        [Expression("jCreatedBy.[PinCode]")]
        public string CreatedByPinCode
        {
            get
            {
                return BatchRow1.Fields.CreatedByPinCode[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Created By Role Id")]
        [Expression("jCreatedBy.[RoleId]")]
        public int? CreatedByRoleId
        {
            get
            {
                return BatchRow1.Fields.CreatedByRoleId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Created By Password Expiry Date")]
        [Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get
            {
                return BatchRow1.Fields.CreatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Forgot Password")]
        [Expression("jCreatedBy.[IsForgotPassword]")]
        public short? CreatedByIsForgotPassword
        {
            get
            {
                return BatchRow1.Fields.CreatedByIsForgotPassword[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is Password Change On Login")]
        [Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public bool? CreatedByIsPasswordChangeOnLogin
        {
            get
            {
                return BatchRow1.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Created By Is User Hidden")]
        [Expression("jCreatedBy.[IsUserHidden]")]
        public short? CreatedByIsUserHidden
        {
            get
            {
                return BatchRow1.Fields.CreatedByIsUserHidden[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Created By Status Id")]
        [Expression("jCreatedBy.[StatusId]")]
        public int? CreatedByStatusId
        {
            get
            {
                return BatchRow1.Fields.CreatedByStatusId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        [Expression("jCreatedBy.[CreatedBy]")]
        public int? CreatedBy1
        {
            get
            {
                return BatchRow1.Fields.CreatedBy1[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Created By Created Date")]
        [Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get
            {
                return BatchRow1.Fields.CreatedByCreatedDate[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated By")]
        [Expression("jCreatedBy.[UpdatedBy]")]
        public int? CreatedByUpdatedBy
        {
            get
            {
                return BatchRow1.Fields.CreatedByUpdatedBy[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created By Updated Date")]
        [Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get
            {
                return BatchRow1.Fields.CreatedByUpdatedDate[(Row)this];
            }
            set
            {
                BatchRow1.Fields.CreatedByUpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Employee Id")]
        [Expression("jUpdatedBy.[EmployeeId]")]
        public string UpdatedByEmployeeId
        {
            get
            {
                return BatchRow1.Fields.UpdatedByEmployeeId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByEmployeeId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By First Name")]
        [Expression("jUpdatedBy.[FirstName]")]
        public string UpdatedByFirstName
        {
            get
            {
                return BatchRow1.Fields.UpdatedByFirstName[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByFirstName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Last Name")]
        [Expression("jUpdatedBy.[LastName]")]
        public string UpdatedByLastName
        {
            get
            {
                return BatchRow1.Fields.UpdatedByLastName[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByLastName[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Department Id")]
        [Expression("jUpdatedBy.[DepartmentId]")]
        public int? UpdatedByDepartmentId
        {
            get
            {
                return BatchRow1.Fields.UpdatedByDepartmentId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByDepartmentId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Designation")]
        [Expression("jUpdatedBy.[Designation]")]
        public string UpdatedByDesignation
        {
            get
            {
                return BatchRow1.Fields.UpdatedByDesignation[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByDesignation[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Code")]
        [Expression("jUpdatedBy.[MobileCode]")]
        public int? UpdatedByMobileCode
        {
            get
            {
                return BatchRow1.Fields.UpdatedByMobileCode[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByMobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Mobile Number")]
        [Expression("jUpdatedBy.[MobileNumber]")]
        public int? UpdatedByMobileNumber
        {
            get
            {
                return BatchRow1.Fields.UpdatedByMobileNumber[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByMobileNumber[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Email")]
        [Expression("jUpdatedBy.[Email]")]
        public string UpdatedByEmail
        {
            get
            {
                return BatchRow1.Fields.UpdatedByEmail[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByEmail[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Username")]
        [Expression("jUpdatedBy.[Username]")]
        public string UpdatedByUsername
        {
            get
            {
                return BatchRow1.Fields.UpdatedByUsername[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByUsername[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Hash")]
        [Expression("jUpdatedBy.[PasswordHash]")]
        public string UpdatedByPasswordHash
        {
            get
            {
                return BatchRow1.Fields.UpdatedByPasswordHash[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByPasswordHash[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Salt")]
        [Expression("jUpdatedBy.[PasswordSalt]")]
        public string UpdatedByPasswordSalt
        {
            get
            {
                return BatchRow1.Fields.UpdatedByPasswordSalt[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByPasswordSalt[(Row)this] = value;
            }
        }

        [DisplayName("Updated By User Image")]
        [Expression("jUpdatedBy.[UserImage]")]
        public string UpdatedByUserImage
        {
            get
            {
                return BatchRow1.Fields.UpdatedByUserImage[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByUserImage[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Address")]
        [Expression("jUpdatedBy.[Address]")]
        public string UpdatedByAddress
        {
            get
            {
                return BatchRow1.Fields.UpdatedByAddress[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByAddress[(Row)this] = value;
            }
        }

        [DisplayName("Updated By City Id")]
        [Expression("jUpdatedBy.[CityId]")]
        public int? UpdatedByCityId
        {
            get
            {
                return BatchRow1.Fields.UpdatedByCityId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByCityId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Pin Code")]
        [Expression("jUpdatedBy.[PinCode]")]
        public string UpdatedByPinCode
        {
            get
            {
                return BatchRow1.Fields.UpdatedByPinCode[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByPinCode[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Role Id")]
        [Expression("jUpdatedBy.[RoleId]")]
        public int? UpdatedByRoleId
        {
            get
            {
                return BatchRow1.Fields.UpdatedByRoleId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByRoleId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Password Expiry Date")]
        [Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get
            {
                return BatchRow1.Fields.UpdatedByPasswordExpiryDate[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByPasswordExpiryDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Forgot Password")]
        [Expression("jUpdatedBy.[IsForgotPassword]")]
        public short? UpdatedByIsForgotPassword
        {
            get
            {
                return BatchRow1.Fields.UpdatedByIsForgotPassword[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByIsForgotPassword[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is Password Change On Login")]
        [Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public bool? UpdatedByIsPasswordChangeOnLogin
        {
            get
            {
                return BatchRow1.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByIsPasswordChangeOnLogin[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Is User Hidden")]
        [Expression("jUpdatedBy.[IsUserHidden]")]
        public short? UpdatedByIsUserHidden
        {
            get
            {
                return BatchRow1.Fields.UpdatedByIsUserHidden[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByIsUserHidden[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Status Id")]
        [Expression("jUpdatedBy.[StatusId]")]
        public int? UpdatedByStatusId
        {
            get
            {
                return BatchRow1.Fields.UpdatedByStatusId[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created By")]
        [Expression("jUpdatedBy.[CreatedBy]")]
        public int? UpdatedByCreatedBy
        {
            get
            {
                return BatchRow1.Fields.UpdatedByCreatedBy[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Created Date")]
        [Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get
            {
                return BatchRow1.Fields.UpdatedByCreatedDate[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        [Expression("jUpdatedBy.[UpdatedBy]")]
        public int? UpdatedBy1
        {
            get
            {
                return BatchRow1.Fields.UpdatedBy1[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedBy1[(Row)this] = value;
            }
        }

        [DisplayName("Updated By Updated Date")]
        [Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get
            {
                return BatchRow1.Fields.UpdatedByUpdatedDate[(Row)this];
            }
            set
            {
                BatchRow1.Fields.UpdatedByUpdatedDate[(Row)this] = value;
            }
        }
        [DisplayName("Comments")]
        [Size(1000)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string Comments
        {
            get
            {
                return BatchRow1.Fields.Comments[(Row)this];
            }
            set
            {
                BatchRow1.Fields.Comments[(Row)this] = value;
            }
        }
        [DisplayName("Repack Status")]
        [Size(1000)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string RepackStatus
        {
            get
            {
                return BatchRow1.Fields.RepackStatus[(Row)this];
            }
            set
            {
                BatchRow1.Fields.RepackStatus[(Row)this] = value;
            }
        }



        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)BatchRow1.Fields.BatchId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return BatchRow1.Fields.BatchName;
            }
        }

        public BatchRow1()
          : base((RowFieldsBase)BatchRow1.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field BatchId;
            public StringField BatchName;
            public Int32Field PackId;
            public DateTimeField BatchStartDateTime;
            public DateTimeField BatchEndDateTime;
            public Int32Field MachineLineId;
            public StringField BatchStatus;
            public Int32Field BatchSize;
            public Int32Field BatchFor;
            public Int32Field NumberOfBottles;
            public Int32Field TotalGoodBottles;
            public Int32Field TotalRejectedBottles;
            public StringField ProductionSpeed;
            public DateTimeField ExpiryDate;
            public Int32Field StatusId;
            public Int32Field BatchForPickListId;
            public StringField BatchForPickListValueName;
            public Int32Field BatchForStatusId;
            public Int32Field BatchForCreatedBy;
            public DateTimeField BatchForCreatedDate;
            public Int32Field BatchForUpdatedBy;
            public DateTimeField BatchForUpdatedDate;
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
            public StringField BatchVersion;
            public Int32Field ParentId;
            public StringField BatchLatestVersion;
            public StringField Comments;
            public StringField RepackStatus;
          
            public RowFields()
              : base((string)null, (string)null)
            {
                this.LocalTextPrefix = "Batch.Batch";
            }
        }
    }
}
