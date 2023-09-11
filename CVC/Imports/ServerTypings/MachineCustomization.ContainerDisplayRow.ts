namespace CVC.MachineCustomization {
    export interface ContainerDisplayRow {
        ContainerDisplayId?: number;
        ContainerDisplayName?: string;
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
        IsCollapsible?: boolean;
    }

    export namespace ContainerDisplayRow {
        export const idProperty = 'ContainerDisplayId';
        export const nameProperty = 'ContainerDisplayName';
        export const localTextPrefix = 'MachineCustomization.ContainerDisplay';
        export const lookupKey = 'MachineCustomization.ContainerDisplay';

        export function getLookup(): Q.Lookup<ContainerDisplayRow> {
            return Q.getLookup<ContainerDisplayRow>('MachineCustomization.ContainerDisplay');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ContainerDisplayId = "ContainerDisplayId",
            ContainerDisplayName = "ContainerDisplayName",
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
            IsCollapsible = "IsCollapsible"
        }
    }
}

