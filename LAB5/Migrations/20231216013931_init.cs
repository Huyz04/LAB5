using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB5.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Makh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Cthds",
                columns: table => new
                {
                    Mahd = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Mama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sl = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cthds", x => x.Mahd);
                });

            migrationBuilder.CreateTable(
                name: "Hoadons",
                columns: table => new
                {
                    Mahd = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Makh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tht = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ngayhd = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoadons", x => x.Mahd);
                });

            migrationBuilder.CreateTable(
                name: "Khachhangs",
                columns: table => new
                {
                    Makh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngaysinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachhangs", x => x.Makh);
                });

            migrationBuilder.CreateTable(
                name: "Monans",
                columns: table => new
                {
                    Mama = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tenma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dongia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Loaima = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monans", x => x.Mama);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Cthds");

            migrationBuilder.DropTable(
                name: "Hoadons");

            migrationBuilder.DropTable(
                name: "Khachhangs");

            migrationBuilder.DropTable(
                name: "Monans");
        }
    }
}
