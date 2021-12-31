using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class SubTotalAddedToPurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "SubTotal",
                table: "wms_purchase_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPurchasePrice",
                table: "wms_purchase_details_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "wms_purchase_tbl");

            migrationBuilder.DropColumn(
                name: "TotalPurchasePrice",
                table: "wms_purchase_details_tbl");
        }
    }
}
