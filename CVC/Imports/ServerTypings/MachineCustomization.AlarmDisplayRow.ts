namespace CVC.MachineCustomization {
    export interface AlarmDisplayRow {
        AlarmDisplayId?: number;
        AlarmDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        IsCheckbox?: boolean;
        Font?: string;
        FontColorSelected?: string;
        FontColorUnselected?: string;
        CautionColor?: string;
        WarningColor?: string;
        EmergencyColor?: string;
        Activation?: number;
        Appearance?: number;
        IsOpenInNewWindow?: boolean;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        Alignment?: number;
        IsFolderBrowse?: boolean;
        IsAddAttachments?: boolean;
        IsCollapsible?: boolean;
    }

    export namespace AlarmDisplayRow {
        export const idProperty = 'AlarmDisplayId';
        export const nameProperty = 'AlarmDisplayName';
        export const localTextPrefix = 'MachineCustomization.AlarmDisplay';
        export const lookupKey = 'MachineCustomization.AlarmDisplay';

        export function getLookup(): Q.Lookup<AlarmDisplayRow> {
            return Q.getLookup<AlarmDisplayRow>('MachineCustomization.AlarmDisplay');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            AlarmDisplayId = "AlarmDisplayId",
            AlarmDisplayName = "AlarmDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            IsCheckbox = "IsCheckbox",
            Font = "Font",
            FontColorSelected = "FontColorSelected",
            FontColorUnselected = "FontColorUnselected",
            CautionColor = "CautionColor",
            WarningColor = "WarningColor",
            EmergencyColor = "EmergencyColor",
            Activation = "Activation",
            Appearance = "Appearance",
            IsOpenInNewWindow = "IsOpenInNewWindow",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            Alignment = "Alignment",
            IsFolderBrowse = "IsFolderBrowse",
            IsAddAttachments = "IsAddAttachments",
            IsCollapsible = "IsCollapsible"
        }
    }
}

