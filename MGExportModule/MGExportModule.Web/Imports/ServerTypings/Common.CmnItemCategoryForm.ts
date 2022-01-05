namespace MGExportModule.Common {
    export interface CmnItemCategoryForm {
        CustomCode: Serenity.StringEditor;
        CategoryName: Serenity.StringEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsDelete: Serenity.BooleanEditor;
    }

    export class CmnItemCategoryForm extends Serenity.PrefixedContext {
        static formKey = 'Common.CmnItemCategory';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CmnItemCategoryForm.init)  {
                CmnItemCategoryForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.BooleanEditor;

                Q.initFormType(CmnItemCategoryForm, [
                    'CustomCode', w0,
                    'CategoryName', w0,
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

