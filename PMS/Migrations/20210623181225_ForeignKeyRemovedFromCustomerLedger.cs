using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ForeignKeyRemovedFromCustomerLedger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wms_customer_ledger_tbl_wms_customer_tbl_EntityId",
                table: "wms_customer_ledger_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_customer_ledger_tbl_EntityId",
                table: "wms_customer_ledger_tbl");

            migrationBuilder.AddColumn<long>(
                name: "CustomerId",
                table: "wms_customer_ledger_tbl",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_wms_customer_ledger_tbl_CustomerId",
                table: "wms_customer_ledger_tbl",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_wms_customer_ledger_tbl_wms_customer_tbl_CustomerId",
                table: "wms_customer_ledger_tbl",
                column: "CustomerId",
                principalTable: "wms_customer_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wms_customer_ledger_tbl_wms_customer_tbl_CustomerId",
                table: "wms_customer_ledger_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_customer_ledger_tbl_CustomerId",
                table: "wms_customer_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "wms_customer_ledger_tbl");

            migrationBuilder.CreateIndex(
                name: "IX_wms_customer_ledger_tbl_EntityId",
                table: "wms_customer_ledger_tbl",
                column: "EntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_wms_customer_ledger_tbl_wms_customer_tbl_EntityId",
                table: "wms_customer_ledger_tbl",
                column: "EntityId",
                principalTable: "wms_customer_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
