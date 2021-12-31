using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class BarCodeAttributeRemovedFromProductBatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_wms_product_batch_tbl_BarCode",
                table: "wms_product_batch_tbl");

            migrationBuilder.DropColumn(
                name: "BarCode",
                table: "wms_product_batch_tbl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BarCode",
                table: "wms_product_batch_tbl",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_wms_product_batch_tbl_BarCode",
                table: "wms_product_batch_tbl",
                column: "BarCode",
                unique: true,
                filter: "[BarCode] IS NOT NULL");
        }
    }
}
