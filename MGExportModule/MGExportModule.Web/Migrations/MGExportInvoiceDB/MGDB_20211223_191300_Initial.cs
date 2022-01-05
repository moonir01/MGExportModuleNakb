using FluentMigrator;
using System;

namespace MGExportModule.Migrations.DefaultDB
{

    [Migration(20211223_191300)]
    public class MGDB_20211223_191300_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("SalesInvoiceMaster", "Id", s => s
                .WithColumn("CustomCode").AsString(100).NotNullable()
                .WithColumn("Description").AsString(500).NotNullable()
                .WithColumn("BuyerID").AsInt32().Nullable()
                .WithColumn("SalesDate").AsDateTime().NotNullable()               
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsDelete").AsBoolean().NotNullable().WithDefaultValue(1));          
        }
    }


    [Migration(20211230_173500)]
    public class MGDB_20211230_173500_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("SalesInvoiceDetail", "SalesDetailId", s => s
                .WithColumn("CustomCode").AsString(100).Nullable()
                .WithColumn("SalesID").AsInt32().ForeignKey("SalesInvoiceMaster", "Id")
                .WithColumn("ItemID").AsString(500).NotNullable()
                .WithColumn("Quontity").AsInt32().NotNullable()
                .WithColumn("UnitPrice").AsDecimal().NotNullable()
                .WithColumn("TotalPrice").AsDecimal().NotNullable()
                .WithColumn("COAID").AsInt32().Nullable()
                .WithColumn("DrAmount").AsDecimal().Nullable()
                .WithColumn("CrAmount").AsDecimal().Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsDelete").AsBoolean().NotNullable().WithDefaultValue(1));
        }
    }

    [Migration(20211226_124600)]
    public class MGDB_20211226_124600_Initial : AutoReversingMigration
    {
        public override void Up()
        {
             this.CreateTableWithId32("CmnUserInfo", "UserID", s => s
             .WithColumn("CustomCode").AsString(100).Nullable()
             .WithColumn("UserFullName").AsString(500).NotNullable()
             .WithColumn("UserTypeID").AsInt32().NotNullable()
             .WithColumn("InsertDate").AsDateTime().NotNullable()
             .WithColumn("InsertUserId").AsInt32().NotNullable()
             .WithColumn("UpdateDate").AsDateTime().Nullable()
             .WithColumn("UpdateUserId").AsInt32().Nullable()
             .WithColumn("IsDelete").AsBoolean().NotNullable().WithDefaultValue(1));



        }
    }

    [Migration(20211226_125900)]
    public class MGDB_20211226_125900_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("CmnItemMaster", "ItemID", s => s
            .WithColumn("CustomCode").AsString(100).Nullable()
            .WithColumn("ItemName").AsString(500).NotNullable()
            .WithColumn("ItemCategoryID").AsInt32().Nullable()
            .WithColumn("ItemGroupID").AsInt32().Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsDelete").AsBoolean().NotNullable().WithDefaultValue(1));
        }
    }

    [Migration(20211227_175200)]
    public class MGDB_20211227_175200_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("CmnItemMaster")
            .AddColumn("ModelID").AsInt32().Nullable();

            Delete.Column("ItemGroupID").FromTable("CmnItemMaster");
        }
    }

    [Migration(20211230_191200)]
    public class MGDB_20211230_191200_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("CmnUserInfo")
            .AddColumn("UserImage").AsString(500).Nullable();

            
        }
    }

    //[Migration(20211227_175500)]
    public class MGDB_20211227_175500_Initial : Migration
    {
        public override void Up()
        {
            Delete.Table("tempCmnItemMaster");
        }  
        public override void Down()
        {
            
        }
    }


    [Migration(20211227_180900)]
    public class MGDB_20211227_180900_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("SalesInvoiceMaster")
            .AlterColumn("BuyerID").AsInt32().ForeignKey("CmnUserInfo", "UserID")
            ;
        }
    }

    [Migration(20211227_182400)]
    public class MGDB_20211227_182400_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            Delete.ForeignKey("FK_SalesInvoiceMaster_BuyerID_CmnUserInfo_UserID").OnTable("SalesInvoiceMaster");


        }
    }

    [Migration(20211229_102900)]
    public class MGDB_20211229_102900_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("CmnItemCategory", "CategoryId", s => s
                .WithColumn("CustomCode").AsString(100).NotNullable()
                .WithColumn("CategoryName").AsString(500).NotNullable()                
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsDelete").AsBoolean().NotNullable().WithDefaultValue(1));
        }
    }

    [Migration(20211229_103900)]
    public class MGDB_20211229_103900_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("CmnItemGroup", "GroupId", s => s
                .WithColumn("CustomCode").AsString(100).NotNullable()
                .WithColumn("GroupName").AsString(500).NotNullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsDelete").AsBoolean().NotNullable().WithDefaultValue(1));
        }
    }

    [Migration(20211229_104100)]
    public class MGDB_20211229_104100_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("CmnItemBrand", "BrandId", s => s
                .WithColumn("CustomCode").AsString(100).NotNullable()
                .WithColumn("BrandName").AsString(500).NotNullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsDelete").AsBoolean().NotNullable().WithDefaultValue(1));
        }
    }

    [Migration(20211229_104400)]
    public class MGDB_20211229_104400_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("CmnItemSize", "SizeId", s => s
                .WithColumn("CustomCode").AsString(100).NotNullable()
                .WithColumn("SizeName").AsString(500).NotNullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsDelete").AsBoolean().NotNullable().WithDefaultValue(1));
        }
    }

    [Migration(20211229_104500)]
    public class MGDB_20211229_104500_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("CmnItemModel", "ModelId", s => s
                .WithColumn("CustomCode").AsString(100).NotNullable()
                .WithColumn("ModelName").AsString(500).NotNullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsDelete").AsBoolean().NotNullable().WithDefaultValue(1));
        }
    }

    [Migration(20211229_104900)]
    public class MGDB_20211229_104900_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("CmnItemMaster")
            .AlterColumn("ModelID").AsInt32().ForeignKey("CmnItemModel", "ModelId")
            .AlterColumn("ItemCategoryID").AsInt32().ForeignKey("CmnItemCategory", "CategoryID")
            ;
        }
    }

}