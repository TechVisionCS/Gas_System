using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class Initilaziation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "wms_bank_ledger_tbl",
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
                    EntityType = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    VoucherNo = table.Column<string>(nullable: true),
                    Debit = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Credit = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TransCode = table.Column<string>(nullable: true),
                    TransType = table.Column<int>(nullable: false),
                    isClosed = table.Column<bool>(nullable: false),
                    BankTransactionId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_bank_ledger_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_bank_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    BankName = table.Column<string>(nullable: false),
                    AccountName = table.Column<string>(nullable: false),
                    AccountNo = table.Column<string>(nullable: false),
                    Branch = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Signature = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_bank_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_bank_transaction_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    TransType = table.Column<int>(nullable: false),
                    BankTransactionId = table.Column<string>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_bank_transaction_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_cash_ledger_tbl",
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
                    EntityType = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    VoucherNo = table.Column<string>(nullable: true),
                    Debit = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Credit = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TransCode = table.Column<string>(nullable: true),
                    TransType = table.Column<int>(nullable: false),
                    isClosed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_cash_ledger_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_category_tbl",
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
                    table.PrimaryKey("PK_wms_category_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_country_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_country_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_customer_advanced_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    CustomerId = table.Column<long>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Desciption = table.Column<string>(nullable: true),
                    TransCode = table.Column<string>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_customer_advanced_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_customer_receive_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    CustomerId = table.Column<long>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Desciption = table.Column<string>(nullable: true),
                    TransCode = table.Column<string>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_customer_receive_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_customer_tbl",
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
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Countryid = table.Column<long>(nullable: false),
                    Provinceid = table.Column<long>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    PreviousBalance = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_customer_tbl", x => x.Id);
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
                    Lastname = table.Column<string>(nullable: true),
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
                    Leavedate = table.Column<DateTime>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    DesignationId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_employee_tbl", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "wms_expense_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    BillNumber = table.Column<string>(nullable: true),
                    BankId = table.Column<long>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    ExpenseCategory = table.Column<long>(nullable: false),
                    EmployeeId = table.Column<long>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TransCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_expense_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_manufacturer_tbl",
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
                    Description = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_manufacturer_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_office_loan_ledger_tbl",
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
                    table.PrimaryKey("PK_wms_office_loan_ledger_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_office_loan_payment_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    PersonName = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Desciption = table.Column<string>(nullable: true),
                    TransCode = table.Column<string>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_office_loan_payment_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_office_loan_receive_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    PersonName = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Desciption = table.Column<string>(nullable: true),
                    TransCode = table.Column<string>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_office_loan_receive_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_office_person_tbl",
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
                    FatherName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    PreviousBalance = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_office_person_tbl", x => x.Id);
                });

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
                    Amount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Desciption = table.Column<string>(nullable: false),
                    TransCode = table.Column<string>(nullable: true),
                    InvestmetType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_partner_investment_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_partner_payment_tbl",
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
                    Date = table.Column<DateTime>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Desciption = table.Column<string>(nullable: false),
                    TransCode = table.Column<string>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_partner_payment_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_partner_tbl",
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
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Countryid = table.Column<long>(nullable: false),
                    Provinceid = table.Column<long>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    PreviousBalance = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_partner_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_partners_purchase_shares_tbl",
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
                    table.PrimaryKey("PK_wms_partners_purchase_shares_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_person_loan_ledger_tbl",
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
                    table.PrimaryKey("PK_wms_person_loan_ledger_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_person_loan_payment_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    PersonName = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Desciption = table.Column<string>(nullable: true),
                    TransCode = table.Column<string>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_person_loan_payment_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_person_loan_receive_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    PersonName = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Desciption = table.Column<string>(nullable: true),
                    TransCode = table.Column<string>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_person_loan_receive_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_person_tbl",
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
                    FatherName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    PreviousBalance = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_person_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_product_batch_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    PurchaseId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    BatchId = table.Column<string>(nullable: true),
                    StockQty = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_product_batch_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_product_supplier_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    ProductId = table.Column<long>(nullable: false),
                    SupplierId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_product_supplier_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_product_type_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    CategoryName = table.Column<string>(nullable: false),
                    TypeName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_product_type_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_purchase_details_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    PurchaseId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    UnitId = table.Column<long>(nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalPurchasePrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_purchase_details_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_purchase_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    InvoiceNo = table.Column<string>(nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    RentAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DueAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PurchaseType = table.Column<int>(nullable: false),
                    TransCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_purchase_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_quote_details_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    QuoteId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    BatchId = table.Column<string>(nullable: true),
                    Qty = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalQuotePrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_quote_details_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_quote_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    QuoteDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    RentAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DueAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true),
                    InvoiceNo = table.Column<string>(nullable: true),
                    QuoteStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_quote_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_return_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    PurchaseId = table.Column<long>(nullable: false),
                    InvoiceNo = table.Column<string>(nullable: true),
                    SaleId = table.Column<long>(nullable: false),
                    ReturnType = table.Column<int>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    RentAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DueAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TransCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_return_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_sale_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    SaleDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    RentAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DueAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TransCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_sale_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_service_category_tbl",
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
                    Fee = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_service_category_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_service_details_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    ServiceId = table.Column<long>(nullable: false),
                    ServiceCatergoryId = table.Column<long>(nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Fee_Charges = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalServicePrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Descriptions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_service_details_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_service_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    ServiceDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    EmployeeId = table.Column<long>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DueAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true),
                    InvoiceNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_service_tbl", x => x.Id);
                });

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
                    LogoUrl = table.Column<string>(nullable: true),
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

            migrationBuilder.CreateTable(
                name: "wms_stock_details_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    ProductId = table.Column<long>(nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    InQty = table.Column<float>(nullable: false),
                    OutQty = table.Column<float>(nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TransCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_stock_details_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_stock_purchase_log_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    ProductId = table.Column<long>(nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    BatchId = table.Column<string>(nullable: true),
                    InQty = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    OutQty = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    StockQty = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_stock_purchase_log_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_stock_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    ProductId = table.Column<long>(nullable: false),
                    InQty = table.Column<float>(nullable: false),
                    OutQty = table.Column<float>(nullable: false),
                    StockQty = table.Column<float>(nullable: false),
                    TotalStockPurchasePrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalStockSalePrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_stock_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_supplier_advanced_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    SupplierId = table.Column<long>(nullable: false),
                    SupplierName = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Desciption = table.Column<string>(nullable: true),
                    TransCode = table.Column<string>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_supplier_advanced_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_supplier_ledger_tbl",
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
                    table.PrimaryKey("PK_wms_supplier_ledger_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_supplier_payment_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    SupplierId = table.Column<long>(nullable: false),
                    SupplierName = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    BankId = table.Column<long>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Desciption = table.Column<string>(nullable: true),
                    TransCode = table.Column<string>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_supplier_payment_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_tax_tbl",
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
                    Amount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_tax_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_transaction_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    TransCode = table.Column<string>(nullable: true),
                    TransDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TransType = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Operation = table.Column<int>(nullable: false),
                    isClosed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_transaction_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_unit_tbl",
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
                    KgAmount = table.Column<float>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_unit_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wms_wastage_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    WastageDate = table.Column<DateTime>(nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    IncomeFromWastage = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    ExCharges = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TransCode = table.Column<string>(nullable: true),
                    Flg = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_wastage_tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "wms_province_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CountryId = table.Column<long>(nullable: false),
                    CountryName = table.Column<string>(nullable: true),
                    CountryCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_province_tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wms_province_tbl_wms_country_tbl_CountryId",
                        column: x => x.CountryId,
                        principalTable: "wms_country_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "wms_customer_ledger_tbl",
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
                    isClosed = table.Column<bool>(nullable: false),
                    CustomerId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_customer_ledger_tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wms_customer_ledger_tbl_wms_customer_tbl_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "wms_customer_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateTable(
                name: "wms_partner_ledger_tbl",
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
                    isClosed = table.Column<bool>(nullable: false),
                    partnerId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_partner_ledger_tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wms_partner_ledger_tbl_wms_partner_tbl_partnerId",
                        column: x => x.partnerId,
                        principalTable: "wms_partner_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "wms_product_tbl",
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
                    CategoryId = table.Column<long>(nullable: false),
                    ManufacturerId = table.Column<long>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    ProductTypeId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_product_tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wms_product_tbl_wms_category_tbl_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "wms_category_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wms_product_tbl_wms_product_type_tbl_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "wms_product_type_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "wms_supplier_tbl",
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
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Countryid = table.Column<long>(nullable: false),
                    Provinceid = table.Column<long>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    PreviousBalance = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_supplier_tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wms_supplier_tbl_wms_country_tbl_Countryid",
                        column: x => x.Countryid,
                        principalTable: "wms_country_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wms_supplier_tbl_wms_province_tbl_Provinceid",
                        column: x => x.Provinceid,
                        principalTable: "wms_province_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductUnits",
                columns: table => new
                {
                    ProductId = table.Column<long>(nullable: false),
                    UnitId = table.Column<long>(nullable: false),
                    Id = table.Column<long>(nullable: false),
                    UnitSellPrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUnits", x => new { x.ProductId, x.UnitId });
                    table.ForeignKey(
                        name: "FK_ProductUnits_wms_product_tbl_ProductId",
                        column: x => x.ProductId,
                        principalTable: "wms_product_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductUnits_wms_unit_tbl_UnitId",
                        column: x => x.UnitId,
                        principalTable: "wms_unit_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "wms_product_tax_tbl",
                columns: table => new
                {
                    ProductId = table.Column<long>(nullable: false),
                    TaxId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_product_tax_tbl", x => new { x.ProductId, x.TaxId });
                    table.ForeignKey(
                        name: "FK_wms_product_tax_tbl_wms_product_tbl_ProductId",
                        column: x => x.ProductId,
                        principalTable: "wms_product_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wms_product_tax_tbl_wms_tax_tbl_TaxId",
                        column: x => x.TaxId,
                        principalTable: "wms_tax_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "wms_return_details_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    ReturnId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    UnitId = table.Column<long>(nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalReturnPrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    DetailsId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_return_details_tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wms_return_details_tbl_wms_product_tbl_ProductId",
                        column: x => x.ProductId,
                        principalTable: "wms_product_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wms_return_details_tbl_wms_unit_tbl_UnitId",
                        column: x => x.UnitId,
                        principalTable: "wms_unit_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "wms_sale_details_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    SaleId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    UnitId = table.Column<long>(nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalSalePrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_sale_details_tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wms_sale_details_tbl_wms_product_tbl_ProductId",
                        column: x => x.ProductId,
                        principalTable: "wms_product_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wms_sale_details_tbl_wms_unit_tbl_UnitId",
                        column: x => x.UnitId,
                        principalTable: "wms_unit_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "wms_wastage_details_tbl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    WastageId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    UnitId = table.Column<long>(nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_wastage_details_tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wms_wastage_details_tbl_wms_product_tbl_ProductId",
                        column: x => x.ProductId,
                        principalTable: "wms_product_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wms_wastage_details_tbl_wms_unit_tbl_UnitId",
                        column: x => x.UnitId,
                        principalTable: "wms_unit_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "wms_category_tbl",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name", "Status", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1L, null, null, "Liquefied petroleum gas (LPG, LP gas, or condensate), is a flammable mixture of hydrocarbon gases, most commonly propane, butane, and propylene. However, the latter two typically comprise 5% or less of the mixture.", "Liquefied petroleum gas LPG", 1, null, null, "System Defined" },
                    { 2L, null, null, "Syngas, or synthesis gas, is a fuel gas mixture consisting primarily of hydrogen, carbon monoxide, and very often some carbon dioxide. Syngas can be produced from many sources, including natural gas, coal, biomass, or virtually any hydrocarbon feedstock, by reaction with steam (steam reforming), carbon dioxide (dry reforming) or oxygen (partial oxidation).", "Syngas", 1, null, null, "System Defined" },
                    { 3L, null, null, "Natural gas is colorless and odorless, and explosive, so a sulfur-smell (similar to rotten eggs) is usually added for early detection of leaks", "Natural gas", 1, null, null, "System Defined" },
                    { 4L, null, null, "Propane (/ˈproʊpeɪn/) is a three-carbon alkane with the molecular formula C3H8. It is a gas at standard temperature and pressure, but compressible to a transportable liquid.", "Propane", 1, null, null, "System Defined" },
                    { 5L, null, null, "A gas stove is a stove that is fuelled by combustible gas such as syngas, natural gas, propane, butane, liquefied petroleum gas or other flammable gas.", "Gas stove", 1, null, null, "System Defined" },
                    { 6L, null, null, "Butane is a gas at room temperature and atmospheric pressure. Butane is a highly flammable, colorless, easily liquefied gas that quickly vaporizes at room temperature.", "Butane", 1, null, null, "System Defined" }
                });

            migrationBuilder.InsertData(
                table: "wms_country_tbl",
                columns: new[] { "Id", "Code", "CreatedAt", "DeletedAt", "Name", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1L, "AFN", null, null, "Afghanistan", null, null, "System_Populated" },
                    { 2L, "PK", null, null, "Pakistan", null, null, "System_Populated" },
                    { 3L, "IND", null, null, "India", null, null, "System_Populated" },
                    { 4L, "TUR", null, null, "Turkey", null, null, "System_Populated" },
                    { 5L, "IR", null, null, "Iran", null, null, "System_Populated" }
                });

            migrationBuilder.InsertData(
                table: "wms_designation_tbl",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name", "Status", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 7L, null, null, null, "Pharmacist", 1, null, null, "System Defined" },
                    { 6L, null, null, null, "Gaurd", 1, null, null, "System Defined" },
                    { 5L, null, null, null, "Car Wash", 1, null, null, "System Defined" },
                    { 4L, null, null, null, "Mechanic", 1, null, null, "System Defined" },
                    { 3L, null, null, null, "Feul Attendant", 1, null, null, "System Defined" },
                    { 2L, null, null, null, "Cashir", 1, null, null, "System Defined" },
                    { 1L, null, null, null, "Admin", 1, null, null, "System Defined" }
                });

            migrationBuilder.InsertData(
                table: "wms_expense_category_tbl",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name", "Status", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 23L, null, null, "", "Printing", 1, null, null, "System Defined" },
                    { 22L, null, null, "", "repairs", 1, null, null, "System Defined" },
                    { 21L, null, null, "", "Maintenance", 1, null, null, "System Defined" },
                    { 20L, null, null, "", "Bank fees", 1, null, null, "System Defined" },
                    { 19L, null, null, "", "Meals", 1, null, null, "System Defined" },
                    { 18L, null, null, "", "Health Insurance", 1, null, null, "System Defined" },
                    { 17L, null, null, "", "Insurance", 1, null, null, "System Defined" },
                    { 16L, null, null, "", "Vehicle expenses", 1, null, null, "System Defined" },
                    { 15L, null, null, "", "travel expenses", 1, null, null, "System Defined" },
                    { 14L, null, null, "", "Business meals", 1, null, null, "System Defined" },
                    { 13L, null, null, "", "Entertainment", 1, null, null, "System Defined" },
                    { 10L, null, null, "", "marketing", 1, null, null, "System Defined" },
                    { 11L, null, null, "", "Website", 1, null, null, "System Defined" },
                    { 12L, null, null, "", "Software", 1, null, null, "System Defined" },
                    { 1L, null, null, "", "Rent", 1, null, null, "System Defined" },
                    { 2L, null, null, "", "Electricity", 1, null, null, "System Defined" },
                    { 4L, null, null, "", "Water", 1, null, null, "System Defined" },
                    { 5L, null, null, "", "Air conditioning", 1, null, null, "System Defined" },
                    { 3L, null, null, "", "Gas", 1, null, null, "System Defined" },
                    { 7L, null, null, "", "Cellphones", 1, null, null, "System Defined" },
                    { 8L, null, null, "", "Office supplies", 1, null, null, "System Defined" },
                    { 9L, null, null, "", "Advertising", 1, null, null, "System Defined" },
                    { 6L, null, null, "", "Trash", 1, null, null, "System Defined" }
                });

            migrationBuilder.InsertData(
                table: "wms_manufacturer_tbl",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name", "Status", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 8L, null, null, "", "Burhan Gas Company", 1, null, null, "System_Populated" },
                    { 11L, null, null, "", "ExpoMughal International", 1, null, null, "System_Populated" },
                    { 12L, null, null, "", "HI-Tek Manufacturing (Pvt) Ltd", 1, null, null, "System_Populated" },
                    { 10L, null, null, "", "Engineering solution international", 1, null, null, "System_Populated" },
                    { 9L, null, null, "", "Country Autogas", 1, null, null, "System_Populated" },
                    { 7L, null, null, "", "Bashir gas pvt limited", 1, null, null, "System_Populated" },
                    { 2L, null, null, "China Petroleum and Chemical Corporation, also known as Sinopec, is the second-largest company behind US retailer Walmart and ", "Sinopec", 1, null, null, "System_Populated" },
                    { 5L, null, null, "Eneos Holdings is a Japanese petroleum and metals conglomerate and the fifth-largest oil and gas company in Asia by revenue.The Tokyo - headquartered firm brought in $75.9bn at the end of the 2019 - 20 fiscal year and recorded a $1.7bn loss across the same period.", "Eneos Holdings ", 1, null, null, "System_Populated" },
                    { 4L, null, null, "Saudi Aramco is the state-owned oil company of the Kingdom of Saudi Arabia and is the third-largest oil and gas company in Asia and the fourth-largest in the world by revenue.", " Saudi Aramco", 1, null, null, "System_Populated" },
                    { 3L, null, null, "China National Petroleum is the state-owned parent company of PetroChina – the country’s second-largest oil producer.", "China National Petroleum", 1, null, null, "System_Populated" },
                    { 1L, null, null, "Turkey", "2A Muhendislik San.- Tur ", 1, null, null, "System_Populated" },
                    { 13L, null, null, "", "Pak Engineering and Automation", 1, null, null, "System_Populated" },
                    { 6L, null, null, "", "Adeel Industry(Shan Gas)", 1, null, null, "System_Populated" },
                    { 14L, null, null, "", "Engineering solution international", 1, null, null, "System_Populated" }
                });

            migrationBuilder.InsertData(
                table: "wms_province_tbl",
                columns: new[] { "Id", "CountryCode", "CountryId", "CountryName", "CreatedAt", "DeletedAt", "Name", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1L, "AFN", 1L, "Afghanistan", null, null, "Badakhshan", null, null, "System_Populated" },
                    { 94L, "TUR", 4L, "Turkey", null, null, "Diyarbakır", null, null, "System_Populated" },
                    { 93L, "TUR", 4L, "Turkey", null, null, "Denizli", null, null, "System_Populated" },
                    { 92L, "TUR", 4L, "Turkey", null, null, "Çorum", null, null, "System_Populated" },
                    { 91L, "TUR", 4L, "Turkey", null, null, "Çankırı", null, null, "System_Populated" },
                    { 90L, "TUR", 4L, "Turkey", null, null, "Çanakkale", null, null, "System_Populated" },
                    { 88L, "TUR", 4L, "Turkey", null, null, "Bursa", null, null, "System_Populated" },
                    { 87L, "TUR", 4L, "Turkey", null, null, "Burdur", null, null, "System_Populated" },
                    { 86L, "TUR", 4L, "Turkey", null, null, "Bolu", null, null, "System_Populated" },
                    { 85L, "TUR", 4L, "Turkey", null, null, "Bitlis", null, null, "System_Populated" },
                    { 84L, "TUR", 4L, "Turkey", null, null, "Bingöl", null, null, "System_Populated" },
                    { 83L, "TUR", 4L, "Turkey", null, null, "Bilecik", null, null, "System_Populated" },
                    { 82L, "TUR", 4L, "Turkey", null, null, "Bayburt", null, null, "System_Populated" },
                    { 81L, "TUR", 4L, "Turkey", null, null, "Batman", null, null, "System_Populated" },
                    { 95L, "TUR", 4L, "Turkey", null, null, "Düzce", null, null, "System_Populated" },
                    { 80L, "TUR", 4L, "Turkey", null, null, "Bartın", null, null, "System_Populated" },
                    { 78L, "TUR", 4L, "Turkey", null, null, "Aydın", null, null, "System_Populated" },
                    { 77L, "TUR", 4L, "Turkey", null, null, "Artvin", null, null, "System_Populated" },
                    { 76L, "TUR", 4L, "Turkey", null, null, "Ardahan", null, null, "System_Populated" },
                    { 75L, "TUR", 4L, "Turkey", null, null, "Antalya", null, null, "System_Populated" },
                    { 74L, "TUR", 4L, "Turkey", null, null, "Ankara", null, null, "System_Populated" },
                    { 73L, "TUR", 4L, "Turkey", null, null, "Amasya", null, null, "System_Populated" },
                    { 72L, "TUR", 4L, "Turkey", null, null, "Aksaray", null, null, "System_Populated" },
                    { 71L, "TUR", 4L, "Turkey", null, null, "Ağri", null, null, "System_Populated" },
                    { 70L, "TUR", 4L, "Turkey", null, null, "Afyonkarahisar", null, null, "System_Populated" },
                    { 69L, "TUR", 4L, "Turkey", null, null, "Adıyaman", null, null, "System_Populated" },
                    { 68L, "TUR", 4L, "Turkey", null, null, "Adana", null, null, "System_Populated" },
                    { 67L, "IND", 3L, "India", null, null, "Uttarakhand", null, null, "System_Populated" },
                    { 66L, "IND", 3L, "India", null, null, "Uttar Pradesh", null, null, "System_Populated" },
                    { 79L, "TUR", 4L, "Turkey", null, null, "Balıkesir", null, null, "System_Populated" },
                    { 65L, "IND", 3L, "India", null, null, "Tripura", null, null, "System_Populated" },
                    { 96L, "IR", 5L, "Iran", null, null, "Alborz", null, null, "System_Populated" },
                    { 98L, "IR", 5L, "Iran", null, null, "Razavi Khorasan", null, null, "System_Populated" },
                    { 125L, "IR", 5L, "Iran", null, null, "Markazi", null, null, "System_Populated" },
                    { 124L, "IR", 5L, "Iran", null, null, "Qazvin", null, null, "System_Populated" },
                    { 123L, "IR", 5L, "Iran", null, null, "Gilan", null, null, "System_Populated" },
                    { 122L, "IR", 5L, "Iran", null, null, "Ardabil", null, null, "System_Populated" },
                    { 121L, "IR", 5L, "Iran", null, null, "Zanjan", null, null, "System_Populated" },
                    { 120L, "IR", 5L, "Iran", null, null, "East Azarbaijan", null, null, "System_Populated" },
                    { 119L, "IR", 5L, "Iran", null, null, "West Azarbaijan", null, null, "System_Populated" },
                    { 118L, "IR", 5L, "Iran", null, null, "Kurdistan", null, null, "System_Populated" },
                    { 117L, "IR", 5L, "Iran", null, null, "Hamadan", null, null, "System_Populated" },
                    { 128L, "IR", 5L, "Iran", null, null, "Kermanshah", null, null, "System_Populated" },
                    { 116L, "IR", 5L, "Iran", null, null, "Ilam", null, null, "System_Populated" },
                    { 115L, "IR", 5L, "Iran", null, null, "Lorestan", null, null, "System_Populated" },
                    { 114L, "IR", 5L, "Iran", null, null, "Khuzestan", null, null, "System_Populated" },
                    { 97L, "IR", 5L, "Iran", null, null, "South Khorasan", null, null, "System_Populated" },
                    { 113L, "IR", 5L, "Iran", null, null, "Chahar Mahaal", null, null, "System_Populated" },
                    { 111L, "IR", 5L, "Iran", null, null, "Kohkiluyeh", null, null, "System_Populated" },
                    { 110L, "IR", 5L, "Iran", null, null, "Buyer Ahmad", null, null, "System_Populated" },
                    { 109L, "IR", 5L, "Iran", null, null, "Bushehr", null, null, "System_Populated" },
                    { 108L, "IR", 5L, "Iran", null, null, "Fars", null, null, "System_Populated" },
                    { 107L, "IR", 5L, "Iran", null, null, "Hormozgan", null, null, "System_Populated" },
                    { 106L, "IR", 5L, "Iran", null, null, "Sistan-Baluchistan", null, null, "System_Populated" },
                    { 105L, "IR", 5L, "Iran", null, null, "Kerman", null, null, "System_Populated" },
                    { 104L, "IR", 5L, "Iran", null, null, "Yazd", null, null, "System_Populated" },
                    { 103L, "IR", 5L, "Iran", null, null, "Esfahan", null, null, "System_Populated" },
                    { 102L, "IR", 5L, "Iran", null, null, "Semnan", null, null, "System_Populated" },
                    { 101L, "IR", 5L, "Iran", null, null, "Mazandaran", null, null, "System_Populated" },
                    { 100L, "IR", 5L, "Iran", null, null, "Golestan", null, null, "System_Populated" },
                    { 99L, "IR", 5L, "Iran", null, null, "North Khorasan", null, null, "System_Populated" },
                    { 112L, "IR", 5L, "Iran", null, null, "Bakhtiari", null, null, "System_Populated" },
                    { 126L, "IR", 5L, "Iran", null, null, "Qom", null, null, "System_Populated" },
                    { 64L, "IND", 3L, "India", null, null, "Telangana", null, null, "System_Populated" },
                    { 62L, "IND", 3L, "India", null, null, "Tamil Nadu", null, null, "System_Populated" },
                    { 29L, "AFN", 1L, "Afghanistan", null, null, "Parwan", null, null, "System_Populated" },
                    { 28L, "AFN", 1L, "Afghanistan", null, null, "Panjshir", null, null, "System_Populated" },
                    { 27L, "AFN", 1L, "Afghanistan", null, null, "Paktika", null, null, "System_Populated" },
                    { 26L, "AFN", 1L, "Afghanistan", null, null, "Paktia", null, null, "System_Populated" },
                    { 25L, "AFN", 1L, "Afghanistan", null, null, "Urozgan", null, null, "System_Populated" },
                    { 24L, "AFN", 1L, "Afghanistan", null, null, "Nuristan", null, null, "System_Populated" },
                    { 23L, "AFN", 1L, "Afghanistan", null, null, "Nimruz", null, null, "System_Populated" },
                    { 22L, "AFN", 1L, "Afghanistan", null, null, "Nangarhar", null, null, "System_Populated" },
                    { 21L, "AFN", 1L, "Afghanistan", null, null, "Logar", null, null, "System_Populated" },
                    { 20L, "AFN", 1L, "Afghanistan", null, null, "Laghman", null, null, "System_Populated" },
                    { 19L, "AFN", 1L, "Afghanistan", null, null, "Kunduz", null, null, "System_Populated" },
                    { 18L, "AFN", 1L, "Afghanistan", null, null, "Kunar", null, null, "System_Populated" },
                    { 17L, "AFN", 1L, "Afghanistan", null, null, "Khost", null, null, "System_Populated" },
                    { 30L, "AFN", 1L, "Afghanistan", null, null, "Samangan", null, null, "System_Populated" },
                    { 16L, "AFN", 1L, "Afghanistan", null, null, "Kapisa", null, null, "System_Populated" },
                    { 14L, "AFN", 1L, "Afghanistan", null, null, "Kabul", null, null, "System_Populated" },
                    { 13L, "AFN", 1L, "Afghanistan", null, null, "Jowzjan", null, null, "System_Populated" },
                    { 12L, "AFN", 1L, "Afghanistan", null, null, "Herat", null, null, "System_Populated" },
                    { 11L, "AFN", 1L, "Afghanistan", null, null, "Helmand", null, null, "System_Populated" },
                    { 10L, "AFN", 1L, "Afghanistan", null, null, "Ghor", null, null, "System_Populated" },
                    { 9L, "AFN", 1L, "Afghanistan", null, null, "Ghazni", null, null, "System_Populated" },
                    { 8L, "AFN", 1L, "Afghanistan", null, null, "Faryab", null, null, "System_Populated" },
                    { 7L, "AFN", 1L, "Afghanistan", null, null, "Farah", null, null, "System_Populated" },
                    { 6L, "AFN", 1L, "Afghanistan", null, null, "Daykundi", null, null, "System_Populated" },
                    { 5L, "AFN", 1L, "Afghanistan", null, null, "Bamyan", null, null, "System_Populated" },
                    { 4L, "AFN", 1L, "Afghanistan", null, null, "Balkh", null, null, "System_Populated" },
                    { 3L, "AFN", 1L, "Afghanistan", null, null, "Baghlan", null, null, "System_Populated" },
                    { 2L, "AFN", 1L, "Afghanistan", null, null, "Badghis", null, null, "System_Populated" },
                    { 15L, "AFN", 1L, "Afghanistan", null, null, "Kandahar", null, null, "System_Populated" },
                    { 63L, "IND", 3L, "India", null, null, "Telangana", null, null, "System_Populated" },
                    { 31L, "AFN", 1L, "Afghanistan", null, null, "Sar-e Pol", null, null, "System_Populated" },
                    { 33L, "AFN", 1L, "Afghanistan", null, null, "Wardak", null, null, "System_Populated" },
                    { 61L, "IND", 3L, "India", null, null, "Sikkim", null, null, "System_Populated" },
                    { 60L, "IND", 3L, "India", null, null, "Rajasthan", null, null, "System_Populated" },
                    { 59L, "IND", 3L, "India", null, null, "Punjab", null, null, "System_Populated" },
                    { 58L, "IND", 3L, "India", null, null, "Odisha", null, null, "System_Populated" },
                    { 57L, "IND", 3L, "India", null, null, "Nagaland", null, null, "System_Populated" },
                    { 56L, "IND", 3L, "India", null, null, "Mizoram", null, null, "System_Populated" },
                    { 55L, "IND", 3L, "India", null, null, "Meghalaya", null, null, "System_Populated" },
                    { 54L, "IND", 3L, "India", null, null, "Manipur", null, null, "System_Populated" },
                    { 53L, "IND", 3L, "India", null, null, "Maharashtra", null, null, "System_Populated" },
                    { 52L, "IND", 3L, "India", null, null, "Madhya Pradesh", null, null, "System_Populated" },
                    { 51L, "IND", 3L, "India", null, null, "Kerala", null, null, "System_Populated" },
                    { 50L, "IND", 3L, "India", null, null, "Karnataka", null, null, "System_Populated" },
                    { 49L, "IND", 3L, "India", null, null, "Jharkhand", null, null, "System_Populated" },
                    { 32L, "AFN", 1L, "Afghanistan", null, null, "Takhar", null, null, "System_Populated" },
                    { 48L, "IND", 3L, "India", null, null, "Himachal Pradesh", null, null, "System_Populated" },
                    { 46L, "IND", 3L, "India", null, null, "Gujarat", null, null, "System_Populated" },
                    { 45L, "IND", 3L, "India", null, null, "Goa", null, null, "System_Populated" },
                    { 44L, "IND", 3L, "India", null, null, "Chhattisgarh", null, null, "System_Populated" },
                    { 43L, "IND", 3L, "India", null, null, "Bihar", null, null, "System_Populated" },
                    { 42L, "IND", 3L, "India", null, null, "Assam", null, null, "System_Populated" },
                    { 41L, "IND", 3L, "India", null, null, "Arunachal Pradesh", null, null, "System_Populated" },
                    { 40L, "IND", 3L, "India", null, null, "Andhra Pradesh", null, null, "System_Populated" },
                    { 39L, "PK", 2L, "Pakistan", null, null, "Peshawar", null, null, "System_Populated" },
                    { 38L, "PK", 2L, "Pakistan", null, null, "Sohawa", null, null, "System_Populated" },
                    { 37L, "PK", 2L, "Pakistan", null, null, "Jehlum", null, null, "System_Populated" },
                    { 36L, "PK", 2L, "Pakistan", null, null, "RawalPindi", null, null, "System_Populated" },
                    { 35L, "PK", 2L, "Pakistan", null, null, "Punjab", null, null, "System_Populated" },
                    { 34L, "AFN", 1L, "Afghanistan", null, null, "Zabul", null, null, "System_Populated" },
                    { 47L, "IND", 3L, "India", null, null, "Haryana", null, null, "System_Populated" },
                    { 127L, "IR", 5L, "Iran", null, null, "Tehran", null, null, "System_Populated" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnits_UnitId",
                table: "ProductUnits",
                column: "UnitId");

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
                name: "IX_wms_country_tbl_Name",
                table: "wms_country_tbl",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_wms_customer_ledger_tbl_CustomerId",
                table: "wms_customer_ledger_tbl",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_employee_tbl_NationalIdnumber",
                table: "wms_employee_tbl",
                column: "NationalIdnumber",
                unique: true,
                filter: "[NationalIdnumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_wms_expense_category_tbl_Name",
                table: "wms_expense_category_tbl",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_wms_partner_ledger_tbl_partnerId",
                table: "wms_partner_ledger_tbl",
                column: "partnerId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_product_tax_tbl_TaxId",
                table: "wms_product_tax_tbl",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_product_tbl_CategoryId",
                table: "wms_product_tbl",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_product_tbl_ProductTypeId",
                table: "wms_product_tbl",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_province_tbl_CountryId",
                table: "wms_province_tbl",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_return_details_tbl_ProductId",
                table: "wms_return_details_tbl",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_return_details_tbl_UnitId",
                table: "wms_return_details_tbl",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_sale_details_tbl_ProductId",
                table: "wms_sale_details_tbl",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_sale_details_tbl_UnitId",
                table: "wms_sale_details_tbl",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_service_category_tbl_Name",
                table: "wms_service_category_tbl",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_wms_supplier_tbl_Countryid",
                table: "wms_supplier_tbl",
                column: "Countryid");

            migrationBuilder.CreateIndex(
                name: "IX_wms_supplier_tbl_Provinceid",
                table: "wms_supplier_tbl",
                column: "Provinceid");

            migrationBuilder.CreateIndex(
                name: "IX_wms_wastage_details_tbl_ProductId",
                table: "wms_wastage_details_tbl",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_wastage_details_tbl_UnitId",
                table: "wms_wastage_details_tbl",
                column: "UnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "pms_employee_ledger_tbl");

            migrationBuilder.DropTable(
                name: "pms_employee_salaries_tbl");

            migrationBuilder.DropTable(
                name: "ProductUnits");

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
                name: "wms_bank_ledger_tbl");

            migrationBuilder.DropTable(
                name: "wms_bank_tbl");

            migrationBuilder.DropTable(
                name: "wms_bank_transaction_tbl");

            migrationBuilder.DropTable(
                name: "wms_cash_ledger_tbl");

            migrationBuilder.DropTable(
                name: "wms_customer_advanced_tbl");

            migrationBuilder.DropTable(
                name: "wms_customer_ledger_tbl");

            migrationBuilder.DropTable(
                name: "wms_customer_receive_tbl");

            migrationBuilder.DropTable(
                name: "wms_designation_tbl");

            migrationBuilder.DropTable(
                name: "wms_expense_category_tbl");

            migrationBuilder.DropTable(
                name: "wms_expense_tbl");

            migrationBuilder.DropTable(
                name: "wms_manufacturer_tbl");

            migrationBuilder.DropTable(
                name: "wms_office_loan_ledger_tbl");

            migrationBuilder.DropTable(
                name: "wms_office_loan_payment_tbl");

            migrationBuilder.DropTable(
                name: "wms_office_loan_receive_tbl");

            migrationBuilder.DropTable(
                name: "wms_office_person_tbl");

            migrationBuilder.DropTable(
                name: "wms_partner_investment_tbl");

            migrationBuilder.DropTable(
                name: "wms_partner_ledger_tbl");

            migrationBuilder.DropTable(
                name: "wms_partner_payment_tbl");

            migrationBuilder.DropTable(
                name: "wms_partners_purchase_shares_tbl");

            migrationBuilder.DropTable(
                name: "wms_person_loan_ledger_tbl");

            migrationBuilder.DropTable(
                name: "wms_person_loan_payment_tbl");

            migrationBuilder.DropTable(
                name: "wms_person_loan_receive_tbl");

            migrationBuilder.DropTable(
                name: "wms_person_tbl");

            migrationBuilder.DropTable(
                name: "wms_product_batch_tbl");

            migrationBuilder.DropTable(
                name: "wms_product_supplier_tbl");

            migrationBuilder.DropTable(
                name: "wms_product_tax_tbl");

            migrationBuilder.DropTable(
                name: "wms_purchase_details_tbl");

            migrationBuilder.DropTable(
                name: "wms_purchase_tbl");

            migrationBuilder.DropTable(
                name: "wms_quote_details_tbl");

            migrationBuilder.DropTable(
                name: "wms_quote_tbl");

            migrationBuilder.DropTable(
                name: "wms_return_details_tbl");

            migrationBuilder.DropTable(
                name: "wms_return_tbl");

            migrationBuilder.DropTable(
                name: "wms_sale_details_tbl");

            migrationBuilder.DropTable(
                name: "wms_sale_tbl");

            migrationBuilder.DropTable(
                name: "wms_service_category_tbl");

            migrationBuilder.DropTable(
                name: "wms_service_details_tbl");

            migrationBuilder.DropTable(
                name: "wms_service_tbl");

            migrationBuilder.DropTable(
                name: "wms_shop_tbl");

            migrationBuilder.DropTable(
                name: "wms_stock_details_tbl");

            migrationBuilder.DropTable(
                name: "wms_stock_purchase_log_tbl");

            migrationBuilder.DropTable(
                name: "wms_stock_tbl");

            migrationBuilder.DropTable(
                name: "wms_supplier_advanced_tbl");

            migrationBuilder.DropTable(
                name: "wms_supplier_ledger_tbl");

            migrationBuilder.DropTable(
                name: "wms_supplier_payment_tbl");

            migrationBuilder.DropTable(
                name: "wms_supplier_tbl");

            migrationBuilder.DropTable(
                name: "wms_transaction_tbl");

            migrationBuilder.DropTable(
                name: "wms_wastage_details_tbl");

            migrationBuilder.DropTable(
                name: "wms_wastage_tbl");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "wms_employee_tbl");

            migrationBuilder.DropTable(
                name: "wms_customer_tbl");

            migrationBuilder.DropTable(
                name: "wms_partner_tbl");

            migrationBuilder.DropTable(
                name: "wms_tax_tbl");

            migrationBuilder.DropTable(
                name: "wms_province_tbl");

            migrationBuilder.DropTable(
                name: "wms_product_tbl");

            migrationBuilder.DropTable(
                name: "wms_unit_tbl");

            migrationBuilder.DropTable(
                name: "wms_country_tbl");

            migrationBuilder.DropTable(
                name: "wms_category_tbl");

            migrationBuilder.DropTable(
                name: "wms_product_type_tbl");
        }
    }
}
