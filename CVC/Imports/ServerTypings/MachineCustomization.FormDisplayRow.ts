namespace CVC.MachineCustomization {
    export interface FormDisplayRow {
        FormDisplayId?: number;
        FormDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        IsCheckbox?: boolean;
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

    export namespace FormDisplayRow {
        export const idProperty = 'FormDisplayId';
        export const nameProperty = 'FormDisplayName';
        export const localTextPrefix = 'MachineCustomization.FormDisplay';
        export const lookupKey = 'MachineCustomization.FormDisplay';

        export function getLookup(): Q.Lookup<FormDisplayRow> {
            return Q.getLookup<FormDisplayRow>('MachineCustomization.FormDisplay');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            FormDisplayId = "FormDisplayId",
            FormDisplayName = "FormDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            IsCheckbox = "IsCheckbox",
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

