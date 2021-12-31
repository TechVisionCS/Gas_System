using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class PartnerInvestmentModelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "wms_partner_ledger_tbl");

            migrationBuilder.CreateTable(
                name: "wms_partner_investment_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    PartnerId = table.Column<long>(nullable: false),
                    PartnerName = table.Column<string>(nullable: true),
                    InvestmentDate = table.Column<DateTime>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Desciption = table.Column<string>(nullable: false),
                    TransCode = table.Column<string>(nullable: true),
                    InvestmetType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_partner_investment_tbl", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wms_partner_investment_tbl");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "wms_partner_ledger_tbl",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
