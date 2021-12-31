using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ProductUnitMappedToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductUnit_wms_product_tbl_ProductId",
                table: "ProductUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductUnit_wms_unit_tbl_UnitId",
                table: "ProductUnit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductUnit",
                table: "ProductUnit");

            migrationBuilder.RenameTable(
                name: "ProductUnit",
                newName: "ProductUnits");

            migrationBuilder.RenameIndex(
                name: "IX_ProductUnit_UnitId",
                table: "ProductUnits",
                newName: "IX_ProductUnits_UnitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductUnits",
                table: "ProductUnits",
                columns: new[] { "ProductId", "UnitId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductUnits_wms_product_tbl_ProductId",
                table: "ProductUnits",
                column: "ProductId",
                principalTable: "wms_product_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductUnits_wms_unit_tbl_UnitId",
                table: "ProductUnits",
                column: "UnitId",
                principalTable: "wms_unit_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductUnits_wms_product_tbl_ProductId",
                table: "ProductUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductUnits_wms_unit_tbl_UnitId",
                table: "ProductUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductUnits",
                table: "ProductUnits");

            migrationBuilder.RenameTable(
                name: "ProductUnits",
                newName: "ProductUnit");

            migrationBuilder.RenameIndex(
                name: "IX_ProductUnits_UnitId",
                table: "ProductUnit",
                newName: "IX_ProductUnit_UnitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductUnit",
                table: "ProductUnit",
                columns: new[] { "ProductId", "UnitId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductUnit_wms_product_tbl_ProductId",
                table: "ProductUnit",
                column: "ProductId",
                principalTable: "wms_product_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductUnit_wms_unit_tbl_UnitId",
                table: "ProductUnit",
                column: "UnitId",
                principalTable: "wms_unit_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
