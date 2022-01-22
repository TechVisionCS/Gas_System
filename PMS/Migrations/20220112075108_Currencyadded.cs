﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class Currencyadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SaleCurrency",
                table: "wms_sale_tbl",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PurchaseCurrency",
                table: "wms_purchase_tbl",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaleCurrency",
                table: "wms_sale_tbl");

            migrationBuilder.DropColumn(
                name: "PurchaseCurrency",
                table: "wms_purchase_tbl");
        }
    }
}
