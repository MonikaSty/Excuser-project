using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class AddingExcuse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Excuse",
                columns: new[] { "Id", "Body", "SubcategoryId", "Tone" },
                values: new object[,]
                {
                    { 1, "Hi%name%! It looks like I might be delayed. There is a traffic jam, it seems there are some construction workers on the way. I will be there as soon as this moves!", 1, 1 },
                    { 2, "I apologize for the inconvinience, but I am unable to reach the time we have agreed. There seems to be a traffic jam ahead. I am unsure about how long will it take, but I will do my best to be with you as soon as I can. ", 1, 0 },
                    { 3, "Hey%name%! Sorry I’ll be a little late. I wasn’t expecting this but at home my roomies dog had fun with toilet paper and it is everywhere. I’ll take care of it and then meet you ASAP.", 2, 1 },
                    { 4, "Hello%name%! I apologise for being late. There was an urgent situation at home that need to be dealt with. Thank you for being patient with me and I’ll be there in 15 min.", 2, 0 },
                    { 5, "Hi%name%. I got carried away while watching the Gossip Girls yesterday. My alarm was not strong enough to wake me up, so I will be a little late for our meetup! Hope that's fine, I will pay for the coffee!", 2, 1 },
                    { 6, "Hello%name%! I have to apologize for being late for our meeting. I wasn't feeling well and over slept. I feel much better today, thank you!", 2, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Excuse",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
