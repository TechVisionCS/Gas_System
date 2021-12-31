using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class UnitSellPriceAddedToUnitModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "wms_product_tbl");

            migrationBuilder.AddColumn<decimal>(
                name: "UnitSellPrice",
                table: "wms_unit_tbl",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "wms_product_tbl",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitSellPrice",
                table: "wms_unit_tbl");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "wms_product_tbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<long>(
                name: "UnitId",
                table: "wms_product_tbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
