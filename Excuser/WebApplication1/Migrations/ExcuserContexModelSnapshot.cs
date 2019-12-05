﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.DbContext;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ExcuserContex))]
    partial class ExcuserContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Repository.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Work"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Events"
                        },
                        new
                        {
                            Id = 3,
                            Name = "School"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Friends"
                        });
                });

            modelBuilder.Entity("Repository.Model.Excuse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<int>("SubcategoryId");

                    b.Property<int>("Tone");

                    b.HasKey("Id");

                    b.HasIndex("SubcategoryId");

                    b.ToTable("Excuse");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "Hi%name%! It looks like I might be delayed. There is a traffic jam, it seems there are some construction workers on the way. I will be there as soon as this moves!",
                            SubcategoryId = 1,
                            Tone = 1
                        },
                        new
                        {
                            Id = 2,
                            Body = "I apologize for the inconvinience, but I am unable to reach the time we have agreed. There seems to be a traffic jam ahead. I am unsure about how long will it take, but I will do my best to be with you as soon as I can. ",
                            SubcategoryId = 1,
                            Tone = 0
                        },
                        new
                        {
                            Id = 3,
                            Body = "Hey%name%! Sorry I’ll be a little late. I wasn’t expecting this but at home my roomies dog had fun with toilet paper and it is everywhere. I’ll take care of it and then meet you ASAP.",
                            SubcategoryId = 2,
                            Tone = 1
                        },
                        new
                        {
                            Id = 4,
                            Body = "Hello%name%! I apologise for being late. There was an urgent situation at home that need to be dealt with. Thank you for being patient with me and I’ll be there in 15 min.",
                            SubcategoryId = 2,
                            Tone = 0
                        },
                        new
                        {
                            Id = 5,
                            Body = "Hi%name%. I got carried away while watching the Gossip Girls yesterday. My alarm was not strong enough to wake me up, so I will be a little late for our meetup! Hope that's fine, I will pay for the coffee!",
                            SubcategoryId = 2,
                            Tone = 1
                        },
                        new
                        {
                            Id = 6,
                            Body = "Hello%name%! I have to apologize for being late for our meeting. I wasn't feeling well and over slept. I feel much better today, thank you!",
                            SubcategoryId = 2,
                            Tone = 0
                        });
                });

            modelBuilder.Entity("Repository.Model.ExcuseKeyword", b =>
                {
                    b.Property<int>("ExcuseId");

                    b.Property<int>("KeywordId");

                    b.HasKey("ExcuseId", "KeywordId");

                    b.HasIndex("KeywordId");

                    b.ToTable("ExcuseKeyword");

                    b.HasData(
                        new
                        {
                            ExcuseId = 1,
                            KeywordId = 1
                        },
                        new
                        {
                            ExcuseId = 2,
                            KeywordId = 1
                        },
                        new
                        {
                            ExcuseId = 1,
                            KeywordId = 2
                        },
                        new
                        {
                            ExcuseId = 2,
                            KeywordId = 2
                        },
                        new
                        {
                            ExcuseId = 3,
                            KeywordId = 2
                        },
                        new
                        {
                            ExcuseId = 4,
                            KeywordId = 2
                        },
                        new
                        {
                            ExcuseId = 5,
                            KeywordId = 2
                        },
                        new
                        {
                            ExcuseId = 6,
                            KeywordId = 2
                        },
                        new
                        {
                            ExcuseId = 1,
                            KeywordId = 3
                        },
                        new
                        {
                            ExcuseId = 2,
                            KeywordId = 3
                        },
                        new
                        {
                            ExcuseId = 3,
                            KeywordId = 4
                        },
                        new
                        {
                            ExcuseId = 4,
                            KeywordId = 4
                        },
                        new
                        {
                            ExcuseId = 3,
                            KeywordId = 5
                        },
                        new
                        {
                            ExcuseId = 4,
                            KeywordId = 5
                        },
                        new
                        {
                            ExcuseId = 4,
                            KeywordId = 6
                        },
                        new
                        {
                            ExcuseId = 5,
                            KeywordId = 6
                        },
                        new
                        {
                            ExcuseId = 5,
                            KeywordId = 7
                        },
                        new
                        {
                            ExcuseId = 6,
                            KeywordId = 7
                        });
                });

            modelBuilder.Entity("Repository.Model.Keyword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Keyword");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Value = "traffic"
                        },
                        new
                        {
                            Id = 2,
                            Value = "late"
                        },
                        new
                        {
                            Id = 3,
                            Value = "friend"
                        },
                        new
                        {
                            Id = 4,
                            Value = "home"
                        },
                        new
                        {
                            Id = 5,
                            Value = "accident"
                        },
                        new
                        {
                            Id = 6,
                            Value = "movies"
                        },
                        new
                        {
                            Id = 7,
                            Value = "meeting"
                        },
                        new
                        {
                            Id = 8,
                            Value = "car"
                        },
                        new
                        {
                            Id = 9,
                            Value = "malfunction"
                        },
                        new
                        {
                            Id = 10,
                            Value = "party"
                        },
                        new
                        {
                            Id = 11,
                            Value = "studying"
                        },
                        new
                        {
                            Id = 12,
                            Value = "doublebooking"
                        },
                        new
                        {
                            Id = 13,
                            Value = "illness"
                        },
                        new
                        {
                            Id = 14,
                            Value = "virus"
                        },
                        new
                        {
                            Id = 15,
                            Value = "pet"
                        },
                        new
                        {
                            Id = 16,
                            Value = "chill"
                        },
                        new
                        {
                            Id = 17,
                            Value = "sick"
                        },
                        new
                        {
                            Id = 18,
                            Value = "cold"
                        },
                        new
                        {
                            Id = 19,
                            Value = "food"
                        },
                        new
                        {
                            Id = 20,
                            Value = "laundry"
                        },
                        new
                        {
                            Id = 21,
                            Value = "allergy"
                        },
                        new
                        {
                            Id = 22,
                            Value = "pain"
                        },
                        new
                        {
                            Id = 23,
                            Value = "polite"
                        },
                        new
                        {
                            Id = 24,
                            Value = "schedule"
                        },
                        new
                        {
                            Id = 25,
                            Value = "school"
                        },
                        new
                        {
                            Id = 26,
                            Value = "appointment"
                        },
                        new
                        {
                            Id = 27,
                            Value = "work"
                        },
                        new
                        {
                            Id = 28,
                            Value = "sync"
                        },
                        new
                        {
                            Id = 29,
                            Value = "headache"
                        },
                        new
                        {
                            Id = 30,
                            Value = "hangover"
                        },
                        new
                        {
                            Id = 31,
                            Value = "lazy"
                        },
                        new
                        {
                            Id = 32,
                            Value = "season"
                        },
                        new
                        {
                            Id = 33,
                            Value = "depression"
                        },
                        new
                        {
                            Id = 34,
                            Value = "friend"
                        });
                });

            modelBuilder.Entity("Repository.Model.Subcategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 4,
                            Name = "Late for meetup"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 4,
                            Name = "Not attending party"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            Name = "Not coming over "
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            Name = "Doublebooking "
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            Name = "Not feeling like it "
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 4,
                            Name = "Physical "
                        });
                });

            modelBuilder.Entity("Repository.Model.Excuse", b =>
                {
                    b.HasOne("Repository.Model.Subcategory", "Subcategory")
                        .WithMany()
                        .HasForeignKey("SubcategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Repository.Model.ExcuseKeyword", b =>
                {
                    b.HasOne("Repository.Model.Excuse", "Excuse")
                        .WithMany("ExcuseKeywords")
                        .HasForeignKey("ExcuseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Repository.Model.Keyword", "Keyword")
                        .WithMany("ExcuseKeywords")
                        .HasForeignKey("KeywordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Repository.Model.Subcategory", b =>
                {
                    b.HasOne("Repository.Model.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
