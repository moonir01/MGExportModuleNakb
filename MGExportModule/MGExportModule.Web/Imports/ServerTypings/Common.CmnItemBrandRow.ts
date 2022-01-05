namespace MGExportModule.Common {
    export interface CmnItemBrandRow {
        BrandId?: number;
        CustomCode?: string;
        BrandName?: string;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        IsDelete?: boolean;
    }

    export namespace CmnItemBrandRow {
        export const idProperty = 'BrandId';
        export const nameProperty = 'CustomCode';
        export const localTextPrefix = 'Common.CmnItemBrand';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            BrandId = "BrandId",
            CustomCode = "CustomCode",
            BrandName = "BrandName",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            IsDelete = "IsDelete"
        }
    }
}

