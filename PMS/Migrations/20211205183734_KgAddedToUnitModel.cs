using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class KgAddedToUnitModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "KgAmount",
                table: "wms_unit_tbl",
                nullable: false,
                defaultValue: 0f);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KgAmount",
                table: "wms_unit_tbl");

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
    }
}
