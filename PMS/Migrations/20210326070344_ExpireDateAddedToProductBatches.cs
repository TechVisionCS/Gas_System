using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ExpireDateAddedToProductBatches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QRCode",
                table: "wms_product_batch_tbl");

            migrationBuilder.RenameColumn(
                name: "SalePrice",
                table: "wms_product_batch_tbl",
                newName: "SellPrice");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                table: "wms_purchase_details_tbl",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                table: "wms_product_batch_tbl",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "wms_purchase_details_tbl");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "wms_product_batch_tbl");

            migrationBuilder.RenameColumn(
                name: "SellPrice",
                table: "wms_product_batch_tbl",
                newName: "SalePrice");

            migrationBuilder.AddColumn<string>(
                name: "QRCode",
                table: "wms_product_batch_tbl",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
