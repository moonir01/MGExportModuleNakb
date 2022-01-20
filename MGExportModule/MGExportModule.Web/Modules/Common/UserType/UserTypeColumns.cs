
namespace MGExportModule.Common.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Common.UserType")]
    [BasedOnRow(typeof(Entities.UserTypeRow), CheckNames = true)]
    public class UserTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 UserTypeId { get; set; }
        [EditLink]
        public String CustomCode { get; set; }
        public String UserTypeName { get; set; }
        public Boolean IsDelete { get; set; }
    }
}