
namespace MGExportModule.Common {

    @Serenity.Decorators.registerClass()
    export class CmnItemSizeDialog extends Serenity.EntityDialog<CmnItemSizeRow, any> {
        protected getFormKey() { return CmnItemSizeForm.formKey; }
        protected getIdProperty() { return CmnItemSizeRow.idProperty; }
        protected getLocalTextPrefix() { return CmnItemSizeRow.localTextPrefix; }
        protected getNameProperty() { return CmnItemSizeRow.nameProperty; }
        protected getService() { return CmnItemSizeService.baseUrl; }
        protected getDeletePermission() { return CmnItemSizeRow.deletePermission; }
        protected getInsertPermission() { return CmnItemSizeRow.insertPermission; }
        protected getUpdatePermission() { return CmnItemSizeRow.updatePermission; }

        protected form = new CmnItemSizeForm(this.idPrefix);

    }
}