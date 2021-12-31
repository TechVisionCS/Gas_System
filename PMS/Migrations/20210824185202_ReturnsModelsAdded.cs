using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ReturnsModelsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wms_return_details_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    SaleId = table.Column<long>(nullable: false),
                    PurchaseId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    BatchId = table.Column<string>(nullable: true),
                    Qty = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_return_details_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_return_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    ReturnType = table.Column<int>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DueAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_return_tbl", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wms_return_details_tbl");

            migrationBuilder.DropTable(
                name: "wms_return_tbl");
        }
    }
}
