using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Infrastrcuture.Utils;
using WebApplication1.Models;

namespace WebApplication1.DbContext
{
	public class ExcuserContex : Microsoft.EntityFrameworkCore.DbContext
	{
		public ExcuserContex(DbContextOptions<ExcuserContex> options)
			: base(options)
		{
		}
		public DbSet<Excuse> Excuses { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Subcategory> Subcategories { get; set; }
		public DbSet<Keyword> Keywords { get; set; }
		public DbSet<ExcuseKeyword> ExcuseKeywords { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Excuse>().ToTable("Excuse");
			modelBuilder.Entity<Category>().ToTable("Category");
			modelBuilder.Entity<Subcategory>().ToTable("Subcategory");
			modelBuilder.Entity<Keyword>().ToTable("Keyword");
			modelBuilder.Entity<ExcuseKeyword>().ToTable("ExcuseKeyword");

			modelBuilder.Entity<ExcuseKeyword>().HasKey(sc => new { sc.ExcuseId, sc.KeywordId });

			modelBuilder.Entity<ExcuseKeyword>()
				.HasOne(bc => bc.Excuse)
				.WithMany(b => b.ExcuseKeywords)
				.HasForeignKey(bc => bc.ExcuseId);
			modelBuilder.Entity<ExcuseKeyword>()
				.HasOne(bc => bc.Keyword)
				.WithMany(c => c.ExcuseKeywords)
				.HasForeignKey(bc => bc.KeywordId);

			modelBuilder.Entity<Excuse>().HasKey(sc => new { sc.Id });
			modelBuilder.Entity<Category>().HasKey(sc => new { sc.Id });
			modelBuilder.Entity<Subcategory>().HasKey(sc => new { sc.Id });
			modelBuilder.Entity<Keyword>().HasKey(sc => new { sc.Id });

			modelBuilder.Entity<Subcategory>()
				.Property(p => p.Id)
				.ValueGeneratedOnAdd();
			modelBuilder.Entity<Category>()
				.Property(p => p.Id)
				.ValueGeneratedOnAdd();
			modelBuilder.Entity<Excuse>()
				.Property(p => p.Id)
				.ValueGeneratedOnAdd();
			modelBuilder.Entity<Keyword>()
				.Property(p => p.Id)
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "Work", Subcategories = new List<Subcategory>() },
				new Category { Id = 2, Name = "Events", Subcategories = new List<Subcategory>() },
				new Category { Id = 3, Name = "School", Subcategories = new List<Subcategory>() },
				new Category { Id = 4, Name = "Friends", Subcategories = new List<Subcategory>() });

            //Subcategory for Work
            modelBuilder.Entity<Subcategory>().HasData(
                new Subcategory { Id = 7, Name = "Late for work", CategoryId = 1 },
                new Subcategory { Id = 8, Name = "Physical", CategoryId = 1 },
                new Subcategory { Id = 9, Name = "Family problems", CategoryId = 1 });

            //Subcategory for Events
            modelBuilder.Entity<Subcategory>().HasData(
                new Subcategory { Id = 10, Name = "Lazy", CategoryId = 2 },
                new Subcategory { Id = 11, Name = "Physical", CategoryId = 2 },
                new Subcategory { Id = 12, Name = "Transportation ", CategoryId = 2 });

            //Subcategory for School
            modelBuilder.Entity<Subcategory>().HasData(
                new Subcategory { Id = 13, Name = "Late for class", CategoryId = 3 },
                new Subcategory { Id = 14, Name = "Transportation", CategoryId = 3 },
                new Subcategory { Id = 15, Name = "Working", CategoryId = 3 });

            //Subcategories for friends
            modelBuilder.Entity<Subcategory>().HasData(
				new Subcategory { Id = 1, Name = "Late for meetup", CategoryId = 4 },
				new Subcategory { Id = 2, Name = "Not attending party", CategoryId = 4 },
				new Subcategory { Id = 3, Name = "Not coming over ", CategoryId = 4 },
				new Subcategory { Id = 4, Name = "Doublebooking ", CategoryId = 4 },
				new Subcategory { Id = 5, Name = "Not feeling like it ", CategoryId = 4 },
				new Subcategory { Id = 6, Name = "Physical ", CategoryId = 4 });

