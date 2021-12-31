using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class PurchaseMigrationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PurchaseId",
                table: "wms_product_batch_tbl",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "QRCode",
                table: "wms_product_batch_tbl",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "wms_partners_purchase_shares_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_partners_purchase_shares_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_purchase_details_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    PurchaseId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    SellPrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_purchase_details_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_purchase_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    InvoiceNo = table.Column<string>(nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    RentAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DueAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PurchaseType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_purchase_tbl", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wms_partners_purchase_shares_tbl");

            migrationBuilder.DropTable(
                name: "wms_purchase_details_tbl");

            migrationBuilder.DropTable(
                name: "wms_purchase_tbl");

            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "wms_product_batch_tbl");

            migrationBuilder.DropColumn(
                name: "QRCode",
                table: "wms_product_batch_tbl");
        }
    }
}
