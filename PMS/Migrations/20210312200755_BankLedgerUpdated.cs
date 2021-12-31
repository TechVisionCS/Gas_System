using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class BankLedgerUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "wms_bank_ledger_tbl");

            migrationBuilder.AddColumn<long>(
                name: "BankTransactionId",
                table: "wms_bank_ledger_tbl",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankTransactionId",
                table: "wms_bank_ledger_tbl");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "wms_bank_ledger_tbl",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
