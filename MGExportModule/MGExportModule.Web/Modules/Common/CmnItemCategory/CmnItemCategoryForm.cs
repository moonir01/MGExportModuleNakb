
namespace MGExportModule.Common.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Common.CmnItemCategory")]
    [BasedOnRow(typeof(Entities.CmnItemCategoryRow), CheckNames = true)]
    public class CmnItemCategoryForm
    {
        public String CustomCode { get; set; }
        public String CategoryName { get; set; }
        public DateTime InsertDate { get; set; }
        public Int32 InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public Int32 UpdateUserId { get; set; }
        public Boolean IsDelete { get; set; }
    }
}