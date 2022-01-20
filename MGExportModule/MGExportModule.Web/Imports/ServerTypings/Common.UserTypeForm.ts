namespace MGExportModule.Common {
    export interface UserTypeForm {
        CustomCode: Serenity.StringEditor;
        UserTypeName: Serenity.StringEditor;
        IsDelete: Serenity.BooleanEditor;
    }

    export class UserTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Common.UserType';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserTypeForm.init)  {
                UserTypeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(UserTypeForm, [
                    'CustomCode', w0,
                    'UserTypeName', w0,
                    'IsDelete', w1
                ]);
            }
        }
    }
}

