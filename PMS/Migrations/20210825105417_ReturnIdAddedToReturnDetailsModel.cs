using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ReturnIdAddedToReturnDetailsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "wms_return_details_tbl");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "wms_return_details_tbl");

            migrationBuilder.AddColumn<long>(
                name: "ReturnId",
                table: "wms_return_details_tbl",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnId",
                table: "wms_return_details_tbl");

            migrationBuilder.AddColumn<long>(
                name: "PurchaseId",
                table: "wms_return_details_tbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SaleId",
                table: "wms_return_details_tbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
