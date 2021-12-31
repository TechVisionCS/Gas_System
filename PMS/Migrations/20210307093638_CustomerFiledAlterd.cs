using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class CustomerFiledAlterd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wms_customer_tbl_wms_province_tbl_Provincesid",
                table: "wms_customer_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_wms_customer_tbl_wms_country_tbl_countrysid",
                table: "wms_customer_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_customer_tbl_Provincesid",
                table: "wms_customer_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_customer_tbl_countrysid",
                table: "wms_customer_tbl");

            migrationBuilder.DropColumn(
                name: "Provincesid",
                table: "wms_customer_tbl");

            migrationBuilder.DropColumn(
                name: "countrysid",
                table: "wms_customer_tbl");

            migrationBuilder.AddColumn<long>(
                name: "Countryid",
                table: "wms_customer_tbl",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Provinceid",
                table: "wms_customer_tbl",
                nullable: false,
                defaultValue: 0L);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Countryid",
                table: "wms_customer_tbl");

            migrationBuilder.DropColumn(
                name: "Provinceid",
                table: "wms_customer_tbl");

            migrationBuilder.AddColumn<long>(
                name: "Provincesid",
                table: "wms_customer_tbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "countrysid",
                table: "wms_customer_tbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_wms_customer_tbl_Provincesid",
                table: "wms_customer_tbl",
                column: "Provincesid");

            migrationBuilder.CreateIndex(
                name: "IX_wms_customer_tbl_countrysid",
                table: "wms_customer_tbl",
                column: "countrysid");

            migrationBuilder.AddForeignKey(
                name: "FK_wms_customer_tbl_wms_province_tbl_Provincesid",
                table: "wms_customer_tbl",
                column: "Provincesid",
                principalTable: "wms_province_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_wms_customer_tbl_wms_country_tbl_countrysid",
                table: "wms_customer_tbl",
                column: "countrysid",
                principalTable: "wms_country_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
