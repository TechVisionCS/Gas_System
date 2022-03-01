using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class sladf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms_product_tbl_gms_category_tbl_CategoryId",
                table: "gms_product_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_gms_supplier_tbl_gms_country_tbl_CountryId",
                table: "gms_supplier_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_gms_supplier_tbl_gms_province_tbl_ProvinceId",
                table: "gms_supplier_tbl");

            migrationBuilder.DropIndex(
                name: "IX_gms_supplier_tbl_CountryId",
                table: "gms_supplier_tbl");

            migrationBuilder.DropIndex(
                name: "IX_gms_supplier_tbl_ProvinceId",
                table: "gms_supplier_tbl");

            migrationBuilder.DropIndex(
                name: "IX_gms_product_tbl_CategoryId",
                table: "gms_product_tbl");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "gms_supplier_tbl");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "gms_supplier_tbl");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpenseDate",
                table: "gms_expense_tbl",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "gms_shop_tbl",
                columns: new[] { "Id", "Address_dr", "Address_en", "Address_ps", "CreatedAt", "DeletedAt", "Email1", "Email2", "LogoUrl", "Name_dr", "Name_en", "Name_ps", "Phone1", "Phone2", "Responsible1", "Responsible2", "Slog_dr", "Slog_en", "Slog_ps", "UpdatedAt", "UserId", "UserName" },
                values: new object[] { 1L, "شهر نو عقب مجید مال", "Share-now Majeed Mal back street", "شهر نو مجید مال شاته کوڅه", null, null, "info@techvision.af", "amanzai@techvision.af", null, "شزکت خدماتی تیک ویژن", "Techvision Consulting Service", "تیک ویژن خدماتی شرکت", "0770902698", "079892332", "Bismillah Amanzi", "AKbr", "تجارت تان جهانی سازید", "Make Your Bussiness Degital", "تجارت مو نړی وال کړی", null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "gms_shop_tbl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.AddColumn<long>(
                name: "CountryId",
                table: "gms_supplier_tbl",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProvinceId",
                table: "gms_supplier_tbl",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpenseDate",
                table: "gms_expense_tbl",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_gms_supplier_tbl_CountryId",
                table: "gms_supplier_tbl",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_gms_supplier_tbl_ProvinceId",
                table: "gms_supplier_tbl",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_gms_product_tbl_CategoryId",
                table: "gms_product_tbl",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms_product_tbl_gms_category_tbl_CategoryId",
                table: "gms_product_tbl",
                column: "CategoryId",
                principalTable: "gms_category_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms_supplier_tbl_gms_country_tbl_CountryId",
                table: "gms_supplier_tbl",
                column: "CountryId",
                principalTable: "gms_country_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms_supplier_tbl_gms_province_tbl_ProvinceId",
                table: "gms_supplier_tbl",
                column: "ProvinceId",
                principalTable: "gms_province_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
