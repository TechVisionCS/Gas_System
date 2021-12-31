using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class BankModelsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "StockQty",
                table: "wms_stock_purchase_log_tbl",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "OutQty",
                table: "wms_stock_purchase_log_tbl",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "InQty",
                table: "wms_stock_purchase_log_tbl",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "EntityType",
                table: "wms_bank_ledger_tbl",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EntityType",
                table: "wms_bank_ledger_tbl");

            migrationBuilder.AlterColumn<float>(
                name: "StockQty",
                table: "wms_stock_purchase_log_tbl",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<float>(
                name: "OutQty",
                table: "wms_stock_purchase_log_tbl",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<float>(
                name: "InQty",
                table: "wms_stock_purchase_log_tbl",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
