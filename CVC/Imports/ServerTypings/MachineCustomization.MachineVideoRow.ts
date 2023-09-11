namespace CVC.MachineCustomization {
    export interface MachineVideoRow {
        MachineVideoId?: number;
        MachineId?: number;
        FileName?: string;
        FileContent?: number[];
        FileLength?: number;
        FileExtension?: string;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        MachineMachineLineId?: number;
        MachineMachineName?: string;
        MachineModelNumber?: string;
        MachineSerialNumber?: string;
        MachineMake?: string;
        MachineYear?: number;
        MachinePlcMake?: string;
        MachinePlcModelNumber?: string;
        MachinePlcSerialNumber?: string;
        MachinePlcAddress?: string;
        MachineAccessIpAddress?: string;
        MachineMachineSequence?: number;
        MachineMachineImage?: number[];
        MachineStatusId?: number;
        MachineDescription?: string;
        MachineCreatedBy?: number;
        MachineCreatedDate?: string;
        MachineUpdatedBy?: number;
        MachineUpdatedDate?: string;
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
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }

    export namespace MachineVideoRow {
        export const idProperty = 'MachineVideoId';
        export const nameProperty = 'FileName';
        export const localTextPrefix = 'MachineCustomization.MachineVideo';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            MachineVideoId = "MachineVideoId",
            MachineId = "MachineId",
            FileName = "FileName",
            FileContent = "FileContent",
            FileLength = "FileLength",
            FileExtension = "FileExtension",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            MachineMachineLineId = "MachineMachineLineId",
            MachineMachineName = "MachineMachineName",
            MachineModelNumber = "MachineModelNumber",
            MachineSerialNumber = "MachineSerialNumber",
            MachineMake = "MachineMake",
            MachineYear = "MachineYear",
            MachinePlcMake = "MachinePlcMake",
            MachinePlcModelNumber = "MachinePlcModelNumber",
            MachinePlcSerialNumber = "MachinePlcSerialNumber",
            MachinePlcAddress = "MachinePlcAddress",
            MachineAccessIpAddress = "MachineAccessIpAddress",
            MachineMachineSequence = "MachineMachineSequence",
            MachineMachineImage = "MachineMachineImage",
            MachineStatusId = "MachineStatusId",
            MachineDescription = "MachineDescription",
            MachineCreatedBy = "MachineCreatedBy",
            MachineCreatedDate = "MachineCreatedDate",
            MachineUpdatedBy = "MachineUpdatedBy",
            MachineUpdatedDate = "MachineUpdatedDate",
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
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}

