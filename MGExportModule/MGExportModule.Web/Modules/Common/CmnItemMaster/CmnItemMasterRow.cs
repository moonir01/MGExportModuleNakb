
namespace MGExportModule.Common.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Common"), TableName("[dbo].[CmnItemMaster]")]
    [DisplayName("Cmn Item Master"), InstanceName("Cmn Item Master")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class CmnItemMasterRow : Row, IIdRow, INameRow
    {
        [DisplayName("Item Id"), Column("ItemID"), Identity]
        public Int32? ItemId
        {
            get { return Fields.ItemId[this]; }
            set { Fields.ItemId[this] = value; }
        }

        [DisplayName("Custom Code"), Size(100), QuickSearch]
        public String CustomCode
        {
            get { return Fields.CustomCode[this]; }
            set { Fields.CustomCode[this] = value; }
        }

        [DisplayName("Item Name"), Size(500), NotNull]
        public String ItemName
        {
            get { return Fields.ItemName[this]; }
            set { Fields.ItemName[this] = value; }
        }

        [DisplayName("Item Category"), Column("ItemCategoryID"), NotNull, ForeignKey("[dbo].[CmnItemCategory]", "CategoryId"), LeftJoin("jItemCategory"), TextualField("ItemCategoryCustomCode")]
        [LookupEditor(typeof(CmnItemCategoryRow),InplaceAdd =true)]
        public Int32? ItemCategoryId
        {
            get { return Fields.ItemCategoryId[this]; }
            set { Fields.ItemCategoryId[this] = value; }
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

        [DisplayName("Model"), Column("ModelID"), NotNull, ForeignKey("[dbo].[CmnItemModel]", "ModelId"), LeftJoin("jModel"), TextualField("ModelCustomCode")]

        [LookupEditor(typeof(CmnItemModelRow))]
        public Int32? ModelId
        {
            get { return Fields.ModelId[this]; }
            set { Fields.ModelId[this] = value; }
        }

        [DisplayName("Item Category Custom Code"), Expression("jItemCategory.[CustomCode]")]
        public String ItemCategoryCustomCode
        {
            get { return Fields.ItemCategoryCustomCode[this]; }
            set { Fields.ItemCategoryCustomCode[this] = value; }
        }

        [DisplayName("Item Category Category Name"), Expression("jItemCategory.[CategoryName]")]
        public String ItemCategoryCategoryName
        {
            get { return Fields.ItemCategoryCategoryName[this]; }
            set { Fields.ItemCategoryCategoryName[this] = value; }
        }

        [DisplayName("Item Category Insert Date"), Expression("jItemCategory.[InsertDate]")]
        public DateTime? ItemCategoryInsertDate
        {
            get { return Fields.ItemCategoryInsertDate[this]; }
            set { Fields.ItemCategoryInsertDate[this] = value; }
        }

        [DisplayName("Item Category Insert User Id"), Expression("jItemCategory.[InsertUserId]")]
        public Int32? ItemCategoryInsertUserId
        {
            get { return Fields.ItemCategoryInsertUserId[this]; }
            set { Fields.ItemCategoryInsertUserId[this] = value; }
        }

        [DisplayName("Item Category Update Date"), Expression("jItemCategory.[UpdateDate]")]
        public DateTime? ItemCategoryUpdateDate
        {
            get { return Fields.ItemCategoryUpdateDate[this]; }
            set { Fields.ItemCategoryUpdateDate[this] = value; }
        }

        [DisplayName("Item Category Update User Id"), Expression("jItemCategory.[UpdateUserId]")]
        public Int32? ItemCategoryUpdateUserId
        {
            get { return Fields.ItemCategoryUpdateUserId[this]; }
            set { Fields.ItemCategoryUpdateUserId[this] = value; }
        }

        [DisplayName("Item Category Is Delete"), Expression("jItemCategory.[IsDelete]")]
        public Boolean? ItemCategoryIsDelete
        {
            get { return Fields.ItemCategoryIsDelete[this]; }
            set { Fields.ItemCategoryIsDelete[this] = value; }
        }

        [DisplayName("Model Custom Code"), Expression("jModel.[CustomCode]")]
        public String ModelCustomCode
        {
            get { return Fields.ModelCustomCode[this]; }
            set { Fields.ModelCustomCode[this] = value; }
        }

        [DisplayName("Model Model Name"), Expression("jModel.[ModelName]")]
        public String ModelModelName
        {
            get { return Fields.ModelModelName[this]; }
            set { Fields.ModelModelName[this] = value; }
        }

        [DisplayName("Model Insert Date"), Expression("jModel.[InsertDate]")]
        public DateTime? ModelInsertDate
        {
            get { return Fields.ModelInsertDate[this]; }
            set { Fields.ModelInsertDate[this] = value; }
        }

        [DisplayName("Model Insert User Id"), Expression("jModel.[InsertUserId]")]
        public Int32? ModelInsertUserId
        {
            get { return Fields.ModelInsertUserId[this]; }
            set { Fields.ModelInsertUserId[this] = value; }
        }

        [DisplayName("Model Update Date"), Expression("jModel.[UpdateDate]")]
        public DateTime? ModelUpdateDate
        {
            get { return Fields.ModelUpdateDate[this]; }
            set { Fields.ModelUpdateDate[this] = value; }
        }

        [DisplayName("Model Update User Id"), Expression("jModel.[UpdateUserId]")]
        public Int32? ModelUpdateUserId
        {
            get { return Fields.ModelUpdateUserId[this]; }
            set { Fields.ModelUpdateUserId[this] = value; }
        }

        [DisplayName("Model Is Delete"), Expression("jModel.[IsDelete]")]
        public Boolean? ModelIsDelete
        {
            get { return Fields.ModelIsDelete[this]; }
            set { Fields.ModelIsDelete[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ItemId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CustomCode; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CmnItemMasterRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ItemId;
            public StringField CustomCode;
            public StringField ItemName;
            public Int32Field ItemCategoryId;
            public DateTimeField InsertDate;
            public Int32Field InsertUserId;
            public DateTimeField UpdateDate;
            public Int32Field UpdateUserId;
            public BooleanField IsDelete;
            public Int32Field ModelId;

            public StringField ItemCategoryCustomCode;
            public StringField ItemCategoryCategoryName;
            public DateTimeField ItemCategoryInsertDate;
            public Int32Field ItemCategoryInsertUserId;
            public DateTimeField ItemCategoryUpdateDate;
            public Int32Field ItemCategoryUpdateUserId;
            public BooleanField ItemCategoryIsDelete;

            public StringField ModelCustomCode;
            public StringField ModelModelName;
            public DateTimeField ModelInsertDate;
            public Int32Field ModelInsertUserId;
            public DateTimeField ModelUpdateDate;
            public Int32Field ModelUpdateUserId;
            public BooleanField ModelIsDelete;
        }
    }
}
