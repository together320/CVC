namespace CVC.MachineCustomization {
    export namespace RealtimeParameterDisplayService {
        export const baseUrl = 'MachineCustomization/RealtimeParameterDisplay';

        export declare function Create(request: Serenity.SaveRequest<RealtimeParameterDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<RealtimeParameterDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RealtimeParameterDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RealtimeParameterDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "MachineCustomization/RealtimeParameterDisplay/Create",
            Update = "MachineCustomization/RealtimeParameterDisplay/Update",
            Delete = "MachineCustomization/RealtimeParameterDisplay/Delete",
            Retrieve = "MachineCustomization/RealtimeParameterDisplay/Retrieve",
            List = "MachineCustomization/RealtimeParameterDisplay/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>RealtimeParameterDisplayService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

