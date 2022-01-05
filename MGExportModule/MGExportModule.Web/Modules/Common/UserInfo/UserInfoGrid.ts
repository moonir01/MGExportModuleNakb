
namespace MGExportModule.Common {

    @Serenity.Decorators.registerClass()
    export class UserInfoGrid extends Serenity.EntityGrid<UserInfoRow, any> {
        protected getColumnsKey() { return 'Common.UserInfo'; }
        protected getDialogType() { return UserInfoDialog; }
        protected getIdProperty() { return UserInfoRow.idProperty; }
        protected getInsertPermission() { return UserInfoRow.insertPermission; }
        protected getLocalTextPrefix() { return UserInfoRow.localTextPrefix; }
        protected getService() { return UserInfoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}