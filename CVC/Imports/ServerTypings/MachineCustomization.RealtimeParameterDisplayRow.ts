namespace CVC.MachineCustomization {
    export interface RealtimeParameterDisplayRow {
        RealtimeParameterDisplayId?: number;
        RealtimeParameterDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        Font?: string;
        FontColor?: string;
        Alignment?: number;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        IsCollapsible?: boolean;
    }

    export namespace RealtimeParameterDisplayRow {
        export const idProperty = 'RealtimeParameterDisplayId';
        export const nameProperty = 'RealtimeParameterDisplayName';
        export const localTextPrefix = 'MachineCustomization.RealtimeParameterDisplay';
        export const lookupKey = 'MachineCustomization.RealtimeParameterDisplay';

        export function getLookup(): Q.Lookup<RealtimeParameterDisplayRow> {
            return Q.getLookup<RealtimeParameterDisplayRow>('MachineCustomization.RealtimeParameterDisplay');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            RealtimeParameterDisplayId = "RealtimeParameterDisplayId",
            RealtimeParameterDisplayName = "RealtimeParameterDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            Font = "Font",
            FontColor = "FontColor",
            Alignment = "Alignment",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            IsCollapsible = "IsCollapsible"
        }
    }
}

