namespace CVC.MachineCustomization {
    export namespace RecipeSettingsParameterService {
        export const baseUrl = 'MachineCustomization/RecipeSettingsParameter';

        export declare function Create(request: Serenity.SaveRequest<RecipeSettingsParameterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<RecipeSettingsParameterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RecipeSettingsParameterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RecipeSettingsParameterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "MachineCustomization/RecipeSettingsParameter/Create",
            Update = "MachineCustomization/RecipeSettingsParameter/Update",
            Delete = "MachineCustomization/RecipeSettingsParameter/Delete",
            Retrieve = "MachineCustomization/RecipeSettingsParameter/Retrieve",
            List = "MachineCustomization/RecipeSettingsParameter/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>RecipeSettingsParameterService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

