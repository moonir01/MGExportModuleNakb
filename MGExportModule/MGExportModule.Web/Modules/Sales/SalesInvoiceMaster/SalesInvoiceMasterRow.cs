namespace MGExportModule.Sales.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
	using System.Collections.Generic;
    using System.IO;
    using MGExportModule.Common.Entities;

    [ConnectionKey("Default"), TableName("[dbo].[SalesInvoiceMaster]")]
    [DisplayName("Sales Invoice Master"), InstanceName("Sales Invoice Master"), TwoLevelCached]
	[NavigationPermission("Sales:SalesInvoiceMaster:Navigation")]
    [ReadPermission("Sales:SalesInvoiceMaster:Read")]
    [InsertPermission("Sales:SalesInvoiceMaster:Insert")]
    [UpdatePermission("Sales:SalesInvoiceMaster:Update")]
    [DeletePermission("Sales:SalesInvoiceMaster:Delete")]
    public sealed class SalesInvoiceMasterRow : NRow, IIdRow, INameRow
    {

        [DisplayName("Id"), Identity]
        public Int32? Id { get => Fields.Id[this]; set => Fields.Id[this] = value; }
		public partial class RowFields { public Int32Field Id; }

        [DisplayName("Custom Code"), Size(100), NotNull, QuickSearch]
        public String CustomCode { get => Fields.CustomCode[this]; set => Fields.CustomCode[this] = value; }
		public partial class RowFields { public StringField CustomCode; }

        [DisplayName("Description"), Size(500), NotNull]
        public String Description { get => Fields.Description[this]; set => Fields.Description[this] = value; }
		public partial class RowFields { public StringField Description; }

        [DisplayName("Buyer Id"), Column("BuyerID"), NotNull]
        [LookupEditor(typeof(UserInfoRow))]
        public Int32? BuyerId { get => Fields.BuyerId[this]; set => Fields.BuyerId[this] = value; }
		public partial class RowFields { public Int32Field BuyerId; }

        [DisplayName("Sales Date"), NotNull]
        public DateTime? SalesDate { get => Fields.SalesDate[this]; set => Fields.SalesDate[this] = value; }
		public partial class RowFields { public DateTimeField SalesDate; }

        [DisplayName("Is Delete"), NotNull]
        public Boolean? IsDelete { get => Fields.IsDelete[this]; set => Fields.IsDelete[this] = value; }
		public partial class RowFields { public BooleanField IsDelete; }

        #region Branch list Detail
        [DisplayName("Sales Details"), MasterDetailRelation(foreignKey: "SalesId"), NotMapped]
        [SalesInvoiceDetailEditor]
        public List<SalesInvoiceDetailRow> SalesDetails
        {
            get { return Fields.SalesDetails[this]; }
            set { Fields.SalesDetails[this] = value; }
        }
        public partial class RowFields { public RowListField<SalesInvoiceDetailRow> SalesDetails; }
        #endregion

        #region Foreign Fields

        #endregion Foreign Fields


        IIdField IIdRow.IdField { get { return Fields.Id; } }

        StringField INameRow.NameField { get { return Fields.CustomCode; } }

        public static readonly RowFields Fields = new RowFields().Init();

        public SalesInvoiceMasterRow() : base(Fields) { }

		public partial class RowFields : NRowFields { }
    }
}
