using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class FlagForUpdateAddedToWastageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Flg",
                table: "wms_wastage_tbl",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Flg",
                table: "wms_wastage_tbl");
        }
    }
}
