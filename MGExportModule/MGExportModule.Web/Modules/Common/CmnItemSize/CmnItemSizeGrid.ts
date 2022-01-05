
namespace MGExportModule.Common {

    @Serenity.Decorators.registerClass()
    export class CmnItemSizeGrid extends Serenity.EntityGrid<CmnItemSizeRow, any> {
        protected getColumnsKey() { return 'Common.CmnItemSize'; }
        protected getDialogType() { return CmnItemSizeDialog; }
        protected getIdProperty() { return CmnItemSizeRow.idProperty; }
        protected getInsertPermission() { return CmnItemSizeRow.insertPermission; }
        protected getLocalTextPrefix() { return CmnItemSizeRow.localTextPrefix; }
        protected getService() { return CmnItemSizeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}