
namespace MGExportModule.Common {
    import fld = UserTypeRow.Fields;

    @Serenity.Decorators.registerClass()
    export class UserTypeDialog extends _Ext.DialogBase<UserTypeRow, any> {
        protected getFormKey() { return UserTypeForm.formKey; }
        protected getRowType() { return UserTypeRow; }
        protected getService() { return UserTypeService.baseUrl; }

        protected form = new UserTypeForm(this.idPrefix);

        constructor(options) {
            super(options);
        }

        protected afterLoadEntity() {
            super.afterLoadEntity();

            if (this.isNew()) {
                UserTypeService.GetCustomCode({
                    
                }, r => {
                    this.form.CustomCode.value = String(r.CustomCode);
                });
            }

        



        }

    }
}