using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class SupplierModelRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wms_supplier_ledger_tbl_wms_country_tbl_Countryid",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_wms_supplier_ledger_tbl_wms_province_tbl_Provinceid",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropTable(
                name: "SupplierLedgers");

            migrationBuilder.DropIndex(
                name: "IX_wms_supplier_ledger_tbl_Countryid",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_supplier_ledger_tbl_Provinceid",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "Countryid",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "Provinceid",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.RenameColumn(
                name: "PreviousBalance",
                table: "wms_supplier_ledger_tbl",
                newName: "Debit");

            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "wms_supplier_ledger_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Credit",
                table: "wms_supplier_ledger_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "wms_supplier_ledger_tbl",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "wms_supplier_ledger_tbl",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "EntityId",
                table: "wms_supplier_ledger_tbl",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "TransCode",
                table: "wms_supplier_ledger_tbl",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VoucherNo",
                table: "wms_supplier_ledger_tbl",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isClosed",
                table: "wms_supplier_ledger_tbl",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "wms_supplier_tbl",
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
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Countryid = table.Column<long>(nullable: false),
                    Provinceid = table.Column<long>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    PreviousBalance = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_supplier_tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wms_supplier_tbl_wms_country_tbl_Countryid",
                        column: x => x.Countryid,
                        principalTable: "wms_country_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wms_supplier_tbl_wms_province_tbl_Provinceid",
                        column: x => x.Provinceid,
                        principalTable: "wms_province_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_wms_supplier_tbl_Countryid",
                table: "wms_supplier_tbl",
                column: "Countryid");

            migrationBuilder.CreateIndex(
                name: "IX_wms_supplier_tbl_Provinceid",
                table: "wms_supplier_tbl",
                column: "Provinceid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wms_supplier_tbl");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "Credit",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "TransCode",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "VoucherNo",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.DropColumn(
                name: "isClosed",
                table: "wms_supplier_ledger_tbl");

            migrationBuilder.RenameColumn(
                name: "Debit",
                table: "wms_supplier_ledger_tbl",
                newName: "PreviousBalance");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "wms_supplier_ledger_tbl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Countryid",
                table: "wms_supplier_ledger_tbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "wms_supplier_ledger_tbl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "wms_supplier_ledger_tbl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "wms_supplier_ledger_tbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "wms_supplier_ledger_tbl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Provinceid",
                table: "wms_supplier_ledger_tbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "SupplierLedgers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Balance = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Credit = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityId = table.Column<long>(type: "bigint", nullable: false),
                    TransCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isClosed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierLedgers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplierLedgers_wms_supplier_ledger_tbl_EntityId",
                        column: x => x.EntityId,
                        principalTable: "wms_supplier_ledger_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_wms_supplier_ledger_tbl_Countryid",
                table: "wms_supplier_ledger_tbl",
                column: "Countryid");

            migrationBuilder.CreateIndex(
                name: "IX_wms_supplier_ledger_tbl_Provinceid",
                table: "wms_supplier_ledger_tbl",
                column: "Provinceid");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLedgers_EntityId",
                table: "SupplierLedgers",
                column: "EntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_wms_supplier_ledger_tbl_wms_country_tbl_Countryid",
                table: "wms_supplier_ledger_tbl",
                column: "Countryid",
                principalTable: "wms_country_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_wms_supplier_ledger_tbl_wms_province_tbl_Provinceid",
                table: "wms_supplier_ledger_tbl",
                column: "Provinceid",
                principalTable: "wms_province_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
