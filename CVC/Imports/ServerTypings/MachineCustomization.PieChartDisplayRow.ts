namespace CVC.MachineCustomization {
    export interface PieChartDisplayRow {
        PieChartDisplayId?: number;
        PieChartDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        Font?: string;
        FontColor?: string;
        IsLegends?: boolean;
        LegendFontSize?: number;
        IsShowValuesAsPercentage?: boolean;
        IsShowTotal?: boolean;
        Alignment?: number;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        IsRealtime?: boolean;
    }

    export namespace PieChartDisplayRow {
        export const idProperty = 'PieChartDisplayId';
        export const nameProperty = 'PieChartDisplayName';
        export const localTextPrefix = 'MachineCustomization.PieChartDisplay';
        export const lookupKey = 'MachineCustomization.PieChartDisplay';

        export function getLookup(): Q.Lookup<PieChartDisplayRow> {
            return Q.getLookup<PieChartDisplayRow>('MachineCustomization.PieChartDisplay');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            PieChartDisplayId = "PieChartDisplayId",
            PieChartDisplayName = "PieChartDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            Font = "Font",
            FontColor = "FontColor",
            IsLegends = "IsLegends",
            LegendFontSize = "LegendFontSize",
            IsShowValuesAsPercentage = "IsShowValuesAsPercentage",
            IsShowTotal = "IsShowTotal",
            Alignment = "Alignment",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            IsRealtime = "IsRealtime"
        }
    }
}

