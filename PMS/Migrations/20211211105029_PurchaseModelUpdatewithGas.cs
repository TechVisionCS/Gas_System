using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class PurchaseModelUpdatewithGas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "wms_purchase_details_tbl");

            migrationBuilder.DropColumn(
                name: "SellPrice",
                table: "wms_purchase_details_tbl");

            migrationBuilder.AddColumn<long>(
                name: "UnitId",
                table: "wms_purchase_details_tbl",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "wms_purchase_details_tbl");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                table: "wms_purchase_details_tbl",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SellPrice",
                table: "wms_purchase_details_tbl",
                type: "decimal(38, 2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
