namespace MGExportModule.Common {
    export interface CmnItemGroupForm {
        CustomCode: Serenity.StringEditor;
        GroupName: Serenity.StringEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsDelete: Serenity.BooleanEditor;
    }

    export class CmnItemGroupForm extends Serenity.PrefixedContext {
        static formKey = 'Common.CmnItemGroup';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CmnItemGroupForm.init)  {
                CmnItemGroupForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.BooleanEditor;

                Q.initFormType(CmnItemGroupForm, [
                    'CustomCode', w0,
                    'GroupName', w0,
                    'InsertDate', w1,
                    'InsertUserId', w2,
                    'UpdateDate', w1,
                    'UpdateUserId', w2,
                    'IsDelete', w3
                ]);
            }
        }
    }
}

