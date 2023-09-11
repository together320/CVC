namespace CVC.ExternalApplicationInterface {
    export namespace ProtocolService {
        export const baseUrl = 'ExternalApplicationInterface/Protocol';

        export declare function Create(request: Serenity.SaveRequest<ProtocolRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ProtocolRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ProtocolRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ProtocolRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "ExternalApplicationInterface/Protocol/Create",
            Update = "ExternalApplicationInterface/Protocol/Update",
            Delete = "ExternalApplicationInterface/Protocol/Delete",
            Retrieve = "ExternalApplicationInterface/Protocol/Retrieve",
            List = "ExternalApplicationInterface/Protocol/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ProtocolService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

