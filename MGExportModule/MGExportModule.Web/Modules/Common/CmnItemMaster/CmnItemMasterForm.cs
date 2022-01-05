﻿
namespace MGExportModule.Common.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Common.CmnItemMaster")]
    [BasedOnRow(typeof(Entities.CmnItemMasterRow), CheckNames = true)]
    public class CmnItemMasterForm
    {
        [HalfWidth(UntilNext = true)]
        public String CustomCode { get; set; }
        public String ItemName { get; set; }
        public Int32 ItemCategoryId { get; set; }
        public DateTime InsertDate { get; set; }
        public Int32 InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public Int32 UpdateUserId { get; set; }
        public Boolean IsDelete { get; set; }
        public Int32 ModelId { get; set; }
    }
}