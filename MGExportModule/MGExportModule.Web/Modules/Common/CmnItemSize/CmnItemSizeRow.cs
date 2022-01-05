
namespace MGExportModule.Common.Entities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    [ConnectionKey("Default"), Module("Common"), TableName("[dbo].[CmnItemSize]")]
    [DisplayName("Cmn Item Size"), InstanceName("Cmn Item Size")]
    [ReadPermission("Administration:General:View")]
    [InsertPermission("Administration:General:Insert")]
    [ModifyPermission("Administration:General:Modify")]
    [DeletePermission("Administration:General:Delete")]
    public sealed class CmnItemSizeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Size Id"), Identity]
        public Int32? SizeId
        {
            get { return Fields.SizeId[this]; }
            set { Fields.SizeId[this] = value; }
        }

        [DisplayName("Custom Code"), Size(100), NotNull, QuickSearch]
        public String CustomCode
        {
            get { return Fields.CustomCode[this]; }
            set { Fields.CustomCode[this] = value; }
        }

        [DisplayName("Size Name"), Size(500), NotNull]
        public String SizeName
        {
            get { return Fields.SizeName[this]; }
            set { Fields.SizeName[this] = value; }
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
            get { return Fields.SizeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CustomCode; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CmnItemSizeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field SizeId;
            public StringField CustomCode;
            public StringField SizeName;
            public DateTimeField InsertDate;
            public Int32Field InsertUserId;
            public DateTimeField UpdateDate;
            public Int32Field UpdateUserId;
            public BooleanField IsDelete;
        }
    }
}
