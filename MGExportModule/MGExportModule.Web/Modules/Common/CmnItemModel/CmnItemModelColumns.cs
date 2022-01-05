
namespace MGExportModule.Common.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Common.CmnItemModel")]
    [BasedOnRow(typeof(Entities.CmnItemModelRow), CheckNames = true)]
    public class CmnItemModelColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ModelId { get; set; }
        [EditLink]
        public String CustomCode { get; set; }
        public String ModelName { get; set; }
        public DateTime InsertDate { get; set; }
        public Int32 InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public Int32 UpdateUserId { get; set; }
        public Boolean IsDelete { get; set; }
    }
}