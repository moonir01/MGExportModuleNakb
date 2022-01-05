
namespace MGExportModule.Common {

    @Serenity.Decorators.registerClass()
    export class CmnItemModelGrid extends Serenity.EntityGrid<CmnItemModelRow, any> {
        protected getColumnsKey() { return 'Common.CmnItemModel'; }
        protected getDialogType() { return CmnItemModelDialog; }
        protected getIdProperty() { return CmnItemModelRow.idProperty; }
        protected getInsertPermission() { return CmnItemModelRow.insertPermission; }
        protected getLocalTextPrefix() { return CmnItemModelRow.localTextPrefix; }
        protected getService() { return CmnItemModelService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}