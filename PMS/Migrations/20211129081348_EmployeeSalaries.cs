using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class EmployeeSalaries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Leavedate",
                table: "wms_employee_tbl",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(2660), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(4160), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(4197), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(4203), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(4208), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(1609), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5064), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5248), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5256), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5262), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5268), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5274), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5279), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5284), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5290), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(4234), new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7175), new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7240), new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7246), new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7251), new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7256), new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7262), new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7267), new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7273), new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7280), new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7285), new DateTime(2021, 11, 29, 12, 43, 45, 874, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(67), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(155), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(165), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(170), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(176), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(7160), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(7220), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(7226), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(7231), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(7236), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(7242), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(7246), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(762), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(757), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(752), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(747), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(742), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(737), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(731), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(726), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(721), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(716), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(711), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(706), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(701), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(695), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(622), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(617), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(608), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(603), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(598), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(593), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(588), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(551), new DateTime(2021, 11, 29, 12, 43, 45, 880, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(9094), new DateTime(2021, 11, 29, 12, 43, 45, 879, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9109), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9201), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9207), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9213), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9218), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9224), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9229), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9234), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9239), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9244), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9249), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9254), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9260), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9265), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9272), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9277), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9282), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9287), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9292), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9297), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9302), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9307), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9313), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9318), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9324), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9329), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9334), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9338), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9407), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9412), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9417), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9422), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9427), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9433), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9438), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9448), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9453), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9458), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9463), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9468), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9473), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9478), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9484), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9489), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9494), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9499), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9443), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2155), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2307), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2314), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2319), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2325), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2332), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2337), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2342), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2349), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2354), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2359), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2364), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2369), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2450), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2455), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2460), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2465), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2470), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2477), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2482), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2487), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2493), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2498), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2503), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2508), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2514), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2519), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2525), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2530), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2535), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2540), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2545), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2550), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2555), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2560), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2565), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2570), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2575), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2581), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2586), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2591), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2596), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2600), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2605), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2610), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2615), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2621), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2627), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2632), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2637), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2642), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2647), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2652), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2657), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2662), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2667), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2672), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2678), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2683), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2688), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2693), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2698), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2703), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2707), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2712), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2717), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2723), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2728), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2733), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2738), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2743), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2749), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2754), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2759), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2764), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2771), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2777), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2875), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2881), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2886), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2891), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2896), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2900), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2905), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2910), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2915), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2921), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2926), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2932), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2937), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2942), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2946), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2951), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2956), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2961), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2966), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2972), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2977), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2982), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2987), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2992), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(2998), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3002), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3007), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3012), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3021), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3027), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3032), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3037), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3042), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3047), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3052), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3057), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3062), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3067), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3073), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3078), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3083), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3088), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3093), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3098), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3103), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3108), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3113), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3118), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3124), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3129), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3134), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3139), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3144), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3149), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3154), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3159), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3164), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3169), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3175), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3180), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3185), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3190), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3195), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3199), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3321), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3327), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3332), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3338), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3343), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3348), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3353), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3358), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3363), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3368), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3373), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3378), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3383), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3389), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3394), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3399), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3404), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3409), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3414), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3419), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3424), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3429), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3434), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3440), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3444), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3451), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3456), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3462), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3466), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3471), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3476), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3481), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3486), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3492), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3497), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3502), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3507), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3513), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3518), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3523), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3528), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3533), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3539), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3544), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3549), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3554), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3560), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3565), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3570), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3575), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3580), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3585), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3591), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3596), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3601), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3606), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3611), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3616), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3620), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3625), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3630), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3635), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3641), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3691), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3697), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3702), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3707), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3712), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3717), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4196), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4295), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4301), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4307), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4311), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4317), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4324), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4329), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4334), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4339), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4344), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4349), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4354), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4359), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4366), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4371), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4377), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4382), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4386), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4392), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4397), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4402), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4407), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4412), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4417), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4422), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4428), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4433), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4438), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4443), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4448), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4452), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4457), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4463), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4468), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4474), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4478), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4483), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4488), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4493), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4498), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4503), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4508), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4513), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4518), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4524), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4529), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4534), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4539), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4544), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4548), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4553), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4621), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4626), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4631), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4638), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4643), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4648), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4653), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4658), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4663), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4668), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4673), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4678), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4684), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4689), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4694), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4699), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4704), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4709), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4714), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4718), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4723), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4728), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4734), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4739), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4744), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4749), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4756), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4761), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4766), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4771), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4776), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4781), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4787), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4792), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4797), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4802), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4806), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4811), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4816), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4821), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4826), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4832), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4837), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4842), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4847), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4852), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4857), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4862), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4867), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4872), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4877), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4883), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4888), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4893), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4897), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4902), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4907), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4912), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4917), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4922), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4971), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4977), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4982), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4992), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4997), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5002), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5007), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5012), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5017), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5022), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5027), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5032), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5037), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5042), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4987), new DateTime(2021, 11, 29, 12, 43, 45, 878, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7295), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7465), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7471), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7476), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7481), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7486), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7491), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7496), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7501), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7505), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7510), new DateTime(2021, 11, 29, 12, 43, 45, 877, DateTimeKind.Local).AddTicks(7512) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Leavedate",
                table: "wms_employee_tbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(9981), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(1988), new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(2037), new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(2046), new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(2053), new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(8050), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(1850), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(1999), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2008), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2016), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2109), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2120), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2128), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2135), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2143), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(5357), new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8564), new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8627), new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8635), new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8641), new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8647), new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8653), new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8659), new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8668), new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8675), new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8682), new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4751), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4843), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4853), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4858), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4865), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4130), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4186), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4192), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4198), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4203), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4208), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4213), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8077), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8072), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8067), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8062), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8057), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8052), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8047), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8042), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8037), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8032), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8027), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8022), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8017), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8013), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8008), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8002), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7996), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7991), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7986), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7981), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7975), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7938), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(6190), new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5164), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5304), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5312), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5319), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5327), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5337), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5344), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5351), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5359), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5366), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5373), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5380), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5387), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5395), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5402), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5409), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5417), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5425), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5432), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5439), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5446), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5454), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5461), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5468), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5475), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5483), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5490), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5497), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5505), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5512), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5519), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5525), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5533), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5542), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5549), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5562), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5570), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5577), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5585), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5592), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5599), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5606), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5613), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5620), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5628), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5635), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5555), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(5956), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6107), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6115), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6122), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6127), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6133), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6139), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6144), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6149), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6156), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6163), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6169), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6174), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6181), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6187), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6191), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6196), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6201), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6207), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6213), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6220), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6226), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6231), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6236), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6241), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6246), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6251), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6257), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6262), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6268), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6273), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6279), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6287), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6289) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6293), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6298), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6303), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6308), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6314), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6319), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6323), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6328), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6335), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6341), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6346), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6351), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6356), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6361), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6367), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6440), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6445), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6450), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6455), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6460), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6465), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6470), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6475), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6480), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6485) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6487), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6492), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6497), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6502), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6507), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6512), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6517), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6522), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6527), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6532), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6537), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6542), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6547), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6552), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6557), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6562), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6567), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6572), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6577), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6583), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6588), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6592), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6597), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6603), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6608), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6615), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6620), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6625), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6630), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6635), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6640), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6645), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6650), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6655), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6660), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6664), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6669), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6674), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6679), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6685), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6690), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6695), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6700), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6705), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6710), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6715), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6720), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6725), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6731), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6736), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6741), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6747), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6752), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6757), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6762), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6812), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6817), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6822), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6828), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6833), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6838), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6843), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6848), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6853), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6858), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6863), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6868), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6873), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6879), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6884), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6889), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6894), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6899), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6904), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6909), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6914), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6920), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6924), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6930), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6935), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6940), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6945), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6950), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6955), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6960), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6965), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6969), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6975), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6980), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6985), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6990), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6996), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7000), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7005), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7010), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7015), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7021), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7026), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7031), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7036), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7041), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7046), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7051), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7056), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7062), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7066), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7072), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7078), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7082), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7087), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7094), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7099), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7104), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7109), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7114), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7119), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7124), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7130), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7135), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7182), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7187), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7193), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7198), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7203), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7209), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7214), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7220), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7225), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7230), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7235), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7240), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7245), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7250), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7255), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7260), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7265), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7271), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7276), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7281), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7286), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7291), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7296), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7301), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7306), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7312), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7317), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7322), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7327), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7332), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7337), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7343), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7348), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7354), new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9597), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9712), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9720), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9727), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9732), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9739), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9746), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9751), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9757), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9764), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9769), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9774), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9779), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9784), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9789), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9794), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9799), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9804), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9810), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9816), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9824), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9830), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9837), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9844), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9852), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(101), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(110), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(115), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(120), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(125), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(130), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(135), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(140), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(145), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(150), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(156), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(162), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(167), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(172), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(177), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(182), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(187), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(192), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(198), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(204), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(209), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(213), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(218), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(223), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(228), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(233), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(239), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(244), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(249), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(254), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(264), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(270), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(275), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(280), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(284), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(289), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(294), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(299), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(304), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(310), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(315), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(320), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(325), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(330), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(335), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(340), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(345), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(351), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(356), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(362), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(367), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(372), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(377), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(382), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(386), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(391), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(396), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(402), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(406), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(417), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(471), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(477), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(482), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(487), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(492), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(497), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(502), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(507), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(513), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(518), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(523), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(528), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(533), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(538), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(543), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(548), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(553), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(558), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(565), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(572), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(577), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(606), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(611), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(616), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(621), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(625), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(630), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(635), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(641), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(646), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(656), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(661), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(666), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(671), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(676), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(681), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(685), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(691), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(696), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(701), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(706), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(651), new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1661), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1758), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1764), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1770), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1774), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1779), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1784), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1790), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1797), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1802), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1806), new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1808) });
        }
    }
}
