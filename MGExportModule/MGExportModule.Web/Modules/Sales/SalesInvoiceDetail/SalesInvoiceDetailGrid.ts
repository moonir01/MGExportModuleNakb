
namespace MGExportModule.Sales {
    import fld = SalesInvoiceDetailRow.Fields;

    @Serenity.Decorators.registerClass()
    export class SalesInvoiceDetailGrid extends _Ext.GridBase<SalesInvoiceDetailRow, any> {
        protected getColumnsKey() { return 'Sales.SalesInvoiceDetail'; }
        protected getDialogType() { return SalesInvoiceDetailDialog; }
        protected getRowType() { return SalesInvoiceDetailRow; }
        protected getService() { return SalesInvoiceDetailService.baseUrl; }

        constructor(container: JQuery, options) {
            super(container, options);
        }
    }
}