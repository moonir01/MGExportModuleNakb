
namespace MGExportModule.Common {

    @Serenity.Decorators.registerClass()
    export class CmnItemMasterGrid extends Serenity.EntityGrid<CmnItemMasterRow, any> {
        protected getColumnsKey() { return 'Common.CmnItemMaster'; }
        protected getDialogType() { return CmnItemMasterDialog; }
        protected getIdProperty() { return CmnItemMasterRow.idProperty; }
        protected getInsertPermission() { return CmnItemMasterRow.insertPermission; }
        protected getLocalTextPrefix() { return CmnItemMasterRow.localTextPrefix; }
        protected getService() { return CmnItemMasterService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}