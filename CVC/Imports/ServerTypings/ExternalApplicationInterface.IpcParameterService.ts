namespace CVC.ExternalApplicationInterface {
    export namespace IpcParameterService {
        export const baseUrl = 'ExternalApplicationInterface/IpcParameter';

        export declare function Create(request: Serenity.SaveRequest<IpcParameterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<IpcParameterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<IpcParameterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<IpcParameterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "ExternalApplicationInterface/IpcParameter/Create",
            Update = "ExternalApplicationInterface/IpcParameter/Update",
            Delete = "ExternalApplicationInterface/IpcParameter/Delete",
            Retrieve = "ExternalApplicationInterface/IpcParameter/Retrieve",
            List = "ExternalApplicationInterface/IpcParameter/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>IpcParameterService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

