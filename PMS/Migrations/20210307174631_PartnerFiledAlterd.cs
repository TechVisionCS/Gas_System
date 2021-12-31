using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class PartnerFiledAlterd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wms_partner_tbl_wms_country_tbl_Country_id",
                table: "wms_partner_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_wms_partner_tbl_wms_province_tbl_Provinceid",
                table: "wms_partner_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_partner_tbl_Country_id",
                table: "wms_partner_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_partner_tbl_Provinceid",
                table: "wms_partner_tbl");

            migrationBuilder.DropColumn(
                name: "Country_id",
                table: "wms_partner_tbl");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "wms_partner_tbl");

            migrationBuilder.DropColumn(
                name: "Province_id",
                table: "wms_partner_tbl");

            migrationBuilder.DropColumn(
                name: "RegDate",
                table: "wms_partner_tbl");

            migrationBuilder.AlterColumn<long>(
                name: "Provinceid",
                table: "wms_partner_tbl",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Countryid",
                table: "wms_partner_tbl",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "wms_partner_tbl",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Countryid",
                table: "wms_partner_tbl");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "wms_partner_tbl");

            migrationBuilder.AlterColumn<long>(
                name: "Provinceid",
                table: "wms_partner_tbl",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "Country_id",
                table: "wms_partner_tbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "wms_partner_tbl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Province_id",
                table: "wms_partner_tbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "RegDate",
                table: "wms_partner_tbl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_wms_partner_tbl_Country_id",
                table: "wms_partner_tbl",
                column: "Country_id");

            migrationBuilder.CreateIndex(
                name: "IX_wms_partner_tbl_Provinceid",
                table: "wms_partner_tbl",
                column: "Provinceid");

            migrationBuilder.AddForeignKey(
                name: "FK_wms_partner_tbl_wms_country_tbl_Country_id",
                table: "wms_partner_tbl",
                column: "Country_id",
                principalTable: "wms_country_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_wms_partner_tbl_wms_province_tbl_Provinceid",
                table: "wms_partner_tbl",
                column: "Provinceid",
                principalTable: "wms_province_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
