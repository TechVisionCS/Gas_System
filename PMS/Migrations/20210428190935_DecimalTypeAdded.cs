using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class DecimalTypeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "StockQty",
                table: "wms_stock_purchase_log_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OutQty",
                table: "wms_stock_purchase_log_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InQty",
                table: "wms_stock_purchase_log_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "wms_partner_payment_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "wms_partner_investment_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "StockQty",
                table: "wms_stock_purchase_log_tbl",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(38, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OutQty",
                table: "wms_stock_purchase_log_tbl",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(38, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InQty",
                table: "wms_stock_purchase_log_tbl",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(38, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "wms_partner_payment_tbl",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(38, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "wms_partner_investment_tbl",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(38, 2)");
        }
    }
}
