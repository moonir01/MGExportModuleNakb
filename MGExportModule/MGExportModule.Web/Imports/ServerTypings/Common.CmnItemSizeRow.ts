namespace MGExportModule.Common {
    export interface CmnItemSizeRow {
        SizeId?: number;
        CustomCode?: string;
        SizeName?: string;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        IsDelete?: boolean;
    }

    export namespace CmnItemSizeRow {
        export const idProperty = 'SizeId';
        export const nameProperty = 'CustomCode';
        export const localTextPrefix = 'Common.CmnItemSize';
        export const deletePermission = 'Administration:General:Delete';
        export const insertPermission = 'Administration:General:Insert';
        export const readPermission = 'Administration:General:View';
        export const updatePermission = 'Administration:General:Modify';

        export declare const enum Fields {
            SizeId = "SizeId",
            CustomCode = "CustomCode",
            SizeName = "SizeName",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            IsDelete = "IsDelete"
        }
    }
}

