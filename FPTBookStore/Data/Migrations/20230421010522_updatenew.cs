using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KTBook.Data.Migrations
{
    public partial class updatenew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "2dcf53f7-113a-4858-97b8-3c62a3f7e425");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "83f3088c-7d33-4a09-b3b2-60d71103a7af");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "S",
                column: "ConcurrencyStamp",
                value: "9f284ad5-a328-4a0f-917c-9773769dd075");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "685ce752-542e-4106-9fab-ed874f602fcb", "AQAAAAEAACcQAAAAEFYFlE2+FS65oiPJb06qHoRdmcEg1jBRweFatyuxDAWGtpIOcSmKp+lZRj1uLuEYeA==", "4b21c59b-dd73-462d-9dd8-371aa1e0c880" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5229c893-bb68-4496-937f-f9d17a118f2a", "AQAAAAEAACcQAAAAEFaeLMq08f6NjI2kbYz53jRfslRQZnO2s5qDM6bEoG3DqrEC56KWVIPVcmYeAee4/Q==", "aa5628d6-7f8b-4d0c-bfa1-bb08f984f4b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1652b395-0957-484e-be73-814445ce498f", "AQAAAAEAACcQAAAAEHURp7uhqSJpQPQAX7tOmL/VXVzW8LBWsVj6sx5WESJsna+WMnK+NkTNv7mS3ZuP5Q==", "e9534fe3-cb2d-4fed-850d-497240842d2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37d3d7bc-d12a-4c14-a80b-ff23d4d62c8c", "AQAAAAEAACcQAAAAEOzrLbRjm8boegrw1SL7MQ0G5CCxM19BRnlDtlAm+pp7xeiQ2Yvp7n+Dhd/QU9nMvg==", "59deab5d-ade2-434f-8694-04687c75e419" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf4e71eb-a999-4f54-85d8-5535eed94919", "AQAAAAEAACcQAAAAEGRkN1h8PbhMgJSLjw5Ejf9jKySxDjlI03C/aVbzoFV51CFKF72VD4sMCt1324fxNA==", "1eeb825a-ca17-4d9f-9e0d-f16bbba767f5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdfb9ef3-0877-4011-9696-15f0a76a4593", "AQAAAAEAACcQAAAAEORLn3lZ/XKGm7bRY4Ulm5pZOgI8BJE93lSgVHhjRFdJDaOKhIklyZfGXdAMURmivw==", "b7fdbdb7-06c8-4be2-bc09-e5f9e5582419" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76381e05-dea7-49f6-9557-e6e651f7aad6", "AQAAAAEAACcQAAAAED++ex+kMXm+MmavCXoomU3YRL2pA0B8MN5kz2Q/tvDoir+2xWpEtKmy1OP3QKtgVw==", "e834f277-b643-42e9-ace0-bb197b41ea89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2525c2d-d18d-4936-b766-a2f4de14383d", "AQAAAAEAACcQAAAAENRnfnQuicJ3EnQHAVXC1L2+AwJeebAnNjjlh6XqbiGNx1sw+QGdLwBOlcyv40aE1A==", "cd29b8d2-04b8-49ec-b213-9e6c6f909bbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93ea5355-2eb5-4c02-b12c-e615d3edec98", "AQAAAAEAACcQAAAAEBf3zW7OAUb1wx56JBsMBZLiYe7K4GvHqDH5V1cUSGfGaf1uokKa3oXHELABaURlJQ==", "0fe153a6-043d-4074-8615-b1cf94e3f985" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45f73ccb-ebd7-46fb-936e-ea8a205f4cd3", "AQAAAAEAACcQAAAAELJx7V7FGtTUkfyNBKKoacYhkHdq3LHivUg+YYYdXO4W8MEHPorlG1Lu9k22kACGPQ==", "ef11881f-a23e-4efb-b74a-b25698c1837d" });
        }
    }
}