			modelBuilder.Entity<ExcuseKeyword>().HasData(
				new ExcuseKeyword
				{
					ExcuseId = 1,
					KeywordId = 1
				}, new ExcuseKeyword
				{
					ExcuseId = 2,
					KeywordId = 1
				}, new ExcuseKeyword
				{
					ExcuseId = 1,
					KeywordId = 2
				}, new ExcuseKeyword
				{
					ExcuseId = 2,
					KeywordId = 2
				}, new ExcuseKeyword
				{
					ExcuseId = 3,
					KeywordId = 2
				}, new ExcuseKeyword
				{
					ExcuseId = 4,
					KeywordId = 2
				}, new ExcuseKeyword
				{
					ExcuseId = 5,
					KeywordId = 2
				}, new ExcuseKeyword
				{
					ExcuseId = 6,
					KeywordId = 2
				}, new ExcuseKeyword
				{
					ExcuseId = 1,
					KeywordId = 3
				}, new ExcuseKeyword
				{
					ExcuseId = 2,
					KeywordId = 3
				}, new ExcuseKeyword
				{
					ExcuseId = 3,
					KeywordId = 4
				}, new ExcuseKeyword
				{
					ExcuseId = 4,
					KeywordId = 4
				}, new ExcuseKeyword
				{
					ExcuseId = 3,
					KeywordId = 5
				}, new ExcuseKeyword
				{
					ExcuseId = 4,
					KeywordId = 5
				}, new ExcuseKeyword
				{
					ExcuseId = 4,
					KeywordId = 6
				}, new ExcuseKeyword
				{
					ExcuseId = 5,
					KeywordId = 6
				}, new ExcuseKeyword
				{
					ExcuseId = 5,
					KeywordId = 7
				}, new ExcuseKeyword
				{
					ExcuseId = 6,
					KeywordId = 7
				},

                //New Addition: 7,8
                new ExcuseKeyword
                {
                    ExcuseId = 7,
                    KeywordId = 8
                }, new ExcuseKeyword
                {
                    ExcuseId = 7,
                    KeywordId = 9
                }, new ExcuseKeyword
                {
                    ExcuseId = 7,
                    KeywordId = 2
                }, new ExcuseKeyword
                {
                    ExcuseId = 8,
                    KeywordId = 8
                }, new ExcuseKeyword
                {
                    ExcuseId = 8,
                    KeywordId = 9
                }, new ExcuseKeyword
                {
                    ExcuseId = 8,
                    KeywordId = 2
                },
                //New Addition: 9,10
                new ExcuseKeyword
                {
                    ExcuseId = 9,
                    KeywordId = 3
                }, new ExcuseKeyword
                {
                    ExcuseId = 9,
                    KeywordId = 10
                }, new ExcuseKeyword
                {
                    ExcuseId = 9,
                    KeywordId = 11
                }, new ExcuseKeyword
                {
                    ExcuseId = 10,
                    KeywordId = 3
                }, new ExcuseKeyword
                {
                    ExcuseId = 10,
                    KeywordId = 10
                }, new ExcuseKeyword
                {
                    ExcuseId = 10,
                    KeywordId = 11
                },
                //New Addition: 11,12
                new ExcuseKeyword
                {
                    ExcuseId = 11,
                    KeywordId = 10
                }, new ExcuseKeyword
                {
                    ExcuseId = 11,
                    KeywordId = 12
                }, new ExcuseKeyword
                {
                    ExcuseId = 11,
                    KeywordId = 3
                }, new ExcuseKeyword
                {
                    ExcuseId = 12,
                    KeywordId = 10
                }, new ExcuseKeyword
                {
                    ExcuseId = 12,
                    KeywordId = 12
                }, new ExcuseKeyword
                {
                    ExcuseId = 12,
                    KeywordId = 3
                },
                //New Addition: 13,14
                new ExcuseKeyword
                {
                    ExcuseId = 13,
                    KeywordId = 10
                }, new ExcuseKeyword
                {
                    ExcuseId = 13,
                    KeywordId = 13
                }, new ExcuseKeyword
                {
                    ExcuseId = 13,
                    KeywordId = 14
                }, new ExcuseKeyword
                {
                    ExcuseId = 14,
                    KeywordId = 10
                }, new ExcuseKeyword
                {
                    ExcuseId = 14,
                    KeywordId = 13
                }, new ExcuseKeyword
                {
                    ExcuseId = 14,
                    KeywordId = 14
                },
                //New Addition: 15,16
                new ExcuseKeyword
                {
                    ExcuseId = 15,
                    KeywordId = 10
                }, new ExcuseKeyword
                {
                    ExcuseId = 15,
                    KeywordId = 3
                }, new ExcuseKeyword
                {
                    ExcuseId = 15,
                    KeywordId = 15
                }, new ExcuseKeyword
                {
                    ExcuseId = 16,
                    KeywordId = 10
                }, new ExcuseKeyword
                {
                    ExcuseId = 16,
                    KeywordId = 3
                }, new ExcuseKeyword
                {
                    ExcuseId = 16,
                    KeywordId = 15
                },
                //New Addition: 17,18
                new ExcuseKeyword
                {
                    ExcuseId = 17,
                    KeywordId = 3
                }, new ExcuseKeyword
                {
                    ExcuseId = 17,
                    KeywordId = 15
                }, new ExcuseKeyword
                {
                    ExcuseId = 17,
                    KeywordId = 10
                }, new ExcuseKeyword
                {
                    ExcuseId = 18,
                    KeywordId = 3
                }, new ExcuseKeyword
                {
                    ExcuseId = 18,
                    KeywordId = 15
                }, new ExcuseKeyword
                {
                    ExcuseId = 18,
                    KeywordId = 10
                },
                //New Addition: 19,20
                new ExcuseKeyword
                {
                    ExcuseId = 19,
                    KeywordId = 16
                }, new ExcuseKeyword
                {
                    ExcuseId = 19,
                    KeywordId = 17
                }, new ExcuseKeyword
                {
                    ExcuseId = 19,
                    KeywordId = 18
                }, new ExcuseKeyword
                {
                    ExcuseId = 20,
                    KeywordId = 16
                }, new ExcuseKeyword
                {
                    ExcuseId = 20,
                    KeywordId = 17
                }, new ExcuseKeyword
                {
                    ExcuseId = 20,
                    KeywordId = 18
                },
                //New Addition: 21,22
                new ExcuseKeyword
                {
                    ExcuseId = 21,
                    KeywordId = 19
                }, new ExcuseKeyword
                {
                    ExcuseId = 21,
                    KeywordId = 20
                }, new ExcuseKeyword
                {
                    ExcuseId = 21,
                    KeywordId = 16
                }, new ExcuseKeyword
                {
                    ExcuseId = 22,
                    KeywordId = 19
                }, new ExcuseKeyword
                {
                    ExcuseId = 22,
                    KeywordId = 20
                }, new ExcuseKeyword
                {
                    ExcuseId = 22,
                    KeywordId = 16
                },
                //New Addition: 23,24
                new ExcuseKeyword
                {
                    ExcuseId = 23,
                    KeywordId = 21
                }, new ExcuseKeyword
                {
                    ExcuseId = 23,
                    KeywordId = 22
                }, new ExcuseKeyword
                {
                    ExcuseId = 23,
                    KeywordId = 17
                }, new ExcuseKeyword
                {
                    ExcuseId = 24,
                    KeywordId = 21
                }, new ExcuseKeyword
                {
                    ExcuseId = 24,
                    KeywordId = 22
                }, new ExcuseKeyword
                {
                    ExcuseId = 24,
                    KeywordId = 17
                },
                //New Addition: 25,26
                new ExcuseKeyword
                {
                    ExcuseId = 25,
                    KeywordId = 12
                }, new ExcuseKeyword
                {
                    ExcuseId = 25,
                    KeywordId = 23
                }, new ExcuseKeyword
                {
                    ExcuseId = 25,
                    KeywordId = 24
                }, new ExcuseKeyword
                {
                    ExcuseId = 26,
                    KeywordId = 12
                }, new ExcuseKeyword
                {
                    ExcuseId = 26,
                    KeywordId = 23
                }, new ExcuseKeyword
                {
                    ExcuseId = 26,
                    KeywordId = 24
                },
                //New Addition: 27,28
                new ExcuseKeyword
                {
                    ExcuseId = 27,
                    KeywordId = 25
                }, new ExcuseKeyword
                {
                    ExcuseId = 27,
                    KeywordId = 26
                }, new ExcuseKeyword
                {
                    ExcuseId = 27,
                    KeywordId = 7
                }, new ExcuseKeyword
                {
                    ExcuseId = 28,
                    KeywordId = 25
                }, new ExcuseKeyword
                {
                    ExcuseId = 28,
                    KeywordId = 26
                }, new ExcuseKeyword
                {
                    ExcuseId = 28,
                    KeywordId = 7
                },
                //New Addition: 29,30
                new ExcuseKeyword
                {
                    ExcuseId = 29,
                    KeywordId = 27
                }, new ExcuseKeyword
                {
                    ExcuseId = 29,
                    KeywordId = 28
                }, new ExcuseKeyword
                {
                    ExcuseId = 29,
                    KeywordId = 7
                }, new ExcuseKeyword
                {
                    ExcuseId = 30,
                    KeywordId = 27
                }, new ExcuseKeyword
                {
                    ExcuseId = 30,
                    KeywordId = 28
                }, new ExcuseKeyword
                {
                    ExcuseId = 30,
                    KeywordId = 7
                },
                //New Addition: 31,32
                new ExcuseKeyword
                {
                    ExcuseId = 31,
                    KeywordId = 3
                }, new ExcuseKeyword
                {
                    ExcuseId = 31,
                    KeywordId = 29
                }, new ExcuseKeyword
                {
                    ExcuseId = 31,
                    KeywordId = 30
                }, new ExcuseKeyword
                {
                    ExcuseId = 32,
                    KeywordId = 3
                }, new ExcuseKeyword
                {
                    ExcuseId = 32,
                    KeywordId = 29
                }, new ExcuseKeyword
                {
                    ExcuseId = 32,
                    KeywordId = 30
                },
                //New Addition: 33,34
                new ExcuseKeyword
                {
                    ExcuseId = 33,
                    KeywordId = 3
                }, new ExcuseKeyword
                {
                    ExcuseId = 33,
                    KeywordId = 10
                }, new ExcuseKeyword
                {
                    ExcuseId = 33,
                    KeywordId = 31
                }, new ExcuseKeyword
                {
                    ExcuseId = 34,
                    KeywordId = 10
                }, new ExcuseKeyword
                {
                    ExcuseId = 34,
                    KeywordId = 3
                }, new ExcuseKeyword
                {
                    ExcuseId = 34,
                    KeywordId = 31
                },
                //New Addition: 35,36
                new ExcuseKeyword
                {
                    ExcuseId = 35,
                    KeywordId = 33
                }, new ExcuseKeyword
                {
                    ExcuseId = 35,
                    KeywordId = 32
                }, new ExcuseKeyword
                {
                    ExcuseId = 35,
                    KeywordId = 34
                }, new ExcuseKeyword
                {
                    ExcuseId = 36,
                    KeywordId = 32
                }, new ExcuseKeyword
                {
                    ExcuseId = 36,
                    KeywordId = 33
                }, new ExcuseKeyword
                {
                    ExcuseId = 36,
                    KeywordId = 34
                },
                //New Addition: 37, 38
                new ExcuseKeyword
                {
                    ExcuseId = 37,
                    KeywordId = 17
                }, new ExcuseKeyword
                {
                    ExcuseId = 37,
                    KeywordId = 30
                }, new ExcuseKeyword
                {
                    ExcuseId = 37,
                    KeywordId = 23
                }, new ExcuseKeyword
                {
                    ExcuseId = 38,
                    KeywordId = 17
                }, new ExcuseKeyword
                {
                    ExcuseId = 38,
                    KeywordId = 30
                }, new ExcuseKeyword
                {
                    ExcuseId = 38,
                    KeywordId = 23
                },
                //New Addition: 39,40
                new ExcuseKeyword
                {
                    ExcuseId = 39,
                    KeywordId = 7
                }, new ExcuseKeyword
                {
                    ExcuseId = 39,
                    KeywordId = 38
                }, new ExcuseKeyword
                {
                    ExcuseId = 39,
                    KeywordId = 39
                }, new ExcuseKeyword
                {
                    ExcuseId = 40,
                    KeywordId = 7
                }, new ExcuseKeyword
                {
                    ExcuseId = 40,
                    KeywordId = 38
                }, new ExcuseKeyword
                {
                    ExcuseId = 40,
                    KeywordId = 39
                },
                //New Addition: 41,42
                new ExcuseKeyword
                {
                    ExcuseId = 41,
                    KeywordId = 39
                }, new ExcuseKeyword
                {
                    ExcuseId = 41,
                    KeywordId = 40
                }, new ExcuseKeyword
                {
                    ExcuseId = 41,
                    KeywordId = 41
                }, new ExcuseKeyword
                {
                    ExcuseId = 42,
                    KeywordId = 39
                }, new ExcuseKeyword
                {
                    ExcuseId = 42,
                    KeywordId = 40
                }, new ExcuseKeyword
                {
                    ExcuseId = 42,
                    KeywordId = 41
                },
                //New Addition: 43,44
                new ExcuseKeyword
                {
                    ExcuseId = 43,
                    KeywordId = 7
                }, new ExcuseKeyword
                {
                    ExcuseId = 43,
                    KeywordId = 17
                }, new ExcuseKeyword
                {
                    ExcuseId = 43,
                    KeywordId = 18
                }, new ExcuseKeyword
                {
                    ExcuseId = 44,
                    KeywordId = 7
                }, new ExcuseKeyword
                {
                    ExcuseId = 44,
                    KeywordId = 17
                }, new ExcuseKeyword
                {
                    ExcuseId = 44,
                    KeywordId = 18
                });


