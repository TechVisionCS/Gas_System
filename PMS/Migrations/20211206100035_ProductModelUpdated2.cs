using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ProductModelUpdated2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitSellPrice",
                table: "wms_product_tbl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "UnitSellPrice",
                table: "wms_product_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
