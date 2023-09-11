namespace CVC.Report {
    export namespace AuditLogArchiveService {
        export const baseUrl = 'Report/AuditLogArchive';

        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<AuditLogArchiveRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<AuditLogArchiveRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Retrieve = "Report/AuditLogArchive/Retrieve",
            List = "Report/AuditLogArchive/List"
        }

        [
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>AuditLogArchiveService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

