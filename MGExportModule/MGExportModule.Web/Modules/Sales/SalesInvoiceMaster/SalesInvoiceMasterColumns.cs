
namespace MGExportModule.Sales.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Sales.SalesInvoiceMaster")]
    [BasedOnRow(typeof(Entities.SalesInvoiceMasterRow), CheckNames = true)]
    public class SalesInvoiceMasterColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String CustomCode { get; set; }
        public String Description { get; set; }
        public Int32 BuyerId { get; set; }
        public DateTime SalesDate { get; set; }
        public Boolean IsDelete { get; set; }
    }
}