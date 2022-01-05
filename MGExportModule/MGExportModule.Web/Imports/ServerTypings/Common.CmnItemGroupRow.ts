namespace MGExportModule.Common {
    export interface CmnItemGroupRow {
        GroupId?: number;
        CustomCode?: string;
        GroupName?: string;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        IsDelete?: boolean;
    }

    export namespace CmnItemGroupRow {
        export const idProperty = 'GroupId';
        export const nameProperty = 'CustomCode';
        export const localTextPrefix = 'Common.CmnItemGroup';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            GroupId = "GroupId",
            CustomCode = "CustomCode",
            GroupName = "GroupName",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            IsDelete = "IsDelete"
        }
    }
}

