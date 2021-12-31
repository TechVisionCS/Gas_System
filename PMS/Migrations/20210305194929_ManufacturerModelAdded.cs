using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ManufacturerModelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "wms_cash_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "SupplierLedgers");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "wms_supplier_ledger_tbl",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "wms_supplier_ledger_tbl",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<long>(
                name: "ManufacturerId",
                table: "wms_product_tbl",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "EntityType",
                table: "wms_cash_ledger_tbl",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "wms_manufacturer_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    CountryName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_manufacturer_tbl", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wms_manufacturer_tbl");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "wms_product_tbl");

            migrationBuilder.DropColumn(
                name: "EntityType",
                table: "wms_cash_ledger_tbl");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "wms_supplier_ledger_tbl",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "wms_supplier_ledger_tbl",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "wms_cash_ledger_tbl",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "SupplierLedgers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
