namespace CVC.MachineCustomization {
    export interface TreeDisplayRow {
        TreeDisplayId?: number;
        TreeDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        Font?: string;
        FontColor?: string;
        IsFullRowSelect?: boolean;
        LineColor?: string;
        DefaultView?: number;
        Alignment?: number;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        IsRealtime?: boolean;
    }

    export namespace TreeDisplayRow {
        export const idProperty = 'TreeDisplayId';
        export const nameProperty = 'TreeDisplayName';
        export const localTextPrefix = 'MachineCustomization.TreeDisplay';
        export const lookupKey = 'MachineCustomization.TreeDisplay';

        export function getLookup(): Q.Lookup<TreeDisplayRow> {
            return Q.getLookup<TreeDisplayRow>('MachineCustomization.TreeDisplay');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            TreeDisplayId = "TreeDisplayId",
            TreeDisplayName = "TreeDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            Font = "Font",
            FontColor = "FontColor",
            IsFullRowSelect = "IsFullRowSelect",
            LineColor = "LineColor",
            DefaultView = "DefaultView",
            Alignment = "Alignment",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            IsRealtime = "IsRealtime"
        }
    }
}

