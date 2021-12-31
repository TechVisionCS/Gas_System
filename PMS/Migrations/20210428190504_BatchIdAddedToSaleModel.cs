using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class BatchIdAddedToSaleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "wms_supplier_payment_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "wms_supplier_advanced_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "BatchId",
                table: "wms_sale_details_tbl",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "wms_customer_receive_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "wms_customer_advanced_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BatchId",
                table: "wms_sale_details_tbl");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "wms_supplier_payment_tbl",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(38, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "wms_supplier_advanced_tbl",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(38, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "wms_customer_receive_tbl",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(38, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "wms_customer_advanced_tbl",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(38, 2)");
        }
    }
}
