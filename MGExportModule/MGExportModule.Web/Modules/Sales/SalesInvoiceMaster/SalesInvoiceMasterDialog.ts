
namespace MGExportModule.Sales {
    import fld = SalesInvoiceMasterRow.Fields;

    @Serenity.Decorators.registerClass()
    export class SalesInvoiceMasterDialog extends _Ext.DialogBase<SalesInvoiceMasterRow, any> {
        protected getFormKey() { return SalesInvoiceMasterForm.formKey; }
        protected getRowType() { return SalesInvoiceMasterRow; }
        protected getService() { return SalesInvoiceMasterService.baseUrl; }

        protected form = new SalesInvoiceMasterForm(this.idPrefix);

        constructor(options) {
            super(options);
        }

        protected get_ExtDialogOptions() {
            let opt = super.get_ExtDialogOptions();
            opt.PendingChangesConfirmation = false;
            return opt;
        }




        protected getToolbarButtons() {

            let buttons = super.getToolbarButtons();

            buttons.push({
                title: "Save Meter Reading",
                cssClass: "send-button",
                onClick: (x) => {
                   


                    let message = "Are you sure want to save?";

                    Q.confirm(message, () => {
                       // let entity: MeterReadingRow;

                        Q.serviceRequest('Sales/SalesInvoiceMaster/GetJournalID', {
                            RealizeId: this.form.Id.value
                           
                            //BillPostingRows: this.form.PaymentList.getItems()
                        }, (response) => {
                            //
                        }, { async: false });

                        Q.notifySuccess("Meter Reading Saved successfully.", "Message");
                        Serenity.SubDialogHelper.triggerDataChange(this);
                        this.dialogClose();

                    });
                }
            })

            return buttons;
        }

    }
}