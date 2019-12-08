using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class CorrectingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubcategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "SubcategoryId" },
                values: new object[] { "I apologize for the inconvinience%name%, but I am unable to reach the time we have agreed. There seems to be a traffic jam ahead. I am unsure about how long will it take, but I will do my best to be with you as soon as I can. ", 4 });

            migrationBuilder.UpdateData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubcategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubcategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubcategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 6,
                column: "SubcategoryId",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubcategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "SubcategoryId" },
                values: new object[] { "I apologize for the inconvinience, but I am unable to reach the time we have agreed. There seems to be a traffic jam ahead. I am unsure about how long will it take, but I will do my best to be with you as soon as I can. ", 1 });

            migrationBuilder.UpdateData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubcategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubcategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubcategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 6,
                column: "SubcategoryId",
                value: 2);
        }
    }
}
