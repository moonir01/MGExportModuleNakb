namespace MGExportModule.Common {
    export interface CmnItemBrandForm {
        CustomCode: Serenity.StringEditor;
        BrandName: Serenity.StringEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateTimeEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsDelete: Serenity.BooleanEditor;
    }

    export class CmnItemBrandForm extends Serenity.PrefixedContext {
        static formKey = 'Common.CmnItemBrand';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CmnItemBrandForm.init)  {
                CmnItemBrandForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DateTimeEditor;
                var w4 = s.BooleanEditor;

                Q.initFormType(CmnItemBrandForm, [
                    'CustomCode', w0,
                    'BrandName', w0,
                    'InsertDate', w1,
                    'InsertUserId', w2,
                    'UpdateDate', w3,
                    'UpdateUserId', w2,
                    'IsDelete', w4
                ]);
            }
        }
    }
}

