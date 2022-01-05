
namespace MGExportModule.Common.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Common.CmnItemModel")]
    [BasedOnRow(typeof(Entities.CmnItemModelRow), CheckNames = true)]
    public class CmnItemModelForm
    {
        public String CustomCode { get; set; }
        public String ModelName { get; set; }
        public DateTime InsertDate { get; set; }
        public Int32 InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public Int32 UpdateUserId { get; set; }
        public Boolean IsDelete { get; set; }
    }
}