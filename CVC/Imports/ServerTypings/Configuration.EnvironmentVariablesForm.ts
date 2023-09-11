namespace CVC.Configuration {
    export interface EnvironmentVariablesForm {
        BackupFolder: Serenity.StringEditor;
        BackupFrequencyNoOfDaya: Serenity.IntegerEditor;
        BackupTime: Serenity.IntegerEditor;
        IsOverWriteBackup: Serenity.BooleanEditor;
        DatabaseLimit: Serenity.IntegerEditor;
        ArchivalPath: Serenity.StringEditor;
        LastPeriodRetained: Serenity.IntegerEditor;
        SessionTimeOut: Serenity.IntegerEditor;
        IsPasswordChangeRequired: Serenity.BooleanEditor;
        PasswordMaxLength: Serenity.IntegerEditor;
        PasswordMinLength: Serenity.IntegerEditor;
        MinAlphaChars: Serenity.IntegerEditor;
        MinNumericChars: Serenity.IntegerEditor;
        MinSpecialChars: Serenity.IntegerEditor;
        MinCapitalLetter: Serenity.IntegerEditor;
        PreviousPasswordLimit: Serenity.IntegerEditor;
        PasswordExpiryInDays: Serenity.IntegerEditor;
        PasswordExpiryNotification: Serenity.IntegerEditor;
        LockInAttempt: Serenity.IntegerEditor;
        IsUnLockAfterTime: Serenity.BooleanEditor;
        UnLockTime: Serenity.IntegerEditor;
        DateFormatTypeID: Serenity.LookupEditor;
        TimeFormatTypeID: Serenity.LookupEditor;
        HourFormatTypeID: Serenity.LookupEditor;
        LicenseExpiryNotification: Serenity.IntegerEditor;
    }

    export class EnvironmentVariablesForm extends Serenity.PrefixedContext {
        static formKey = 'Configuration.EnvironmentVariables';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!EnvironmentVariablesForm.init)  {
                EnvironmentVariablesForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.BooleanEditor;
                var w3 = s.LookupEditor;

                Q.initFormType(EnvironmentVariablesForm, [
                    'BackupFolder', w0,
                    'BackupFrequencyNoOfDaya', w1,
                    'BackupTime', w1,
                    'IsOverWriteBackup', w2,
                    'DatabaseLimit', w1,
                    'ArchivalPath', w0,
                    'LastPeriodRetained', w1,
                    'SessionTimeOut', w1,
                    'IsPasswordChangeRequired', w2,
                    'PasswordMaxLength', w1,
                    'PasswordMinLength', w1,
                    'MinAlphaChars', w1,
                    'MinNumericChars', w1,
                    'MinSpecialChars', w1,
                    'MinCapitalLetter', w1,
                    'PreviousPasswordLimit', w1,
                    'PasswordExpiryInDays', w1,
                    'PasswordExpiryNotification', w1,
                    'LockInAttempt', w1,
                    'IsUnLockAfterTime', w2,
                    'UnLockTime', w1,
                    'DateFormatTypeID', w3,
                    'TimeFormatTypeID', w3,
                    'HourFormatTypeID', w3,
                    'LicenseExpiryNotification', w1
                ]);
            }
        }
    }
}

