namespace CVC.MachineCustomization {
    export namespace MachineService {
        export const baseUrl = 'MachineCustomization/Machine';

        export declare function Create(request: Serenity.SaveRequest<MachineRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<MachineRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function FetchAllTables(request: Serenity.ServiceRequest, onSuccess?: (response: Serenity.ListResponse<TableObjIDRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "MachineCustomization/Machine/Create",
            Update = "MachineCustomization/Machine/Update",
            Delete = "MachineCustomization/Machine/Delete",
            Retrieve = "MachineCustomization/Machine/Retrieve",
            List = "MachineCustomization/Machine/List",
            FetchAllTables = "MachineCustomization/Machine/FetchAllTables"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'FetchAllTables'
        ].forEach(x => {
            (<any>MachineService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

