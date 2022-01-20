namespace MGExportModule.Common.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
	using System.Collections.Generic;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[CmnUserType]")]
    [DisplayName("User Type"), InstanceName("User Type"), TwoLevelCached]
	[NavigationPermission("Common:UserType:Navigation")]
    [ReadPermission("Common:UserType:Read")]
    [InsertPermission("Common:UserType:Insert")]
    [UpdatePermission("Common:UserType:Update")]
    [DeletePermission("Common:UserType:Delete")]
    [LookupScript]
    public sealed class UserTypeRow : NRow, IIdRow, INameRow
    {

        [DisplayName("User Type Id"), Identity]
        public Int32? UserTypeId { get => Fields.UserTypeId[this]; set => Fields.UserTypeId[this] = value; }
		public partial class RowFields { public Int32Field UserTypeId; }

        [DisplayName("Custom Code"), Size(100), NotNull, QuickSearch]
        public String CustomCode { get => Fields.CustomCode[this]; set => Fields.CustomCode[this] = value; }
		public partial class RowFields { public StringField CustomCode; }

        [DisplayName("User Type Name"), Size(500), NotNull]
        public String UserTypeName { get => Fields.UserTypeName[this]; set => Fields.UserTypeName[this] = value; }
		public partial class RowFields { public StringField UserTypeName; }

        [DisplayName("Is Delete"), NotNull]
        [Hidden]
        public Boolean? IsDelete { get => Fields.IsDelete[this]; set => Fields.IsDelete[this] = value; }
		public partial class RowFields { public BooleanField IsDelete; }

        #region Foreign Fields

        #endregion Foreign Fields


        IIdField IIdRow.IdField { get { return Fields.UserTypeId; } }

        StringField INameRow.NameField { get { return Fields.UserTypeName; } }

        public static readonly RowFields Fields = new RowFields().Init();

        public UserTypeRow() : base(Fields) { }

		public partial class RowFields : NRowFields { }
    }
}
