
namespace MGExportModule.Common.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Common.CmnItemMaster")]
    [BasedOnRow(typeof(Entities.CmnItemMasterRow), CheckNames = true)]
    public class CmnItemMasterColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ItemId { get; set; }
        [EditLink]
        [QuickFilter,FilterOnly]
        public String CustomCode { get; set; }
        public String ItemName { get; set; }
        public String ItemCategoryCustomCode { get; set; }
        public DateTime InsertDate { get; set; }
        public Int32 InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public Int32 UpdateUserId { get; set; }
        public Boolean IsDelete { get; set; }
        public String ModelCustomCode { get; set; }
    }
}