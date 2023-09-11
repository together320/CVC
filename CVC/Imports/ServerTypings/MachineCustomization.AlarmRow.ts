namespace CVC.MachineCustomization {
    export interface AlarmRow {
        AlarmId?: number;
        AlarmName?: string;
        MachineId?: number;
        MachineParameterId?: number;
        Message?: string;
        Description?: string;
        IsResetRequired?: boolean;
        IsCommentRequired?: boolean;
        IsMachineRequiredToStop?: boolean;
        MachineStopMachineParameterId?: number;
        IsCountForReject?: boolean;
        BitValue?: boolean;
        IsCheckAtMachineStart?: boolean;
        StatusId?: number;
        MachineStopMachineParameterMachineId?: number;
        MachineStopMachineParameterMachineParameterName?: string;
        StatusStatusName?: string;
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
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByBirthDate?: string;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
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
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByBirthDate?: string;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        MachineMachineName?: string;
        MachineParameterMachineParameterName?: string;
        IsResetRequiredString?: string;
        IsCommentRequiredString?: string;
        IsMachineRequiredToStopString?: string;
        IsCountForRejectString?: string;
        BitValueString?: string;
        IsCheckAtMachineStartString?: string;
        IsRefreshMachineSettings?: boolean;
        IsHideEdit?: boolean;
        IsAlarmForCounter?: boolean;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace AlarmRow {
        export const idProperty = 'AlarmId';
        export const nameProperty = 'AlarmName';
        export const localTextPrefix = 'MachineCustomization.Alarm';
        export const deletePermission = 'MachineCustomization:Alarm:Modify';
        export const insertPermission = 'MachineCustomization:Alarm:Modify';
        export const readPermission = 'MachineCustomization:Alarm:Read';
        export const updatePermission = 'MachineCustomization:Alarm:Modify';

        export declare const enum Fields {
            AlarmId = "AlarmId",
            AlarmName = "AlarmName",
            MachineId = "MachineId",
            MachineParameterId = "MachineParameterId",
            Message = "Message",
            Description = "Description",
            IsResetRequired = "IsResetRequired",
            IsCommentRequired = "IsCommentRequired",
            IsMachineRequiredToStop = "IsMachineRequiredToStop",
            MachineStopMachineParameterId = "MachineStopMachineParameterId",
            IsCountForReject = "IsCountForReject",
            BitValue = "BitValue",
            IsCheckAtMachineStart = "IsCheckAtMachineStart",
            StatusId = "StatusId",
            MachineStopMachineParameterMachineId = "MachineStopMachineParameterMachineId",
            MachineStopMachineParameterMachineParameterName = "MachineStopMachineParameterMachineParameterName",
            StatusStatusName = "StatusStatusName",
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
            MachineMachineName = "MachineMachineName",
            MachineParameterMachineParameterName = "MachineParameterMachineParameterName",
            IsResetRequiredString = "IsResetRequiredString",
            IsCommentRequiredString = "IsCommentRequiredString",
            IsMachineRequiredToStopString = "IsMachineRequiredToStopString",
            IsCountForRejectString = "IsCountForRejectString",
            BitValueString = "BitValueString",
            IsCheckAtMachineStartString = "IsCheckAtMachineStartString",
            IsRefreshMachineSettings = "IsRefreshMachineSettings",
            IsHideEdit = "IsHideEdit",
            IsAlarmForCounter = "IsAlarmForCounter",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

