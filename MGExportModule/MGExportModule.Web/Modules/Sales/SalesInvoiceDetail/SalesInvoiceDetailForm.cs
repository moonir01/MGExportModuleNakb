
namespace MGExportModule.Sales.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Sales.SalesInvoiceDetail")]
    [BasedOnRow(typeof(Entities.SalesInvoiceDetailRow), CheckNames = true)]
    public class SalesInvoiceDetailForm
    {
        public String CustomCode { get; set; }
        public String ItemId { get; set; }
        public Int32 Quontity { get; set; }
        public Decimal UnitPrice { get; set; }
        public Decimal TotalPrice { get; set; }
        public Int32 Coaid { get; set; }
        public Decimal DrAmount { get; set; }
        public Decimal CrAmount { get; set; }
        public Boolean IsDelete { get; set; }
    }
}