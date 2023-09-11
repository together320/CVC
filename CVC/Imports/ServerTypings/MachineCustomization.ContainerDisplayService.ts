namespace CVC.MachineCustomization {
    export namespace ContainerDisplayService {
        export const baseUrl = 'MachineCustomization/ContainerDisplay';

        export declare function Create(request: Serenity.SaveRequest<ContainerDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ContainerDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ContainerDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ContainerDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "MachineCustomization/ContainerDisplay/Create",
            Update = "MachineCustomization/ContainerDisplay/Update",
            Delete = "MachineCustomization/ContainerDisplay/Delete",
            Retrieve = "MachineCustomization/ContainerDisplay/Retrieve",
            List = "MachineCustomization/ContainerDisplay/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ContainerDisplayService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

