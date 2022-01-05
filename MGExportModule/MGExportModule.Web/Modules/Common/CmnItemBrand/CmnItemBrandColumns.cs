
namespace MGExportModule.Common.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Common.CmnItemBrand")]
    [BasedOnRow(typeof(Entities.CmnItemBrandRow), CheckNames = true)]
    public class CmnItemBrandColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        [Hidden]
        public Int32 BrandId { get; set; }
        [EditLink]
        [QuickFilter]
        public String CustomCode { get; set; }
        [QuickFilter]
        public String BrandName { get; set; }
        public DateTime InsertDate { get; set; }
        [Hidden]
        public Int32 InsertUserId { get; set; }

        [Hidden]
        public DateTime UpdateDate { get; set; }

        [Hidden]
        public Int32 UpdateUserId { get; set; }
        [Hidden]
        public Boolean IsDelete { get; set; }
    }
}