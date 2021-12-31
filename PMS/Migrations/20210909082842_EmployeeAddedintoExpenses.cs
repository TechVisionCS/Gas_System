using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class EmployeeAddedintoExpenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "wms_return_details_tbl",
                newName: "TotalReturnPrice");

            migrationBuilder.AddColumn<long>(
                name: "CustomerId",
                table: "wms_stock_details_tbl",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "DetailsId",
                table: "wms_return_details_tbl",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "EmployeeId",
                table: "wms_expense_tbl",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "wms_employee_tbl",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "wms_country_tbl",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_wms_country_tbl_Name",
                table: "wms_country_tbl",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_wms_country_tbl_Name",
                table: "wms_country_tbl");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "wms_stock_details_tbl");

            migrationBuilder.DropColumn(
                name: "DetailsId",
                table: "wms_return_details_tbl");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "wms_expense_tbl");

            migrationBuilder.RenameColumn(
                name: "TotalReturnPrice",
                table: "wms_return_details_tbl",
                newName: "TotalPrice");

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "wms_employee_tbl",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "wms_country_tbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
