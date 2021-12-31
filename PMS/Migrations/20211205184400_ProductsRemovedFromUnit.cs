using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ProductsRemovedFromUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wms_product_tbl_wms_unit_tbl_UnitId",
                table: "wms_product_tbl");

            migrationBuilder.DropIndex(
                name: "IX_wms_product_tbl_UnitId",
                table: "wms_product_tbl");

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(6129), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(7658), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(7694), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(7700), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(7706), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(4603), new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8202), new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8333), new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8339), new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8345), new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8351), new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8358), new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8364), new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8369), new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8374), new DateTime(2021, 12, 5, 23, 13, 58, 10, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(3635), new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6538), new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6604), new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6610), new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6615), new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6620), new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6625), new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6631), new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6637), new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6642), new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6647), new DateTime(2021, 12, 5, 23, 13, 58, 5, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(9705), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(9796), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(9805), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(9811), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(9816), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(628), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(684), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(689), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(697), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(702), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(707), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(711), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4244), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4239), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4235), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4230), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4225), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4220), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4214), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4209), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4204), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4199), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4194), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4189), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4184), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4179), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4174), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4169), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4163), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4158), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4153), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4147), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4141), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4104), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(2616), new DateTime(2021, 12, 5, 23, 13, 58, 11, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8664), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8756), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8763), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8768), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8773), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8780), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8854), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8859), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8864), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8869), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8874), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8880), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8885), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8890), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8896), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8901), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8906), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8911), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8917), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8922), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8926), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8931), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8936), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8941), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8948), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8953), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8958), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8963), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8968), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8973), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8978), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8984), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8989), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8994), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(8999), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9009), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9014), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9018), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9023), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9028), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9033), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9039), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9044), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9049), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9054), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9060), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9004), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1683), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1816), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1825), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1830), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1835), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1840), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1845), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1850), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1856), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1861), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1866), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1871), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1876), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1881), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1886), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1891), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1896), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1901), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1907), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1913), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1918), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1923), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1928), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1933), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1938), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1943), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1948), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1954), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1959), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1964), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1969), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1974), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1979), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1985), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1989), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1995), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2000), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2006), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2011), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2016), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2021), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2026), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2031), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2036), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2041), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2046), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2051), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2057), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2062), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2067), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2072), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2079), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2085), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2090), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2094), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2099), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2180), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2186), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2191), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2196), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2202), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2208), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2213), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2219), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2224), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2229), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2235), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2241), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2246), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2251), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2256), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2261), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2266), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2271), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2276), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2281), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2287), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2292), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2297), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2302), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2307), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2312), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2317), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2322), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2327), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2332), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2338), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2343), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2348), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2353), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2359), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2363), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2368), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2373), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2378), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2383), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2390), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2395), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2399), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2404), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2409), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2414), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2420), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2425), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2430), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2436), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2441), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2446), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2451), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2456), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2461), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2466), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2471), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2477), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2482), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2488), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2493), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2498), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2503), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2507), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2609), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2615), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2620), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2625), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2630), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2636), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2641), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2646), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2651), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2656), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2661), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2666), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2671), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2676), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2681), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2687), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2692), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2697), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2702), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2707), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2712), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2717), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2722), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2727), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2733), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2738), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2743), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2748), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2753), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2758), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2764), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2769), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2774), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2779), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2785), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2884), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2889), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2894), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2899), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2904), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2909), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2913), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2918), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2923), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2929), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2934), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2940), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2945), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2951), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2958), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2966), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2975), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2980), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2985), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2990), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2995), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3000), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3005), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3010), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3015), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3020), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3025), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3030), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3094), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3099), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3105), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3114), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3120), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3125), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3130), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3135), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3140), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3145), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3151), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3156), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3161), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3165), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3170), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3175), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3180), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3185), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3190), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3195), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3200), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3206), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3210), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3215), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3220), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3225), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3231), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3748), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3838), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3845), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3851), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3856), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3861), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3867), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3873), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3878), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3883), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3888), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3893), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3898), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3904), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3909), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3915), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3921), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3928), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3934), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3939), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3943), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3948), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3954), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3959), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3964), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3969), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3976), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3981), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3986), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3991), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3995), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4003), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4007), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4084), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4090), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4096), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4102), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4107), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4112), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4116), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4121), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4126), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4131), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4136), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4141), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4147), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4152), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4157), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4162), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4167), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4172), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4177), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4182), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4187), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4192), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4199), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4204), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4209), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4214), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4219), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4225), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4230), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4235), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4241), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4246), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4251), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4257), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4261), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4267), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4272), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4277), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4282), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4287), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4292), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4298), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4303), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4308), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4313), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4318), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4323), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4328), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4333), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4337), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4342), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4348), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4353), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4358), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4363), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4368), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4373), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4378), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4384), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4388), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4458), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4461) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4464), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4469), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4474), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4479), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4483), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4488), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4493), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4498), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4503), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4509), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4514), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4519), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4523), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4528), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4534), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4538), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4543), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4548), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4553), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4559), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4565), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4575), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4580), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4585), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4590), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4599), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4604), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4615), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4619), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4625), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4629), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4570), new DateTime(2021, 12, 5, 23, 13, 58, 9, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(6944), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7030), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7103), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7109), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7114), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7119), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7124), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7130), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7135), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7145), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7149), new DateTime(2021, 12, 5, 23, 13, 58, 8, DateTimeKind.Local).AddTicks(7152) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(7054), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(9162), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(9222), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(9230), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(9237), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(491), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(5667), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(5840), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(5848), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(5857), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(5865), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(5873), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(6059), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(6071), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(6078), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(5109), new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(8906), new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(8999), new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9006), new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9015), new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9022), new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9029), new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9036), new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9044), new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9051), new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9058), new DateTime(2021, 12, 5, 23, 7, 31, 887, DateTimeKind.Local).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(1946), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(2033), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(2038), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(2044), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(2048), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(9222), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(9309), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(9318), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(9326), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(9331), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(9337), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(9343), new DateTime(2021, 12, 5, 23, 7, 31, 894, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4355), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4348), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4342), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4335), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4328), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4322), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4314), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4307), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4299), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4292), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4286), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4279), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4273), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4267), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4261), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4254), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4246), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4239), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4233), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4227), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4229) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4220), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4155), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(2127), new DateTime(2021, 12, 5, 23, 7, 31, 895, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3779), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3922), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3932), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3941), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3949), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3958), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3973), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3981), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3989), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(3998), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4006), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4013), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4021), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4031), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4039), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4047), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4055), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4063), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4071), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4079), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4086), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4094), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4103), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4112), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4119), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4127), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4135), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4143), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4151), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4158), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4166), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4174), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4182), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4190), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4207), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4215), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4222), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4230), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4238), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4246), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4254), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4261), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4269), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4277), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4285), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4198), new DateTime(2021, 12, 5, 23, 7, 31, 893, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1368), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1568), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1577), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1583), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1591), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1598), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1606), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1614), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1623), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1631), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1639), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1646), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1654), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1661), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1669), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1678), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1685), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1693), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1701), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1708), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1716), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1724), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1732), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1740), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1748), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1755), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1762), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1769), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1777), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1783), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1790), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1797), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1805), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1811), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1818), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1825), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1834), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1841), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1848), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1855), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1862), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1868), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1876), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1883), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1890), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1897), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1904), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1913), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1920), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1928), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2072), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2081), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2088), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2095), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2102), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2110), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2118), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2126), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2133), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2140), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2147), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2154), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2162), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2169), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2176), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2183), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2191), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2198), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2205), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2213), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2220), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2227), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2233), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2240), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2246), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2252), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2260), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2267), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2276), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2283), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2317), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2324), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2331), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2338), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2346), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2354), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2361), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2367), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2375), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2382), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2389), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2396), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2402), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2409), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2417), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2424), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2431), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2439), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2446), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2453), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2461), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2468), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2475), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2483), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2490), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2498), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2506), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2513), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2521), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2528), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2535), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2542), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2550), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2556), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2619), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2625), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2630), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2635), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2640), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2646), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2651), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2656), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2661), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2666), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2671), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2678), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2685), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2690), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2695), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2700), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2705), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2710), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2715), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2720), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2725), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2730), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2735), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2740), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2745), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2750), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2755), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2760), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2765), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2770), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2779), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2784), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2790), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2794), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2799), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2804), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2809), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2815), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2819), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2824), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2830), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2835), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2840), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2845), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2851), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2858), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2864), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2871), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2878), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2884), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2891), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2897), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2903), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2909), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2915), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2922), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2928), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2935), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2941), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2949), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2957), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2965), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2972), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2979), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3072), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3082), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3090), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3098), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3105), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3114), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3122), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3131), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3138), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3146), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3154), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3161), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3168), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3176), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3184), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3192), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3200), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3208), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3215), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3223), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3231), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3239), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3246), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3253), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3261), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3269), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3276), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3284), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3292), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3299), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3307), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3315), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(6863), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(6962), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(6969), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(6974), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(6980), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(6984), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(6995), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7000), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7006), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7012), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7017), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7022), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7027), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7033), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7038), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7043), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7049), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7054), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7059), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7064), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7074), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7080), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7087), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7094), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7100), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7107), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7115), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7217), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7226), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7233), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7240), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7247), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7254), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7261), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7268), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7276), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7283), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7290), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7297), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7304), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7311), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7318), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7326), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7333), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7340), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7348), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7356), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7364), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7371), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7378), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7385), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7392), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7399), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7406), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7412), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7420), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7427), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7435), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7442), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7450), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7458), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7466), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7474), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7481), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7490), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7498), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7506), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7513), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7521), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7529), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7537), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7545), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7552), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7560), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7569), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7577), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7585), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7593), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7600), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7608), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7616), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7623), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7631), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7639), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7646), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7654), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7662), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7740), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7749), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7757), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7765), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7773), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7781), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7790), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7798), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7806), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7813), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7821), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7829), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7837), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7845), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7853), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7861), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7870), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7877), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7885), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7893), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7900), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7908), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7916), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7923), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7931), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7939), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7947), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7954), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7970), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7978), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7986), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7994), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(8002), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(8009), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(8017), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(8026), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(8034), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(8041), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(8049), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7962), new DateTime(2021, 12, 5, 23, 7, 31, 892, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8294), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8410), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8420), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8428), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8435), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8443), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8450), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8457), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8466), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8473), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8510), new DateTime(2021, 12, 5, 23, 7, 31, 891, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.CreateIndex(
                name: "IX_wms_product_tbl_UnitId",
                table: "wms_product_tbl",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_wms_product_tbl_wms_unit_tbl_UnitId",
                table: "wms_product_tbl",
                column: "UnitId",
                principalTable: "wms_unit_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
