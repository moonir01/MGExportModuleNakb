
namespace MGExportModule.Common {

    @Serenity.Decorators.registerClass()
    export class CmnItemBrandDialog extends Serenity.EntityDialog<CmnItemBrandRow, any> {
        protected getFormKey() { return CmnItemBrandForm.formKey; }
        protected getIdProperty() { return CmnItemBrandRow.idProperty; }
        protected getLocalTextPrefix() { return CmnItemBrandRow.localTextPrefix; }
        protected getNameProperty() { return CmnItemBrandRow.nameProperty; }
        protected getService() { return CmnItemBrandService.baseUrl; }
        protected getDeletePermission() { return CmnItemBrandRow.deletePermission; }
        protected getInsertPermission() { return CmnItemBrandRow.insertPermission; }
        protected getUpdatePermission() { return CmnItemBrandRow.updatePermission; }

        protected form = new CmnItemBrandForm(this.idPrefix);
        protected afterLoadEntity() {
            super.afterLoadEntity();

            if (this.isNew()) {
                CmnItemBrandService.GetCustomCode({
                    CustomerId: "SSS"
                }, r => {
                    this.form.CustomCode.value = String(r.CustomCode);
                });
            }

            this.form.CustomCode.change(p => {
                this.form.BrandName.value = this.form.CustomCode.value;
            });



        }
    }
}