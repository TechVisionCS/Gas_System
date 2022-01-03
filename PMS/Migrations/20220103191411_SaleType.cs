using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class SaleType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SaleType",
                table: "wms_sale_tbl",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaleType",
                table: "wms_sale_tbl");
        }
    }
}
