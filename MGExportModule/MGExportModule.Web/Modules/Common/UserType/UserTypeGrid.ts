
namespace MGExportModule.Common {
    import fld = UserTypeRow.Fields;

    @Serenity.Decorators.registerClass()
    export class UserTypeGrid extends _Ext.GridBase<UserTypeRow, any> {
        protected getColumnsKey() { return 'Common.UserType'; }
        protected getDialogType() { return UserTypeDialog; }
        protected getRowType() { return UserTypeRow; }
        protected getService() { return UserTypeService.baseUrl; }

        constructor(container: JQuery, options) {
            super(container, options);
        }
    }
}