namespace CVC.MachineCustomization {
    export namespace SecondaryRelationshipService {
        export const baseUrl = 'MachineCustomization/SecondaryRelationship';

        export declare function Create(request: Serenity.SaveRequest<SecondaryRelationshipRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<SecondaryRelationshipRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<SecondaryRelationshipRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<SecondaryRelationshipRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "MachineCustomization/SecondaryRelationship/Create",
            Update = "MachineCustomization/SecondaryRelationship/Update",
            Delete = "MachineCustomization/SecondaryRelationship/Delete",
            Retrieve = "MachineCustomization/SecondaryRelationship/Retrieve",
            List = "MachineCustomization/SecondaryRelationship/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>SecondaryRelationshipService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

