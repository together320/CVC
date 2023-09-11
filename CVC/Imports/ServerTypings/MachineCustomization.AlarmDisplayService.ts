namespace CVC.MachineCustomization {
    export namespace AlarmDisplayService {
        export const baseUrl = 'MachineCustomization/AlarmDisplay';

        export declare function Create(request: Serenity.SaveRequest<AlarmDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<AlarmDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<AlarmDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<AlarmDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "MachineCustomization/AlarmDisplay/Create",
            Update = "MachineCustomization/AlarmDisplay/Update",
            Delete = "MachineCustomization/AlarmDisplay/Delete",
            Retrieve = "MachineCustomization/AlarmDisplay/Retrieve",
            List = "MachineCustomization/AlarmDisplay/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>AlarmDisplayService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

