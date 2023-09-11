namespace CVC.MachineCustomization {
    export interface NotificationDisplayRow {
        NotificationDisplayId?: number;
        NotificationDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        Font?: string;
        FontColorSelected?: string;
        FontColorUnselected?: string;
        Activation?: number;
        IsOpenInNewWindow?: boolean;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        Alignment?: number;
        IsFolderBrowse?: boolean;
        IsAddAttachments?: boolean;
        IsCollapsible?: boolean;
    }

    export namespace NotificationDisplayRow {
        export const idProperty = 'NotificationDisplayId';
        export const nameProperty = 'NotificationDisplayName';
        export const localTextPrefix = 'MachineCustomization.NotificationDisplay';
        export const lookupKey = 'MachineCustomization.NotificationDisplay';

        export function getLookup(): Q.Lookup<NotificationDisplayRow> {
            return Q.getLookup<NotificationDisplayRow>('MachineCustomization.NotificationDisplay');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            NotificationDisplayId = "NotificationDisplayId",
            NotificationDisplayName = "NotificationDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            Font = "Font",
            FontColorSelected = "FontColorSelected",
            FontColorUnselected = "FontColorUnselected",
            Activation = "Activation",
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

