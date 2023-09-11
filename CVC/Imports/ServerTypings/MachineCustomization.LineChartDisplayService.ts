namespace CVC.MachineCustomization {
    export namespace LineChartDisplayService {
        export const baseUrl = 'MachineCustomization/LineChartDisplay';

        export declare function Create(request: Serenity.SaveRequest<LineChartDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<LineChartDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<LineChartDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<LineChartDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "MachineCustomization/LineChartDisplay/Create",
            Update = "MachineCustomization/LineChartDisplay/Update",
            Delete = "MachineCustomization/LineChartDisplay/Delete",
            Retrieve = "MachineCustomization/LineChartDisplay/Retrieve",
            List = "MachineCustomization/LineChartDisplay/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>LineChartDisplayService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

