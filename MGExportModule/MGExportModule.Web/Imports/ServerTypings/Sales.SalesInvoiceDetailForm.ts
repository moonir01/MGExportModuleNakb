namespace MGExportModule.Sales {
    export interface SalesInvoiceDetailForm {
        CustomCode: Serenity.StringEditor;
        ItemId: Serenity.LookupEditor;
        Quontity: Serenity.IntegerEditor;
        UnitPrice: Serenity.DecimalEditor;
        TotalPrice: Serenity.DecimalEditor;
        Coaid: Serenity.IntegerEditor;
        DrAmount: Serenity.DecimalEditor;
        CrAmount: Serenity.DecimalEditor;
        IsDelete: Serenity.BooleanEditor;
    }

    export class SalesInvoiceDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Sales.SalesInvoiceDetail';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SalesInvoiceDetailForm.init)  {
                SalesInvoiceDetailForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DecimalEditor;
                var w4 = s.BooleanEditor;

                Q.initFormType(SalesInvoiceDetailForm, [
                    'CustomCode', w0,
                    'ItemId', w1,
                    'Quontity', w2,
                    'UnitPrice', w3,
                    'TotalPrice', w3,
                    'Coaid', w2,
                    'DrAmount', w3,
                    'CrAmount', w3,
                    'IsDelete', w4
                ]);
            }
        }
    }
}

