namespace MGExportModule.Common {
    export interface UserTypeRow {
        UserTypeId?: number;
        CustomCode?: string;
        UserTypeName?: string;
        IsDelete?: boolean;
    }

    export namespace UserTypeRow {
        export const idProperty = 'UserTypeId';
        export const nameProperty = 'UserTypeName';
        export const localTextPrefix = 'Common.UserType';
        export const lookupKey = 'Common.UserType';

        export function getLookup(): Q.Lookup<UserTypeRow> {
            return Q.getLookup<UserTypeRow>('Common.UserType');
        }
        export const deletePermission = 'Common:UserType:Delete';
        export const insertPermission = 'Common:UserType:Insert';
        export const readPermission = 'Common:UserType:Read';
        export const updatePermission = 'Common:UserType:Update';

        export declare const enum Fields {
            UserTypeId = "UserTypeId",
            CustomCode = "CustomCode",
            UserTypeName = "UserTypeName",
            IsDelete = "IsDelete"
        }
    }
}

