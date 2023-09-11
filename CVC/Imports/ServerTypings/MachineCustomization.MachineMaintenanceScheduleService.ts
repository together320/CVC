namespace CVC.MachineCustomization {
    export namespace MachineMaintenanceScheduleService {
        export const baseUrl = 'MachineCustomization/MachineMaintenanceSchedule';

        export declare function Create(request: Serenity.SaveRequest<MachineMaintenanceScheduleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<MachineMaintenanceScheduleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineMaintenanceScheduleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineMaintenanceScheduleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "MachineCustomization/MachineMaintenanceSchedule/Create",
            Update = "MachineCustomization/MachineMaintenanceSchedule/Update",
            Delete = "MachineCustomization/MachineMaintenanceSchedule/Delete",
            Retrieve = "MachineCustomization/MachineMaintenanceSchedule/Retrieve",
            List = "MachineCustomization/MachineMaintenanceSchedule/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>MachineMaintenanceScheduleService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

