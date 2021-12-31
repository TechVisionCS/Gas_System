using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ExpanseCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desciption",
                table: "wms_expense_tbl");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "wms_expense_tbl",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "wms_expense_category_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_expense_category_tbl", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_wms_expense_category_tbl_Name",
                table: "wms_expense_category_tbl",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wms_expense_category_tbl");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "wms_expense_tbl");

            migrationBuilder.AddColumn<string>(
                name: "Desciption",
                table: "wms_expense_tbl",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