			modelBuilder.Entity<Keyword>().HasData(
				new Keyword
				{
					Id = 1,
					Value = "traffic",
				},
					new Keyword
					{
						Id = 2,
						Value = "late",

					},
					new Keyword
					{
						Id = 3,
						Value = "friend",

					},
					new Keyword
					{
						Id = 4,
						Value = "home",

					},
					new Keyword
					{
						Id = 5,
						Value = "accident",

					},
					new Keyword
					{
						Id = 6,
						Value = "movies",
					},
					new Keyword
					{
						Id = 7,
						Value = "meeting"
					},
					new Keyword { Id = 8, Value = "car" },
					new Keyword { Id = 9, Value = "malfunction" },
					new Keyword { Id = 10, Value = "party" },
					new Keyword { Id = 11, Value = "studying" },
					new Keyword { Id = 12, Value = "doublebooking" },
					new Keyword { Id = 13, Value = "illness" },
					new Keyword { Id = 14, Value = "virus" },
					new Keyword { Id = 15, Value = "pet" },
					new Keyword { Id = 16, Value = "chill" },
					new Keyword { Id = 17, Value = "sick" },
					new Keyword { Id = 18, Value = "cold" },
					new Keyword { Id = 19, Value = "food" },
					new Keyword { Id = 20, Value = "laundry" },
					new Keyword { Id = 21, Value = "allergy" },
					new Keyword { Id = 22, Value = "pain" },
					new Keyword { Id = 23, Value = "polite" },
					new Keyword { Id = 24, Value = "schedule" },
					new Keyword { Id = 25, Value = "school" },
					new Keyword { Id = 26, Value = "appointment" },
					new Keyword { Id = 27, Value = "work" },
					new Keyword { Id = 28, Value = "sync" },
					new Keyword { Id = 29, Value = "headache" },
					new Keyword { Id = 30, Value = "hangover" },
					new Keyword { Id = 31, Value = "lazy" },
					new Keyword { Id = 32, Value = "season" },
					new Keyword { Id = 33, Value = "depression" },
					new Keyword { Id = 34, Value = "friend" });

