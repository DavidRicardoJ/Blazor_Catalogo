using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor_Catalogo.Server.Migrations
{
    public partial class CreateRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab791157-ac75-42e7-9f37-ec6b6cb869e4", "773a98f5-2331-44dd-b019-e731fbbfe3ca", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3346a8fc-ee1c-4f1c-9e6e-a0489e913247", "e099f253-6b36-4138-a435-d05d3ca750b9", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3346a8fc-ee1c-4f1c-9e6e-a0489e913247");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab791157-ac75-42e7-9f37-ec6b6cb869e4");
        }
    }
}
