namespace MGExportModule.Common {
    export interface CmnItemMasterForm {
        CustomCode: Serenity.StringEditor;
        ItemName: Serenity.StringEditor;
        ItemCategoryId: Serenity.LookupEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsDelete: Serenity.BooleanEditor;
        ModelId: Serenity.LookupEditor;
    }

    export class CmnItemMasterForm extends Serenity.PrefixedContext {
        static formKey = 'Common.CmnItemMaster';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CmnItemMasterForm.init)  {
                CmnItemMasterForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.DateEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.BooleanEditor;

                Q.initFormType(CmnItemMasterForm, [
                    'CustomCode', w0,
                    'ItemName', w0,
                    'ItemCategoryId', w1,
                    'InsertDate', w2,
                    'InsertUserId', w3,
                    'UpdateDate', w2,
                    'UpdateUserId', w3,
                    'IsDelete', w4,
                    'ModelId', w1
                ]);
            }
        }
    }
}

