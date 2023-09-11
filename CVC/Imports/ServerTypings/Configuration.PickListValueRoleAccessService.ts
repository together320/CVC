namespace CVC.Configuration {
    export namespace PickListValueRoleAccessService {
        export const baseUrl = 'Configuration/PickListValueRoleAccess';

        export declare function Create(request: Serenity.SaveRequest<PickListValueRoleAccessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<PickListValueRoleAccessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PickListValueRoleAccessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PickListValueRoleAccessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Configuration/PickListValueRoleAccess/Create",
            Update = "Configuration/PickListValueRoleAccess/Update",
            Delete = "Configuration/PickListValueRoleAccess/Delete",
            Retrieve = "Configuration/PickListValueRoleAccess/Retrieve",
            List = "Configuration/PickListValueRoleAccess/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>PickListValueRoleAccessService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

