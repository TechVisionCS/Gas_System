using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class DiscountAddedToReturnDetailsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "wms_return_details_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "wms_return_details_tbl");
        }
    }
}
