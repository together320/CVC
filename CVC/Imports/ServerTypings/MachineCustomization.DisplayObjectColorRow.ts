
namespace CVC.MachineCustomization {
    export interface DisplayObjectColorRow {
        ColorId?: number;
        RangeFrom?: number;
        RangeTo?: number;
        Color?: string;
        ViewsId?: number;
        ViewsModuleId?: number;
        ViewsViewName?: string;
        ViewsIsAccessFieldWise?: boolean;
        ViewsStatusId?: number;
        ViewsCreatedBy?: number;
        ViewsCreatedDate?: string;
        ViewsUpdatedBy?: number;
        ViewsUpdatedDate?: string;
        ViewsIsMachineSettings?: boolean;
        ViewsIsMachineSummary?: boolean;
        ViewsIslabelRoll?: boolean;
        ViewsIsCommandPanel?: boolean;
        ViewsIsFactorySetting?: boolean;
        ViewsDisplayObjectTypeId?: number;
        ViewsMachineId?: number;
        ViewsListDisplayId?: number;
        ViewsFormDisplayId?: number;
        ViewsButtonDisplayId?: number;
        ViewsRealtimeParameterDisplayId?: number;
        ViewsLineChartDisplayId?: number;
        ViewsPieChartDisplayId?: number;
        ViewsTreeDisplayId?: number;
        ViewsAttachmentDisplayId?: number;
        ViewsAlarmDisplayId?: number;
        ViewsNotificationDisplayId?: number;
        ViewsContainerDisplayId?: number;
    }

    export namespace DisplayObjectColorRow {
        export const idProperty = 'ColorId';
        export const nameProperty = 'Color';
        export const localTextPrefix = 'MachineCustomization.DisplayObjectColor';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export namespace Fields {
            export declare const ColorId;
            export declare const RangeFrom;
            export declare const RangeTo;
            export declare const Color;
            export declare const ViewsId;
            export declare const ViewsModuleId;
            export declare const ViewsViewName;
            export declare const ViewsIsAccessFieldWise;
            export declare const ViewsStatusId;
            export declare const ViewsCreatedBy;
            export declare const ViewsCreatedDate;
            export declare const ViewsUpdatedBy;
            export declare const ViewsUpdatedDate;
            export declare const ViewsIsMachineSettings;
            export declare const ViewsIsMachineSummary;
            export declare const ViewsIslabelRoll;
            export declare const ViewsIsCommandPanel;
            export declare const ViewsIsFactorySetting;
            export declare const ViewsDisplayObjectTypeId;
            export declare const ViewsMachineId;
            export declare const ViewsListDisplayId;
            export declare const ViewsFormDisplayId;
            export declare const ViewsButtonDisplayId;
            export declare const ViewsRealtimeParameterDisplayId;
            export declare const ViewsLineChartDisplayId;
            export declare const ViewsPieChartDisplayId;
            export declare const ViewsTreeDisplayId;
            export declare const ViewsAttachmentDisplayId;
            export declare const ViewsAlarmDisplayId;
            export declare const ViewsNotificationDisplayId;
            export declare const ViewsContainerDisplayId;
        }

        [
            'ColorId',
            'RangeFrom',
            'RangeTo',
            'Color',
            'ViewsId',
            'ViewsModuleId',
            'ViewsViewName',
            'ViewsIsAccessFieldWise',
            'ViewsStatusId',
            'ViewsCreatedBy',
            'ViewsCreatedDate',
            'ViewsUpdatedBy',
            'ViewsUpdatedDate',
            'ViewsIsMachineSettings',
            'ViewsIsMachineSummary',
            'ViewsIslabelRoll',
            'ViewsIsCommandPanel',
            'ViewsIsFactorySetting',
            'ViewsDisplayObjectTypeId',
            'ViewsMachineId',
            'ViewsListDisplayId',
            'ViewsFormDisplayId',
            'ViewsButtonDisplayId',
            'ViewsRealtimeParameterDisplayId',
            'ViewsLineChartDisplayId',
            'ViewsPieChartDisplayId',
            'ViewsTreeDisplayId',
            'ViewsAttachmentDisplayId',
            'ViewsAlarmDisplayId',
            'ViewsNotificationDisplayId',
            'ViewsContainerDisplayId'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}