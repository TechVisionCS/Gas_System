using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class insdfkj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "gms_expense_tbl");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpenseDate",
                table: "gms_expense_tbl",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpenseDate",
                table: "gms_expense_tbl");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "gms_expense_tbl",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
