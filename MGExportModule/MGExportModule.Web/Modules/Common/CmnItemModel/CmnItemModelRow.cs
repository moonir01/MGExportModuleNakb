
namespace MGExportModule.Common.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Common"), TableName("[dbo].[CmnItemModel]")]
    [DisplayName("Cmn Item Model"), InstanceName("Cmn Item Model")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class CmnItemModelRow : Row, IIdRow, INameRow
    {
        [DisplayName("Model Id"), Identity]
        public Int32? ModelId
        {
            get { return Fields.ModelId[this]; }
            set { Fields.ModelId[this] = value; }
        }

        [DisplayName("Custom Code"), Size(100), NotNull, QuickSearch]
        public String CustomCode
        {
            get { return Fields.CustomCode[this]; }
            set { Fields.CustomCode[this] = value; }
        }

        [DisplayName("Model Name"), Size(500), NotNull]
        public String ModelName
        {
            get { return Fields.ModelName[this]; }
            set { Fields.ModelName[this] = value; }
        }

        [DisplayName("Insert Date"), NotNull]
        public DateTime? InsertDate
        {
            get { return Fields.InsertDate[this]; }
            set { Fields.InsertDate[this] = value; }
        }

        [DisplayName("Insert User Id"), NotNull]
        public Int32? InsertUserId
        {
            get { return Fields.InsertUserId[this]; }
            set { Fields.InsertUserId[this] = value; }
        }

        [DisplayName("Update Date")]
        public DateTime? UpdateDate
        {
            get { return Fields.UpdateDate[this]; }
            set { Fields.UpdateDate[this] = value; }
        }

        [DisplayName("Update User Id")]
        public Int32? UpdateUserId
        {
            get { return Fields.UpdateUserId[this]; }
            set { Fields.UpdateUserId[this] = value; }
        }

        [DisplayName("Is Delete"), NotNull]
        public Boolean? IsDelete
        {
            get { return Fields.IsDelete[this]; }
            set { Fields.IsDelete[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ModelId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ModelName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CmnItemModelRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ModelId;
            public StringField CustomCode;
            public StringField ModelName;
            public DateTimeField InsertDate;
            public Int32Field InsertUserId;
            public DateTimeField UpdateDate;
            public Int32Field UpdateUserId;
            public BooleanField IsDelete;
        }
    }
}
