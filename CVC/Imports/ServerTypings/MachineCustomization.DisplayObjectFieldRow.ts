namespace CVC.MachineCustomization {
    export interface DisplayObjectFieldRow {
        ViewField?: number;
        ViewsId?: number;
        ViewFieldName?: string;
        StatusId?: number;
        Sequence?: number;
        MachineParameterId?: number;
        IsPopUpRequired?: boolean;
        IsCommentRequired?: boolean;
        IsAuthenticationRequired?: boolean;
        ModuleId?: number;
        Roles?: number[];
        IsSelectAllRoles?: boolean;
        ViewsModuleId?: number;
        ViewsViewName?: string;
        ViewsIsAccessFieldWise?: boolean;
        ViewsStatusId?: number;
        ViewsCreatedBy?: number;
        ViewsCreatedDate?: string;
        ViewsUpdatedBy?: number;
        ViewsUpdatedDate?: string;
        ViewsIsMachineSettings?: boolean;
        ViewsIsMachineSummary?: boolean;
        ViewsIslabelRoll?: boolean;
        ViewsIsCommandPanel?: boolean;
        ViewsIsFactorySetting?: boolean;
        ViewsDisplayObjectTypeId?: number;
        ViewsMachineId?: number;
        ViewsListDisplayId?: number;
        ViewsFormDisplayId?: number;
        ViewsButtonDisplayId?: number;
        ViewsRealtimeParameterDisplayId?: number;
        ViewsLineChartDisplayId?: number;
        ViewsPieChartDisplayId?: number;
        ViewsTreeDisplayId?: number;
        ViewsAttachmentDisplayId?: number;
        ViewsAlarmDisplayId?: number;
        ViewsNotificationDisplayId?: number;
        ViewsContainerDisplayId?: number;
        StatusStatusName?: string;
        MachineName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: boolean;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: boolean;
        CreatedByBirthDate?: string;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        CreatedByQuestionId?: number;
        CreatedByQuestionAns?: string;
        CreatedByIsLockOut?: boolean;
        CreatedByLockOutDateTime?: string;
        CreatedByLogInAttempt?: number;
        CreatedByIsActiveDirectory?: boolean;
        CreatedByMachineId?: string;
        CreatedByRecordAddedSource?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: boolean;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: boolean;
        UpdatedByBirthDate?: string;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        UpdatedByQuestionId?: number;
        UpdatedByQuestionAns?: string;
        UpdatedByIsLockOut?: boolean;
        UpdatedByLockOutDateTime?: string;
        UpdatedByLogInAttempt?: number;
        UpdatedByIsActiveDirectory?: boolean;
        UpdatedByMachineId?: string;
        UpdatedByRecordAddedSource?: string;
        MachineParameterMachineId?: number;
        MachineParameterParameterName?: string;
        MachineParameterPlcAddress?: string;
        MachineParameterDescription?: string;
        MachineParameterDataTypeId?: number;
        MachineParameterIsRangeUnlimited?: boolean;
        MachineParameterMin?: number;
        MachineParameterMax?: number;
        MachineParameterIsUseUnit?: boolean;
        MachineParameterUnitId?: number;
        MachineParameterStatusId?: number;
        MachineParameterCreatedBy?: number;
        MachineParameterCreatedDate?: string;
        MachineParameterUpdatedBy?: number;
        MachineParameterUpdatedDate?: string;
        MachineParameterType?: number;
        MachineParameterIsRead?: boolean;
        MachineParameterIsWrite?: boolean;
        MachineParameterRowId?: number;
        MachineParameterIsBitWise?: boolean;
        MachineParameterBitWiseIndex?: number;
        MachineParameterQueryTypeRowId?: number;
        MachineParameterOperationType?: number;
        MachineParameterOperationValue?: number;
        MachineParameterIs32Bit?: boolean;
        MachineParameterBit32RowId?: number;
        MachineParameterIsStopAt?: boolean;
        MachineParameterReadMachineParameterId?: number;
        MachineParameterReloadMachineParameterId?: number;
        MachineParameterIsShowAsMessage?: boolean;
        MachineParameterIsBatchStartRequired?: boolean;
        MachineParameterIsResetOnBatchCreate?: boolean;
        MachineParameterIsLabelRoll?: boolean;
        MachineParameterDisableParameterId?: number;
        MachineParameterDisableParameterValue?: string;
        MachineParameterAllowDecimalPoint?: boolean;
        MachineParameterIsStopOnBatchStop?: boolean;
        MachineParameterRecordAddedSource?: string;
        MachineParameterColumnName?: string;
        MachineParameterPickListId?: number;
        ModuleModuleName?: string;
        ModuleMachineId?: number;
        ModuleStatusId?: number;
        ModuleCreatedBy?: number;
        ModuleCreatedDate?: string;
        ModuleUpdatedBy?: number;
        ModuleUpdatedDate?: string;
        ModuleSequence?: number;
        ModuleEquipmentId?: string;
        ModuleSerialNumber?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace DisplayObjectFieldRow {
        export const idProperty = 'ViewField';
        export const nameProperty = 'ViewFieldName';
        export const localTextPrefix = 'MachineCustomization.DisplayObjectField';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ViewField = "ViewField",
            ViewsId = "ViewsId",
            ViewFieldName = "ViewFieldName",
            StatusId = "StatusId",
            Sequence = "Sequence",
            MachineParameterId = "MachineParameterId",
            IsPopUpRequired = "IsPopUpRequired",
            IsCommentRequired = "IsCommentRequired",
            IsAuthenticationRequired = "IsAuthenticationRequired",
            ModuleId = "ModuleId",
            Roles = "Roles",
            IsSelectAllRoles = "IsSelectAllRoles",
            ViewsModuleId = "ViewsModuleId",
            ViewsViewName = "ViewsViewName",
            ViewsIsAccessFieldWise = "ViewsIsAccessFieldWise",
            ViewsStatusId = "ViewsStatusId",
            ViewsCreatedBy = "ViewsCreatedBy",
            ViewsCreatedDate = "ViewsCreatedDate",
            ViewsUpdatedBy = "ViewsUpdatedBy",
            ViewsUpdatedDate = "ViewsUpdatedDate",
            ViewsIsMachineSettings = "ViewsIsMachineSettings",
            ViewsIsMachineSummary = "ViewsIsMachineSummary",
            ViewsIslabelRoll = "ViewsIslabelRoll",
            ViewsIsCommandPanel = "ViewsIsCommandPanel",
            ViewsIsFactorySetting = "ViewsIsFactorySetting",
            ViewsDisplayObjectTypeId = "ViewsDisplayObjectTypeId",
            ViewsMachineId = "ViewsMachineId",
            ViewsListDisplayId = "ViewsListDisplayId",
            ViewsFormDisplayId = "ViewsFormDisplayId",
            ViewsButtonDisplayId = "ViewsButtonDisplayId",
            ViewsRealtimeParameterDisplayId = "ViewsRealtimeParameterDisplayId",
            ViewsLineChartDisplayId = "ViewsLineChartDisplayId",
            ViewsPieChartDisplayId = "ViewsPieChartDisplayId",
            ViewsTreeDisplayId = "ViewsTreeDisplayId",
            ViewsAttachmentDisplayId = "ViewsAttachmentDisplayId",
            ViewsAlarmDisplayId = "ViewsAlarmDisplayId",
            ViewsNotificationDisplayId = "ViewsNotificationDisplayId",
            ViewsContainerDisplayId = "ViewsContainerDisplayId",
            StatusStatusName = "StatusStatusName",
            MachineName = "MachineName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByBirthDate = "CreatedByBirthDate",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            CreatedByQuestionId = "CreatedByQuestionId",
            CreatedByQuestionAns = "CreatedByQuestionAns",
            CreatedByIsLockOut = "CreatedByIsLockOut",
            CreatedByLockOutDateTime = "CreatedByLockOutDateTime",
            CreatedByLogInAttempt = "CreatedByLogInAttempt",
            CreatedByIsActiveDirectory = "CreatedByIsActiveDirectory",
            CreatedByMachineId = "CreatedByMachineId",
            CreatedByRecordAddedSource = "CreatedByRecordAddedSource",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByBirthDate = "UpdatedByBirthDate",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            UpdatedByQuestionId = "UpdatedByQuestionId",
            UpdatedByQuestionAns = "UpdatedByQuestionAns",
            UpdatedByIsLockOut = "UpdatedByIsLockOut",
            UpdatedByLockOutDateTime = "UpdatedByLockOutDateTime",
            UpdatedByLogInAttempt = "UpdatedByLogInAttempt",
            UpdatedByIsActiveDirectory = "UpdatedByIsActiveDirectory",
            UpdatedByMachineId = "UpdatedByMachineId",
            UpdatedByRecordAddedSource = "UpdatedByRecordAddedSource",
            MachineParameterMachineId = "MachineParameterMachineId",
            MachineParameterParameterName = "MachineParameterParameterName",
            MachineParameterPlcAddress = "MachineParameterPlcAddress",
            MachineParameterDescription = "MachineParameterDescription",
            MachineParameterDataTypeId = "MachineParameterDataTypeId",
            MachineParameterIsRangeUnlimited = "MachineParameterIsRangeUnlimited",
            MachineParameterMin = "MachineParameterMin",
            MachineParameterMax = "MachineParameterMax",
            MachineParameterIsUseUnit = "MachineParameterIsUseUnit",
            MachineParameterUnitId = "MachineParameterUnitId",
            MachineParameterStatusId = "MachineParameterStatusId",
            MachineParameterCreatedBy = "MachineParameterCreatedBy",
            MachineParameterCreatedDate = "MachineParameterCreatedDate",
            MachineParameterUpdatedBy = "MachineParameterUpdatedBy",
            MachineParameterUpdatedDate = "MachineParameterUpdatedDate",
            MachineParameterType = "MachineParameterType",
            MachineParameterIsRead = "MachineParameterIsRead",
            MachineParameterIsWrite = "MachineParameterIsWrite",
            MachineParameterRowId = "MachineParameterRowId",
            MachineParameterIsBitWise = "MachineParameterIsBitWise",
            MachineParameterBitWiseIndex = "MachineParameterBitWiseIndex",
            MachineParameterQueryTypeRowId = "MachineParameterQueryTypeRowId",
            MachineParameterOperationType = "MachineParameterOperationType",
            MachineParameterOperationValue = "MachineParameterOperationValue",
            MachineParameterIs32Bit = "MachineParameterIs32Bit",
            MachineParameterBit32RowId = "MachineParameterBit32RowId",
            MachineParameterIsStopAt = "MachineParameterIsStopAt",
            MachineParameterReadMachineParameterId = "MachineParameterReadMachineParameterId",
            MachineParameterReloadMachineParameterId = "MachineParameterReloadMachineParameterId",
            MachineParameterIsShowAsMessage = "MachineParameterIsShowAsMessage",
            MachineParameterIsBatchStartRequired = "MachineParameterIsBatchStartRequired",
            MachineParameterIsResetOnBatchCreate = "MachineParameterIsResetOnBatchCreate",
            MachineParameterIsLabelRoll = "MachineParameterIsLabelRoll",
            MachineParameterDisableParameterId = "MachineParameterDisableParameterId",
            MachineParameterDisableParameterValue = "MachineParameterDisableParameterValue",
            MachineParameterAllowDecimalPoint = "MachineParameterAllowDecimalPoint",
            MachineParameterIsStopOnBatchStop = "MachineParameterIsStopOnBatchStop",
            MachineParameterRecordAddedSource = "MachineParameterRecordAddedSource",
            MachineParameterColumnName = "MachineParameterColumnName",
            MachineParameterPickListId = "MachineParameterPickListId",
            ModuleModuleName = "ModuleModuleName",
            ModuleMachineId = "ModuleMachineId",
            ModuleStatusId = "ModuleStatusId",
            ModuleCreatedBy = "ModuleCreatedBy",
            ModuleCreatedDate = "ModuleCreatedDate",
            ModuleUpdatedBy = "ModuleUpdatedBy",
            ModuleUpdatedDate = "ModuleUpdatedDate",
            ModuleSequence = "ModuleSequence",
            ModuleEquipmentId = "ModuleEquipmentId",
            ModuleSerialNumber = "ModuleSerialNumber",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

