using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class SaleIdAddedToReturnModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SaleId",
                table: "wms_return_tbl",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "wms_return_tbl");
        }
    }
}
