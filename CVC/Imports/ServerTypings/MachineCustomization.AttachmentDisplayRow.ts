namespace CVC.MachineCustomization {
    export interface AttachmentDisplayRow {
        AttachmentDisplayId?: number;
        AttachmentDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        IsCheckbox?: boolean;
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

    export namespace AttachmentDisplayRow {
        export const idProperty = 'AttachmentDisplayId';
        export const nameProperty = 'AttachmentDisplayName';
        export const localTextPrefix = 'MachineCustomization.AttachmentDisplay';
        export const lookupKey = 'MachineCustomization.AttachmentDisplay';

        export function getLookup(): Q.Lookup<AttachmentDisplayRow> {
            return Q.getLookup<AttachmentDisplayRow>('MachineCustomization.AttachmentDisplay');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            AttachmentDisplayId = "AttachmentDisplayId",
            AttachmentDisplayName = "AttachmentDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            IsCheckbox = "IsCheckbox",
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

