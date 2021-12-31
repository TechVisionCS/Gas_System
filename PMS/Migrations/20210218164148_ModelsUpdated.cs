using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ModelsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "wms_product_tbl");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "wms_product_tbl");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "wms_product_tbl");

            migrationBuilder.AlterColumn<long>(
                name: "UnitId",
                table: "wms_product_tbl",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "wms_product_tbl",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "CategoryId",
                table: "wms_product_tbl",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TypeId",
                table: "wms_product_tbl",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "wms_product_tbl");

            migrationBuilder.AlterColumn<long>(
                name: "UnitId",
                table: "wms_product_tbl",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "Model",
                table: "wms_product_tbl",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<long>(
                name: "CategoryId",
                table: "wms_product_tbl",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "Category",
                table: "wms_product_tbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Type",
                table: "wms_product_tbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Unit",
                table: "wms_product_tbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
