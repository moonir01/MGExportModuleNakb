namespace MGExportModule.Common {
    export interface UserInfoForm {
        CustomCode: Serenity.StringEditor;
        UserFullName: Serenity.StringEditor;
        UserTypeId: Serenity.IntegerEditor;
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
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;
                var w3 = s.BooleanEditor;
                var w4 = s.ImageUploadEditor;

                Q.initFormType(UserInfoForm, [
                    'CustomCode', w0,
                    'UserFullName', w0,
                    'UserTypeId', w1,
                    'InsertDate', w2,
                    'InsertUserId', w1,
                    'UpdateDate', w2,
                    'UpdateUserId', w1,
                    'IsDelete', w3,
                    'UserImage', w4
                ]);
            }
        }
    }
}

