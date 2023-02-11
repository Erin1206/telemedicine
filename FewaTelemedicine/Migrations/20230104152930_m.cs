using Microsoft.EntityFrameworkCore.Migrations;

namespace FewaTelemedicine.Migrations
{
    public partial class m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "providerId",
                keyValue: 1,
                column: "roomName",
                value: "db2aa4fb-1ab3-40aa-aa84-6e68df115014-name");

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "providerId",
                keyValue: 2,
                column: "roomName",
                value: "9b8b5023-261d-4008-bae0-e60022a3d82a-name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "providerId",
                keyValue: 1,
                column: "roomName",
                value: "aab0ad23-0ea5-442a-bff8-a554ce9cc487-name");

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "providerId",
                keyValue: 2,
                column: "roomName",
                value: "4f65c67e-470e-47f0-a50b-23a1444d79cc-name");
        }
    }
}
