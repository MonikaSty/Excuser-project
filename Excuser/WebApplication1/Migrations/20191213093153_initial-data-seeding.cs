using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class initialdataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keyword",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyword", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subcategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subcategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Excuse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(nullable: true),
                    Tone = table.Column<int>(nullable: false),
                    SubcategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Excuse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Excuse_Subcategory_SubcategoryId",
                        column: x => x.SubcategoryId,
                        principalTable: "Subcategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExcuseKeyword",
                columns: table => new
                {
                    ExcuseId = table.Column<int>(nullable: false),
                    KeywordId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcuseKeyword", x => new { x.ExcuseId, x.KeywordId });
                    table.ForeignKey(
                        name: "FK_ExcuseKeyword_Excuse_ExcuseId",
                        column: x => x.ExcuseId,
                        principalTable: "Excuse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExcuseKeyword_Keyword_KeywordId",
                        column: x => x.KeywordId,
                        principalTable: "Keyword",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Work" },
                    { 2, "Events" },
                    { 3, "School" },
                    { 4, "Friends" }
                });

            migrationBuilder.InsertData(
                table: "Keyword",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { 19, "food" },
                    { 20, "laundry" },
                    { 21, "allergy" },
                    { 22, "pain" },
                    { 23, "polite" },
                    { 24, "schedule" },
                    { 25, "school" },
                    { 27, "work" },
                    { 18, "cold" },
                    { 28, "sync" },
                    { 29, "headache" },
                    { 30, "hangover" },
                    { 31, "lazy" },
                    { 32, "season" },
                    { 26, "appointment" },
                    { 17, "sick" },
                    { 15, "pet" },
                    { 33, "depression" },
                    { 1, "traffic" },
                    { 2, "late" },
                    { 3, "friend" },
                    { 4, "home" },
                    { 5, "accident" },
                    { 6, "movies" },
                    { 16, "chill" },
                    { 7, "meeting" },
                    { 9, "malfunction" },
                    { 10, "party" },
                    { 11, "studying" },
                    { 12, "doublebooking" },
                    { 13, "illness" },
                    { 14, "virus" },
                    { 8, "car" },
                    { 34, "friend" }
                });

            migrationBuilder.InsertData(
                table: "Subcategory",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 7, 1, "Late for work" },
                    { 8, 1, "Physical" },
                    { 9, 1, "Family problems" },
                    { 10, 2, "Lazy" },
                    { 11, 2, "Physical" },
                    { 12, 2, "Transportation " },
                    { 13, 3, "Late for class" },
                    { 14, 3, "Transportation" },
                    { 15, 3, "Working" },
                    { 1, 4, "Late for meetup" },
                    { 2, 4, "Not attending party" },
                    { 3, 4, "Not coming over " },
                    { 4, 4, "Doublebooking " },
                    { 5, 4, "Not feeling like it " },
                    { 6, 4, "Physical " }
                });

            migrationBuilder.InsertData(
                table: "Excuse",
                columns: new[] { "Id", "Body", "SubcategoryId", "Tone" },
                values: new object[,]
                {
                    { 1, "Hi%name%! It looks like I might be delayed. There is a traffic jam, it seems there are some construction workers on the way. I will be there as soon as this moves!", 1, 1 },
                    { 25, "Hey%name%! I was looking to the party so much, but I cannot make it after all! It seems there was a mistake in my calendar and it was not updated, and I did not see there is this conference which I signed up for last week. Can we reschedule?", 4, 1 },
                    { 26, "Hello%name%, I am so pleased by the invitation, which I really apprectiate. Regretably I cannot attend, as I would love to, because I am already booked at this date - there si a conference that I have promised I would attend.", 4, 0 },
                    { 27, "Hey%name%! I forgot that I need to go to school, so today won’t work for meeting up.I hope you aren’t annoyed.See you tomrorrow?", 4, 1 },
                    { 28, "Hello%name%. Unfortunately I won’t be able to meet up. I forgot that I have an appointment at school which I need to attend. I hope it wasn’t a big inconvenience. Thanks for being understanding and see you tomorrow!", 4, 0 },
                    { 29, "Gosh%name%, I am so retarded. I am keeping two calendars and I forgot to sync my other meetings. There is unfortunately a work meeting with a potential client, that I have to attend, so yeah. Fun stuff... hopefully next time?", 4, 1 },
                    { 30, "Hello%name%, unfortunately, I made an error in booking my meetings and I have another meeting at that time that I just have to attend. I would like to reschedule and offer you some more of our services for free. Thank you for being understanding and talk to you soon.", 4, 0 },
                    { 31, "I am sorry%name%, but I have had a migrena the whole day from the morning. I would love to reschedule, can we please get in touch when I am feeling better?", 5, 1 },
                    { 32, "Hello%name%, I was looking forward to meeting you, but unfortunatelly, I cannot come today due to enduring headache. I tried to take a headache pill, but it did not relieve my pain. I will be in touch about rescheduling our appointment. ", 5, 0 },
                    { 24, "Hello%name%. I got bit by a tiger mosquito and my arm is incredibly swollen. I am going to my doctor now. I am sorry but I can't come over.", 3, 0 },
                    { 33, "Heya%name%! I won’t join you tonight with the party fun. I have had an insane week and I need to do nothing tonight. Say hi to the others from me though!", 5, 1 },
                    { 35, "Hey%name%, today is just a weird day and the weather got me really hard. Hope you won't mind me staying home and trying to fight with this season depression. I wouldn't be a great asset to your chill evening. Hope you understand... xoxo", 5, 1 },
                    { 36, "Hi%name%. I have to unfortunately skip today. I don't feel personally very well and I don't want to disrupt your cozy evening. I wish to meet some other time soon!", 5, 0 },
                    { 37, "Hi%name%! I am so sorry, but I cannot come to the party. I got a horrible headache and I am throwing up, it does not look like it is getting better anytime soon!", 6, 1 },
                    { 38, "Hello%name%. I do apologize for the inconviniance, but I will not be able to attend after all. I am experiencing a physical discomfort in my stomach and I know I could not be my full self on the party.", 6, 0 },
                    { 39, "Hey%name%, I know we were supposed to meet up but I went to the gym yesterday. and I am so sore I can’t move out of bed even. I would prefer to meet in the evening, can we do that?", 6, 1 },
                    { 40, "Hi%name%, I am sorry but I won’t make it to our meet-up in the morning. I went overboard in the gym and I need some recovery time. Do you mind if we postpone out meet-up to the morning?", 6, 0 },
                    { 41, "Hey%name%, I cannot come to our training today, because of a fracture of my bones. Could you tell the trainer I will write him later after I get better? Thanks!", 6, 0 },
                    { 42, "Hi%name%, I cannot come to this or few next trainings. I fractured some bones, at the moment I am still waiting for the results. I will let you know of my status as soon as possible. Thank you for understanding!", 6, 0 },
                    { 34, "I am sorry%name%, I know we were supposed to go out together tonight but I really don’t feel like doing anything. I need some time to myself tonight after this stressful week.", 5, 0 },
                    { 23, "Hey%name%. My damn hand is so swollen, it looks like a baloon. All from a tiger mosquito bite, I can't come over mate. ", 3, 1 },
                    { 22, "Hi%name%. I feel terribly sorry, but I have to cancel today. There is a stack of house chores that need to be done today. Let's reschedule, maybe next time at my place?", 3, 0 },
                    { 21, "Eh%name%, I just made myself some garlic bread and am planning on doing the laundry soon, do you mind if I take a raincheck tonight? Thx", 3, 1 },
                    { 2, "I apologize for the inconvinience%name%, but I am unable to reach the time we have agreed. There seems to be a traffic jam ahead. I am unsure about how long will it take, but I will do my best to be with you as soon as I can. ", 1, 0 },
                    { 3, "Hey%name%! Sorry I’ll be a little late. I wasn’t expecting this but at home my roomies dog had fun with toilet paper and it is everywhere. I’ll take care of it and then meet you ASAP.", 1, 1 },
                    { 4, "Hello%name%! I apologise for being late. There was an urgent situation at home that need to be dealt with. Thank you for being patient with me and I’ll be there in 15 min.", 1, 0 },
                    { 5, "Hi%name%. I got carried away while watching the Gossip Girls yesterday. My alarm was not strong enough to wake me up, so I will be a little late for our meetup! Hope that's fine, I will pay for the coffee!", 1, 1 },
                    { 6, "Hello%name%! I have to apologize for being late for our meeting. I wasn't feeling well and over slept. I feel much better today, thank you!", 1, 0 },
                    { 7, "Hello%name%. My car broke down and I am trying to fix it. I am sorry for being late.", 1, 1 },
                    { 8, "Hi, I apologize for the inconvinience, but I am late, my car unfortunatelly broke down, I am waiting for the mechanic right now.", 1, 0 },
                    { 9, "Hi%name%! Thank you so much again for the invitation to the party, but I cannot attend. I am buried in books now, we have a deadline in school approaching in the subject I told you about. Thanks for understanding! ", 2, 1 },
                    { 10, "Hi%name%. I do apologize, but I will not be able to attend the party. It seems that the deadline in my school has fallen very close to the date and I will have to spend the time studying. This is very inconvinient and I know this is a last notice, but I cannot underestimate this subject. Thanks you for understanding the situation, I appreacitate that.", 2, 0 },
                    { 11, "Hey%name%! Thank you so much for the party invite but I won’t be able to attend. I have signed myself up for a workshop about pottery and wont be back in time. Have fun at the party.", 2, 1 },
                    { 12, "Hey%name%! Unfortunately, I won’t be able to join to the party. A while ago I signed myself up for a whole day workshop and since it is in Copenhagen I won’t make it back in time.", 2, 0 },
                    { 13, "Ola%name%! Thanks for having me but I gotta say no, my stomach viruses are basically destroying me from inside, so alcohol would make me no good. *sad emoji* Hope to see you soon! xoxo", 2, 1 },
                    { 14, "Hello%name%. I am very sorry to inform you I am not able to attend your party. I do sincerely thank you for the beautiful invitation, but I got a virus in my body that I need to cure in order to be able to live again. Thank you for your understanding.", 2, 0 },
                    { 15, "Hey%name%. I took the red pill my friend, now the dog I was left to take care of is glithing... Not coming to the party by the way... ", 2, 1 },
                    { 16, "Hello%name%. My friend left his dog with me for the day so I won't be able to make it to the party. ", 2, 0 },
                    { 17, "Oh%name%! This is so bad! My dog is throwing up and I cannot leave now, because I am scared it could get worse. I need to find some other day we will meet. ", 3, 1 },
                    { 18, "Hello%name%. I do apologize, but I cannot leave my dog alone at home today, it seems he ate something bad and I might need to take him to the vet later.", 3, 0 },
                    { 19, "Hi%name%! I sorry but yesterdays weather murdered me and I ended up catching a cold. So you wouldn’t get sick I think it would be better if I stayed home.", 3, 1 },
                    { 20, "Hey%name%! I apologise but I am unable to come over tonight. I think I caught a cold yesterday and it hasn’t past. I don’t want to infect anyone  so it would be better if I stayed home.", 3, 0 },
                    { 43, "Hi %name%! I believe I am so sorry, but I got cold from the weather. I will not be able to meet up today. I will text you later about some other plans we can do together. ", 6, 1 },
                    { 44, "Hi%name%, winter weather incredibly sick and I am unable to move my body without shivering or feeling pain. I am sorry but I can't make it to the reunion.", 6, 0 }
                });

            migrationBuilder.InsertData(
                table: "ExcuseKeyword",
                columns: new[] { "ExcuseId", "KeywordId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 33, 3 },
                    { 32, 30 },
                    { 32, 29 },
                    { 32, 3 },
                    { 31, 30 },
                    { 31, 29 },
                    { 31, 3 },
                    { 30, 7 },
                    { 30, 28 },
                    { 30, 27 },
                    { 29, 7 },
                    { 29, 28 },
                    { 29, 27 },
                    { 28, 7 },
                    { 28, 26 },
                    { 28, 25 },
                    { 27, 7 },
                    { 27, 26 },
                    { 27, 25 },
                    { 26, 24 },
                    { 26, 23 },
                    { 26, 12 },
                    { 25, 24 },
                    { 25, 23 },
                    { 25, 12 },
                    { 24, 17 },
                    { 24, 22 },
                    { 24, 21 },
                    { 23, 17 },
                    { 33, 10 },
                    { 23, 22 },
                    { 33, 31 },
                    { 34, 3 },
                    { 44, 7 },
                    { 43, 18 },
                    { 43, 17 },
                    { 43, 7 },
                    { 42, 5 },
                    { 42, 17 },
                    { 42, 22 },
                    { 41, 5 },
                    { 41, 17 },
                    { 41, 22 },
                    { 40, 31 },
                    { 40, 34 },
                    { 40, 7 },
                    { 39, 31 },
                    { 39, 34 },
                    { 39, 7 },
                    { 38, 23 },
                    { 38, 30 },
                    { 38, 17 },
                    { 37, 23 },
                    { 37, 30 },
                    { 37, 17 },
                    { 36, 34 },
                    { 36, 33 },
                    { 36, 32 },
                    { 35, 34 },
                    { 35, 32 },
                    { 35, 33 },
                    { 34, 31 },
                    { 34, 10 },
                    { 23, 21 },
                    { 22, 16 },
                    { 22, 20 },
                    { 10, 11 },
                    { 10, 10 },
                    { 10, 3 },
                    { 9, 11 },
                    { 9, 10 },
                    { 9, 3 },
                    { 8, 2 },
                    { 8, 9 },
                    { 8, 8 },
                    { 7, 2 },
                    { 7, 9 },
                    { 7, 8 },
                    { 6, 7 },
                    { 6, 2 },
                    { 5, 7 },
                    { 5, 6 },
                    { 5, 2 },
                    { 4, 6 },
                    { 4, 5 },
                    { 4, 4 },
                    { 4, 2 },
                    { 3, 5 },
                    { 3, 4 },
                    { 3, 2 },
                    { 2, 3 },
                    { 2, 2 },
                    { 2, 1 },
                    { 1, 3 },
                    { 1, 2 },
                    { 11, 10 },
                    { 11, 12 },
                    { 11, 3 },
                    { 12, 10 },
                    { 22, 19 },
                    { 21, 16 },
                    { 21, 20 },
                    { 21, 19 },
                    { 20, 18 },
                    { 20, 17 },
                    { 20, 16 },
                    { 19, 18 },
                    { 19, 17 },
                    { 19, 16 },
                    { 18, 10 },
                    { 18, 15 },
                    { 18, 3 },
                    { 17, 10 },
                    { 44, 17 },
                    { 17, 15 },
                    { 16, 15 },
                    { 16, 3 },
                    { 16, 10 },
                    { 15, 15 },
                    { 15, 3 },
                    { 15, 10 },
                    { 14, 14 },
                    { 14, 13 },
                    { 14, 10 },
                    { 13, 14 },
                    { 13, 13 },
                    { 13, 10 },
                    { 12, 3 },
                    { 12, 12 },
                    { 17, 3 },
                    { 44, 18 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Excuse_SubcategoryId",
                table: "Excuse",
                column: "SubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ExcuseKeyword_KeywordId",
                table: "ExcuseKeyword",
                column: "KeywordId");

            migrationBuilder.CreateIndex(
                name: "IX_Subcategory_CategoryId",
                table: "Subcategory",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExcuseKeyword");

            migrationBuilder.DropTable(
                name: "Excuse");

            migrationBuilder.DropTable(
                name: "Keyword");

            migrationBuilder.DropTable(
                name: "Subcategory");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
