using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class asdflasdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeAmount",
                table: "wms_purchase_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRate",
                table: "wms_purchase_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExchangeAmount",
                table: "wms_purchase_tbl");

            migrationBuilder.DropColumn(
                name: "ExchangeRate",
                table: "wms_purchase_tbl");
        }
    }
}
