using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class initialMigration : Migration
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
                name: "ProductTypes",
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
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
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
                    Signature = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_bank_tbl", x => x.Id);
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
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    VoucherNo = table.Column<string>(nullable: true),
                    MyProperty = table.Column<int>(nullable: false),
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
                    BatchId = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    ProductId = table.Column<long>(nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
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
                    InQty = table.Column<float>(nullable: false),
                    OutQty = table.Column<float>(nullable: false),
                    StockQty = table.Column<float>(nullable: false),
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
                    TotalStockSalePrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TotalStockPurchasePrice = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_stock_tbl", x => x.Id);
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
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_unit_tbl", x => x.Id);
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
                    TransID = table.Column<string>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_bank_transaction_tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wms_bank_transaction_tbl_wms_bank_tbl_BankId",
                        column: x => x.BankId,
                        principalTable: "wms_bank_tbl",
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
                    Category = table.Column<long>(nullable: false),
                    Type = table.Column<long>(nullable: false),
                    Model = table.Column<long>(nullable: false),
                    Unit = table.Column<long>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CategoryId = table.Column<long>(nullable: true),
                    ProductTypeId = table.Column<long>(nullable: true),
                    UnitId = table.Column<long>(nullable: true)
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
                        name: "FK_wms_product_tbl_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wms_product_tbl_wms_unit_tbl_UnitId",
                        column: x => x.UnitId,
                        principalTable: "wms_unit_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    VoucherNo = table.Column<string>(nullable: true),
                    MyProperty = table.Column<int>(nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Credit = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TransCode = table.Column<string>(nullable: true),
                    TransType = table.Column<int>(nullable: false),
                    isClosed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_bank_ledger_tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wms_bank_ledger_tbl_wms_bank_transaction_tbl_EntityId",
                        column: x => x.EntityId,
                        principalTable: "wms_bank_transaction_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    countrysid = table.Column<long>(nullable: false),
                    Provincesid = table.Column<long>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    PreviousBalance = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_customer_tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wms_customer_tbl_wms_province_tbl_Provincesid",
                        column: x => x.Provincesid,
                        principalTable: "wms_province_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wms_customer_tbl_wms_country_tbl_countrysid",
                        column: x => x.countrysid,
                        principalTable: "wms_country_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Description = table.Column<string>(nullable: true),
                    PreviousBalance = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Province_id = table.Column<long>(nullable: false),
                    Country_id = table.Column<long>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    RegDate = table.Column<string>(nullable: true),
                    Provinceid = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_partner_tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wms_partner_tbl_wms_country_tbl_Country_id",
                        column: x => x.Country_id,
                        principalTable: "wms_country_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wms_partner_tbl_wms_province_tbl_Provinceid",
                        column: x => x.Provinceid,
                        principalTable: "wms_province_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Phone = table.Column<string>(maxLength: 15, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Countryid = table.Column<long>(nullable: false),
                    Provinceid = table.Column<long>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    PreviousBalance = table.Column<decimal>(type: "decimal(38, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_supplier_ledger_tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wms_supplier_ledger_tbl_wms_country_tbl_Countryid",
                        column: x => x.Countryid,
                        principalTable: "wms_country_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wms_supplier_ledger_tbl_wms_province_tbl_Provinceid",
                        column: x => x.Provinceid,
                        principalTable: "wms_province_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductTaxes",
                columns: table => new
                {
                    ProductId = table.Column<long>(nullable: false),
                    TaxId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTaxes", x => new { x.ProductId, x.TaxId });
                    table.ForeignKey(
                        name: "FK_ProductTaxes_wms_product_tbl_ProductId",
                        column: x => x.ProductId,
                        principalTable: "wms_product_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductTaxes_wms_tax_tbl_TaxId",
                        column: x => x.TaxId,
                        principalTable: "wms_tax_tbl",
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
                    isClosed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_customer_ledger_tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wms_customer_ledger_tbl_wms_customer_tbl_EntityId",
                        column: x => x.EntityId,
                        principalTable: "wms_customer_tbl",
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
                    MyProperty = table.Column<int>(nullable: false),
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
                name: "SupplierLedgers",
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
                    MyProperty = table.Column<int>(nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Credit = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(38, 2)", nullable: false),
                    TransCode = table.Column<string>(nullable: true),
                    isClosed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierLedgers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplierLedgers_wms_supplier_ledger_tbl_EntityId",
                        column: x => x.EntityId,
                        principalTable: "wms_supplier_ledger_tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_ProductTaxes_TaxId",
                table: "ProductTaxes",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLedgers_EntityId",
                table: "SupplierLedgers",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_bank_ledger_tbl_EntityId",
                table: "wms_bank_ledger_tbl",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_bank_transaction_tbl_BankId",
                table: "wms_bank_transaction_tbl",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_customer_ledger_tbl_EntityId",
                table: "wms_customer_ledger_tbl",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_customer_tbl_Provincesid",
                table: "wms_customer_tbl",
                column: "Provincesid");

            migrationBuilder.CreateIndex(
                name: "IX_wms_customer_tbl_countrysid",
                table: "wms_customer_tbl",
                column: "countrysid");

            migrationBuilder.CreateIndex(
                name: "IX_wms_partner_ledger_tbl_partnerId",
                table: "wms_partner_ledger_tbl",
                column: "partnerId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_partner_tbl_Country_id",
                table: "wms_partner_tbl",
                column: "Country_id");

            migrationBuilder.CreateIndex(
                name: "IX_wms_partner_tbl_Provinceid",
                table: "wms_partner_tbl",
                column: "Provinceid");

            migrationBuilder.CreateIndex(
                name: "IX_wms_product_batch_tbl_BatchId",
                table: "wms_product_batch_tbl",
                column: "BatchId",
                unique: true,
                filter: "[BatchId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_wms_product_batch_tbl_Code",
                table: "wms_product_batch_tbl",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_wms_product_tbl_CategoryId",
                table: "wms_product_tbl",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_product_tbl_ProductTypeId",
                table: "wms_product_tbl",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_product_tbl_UnitId",
                table: "wms_product_tbl",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_province_tbl_CountryId",
                table: "wms_province_tbl",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_wms_supplier_ledger_tbl_Countryid",
                table: "wms_supplier_ledger_tbl",
                column: "Countryid");

            migrationBuilder.CreateIndex(
                name: "IX_wms_supplier_ledger_tbl_Provinceid",
                table: "wms_supplier_ledger_tbl",
                column: "Provinceid");
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
                name: "ProductTaxes");

            migrationBuilder.DropTable(
                name: "SupplierLedgers");

            migrationBuilder.DropTable(
                name: "wms_bank_ledger_tbl");

            migrationBuilder.DropTable(
                name: "wms_cash_ledger_tbl");

            migrationBuilder.DropTable(
                name: "wms_customer_ledger_tbl");

            migrationBuilder.DropTable(
                name: "wms_partner_ledger_tbl");

            migrationBuilder.DropTable(
                name: "wms_product_batch_tbl");

            migrationBuilder.DropTable(
                name: "wms_product_supplier_tbl");

            migrationBuilder.DropTable(
                name: "wms_stock_details_tbl");

            migrationBuilder.DropTable(
                name: "wms_stock_purchase_log_tbl");

            migrationBuilder.DropTable(
                name: "wms_stock_tbl");

            migrationBuilder.DropTable(
                name: "wms_transaction_tbl");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "wms_product_tbl");

            migrationBuilder.DropTable(
                name: "wms_tax_tbl");

            migrationBuilder.DropTable(
                name: "wms_supplier_ledger_tbl");

            migrationBuilder.DropTable(
                name: "wms_bank_transaction_tbl");

            migrationBuilder.DropTable(
                name: "wms_customer_tbl");

            migrationBuilder.DropTable(
                name: "wms_partner_tbl");

            migrationBuilder.DropTable(
                name: "wms_category_tbl");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "wms_unit_tbl");

            migrationBuilder.DropTable(
                name: "wms_bank_tbl");

            migrationBuilder.DropTable(
                name: "wms_province_tbl");

            migrationBuilder.DropTable(
                name: "wms_country_tbl");
        }
    }
}
