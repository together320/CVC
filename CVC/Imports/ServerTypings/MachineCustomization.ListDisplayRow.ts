namespace CVC.MachineCustomization {
    export interface ListDisplayRow {
        ListDisplayId?: number;
        ListDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        Checkbox?: boolean;
        Font?: string;
        FontColor?: string;
        FontSize?: number;
        FullRowSelect?: boolean;
        Gridlines?: boolean;
        UseWaitCursorOnClick?: boolean;
        Activation?: number;
        Alignment?: number;
        SortingType?: number;
        SortAscDesc?: boolean;
        MultiSelect?: boolean;
        AutoResize?: boolean;
        Collapsible?: boolean;
    }

    export namespace ListDisplayRow {
        export const idProperty = 'ListDisplayId';
        export const nameProperty = 'ListDisplayName';
        export const localTextPrefix = 'MachineCustomization.ListDisplay';
        export const lookupKey = 'MachineCustomization.ListDisplay';

        export function getLookup(): Q.Lookup<ListDisplayRow> {
            return Q.getLookup<ListDisplayRow>('MachineCustomization.ListDisplay');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ListDisplayId = "ListDisplayId",
            ListDisplayName = "ListDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            Checkbox = "Checkbox",
            Font = "Font",
            FontColor = "FontColor",
            FontSize = "FontSize",
            FullRowSelect = "FullRowSelect",
            Gridlines = "Gridlines",
            UseWaitCursorOnClick = "UseWaitCursorOnClick",
            Activation = "Activation",
            Alignment = "Alignment",
            SortingType = "SortingType",
            SortAscDesc = "SortAscDesc",
            MultiSelect = "MultiSelect",
            AutoResize = "AutoResize",
            Collapsible = "Collapsible"
        }
    }
}

