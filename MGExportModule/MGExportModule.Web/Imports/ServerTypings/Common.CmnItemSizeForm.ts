namespace MGExportModule.Common {
    export interface CmnItemSizeForm {
        CustomCode: Serenity.StringEditor;
        SizeName: Serenity.StringEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsDelete: Serenity.BooleanEditor;
    }

    export class CmnItemSizeForm extends Serenity.PrefixedContext {
        static formKey = 'Common.CmnItemSize';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CmnItemSizeForm.init)  {
                CmnItemSizeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.BooleanEditor;

                Q.initFormType(CmnItemSizeForm, [
                    'CustomCode', w0,
                    'SizeName', w0,
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

