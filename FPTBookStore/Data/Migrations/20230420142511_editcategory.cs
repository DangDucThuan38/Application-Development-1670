using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KTBook.Data.Migrations
{
    public partial class editcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_WaitCategory_WaitCategoryId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "WaitCategory");

            migrationBuilder.DropIndex(
                name: "IX_Product_WaitCategoryId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "WaitCategoryId",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "255bde9b-4fa1-4611-96ff-d984c8f35537");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "2a9774c2-3141-434b-acaa-f1d1691155aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "S",
                column: "ConcurrencyStamp",
                value: "5b971da2-7efa-43b5-94c3-d3128057adb6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Image", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdfb9ef3-0877-4011-9696-15f0a76a4593", "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg", "AQAAAAEAACcQAAAAEORLn3lZ/XKGm7bRY4Ulm5pZOgI8BJE93lSgVHhjRFdJDaOKhIklyZfGXdAMURmivw==", "b7fdbdb7-06c8-4be2-bc09-e5f9e5582419" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Image", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76381e05-dea7-49f6-9557-e6e651f7aad6", "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg", "AQAAAAEAACcQAAAAED++ex+kMXm+MmavCXoomU3YRL2pA0B8MN5kz2Q/tvDoir+2xWpEtKmy1OP3QKtgVw==", "e834f277-b643-42e9-ace0-bb197b41ea89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Image", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2525c2d-d18d-4936-b766-a2f4de14383d", "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg", "AQAAAAEAACcQAAAAENRnfnQuicJ3EnQHAVXC1L2+AwJeebAnNjjlh6XqbiGNx1sw+QGdLwBOlcyv40aE1A==", "cd29b8d2-04b8-49ec-b213-9e6c6f909bbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Image", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93ea5355-2eb5-4c02-b12c-e615d3edec98", "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg", "AQAAAAEAACcQAAAAEBf3zW7OAUb1wx56JBsMBZLiYe7K4GvHqDH5V1cUSGfGaf1uokKa3oXHELABaURlJQ==", "0fe153a6-043d-4074-8615-b1cf94e3f985" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "Image", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45f73ccb-ebd7-46fb-936e-ea8a205f4cd3", "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg", "AQAAAAEAACcQAAAAELJx7V7FGtTUkfyNBKKoacYhkHdq3LHivUg+YYYdXO4W8MEHPorlG1Lu9k22kACGPQ==", "ef11881f-a23e-4efb-b74a-b25698c1837d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WaitCategoryId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WaitCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaitCategory", x => x.Id);
                });

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
                columns: new[] { "ConcurrencyStamp", "Image", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4eca54a-1d1d-4542-9e94-7584b251b391", "https://file.hstatic.net/200000122283/article/shin-cau-be-but-chi_4017a723e5df4b7d91524dc0bf656c27_1024x1024.jpg", "AQAAAAEAACcQAAAAELEoMUZfb6EhWPu+c0fj7ykq0xmFH48sUv44PtkwJffusO3/XrBL2xP8hqvuc8U9tg==", "2dbf771c-ac96-477d-976f-296fd06dc6ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Image", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c701475-979a-4156-a813-d7f70fb361a6", "https://file.hstatic.net/200000122283/article/shin-cau-be-but-chi_4017a723e5df4b7d91524dc0bf656c27_1024x1024.jpg", "AQAAAAEAACcQAAAAED9I7Ihhw2bRNA9RDw6Zom+9vjcR+q9HE3MsPhhorl2q9UeuOVZdBpj4BbH2IZvfSQ==", "d1300726-a4d7-4dfe-97da-12b24b5a8f10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Image", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d347d1a7-29c2-493a-a494-26409eab31da", "https://file.hstatic.net/200000122283/article/shin-cau-be-but-chi_4017a723e5df4b7d91524dc0bf656c27_1024x1024.jpg", "AQAAAAEAACcQAAAAED8r7JZYWnXCxsd/5HTfXa58JTyknn7Bvm/cE8tmVp8n/OYx0o/+G743us2o/9ANkw==", "62d3704c-fcea-481a-b8cd-4e03bff6dbad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Image", "PasswordHash", "SecurityStamp" },
                values: new object[] { "362d9072-00cc-4d7d-8474-00aacd8cc416", "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png", "AQAAAAEAACcQAAAAEIm0l8CmCdo1dumztoOevX//CWi8mOttE3V/pKbmqhTXacrs1drEYzGTZytSmMQtlQ==", "c3a148d0-3630-4ec6-8d34-f70e856023b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "Image", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bb66525-6f70-4abf-abf0-2e27a458c779", "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png", "AQAAAAEAACcQAAAAEBKYjyy9aTHuhz3fLzcB2FYM6/sLLZDfqlYTjfZ4uIxlHdDhJ1QOqovhngAox5NDMA==", "0d02ecfb-2de4-4902-8671-afe121ddd1e3" });

            migrationBuilder.CreateIndex(
                name: "IX_Product_WaitCategoryId",
                table: "Product",
                column: "WaitCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_WaitCategory_WaitCategoryId",
                table: "Product",
                column: "WaitCategoryId",
                principalTable: "WaitCategory",
                principalColumn: "Id");
        }
    }
}
