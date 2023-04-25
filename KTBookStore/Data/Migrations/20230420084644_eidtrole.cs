using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KTBook.Data.Migrations
{
    public partial class eidtrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "O", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "O", "6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "O");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "S", "ffff54a5-cd3b-4918-98a2-e882a5dd9162", "Staff", "Staff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Address", "ConcurrencyStamp", "DoB", "Email", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Hà Nội", "33a0a8db-0424-4468-8143-f829f96b163a", "2000/08/03", "thuanddgch200729@fpt.edu.vn", "Đặng Đức Thuần", "thuanddgch200729@fpt.edu.vn", "AQAAAAEAACcQAAAAEGBj+MGwPXKIXt78rQ50a59h2LYtQsSR1nIa+epmihxzWvQb33ZaLogh4VsGY4fq7w==", "85172d57-a59d-4ed0-8d53-5cd372b4889f", "thuanddgch200729@fpt.edu.vn" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Quảng Ninh", "33359d18-272a-47ae-8839-34e84ba7a3fa", "phamtrungkien@gmail.com", "Phạm Trung Kiên", "phamtrungkien@gmail.com", "AQAAAAEAACcQAAAAELt7f6krBwmTp9Qg65WaOGO8+lMrznj0fVc/87np1NDLphk4o5Livnq1XVJ6a619lA==", "73cfe005-4659-4fcf-85a5-6400f1296e23", "phamtrungkien@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a82707c-aa92-480f-b34c-06e38e0f964e", "Nguyen Van A", "AQAAAAEAACcQAAAAEBo1YIrRCNHTq6paozPU001Ezgf/XQQc81AAaMDvI/aObTXgglohykVyhKacO13Pgw==", "4b853201-24a7-48d0-8354-71336999cdbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Hà Nội", "25df9099-6709-42d3-b64e-bad30c7eacdc", "staff1@gmail.com", "Dang Duc Thuan", "staff1@gmail.com", "AQAAAAEAACcQAAAAEPNoYBcWLPrWLDdtdbuYDD/2Eo4QrzJcpMaC6mxktoYFETi1gi/DPw2vLqzzPi0A/w==", "45a9b755-1404-476f-a0cf-79c156d33b78", "staff1@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Quang Ninh", "05bea97c-8a11-413b-9d07-a5739d0c6afb", "staff2@gmail.com", "Pham Trung Kien", "staff2@gmail.com", "AQAAAAEAACcQAAAAEKA4jG2T2MGb5Xdxla9lWmQdN8cwVmZR+Zml2HRfv8J6IuIAfkW2ZKRcIZ1JKbR6HQ==", "70806492-fd1d-4a2b-821e-beeda32cc2e7", "staff2@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "S", "5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "S", "6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "S", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "S", "6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "S");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "O", "37eb22fa-47ef-443b-b4de-f488a6ef9421", "Owner", "Owner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Address", "ConcurrencyStamp", "DoB", "Email", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Vĩnh Phúc", "37bd59c2-db67-4504-9364-c3d1d7a02bfc", "2000/02/22", "quanghuy01@gmail.com", "Nguyễn Quang Huy", "quanghuy01@gmail.com", "AQAAAAEAACcQAAAAEKVDpQwh/wtnJRZAMRwZZlHMteK9Veom3ouo4dvTwmMszaRA2roe3s8JWo7MDo9MRQ==", "63fef06f-7296-4fc1-aa96-74bd4b818f69", "quanghuy01@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Hà Nội", "c3585138-2a35-4023-b2ca-170ec4651346", "admin@gmail.com", "Văn Minh", "admin@gmail.com", "AQAAAAEAACcQAAAAEEe5DhmaexL/IpXF1O5IHYl/SKDMXar9aP+Ye7uctcCsuVnDJ1ijMG2/8JmS/Un6zQ==", "f2f48d1b-63bd-4ddf-adc1-9d3c09ef3bf6", "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56e35f51-0e51-4ff0-8f82-5f1b4feaf113", "Trần Minh Nghĩa", "AQAAAAEAACcQAAAAEAYiKs45X4oageiO4RaTFXNWLskjPD0ua4b9rINQGYU5tuPpZ+SPCna9CVwP4ilC1w==", "9350ca3c-1cb1-400d-9cdd-3a7ab7a19d88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "New York", "1ef432bc-d65b-4982-8494-045754ec0e96", "owner1@gmail.com", "Tom Holand", "owner1@gmail.com", "AQAAAAEAACcQAAAAECemc7Z0N4/r7qx/m2MKoVLyb67SjIBYDKxJO60NKHwZ2Y0MDEZEzCgjQFSS0PvTZQ==", "92e784f7-6d54-4fb9-94f0-af65fb958fc8", "owner1@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "London", "97154e03-12b4-4a08-b417-39e05174f2fa", "owner2@gmail.com", "Harry Kane", "owner2@gmail.com", "AQAAAAEAACcQAAAAEFaJ7RTi/B5F015tQCwQ3U93aeMwU7SVLH+9Cw1pNq7sb0xeceWAj9KKn6o/8phxWg==", "83797804-4e80-44e1-8973-0d8683cea7fb", "owner2@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FullName", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4", 0, "Hà Nội", "650bbadb-decb-48f0-a616-482471957850", "ApplicationUser", "2002/02/18", "quanghuy67@gmail.com", false, "Quang Huy Nguyễn", "https://www.alotintuc.com/wp-content/uploads/2021/07/Untitled-Capture2244-scaled-e1626766063525.jpg", false, null, null, "quanghuy67@gmail.com", "AQAAAAEAACcQAAAAEAddjpA3klMtsgETps3EiPrq4ZXdMgAXhFz9k12LPA5ouiksL1XArSLUwrc/SuSd9w==", null, false, "2b07fbd8-86e1-43f7-9100-e194495ceb3a", false, "quanghuy67@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "O", "5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "O", "6" });
        }
    }
}
