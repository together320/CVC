namespace CVC.MachineCustomization {
    export namespace MachineParameterService {
        export const baseUrl = 'MachineCustomization/MachineParameter';

        export declare function Create(request: Serenity.SaveRequest<MachineParameterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<MachineParameterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineParameterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineParameterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function FetchAllColumns(request: ColumnIdsRequest, onSuccess?: (response: Serenity.ListResponse<ColumnIDRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "MachineCustomization/MachineParameter/Create",
            Update = "MachineCustomization/MachineParameter/Update",
            Delete = "MachineCustomization/MachineParameter/Delete",
            Retrieve = "MachineCustomization/MachineParameter/Retrieve",
            List = "MachineCustomization/MachineParameter/List",
            FetchAllColumns = "MachineCustomization/MachineParameter/FetchAllColumns"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'FetchAllColumns'
        ].forEach(x => {
            (<any>MachineParameterService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

