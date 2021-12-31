using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class BankModelsChangeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransID",
                table: "wms_bank_transaction_tbl");

            migrationBuilder.AddColumn<string>(
                name: "BankTransactionId",
                table: "wms_bank_transaction_tbl",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankTransactionId",
                table: "wms_bank_transaction_tbl");

            migrationBuilder.AddColumn<string>(
                name: "TransID",
                table: "wms_bank_transaction_tbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
