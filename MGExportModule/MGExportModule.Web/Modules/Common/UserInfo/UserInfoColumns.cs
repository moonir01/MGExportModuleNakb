
namespace MGExportModule.Common.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Common.UserInfo")]
    [BasedOnRow(typeof(Entities.UserInfoRow), CheckNames = true)]
    public class UserInfoColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 UserId { get; set; }
        [EditLink]
        [QuickFilter]
        public String CustomCode { get; set; }
        [QuickFilter]
        public String UserFullName { get; set; }
        public Int32 UserTypeId { get; set; }
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