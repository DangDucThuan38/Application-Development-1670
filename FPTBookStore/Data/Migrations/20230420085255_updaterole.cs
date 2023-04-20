using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KTBook.Data.Migrations
{
    public partial class updaterole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "1fd35b3f-8b1b-4f10-8567-317437450973");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "ec92b446-7773-46a4-8618-f64a43e5ed4d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "S",
                column: "ConcurrencyStamp",
                value: "583673c9-3c46-4602-9d20-3efc32fffee3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4eca54a-1d1d-4542-9e94-7584b251b391", "AQAAAAEAACcQAAAAELEoMUZfb6EhWPu+c0fj7ykq0xmFH48sUv44PtkwJffusO3/XrBL2xP8hqvuc8U9tg==", "2dbf771c-ac96-477d-976f-296fd06dc6ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c701475-979a-4156-a813-d7f70fb361a6", "AQAAAAEAACcQAAAAED9I7Ihhw2bRNA9RDw6Zom+9vjcR+q9HE3MsPhhorl2q9UeuOVZdBpj4BbH2IZvfSQ==", "d1300726-a4d7-4dfe-97da-12b24b5a8f10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d347d1a7-29c2-493a-a494-26409eab31da", "AQAAAAEAACcQAAAAED8r7JZYWnXCxsd/5HTfXa58JTyknn7Bvm/cE8tmVp8n/OYx0o/+G743us2o/9ANkw==", "62d3704c-fcea-481a-b8cd-4e03bff6dbad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "362d9072-00cc-4d7d-8474-00aacd8cc416", "AQAAAAEAACcQAAAAEIm0l8CmCdo1dumztoOevX//CWi8mOttE3V/pKbmqhTXacrs1drEYzGTZytSmMQtlQ==", "c3a148d0-3630-4ec6-8d34-f70e856023b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bb66525-6f70-4abf-abf0-2e27a458c779", "AQAAAAEAACcQAAAAEBKYjyy9aTHuhz3fLzcB2FYM6/sLLZDfqlYTjfZ4uIxlHdDhJ1QOqovhngAox5NDMA==", "0d02ecfb-2de4-4902-8671-afe121ddd1e3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "cc8304a3-5f84-4704-97b6-307e1417be05");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "5d071379-f6ce-4e0f-bd1f-953cf2ad68e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "S",
                column: "ConcurrencyStamp",
                value: "ffff54a5-cd3b-4918-98a2-e882a5dd9162");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33a0a8db-0424-4468-8143-f829f96b163a", "AQAAAAEAACcQAAAAEGBj+MGwPXKIXt78rQ50a59h2LYtQsSR1nIa+epmihxzWvQb33ZaLogh4VsGY4fq7w==", "85172d57-a59d-4ed0-8d53-5cd372b4889f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33359d18-272a-47ae-8839-34e84ba7a3fa", "AQAAAAEAACcQAAAAELt7f6krBwmTp9Qg65WaOGO8+lMrznj0fVc/87np1NDLphk4o5Livnq1XVJ6a619lA==", "73cfe005-4659-4fcf-85a5-6400f1296e23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a82707c-aa92-480f-b34c-06e38e0f964e", "AQAAAAEAACcQAAAAEBo1YIrRCNHTq6paozPU001Ezgf/XQQc81AAaMDvI/aObTXgglohykVyhKacO13Pgw==", "4b853201-24a7-48d0-8354-71336999cdbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25df9099-6709-42d3-b64e-bad30c7eacdc", "AQAAAAEAACcQAAAAEPNoYBcWLPrWLDdtdbuYDD/2Eo4QrzJcpMaC6mxktoYFETi1gi/DPw2vLqzzPi0A/w==", "45a9b755-1404-476f-a0cf-79c156d33b78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05bea97c-8a11-413b-9d07-a5739d0c6afb", "AQAAAAEAACcQAAAAEKA4jG2T2MGb5Xdxla9lWmQdN8cwVmZR+Zml2HRfv8J6IuIAfkW2ZKRcIZ1JKbR6HQ==", "70806492-fd1d-4a2b-821e-beeda32cc2e7" });
        }
    }
}
