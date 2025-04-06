using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KratomShop.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f9c0980f-0fac-44b1-a59e-d55a64d9ad01", 0, "c83c7a5b-384f-4931-9519-9cb38c9d5587", "test@example.com", true, "Jan", "Novák", true, null, "TEST@EXAMPLE.COM", "TEST@EXAMPLE.COM", "AQAAAAIAAYagAAAAELoBI1bJ+o6zQGobyYB41a8Ik1OMUq2ssHB/pVWg2ywvMyvdRoqrBmhGVQpG8RLtkg==", null, false, "a7985672-2bb6-4d79-87e9-50b50b1547d3", false, "test@example.com" },
                    { "f9c0980f-0fac-44b1-a59e-d55a64d9ad04", 0, "64bcc02f-f78b-4e96-bc91-23eefd7d60ad", "user2@example.com", true, "Petr", "Novotný", true, null, "USER2@EXAMPLE.COM", "USER2@EXAMPLE.COM", "AQAAAAIAAYagAAAAELoBI1bJ+o6zQGobyYB41a8Ik1OMUq2ssHB/pVWg2ywvMyvdRoqrBmhGVQpG8RLtkg==", null, false, "5b9391c6-5c06-47f8-8ca6-cb12b6f45c2e", false, "user2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageUrl", "IsActive", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("94734818-e8a8-4142-937e-af6d71dd2823"), new DateTime(2024, 4, 6, 16, 20, 0, 0, DateTimeKind.Utc).AddTicks(3306), "A potent strain with energizing effects.", "/images/green-bali.png", true, "Kratom Green Maeng Da", 850.99m, 50 },
                    { new Guid("e05c5364-c6ed-48a2-854b-c22aafd9b543"), new DateTime(2024, 4, 6, 16, 20, 0, 0, DateTimeKind.Utc).AddTicks(3306), "A popular strain known for its relaxing effects.", "/images/green-bali.png", true, "Kratom Red Bali", 799.00m, 100 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "ItemId", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("03c02b6e-524e-4fed-9ac8-809acd6eef12"), "Kratom byl výborný, určitě objednám znovu!", new DateTime(2024, 4, 6, 16, 20, 0, 0, DateTimeKind.Utc).AddTicks(3315), new Guid("e05c5364-c6ed-48a2-854b-c22aafd9b543"), 5, "f9c0980f-0fac-44b1-a59e-d55a64d9ad01" },
                    { new Guid("88b1a6fb-c1ae-4210-af91-282daad1e2b1"), "Velmi kvalitní kratom, jeden z nejlepších, co jsem vyzkoušel.", new DateTime(2024, 4, 6, 16, 25, 0, 0, DateTimeKind.Utc).AddTicks(3315), new Guid("e05c5364-c6ed-48a2-854b-c22aafd9b543"), 4, "f9c0980f-0fac-44b1-a59e-d55a64d9ad04" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("94734818-e8a8-4142-937e-af6d71dd2823"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("03c02b6e-524e-4fed-9ac8-809acd6eef12"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("88b1a6fb-c1ae-4210-af91-282daad1e2b1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9c0980f-0fac-44b1-a59e-d55a64d9ad01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9c0980f-0fac-44b1-a59e-d55a64d9ad04");

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e05c5364-c6ed-48a2-854b-c22aafd9b543"));
        }
    }
}
