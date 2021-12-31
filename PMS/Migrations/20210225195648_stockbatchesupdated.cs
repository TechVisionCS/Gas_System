using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class stockbatchesupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_wms_product_batch_tbl_Code",
                table: "wms_product_batch_tbl");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "wms_product_batch_tbl");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "wms_product_batch_tbl");

            migrationBuilder.AddColumn<string>(
                name: "BarCode",
                table: "wms_product_batch_tbl",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "StockQty",
                table: "wms_product_batch_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_wms_product_batch_tbl_BarCode",
                table: "wms_product_batch_tbl",
                column: "BarCode",
                unique: true,
                filter: "[BarCode] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_wms_product_batch_tbl_BarCode",
                table: "wms_product_batch_tbl");

            migrationBuilder.DropColumn(
                name: "BarCode",
                table: "wms_product_batch_tbl");

            migrationBuilder.DropColumn(
                name: "StockQty",
                table: "wms_product_batch_tbl");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "wms_product_batch_tbl",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SupplierId",
                table: "wms_product_batch_tbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_wms_product_batch_tbl_Code",
                table: "wms_product_batch_tbl",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");
        }
    }
}
