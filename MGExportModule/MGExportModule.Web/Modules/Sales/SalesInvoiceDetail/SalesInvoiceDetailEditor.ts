

namespace MGExportModule.Sales {
    
    @Serenity.Decorators.registerClass()
    //export class AccBankBranchInformationEditor extends GridEditorBase<AccBankBranchInformationRow> {
    export class SalesInvoiceDetailEditor extends _Ext.GridEditorBase<SalesInvoiceDetailRow> {
        protected getColumnsKey() { return 'Sales.SalesInvoiceDetail'; }
        protected getDialogType() { return SalesInvoiceDetailDialog; }
        protected getLocalTextPrefix() { return SalesInvoiceDetailRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}