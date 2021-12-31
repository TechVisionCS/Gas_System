using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class CustomerForeignKeysRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wms_customer_tbl_wms_country_tbl_Countryid",
                table: "wms_customer_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_wms_customer_tbl_wms_province_tbl_Provinceid",
                table: "wms_customer_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_customer_tbl_Countryid",
                table: "wms_customer_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_customer_tbl_Provinceid",
                table: "wms_customer_tbl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_wms_customer_tbl_Countryid",
                table: "wms_customer_tbl",
                column: "Countryid");

            migrationBuilder.CreateIndex(
                name: "IX_wms_customer_tbl_Provinceid",
                table: "wms_customer_tbl",
                column: "Provinceid");

            migrationBuilder.AddForeignKey(
                name: "FK_wms_customer_tbl_wms_country_tbl_Countryid",
                table: "wms_customer_tbl",
                column: "Countryid",
                principalTable: "wms_country_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_wms_customer_tbl_wms_province_tbl_Provinceid",
                table: "wms_customer_tbl",
                column: "Provinceid",
                principalTable: "wms_province_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
