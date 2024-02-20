
namespace CVC.MachineCustomization {
    export interface DisplayObjectTypeColorRow {
        DotColorId?: number;
        DotColor?: string;
        Min?: number;
        Max?: number;
        DisplayObjectTypeId?: number;
        SubTypeId?: number;
    }

    export namespace DisplayObjectTypeColorRow {
        export const idProperty = 'DotColorId';
        export const nameProperty = 'DotColor';
        export const localTextPrefix = 'MachineCustomization.DisplayObjectTypeColor';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';
        
        export namespace Fields {
            export declare const DotColorId;
            export declare const DotColor;
            export declare const Min;
            export declare const Max;
            export declare const DisplayObjectTypeId;
            export declare const SubTypeId;
        }

        [
            'DotColorId',
            'DotColor',
            'Min',
            'Max',
            'DisplayObjectTypeId',
            'SubTypeId'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}
