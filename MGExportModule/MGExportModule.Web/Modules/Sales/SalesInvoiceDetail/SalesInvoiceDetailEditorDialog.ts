
namespace MGExportModule.Sales {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class SalesInvoiceDetailEditorDialog extends _Ext.EditorDialogBase<SalesInvoiceDetailRow> {
        protected getFormKey() { return SalesInvoiceDetailForm.formKey; }
        protected getLocalTextPrefix() { return SalesInvoiceDetailRow.localTextPrefix; }
        protected getNameProperty() { return SalesInvoiceDetailRow.nameProperty; }
        protected form = new SalesInvoiceDetailForm(this.idPrefix);
        constructor() {
            super();
            
        }


        protected afterLoadEntity() {
            super.afterLoadEntity();

            //this.form.UnitPrice.change(p => {

            //    this.form.TotalPrice.value = (this.form.Quontity.value || 0) * this.form.UnitPrice.value || 0;
            //});

            this.form.UnitPrice.changeSelect2(p => {

                this.form.TotalPrice.value = (this.form.Quontity.value || 0) * this.form.UnitPrice.value || 0;
            });
        }
    }
}