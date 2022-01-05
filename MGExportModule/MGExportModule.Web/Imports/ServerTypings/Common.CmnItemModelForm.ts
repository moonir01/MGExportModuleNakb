namespace MGExportModule.Common {
    export interface CmnItemModelForm {
        CustomCode: Serenity.StringEditor;
        ModelName: Serenity.StringEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsDelete: Serenity.BooleanEditor;
    }

    export class CmnItemModelForm extends Serenity.PrefixedContext {
        static formKey = 'Common.CmnItemModel';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CmnItemModelForm.init)  {
                CmnItemModelForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.BooleanEditor;

                Q.initFormType(CmnItemModelForm, [
                    'CustomCode', w0,
                    'ModelName', w0,
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

