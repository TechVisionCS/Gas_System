using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ForeignKeysRemovedFromBankModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wms_bank_ledger_tbl_wms_bank_transaction_tbl_EntityId",
                table: "wms_bank_ledger_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_wms_bank_transaction_tbl_wms_bank_tbl_BankId",
                table: "wms_bank_transaction_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_bank_transaction_tbl_BankId",
                table: "wms_bank_transaction_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_bank_ledger_tbl_EntityId",
                table: "wms_bank_ledger_tbl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_wms_bank_transaction_tbl_BankId",
                table: "wms_bank_transaction_tbl",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_bank_ledger_tbl_EntityId",
                table: "wms_bank_ledger_tbl",
                column: "EntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_wms_bank_ledger_tbl_wms_bank_transaction_tbl_EntityId",
                table: "wms_bank_ledger_tbl",
                column: "EntityId",
                principalTable: "wms_bank_transaction_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_wms_bank_transaction_tbl_wms_bank_tbl_BankId",
                table: "wms_bank_transaction_tbl",
                column: "BankId",
                principalTable: "wms_bank_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
