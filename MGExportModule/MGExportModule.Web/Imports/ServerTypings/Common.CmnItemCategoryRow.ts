namespace MGExportModule.Common {
    export interface CmnItemCategoryRow {
        CategoryId?: number;
        CustomCode?: string;
        CategoryName?: string;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        IsDelete?: boolean;
    }

    export namespace CmnItemCategoryRow {
        export const idProperty = 'CategoryId';
        export const nameProperty = 'CustomCode';
        export const localTextPrefix = 'Common.CmnItemCategory';
        export const lookupKey = 'Common.CmnItemCategory';

        export function getLookup(): Q.Lookup<CmnItemCategoryRow> {
            return Q.getLookup<CmnItemCategoryRow>('Common.CmnItemCategory');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            CategoryId = "CategoryId",
            CustomCode = "CustomCode",
            CategoryName = "CategoryName",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            IsDelete = "IsDelete"
        }
    }
}

