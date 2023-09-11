namespace CVC.Report {
    export namespace AuditLogService {
        export const baseUrl = 'Report/AuditLog';

        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<AuditLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<AuditLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Retrieve = "Report/AuditLog/Retrieve",
            List = "Report/AuditLog/List"
        }

        [
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>AuditLogService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

