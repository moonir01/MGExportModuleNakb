namespace MGExportModule.Common {
    export interface UserInfoRow {
        UserId?: number;
        CustomCode?: string;
        UserFullName?: string;
        UserTypeId?: number;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        IsDelete?: boolean;
        UserImage?: string;
    }

    export namespace UserInfoRow {
        export const idProperty = 'UserId';
        export const nameProperty = 'CustomCode';
        export const localTextPrefix = 'Common.UserInfo';
        export const deletePermission = 'Administration:General:Delete';
        export const insertPermission = 'Administration:General:Insert';
        export const readPermission = 'Administration:General:View';
        export const updatePermission = 'Administration:General:Modify';

        export declare const enum Fields {
            UserId = "UserId",
            CustomCode = "CustomCode",
            UserFullName = "UserFullName",
            UserTypeId = "UserTypeId",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            IsDelete = "IsDelete",
            UserImage = "UserImage"
        }
    }
}

