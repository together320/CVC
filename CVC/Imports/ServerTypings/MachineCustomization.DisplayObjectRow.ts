namespace CVC.MachineCustomization {
    export interface DisplayObjectRow {
        ViewsId?: number;
        ModuleId?: number;
        ViewName?: string;
        IsAccessFieldWise?: boolean;
        StatusId?: number;
        IsMachineSettings?: boolean;
        IsMachineSummary?: boolean;
        IslabelRoll?: boolean;
        IsCommandPanel?: boolean;
        IsFactorySetting?: boolean;
        DisplayObjectTypeId?: number;
        DisplayObjectStyle?: string;
        MachineId?: number;
        StatusStatusName?: string;
        CreatedByUsername?: string;
        UpdatedByUsername?: string;
        MachineMachineName?: string;
        ListDisplayId?: number;
        ListDisplayName?: string;
        FormDisplayId?: number;
        FormDisplayName?: string;
        ButtonDisplayId?: number;
        ButtonDisplayName?: string;
        RealtimeParameterDisplayId?: number;
        RealtimeParameterDisplayName?: string;
        LineChartDisplayId?: number;
        LineChartDisplayName?: string;
        PieChartDisplayId?: number;
        PieChartDisplayName?: string;
        TreeDisplayId?: number;
        TreeDisplayName?: string;
        AttachmentDisplayId?: number;
        AttachmentDisplayName?: string;
        AlarmDisplayId?: number;
        AlarmDisplayName?: string;
        NotificationDisplayId?: number;
        NotificationDisplayName?: string;
        ContainerDisplayId?: number;
        ContainerDisplayName?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace DisplayObjectRow {
        export const idProperty = 'ViewsId';
        export const nameProperty = 'ViewName';
        export const localTextPrefix = 'MachineCustomization.DisplayObject';
        export const lookupKey = 'MachineCustomization.DisplayObject';

        export function getLookup(): Q.Lookup<DisplayObjectRow> {
            return Q.getLookup<DisplayObjectRow>('MachineCustomization.DisplayObject');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ViewsId = "ViewsId",
            ModuleId = "ModuleId",
            ViewName = "ViewName",
            IsAccessFieldWise = "IsAccessFieldWise",
            StatusId = "StatusId",
            IsMachineSettings = "IsMachineSettings",
            IsMachineSummary = "IsMachineSummary",
            IslabelRoll = "IslabelRoll",
            IsCommandPanel = "IsCommandPanel",
            IsFactorySetting = "IsFactorySetting",
            DisplayObjectTypeId = "DisplayObjectTypeId",
            DisplayObjectStyle = "DisplayObjectStyle",
            MachineId = "MachineId",
            StatusStatusName = "StatusStatusName",
            CreatedByUsername = "CreatedByUsername",
            UpdatedByUsername = "UpdatedByUsername",
            MachineMachineName = "MachineMachineName",
            ListDisplayId = "ListDisplayId",
            ListDisplayName = "ListDisplayName",
            FormDisplayId = "FormDisplayId",
            FormDisplayName = "FormDisplayName",
            ButtonDisplayId = "ButtonDisplayId",
            ButtonDisplayName = "ButtonDisplayName",
            RealtimeParameterDisplayId = "RealtimeParameterDisplayId",
            RealtimeParameterDisplayName = "RealtimeParameterDisplayName",
            LineChartDisplayId = "LineChartDisplayId",
            LineChartDisplayName = "LineChartDisplayName",
            PieChartDisplayId = "PieChartDisplayId",
            PieChartDisplayName = "PieChartDisplayName",
            TreeDisplayId = "TreeDisplayId",
            TreeDisplayName = "TreeDisplayName",
            AttachmentDisplayId = "AttachmentDisplayId",
            AttachmentDisplayName = "AttachmentDisplayName",
            AlarmDisplayId = "AlarmDisplayId",
            AlarmDisplayName = "AlarmDisplayName",
            NotificationDisplayId = "NotificationDisplayId",
            NotificationDisplayName = "NotificationDisplayName",
            ContainerDisplayId = "ContainerDisplayId",
            ContainerDisplayName = "ContainerDisplayName",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

