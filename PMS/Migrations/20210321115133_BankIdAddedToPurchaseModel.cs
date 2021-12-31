using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class BankIdAddedToPurchaseModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BankId",
                table: "wms_purchase_tbl",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankId",
                table: "wms_purchase_tbl");
        }
    }
}
