namespace MGExportModule.Sales {
    export interface SalesInvoiceMasterForm {
        Id: Serenity.IntegerEditor;
        CustomCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        BuyerId: Serenity.LookupEditor;
        SalesDate: Serenity.DateEditor;
        IsDelete: Serenity.BooleanEditor;
        SalesDetails: SalesInvoiceDetailEditor;
    }

    export class SalesInvoiceMasterForm extends Serenity.PrefixedContext {
        static formKey = 'Sales.SalesInvoiceMaster';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SalesInvoiceMasterForm.init)  {
                SalesInvoiceMasterForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.LookupEditor;
                var w3 = s.DateEditor;
                var w4 = s.BooleanEditor;
                var w5 = SalesInvoiceDetailEditor;

                Q.initFormType(SalesInvoiceMasterForm, [
                    'Id', w0,
                    'CustomCode', w1,
                    'Description', w1,
                    'BuyerId', w2,
                    'SalesDate', w3,
                    'IsDelete', w4,
                    'SalesDetails', w5
                ]);
            }
        }
    }
}

