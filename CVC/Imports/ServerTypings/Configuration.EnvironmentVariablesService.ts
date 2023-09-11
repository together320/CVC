namespace CVC.Configuration {
    export namespace EnvironmentVariablesService {
        export const baseUrl = 'Configuration/EnvironmentVariables';

        export declare function Create(request: Serenity.SaveRequest<EnvironmentVariablesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<EnvironmentVariablesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<EnvironmentVariablesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<EnvironmentVariablesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Configuration/EnvironmentVariables/Create",
            Update = "Configuration/EnvironmentVariables/Update",
            Delete = "Configuration/EnvironmentVariables/Delete",
            Retrieve = "Configuration/EnvironmentVariables/Retrieve",
            List = "Configuration/EnvironmentVariables/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>EnvironmentVariablesService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

