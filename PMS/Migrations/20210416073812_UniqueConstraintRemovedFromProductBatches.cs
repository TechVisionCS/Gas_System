using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class UniqueConstraintRemovedFromProductBatches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_wms_product_batch_tbl_BatchId",
                table: "wms_product_batch_tbl");

            migrationBuilder.AlterColumn<string>(
                name: "BatchId",
                table: "wms_product_batch_tbl",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BatchId",
                table: "wms_product_batch_tbl",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_wms_product_batch_tbl_BatchId",
                table: "wms_product_batch_tbl",
                column: "BatchId",
                unique: true,
                filter: "[BatchId] IS NOT NULL");
        }
    }
}
