
namespace MGExportModule.Sales {
    import fld = SalesInvoiceMasterRow.Fields;

    @Serenity.Decorators.registerClass()
    export class SalesInvoiceMasterDialog extends _Ext.DialogBase<SalesInvoiceMasterRow, any> {
        protected getFormKey() { return SalesInvoiceMasterForm.formKey; }
        protected getRowType() { return SalesInvoiceMasterRow; }
        protected getService() { return SalesInvoiceMasterService.baseUrl; }

        protected form = new SalesInvoiceMasterForm(this.idPrefix);

        constructor(options) {
            super(options);
        }

    }
}