using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace MGExportModule.Sales
{
    public partial class SalesInvoiceDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "MGExportModule.Sales.SalesInvoiceDetailEditor";

        public SalesInvoiceDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}

