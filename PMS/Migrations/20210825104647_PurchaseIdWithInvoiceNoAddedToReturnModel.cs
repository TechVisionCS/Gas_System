using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class PurchaseIdWithInvoiceNoAddedToReturnModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InvoiceNo",
                table: "wms_return_tbl",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PurchaseId",
                table: "wms_return_tbl",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceNo",
                table: "wms_return_tbl");

            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "wms_return_tbl");
        }
    }
}
