using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class LoanModuleCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wms_office_loan_ledger_tbl");

            migrationBuilder.DropTable(
                name: "wms_office_loan_payment_tbl");

            migrationBuilder.DropTable(
                name: "wms_office_loan_receive_tbl");

            migrationBuilder.DropTable(
                name: "wms_office_person_tbl");

            migrationBuilder.DropTable(
                name: "wms_person_loan_ledger_tbl");

            migrationBuilder.DropTable(
                name: "wms_person_loan_payment_tbl");

            migrationBuilder.DropTable(
                name: "wms_person_loan_receive_tbl");

            migrationBuilder.DropTable(
                name: "wms_person_tbl");
        }
    }
}
