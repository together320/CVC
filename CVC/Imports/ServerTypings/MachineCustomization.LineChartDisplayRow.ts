namespace CVC.MachineCustomization {
    export interface LineChartDisplayRow {
        LineChartDisplayId?: number;
        LineChartDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        Font?: string;
        FontColor?: string;
        Alignment?: number;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        IsCollapsible?: boolean;
        IsLegends?: boolean;
        IsGridlines?: boolean;
        GridlineColor?: string;
        IsRealtime?: boolean;
        AxisColor?: string;
    }

    export namespace LineChartDisplayRow {
        export const idProperty = 'LineChartDisplayId';
        export const nameProperty = 'LineChartDisplayName';
        export const localTextPrefix = 'MachineCustomization.LineChartDisplay';
        export const lookupKey = 'MachineCustomization.LineChartDisplay';

        export function getLookup(): Q.Lookup<LineChartDisplayRow> {
            return Q.getLookup<LineChartDisplayRow>('MachineCustomization.LineChartDisplay');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            LineChartDisplayId = "LineChartDisplayId",
            LineChartDisplayName = "LineChartDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            Font = "Font",
            FontColor = "FontColor",
            Alignment = "Alignment",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            IsCollapsible = "IsCollapsible",
            IsLegends = "IsLegends",
            IsGridlines = "IsGridlines",
            GridlineColor = "GridlineColor",
            IsRealtime = "IsRealtime",
            AxisColor = "AxisColor"
        }
    }
}

