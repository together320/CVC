
namespace CVC.MachineCustomization {
    export namespace DisplayObjectColorService {
        export const baseUrl = 'MachineCustomization/DisplayObjectColor';

        export declare function Create(request: Serenity.SaveRequest<DisplayObjectColorRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<DisplayObjectColorRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DisplayObjectColorRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DisplayObjectColorRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function FetchAllColumns(request: ColumnIdsRequest, onSuccess?: (response: Serenity.ListResponse<ColumnIDRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "MachineCustomization/DisplayObjectColor/Create",
            Update = "MachineCustomization/DisplayObjectColor/Update",
            Delete = "MachineCustomization/DisplayObjectColor/Delete",
            Retrieve = "MachineCustomization/DisplayObjectColor/Retrieve",
            List = "MachineCustomization/DisplayObjectColor/List",
            FetchAllColumns = "MachineCustomization/DisplayObjectColor/FetchAllColumns"
        }

        [
            'Create',
            'Update',
            'Delete',
            'Retrieve',
            'List',
            'FetchAllColumns'

        ].forEach(x => {
            (<any>DisplayObjectColorService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}