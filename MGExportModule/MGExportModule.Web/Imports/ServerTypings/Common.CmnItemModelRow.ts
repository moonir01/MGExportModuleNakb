namespace MGExportModule.Common {
    export interface CmnItemModelRow {
        ModelId?: number;
        CustomCode?: string;
        ModelName?: string;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        IsDelete?: boolean;
    }

    export namespace CmnItemModelRow {
        export const idProperty = 'ModelId';
        export const nameProperty = 'ModelName';
        export const localTextPrefix = 'Common.CmnItemModel';
        export const lookupKey = 'Common.CmnItemModel';

        export function getLookup(): Q.Lookup<CmnItemModelRow> {
            return Q.getLookup<CmnItemModelRow>('Common.CmnItemModel');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ModelId = "ModelId",
            CustomCode = "CustomCode",
            ModelName = "ModelName",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            IsDelete = "IsDelete"
        }
    }
}

