namespace MGExportModule.Common {
    export interface CmnItemMasterRow {
        ItemId?: number;
        CustomCode?: string;
        ItemName?: string;
        ItemCategoryId?: number;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        IsDelete?: boolean;
        ModelId?: number;
        ItemCategoryCustomCode?: string;
        ItemCategoryCategoryName?: string;
        ItemCategoryInsertDate?: string;
        ItemCategoryInsertUserId?: number;
        ItemCategoryUpdateDate?: string;
        ItemCategoryUpdateUserId?: number;
        ItemCategoryIsDelete?: boolean;
        ModelCustomCode?: string;
        ModelModelName?: string;
        ModelInsertDate?: string;
        ModelInsertUserId?: number;
        ModelUpdateDate?: string;
        ModelUpdateUserId?: number;
        ModelIsDelete?: boolean;
    }

    export namespace CmnItemMasterRow {
        export const idProperty = 'ItemId';
        export const nameProperty = 'CustomCode';
        export const localTextPrefix = 'Common.CmnItemMaster';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ItemId = "ItemId",
            CustomCode = "CustomCode",
            ItemName = "ItemName",
            ItemCategoryId = "ItemCategoryId",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            IsDelete = "IsDelete",
            ModelId = "ModelId",
            ItemCategoryCustomCode = "ItemCategoryCustomCode",
            ItemCategoryCategoryName = "ItemCategoryCategoryName",
            ItemCategoryInsertDate = "ItemCategoryInsertDate",
            ItemCategoryInsertUserId = "ItemCategoryInsertUserId",
            ItemCategoryUpdateDate = "ItemCategoryUpdateDate",
            ItemCategoryUpdateUserId = "ItemCategoryUpdateUserId",
            ItemCategoryIsDelete = "ItemCategoryIsDelete",
            ModelCustomCode = "ModelCustomCode",
            ModelModelName = "ModelModelName",
            ModelInsertDate = "ModelInsertDate",
            ModelInsertUserId = "ModelInsertUserId",
            ModelUpdateDate = "ModelUpdateDate",
            ModelUpdateUserId = "ModelUpdateUserId",
            ModelIsDelete = "ModelIsDelete"
        }
    }
}

