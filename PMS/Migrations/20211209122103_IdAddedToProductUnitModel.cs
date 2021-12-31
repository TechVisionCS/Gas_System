using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class IdAddedToProductUnitModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "ProductUnits",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductUnits");
        }
    }
}
