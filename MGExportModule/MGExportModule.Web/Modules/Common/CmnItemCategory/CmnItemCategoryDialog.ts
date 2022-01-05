
namespace MGExportModule.Common {

    @Serenity.Decorators.registerClass()
    export class CmnItemCategoryDialog extends Serenity.EntityDialog<CmnItemCategoryRow, any> {
        protected getFormKey() { return CmnItemCategoryForm.formKey; }
        protected getIdProperty() { return CmnItemCategoryRow.idProperty; }
        protected getLocalTextPrefix() { return CmnItemCategoryRow.localTextPrefix; }
        protected getNameProperty() { return CmnItemCategoryRow.nameProperty; }
        protected getService() { return CmnItemCategoryService.baseUrl; }
        protected getDeletePermission() { return CmnItemCategoryRow.deletePermission; }
        protected getInsertPermission() { return CmnItemCategoryRow.insertPermission; }
        protected getUpdatePermission() { return CmnItemCategoryRow.updatePermission; }

        protected form = new CmnItemCategoryForm(this.idPrefix);

    }
}