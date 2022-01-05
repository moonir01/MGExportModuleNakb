
namespace MGExportModule.Common.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Common.UserInfo")]
    [BasedOnRow(typeof(Entities.UserInfoRow), CheckNames = true)]
    public class UserInfoForm
    {
        public String CustomCode { get; set; }
        public String UserFullName { get; set; }
        public Int32 UserTypeId { get; set; }
        public DateTime InsertDate { get; set; }
        public Int32 InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public Int32 UpdateUserId { get; set; }
        public Boolean IsDelete { get; set; }
        public String UserImage { get; set; }
    }
}