
namespace MGExportModule.Common {

    @Serenity.Decorators.registerClass()
    export class CmnItemGroupGrid extends Serenity.EntityGrid<CmnItemGroupRow, any> {
        protected getColumnsKey() { return 'Common.CmnItemGroup'; }
        protected getDialogType() { return CmnItemGroupDialog; }
        protected getIdProperty() { return CmnItemGroupRow.idProperty; }
        protected getInsertPermission() { return CmnItemGroupRow.insertPermission; }
        protected getLocalTextPrefix() { return CmnItemGroupRow.localTextPrefix; }
        protected getService() { return CmnItemGroupService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}