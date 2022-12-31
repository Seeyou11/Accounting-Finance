using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    public partial class MIGRATIONNAME : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountingFinances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OfficeRentprice = table.Column<double>(type: "float", nullable: false),
                    EmployeeSalary = table.Column<double>(type: "float", nullable: false),
                    TaxPrice = table.Column<double>(type: "float", nullable: false),
                    OfficeSupplyPrice = table.Column<double>(type: "float", nullable: false),
                    SoldSWPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingFinances", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountingFinances");
        }
    }
}
