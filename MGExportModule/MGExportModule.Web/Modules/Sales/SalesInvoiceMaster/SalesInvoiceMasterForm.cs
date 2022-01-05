
namespace MGExportModule.Sales.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using MGExportModule.Sales.Entities;

    [FormScript("Sales.SalesInvoiceMaster")]
    [BasedOnRow(typeof(Entities.SalesInvoiceMasterRow), CheckNames = true)]
    public class SalesInvoiceMasterForm
    {
        public String CustomCode { get; set; }
        public String Description { get; set; }

        public Int32 BuyerId { get; set; }
        public DateTime SalesDate { get; set; }
        public Boolean IsDelete { get; set; }
        public List<SalesInvoiceDetailRow> SalesDetails { get; set;}
    }
}