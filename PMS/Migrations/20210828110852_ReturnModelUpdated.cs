using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ReturnModelUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DiscountAmount",
                table: "wms_return_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "RentAmount",
                table: "wms_return_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SubTotal",
                table: "wms_return_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TaxAmount",
                table: "wms_return_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountAmount",
                table: "wms_return_tbl");

            migrationBuilder.DropColumn(
                name: "RentAmount",
                table: "wms_return_tbl");

            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "wms_return_tbl");

            migrationBuilder.DropColumn(
                name: "TaxAmount",
                table: "wms_return_tbl");
        }
    }
}
