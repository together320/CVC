namespace CVC.Configuration {
    export interface EnvironmentVariablesRow {
        EnvVariableId?: number;
        ReportLocation?: string;
        BackupFolder?: string;
        BackupFrequencyNoOfDaya?: number;
        BackupTime?: number;
        TimeZoneId?: string;
        TimeZoneName?: string;
        ScreenTimeOut?: number;
        IsPasswordChangeRequired?: boolean;
        PasswordMinLength?: number;
        PasswordMaxLength?: number;
        MinAlphaChars?: number;
        MinNumericChars?: number;
        MinSpecialChars?: number;
        MinCapitalLetter?: number;
        PasswordExpiryInDays?: number;
        CurrencyId?: number;
        LanguageId?: number;
        SessionTimeOut?: number;
        DateTimeFormat?: string;
        NumberFormat?: string;
        LockInAttempt?: number;
        UnLockTime?: number;
        IsUnLockAfterTime?: boolean;
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
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        DateFormatTypeID?: number;
        DateFormatTypeValue?: string;
        TimeFormatTypeID?: number;
        TimeFormatValue?: string;
        HourFormatTypeID?: number;
        HourFormatTypeValue?: string;
        ArchivalPath?: string;
        LastPeriodRetained?: number;
        IsOverWriteBackup?: boolean;
        PasswordExpiryNotification?: number;
        PreviousPasswordLimit?: number;
        DatabaseLimit?: number;
        LicenseExpiryNotification?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace EnvironmentVariablesRow {
        export const idProperty = 'EnvVariableId';
        export const nameProperty = 'ReportLocation';
        export const localTextPrefix = 'Configuration.EnvironmentVariables';
        export const deletePermission = 'Configuration:EnvironmentVariable:Modify';
        export const insertPermission = 'Configuration:EnvironmentVariable:Modify';
        export const readPermission = 'Configuration:EnvironmentVariable:Read';
        export const updatePermission = 'Configuration:EnvironmentVariable:Modify';

        export declare const enum Fields {
            EnvVariableId = "EnvVariableId",
            ReportLocation = "ReportLocation",
            BackupFolder = "BackupFolder",
            BackupFrequencyNoOfDaya = "BackupFrequencyNoOfDaya",
            BackupTime = "BackupTime",
            TimeZoneId = "TimeZoneId",
            TimeZoneName = "TimeZoneName",
            ScreenTimeOut = "ScreenTimeOut",
            IsPasswordChangeRequired = "IsPasswordChangeRequired",
            PasswordMinLength = "PasswordMinLength",
            PasswordMaxLength = "PasswordMaxLength",
            MinAlphaChars = "MinAlphaChars",
            MinNumericChars = "MinNumericChars",
            MinSpecialChars = "MinSpecialChars",
            MinCapitalLetter = "MinCapitalLetter",
            PasswordExpiryInDays = "PasswordExpiryInDays",
            CurrencyId = "CurrencyId",
            LanguageId = "LanguageId",
            SessionTimeOut = "SessionTimeOut",
            DateTimeFormat = "DateTimeFormat",
            NumberFormat = "NumberFormat",
            LockInAttempt = "LockInAttempt",
            UnLockTime = "UnLockTime",
            IsUnLockAfterTime = "IsUnLockAfterTime",
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
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            DateFormatTypeID = "DateFormatTypeID",
            DateFormatTypeValue = "DateFormatTypeValue",
            TimeFormatTypeID = "TimeFormatTypeID",
            TimeFormatValue = "TimeFormatValue",
            HourFormatTypeID = "HourFormatTypeID",
            HourFormatTypeValue = "HourFormatTypeValue",
            ArchivalPath = "ArchivalPath",
            LastPeriodRetained = "LastPeriodRetained",
            IsOverWriteBackup = "IsOverWriteBackup",
            PasswordExpiryNotification = "PasswordExpiryNotification",
            PreviousPasswordLimit = "PreviousPasswordLimit",
            DatabaseLimit = "DatabaseLimit",
            LicenseExpiryNotification = "LicenseExpiryNotification",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

