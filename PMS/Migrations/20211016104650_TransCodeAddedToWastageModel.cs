using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class TransCodeAddedToWastageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TransCode",
                table: "wms_wastage_tbl",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransCode",
                table: "wms_wastage_tbl");
        }
    }
}
