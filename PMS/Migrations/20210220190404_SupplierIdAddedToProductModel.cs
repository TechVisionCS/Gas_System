using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class SupplierIdAddedToProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SupplierId",
                table: "wms_product_tbl",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "wms_product_tbl");
        }
    }
}
