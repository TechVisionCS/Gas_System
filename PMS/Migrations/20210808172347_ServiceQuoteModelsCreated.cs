using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class ServiceQuoteModelsCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTaxes_wms_product_tbl_ProductId",
                table: "ProductTaxes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTaxes_wms_tax_tbl_TaxId",
                table: "ProductTaxes");

            migrationBuilder.DropForeignKey(
                name: "FK_wms_product_tbl_ProductTypes_ProductTypeId",
                table: "wms_product_tbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTypes",
                table: "ProductTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTaxes",
                table: "ProductTaxes");

            migrationBuilder.RenameTable(
                name: "ProductTypes",
                newName: "wms_product_type_tbl");

            migrationBuilder.RenameTable(
                name: "ProductTaxes",
                newName: "wms_product_tax_tbl");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTaxes_TaxId",
                table: "wms_product_tax_tbl",
                newName: "IX_wms_product_tax_tbl_TaxId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_wms_product_type_tbl",
                table: "wms_product_type_tbl",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_wms_product_tax_tbl",
                table: "wms_product_tax_tbl",
                columns: new[] { "ProductId", "TaxId" });

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

            migrationBuilder.CreateIndex(
                name: "IX_wms_service_category_tbl_Name",
                table: "wms_service_category_tbl",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_wms_product_tax_tbl_wms_product_tbl_ProductId",
                table: "wms_product_tax_tbl",
                column: "ProductId",
                principalTable: "wms_product_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_wms_product_tax_tbl_wms_tax_tbl_TaxId",
                table: "wms_product_tax_tbl",
                column: "TaxId",
                principalTable: "wms_tax_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_wms_product_tbl_wms_product_type_tbl_ProductTypeId",
                table: "wms_product_tbl",
                column: "ProductTypeId",
                principalTable: "wms_product_type_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wms_product_tax_tbl_wms_product_tbl_ProductId",
                table: "wms_product_tax_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_wms_product_tax_tbl_wms_tax_tbl_TaxId",
                table: "wms_product_tax_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_wms_product_tbl_wms_product_type_tbl_ProductTypeId",
                table: "wms_product_tbl");

            migrationBuilder.DropTable(
                name: "wms_quote_details_tbl");

            migrationBuilder.DropTable(
                name: "wms_quote_tbl");

            migrationBuilder.DropTable(
                name: "wms_service_category_tbl");

            migrationBuilder.DropTable(
                name: "wms_service_details_tbl");

            migrationBuilder.DropTable(
                name: "wms_service_tbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_wms_product_type_tbl",
                table: "wms_product_type_tbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_wms_product_tax_tbl",
                table: "wms_product_tax_tbl");

            migrationBuilder.RenameTable(
                name: "wms_product_type_tbl",
                newName: "ProductTypes");

            migrationBuilder.RenameTable(
                name: "wms_product_tax_tbl",
                newName: "ProductTaxes");

            migrationBuilder.RenameIndex(
                name: "IX_wms_product_tax_tbl_TaxId",
                table: "ProductTaxes",
                newName: "IX_ProductTaxes_TaxId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTypes",
                table: "ProductTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTaxes",
                table: "ProductTaxes",
                columns: new[] { "ProductId", "TaxId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTaxes_wms_product_tbl_ProductId",
                table: "ProductTaxes",
                column: "ProductId",
                principalTable: "wms_product_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTaxes_wms_tax_tbl_TaxId",
                table: "ProductTaxes",
                column: "TaxId",
                principalTable: "wms_tax_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_wms_product_tbl_ProductTypes_ProductTypeId",
                table: "wms_product_tbl",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