            //Excuse ID
			modelBuilder.Entity<Excuse>().HasData(
                //Subcategory ID 1
				new Excuse
				{
					Id = 1,
					Body = "Hi%name%! It looks like I might be delayed. There is a traffic jam, it seems there are some construction workers on the way. I will be there as soon as this moves!",
					Tone = Tone.Friendly,
					SubcategoryId = 1
				},
				new Excuse
				{
					Id = 2,
					Body = "I apologize for the inconvinience%name%, but I am unable to reach the time we have agreed. There seems to be a traffic jam ahead. I am unsure about how long will it take, but I will do my best to be with you as soon as I can. ",
					Tone = Tone.Polite,
					SubcategoryId = 1
				}, new Excuse
				{
					Id = 3,
					Body = "Hey%name%! Sorry I’ll be a little late. I wasn’t expecting this but at home my roomies dog had fun with toilet paper and it is everywhere. I’ll take care of it and then meet you ASAP.",
					Tone = Tone.Friendly,
					SubcategoryId = 1
				},
				new Excuse
				{
					Id = 4,
					Body = "Hello%name%! I apologise for being late. There was an urgent situation at home that need to be dealt with. Thank you for being patient with me and I’ll be there in 15 min.",
					Tone = Tone.Polite,
					SubcategoryId = 1
				},
				new Excuse
				{
					Id = 5,
					Body = "Hi%name%. I got carried away while watching the Gossip Girls yesterday. My alarm was not strong enough to wake me up, so I will be a little late for our meetup! Hope that's fine, I will pay for the coffee!",
					Tone = Tone.Friendly,
					SubcategoryId = 1
				}, new Excuse
				{
					Id = 6,
					Body = "Hello%name%! I have to apologize for being late for our meeting. I wasn't feeling well and over slept. I feel much better today, thank you!",
					Tone = Tone.Polite,
					SubcategoryId = 1
				}, 
                // New Additions to sub 1
                new Excuse
                {
                    Id = 7,
                    Body = "Hello%name%. My car broke down and I am trying to fix it. I am sorry for being late.",
                    Tone = Tone.Friendly,
                    SubcategoryId = 1
                }, new Excuse
                {
                    Id = 8,
                    Body = "Hi, I apologize for the inconvinience, but I am late, my car unfortunatelly broke down, I am waiting for the mechanic right now.",
                    Tone = Tone.Polite,
                    SubcategoryId = 1
                },
                //Subcategory Id 2
                new Excuse
                {
                    Id = 9,
                    Body = "Hi%name%! Thank you so much again for the invitation to the party, but I cannot attend. I am buried in books now, we have a deadline in school approaching in the subject I told you about. Thanks for understanding! ",
                    Tone = Tone.Friendly,
                    SubcategoryId = 2
                }, new Excuse
                {
                    Id = 10,
                    Body = "Hi%name%. I do apologize, but I will not be able to attend the party. It seems that the deadline in my school has fallen very close to the date and I will have to spend the time studying. This is very inconvinient and I know this is a last notice, but I cannot underestimate this subject. Thanks you for understanding the situation, I appreacitate that.",
                    Tone = Tone.Polite,
                    SubcategoryId = 2
                }, new Excuse
                {
                    Id = 11,
                    Body = "Hey%name%! Thank you so much for the party invite but I won’t be able to attend. I have signed myself up for a workshop about pottery and wont be back in time. Have fun at the party.",
                    Tone = Tone.Friendly,
                    SubcategoryId = 2
                }, new Excuse
                {
                    Id = 12,
                    Body = "Hey%name%! Unfortunately, I won’t be able to join to the party. A while ago I signed myself up for a whole day workshop and since it is in Copenhagen I won’t make it back in time.",
                    Tone = Tone.Polite,
                    SubcategoryId = 2
                }, new Excuse
                {
                    Id = 13,
                    Body = "Ola%name%! Thanks for having me but I gotta say no, my stomach viruses are basically destroying me from inside, so alcohol would make me no good. *sad emoji* Hope to see you soon! xoxo",
                    Tone = Tone.Friendly,
                    SubcategoryId = 2
                }, new Excuse
                {
                    Id = 14,
                    Body = "Hello%name%. I am very sorry to inform you I am not able to attend your party. I do sincerely thank you for the beautiful invitation, but I got a virus in my body that I need to cure in order to be able to live again. Thank you for your understanding.",
                    Tone = Tone.Polite,
                    SubcategoryId = 2
                }, new Excuse
                {
                    Id = 15,
                    Body = "Hey%name%. I took the red pill my friend, now the dog I was left to take care of is glithing... Not coming to the party by the way... ",
                    Tone = Tone.Friendly,
                    SubcategoryId = 2
                }, new Excuse
                {
                    Id = 16,
                    Body = "Hello%name%. My friend left his dog with me for the day so I won't be able to make it to the party. ",
                    Tone = Tone.Polite,
                    SubcategoryId = 2
                },
                //Subcategory Id 3
                new Excuse
                {
                    Id = 17,
                    Body = "Oh%name%! This is so bad! My dog is throwing up and I cannot leave now, because I am scared it could get worse. I need to find some other day we will meet. ",
                    Tone = Tone.Friendly,
                    SubcategoryId = 3
                }, new Excuse
                {
                    Id = 18,
                    Body = "Hello%name%. I do apologize, but I cannot leave my dog alone at home today, it seems he ate something bad and I might need to take him to the vet later.",
                    Tone = Tone.Polite,
                    SubcategoryId = 3
                }, new Excuse
                {
                    Id = 19,
                    Body = "Hi%name%! I sorry but yesterdays weather murdered me and I ended up catching a cold. So you wouldn’t get sick I think it would be better if I stayed home.",
                    Tone = Tone.Friendly,
                    SubcategoryId = 3
                }, new Excuse
                {
                    Id = 20,
                    Body = "Hey%name%! I apologise but I am unable to come over tonight. I think I caught a cold yesterday and it hasn’t past. I don’t want to infect anyone  so it would be better if I stayed home.",
                    Tone = Tone.Polite,
                    SubcategoryId = 3
                }, new Excuse
                {
                    Id = 21,
                    Body = "Eh%name%, I just made myself some garlic bread and am planning on doing the laundry soon, do you mind if I take a raincheck tonight? Thx",
                    Tone = Tone.Friendly,
                    SubcategoryId = 3
                }, new Excuse
                {
                    Id = 22,
                    Body = "Hi%name%. I feel terribly sorry, but I have to cancel today. There is a stack of house chores that need to be done today. Let's reschedule, maybe next time at my place?",
                    Tone = Tone.Polite,
                    SubcategoryId = 3
                }, new Excuse
                {
                    Id = 23,
                    Body = "Hey%name%. My damn hand is so swollen, it looks like a baloon. All from a tiger mosquito bite, I can't come over mate. ",
                    Tone = Tone.Friendly,
                    SubcategoryId = 3
                }, new Excuse
                {
                    Id = 24,
                    Body = "Hello%name%. I got bit by a tiger mosquito and my arm is incredibly swollen. I am going to my doctor now. I am sorry but I can't come over.",
                    Tone = Tone.Polite,
                    SubcategoryId = 3
                }, 
                // Subcategory Id 4
                new Excuse
                {
                    Id = 25,
                    Body = "Hey%name%! I was looking to the party so much, but I cannot make it after all! It seems there was a mistake in my calendar and it was not updated, and I did not see there is this conference which I signed up for last week. Can we reschedule?",
                    Tone = Tone.Friendly,
                    SubcategoryId = 4
                }, new Excuse
                {
                    Id = 26,
                    Body = "Hello%name%, I am so pleased by the invitation, which I really apprectiate. Regretably I cannot attend, as I would love to, because I am already booked at this date - there si a conference that I have promised I would attend.",
                    Tone = Tone.Polite,
                    SubcategoryId = 4
                }, new Excuse
                {
                    Id = 27,
                    Body = "Hey%name%! I forgot that I need to go to school, so today won’t work for meeting up.I hope you aren’t annoyed.See you tomrorrow?",
                    Tone = Tone.Friendly,
                    SubcategoryId = 4
                }, new Excuse
                {
                    Id = 28,
                    Body = "Hello%name%. Unfortunately I won’t be able to meet up. I forgot that I have an appointment at school which I need to attend. I hope it wasn’t a big inconvenience. Thanks for being understanding and see you tomorrow!",
                    Tone = Tone.Polite,
                    SubcategoryId = 4
                }, new Excuse
                {
                    Id = 29,
                    Body = "Gosh%name%, I am so retarded. I am keeping two calendars and I forgot to sync my other meetings. There is unfortunately a work meeting with a potential client, that I have to attend, so yeah. Fun stuff... hopefully next time?",
                    Tone = Tone.Friendly,
                    SubcategoryId = 4
                }, new Excuse
                {
                    Id = 30,
                    Body = "Hello%name%, unfortunately, I made an error in booking my meetings and I have another meeting at that time that I just have to attend. I would like to reschedule and offer you some more of our services for free. Thank you for being understanding and talk to you soon.",
                    Tone = Tone.Polite,
                    SubcategoryId = 4
                }, 
                //Subcategory Id 5
                new Excuse
                {
                    Id = 31,
                    Body = "I am sorry%name%, but I have had a migrena the whole day from the morning. I would love to reschedule, can we please get in touch when I am feeling better?",
                    Tone = Tone.Friendly,
                    SubcategoryId = 5
                }, new Excuse
                {
                    Id = 32,
                    Body = "Hello%name%, I was looking forward to meeting you, but unfortunatelly, I cannot come today due to enduring headache. I tried to take a headache pill, but it did not relieve my pain. I will be in touch about rescheduling our appointment. ",
                    Tone = Tone.Polite,
                    SubcategoryId = 5
                }, new Excuse
                {
                    Id = 33,
                    Body = "Heya%name%! I won’t join you tonight with the party fun. I have had an insane week and I need to do nothing tonight. Say hi to the others from me though!",
                    Tone = Tone.Friendly,
                    SubcategoryId = 5
                }, new Excuse
                {
                    Id = 34,
                    Body = "I am sorry%name%, I know we were supposed to go out together tonight but I really don’t feel like doing anything. I need some time to myself tonight after this stressful week.",
                    Tone = Tone.Polite,
                    SubcategoryId = 5
                }, new Excuse
                {
                    Id = 35,
                    Body = "Hey%name%, today is just a weird day and the weather got me really hard. Hope you won't mind me staying home and trying to fight with this season depression. I wouldn't be a great asset to your chill evening. Hope you understand... xoxo",
                    Tone = Tone.Friendly,
                    SubcategoryId = 5
                }, new Excuse
                {
                    Id = 36,
                    Body = "Hi%name%. I have to unfortunately skip today. I don't feel personally very well and I don't want to disrupt your cozy evening. I wish to meet some other time soon!",
                    Tone = Tone.Polite,
                    SubcategoryId = 5
                }, 
                //Subcategory Id 6
                new Excuse
                {
                    Id = 37,
                    Body = "Hi%name%! I am so sorry, but I cannot come to the party. I got a horrible headache and I am throwing up, it does not look like it is getting better anytime soon!",
                    Tone = Tone.Friendly,
                    SubcategoryId = 6
                }, new Excuse
                {
                    Id = 38,
                    Body = "Hello%name%. I do apologize for the inconviniance, but I will not be able to attend after all. I am experiencing a physical discomfort in my stomach and I know I could not be my full self on the party.",
                    Tone = Tone.Polite,
                    SubcategoryId = 6
                }, new Excuse
                {
                    Id = 39,
                    Body = "Hey%name%, I know we were supposed to meet up but I went to the gym yesterday. and I am so sore I can’t move out of bed even. I would prefer to meet in the evening, can we do that?",
                    Tone = Tone.Friendly,
                    SubcategoryId = 6
                }, new Excuse
                {
                    Id = 40,
                    Body = "Hi%name%, I am sorry but I won’t make it to our meet-up in the morning. I went overboard in the gym and I need some recovery time. Do you mind if we postpone out meet-up to the morning?",
                    Tone = Tone.Polite,
                    SubcategoryId = 6
                }, new Excuse
                {
                    Id = 41,
                    Body = "Hey%name%, I cannot come to our training today, because of a fracture of my bones. Could you tell the trainer I will write him later after I get better? Thanks!",
                    SubcategoryId = 6
                }, new Excuse
                {
                    Id = 42,
                    Body = "Hi%name%, I cannot come to this or few next trainings. I fractured some bones, at the moment I am still waiting for the results. I will let you know of my status as soon as possible. Thank you for understanding!",
                    Tone = Tone.Polite,
                    SubcategoryId = 6
                }, new Excuse
                {
                    Id = 43,
                    Body = "Hi %name%! I believe I am so sorry, but I got cold from the weather. I will not be able to meet up today. I will text you later about some other plans we can do together. ",
                    Tone = Tone.Friendly,
                    SubcategoryId = 6
                }, new Excuse
                {
                    Id = 44,
                    Body = "Hi%name%, winter weather incredibly sick and I am unable to move my body without shivering or feeling pain. I am sorry but I can't make it to the reunion.",
                    Tone = Tone.Polite,
                    SubcategoryId = 6
                });
		}
	}
}