
namespace MGExportModule.Common {

    @Serenity.Decorators.registerClass()
    export class CmnItemMasterDialog extends Serenity.EntityDialog<CmnItemMasterRow, any> {
        protected getFormKey() { return CmnItemMasterForm.formKey; }
        protected getIdProperty() { return CmnItemMasterRow.idProperty; }
        protected getLocalTextPrefix() { return CmnItemMasterRow.localTextPrefix; }
        protected getNameProperty() { return CmnItemMasterRow.nameProperty; }
        protected getService() { return CmnItemMasterService.baseUrl; }
        protected getDeletePermission() { return CmnItemMasterRow.deletePermission; }
        protected getInsertPermission() { return CmnItemMasterRow.insertPermission; }
        protected getUpdatePermission() { return CmnItemMasterRow.updatePermission; }

        protected form = new CmnItemMasterForm(this.idPrefix);

    }
}