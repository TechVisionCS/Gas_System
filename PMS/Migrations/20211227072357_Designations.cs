using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class Designations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "wms_designation_tbl",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name", "Status", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1L, null, null, null, "Admin", 1, null, null, "System Defined" },
                    { 2L, null, null, null, "Cashir", 1, null, null, "System Defined" },
                    { 3L, null, null, null, "Feul Attendant", 1, null, null, "System Defined" },
                    { 4L, null, null, null, "Mechanic", 1, null, null, "System Defined" },
                    { 5L, null, null, null, "Car Wash", 1, null, null, "System Defined" },
                    { 6L, null, null, null, "Gaurd", 1, null, null, "System Defined" },
                    { 7L, null, null, null, "Pharmacist", 1, null, null, "System Defined" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "wms_designation_tbl",
                keyColumn: "Id",
                keyValue: 7L);
        }
    }
}
