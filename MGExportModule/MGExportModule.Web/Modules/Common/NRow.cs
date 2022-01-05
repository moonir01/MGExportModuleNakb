using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MGExportModule
{
    public abstract class NRow : Row, IInsertLogRow, IUpdateLogRow
    {
        [DisplayName("Create Date"), MinSelectLevel(SelectLevel.Explicit)]
        public DateTime? InsertDate
        {
            get { return Fields.InsertDate[this]; }
            set { Fields.InsertDate[this] = value; }
        }

        [DisplayName("Created By")/*, ForeignKey("[dbo].[AppUser]", "Id"), LeftJoin("jUser"), TextualField("Name")*/]
        public Int32? InsertUserId
        {
            get { return Fields.InsertUserId[this]; }
            set { Fields.InsertUserId[this] = value; }
        }

        [DisplayName("Last Update Date "), MinSelectLevel(SelectLevel.Explicit)]
        public DateTime? UpdateDate
        {
            get { return Fields.UpdateDate[this]; }
            set { Fields.UpdateDate[this] = value; }
        }

        [DisplayName("Last Updated By"), MinSelectLevel(SelectLevel.Explicit)]
        public Int64? UpdateUserId
        {
            get { return Fields.UpdateUserId[this]; }
            set { Fields.UpdateUserId[this] = value; }
        }

        IIdField IInsertLogRow.InsertUserIdField
        {
            get { return Fields.InsertUserId; }
        }

        IIdField IUpdateLogRow.UpdateUserIdField
        {
            get { return Fields.UpdateUserId; }
        }

        DateTimeField IInsertLogRow.InsertDateField
        {
            get { return Fields.InsertDate; }
        }

        DateTimeField IUpdateLogRow.UpdateDateField
        {
            get { return Fields.UpdateDate; }
        }


        private NRowFields Fields;

        public NRow(NRowFields fields) : base(fields)
        {
            Fields = fields;
        }
    }

    public abstract class NRowFields : RowFieldsBase
    {
        public DateTimeField InsertDate;
        public Int32Field InsertUserId;
        public DateTimeField UpdateDate;
        public Int64Field UpdateUserId;

        public NRowFields() : base()
        {

        }
    }

}