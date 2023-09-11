namespace CVC.MachineCustomization {
    export namespace MachineHelpFileService {
        export const baseUrl = 'MachineCustomization/MachineHelpFile';

        export declare function Create(request: Serenity.SaveRequest<MachineHelpFileRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<MachineHelpFileRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineHelpFileRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineHelpFileRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "MachineCustomization/MachineHelpFile/Create",
            Update = "MachineCustomization/MachineHelpFile/Update",
            Delete = "MachineCustomization/MachineHelpFile/Delete",
            Retrieve = "MachineCustomization/MachineHelpFile/Retrieve",
            List = "MachineCustomization/MachineHelpFile/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>MachineHelpFileService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

