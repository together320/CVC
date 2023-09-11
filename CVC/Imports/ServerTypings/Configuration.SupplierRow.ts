namespace CVC.Configuration {
    export interface SupplierRow {
        SupplierId?: number;
        SupplierName?: string;
        SupplierAddress?: string;
        CityId?: number;
        PinCode?: string;
        MobileCode?: number;
        MobileNumber?: number;
        StatusId?: number;
        StatusStatusName?: string;
        CityCountry?: string;
        CityState?: string;
        City?: string;
        CityStatusId?: number;
        CityCreatedBy?: number;
        CityCreatedDate?: string;
        CityUpdatedBy?: number;
        CityUpdatedDate?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace SupplierRow {
        export const idProperty = 'SupplierId';
        export const nameProperty = 'SupplierName';
        export const localTextPrefix = 'Configuration.Supplier';
        export const lookupKey = 'Configuration.Supplier';

        export function getLookup(): Q.Lookup<SupplierRow> {
            return Q.getLookup<SupplierRow>('Configuration.Supplier');
        }
        export const deletePermission = 'Configuration:Supplier:Modify';
        export const insertPermission = 'Configuration:Supplier:Modify';
        export const readPermission = 'Configuration:Supplier:Read';
        export const updatePermission = 'Configuration:Supplier:Modify';

        export declare const enum Fields {
            SupplierId = "SupplierId",
            SupplierName = "SupplierName",
            SupplierAddress = "SupplierAddress",
            CityId = "CityId",
            PinCode = "PinCode",
            MobileCode = "MobileCode",
            MobileNumber = "MobileNumber",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CityCountry = "CityCountry",
            CityState = "CityState",
            City = "City",
            CityStatusId = "CityStatusId",
            CityCreatedBy = "CityCreatedBy",
            CityCreatedDate = "CityCreatedDate",
            CityUpdatedBy = "CityUpdatedBy",
            CityUpdatedDate = "CityUpdatedDate",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

