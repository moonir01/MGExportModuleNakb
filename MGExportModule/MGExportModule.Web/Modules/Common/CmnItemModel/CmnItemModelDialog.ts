
namespace MGExportModule.Common {

    @Serenity.Decorators.registerClass()
    export class CmnItemModelDialog extends Serenity.EntityDialog<CmnItemModelRow, any> {
        protected getFormKey() { return CmnItemModelForm.formKey; }
        protected getIdProperty() { return CmnItemModelRow.idProperty; }
        protected getLocalTextPrefix() { return CmnItemModelRow.localTextPrefix; }
        protected getNameProperty() { return CmnItemModelRow.nameProperty; }
        protected getService() { return CmnItemModelService.baseUrl; }
        protected getDeletePermission() { return CmnItemModelRow.deletePermission; }
        protected getInsertPermission() { return CmnItemModelRow.insertPermission; }
        protected getUpdatePermission() { return CmnItemModelRow.updatePermission; }

        protected form = new CmnItemModelForm(this.idPrefix);

    }
}