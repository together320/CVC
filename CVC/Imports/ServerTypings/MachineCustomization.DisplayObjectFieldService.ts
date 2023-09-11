namespace CVC.MachineCustomization {
    export namespace DisplayObjectFieldService {
        export const baseUrl = 'MachineCustomization/DisplayObjectField';

        export declare function Create(request: Serenity.SaveRequest<DisplayObjectFieldRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<DisplayObjectFieldRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DisplayObjectFieldRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DisplayObjectFieldRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "MachineCustomization/DisplayObjectField/Create",
            Update = "MachineCustomization/DisplayObjectField/Update",
            Delete = "MachineCustomization/DisplayObjectField/Delete",
            Retrieve = "MachineCustomization/DisplayObjectField/Retrieve",
            List = "MachineCustomization/DisplayObjectField/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>DisplayObjectFieldService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

