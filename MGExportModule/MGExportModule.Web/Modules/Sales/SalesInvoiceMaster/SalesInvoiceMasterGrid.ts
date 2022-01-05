
namespace MGExportModule.Sales {
    import fld = SalesInvoiceMasterRow.Fields;

    @Serenity.Decorators.registerClass()
    export class SalesInvoiceMasterGrid extends _Ext.GridBase<SalesInvoiceMasterRow, any> {
        protected getColumnsKey() { return 'Sales.SalesInvoiceMaster'; }
        protected getDialogType() { return SalesInvoiceMasterDialog; }
        protected getRowType() { return SalesInvoiceMasterRow; }
        protected getService() { return SalesInvoiceMasterService.baseUrl; }

        constructor(container: JQuery, options) {
            super(container, options);
        }
    }
}