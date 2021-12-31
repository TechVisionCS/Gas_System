using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ProductUnitModelCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitSellPrice",
                table: "wms_unit_tbl");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "wms_product_batch_tbl");

            migrationBuilder.DropColumn(
                name: "SellPrice",
                table: "wms_product_batch_tbl");

            migrationBuilder.CreateTable(
                name: "ProductUnit",
                columns: table => new
                {
                    ProductId = table.Column<long>(nullable: false),
                    UnitId = table.Column<long>(nullable: false),
                    UnitSellPrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUnit", x => new { x.ProductId, x.UnitId });
                    table.ForeignKey(
                        name: "FK_ProductUnit_wms_product_tbl_ProductId",
                        column: x => x.ProductId,
                        principalTable: "wms_product_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductUnit_wms_unit_tbl_UnitId",
                        column: x => x.UnitId,
                        principalTable: "wms_unit_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnit_UnitId",
                table: "ProductUnit",
                column: "UnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductUnit");

            migrationBuilder.AddColumn<decimal>(
                name: "UnitSellPrice",
                table: "wms_unit_tbl",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                table: "wms_product_batch_tbl",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SellPrice",
                table: "wms_product_batch_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
