namespace CVC.MachineCustomization {
    export namespace PrimaryRelationshipService {
        export const baseUrl = 'MachineCustomization/PrimaryRelationship';

        export declare function Create(request: Serenity.SaveRequest<PrimaryRelationshipRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<PrimaryRelationshipRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PrimaryRelationshipRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PrimaryRelationshipRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "MachineCustomization/PrimaryRelationship/Create",
            Update = "MachineCustomization/PrimaryRelationship/Update",
            Delete = "MachineCustomization/PrimaryRelationship/Delete",
            Retrieve = "MachineCustomization/PrimaryRelationship/Retrieve",
            List = "MachineCustomization/PrimaryRelationship/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>PrimaryRelationshipService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

