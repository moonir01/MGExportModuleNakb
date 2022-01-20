
namespace MGExportModule.Common {

    @Serenity.Decorators.registerClass()
    export class UserInfoDialog extends Serenity.EntityDialog<UserInfoRow, any> {
        protected getFormKey() { return UserInfoForm.formKey; }
        protected getIdProperty() { return UserInfoRow.idProperty; }
        protected getLocalTextPrefix() { return UserInfoRow.localTextPrefix; }
        protected getNameProperty() { return UserInfoRow.nameProperty; }
        protected getService() { return UserInfoService.baseUrl; }
        protected getDeletePermission() { return UserInfoRow.deletePermission; }
        protected getInsertPermission() { return UserInfoRow.insertPermission; }
        protected getUpdatePermission() { return UserInfoRow.updatePermission; }

        protected form = new UserInfoForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();

            if (this.isNew()) {
                UserInfoService.GetCustomCode({
                  
                }, r => {
                    this.form.CustomCode.value = String(r.CustomCode);
                });
            }

      



        }

    }
}