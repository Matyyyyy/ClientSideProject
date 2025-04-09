using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KratomShop.Migrations
{
    /// <inheritdoc />
    public partial class Vat_edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "VatRate",
                table: "OrderLines",
                type: "decimal(6,4)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "VatRate",
                table: "Items",
                type: "decimal(6,4)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("94734818-e8a8-4142-937e-af6d71dd2823"),
                column: "VatRate",
                value: 0.21m);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e05c5364-c6ed-48a2-854b-c22aafd9b543"),
                column: "VatRate",
                value: 0.21m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "VatRate",
                table: "OrderLines",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,4)");

            migrationBuilder.AlterColumn<int>(
                name: "VatRate",
                table: "Items",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,4)");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("94734818-e8a8-4142-937e-af6d71dd2823"),
                column: "VatRate",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e05c5364-c6ed-48a2-854b-c22aafd9b543"),
                column: "VatRate",
                value: 0);
        }
    }
}
