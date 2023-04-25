using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KTBook.Data.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "95f119ea-487a-4e2d-91f3-53db5717bb45");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "5a0256e5-77bf-4333-8152-9ec525b69b4a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "O",
                column: "ConcurrencyStamp",
                value: "37eb22fa-47ef-443b-b4de-f488a6ef9421");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37bd59c2-db67-4504-9364-c3d1d7a02bfc", "AQAAAAEAACcQAAAAEKVDpQwh/wtnJRZAMRwZZlHMteK9Veom3ouo4dvTwmMszaRA2roe3s8JWo7MDo9MRQ==", "63fef06f-7296-4fc1-aa96-74bd4b818f69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3585138-2a35-4023-b2ca-170ec4651346", "AQAAAAEAACcQAAAAEEe5DhmaexL/IpXF1O5IHYl/SKDMXar9aP+Ye7uctcCsuVnDJ1ijMG2/8JmS/Un6zQ==", "f2f48d1b-63bd-4ddf-adc1-9d3c09ef3bf6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56e35f51-0e51-4ff0-8f82-5f1b4feaf113", "AQAAAAEAACcQAAAAEAYiKs45X4oageiO4RaTFXNWLskjPD0ua4b9rINQGYU5tuPpZ+SPCna9CVwP4ilC1w==", "9350ca3c-1cb1-400d-9cdd-3a7ab7a19d88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "650bbadb-decb-48f0-a616-482471957850", "AQAAAAEAACcQAAAAEAddjpA3klMtsgETps3EiPrq4ZXdMgAXhFz9k12LPA5ouiksL1XArSLUwrc/SuSd9w==", "2b07fbd8-86e1-43f7-9100-e194495ceb3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ef432bc-d65b-4982-8494-045754ec0e96", "AQAAAAEAACcQAAAAECemc7Z0N4/r7qx/m2MKoVLyb67SjIBYDKxJO60NKHwZ2Y0MDEZEzCgjQFSS0PvTZQ==", "92e784f7-6d54-4fb9-94f0-af65fb958fc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97154e03-12b4-4a08-b417-39e05174f2fa", "AQAAAAEAACcQAAAAEFaJ7RTi/B5F015tQCwQ3U93aeMwU7SVLH+9Cw1pNq7sb0xeceWAj9KKn6o/8phxWg==", "83797804-4e80-44e1-8973-0d8683cea7fb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "b928dda7-2bba-40a1-91df-85fa5febd18d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "ff7b6271-de4e-4c59-8c51-0e6730fdef56");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "O",
                column: "ConcurrencyStamp",
                value: "106feaee-7ece-4751-aa47-99d7adb8b7d9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8391a69-f91c-46d3-b575-42c992313c9e", "AQAAAAEAACcQAAAAEKTeRNsxckiBShT1p9RlQfy1cDmg9FB+o/08FxMGkD5wwmMkuvIoCrsaxTq5AKKwMw==", "56f48c51-f94d-4357-bd0b-2d70b9a5ed09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "567d7f3c-3151-4ed9-a6e5-51ec1cbbd0a8", "AQAAAAEAACcQAAAAEM+WtYRVgrwjnvoU1bWiKTR8fpZKVOYAQr0Sd8EypkZspcuAbeXy7qaUn65rdBLPFA==", "22f87684-7153-486a-ad02-b33123e30121" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70000aae-e48c-463b-859f-1e3e0cb85e34", "AQAAAAEAACcQAAAAECTO00EgR6dLIcL5kyw7o3HBjPnsLHxQUjqdsKFlzsT1gjs06OYXRNypJafYQEiL/g==", "66529560-67c6-4224-a23c-05742eb9c697" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e609817-9871-4742-9114-46140c3ab410", "AQAAAAEAACcQAAAAEB6BMzGk6lBmPvam4ej6xBFMDybYWV6WwvWHmntkeO8w6+zmVNq27BAJSTTmc+BxPA==", "aa4865eb-837c-4dee-8a1e-e34c7a4ff3ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1c4d75c-3629-4560-8ee4-50f2465804d4", "AQAAAAEAACcQAAAAENuszzHRy3Su3efmHBVL1Smk3p8rR8pYSyUHKVQWtMOPNWBtr5F6bhPSVId8eJRAWw==", "07ee1adc-e65d-427a-b0f5-6fe1a1d37b3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b24f6da6-8699-43c8-a72b-735e6ecb971d", "AQAAAAEAACcQAAAAEJeqkjaMsYLnBgjtPvGl/7EnstKeVEiuDJJQ1HgNJpxtg6zyNyMYSx6SL1FT3v9wTQ==", "e9162e3f-99d0-4c43-aaff-8ad23c790a17" });
        }
    }
}
