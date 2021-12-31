using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ShopModelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wms_shop_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name_en = table.Column<string>(nullable: false),
                    Name_ps = table.Column<string>(nullable: true),
                    Name_dr = table.Column<string>(nullable: true),
                    LogoUrl = table.Column<string>(nullable: false),
                    Phone1 = table.Column<string>(nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    Email1 = table.Column<string>(nullable: true),
                    Email2 = table.Column<string>(nullable: true),
                    Address_en = table.Column<string>(nullable: true),
                    Address_ps = table.Column<string>(nullable: true),
                    Address_dr = table.Column<string>(nullable: true),
                    Responsible1 = table.Column<string>(nullable: true),
                    Responsible2 = table.Column<string>(nullable: true),
                    Slog_en = table.Column<string>(nullable: true),
                    Slog_ps = table.Column<string>(nullable: true),
                    Slog_dr = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_shop_tbl", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wms_shop_tbl");
        }
    }
}
