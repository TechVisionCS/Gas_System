using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ReturnModelsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BatchId",
                table: "wms_wastage_details_tbl");

            migrationBuilder.DropColumn(
                name: "BatchId",
                table: "wms_return_details_tbl");

            migrationBuilder.AddColumn<long>(
                name: "UnitId",
                table: "wms_wastage_details_tbl",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UnitId",
                table: "wms_return_details_tbl",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_wms_wastage_details_tbl_ProductId",
                table: "wms_wastage_details_tbl",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_wastage_details_tbl_UnitId",
                table: "wms_wastage_details_tbl",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_return_details_tbl_ProductId",
                table: "wms_return_details_tbl",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_return_details_tbl_UnitId",
                table: "wms_return_details_tbl",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_wms_return_details_tbl_wms_product_tbl_ProductId",
                table: "wms_return_details_tbl",
                column: "ProductId",
                principalTable: "wms_product_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_wms_return_details_tbl_wms_unit_tbl_UnitId",
                table: "wms_return_details_tbl",
                column: "UnitId",
                principalTable: "wms_unit_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_wms_wastage_details_tbl_wms_product_tbl_ProductId",
                table: "wms_wastage_details_tbl",
                column: "ProductId",
                principalTable: "wms_product_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_wms_wastage_details_tbl_wms_unit_tbl_UnitId",
                table: "wms_wastage_details_tbl",
                column: "UnitId",
                principalTable: "wms_unit_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wms_return_details_tbl_wms_product_tbl_ProductId",
                table: "wms_return_details_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_wms_return_details_tbl_wms_unit_tbl_UnitId",
                table: "wms_return_details_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_wms_wastage_details_tbl_wms_product_tbl_ProductId",
                table: "wms_wastage_details_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_wms_wastage_details_tbl_wms_unit_tbl_UnitId",
                table: "wms_wastage_details_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_wastage_details_tbl_ProductId",
                table: "wms_wastage_details_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_wastage_details_tbl_UnitId",
                table: "wms_wastage_details_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_return_details_tbl_ProductId",
                table: "wms_return_details_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_return_details_tbl_UnitId",
                table: "wms_return_details_tbl");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "wms_wastage_details_tbl");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "wms_return_details_tbl");

            migrationBuilder.AddColumn<string>(
                name: "BatchId",
                table: "wms_wastage_details_tbl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BatchId",
                table: "wms_return_details_tbl",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
