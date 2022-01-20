
namespace MGExportModule.Common.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Common.UserType")]
    [BasedOnRow(typeof(Entities.UserTypeRow), CheckNames = true)]
    public class UserTypeForm
    {
        public String CustomCode { get; set; }
        public String UserTypeName { get; set; }
        public Boolean IsDelete { get; set; }
    }
}