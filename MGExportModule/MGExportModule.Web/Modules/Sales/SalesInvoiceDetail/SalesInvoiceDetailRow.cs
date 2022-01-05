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

    [ConnectionKey("Default"), TableName("[dbo].[SalesInvoiceDetail]")]
    [DisplayName("Sales Invoice Detail"), InstanceName("Sales Invoice Detail"), TwoLevelCached]
	[NavigationPermission("Sales:SalesInvoiceDetail:Navigation")]
    [ReadPermission("Sales:SalesInvoiceDetail:Read")]
    [InsertPermission("Sales:SalesInvoiceDetail:Insert")]
    [UpdatePermission("Sales:SalesInvoiceDetail:Update")]
    [DeletePermission("Sales:SalesInvoiceDetail:Delete")]
    public sealed class SalesInvoiceDetailRow : NRow, IIdRow, INameRow
    {

        [DisplayName("Sales Detail Id"), Identity]
        public Int32? SalesDetailId { get => Fields.SalesDetailId[this]; set => Fields.SalesDetailId[this] = value; }
		public partial class RowFields { public Int32Field SalesDetailId; }

        [DisplayName("Custom Code"), Size(100), QuickSearch]
        public String CustomCode { get => Fields.CustomCode[this]; set => Fields.CustomCode[this] = value; }
		public partial class RowFields { public StringField CustomCode; }

        [DisplayName("Sales"), Column("SalesID"), NotNull, ForeignKey("[dbo].[SalesInvoiceMaster]", "Id"), LeftJoin("jSales"), TextualField("SalesCustomCode")]
        public Int32? SalesId { get => Fields.SalesId[this]; set => Fields.SalesId[this] = value; }
		public partial class RowFields { public Int32Field SalesId; }

        [DisplayName("Item Id"), Column("ItemID"), Size(500), NotNull, QuickSearch]
        [LookupEditor(typeof(CmnItemMasterRow))]
        public String ItemId { get => Fields.ItemId[this]; set => Fields.ItemId[this] = value; }
		public partial class RowFields { public StringField ItemId; }

        [DisplayName("Quontity"), NotNull]
        public Int32? Quontity { get => Fields.Quontity[this]; set => Fields.Quontity[this] = value; }
		public partial class RowFields { public Int32Field Quontity; }

        [DisplayName("Unit Price"), Size(19), Scale(5), NotNull]
        public Decimal? UnitPrice { get => Fields.UnitPrice[this]; set => Fields.UnitPrice[this] = value; }
		public partial class RowFields { public DecimalField UnitPrice; }

        [DisplayName("Total Price"), Size(19), Scale(5), NotNull]
        public Decimal? TotalPrice { get => Fields.TotalPrice[this]; set => Fields.TotalPrice[this] = value; }
		public partial class RowFields { public DecimalField TotalPrice; }

        [DisplayName("Coaid"), Column("COAID")]
        public Int32? Coaid { get => Fields.Coaid[this]; set => Fields.Coaid[this] = value; }
		public partial class RowFields { public Int32Field Coaid; }

        [DisplayName("Dr Amount"), Size(19), Scale(5)]
        public Decimal? DrAmount { get => Fields.DrAmount[this]; set => Fields.DrAmount[this] = value; }
		public partial class RowFields { public DecimalField DrAmount; }

        [DisplayName("Cr Amount"), Size(19), Scale(5)]
        public Decimal? CrAmount { get => Fields.CrAmount[this]; set => Fields.CrAmount[this] = value; }
		public partial class RowFields { public DecimalField CrAmount; }

        [DisplayName("Is Delete"), NotNull]
        public Boolean? IsDelete { get => Fields.IsDelete[this]; set => Fields.IsDelete[this] = value; }
		public partial class RowFields { public BooleanField IsDelete; }

        #region Foreign Fields


        [DisplayName("Sales Custom Code"), Expression("jSales.[CustomCode]"), ReadOnly(true)]
        public String SalesCustomCode { get => Fields.SalesCustomCode[this]; set => Fields.SalesCustomCode[this] = value; }
		public partial class RowFields { public StringField SalesCustomCode; }

        [DisplayName("Sales Description"), Expression("jSales.[Description]"), ReadOnly(true)]
        public String SalesDescription { get => Fields.SalesDescription[this]; set => Fields.SalesDescription[this] = value; }
		public partial class RowFields { public StringField SalesDescription; }

        [DisplayName("Sales Buyer Id"), Expression("jSales.[BuyerID]"), ReadOnly(true)]
        public Int32? SalesBuyerId { get => Fields.SalesBuyerId[this]; set => Fields.SalesBuyerId[this] = value; }
		public partial class RowFields { public Int32Field SalesBuyerId; }

        [DisplayName("Sales Sales Date"), Expression("jSales.[SalesDate]"), ReadOnly(true)]
        public DateTime? SalesSalesDate { get => Fields.SalesSalesDate[this]; set => Fields.SalesSalesDate[this] = value; }
		public partial class RowFields { public DateTimeField SalesSalesDate; }

        [DisplayName("Sales Is Delete"), Expression("jSales.[IsDelete]"), ReadOnly(true)]
        public Boolean? SalesIsDelete { get => Fields.SalesIsDelete[this]; set => Fields.SalesIsDelete[this] = value; }
		public partial class RowFields { public BooleanField SalesIsDelete; }


        #endregion Foreign Fields


        IIdField IIdRow.IdField { get { return Fields.SalesDetailId; } }

        StringField INameRow.NameField { get { return Fields.CustomCode; } }

        public static readonly RowFields Fields = new RowFields().Init();

        public SalesInvoiceDetailRow() : base(Fields) { }

		public partial class RowFields : NRowFields { }
    }
}
