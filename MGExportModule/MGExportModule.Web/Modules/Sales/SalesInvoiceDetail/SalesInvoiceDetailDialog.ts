
namespace MGExportModule.Sales {
    import fld = SalesInvoiceDetailRow.Fields;

    @Serenity.Decorators.registerClass()
    export class SalesInvoiceDetailDialog extends _Ext.DialogBase<SalesInvoiceDetailRow, any> {
        protected getFormKey() { return SalesInvoiceDetailForm.formKey; }
        protected getRowType() { return SalesInvoiceDetailRow; }
        protected getService() { return SalesInvoiceDetailService.baseUrl; }

        protected form = new SalesInvoiceDetailForm(this.idPrefix);

        constructor(options) {
            super(options);
        }

    }
}