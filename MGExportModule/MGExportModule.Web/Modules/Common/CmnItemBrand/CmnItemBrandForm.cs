
namespace MGExportModule.Common.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Common.CmnItemBrand")]
    [BasedOnRow(typeof(Entities.CmnItemBrandRow), CheckNames = true)]
    public class CmnItemBrandForm
    {
        public String CustomCode { get; set; }
        public String BrandName { get; set; }
        [Hidden]
        public DateTime InsertDate { get; set; }
        [Hidden]
        public Int32 InsertUserId { get; set; }
    
        [DateTimeEditor]
        public DateTime UpdateDate { get; set; }
        [Hidden]
        public Int32 UpdateUserId { get; set; }
        [Hidden]
        public Boolean IsDelete { get; set; }
    }
}