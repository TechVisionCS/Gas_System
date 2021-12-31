using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class InvoiceNoAddedToSaleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InvoiceNo",
                table: "wms_sale_tbl",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceNo",
                table: "wms_sale_tbl");
        }
    }
}
