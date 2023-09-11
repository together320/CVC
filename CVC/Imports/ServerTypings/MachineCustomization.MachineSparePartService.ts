namespace CVC.MachineCustomization {
    export namespace MachineSparePartService {
        export const baseUrl = 'MachineCustomization/MachineSparePart';

        export declare function Create(request: Serenity.SaveRequest<MachineSparePartRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<MachineSparePartRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineSparePartRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineSparePartRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "MachineCustomization/MachineSparePart/Create",
            Update = "MachineCustomization/MachineSparePart/Update",
            Delete = "MachineCustomization/MachineSparePart/Delete",
            Retrieve = "MachineCustomization/MachineSparePart/Retrieve",
            List = "MachineCustomization/MachineSparePart/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>MachineSparePartService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

