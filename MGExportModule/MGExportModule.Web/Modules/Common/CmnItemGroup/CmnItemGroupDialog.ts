
namespace MGExportModule.Common {

    @Serenity.Decorators.registerClass()
    export class CmnItemGroupDialog extends Serenity.EntityDialog<CmnItemGroupRow, any> {
        protected getFormKey() { return CmnItemGroupForm.formKey; }
        protected getIdProperty() { return CmnItemGroupRow.idProperty; }
        protected getLocalTextPrefix() { return CmnItemGroupRow.localTextPrefix; }
        protected getNameProperty() { return CmnItemGroupRow.nameProperty; }
        protected getService() { return CmnItemGroupService.baseUrl; }
        protected getDeletePermission() { return CmnItemGroupRow.deletePermission; }
        protected getInsertPermission() { return CmnItemGroupRow.insertPermission; }
        protected getUpdatePermission() { return CmnItemGroupRow.updatePermission; }

        protected form = new CmnItemGroupForm(this.idPrefix);

    }
}