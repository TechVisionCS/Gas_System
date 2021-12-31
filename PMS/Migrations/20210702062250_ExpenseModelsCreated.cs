using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ExpenseModelsCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BankId",
                table: "wms_expense_tbl",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "wms_expense_tbl",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillNumber",
                table: "wms_expense_tbl",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "wms_asset_handover_Details_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    AssetHandoverId = table.Column<long>(nullable: false),
                    AssetId = table.Column<long>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_asset_handover_Details_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_asset_handover_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    EmployeeId = table.Column<long>(nullable: false),
                    HandoverDate = table.Column<DateTime>(nullable: true),
                    HandoverRequestId = table.Column<string>(nullable: true),
                    HandoverRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_asset_handover_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_asset_return",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_asset_return", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_asset_stock_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    AssetId = table.Column<long>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: true),
                    InQty = table.Column<int>(nullable: false),
                    OutQty = table.Column<int>(nullable: false),
                    StockQty = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_asset_stock_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_asset_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    AssetCategoryId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    InQty = table.Column<int>(nullable: false),
                    OutQty = table.Column<int>(nullable: false),
                    StockQty = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_asset_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_assets_category_tbl",
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
                    table.PrimaryKey("PK_wms_assets_category_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_designation_tbl",
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
                    table.PrimaryKey("PK_wms_designation_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_employee_tbl",
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
                    Lastname = table.Column<string>(nullable: false),
                    Fathername = table.Column<string>(nullable: false),
                    NationalIdnumber = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Countryid = table.Column<long>(nullable: false),
                    Provinceid = table.Column<long>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    MaritalStatus = table.Column<int>(nullable: false),
                    EducationalDegree = table.Column<int>(nullable: false),
                    BaseSalary = table.Column<decimal>(type: "decimal (38,2)", nullable: false),
                    Birthdate = table.Column<string>(nullable: true),
                    Hiredate = table.Column<string>(nullable: true),
                    Leavedate = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    DesignationId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_employee_tbl", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_wms_asset_tbl_Name",
                table: "wms_asset_tbl",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_wms_assets_category_tbl_Name",
                table: "wms_assets_category_tbl",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_wms_employee_tbl_NationalIdnumber",
                table: "wms_employee_tbl",
                column: "NationalIdnumber",
                unique: true,
                filter: "[NationalIdnumber] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wms_asset_handover_Details_tbl");

            migrationBuilder.DropTable(
                name: "wms_asset_handover_tbl");

            migrationBuilder.DropTable(
                name: "wms_asset_return");

            migrationBuilder.DropTable(
                name: "wms_asset_stock_tbl");

            migrationBuilder.DropTable(
                name: "wms_asset_tbl");

            migrationBuilder.DropTable(
                name: "wms_assets_category_tbl");

            migrationBuilder.DropTable(
                name: "wms_designation_tbl");

            migrationBuilder.DropTable(
                name: "wms_employee_tbl");

            migrationBuilder.DropColumn(
                name: "BankId",
                table: "wms_expense_tbl");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "wms_expense_tbl");

            migrationBuilder.DropColumn(
                name: "BillNumber",
                table: "wms_expense_tbl");
        }
    }
}
