using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class TransactionCodeAddedToSalePurchaseModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TransCode",
                table: "wms_sale_tbl",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransCode",
                table: "wms_purchase_tbl",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransCode",
                table: "wms_sale_tbl");

            migrationBuilder.DropColumn(
                name: "TransCode",
                table: "wms_purchase_tbl");
        }
    }
}
