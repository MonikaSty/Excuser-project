using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class AddingRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ExcuseKeyword",
                columns: new[] { "ExcuseId", "KeywordId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 5, 6 },
                    { 4, 6 },
                    { 4, 5 },
                    { 3, 5 },
                    { 4, 4 },
                    { 3, 4 },
                    { 2, 3 },
                    { 1, 3 },
                    { 6, 2 },
                    { 5, 2 },
                    { 4, 2 },
                    { 3, 2 },
                    { 2, 2 },
                    { 1, 2 },
                    { 2, 1 },
                    { 5, 7 },
                    { 6, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ExcuseKeyword",
                keyColumns: new[] { "ExcuseId", "KeywordId" },
                keyValues: new object[] { 6, 7 });
        }
    }
}
