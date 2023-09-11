
namespace CVC.MachineCustomization.Entities
{
    using CVC.Administration.Entities;
    using CVC.Configuration.Entities;
    using CVC.Modules.Common.BaseClass;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("MachineCustomization"), TableName("[dbo].[ViewField]")]
    [DisplayName("Display Object Field"), InstanceName("Display Object Field")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class DisplayObjectFieldRow : LoggingRow, IIdRow, INameRow, IAuditLog
    {
        [DisplayName("View Field"), Identity]
        public Int32? ViewField
        {
            get { return Fields.ViewField[this]; }
            set { Fields.ViewField[this] = value; }
        }

        [DisplayName("Display Object"), ForeignKey("[dbo].[Views]", "ViewsId"), LeftJoin("jViews"), TextualField("ViewsViewName")]
        //[LookupEditor(typeof(DisplayObjectRow))]
        [DisplayObjectLookupEditor]
        [Required]
        public Int32? ViewsId
        {
            get { return Fields.ViewsId[this]; }
            set { Fields.ViewsId[this] = value; }
        }

        [DisplayName("Display Object Field"), Size(50), QuickSearch]
        [Required]
        public String ViewFieldName
        {
            get { return Fields.ViewFieldName[this]; }
            set { Fields.ViewFieldName[this] = value; }
        }

        [DisplayName("Status"), ForeignKey("[dbo].[Status]", "StatusId"), LeftJoin("jStatus"), TextualField("StatusStatusName")]
        [LookupEditor(typeof(StatusRow))]
        [Required]
        [DefaultValue(1)]
        public Int32? StatusId
        {
            get { return Fields.StatusId[this]; }
            set { Fields.StatusId[this] = value; }
        }

        [DisplayName("Created By"), ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jCreatedBy"), TextualField("CreatedByUsername")]
        public Int32? CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Updated By"), ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jUpdatedBy"), TextualField("UpdatedByUsername")]
        public Int32? UpdatedBy
        {
            get { return Fields.UpdatedBy[this]; }
            set { Fields.UpdatedBy[this] = value; }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get { return Fields.UpdatedDate[this]; }
            set { Fields.UpdatedDate[this] = value; }
        }

        [DisplayName("Sequence")]
        public Int32? Sequence
        {
            get { return Fields.Sequence[this]; }
            set { Fields.Sequence[this] = value; }
        }

        [DisplayName("Entity Field"), ForeignKey("[dbo].[MachineParameter]", "MachineParameterId"), LeftJoin("jMachineParameter"), TextualField("MachineParameterParameterName")]
        [LookupEditor(typeof(MachineParameterRow))]
        [Required]
        public Int32? MachineParameterId
        {
            get { return Fields.MachineParameterId[this]; }
            set { Fields.MachineParameterId[this] = value; }
        }

        [DisplayName("Is PopUp Required")]
        public Boolean? IsPopUpRequired
        {
            get { return Fields.IsPopUpRequired[this]; }
            set { Fields.IsPopUpRequired[this] = value; }
        }

        [DisplayName("Is Comment Required")]
        public Boolean? IsCommentRequired
        {
            get { return Fields.IsCommentRequired[this]; }
            set { Fields.IsCommentRequired[this] = value; }
        }

        [DisplayName("Is Authentication Required")]
        public Boolean? IsAuthenticationRequired
        {
            get { return Fields.IsAuthenticationRequired[this]; }
            set { Fields.IsAuthenticationRequired[this] = value; }
        }

        [DisplayName("Module"), ForeignKey("[dbo].[Module]", "ModuleId"), LeftJoin("jModule"), TextualField("ModuleModuleName")]
        public Int32? ModuleId
        {
            get { return Fields.ModuleId[this]; }
            set { Fields.ModuleId[this] = value; }
        }

        [DisplayName("Roles")]
        [LookupEditor(typeof(RoleRow), Multiple = true), NotMapped]
        [Required]
        public List<Int32> Roles
        {
            get { return Fields.Roles[this]; }
            set { Fields.Roles[this] = value; }
        }

        [DisplayName("Select All Roles"), NotMapped]
        public Boolean? IsSelectAllRoles
        {
            get { return Fields.IsSelectAllRoles[this]; }
            set { Fields.IsSelectAllRoles[this] = value; }
        }

        [DisplayName("Views Module Id"), Expression("jViews.[ModuleId]")]
        public Int32? ViewsModuleId
        {
            get { return Fields.ViewsModuleId[this]; }
            set { Fields.ViewsModuleId[this] = value; }
        }

        [DisplayName("Display Object"), Expression("jViews.[ViewName]")]
        public String ViewsViewName
        {
            get { return Fields.ViewsViewName[this]; }
            set { Fields.ViewsViewName[this] = value; }
        }

        [DisplayName("Views Is Access Field Wise"), Expression("jViews.[IsAccessFieldWise]")]
        public Boolean? ViewsIsAccessFieldWise
        {
            get { return Fields.ViewsIsAccessFieldWise[this]; }
            set { Fields.ViewsIsAccessFieldWise[this] = value; }
        }

        [DisplayName("Views Status Id"), Expression("jViews.[StatusId]")]
        public Int32? ViewsStatusId
        {
            get { return Fields.ViewsStatusId[this]; }
            set { Fields.ViewsStatusId[this] = value; }
        }

        [DisplayName("Views Created By"), Expression("jViews.[CreatedBy]")]
        public Int32? ViewsCreatedBy
        {
            get { return Fields.ViewsCreatedBy[this]; }
            set { Fields.ViewsCreatedBy[this] = value; }
        }

        [DisplayName("Views Created Date"), Expression("jViews.[CreatedDate]")]
        public DateTime? ViewsCreatedDate
        {
            get { return Fields.ViewsCreatedDate[this]; }
            set { Fields.ViewsCreatedDate[this] = value; }
        }

        [DisplayName("Views Updated By"), Expression("jViews.[UpdatedBy]")]
        public Int32? ViewsUpdatedBy
        {
            get { return Fields.ViewsUpdatedBy[this]; }
            set { Fields.ViewsUpdatedBy[this] = value; }
        }

        [DisplayName("Views Updated Date"), Expression("jViews.[UpdatedDate]")]
        public DateTime? ViewsUpdatedDate
        {
            get { return Fields.ViewsUpdatedDate[this]; }
            set { Fields.ViewsUpdatedDate[this] = value; }
        }

        [DisplayName("Views Is Machine Settings"), Expression("jViews.[IsMachineSettings]")]
        public Boolean? ViewsIsMachineSettings
        {
            get { return Fields.ViewsIsMachineSettings[this]; }
            set { Fields.ViewsIsMachineSettings[this] = value; }
        }

        [DisplayName("Views Is Machine Summary"), Expression("jViews.[IsMachineSummary]")]
        public Boolean? ViewsIsMachineSummary
        {
            get { return Fields.ViewsIsMachineSummary[this]; }
            set { Fields.ViewsIsMachineSummary[this] = value; }
        }

        [DisplayName("Views Islabel Roll"), Expression("jViews.[IslabelRoll]")]
        public Boolean? ViewsIslabelRoll
        {
            get { return Fields.ViewsIslabelRoll[this]; }
            set { Fields.ViewsIslabelRoll[this] = value; }
        }

        [DisplayName("Views Is Command Panel"), Expression("jViews.[IsCommandPanel]")]
        public Boolean? ViewsIsCommandPanel
        {
            get { return Fields.ViewsIsCommandPanel[this]; }
            set { Fields.ViewsIsCommandPanel[this] = value; }
        }

        [DisplayName("Views Is Factory Setting"), Expression("jViews.[IsFactorySetting]")]
        public Boolean? ViewsIsFactorySetting
        {
            get { return Fields.ViewsIsFactorySetting[this]; }
            set { Fields.ViewsIsFactorySetting[this] = value; }
        }

        [DisplayName("Views Display Object Type Id"), Expression("jViews.[DisplayObjectTypeId]")]
        public Int32? ViewsDisplayObjectTypeId
        {
            get { return Fields.ViewsDisplayObjectTypeId[this]; }
            set { Fields.ViewsDisplayObjectTypeId[this] = value; }
        }

        [DisplayName("Business Entity"), ForeignKey("[dbo].[Machine]", "MachineId"), LeftJoin("jMachine"), TextualField("MachineName"), Expression("jViews.[MachineId]")]
        public Int32? ViewsMachineId
        {
            get { return Fields.ViewsMachineId[this]; }
            set { Fields.ViewsMachineId[this] = value; }
        }

        [DisplayName("Business Entity"), Expression("jMachine.[MachineName]")]
        public String MachineName
        {
            get { return Fields.MachineName[this]; }
            set { Fields.MachineName[this] = value; }
        }

        [DisplayName("Views List Display Id"), Expression("jViews.[ListDisplayId]")]
        public Int32? ViewsListDisplayId
        {
            get { return Fields.ViewsListDisplayId[this]; }
            set { Fields.ViewsListDisplayId[this] = value; }
        }

        [DisplayName("Views Form Display Id"), Expression("jViews.[FormDisplayId]")]
        public Int32? ViewsFormDisplayId
        {
            get { return Fields.ViewsFormDisplayId[this]; }
            set { Fields.ViewsFormDisplayId[this] = value; }
        }

        [DisplayName("Views Button Display Id"), Expression("jViews.[ButtonDisplayId]")]
        public Int32? ViewsButtonDisplayId
        {
            get { return Fields.ViewsButtonDisplayId[this]; }
            set { Fields.ViewsButtonDisplayId[this] = value; }
        }

        [DisplayName("Views Realtime Parameter Display Id"), Expression("jViews.[RealtimeParameterDisplayId]")]
        public Int32? ViewsRealtimeParameterDisplayId
        {
            get { return Fields.ViewsRealtimeParameterDisplayId[this]; }
            set { Fields.ViewsRealtimeParameterDisplayId[this] = value; }
        }

        [DisplayName("Views Line Chart Display Id"), Expression("jViews.[LineChartDisplayId]")]
        public Int32? ViewsLineChartDisplayId
        {
            get { return Fields.ViewsLineChartDisplayId[this]; }
            set { Fields.ViewsLineChartDisplayId[this] = value; }
        }

        [DisplayName("Views Pie Chart Display Id"), Expression("jViews.[PieChartDisplayId]")]
        public Int32? ViewsPieChartDisplayId
        {
            get { return Fields.ViewsPieChartDisplayId[this]; }
            set { Fields.ViewsPieChartDisplayId[this] = value; }
        }

        [DisplayName("Views Tree Display Id"), Expression("jViews.[TreeDisplayId]")]
        public Int32? ViewsTreeDisplayId
        {
            get { return Fields.ViewsTreeDisplayId[this]; }
            set { Fields.ViewsTreeDisplayId[this] = value; }
        }

        [DisplayName("Views Attachment Display Id"), Expression("jViews.[AttachmentDisplayId]")]
        public Int32? ViewsAttachmentDisplayId
        {
            get { return Fields.ViewsAttachmentDisplayId[this]; }
            set { Fields.ViewsAttachmentDisplayId[this] = value; }
        }

        [DisplayName("Views Alarm Display Id"), Expression("jViews.[AlarmDisplayId]")]
        public Int32? ViewsAlarmDisplayId
        {
            get { return Fields.ViewsAlarmDisplayId[this]; }
            set { Fields.ViewsAlarmDisplayId[this] = value; }
        }

        [DisplayName("Views Notification Display Id"), Expression("jViews.[NotificationDisplayId]")]
        public Int32? ViewsNotificationDisplayId
        {
            get { return Fields.ViewsNotificationDisplayId[this]; }
            set { Fields.ViewsNotificationDisplayId[this] = value; }
        }

        [DisplayName("Views Container Display Id"), Expression("jViews.[ContainerDisplayId]")]
        public Int32? ViewsContainerDisplayId
        {
            get { return Fields.ViewsContainerDisplayId[this]; }
            set { Fields.ViewsContainerDisplayId[this] = value; }
        }

        [DisplayName("Status"), Expression("jStatus.[StatusName]")]
        public String StatusStatusName
        {
            get { return Fields.StatusStatusName[this]; }
            set { Fields.StatusStatusName[this] = value; }
        }

        [DisplayName("Created By"), Expression("jCreatedBy.[EmployeeId]")]
        public String CreatedByEmployeeId
        {
            get { return Fields.CreatedByEmployeeId[this]; }
            set { Fields.CreatedByEmployeeId[this] = value; }
        }

        [DisplayName("Created By First Name"), Expression("jCreatedBy.[FirstName]")]
        public String CreatedByFirstName
        {
            get { return Fields.CreatedByFirstName[this]; }
            set { Fields.CreatedByFirstName[this] = value; }
        }

        [DisplayName("Created By Last Name"), Expression("jCreatedBy.[LastName]")]
        public String CreatedByLastName
        {
            get { return Fields.CreatedByLastName[this]; }
            set { Fields.CreatedByLastName[this] = value; }
        }

        [DisplayName("Created By Department Id"), Expression("jCreatedBy.[DepartmentId]")]
        public Int32? CreatedByDepartmentId
        {
            get { return Fields.CreatedByDepartmentId[this]; }
            set { Fields.CreatedByDepartmentId[this] = value; }
        }

        [DisplayName("Created By Designation"), Expression("jCreatedBy.[Designation]")]
        public String CreatedByDesignation
        {
            get { return Fields.CreatedByDesignation[this]; }
            set { Fields.CreatedByDesignation[this] = value; }
        }

        [DisplayName("Created By Mobile Code"), Expression("jCreatedBy.[MobileCode]")]
        public Int32? CreatedByMobileCode
        {
            get { return Fields.CreatedByMobileCode[this]; }
            set { Fields.CreatedByMobileCode[this] = value; }
        }

        [DisplayName("Created By Mobile Number"), Expression("jCreatedBy.[MobileNumber]")]
        public Int64? CreatedByMobileNumber
        {
            get { return Fields.CreatedByMobileNumber[this]; }
            set { Fields.CreatedByMobileNumber[this] = value; }
        }

        [DisplayName("Created By Email"), Expression("jCreatedBy.[Email]")]
        public String CreatedByEmail
        {
            get { return Fields.CreatedByEmail[this]; }
            set { Fields.CreatedByEmail[this] = value; }
        }

        [DisplayName("Created By"), Expression("jCreatedBy.[Username]")]
        public String CreatedByUsername
        {
            get { return Fields.CreatedByUsername[this]; }
            set { Fields.CreatedByUsername[this] = value; }
        }

        [DisplayName("Created By Password Hash"), Expression("jCreatedBy.[PasswordHash]")]
        public String CreatedByPasswordHash
        {
            get { return Fields.CreatedByPasswordHash[this]; }
            set { Fields.CreatedByPasswordHash[this] = value; }
        }

        [DisplayName("Created By Password Salt"), Expression("jCreatedBy.[PasswordSalt]")]
        public String CreatedByPasswordSalt
        {
            get { return Fields.CreatedByPasswordSalt[this]; }
            set { Fields.CreatedByPasswordSalt[this] = value; }
        }

        [DisplayName("Created By User Image"), Expression("jCreatedBy.[UserImage]")]
        public String CreatedByUserImage
        {
            get { return Fields.CreatedByUserImage[this]; }
            set { Fields.CreatedByUserImage[this] = value; }
        }

        [DisplayName("Created By Address"), Expression("jCreatedBy.[Address]")]
        public String CreatedByAddress
        {
            get { return Fields.CreatedByAddress[this]; }
            set { Fields.CreatedByAddress[this] = value; }
        }

        [DisplayName("Created By City Id"), Expression("jCreatedBy.[CityId]")]
        public Int32? CreatedByCityId
        {
            get { return Fields.CreatedByCityId[this]; }
            set { Fields.CreatedByCityId[this] = value; }
        }

        [DisplayName("Created By Pin Code"), Expression("jCreatedBy.[PinCode]")]
        public String CreatedByPinCode
        {
            get { return Fields.CreatedByPinCode[this]; }
            set { Fields.CreatedByPinCode[this] = value; }
        }

        [DisplayName("Created By Role Id"), Expression("jCreatedBy.[RoleId]")]
        public Int32? CreatedByRoleId
        {
            get { return Fields.CreatedByRoleId[this]; }
            set { Fields.CreatedByRoleId[this] = value; }
        }

        [DisplayName("Created By Password Expiry Date"), Expression("jCreatedBy.[PasswordExpiryDate]")]
        public DateTime? CreatedByPasswordExpiryDate
        {
            get { return Fields.CreatedByPasswordExpiryDate[this]; }
            set { Fields.CreatedByPasswordExpiryDate[this] = value; }
        }

        [DisplayName("Created By Is Forgot Password"), Expression("jCreatedBy.[IsForgotPassword]")]
        public Boolean? CreatedByIsForgotPassword
        {
            get { return Fields.CreatedByIsForgotPassword[this]; }
            set { Fields.CreatedByIsForgotPassword[this] = value; }
        }

        [DisplayName("Created By Is Password Change On Login"), Expression("jCreatedBy.[IsPasswordChangeOnLogin]")]
        public Boolean? CreatedByIsPasswordChangeOnLogin
        {
            get { return Fields.CreatedByIsPasswordChangeOnLogin[this]; }
            set { Fields.CreatedByIsPasswordChangeOnLogin[this] = value; }
        }

        [DisplayName("Created By Is User Hidden"), Expression("jCreatedBy.[IsUserHidden]")]
        public Boolean? CreatedByIsUserHidden
        {
            get { return Fields.CreatedByIsUserHidden[this]; }
            set { Fields.CreatedByIsUserHidden[this] = value; }
        }

        [DisplayName("Created By Birth Date"), Expression("jCreatedBy.[BirthDate]")]
        public DateTime? CreatedByBirthDate
        {
            get { return Fields.CreatedByBirthDate[this]; }
            set { Fields.CreatedByBirthDate[this] = value; }
        }

        [DisplayName("Created By Status Id"), Expression("jCreatedBy.[StatusId]")]
        public Int32? CreatedByStatusId
        {
            get { return Fields.CreatedByStatusId[this]; }
            set { Fields.CreatedByStatusId[this] = value; }
        }

        [DisplayName("Created By"), Expression("jCreatedBy.[CreatedBy]")]
        public Int32? CreatedBy1
        {
            get { return Fields.CreatedBy1[this]; }
            set { Fields.CreatedBy1[this] = value; }
        }

        [DisplayName("Created By Created Date"), Expression("jCreatedBy.[CreatedDate]")]
        public DateTime? CreatedByCreatedDate
        {
            get { return Fields.CreatedByCreatedDate[this]; }
            set { Fields.CreatedByCreatedDate[this] = value; }
        }

        [DisplayName("Created By Updated By"), Expression("jCreatedBy.[UpdatedBy]")]
        public Int32? CreatedByUpdatedBy
        {
            get { return Fields.CreatedByUpdatedBy[this]; }
            set { Fields.CreatedByUpdatedBy[this] = value; }
        }

        [DisplayName("Created By Updated Date"), Expression("jCreatedBy.[UpdatedDate]")]
        public DateTime? CreatedByUpdatedDate
        {
            get { return Fields.CreatedByUpdatedDate[this]; }
            set { Fields.CreatedByUpdatedDate[this] = value; }
        }

        [DisplayName("Created By Question Id"), Expression("jCreatedBy.[QuestionId]")]
        public Int32? CreatedByQuestionId
        {
            get { return Fields.CreatedByQuestionId[this]; }
            set { Fields.CreatedByQuestionId[this] = value; }
        }

        [DisplayName("Created By Question Ans"), Expression("jCreatedBy.[QuestionAns]")]
        public String CreatedByQuestionAns
        {
            get { return Fields.CreatedByQuestionAns[this]; }
            set { Fields.CreatedByQuestionAns[this] = value; }
        }

        [DisplayName("Created By Is Lock Out"), Expression("jCreatedBy.[IsLockOut]")]
        public Boolean? CreatedByIsLockOut
        {
            get { return Fields.CreatedByIsLockOut[this]; }
            set { Fields.CreatedByIsLockOut[this] = value; }
        }

        [DisplayName("Created By Lock Out Date Time"), Expression("jCreatedBy.[LockOutDateTime]")]
        public DateTime? CreatedByLockOutDateTime
        {
            get { return Fields.CreatedByLockOutDateTime[this]; }
            set { Fields.CreatedByLockOutDateTime[this] = value; }
        }

        [DisplayName("Created By Log In Attempt"), Expression("jCreatedBy.[LogInAttempt]")]
        public Int32? CreatedByLogInAttempt
        {
            get { return Fields.CreatedByLogInAttempt[this]; }
            set { Fields.CreatedByLogInAttempt[this] = value; }
        }

        [DisplayName("Created By Is Active Directory"), Expression("jCreatedBy.[IsActiveDirectory]")]
        public Boolean? CreatedByIsActiveDirectory
        {
            get { return Fields.CreatedByIsActiveDirectory[this]; }
            set { Fields.CreatedByIsActiveDirectory[this] = value; }
        }

        [DisplayName("Created By Machine Id"), Expression("jCreatedBy.[MachineId]")]
        public String CreatedByMachineId
        {
            get { return Fields.CreatedByMachineId[this]; }
            set { Fields.CreatedByMachineId[this] = value; }
        }

        [DisplayName("Created By Record Added Source"), Expression("jCreatedBy.[RecordAddedSource]")]
        public String CreatedByRecordAddedSource
        {
            get { return Fields.CreatedByRecordAddedSource[this]; }
            set { Fields.CreatedByRecordAddedSource[this] = value; }
        }

        [DisplayName("Updated By"), Expression("jUpdatedBy.[EmployeeId]")]
        public String UpdatedByEmployeeId
        {
            get { return Fields.UpdatedByEmployeeId[this]; }
            set { Fields.UpdatedByEmployeeId[this] = value; }
        }

        [DisplayName("Updated By First Name"), Expression("jUpdatedBy.[FirstName]")]
        public String UpdatedByFirstName
        {
            get { return Fields.UpdatedByFirstName[this]; }
            set { Fields.UpdatedByFirstName[this] = value; }
        }

        [DisplayName("Updated By Last Name"), Expression("jUpdatedBy.[LastName]")]
        public String UpdatedByLastName
        {
            get { return Fields.UpdatedByLastName[this]; }
            set { Fields.UpdatedByLastName[this] = value; }
        }

        [DisplayName("Updated By Department Id"), Expression("jUpdatedBy.[DepartmentId]")]
        public Int32? UpdatedByDepartmentId
        {
            get { return Fields.UpdatedByDepartmentId[this]; }
            set { Fields.UpdatedByDepartmentId[this] = value; }
        }

        [DisplayName("Updated By Designation"), Expression("jUpdatedBy.[Designation]")]
        public String UpdatedByDesignation
        {
            get { return Fields.UpdatedByDesignation[this]; }
            set { Fields.UpdatedByDesignation[this] = value; }
        }

        [DisplayName("Updated By Mobile Code"), Expression("jUpdatedBy.[MobileCode]")]
        public Int32? UpdatedByMobileCode
        {
            get { return Fields.UpdatedByMobileCode[this]; }
            set { Fields.UpdatedByMobileCode[this] = value; }
        }

        [DisplayName("Updated By Mobile Number"), Expression("jUpdatedBy.[MobileNumber]")]
        public Int64? UpdatedByMobileNumber
        {
            get { return Fields.UpdatedByMobileNumber[this]; }
            set { Fields.UpdatedByMobileNumber[this] = value; }
        }

        [DisplayName("Updated By Email"), Expression("jUpdatedBy.[Email]")]
        public String UpdatedByEmail
        {
            get { return Fields.UpdatedByEmail[this]; }
            set { Fields.UpdatedByEmail[this] = value; }
        }

        [DisplayName("Updated By"), Expression("jUpdatedBy.[Username]")]
        public String UpdatedByUsername
        {
            get { return Fields.UpdatedByUsername[this]; }
            set { Fields.UpdatedByUsername[this] = value; }
        }

        [DisplayName("Updated By Password Hash"), Expression("jUpdatedBy.[PasswordHash]")]
        public String UpdatedByPasswordHash
        {
            get { return Fields.UpdatedByPasswordHash[this]; }
            set { Fields.UpdatedByPasswordHash[this] = value; }
        }

        [DisplayName("Updated By Password Salt"), Expression("jUpdatedBy.[PasswordSalt]")]
        public String UpdatedByPasswordSalt
        {
            get { return Fields.UpdatedByPasswordSalt[this]; }
            set { Fields.UpdatedByPasswordSalt[this] = value; }
        }

        [DisplayName("Updated By User Image"), Expression("jUpdatedBy.[UserImage]")]
        public String UpdatedByUserImage
        {
            get { return Fields.UpdatedByUserImage[this]; }
            set { Fields.UpdatedByUserImage[this] = value; }
        }

        [DisplayName("Updated By Address"), Expression("jUpdatedBy.[Address]")]
        public String UpdatedByAddress
        {
            get { return Fields.UpdatedByAddress[this]; }
            set { Fields.UpdatedByAddress[this] = value; }
        }

        [DisplayName("Updated By City Id"), Expression("jUpdatedBy.[CityId]")]
        public Int32? UpdatedByCityId
        {
            get { return Fields.UpdatedByCityId[this]; }
            set { Fields.UpdatedByCityId[this] = value; }
        }

        [DisplayName("Updated By Pin Code"), Expression("jUpdatedBy.[PinCode]")]
        public String UpdatedByPinCode
        {
            get { return Fields.UpdatedByPinCode[this]; }
            set { Fields.UpdatedByPinCode[this] = value; }
        }

        [DisplayName("Updated By Role Id"), Expression("jUpdatedBy.[RoleId]")]
        public Int32? UpdatedByRoleId
        {
            get { return Fields.UpdatedByRoleId[this]; }
            set { Fields.UpdatedByRoleId[this] = value; }
        }

        [DisplayName("Updated By Password Expiry Date"), Expression("jUpdatedBy.[PasswordExpiryDate]")]
        public DateTime? UpdatedByPasswordExpiryDate
        {
            get { return Fields.UpdatedByPasswordExpiryDate[this]; }
            set { Fields.UpdatedByPasswordExpiryDate[this] = value; }
        }

        [DisplayName("Updated By Is Forgot Password"), Expression("jUpdatedBy.[IsForgotPassword]")]
        public Boolean? UpdatedByIsForgotPassword
        {
            get { return Fields.UpdatedByIsForgotPassword[this]; }
            set { Fields.UpdatedByIsForgotPassword[this] = value; }
        }

        [DisplayName("Updated By Is Password Change On Login"), Expression("jUpdatedBy.[IsPasswordChangeOnLogin]")]
        public Boolean? UpdatedByIsPasswordChangeOnLogin
        {
            get { return Fields.UpdatedByIsPasswordChangeOnLogin[this]; }
            set { Fields.UpdatedByIsPasswordChangeOnLogin[this] = value; }
        }

        [DisplayName("Updated By Is User Hidden"), Expression("jUpdatedBy.[IsUserHidden]")]
        public Boolean? UpdatedByIsUserHidden
        {
            get { return Fields.UpdatedByIsUserHidden[this]; }
            set { Fields.UpdatedByIsUserHidden[this] = value; }
        }

        [DisplayName("Updated By Birth Date"), Expression("jUpdatedBy.[BirthDate]")]
        public DateTime? UpdatedByBirthDate
        {
            get { return Fields.UpdatedByBirthDate[this]; }
            set { Fields.UpdatedByBirthDate[this] = value; }
        }

        [DisplayName("Updated By Status Id"), Expression("jUpdatedBy.[StatusId]")]
        public Int32? UpdatedByStatusId
        {
            get { return Fields.UpdatedByStatusId[this]; }
            set { Fields.UpdatedByStatusId[this] = value; }
        }

        [DisplayName("Updated By Created By"), Expression("jUpdatedBy.[CreatedBy]")]
        public Int32? UpdatedByCreatedBy
        {
            get { return Fields.UpdatedByCreatedBy[this]; }
            set { Fields.UpdatedByCreatedBy[this] = value; }
        }

        [DisplayName("Updated By Created Date"), Expression("jUpdatedBy.[CreatedDate]")]
        public DateTime? UpdatedByCreatedDate
        {
            get { return Fields.UpdatedByCreatedDate[this]; }
            set { Fields.UpdatedByCreatedDate[this] = value; }
        }

        [DisplayName("Updated By"), Expression("jUpdatedBy.[UpdatedBy]")]
        public Int32? UpdatedBy1
        {
            get { return Fields.UpdatedBy1[this]; }
            set { Fields.UpdatedBy1[this] = value; }
        }

        [DisplayName("Updated By Updated Date"), Expression("jUpdatedBy.[UpdatedDate]")]
        public DateTime? UpdatedByUpdatedDate
        {
            get { return Fields.UpdatedByUpdatedDate[this]; }
            set { Fields.UpdatedByUpdatedDate[this] = value; }
        }

        [DisplayName("Updated By Question Id"), Expression("jUpdatedBy.[QuestionId]")]
        public Int32? UpdatedByQuestionId
        {
            get { return Fields.UpdatedByQuestionId[this]; }
            set { Fields.UpdatedByQuestionId[this] = value; }
        }

        [DisplayName("Updated By Question Ans"), Expression("jUpdatedBy.[QuestionAns]")]
        public String UpdatedByQuestionAns
        {
            get { return Fields.UpdatedByQuestionAns[this]; }
            set { Fields.UpdatedByQuestionAns[this] = value; }
        }

        [DisplayName("Updated By Is Lock Out"), Expression("jUpdatedBy.[IsLockOut]")]
        public Boolean? UpdatedByIsLockOut
        {
            get { return Fields.UpdatedByIsLockOut[this]; }
            set { Fields.UpdatedByIsLockOut[this] = value; }
        }

        [DisplayName("Updated By Lock Out Date Time"), Expression("jUpdatedBy.[LockOutDateTime]")]
        public DateTime? UpdatedByLockOutDateTime
        {
            get { return Fields.UpdatedByLockOutDateTime[this]; }
            set { Fields.UpdatedByLockOutDateTime[this] = value; }
        }

        [DisplayName("Updated By Log In Attempt"), Expression("jUpdatedBy.[LogInAttempt]")]
        public Int32? UpdatedByLogInAttempt
        {
            get { return Fields.UpdatedByLogInAttempt[this]; }
            set { Fields.UpdatedByLogInAttempt[this] = value; }
        }

        [DisplayName("Updated By Is Active Directory"), Expression("jUpdatedBy.[IsActiveDirectory]")]
        public Boolean? UpdatedByIsActiveDirectory
        {
            get { return Fields.UpdatedByIsActiveDirectory[this]; }
            set { Fields.UpdatedByIsActiveDirectory[this] = value; }
        }

        [DisplayName("Updated By Machine Id"), Expression("jUpdatedBy.[MachineId]")]
        public String UpdatedByMachineId
        {
            get { return Fields.UpdatedByMachineId[this]; }
            set { Fields.UpdatedByMachineId[this] = value; }
        }

        [DisplayName("Updated By Record Added Source"), Expression("jUpdatedBy.[RecordAddedSource]")]
        public String UpdatedByRecordAddedSource
        {
            get { return Fields.UpdatedByRecordAddedSource[this]; }
            set { Fields.UpdatedByRecordAddedSource[this] = value; }
        }

        [DisplayName("Machine Parameter Machine Id"), Expression("jMachineParameter.[MachineId]")]
        public Int32? MachineParameterMachineId
        {
            get { return Fields.MachineParameterMachineId[this]; }
            set { Fields.MachineParameterMachineId[this] = value; }
        }

        [DisplayName("Entity Field"), Expression("jMachineParameter.[ParameterName]")]
        public String MachineParameterParameterName
        {
            get { return Fields.MachineParameterParameterName[this]; }
            set { Fields.MachineParameterParameterName[this] = value; }
        }

        [DisplayName("Machine Parameter Plc Address"), Expression("jMachineParameter.[PLCAddress]")]
        public String MachineParameterPlcAddress
        {
            get { return Fields.MachineParameterPlcAddress[this]; }
            set { Fields.MachineParameterPlcAddress[this] = value; }
        }

        [DisplayName("Machine Parameter Description"), Expression("jMachineParameter.[Description]")]
        public String MachineParameterDescription
        {
            get { return Fields.MachineParameterDescription[this]; }
            set { Fields.MachineParameterDescription[this] = value; }
        }

        [DisplayName("Machine Parameter Data Type Id"), Expression("jMachineParameter.[DataTypeId]")]
        public Int32? MachineParameterDataTypeId
        {
            get { return Fields.MachineParameterDataTypeId[this]; }
            set { Fields.MachineParameterDataTypeId[this] = value; }
        }

        [DisplayName("Machine Parameter Is Range Unlimited"), Expression("jMachineParameter.[IsRangeUnlimited]")]
        public Boolean? MachineParameterIsRangeUnlimited
        {
            get { return Fields.MachineParameterIsRangeUnlimited[this]; }
            set { Fields.MachineParameterIsRangeUnlimited[this] = value; }
        }

        [DisplayName("Machine Parameter Min"), Expression("jMachineParameter.[Min]")]
        public Decimal? MachineParameterMin
        {
            get { return Fields.MachineParameterMin[this]; }
            set { Fields.MachineParameterMin[this] = value; }
        }

        [DisplayName("Machine Parameter Max"), Expression("jMachineParameter.[Max]")]
        public Decimal? MachineParameterMax
        {
            get { return Fields.MachineParameterMax[this]; }
            set { Fields.MachineParameterMax[this] = value; }
        }

        [DisplayName("Machine Parameter Is Use Unit"), Expression("jMachineParameter.[IsUseUnit]")]
        public Boolean? MachineParameterIsUseUnit
        {
            get { return Fields.MachineParameterIsUseUnit[this]; }
            set { Fields.MachineParameterIsUseUnit[this] = value; }
        }

        [DisplayName("Machine Parameter Unit Id"), Expression("jMachineParameter.[UnitId]")]
        public Int32? MachineParameterUnitId
        {
            get { return Fields.MachineParameterUnitId[this]; }
            set { Fields.MachineParameterUnitId[this] = value; }
        }

        [DisplayName("Machine Parameter Status Id"), Expression("jMachineParameter.[StatusId]")]
        public Int32? MachineParameterStatusId
        {
            get { return Fields.MachineParameterStatusId[this]; }
            set { Fields.MachineParameterStatusId[this] = value; }
        }

        [DisplayName("Machine Parameter Created By"), Expression("jMachineParameter.[CreatedBy]")]
        public Int32? MachineParameterCreatedBy
        {
            get { return Fields.MachineParameterCreatedBy[this]; }
            set { Fields.MachineParameterCreatedBy[this] = value; }
        }

        [DisplayName("Machine Parameter Created Date"), Expression("jMachineParameter.[CreatedDate]")]
        public DateTime? MachineParameterCreatedDate
        {
            get { return Fields.MachineParameterCreatedDate[this]; }
            set { Fields.MachineParameterCreatedDate[this] = value; }
        }

        [DisplayName("Machine Parameter Updated By"), Expression("jMachineParameter.[UpdatedBy]")]
        public Int32? MachineParameterUpdatedBy
        {
            get { return Fields.MachineParameterUpdatedBy[this]; }
            set { Fields.MachineParameterUpdatedBy[this] = value; }
        }

        [DisplayName("Machine Parameter Updated Date"), Expression("jMachineParameter.[UpdatedDate]")]
        public DateTime? MachineParameterUpdatedDate
        {
            get { return Fields.MachineParameterUpdatedDate[this]; }
            set { Fields.MachineParameterUpdatedDate[this] = value; }
        }

        [DisplayName("Machine Parameter Type"), Expression("jMachineParameter.[Type]")]
        public Int32? MachineParameterType
        {
            get { return Fields.MachineParameterType[this]; }
            set { Fields.MachineParameterType[this] = value; }
        }

        [DisplayName("Machine Parameter Is Read"), Expression("jMachineParameter.[IsRead]")]
        public Boolean? MachineParameterIsRead
        {
            get { return Fields.MachineParameterIsRead[this]; }
            set { Fields.MachineParameterIsRead[this] = value; }
        }

        [DisplayName("Machine Parameter Is Write"), Expression("jMachineParameter.[IsWrite]")]
        public Boolean? MachineParameterIsWrite
        {
            get { return Fields.MachineParameterIsWrite[this]; }
            set { Fields.MachineParameterIsWrite[this] = value; }
        }

        [DisplayName("Machine Parameter Row Id"), Expression("jMachineParameter.[RowId]")]
        public Int32? MachineParameterRowId
        {
            get { return Fields.MachineParameterRowId[this]; }
            set { Fields.MachineParameterRowId[this] = value; }
        }

        [DisplayName("Machine Parameter Is Bit Wise"), Expression("jMachineParameter.[IsBitWise]")]
        public Boolean? MachineParameterIsBitWise
        {
            get { return Fields.MachineParameterIsBitWise[this]; }
            set { Fields.MachineParameterIsBitWise[this] = value; }
        }

        [DisplayName("Machine Parameter Bit Wise Index"), Expression("jMachineParameter.[BitWiseIndex]")]
        public Int32? MachineParameterBitWiseIndex
        {
            get { return Fields.MachineParameterBitWiseIndex[this]; }
            set { Fields.MachineParameterBitWiseIndex[this] = value; }
        }

        [DisplayName("Machine Parameter Query Type Row Id"), Expression("jMachineParameter.[QueryTypeRowId]")]
        public Int32? MachineParameterQueryTypeRowId
        {
            get { return Fields.MachineParameterQueryTypeRowId[this]; }
            set { Fields.MachineParameterQueryTypeRowId[this] = value; }
        }

        [DisplayName("Machine Parameter Operation Type"), Expression("jMachineParameter.[OperationType]")]
        public Int32? MachineParameterOperationType
        {
            get { return Fields.MachineParameterOperationType[this]; }
            set { Fields.MachineParameterOperationType[this] = value; }
        }

        [DisplayName("Machine Parameter Operation Value"), Expression("jMachineParameter.[OperationValue]")]
        public Decimal? MachineParameterOperationValue
        {
            get { return Fields.MachineParameterOperationValue[this]; }
            set { Fields.MachineParameterOperationValue[this] = value; }
        }

        [DisplayName("Machine Parameter Is32 Bit"), Expression("jMachineParameter.[Is32Bit]")]
        public Boolean? MachineParameterIs32Bit
        {
            get { return Fields.MachineParameterIs32Bit[this]; }
            set { Fields.MachineParameterIs32Bit[this] = value; }
        }

        [DisplayName("Machine Parameter Bit32 Row Id"), Expression("jMachineParameter.[Bit32RowId]")]
        public Int32? MachineParameterBit32RowId
        {
            get { return Fields.MachineParameterBit32RowId[this]; }
            set { Fields.MachineParameterBit32RowId[this] = value; }
        }

        [DisplayName("Machine Parameter Is Stop At"), Expression("jMachineParameter.[IsStopAt]")]
        public Boolean? MachineParameterIsStopAt
        {
            get { return Fields.MachineParameterIsStopAt[this]; }
            set { Fields.MachineParameterIsStopAt[this] = value; }
        }

        [DisplayName("Machine Parameter Read Machine Parameter Id"), Expression("jMachineParameter.[ReadMachineParameterId]")]
        public Int32? MachineParameterReadMachineParameterId
        {
            get { return Fields.MachineParameterReadMachineParameterId[this]; }
            set { Fields.MachineParameterReadMachineParameterId[this] = value; }
        }

        [DisplayName("Machine Parameter Reload Machine Parameter Id"), Expression("jMachineParameter.[ReloadMachineParameterId]")]
        public Int32? MachineParameterReloadMachineParameterId
        {
            get { return Fields.MachineParameterReloadMachineParameterId[this]; }
            set { Fields.MachineParameterReloadMachineParameterId[this] = value; }
        }

        [DisplayName("Machine Parameter Is Show As Message"), Expression("jMachineParameter.[IsShowAsMessage]")]
        public Boolean? MachineParameterIsShowAsMessage
        {
            get { return Fields.MachineParameterIsShowAsMessage[this]; }
            set { Fields.MachineParameterIsShowAsMessage[this] = value; }
        }

        [DisplayName("Machine Parameter Is Batch Start Required"), Expression("jMachineParameter.[IsBatchStartRequired]")]
        public Boolean? MachineParameterIsBatchStartRequired
        {
            get { return Fields.MachineParameterIsBatchStartRequired[this]; }
            set { Fields.MachineParameterIsBatchStartRequired[this] = value; }
        }

        [DisplayName("Machine Parameter Is Reset On Batch Create"), Expression("jMachineParameter.[IsResetOnBatchCreate]")]
        public Boolean? MachineParameterIsResetOnBatchCreate
        {
            get { return Fields.MachineParameterIsResetOnBatchCreate[this]; }
            set { Fields.MachineParameterIsResetOnBatchCreate[this] = value; }
        }

        [DisplayName("Machine Parameter Is Label Roll"), Expression("jMachineParameter.[IsLabelRoll]")]
        public Boolean? MachineParameterIsLabelRoll
        {
            get { return Fields.MachineParameterIsLabelRoll[this]; }
            set { Fields.MachineParameterIsLabelRoll[this] = value; }
        }

        [DisplayName("Machine Parameter Disable Parameter Id"), Expression("jMachineParameter.[DisableParameterId]")]
        public Int32? MachineParameterDisableParameterId
        {
            get { return Fields.MachineParameterDisableParameterId[this]; }
            set { Fields.MachineParameterDisableParameterId[this] = value; }
        }

        [DisplayName("Machine Parameter Disable Parameter Value"), Expression("jMachineParameter.[DisableParameterValue]")]
        public String MachineParameterDisableParameterValue
        {
            get { return Fields.MachineParameterDisableParameterValue[this]; }
            set { Fields.MachineParameterDisableParameterValue[this] = value; }
        }

        [DisplayName("Machine Parameter Allow Decimal Point"), Expression("jMachineParameter.[AllowDecimalPoint]")]
        public Boolean? MachineParameterAllowDecimalPoint
        {
            get { return Fields.MachineParameterAllowDecimalPoint[this]; }
            set { Fields.MachineParameterAllowDecimalPoint[this] = value; }
        }

        [DisplayName("Machine Parameter Is Stop On Batch Stop"), Expression("jMachineParameter.[IsStopOnBatchStop]")]
        public Boolean? MachineParameterIsStopOnBatchStop
        {
            get { return Fields.MachineParameterIsStopOnBatchStop[this]; }
            set { Fields.MachineParameterIsStopOnBatchStop[this] = value; }
        }

        [DisplayName("Machine Parameter Record Added Source"), Expression("jMachineParameter.[RecordAddedSource]")]
        public String MachineParameterRecordAddedSource
        {
            get { return Fields.MachineParameterRecordAddedSource[this]; }
            set { Fields.MachineParameterRecordAddedSource[this] = value; }
        }

        [DisplayName("Machine Parameter Column Name"), Expression("jMachineParameter.[ColumnName]")]
        public String MachineParameterColumnName
        {
            get { return Fields.MachineParameterColumnName[this]; }
            set { Fields.MachineParameterColumnName[this] = value; }
        }

        [DisplayName("Machine Parameter Pick List Id"), Expression("jMachineParameter.[PickListId]")]
        public Int32? MachineParameterPickListId
        {
            get { return Fields.MachineParameterPickListId[this]; }
            set { Fields.MachineParameterPickListId[this] = value; }
        }

        [DisplayName("Module Module Name"), Expression("jModule.[ModuleName]")]
        public String ModuleModuleName
        {
            get { return Fields.ModuleModuleName[this]; }
            set { Fields.ModuleModuleName[this] = value; }
        }

        [DisplayName("Module Machine Id"), Expression("jModule.[MachineId]")]
        public Int32? ModuleMachineId
        {
            get { return Fields.ModuleMachineId[this]; }
            set { Fields.ModuleMachineId[this] = value; }
        }

        [DisplayName("Module Status Id"), Expression("jModule.[StatusId]")]
        public Int32? ModuleStatusId
        {
            get { return Fields.ModuleStatusId[this]; }
            set { Fields.ModuleStatusId[this] = value; }
        }

        [DisplayName("Module Created By"), Expression("jModule.[CreatedBy]")]
        public Int32? ModuleCreatedBy
        {
            get { return Fields.ModuleCreatedBy[this]; }
            set { Fields.ModuleCreatedBy[this] = value; }
        }

        [DisplayName("Module Created Date"), Expression("jModule.[CreatedDate]")]
        public DateTime? ModuleCreatedDate
        {
            get { return Fields.ModuleCreatedDate[this]; }
            set { Fields.ModuleCreatedDate[this] = value; }
        }

        [DisplayName("Module Updated By"), Expression("jModule.[UpdatedBy]")]
        public Int32? ModuleUpdatedBy
        {
            get { return Fields.ModuleUpdatedBy[this]; }
            set { Fields.ModuleUpdatedBy[this] = value; }
        }

        [DisplayName("Module Updated Date"), Expression("jModule.[UpdatedDate]")]
        public DateTime? ModuleUpdatedDate
        {
            get { return Fields.ModuleUpdatedDate[this]; }
            set { Fields.ModuleUpdatedDate[this] = value; }
        }

        [DisplayName("Module Sequence"), Expression("jModule.[Sequence]")]
        public Int32? ModuleSequence
        {
            get { return Fields.ModuleSequence[this]; }
            set { Fields.ModuleSequence[this] = value; }
        }

        [DisplayName("Module Equipment Id"), Expression("jModule.[EquipmentID]")]
        public String ModuleEquipmentId
        {
            get { return Fields.ModuleEquipmentId[this]; }
            set { Fields.ModuleEquipmentId[this] = value; }
        }

        [DisplayName("Module Serial Number"), Expression("jModule.[SerialNumber]")]
        public String ModuleSerialNumber
        {
            get { return Fields.ModuleSerialNumber[this]; }
            set { Fields.ModuleSerialNumber[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ViewField; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ViewFieldName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DisplayObjectFieldRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field ViewField;
            public Int32Field ViewsId;
            public StringField ViewFieldName;
            public Int32Field StatusId;
            //public Int32Field CreatedBy;
            //public DateTimeField CreatedDate;
            //public Int32Field UpdatedBy;
            //public DateTimeField UpdatedDate;
            public Int32Field Sequence;
            public Int32Field MachineParameterId;
            public BooleanField IsPopUpRequired;
            public BooleanField IsCommentRequired;
            public BooleanField IsAuthenticationRequired;
            public Int32Field ModuleId;
            public ListField<Int32> Roles;
            public BooleanField IsSelectAllRoles;

            public Int32Field ViewsModuleId;
            public StringField ViewsViewName;
            public BooleanField ViewsIsAccessFieldWise;
            public Int32Field ViewsStatusId;
            public Int32Field ViewsCreatedBy;
            public DateTimeField ViewsCreatedDate;
            public Int32Field ViewsUpdatedBy;
            public DateTimeField ViewsUpdatedDate;
            public BooleanField ViewsIsMachineSettings;
            public BooleanField ViewsIsMachineSummary;
            public BooleanField ViewsIslabelRoll;
            public BooleanField ViewsIsCommandPanel;
            public BooleanField ViewsIsFactorySetting;
            public Int32Field ViewsDisplayObjectTypeId;
            public Int32Field ViewsMachineId;
            public Int32Field ViewsListDisplayId;
            public Int32Field ViewsFormDisplayId;
            public Int32Field ViewsButtonDisplayId;
            public Int32Field ViewsRealtimeParameterDisplayId;
            public Int32Field ViewsLineChartDisplayId;
            public Int32Field ViewsPieChartDisplayId;
            public Int32Field ViewsTreeDisplayId;
            public Int32Field ViewsAttachmentDisplayId;
            public Int32Field ViewsAlarmDisplayId;
            public Int32Field ViewsNotificationDisplayId;
            public Int32Field ViewsContainerDisplayId;

            public StringField StatusStatusName;
            public StringField MachineName;

            public StringField CreatedByEmployeeId;
            public StringField CreatedByFirstName;
            public StringField CreatedByLastName;
            public Int32Field CreatedByDepartmentId;
            public StringField CreatedByDesignation;
            public Int32Field CreatedByMobileCode;
            public Int64Field CreatedByMobileNumber;
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
            public BooleanField CreatedByIsForgotPassword;
            public BooleanField CreatedByIsPasswordChangeOnLogin;
            public BooleanField CreatedByIsUserHidden;
            public DateTimeField CreatedByBirthDate;
            public Int32Field CreatedByStatusId;
            public Int32Field CreatedBy1;
            public DateTimeField CreatedByCreatedDate;
            public Int32Field CreatedByUpdatedBy;
            public DateTimeField CreatedByUpdatedDate;
            public Int32Field CreatedByQuestionId;
            public StringField CreatedByQuestionAns;
            public BooleanField CreatedByIsLockOut;
            public DateTimeField CreatedByLockOutDateTime;
            public Int32Field CreatedByLogInAttempt;
            public BooleanField CreatedByIsActiveDirectory;
            public StringField CreatedByMachineId;
            public StringField CreatedByRecordAddedSource;

            public StringField UpdatedByEmployeeId;
            public StringField UpdatedByFirstName;
            public StringField UpdatedByLastName;
            public Int32Field UpdatedByDepartmentId;
            public StringField UpdatedByDesignation;
            public Int32Field UpdatedByMobileCode;
            public Int64Field UpdatedByMobileNumber;
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
            public BooleanField UpdatedByIsForgotPassword;
            public BooleanField UpdatedByIsPasswordChangeOnLogin;
            public BooleanField UpdatedByIsUserHidden;
            public DateTimeField UpdatedByBirthDate;
            public Int32Field UpdatedByStatusId;
            public Int32Field UpdatedByCreatedBy;
            public DateTimeField UpdatedByCreatedDate;
            public Int32Field UpdatedBy1;
            public DateTimeField UpdatedByUpdatedDate;
            public Int32Field UpdatedByQuestionId;
            public StringField UpdatedByQuestionAns;
            public BooleanField UpdatedByIsLockOut;
            public DateTimeField UpdatedByLockOutDateTime;
            public Int32Field UpdatedByLogInAttempt;
            public BooleanField UpdatedByIsActiveDirectory;
            public StringField UpdatedByMachineId;
            public StringField UpdatedByRecordAddedSource;

            public Int32Field MachineParameterMachineId;
            public StringField MachineParameterParameterName;
            public StringField MachineParameterPlcAddress;
            public StringField MachineParameterDescription;
            public Int32Field MachineParameterDataTypeId;
            public BooleanField MachineParameterIsRangeUnlimited;
            public DecimalField MachineParameterMin;
            public DecimalField MachineParameterMax;
            public BooleanField MachineParameterIsUseUnit;
            public Int32Field MachineParameterUnitId;
            public Int32Field MachineParameterStatusId;
            public Int32Field MachineParameterCreatedBy;
            public DateTimeField MachineParameterCreatedDate;
            public Int32Field MachineParameterUpdatedBy;
            public DateTimeField MachineParameterUpdatedDate;
            public Int32Field MachineParameterType;
            public BooleanField MachineParameterIsRead;
            public BooleanField MachineParameterIsWrite;
            public Int32Field MachineParameterRowId;
            public BooleanField MachineParameterIsBitWise;
            public Int32Field MachineParameterBitWiseIndex;
            public Int32Field MachineParameterQueryTypeRowId;
            public Int32Field MachineParameterOperationType;
            public DecimalField MachineParameterOperationValue;
            public BooleanField MachineParameterIs32Bit;
            public Int32Field MachineParameterBit32RowId;
            public BooleanField MachineParameterIsStopAt;
            public Int32Field MachineParameterReadMachineParameterId;
            public Int32Field MachineParameterReloadMachineParameterId;
            public BooleanField MachineParameterIsShowAsMessage;
            public BooleanField MachineParameterIsBatchStartRequired;
            public BooleanField MachineParameterIsResetOnBatchCreate;
            public BooleanField MachineParameterIsLabelRoll;
            public Int32Field MachineParameterDisableParameterId;
            public StringField MachineParameterDisableParameterValue;
            public BooleanField MachineParameterAllowDecimalPoint;
            public BooleanField MachineParameterIsStopOnBatchStop;
            public StringField MachineParameterRecordAddedSource;
            public StringField MachineParameterColumnName;
            public Int32Field MachineParameterPickListId;

            public StringField ModuleModuleName;
            public Int32Field ModuleMachineId;
            public Int32Field ModuleStatusId;
            public Int32Field ModuleCreatedBy;
            public DateTimeField ModuleCreatedDate;
            public Int32Field ModuleUpdatedBy;
            public DateTimeField ModuleUpdatedDate;
            public Int32Field ModuleSequence;
            public StringField ModuleEquipmentId;
            public StringField ModuleSerialNumber;
        }
    }
}
