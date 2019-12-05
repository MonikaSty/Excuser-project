﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.DbContext;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ExcuserContex))]
    [Migration("20191205115704_AddingKeywords")]
    partial class AddingKeywords
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                });

            modelBuilder.Entity("Repository.Model.ExcuseKeyword", b =>
                {
                    b.Property<int>("ExcuseId");

                    b.Property<int>("KeywordId");

                    b.HasKey("ExcuseId", "KeywordId");

                    b.HasIndex("KeywordId");

                    b.ToTable("ExcuseKeyword");
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
