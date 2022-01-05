namespace MGExportModule.Sales {
    export interface SalesInvoiceMasterForm {
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
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.DateEditor;
                var w3 = s.BooleanEditor;
                var w4 = SalesInvoiceDetailEditor;

                Q.initFormType(SalesInvoiceMasterForm, [
                    'CustomCode', w0,
                    'Description', w0,
                    'BuyerId', w1,
                    'SalesDate', w2,
                    'IsDelete', w3,
                    'SalesDetails', w4
                ]);
            }
        }
    }
}

