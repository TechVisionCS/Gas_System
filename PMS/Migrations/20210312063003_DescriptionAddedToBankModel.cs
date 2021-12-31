using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class DescriptionAddedToBankModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "wms_bank_tbl",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "wms_bank_tbl");
        }
    }
}
