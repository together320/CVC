namespace CVC.ExternalApplicationInterface {
    export namespace MachineCommunicationService {
        export const baseUrl = 'ExternalApplicationInterface/MachineCommunication';

        export declare function Create(request: Serenity.SaveRequest<MachineCommunicationRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<MachineCommunicationRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineCommunicationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineCommunicationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "ExternalApplicationInterface/MachineCommunication/Create",
            Update = "ExternalApplicationInterface/MachineCommunication/Update",
            Delete = "ExternalApplicationInterface/MachineCommunication/Delete",
            Retrieve = "ExternalApplicationInterface/MachineCommunication/Retrieve",
            List = "ExternalApplicationInterface/MachineCommunication/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>MachineCommunicationService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

