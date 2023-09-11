namespace CVC.MachineCustomization {
    export interface ButtonDisplayRow {
        ButtonDisplayId?: number;
        ButtonDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        Font?: string;
        FontColorSelected?: string;
        FontColorUnselected?: string;
        Activation?: number;
        Alignment?: number;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        IsCollapsible?: boolean;
    }

    export namespace ButtonDisplayRow {
        export const idProperty = 'ButtonDisplayId';
        export const nameProperty = 'ButtonDisplayName';
        export const localTextPrefix = 'MachineCustomization.ButtonDisplay';
        export const lookupKey = 'MachineCustomization.ButtonDisplay';

        export function getLookup(): Q.Lookup<ButtonDisplayRow> {
            return Q.getLookup<ButtonDisplayRow>('MachineCustomization.ButtonDisplay');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ButtonDisplayId = "ButtonDisplayId",
            ButtonDisplayName = "ButtonDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            Font = "Font",
            FontColorSelected = "FontColorSelected",
            FontColorUnselected = "FontColorUnselected",
            Activation = "Activation",
            Alignment = "Alignment",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            IsCollapsible = "IsCollapsible"
        }
    }
}

