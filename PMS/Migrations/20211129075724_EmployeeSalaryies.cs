using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class EmployeeSalaryies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pms_employee_ledger_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    EntityId = table.Column<long>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    VoucherNo = table.Column<string>(nullable: true),
                    Debit = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Credit = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TransCode = table.Column<string>(nullable: true),
                    isClosed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pms_employee_ledger_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pms_employee_salaries_tbl",
                columns: table => new
                {
                    EmployeeId = table.Column<long>(nullable: false),
                    SalaryYear = table.Column<int>(nullable: false),
                    SalaryMonth = table.Column<int>(nullable: false),
                    Id = table.Column<long>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    TotalWorkDays = table.Column<int>(nullable: false),
                    OverTime = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Bounce = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    NetSalary = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Paid = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Balanced = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    isPaid = table.Column<bool>(nullable: false),
                    TransCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pms_employee_salaries_tbl", x => new { x.EmployeeId, x.SalaryYear, x.SalaryMonth });
                    table.ForeignKey(
                        name: "FK_pms_employee_salaries_tbl_wms_employee_tbl_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "wms_employee_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "wms_assets_category_tbl",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name", "Status", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 5L, new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(2053), null, "", "Land", 1, new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(2056), null, "System Defined" },
                    { 4L, new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(2046), null, "", "Buildings", 1, new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(2049), null, "System Defined" },
                    { 3L, new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(2037), null, "", "Machinery", 1, new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(2040), null, "System Defined" },
                    { 2L, new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(1988), null, "", "Office furniture", 1, new DateTime(2021, 11, 29, 12, 27, 22, 137, DateTimeKind.Local).AddTicks(1999), null, "System Defined" },
                    { 1L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(9981), null, "", "Vehicles", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(9994), null, "System Defined" }
                });

            migrationBuilder.InsertData(
                table: "wms_bank_tbl",
                columns: new[] { "Id", "AccountName", "AccountNo", "BankName", "Branch", "CreatedAt", "DeletedAt", "Description", "Signature", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1L, "System Defiand", "Editable", "Islamic Bank of Afghanistan", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(8050), null, "Editebal", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(8062), null, "System Defined" },
                    { 9L, "System Defiand", "Editable", "Ghazanfar bank", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2135), null, "Editebal", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2139), null, "System Defined" },
                    { 10L, "System Defiand", "Editable", "Afghan United Bank", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2143), null, "Editebal", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2146), null, "System Defined" },
                    { 7L, "System Defiand", "Editable", "New Kabul Bank", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2120), null, "Editebal", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2123), null, "System Defined" },
                    { 6L, "System Defiand", "Editable", "Kabul Bank", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2109), null, "Editebal", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2114), null, "System Defined" },
                    { 5L, "System Defiand", "Editable", "First MicroFinance Bank-Afghanistan", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2016), null, "Editebal", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2021), null, "System Defined" },
                    { 4L, "System Defiand", "Editable", "Bank-e-Millie Afghan", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2008), null, "Editebal", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2011), null, "System Defined" },
                    { 3L, "System Defiand", "Editable", "Azizi Bank", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(1999), null, "Editebal", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2003), null, "System Defined" },
                    { 2L, "System Defiand", "Editable", "Afghanistan International Bank", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(1850), null, "Editebal", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(1863), null, "System Defined" },
                    { 8L, "System Defiand", "Editable", "Pashtany Bank", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2128), null, "Editebal", "Editable", new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(2131), null, "System Defined" }
                });

            migrationBuilder.InsertData(
                table: "wms_category_tbl",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name", "Status", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 7L, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8653), null, "remedy to counteract the effects of poison needed the antidote for the snake's venom. 2 : something that relieves, prevents, or counteracts an antidote to boredom", "Antidotes", 1, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8656), null, "System Defined" },
                    { 12L, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8682), null, " ", "Enzymya", 1, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8684), null, "System Defined" },
                    { 9L, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8668), null, " ", "Antifungals", 1, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8670), null, "System Defined" },
                    { 8L, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8659), null, "drug that is effective against vomiting and nausea", "Antiemetics", 1, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8662), null, "System Defined" },
                    { 6L, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8647), null, " used to prevent or treat depression.", "Antidepressants", 1, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8649), null, "System Defined" },
                    { 10L, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8675), null, " category of drugs used to prevent anxiety and treat anxiety related to several anxiety disorders)", "Anxiolytic", 1, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8677), null, "System Defined" },
                    { 4L, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8635), null, "Anticonvulsants suppress the excessive rapid firing of neurons during seizures. Anticonvulsants also prevent the spread of the seizure within the brain.", "Anticonvulsants", 1, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8637), null, "System Defined" },
                    { 3L, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8627), null, "medications that destroy or slow down the growth of bacteria", "Antibacterials", 1, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8630), null, "System Defined" },
                    { 2L, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8564), null, "any agent that produces a local or general loss of sensation, including pain. Anesthetics achieve this effect by acting on the brain or peripheral nervous system to suppress responses to sensory stimulation", "Anesthetics", 1, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8588), null, "System Defined" },
                    { 1L, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(5357), null, "including opioids and non-opioids designed to relieve pain without causing the loss of consciousness.", "Analgesics", 1, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(6609), null, "System Defined" },
                    { 5L, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8641), null, "A cholinesterase inhibitor used to manage mild to moderate dementia associated with Alzheimer's Disease.", "Antidementia ", 1, new DateTime(2021, 11, 29, 12, 27, 22, 130, DateTimeKind.Local).AddTicks(8642), null, "System Defined" }
                });

            migrationBuilder.InsertData(
                table: "wms_country_tbl",
                columns: new[] { "Id", "Code", "CreatedAt", "DeletedAt", "Name", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1L, "AFN", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4751), null, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4763), null, "System_Populated" },
                    { 2L, "PK", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4843), null, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4847), null, "System_Populated" },
                    { 3L, "IND", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4853), null, "India", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4855), null, "System_Populated" },
                    { 4L, "TUR", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4858), null, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4861), null, "System_Populated" },
                    { 5L, "IR", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4865), null, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(4867), null, "System_Populated" }
                });

            migrationBuilder.InsertData(
                table: "wms_designation_tbl",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name", "Status", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 7L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4213), null, null, "Pharmacist", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4215), null, "System Defined" },
                    { 6L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4208), null, null, "SalesMan", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4210), null, "System Defined" },
                    { 5L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4203), null, null, "Pharmacy IT Specialist", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4206), null, "System Defined" },
                    { 4L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4198), null, null, "Medicines Safety Manager", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4201), null, "System Defined" },
                    { 2L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4186), null, null, "Checking Technician", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4189), null, "System Defined" },
                    { 1L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4130), null, null, "Admin", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4141), null, "System Defined" },
                    { 3L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4192), null, null, "Dispensary Manager", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(4194), null, "System Defined" }
                });

            migrationBuilder.InsertData(
                table: "wms_expense_category_tbl",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name", "Status", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 10L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8032), null, "", "Business meals", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8034), null, "System Defined" },
                    { 1L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8077), null, "", "Printing", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8079), null, "System Defined" },
                    { 2L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8072), null, "", "repairs", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8074), null, "System Defined" },
                    { 3L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8067), null, "", "Maintenance", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8069), null, "System Defined" },
                    { 4L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8062), null, "", "Bank fees", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8064), null, "System Defined" },
                    { 5L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8057), null, "", "Meals", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8059), null, "System Defined" },
                    { 6L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8052), null, "", "Health Insurance", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8054), null, "System Defined" },
                    { 7L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8047), null, "", "Insurance", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8050), null, "System Defined" },
                    { 8L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8042), null, "", "Vehicle expenses", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8044), null, "System Defined" },
                    { 9L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8037), null, "", "travel expenses", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8039), null, "System Defined" },
                    { 11L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8027), null, "", "Entertainment", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8029), null, "System Defined" },
                    { 20L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7981), null, "", "Water", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7983), null, "System Defined" },
                    { 13L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8017), null, "", "Website", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8019), null, "System Defined" },
                    { 12L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8022), null, "", "Software", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8024), null, "System Defined" },
                    { 22L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7938), null, "", "Electricity", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7948), null, "System Defined" },
                    { 21L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7975), null, "", "Gas", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7978), null, "System Defined" },
                    { 19L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7986), null, "", "Air conditioning", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7988), null, "System Defined" },
                    { 23L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(6190), null, "", "Rent ", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(6204), null, "System Defined" },
                    { 17L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7996), null, "", "Cellphones", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7999), null, "System Defined" },
                    { 16L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8002), null, "Track your spending on pens, folders, disinfectant wipes, trash bags, and other cleaning supplies", "Office supplies", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8004), null, "System Defined" },
                    { 15L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8008), null, "", "Advertising", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8010), null, "System Defined" },
                    { 14L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8013), null, "", "marketing", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(8015), null, "System Defined" },
                    { 18L, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7991), null, "", "Trash", 1, new DateTime(2021, 11, 29, 12, 27, 22, 136, DateTimeKind.Local).AddTicks(7993), null, "System Defined" }
                });

            migrationBuilder.InsertData(
                table: "wms_manufacturer_tbl",
                columns: new[] { "Id", "CountryName", "CreatedAt", "DeletedAt", "Description", "Name", "Status", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 26L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5483), null, "Pakistan", "Hilton Pharma ", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5486), null, "System_Populated" },
                    { 34L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5542), null, "Pakistan", "Sanofi", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5545), null, "System_Populated" },
                    { 27L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5490), null, "Pakistan", " Ferozsons Laboratorie", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5493), null, "System_Populated" },
                    { 28L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5497), null, "Pakistan", "Pfizer Pakistan", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5500), null, "System_Populated" },
                    { 29L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5505), null, "Pakistan", "Bayer - pK", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5507), null, "System_Populated" },
                    { 30L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5512), null, "Pakistan", "Macter pharma", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5514), null, "System_Populated" },
                    { 31L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5519), null, "Pakistan", "PharmEvo", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5521), null, "System_Populated" },
                    { 32L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5525), null, "Pakistan", "Martin Dow", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5528), null, "System_Populated" },
                    { 33L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5533), null, "Pakistan", "Novartis", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5536), null, "System_Populated" },
                    { 35L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5549), null, "Pakistan", "Bosch pharma", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5552), null, "System_Populated" },
                    { 40L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5592), null, "India", "Torrent Pharmaceuticals", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5595), null, "System_Populated" },
                    { 36L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5562), null, "India", "Dr. Reddy’s Laboratories Ltd", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5566), null, "System_Populated" },
                    { 37L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5570), null, "India", "Divi’s Laboratories", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5573), null, "System_Populated" },
                    { 38L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5577), null, "India", "Cipla", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5580), null, "System_Populated" },
                    { 39L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5585), null, "India", "Aurobindo Pharma", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5588), null, "System_Populated" },
                    { 41L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5599), null, "India", "Lupin Ltd", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5602), null, "System_Populated" },
                    { 42L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5606), null, "India", "Zydus Cadila Healthcare", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5609), null, "System_Populated" },
                    { 43L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5613), null, "India", "Abbott India", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5616), null, "System_Populated" },
                    { 44L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5620), null, "India", "Alkem Laboratories", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5623), null, "System_Populated" },
                    { 46L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5635), null, "India", "Lupin", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5638), null, "System_Populated" },
                    { 25L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5475), null, "Pakistan", " Sami Pharmaceutical", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5478), null, "System_Populated" },
                    { 47L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5555), null, "India", "Sun Pharmaceutical Industries Ltd", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5558), null, "System_Populated" },
                    { 24L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5468), null, "Pakistan", " Abbott Laboratories ", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5471), null, "System_Populated" },
                    { 45L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5628), null, "India", "Glenmark Pharmaceuticals Ltd", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5631), null, "System_Populated" },
                    { 22L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5454), null, "Pakistan", "GlaxoSmithKline", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5456), null, "System_Populated" },
                    { 23L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5461), null, "Pakistan", "Getz Pharma (Private) Limited", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5464), null, "System_Populated" },
                    { 1L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5164), null, "Iran", "DAROU PAKHSH FACTORIES - IR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5179), null, "System_Populated" },
                    { 2L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5304), null, "Iran", "SOBHAN PHARMACEUTICAL - IR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5307), null, "System_Populated" },
                    { 3L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5312), null, "Iran", "SINA DAROU LABORATORIES - IR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5315), null, "System_Populated" },
                    { 4L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5319), null, "Iran", "CINNAGEN - IR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5323), null, "System_Populated" },
                    { 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5327), null, "Iran", "BEHESTAN PLASMA COMPANY-IR ", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5330), null, "System_Populated" },
                    { 7L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5344), null, "Iran", "PISHTAZ TEB ZAMAN - IR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5347), null, "System_Populated" },
                    { 8L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5351), null, "Iran", "PARTO SALAMAT ROUZ - IR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5354), null, "System_Populated" },
                    { 9L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5359), null, "Iran", "DR. ABIDI PHARMACEUTICALS -IR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5362), null, "System_Populated" },
                    { 10L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5366), null, "Iran", "FARABI PHARMACEUTICALS CO -IR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5369), null, "System_Populated" },
                    { 6L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5337), null, "Iran", "CASPIAN TAMIN PHARMACEUTICAL CO -IR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5340), null, "System_Populated" },
                    { 12L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5380), null, "Iran", "ARASTO PHARMACEUTICAL CHEMICAL INC -IR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5383), null, "System_Populated" },
                    { 21L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5446), null, "Turkey", "Dora Pharma LLC", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5449), null, "System_Populated" },
                    { 11L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5373), null, "Iran", "ALMAGEN DAROU -IR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5376), null, "System_Populated" },
                    { 19L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5432), null, "Turkey", "Halfa Medical -TUR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5435), null, "System_Populated" },
                    { 18L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5425), null, "Turkey", "MS Pharma İlaç - TUR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5428), null, "System_Populated" },
                    { 17L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5417), null, "Turkey", "Directorate General of Drug Pharmactiv - TUR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5420), null, "System_Populated" },
                    { 20L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5439), null, "Turkey", "Hamle Pharma Trade -TUR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5442), null, "System_Populated" },
                    { 15L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5402), null, "Elbi Pharmaceutical Warehouse provides the delivery of medicines and medical supplies around the world with a wide range of products.", "Elbi Pharmaceutical Wholesale Warehouse - TUR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5405), null, "System_Populated" },
                    { 14L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5395), null, "established in 1947. The company is engaged in manufacturing and selling of pharmaceutical products. Its products include dermatology, gastrointestinal and metabolism, hematology, immune, cardiovascular, muscle and skeleton, radiology, central nervous, respiratory, and urogenital medicines.", "Santa Farma Ilac - TUR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5398), null, "System_Populated" },
                    { 13L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5387), null, "Iran", "MELLI AGRO CHEMICAL -IR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5390), null, "System_Populated" },
                    { 16L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5409), null, "Imuneks Farma is a pharmaceutical company that dates back to Mustafa Nevzat Pharmaceuticals’ establishment in 1923", "İmuneks Farma - TUR", 1, new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(5412), null, "System_Populated" }
                });

            migrationBuilder.InsertData(
                table: "wms_product_type_tbl",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "DeletedAt", "Description", "Status", "TypeName", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 144L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6969), null, "", 1, "I.V Infusion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6971), null, "System Defined" },
                    { 135L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6924), null, "", 1, "Elixir", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6928), null, "System Defined" },
                    { 136L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6930), null, "", 1, "Suppository", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6932), null, "System Defined" },
                    { 137L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6935), null, "", 1, "Ampoules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6937), null, "System Defined" },
                    { 138L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6940), null, "", 1, "Suspension", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6942), null, "System Defined" },
                    { 139L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6945), null, "", 1, "Oily", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6947), null, "System Defined" },
                    { 140L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6950), null, "", 1, "Cream", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6952), null, "System Defined" },
                    { 141L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6955), null, "", 1, "Gel/Lotion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6957), null, "System Defined" },
                    { 142L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6960), null, "", 1, "Dispersible", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6962), null, "System Defined" },
                    { 143L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6965), null, "", 1, "Chewable", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6967), null, "System Defined" },
                    { 145L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6975), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6977), null, "System Defined" },
                    { 155L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7026), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7028), null, "System Defined" },
                    { 147L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6985), null, "", 1, "Implant Capsule", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6987), null, "System Defined" },
                    { 148L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6990), null, "", 1, "Liquid", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6992), null, "System Defined" },
                    { 149L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6996), null, "", 1, "Tablet", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6998), null, "System Defined" },
                    { 150L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7000), null, "", 1, "Capsules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7002), null, "System Defined" },
                    { 151L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7005), null, "", 1, "Drops", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7007), null, "System Defined" },
                    { 152L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7010), null, "", 1, "Inhalers", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7013), null, "System Defined" },
                    { 153L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7015), null, "", 1, "Injections", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7018), null, "System Defined" },
                    { 154L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7021), null, "", 1, "Powder", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7023), null, "System Defined" },
                    { 134L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6920), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6922), null, "System Defined" },
                    { 156L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7031), null, "", 1, "Elixir", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7033), null, "System Defined" },
                    { 146L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6980), null, "", 1, "Liposomal", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6982), null, "System Defined" },
                    { 133L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6914), null, "", 1, "Powder", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6916), null, "System Defined" },
                    { 122L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6858), null, "", 1, "Chewable", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6860), null, "System Defined" },
                    { 131L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6904), null, "", 1, "Inhalers", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6906), null, "System Defined" },
                    { 108L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6741), null, "", 1, "Capsules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6743), null, "System Defined" },
                    { 109L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6747), null, "", 1, "Drops", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6749), null, "System Defined" },
                    { 110L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6752), null, "", 1, "Inhalers", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6754), null, "System Defined" },
                    { 111L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6757), null, "", 1, "Injections", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6759), null, "System Defined" },
                    { 112L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6762), null, "", 1, "Powder", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6764), null, "System Defined" },
                    { 113L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6812), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6814), null, "System Defined" },
                    { 114L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6817), null, "", 1, "Elixir", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6819), null, "System Defined" },
                    { 115L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6822), null, "", 1, "Suppository", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6824), null, "System Defined" },
                    { 116L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6828), null, "", 1, "Ampoules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6830), null, "System Defined" },
                    { 117L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6833), null, "", 1, "Suspension", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6835), null, "System Defined" },
                    { 118L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6838), null, "", 1, "Oily", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6840), null, "System Defined" },
                    { 119L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6843), null, "", 1, "Cream", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6845), null, "System Defined" },
                    { 120L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6848), null, "", 1, "Gel/Lotion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6850), null, "System Defined" },
                    { 121L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6853), null, "", 1, "Dispersible", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6855), null, "System Defined" },
                    { 157L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7036), null, "", 1, "Suppository", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7038), null, "System Defined" },
                    { 123L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6863), null, "", 1, "I.V Infusion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6865), null, "System Defined" },
                    { 124L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6868), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6870), null, "System Defined" },
                    { 125L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6873), null, "", 1, "Liposomal", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6875), null, "System Defined" },
                    { 126L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6879), null, "", 1, "Implant Capsule", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6881), null, "System Defined" },
                    { 127L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6884), null, "", 1, "Liquid", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6886), null, "System Defined" },
                    { 128L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6889), null, "", 1, "Tablet", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6891), null, "System Defined" },
                    { 129L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6894), null, "", 1, "Capsules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6896), null, "System Defined" },
                    { 130L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6899), null, "", 1, "Drops", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6901), null, "System Defined" },
                    { 132L, "Antiemetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6909), null, "", 1, "Injections", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6911), null, "System Defined" },
                    { 158L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7041), null, "", 1, "Ampoules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7043), null, "System Defined" },
                    { 170L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7104), null, "", 1, "Tablet", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7106), null, "System Defined" },
                    { 160L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7051), null, "", 1, "Oily", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7053), null, "System Defined" },
                    { 189L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7245), null, "", 1, "Implant Capsule", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7247), null, "System Defined" },
                    { 190L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7250), null, "", 1, "Liquid", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7252), null, "System Defined" },
                    { 191L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7255), null, "", 1, "Tablet", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7257), null, "System Defined" },
                    { 192L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7260), null, "", 1, "Capsules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7262), null, "System Defined" },
                    { 193L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7265), null, "", 1, "Drops", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7267), null, "System Defined" },
                    { 194L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7271), null, "", 1, "Inhalers", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7273), null, "System Defined" },
                    { 195L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7276), null, "", 1, "Injections", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7278), null, "System Defined" },
                    { 196L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7281), null, "", 1, "Powder", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7283), null, "System Defined" },
                    { 197L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7286), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7288), null, "System Defined" },
                    { 198L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7291), null, "", 1, "Elixir", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7293), null, "System Defined" },
                    { 199L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7296), null, "", 1, "Suppository", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7298), null, "System Defined" },
                    { 200L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7301), null, "", 1, "Ampoules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7303), null, "System Defined" },
                    { 201L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7306), null, "", 1, "Suspension", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7309), null, "System Defined" },
                    { 202L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7312), null, "", 1, "Oily", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7314), null, "System Defined" },
                    { 203L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7317), null, "", 1, "Cream", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7319), null, "System Defined" },
                    { 204L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7322), null, "", 1, "Gel/Lotion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7324), null, "System Defined" },
                    { 205L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7327), null, "", 1, "Dispersible", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7329), null, "System Defined" },
                    { 206L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7332), null, "", 1, "Chewable", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7334), null, "System Defined" },
                    { 207L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7337), null, "", 1, "I.V Infusion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7339), null, "System Defined" },
                    { 208L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7343), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7345), null, "System Defined" },
                    { 209L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7348), null, "", 1, "Liposomal", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7350), null, "System Defined" },
                    { 210L, "Enzymya", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7354), null, "", 1, "Implant Capsule", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7356), null, "System Defined" },
                    { 107L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6736), null, "", 1, "Tablet", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6738), null, "System Defined" },
                    { 188L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7240), null, "", 1, "Liposomal", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7242), null, "System Defined" },
                    { 159L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7046), null, "", 1, "Suspension", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7048), null, "System Defined" },
                    { 187L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7235), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7237), null, "System Defined" },
                    { 185L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7225), null, "", 1, "Chewable", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7227), null, "System Defined" },
                    { 161L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7056), null, "", 1, "Cream", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7058), null, "System Defined" },
                    { 162L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7062), null, "", 1, "Gel/Lotion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7064), null, "System Defined" },
                    { 163L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7066), null, "", 1, "Dispersible", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7069), null, "System Defined" },
                    { 164L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7072), null, "", 1, "Chewable", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7074), null, "System Defined" },
                    { 165L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7078), null, "", 1, "I.V Infusion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7079), null, "System Defined" },
                    { 166L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7082), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7084), null, "System Defined" },
                    { 167L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7087), null, "", 1, "Liposomal", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7089), null, "System Defined" },
                    { 168L, "Antifungals", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7094), null, "", 1, "Implant Capsule", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7096), null, "System Defined" },
                    { 169L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7099), null, "", 1, "Liquid", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7101), null, "System Defined" },
                    { 171L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7109), null, "", 1, "Capsules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7111), null, "System Defined" },
                    { 172L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7114), null, "", 1, "Drops", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7116), null, "System Defined" },
                    { 173L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7119), null, "", 1, "Inhalers", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7121), null, "System Defined" },
                    { 174L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7124), null, "", 1, "Injections", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7127), null, "System Defined" },
                    { 175L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7130), null, "", 1, "Powder", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7132), null, "System Defined" },
                    { 176L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7135), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7137), null, "System Defined" },
                    { 177L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7182), null, "", 1, "Elixir", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7184), null, "System Defined" },
                    { 178L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7187), null, "", 1, "Suppository", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7189), null, "System Defined" },
                    { 179L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7193), null, "", 1, "Ampoules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7195), null, "System Defined" },
                    { 180L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7198), null, "", 1, "Suspension", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7200), null, "System Defined" },
                    { 181L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7203), null, "", 1, "Oily", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7206), null, "System Defined" },
                    { 182L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7209), null, "", 1, "Cream", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7211), null, "System Defined" },
                    { 183L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7214), null, "", 1, "Gel/Lotion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7216), null, "System Defined" },
                    { 184L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7220), null, "", 1, "Dispersible", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7223), null, "System Defined" },
                    { 186L, "Anxiolytic", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7230), null, "", 1, "I.V Infusion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(7232), null, "System Defined" },
                    { 106L, "Antidotes", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6731), null, "", 1, "Liquid", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6733), null, "System Defined" }
                });

            migrationBuilder.InsertData(
                table: "wms_product_type_tbl",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "DeletedAt", "Description", "Status", "TypeName", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 57L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6480), null, "", 1, "Gel/Lotion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6485), null, "System Defined" },
                    { 104L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6720), null, "", 1, "Liposomal", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6722), null, "System Defined" },
                    { 28L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6257), null, "", 1, "Powder", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6259), null, "System Defined" },
                    { 29L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6262), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6265), null, "System Defined" },
                    { 30L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6268), null, "", 1, "Elixir", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6270), null, "System Defined" },
                    { 31L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6273), null, "", 1, "Suppository", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6275), null, "System Defined" },
                    { 32L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6279), null, "", 1, "Ampoules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6282), null, "System Defined" },
                    { 33L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6287), null, "", 1, "Suspension", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6289), null, "System Defined" },
                    { 34L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6293), null, "", 1, "Oily", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6295), null, "System Defined" },
                    { 35L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6298), null, "", 1, "Cream", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6300), null, "System Defined" },
                    { 36L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6303), null, "", 1, "Gel/Lotion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6305), null, "System Defined" },
                    { 37L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6308), null, "", 1, "Dispersible", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6310), null, "System Defined" },
                    { 27L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6251), null, "", 1, "Injections", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6254), null, "System Defined" },
                    { 38L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6314), null, "", 1, "Chewable", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6316), null, "System Defined" },
                    { 40L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6323), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6325), null, "System Defined" },
                    { 41L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6328), null, "", 1, "Liposomal", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6331), null, "System Defined" },
                    { 42L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6335), null, "", 1, "Implant Capsule", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6337), null, "System Defined" },
                    { 43L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6341), null, "", 1, "Liquid", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6343), null, "System Defined" },
                    { 44L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6346), null, "", 1, "Tablet", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6348), null, "System Defined" },
                    { 45L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6351), null, "", 1, "Capsules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6353), null, "System Defined" },
                    { 46L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6356), null, "", 1, "Drops", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6358), null, "System Defined" },
                    { 105L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6725), null, "", 1, "Implant Capsule", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6727), null, "System Defined" },
                    { 48L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6367), null, "", 1, "Injections", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6369), null, "System Defined" },
                    { 49L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6440), null, "", 1, "Powder", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6442), null, "System Defined" },
                    { 39L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6319), null, "", 1, "I.V Infusion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6320), null, "System Defined" },
                    { 26L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6246), null, "", 1, "Inhalers", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6248), null, "System Defined" },
                    { 25L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6241), null, "", 1, "Drops", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6243), null, "System Defined" },
                    { 24L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6236), null, "", 1, "Capsules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6238), null, "System Defined" },
                    { 1L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(5956), null, "", 1, "Liquid", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6001), null, "System Defined" },
                    { 2L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6107), null, "", 1, "Tablet", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6110), null, "System Defined" },
                    { 3L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6115), null, "", 1, "Capsules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6117), null, "System Defined" },
                    { 4L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6122), null, "", 1, "Drops", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6124), null, "System Defined" },
                    { 5L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6127), null, "", 1, "Inhalers", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6129), null, "System Defined" },
                    { 6L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6133), null, "", 1, "Injections", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6135), null, "System Defined" },
                    { 7L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6139), null, "", 1, "Powder", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6141), null, "System Defined" },
                    { 8L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6144), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6146), null, "System Defined" },
                    { 9L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6149), null, "", 1, "Elixir", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6151), null, "System Defined" },
                    { 10L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6156), null, "", 1, "Suppository", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6158), null, "System Defined" },
                    { 11L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6163), null, "", 1, "Ampoules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6165), null, "System Defined" },
                    { 12L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6169), null, "", 1, "Suspension", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6171), null, "System Defined" },
                    { 13L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6174), null, "", 1, "Oily", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6178), null, "System Defined" },
                    { 14L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6181), null, "", 1, "Cream", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6183), null, "System Defined" },
                    { 15L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6187), null, "", 1, "Gel/Lotion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6189), null, "System Defined" },
                    { 16L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6191), null, "", 1, "Dispersible", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6193), null, "System Defined" },
                    { 17L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6196), null, "", 1, "Chewable", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6198), null, "System Defined" },
                    { 18L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6201), null, "", 1, "I.V Infusion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6204), null, "System Defined" },
                    { 19L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6207), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6209), null, "System Defined" },
                    { 20L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6213), null, "", 1, "Liposomal", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6216), null, "System Defined" },
                    { 21L, "Analgesics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6220), null, "", 1, "Implant Capsule", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6222), null, "System Defined" },
                    { 22L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6226), null, "", 1, "Liquid", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6228), null, "System Defined" },
                    { 23L, "Anesthetics", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6231), null, "", 1, "Tablet", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6233), null, "System Defined" },
                    { 50L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6445), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6447), null, "System Defined" },
                    { 51L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6450), null, "", 1, "Elixir", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6452), null, "System Defined" },
                    { 47L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6361), null, "", 1, "Inhalers", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6363), null, "System Defined" },
                    { 53L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6460), null, "", 1, "Ampoules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6462), null, "System Defined" },
                    { 81L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6603), null, "", 1, "I.V Infusion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6605), null, "System Defined" },
                    { 82L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6608), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6611), null, "System Defined" },
                    { 52L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6455), null, "", 1, "Suppository", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6457), null, "System Defined" },
                    { 84L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6620), null, "", 1, "Implant Capsule", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6622), null, "System Defined" },
                    { 85L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6625), null, "", 1, "Liquid", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6627), null, "System Defined" },
                    { 86L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6630), null, "", 1, "Tablet", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6632), null, "System Defined" },
                    { 87L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6635), null, "", 1, "Capsules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6637), null, "System Defined" },
                    { 88L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6640), null, "", 1, "Drops", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6642), null, "System Defined" },
                    { 89L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6645), null, "", 1, "Inhalers", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6647), null, "System Defined" },
                    { 90L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6650), null, "", 1, "Injections", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6652), null, "System Defined" },
                    { 91L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6655), null, "", 1, "Powder", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6657), null, "System Defined" },
                    { 92L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6660), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6662), null, "System Defined" },
                    { 93L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6664), null, "", 1, "Elixir", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6666), null, "System Defined" },
                    { 94L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6669), null, "", 1, "Suppository", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6671), null, "System Defined" },
                    { 95L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6674), null, "", 1, "Ampoules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6676), null, "System Defined" },
                    { 96L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6679), null, "", 1, "Suspension", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6682), null, "System Defined" },
                    { 97L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6685), null, "", 1, "Oily", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6687), null, "System Defined" },
                    { 98L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6690), null, "", 1, "Cream", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6693), null, "System Defined" },
                    { 99L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6695), null, "", 1, "Gel/Lotion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6698), null, "System Defined" },
                    { 100L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6700), null, "", 1, "Dispersible", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6702), null, "System Defined" },
                    { 101L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6705), null, "", 1, "Chewable", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6707), null, "System Defined" },
                    { 102L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6710), null, "", 1, "I.V Infusion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6712), null, "System Defined" },
                    { 103L, "Antidementia", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6715), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6717), null, "System Defined" },
                    { 80L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6597), null, "", 1, "Chewable", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6600), null, "System Defined" },
                    { 79L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6592), null, "", 1, "Dispersible", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6595), null, "System Defined" },
                    { 83L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6615), null, "", 1, "Liposomal", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6617), null, "System Defined" },
                    { 77L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6583), null, "", 1, "Cream", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6585), null, "System Defined" },
                    { 54L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6465), null, "", 1, "Suspension", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6467), null, "System Defined" },
                    { 55L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6470), null, "", 1, "Oily", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6472), null, "System Defined" },
                    { 56L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6475), null, "", 1, "Cream", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6477), null, "System Defined" },
                    { 58L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6487), null, "", 1, "Dispersible", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6489), null, "System Defined" },
                    { 59L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6492), null, "", 1, "Chewable", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6494), null, "System Defined" },
                    { 78L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6588), null, "", 1, "Gel/Lotion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6590), null, "System Defined" },
                    { 61L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6502), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6504), null, "System Defined" },
                    { 62L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6507), null, "", 1, "Liposomal", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6509), null, "System Defined" },
                    { 63L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6512), null, "", 1, "Implant Capsule", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6514), null, "System Defined" },
                    { 64L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6517), null, "", 1, "Liquid", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6519), null, "System Defined" },
                    { 65L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6522), null, "", 1, "Tablet", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6523), null, "System Defined" },
                    { 60L, "Antibacterials", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6497), null, "", 1, "I.V Infusion", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6499), null, "System Defined" },
                    { 67L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6532), null, "", 1, "Drops", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6534), null, "System Defined" },
                    { 66L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6527), null, "", 1, "Capsules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6529), null, "System Defined" },
                    { 75L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6572), null, "", 1, "Suspension", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6574), null, "System Defined" },
                    { 74L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6567), null, "", 1, "Ampoules", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6569), null, "System Defined" },
                    { 73L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6562), null, "", 1, "Suppository", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6564), null, "System Defined" },
                    { 76L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6577), null, "", 1, "Oily", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6579), null, "System Defined" },
                    { 71L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6552), null, "", 1, "Ointment", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6554), null, "System Defined" },
                    { 70L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6547), null, "", 1, "Powder", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6549), null, "System Defined" },
                    { 69L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6542), null, "", 1, "Injections", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6544), null, "System Defined" },
                    { 68L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6537), null, "", 1, "Inhalers", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6539), null, "System Defined" },
                    { 72L, "Anticonvulsants", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6557), null, "", 1, "Elixir", new DateTime(2021, 11, 29, 12, 27, 22, 133, DateTimeKind.Local).AddTicks(6559), null, "System Defined" }
                });

            migrationBuilder.InsertData(
                table: "wms_unit_tbl",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name", "Status", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 10L, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1802), null, "", "Boxes", 1, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1804), null, "System Defined" },
                    { 1L, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1661), null, "", "Blister Packs", 1, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1677), null, "System Defined" },
                    { 2L, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1758), null, "", "Tubes", 1, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1760), null, "System Defined" },
                    { 3L, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1764), null, "", "Bottles", 1, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1767), null, "System Defined" },
                    { 4L, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1770), null, "", "Jars ", 1, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1772), null, "System Defined" },
                    { 5L, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1774), null, "", "Plastic bags", 1, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1776), null, "System Defined" },
                    { 6L, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1779), null, "", "Syringes", 1, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1781), null, "System Defined" },
                    { 7L, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1784), null, "", "Vials", 1, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1786), null, "System Defined" },
                    { 8L, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1790), null, "", "Sachets", 1, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1792), null, "System Defined" },
                    { 9L, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1797), null, "", "Cartons", 1, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1799), null, "System Defined" },
                    { 11L, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1806), null, "", "Enteral syringe", 1, new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(1808), null, "System Defined" }
                });

            migrationBuilder.InsertData(
                table: "wms_province_tbl",
                columns: new[] { "Id", "CountryCode", "CountryId", "CountryName", "CreatedAt", "DeletedAt", "Name", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9597), null, "Badakhshan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9620), null, "System_Populated" },
                    { 94L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(507), null, "Diyarbakır", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(509), null, "System_Populated" },
                    { 93L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(502), null, "Denizli", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(504), null, "System_Populated" },
                    { 92L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(497), null, "Çorum", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(499), null, "System_Populated" },
                    { 91L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(492), null, "Çankırı", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(494), null, "System_Populated" },
                    { 90L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(487), null, "Çanakkale", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(489), null, "System_Populated" },
                    { 88L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(482), null, "Bursa", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(484), null, "System_Populated" },
                    { 87L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(477), null, "Burdur", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(479), null, "System_Populated" },
                    { 86L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(471), null, "Bolu", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(474), null, "System_Populated" },
                    { 85L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(417), null, "Bitlis", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(419), null, "System_Populated" },
                    { 84L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(406), null, "Bingöl", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(408), null, "System_Populated" },
                    { 83L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(402), null, "Bilecik", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(404), null, "System_Populated" },
                    { 82L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(396), null, "Bayburt", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(399), null, "System_Populated" },
                    { 81L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(391), null, "Batman", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(393), null, "System_Populated" },
                    { 95L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(513), null, "Düzce", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(515), null, "System_Populated" },
                    { 80L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(386), null, "Bartın", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(388), null, "System_Populated" },
                    { 78L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(377), null, "Aydın", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(379), null, "System_Populated" },
                    { 77L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(372), null, "Artvin", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(374), null, "System_Populated" },
                    { 76L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(367), null, "Ardahan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(369), null, "System_Populated" },
                    { 75L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(362), null, "Antalya", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(364), null, "System_Populated" },
                    { 74L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(356), null, "Ankara", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(358), null, "System_Populated" },
                    { 73L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(351), null, "Amasya", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(353), null, "System_Populated" },
                    { 72L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(345), null, "Aksaray", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(347), null, "System_Populated" },
                    { 71L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(340), null, "Ağri", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(342), null, "System_Populated" },
                    { 70L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(335), null, "Afyonkarahisar", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(337), null, "System_Populated" },
                    { 69L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(330), null, "Adıyaman", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(332), null, "System_Populated" },
                    { 68L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(325), null, "Adana", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(327), null, "System_Populated" },
                    { 67L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(320), null, "Uttarakhand", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(322), null, "System_Populated" },
                    { 66L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(315), null, "Uttar Pradesh", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(317), null, "System_Populated" },
                    { 79L, "TUR", 4L, "Turkey", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(382), null, "Balıkesir", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(384), null, "System_Populated" },
                    { 65L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(310), null, "Tripura", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(312), null, "System_Populated" },
                    { 96L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(518), null, "Alborz", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(520), null, "System_Populated" },
                    { 98L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(528), null, "Razavi Khorasan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(530), null, "System_Populated" },
                    { 125L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(696), null, "Markazi", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(698), null, "System_Populated" },
                    { 124L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(691), null, "Qazvin", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(693), null, "System_Populated" },
                    { 123L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(685), null, "Gilan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(689), null, "System_Populated" },
                    { 122L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(681), null, "Ardabil", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(682), null, "System_Populated" },
                    { 121L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(676), null, "Zanjan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(678), null, "System_Populated" },
                    { 120L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(671), null, "East Azarbaijan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(672), null, "System_Populated" },
                    { 119L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(666), null, "West Azarbaijan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(668), null, "System_Populated" },
                    { 118L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(661), null, "Kurdistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(663), null, "System_Populated" },
                    { 117L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(656), null, "Hamadan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(658), null, "System_Populated" },
                    { 128L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(651), null, "Kermanshah", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(653), null, "System_Populated" },
                    { 116L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(646), null, "Ilam", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(648), null, "System_Populated" },
                    { 115L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(641), null, "Lorestan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(643), null, "System_Populated" },
                    { 114L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(635), null, "Khuzestan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(637), null, "System_Populated" },
                    { 97L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(523), null, "South Khorasan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(525), null, "System_Populated" },
                    { 113L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(630), null, "Chahar Mahaal", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(632), null, "System_Populated" },
                    { 111L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(621), null, "Kohkiluyeh", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(623), null, "System_Populated" },
                    { 110L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(616), null, "Buyer Ahmad", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(618), null, "System_Populated" },
                    { 109L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(611), null, "Bushehr", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(613), null, "System_Populated" },
                    { 108L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(606), null, "Fars", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(608), null, "System_Populated" },
                    { 107L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(577), null, "Hormozgan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(603), null, "System_Populated" },
                    { 106L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(572), null, "Sistan-Baluchistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(574), null, "System_Populated" },
                    { 105L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(565), null, "Kerman", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(569), null, "System_Populated" },
                    { 104L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(558), null, "Yazd", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(560), null, "System_Populated" },
                    { 103L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(553), null, "Esfahan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(555), null, "System_Populated" },
                    { 102L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(548), null, "Semnan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(550), null, "System_Populated" },
                    { 101L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(543), null, "Mazandaran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(545), null, "System_Populated" },
                    { 100L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(538), null, "Golestan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(540), null, "System_Populated" },
                    { 99L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(533), null, "North Khorasan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(535), null, "System_Populated" },
                    { 112L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(625), null, "Bakhtiari", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(627), null, "System_Populated" },
                    { 126L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(701), null, "Qom", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(703), null, "System_Populated" },
                    { 64L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(304), null, "Telangana", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(306), null, "System_Populated" },
                    { 62L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(294), null, "Tamil Nadu", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(297), null, "System_Populated" },
                    { 29L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(120), null, "Parwan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(122), null, "System_Populated" },
                    { 28L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(115), null, "Panjshir", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(117), null, "System_Populated" },
                    { 27L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(110), null, "Paktika", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(112), null, "System_Populated" },
                    { 26L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(101), null, "Paktia", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(105), null, "System_Populated" },
                    { 25L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9852), null, "Urozgan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9855), null, "System_Populated" },
                    { 24L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9844), null, "Nuristan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9848), null, "System_Populated" },
                    { 23L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9837), null, "Nimruz", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9840), null, "System_Populated" },
                    { 22L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9830), null, "Nangarhar", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9832), null, "System_Populated" },
                    { 21L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9824), null, "Logar", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9826), null, "System_Populated" },
                    { 20L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9816), null, "Laghman", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9820), null, "System_Populated" },
                    { 19L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9810), null, "Kunduz", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9812), null, "System_Populated" },
                    { 18L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9804), null, "Kunar", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9807), null, "System_Populated" },
                    { 17L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9799), null, "Khost", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9801), null, "System_Populated" },
                    { 30L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(125), null, "Samangan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(127), null, "System_Populated" },
                    { 16L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9794), null, "Kapisa", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9796), null, "System_Populated" },
                    { 14L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9784), null, "Kabul", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9786), null, "System_Populated" },
                    { 13L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9779), null, "Jowzjan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9781), null, "System_Populated" },
                    { 12L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9774), null, "Herat", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9776), null, "System_Populated" },
                    { 11L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9769), null, "Helmand", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9771), null, "System_Populated" },
                    { 10L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9764), null, "Ghor", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9766), null, "System_Populated" },
                    { 9L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9757), null, "Ghazni", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9759), null, "System_Populated" },
                    { 8L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9751), null, "Faryab", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9753), null, "System_Populated" },
                    { 7L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9746), null, "Farah", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9748), null, "System_Populated" },
                    { 6L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9739), null, "Daykundi", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9741), null, "System_Populated" },
                    { 5L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9732), null, "Bamyan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9734), null, "System_Populated" },
                    { 4L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9727), null, "Balkh", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9729), null, "System_Populated" },
                    { 3L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9720), null, "Baghlan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9722), null, "System_Populated" },
                    { 2L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9712), null, "Badghis", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9715), null, "System_Populated" },
                    { 15L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9789), null, "Kandahar", new DateTime(2021, 11, 29, 12, 27, 22, 134, DateTimeKind.Local).AddTicks(9791), null, "System_Populated" },
                    { 63L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(299), null, "Telangana", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(301), null, "System_Populated" },
                    { 31L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(130), null, "Sar-e Pol", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(132), null, "System_Populated" },
                    { 33L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(140), null, "Wardak", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(142), null, "System_Populated" },
                    { 61L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(289), null, "Sikkim", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(291), null, "System_Populated" },
                    { 60L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(284), null, "Rajasthan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(286), null, "System_Populated" },
                    { 59L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(280), null, "Punjab", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(282), null, "System_Populated" },
                    { 58L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(275), null, "Odisha", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(277), null, "System_Populated" },
                    { 57L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(270), null, "Nagaland", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(272), null, "System_Populated" },
                    { 56L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(264), null, "Mizoram", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(266), null, "System_Populated" },
                    { 55L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(254), null, "Meghalaya", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(262), null, "System_Populated" },
                    { 54L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(249), null, "Manipur", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(252), null, "System_Populated" },
                    { 53L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(244), null, "Maharashtra", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(246), null, "System_Populated" },
                    { 52L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(239), null, "Madhya Pradesh", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(241), null, "System_Populated" },
                    { 51L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(233), null, "Kerala", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(235), null, "System_Populated" },
                    { 50L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(228), null, "Karnataka", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(230), null, "System_Populated" },
                    { 49L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(223), null, "Jharkhand", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(225), null, "System_Populated" },
                    { 32L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(135), null, "Takhar", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(137), null, "System_Populated" },
                    { 48L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(218), null, "Himachal Pradesh", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(220), null, "System_Populated" },
                    { 46L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(209), null, "Gujarat", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(211), null, "System_Populated" },
                    { 45L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(204), null, "Goa", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(206), null, "System_Populated" },
                    { 44L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(198), null, "Chhattisgarh", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(201), null, "System_Populated" },
                    { 43L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(192), null, "Bihar", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(195), null, "System_Populated" },
                    { 42L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(187), null, "Assam", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(189), null, "System_Populated" },
                    { 41L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(182), null, "Arunachal Pradesh", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(184), null, "System_Populated" },
                    { 40L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(177), null, "Andhra Pradesh", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(179), null, "System_Populated" },
                    { 39L, "PK", 2L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(172), null, "Peshawar", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(174), null, "System_Populated" },
                    { 38L, "PK", 2L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(167), null, "Sohawa", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(169), null, "System_Populated" },
                    { 37L, "PK", 2L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(162), null, "Jehlum", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(164), null, "System_Populated" },
                    { 36L, "PK", 2L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(156), null, "RawalPindi", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(158), null, "System_Populated" },
                    { 35L, "PK", 2L, "Pakistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(150), null, "Punjab", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(152), null, "System_Populated" },
                    { 34L, "AFN", 1L, "Afghanistan", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(145), null, "Zabul", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(147), null, "System_Populated" },
                    { 47L, "IND", 3L, "India", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(213), null, "Haryana", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(215), null, "System_Populated" },
                    { 127L, "IR", 5L, "Iran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(706), null, "Tehran", new DateTime(2021, 11, 29, 12, 27, 22, 135, DateTimeKind.Local).AddTicks(708), null, "System_Populated" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pms_employee_ledger_tbl");

            migrationBuilder.DropTable(
                name: "pms_employee_salaries_tbl");

            migrationBuilder.DeleteData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "wms_assets_category_tbl",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "wms_bank_tbl",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 12L);

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

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "wms_expense_category_tbl",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "wms_product_type_tbl",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "wms_unit_tbl",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 5L);
        }
    }
}
