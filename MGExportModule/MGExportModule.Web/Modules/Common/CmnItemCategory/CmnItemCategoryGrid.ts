
namespace MGExportModule.Common {

    @Serenity.Decorators.registerClass()
    export class CmnItemCategoryGrid extends Serenity.EntityGrid<CmnItemCategoryRow, any> {
        protected getColumnsKey() { return 'Common.CmnItemCategory'; }
        protected getDialogType() { return CmnItemCategoryDialog; }
        protected getIdProperty() { return CmnItemCategoryRow.idProperty; }
        protected getInsertPermission() { return CmnItemCategoryRow.insertPermission; }
        protected getLocalTextPrefix() { return CmnItemCategoryRow.localTextPrefix; }
        protected getService() { return CmnItemCategoryService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}