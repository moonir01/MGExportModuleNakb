
namespace MGExportModule.Common {

    @Serenity.Decorators.registerClass()
    export class CmnItemBrandGrid extends Serenity.EntityGrid<CmnItemBrandRow, any> {
        protected getColumnsKey() { return 'Common.CmnItemBrand'; }
        protected getDialogType() { return CmnItemBrandDialog; }
        protected getIdProperty() { return CmnItemBrandRow.idProperty; }
        protected getInsertPermission() { return CmnItemBrandRow.insertPermission; }
        protected getLocalTextPrefix() { return CmnItemBrandRow.localTextPrefix; }
        protected getService() { return CmnItemBrandService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}