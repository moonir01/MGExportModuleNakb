namespace MGExportModule.Common {
    export interface UserInfoForm {
        CustomCode: Serenity.StringEditor;
        UserFullName: Serenity.StringEditor;
        UserTypeId: Serenity.LookupEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsDelete: Serenity.BooleanEditor;
        UserImage: Serenity.ImageUploadEditor;
    }

    export class UserInfoForm extends Serenity.PrefixedContext {
        static formKey = 'Common.UserInfo';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserInfoForm.init)  {
                UserInfoForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.DateEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.BooleanEditor;
                var w5 = s.ImageUploadEditor;

                Q.initFormType(UserInfoForm, [
                    'CustomCode', w0,
                    'UserFullName', w0,
                    'UserTypeId', w1,
                    'InsertDate', w2,
                    'InsertUserId', w3,
                    'UpdateDate', w2,
                    'UpdateUserId', w3,
                    'IsDelete', w4,
                    'UserImage', w5
                ]);
            }
        }
    }
}

