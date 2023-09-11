namespace CVC.MachineCustomization {
    export namespace LineMaintenanceScheduleService {
        export const baseUrl = 'MachineCustomization/LineMaintenanceSchedule';

        export declare function Create(request: Serenity.SaveRequest<LineMaintenanceScheduleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<LineMaintenanceScheduleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<LineMaintenanceScheduleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<LineMaintenanceScheduleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "MachineCustomization/LineMaintenanceSchedule/Create",
            Update = "MachineCustomization/LineMaintenanceSchedule/Update",
            Delete = "MachineCustomization/LineMaintenanceSchedule/Delete",
            Retrieve = "MachineCustomization/LineMaintenanceSchedule/Retrieve",
            List = "MachineCustomization/LineMaintenanceSchedule/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>LineMaintenanceScheduleService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

