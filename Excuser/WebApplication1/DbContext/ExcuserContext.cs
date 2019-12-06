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
				}
			);


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

			modelBuilder.Entity<Excuse>().HasData(
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
					Body = "I apologize for the inconvinience, but I am unable to reach the time we have agreed. There seems to be a traffic jam ahead. I am unsure about how long will it take, but I will do my best to be with you as soon as I can. ",
					Tone = Tone.Polite,
					SubcategoryId = 1
				}, new Excuse
				{
					Id = 3,
					Body = "Hey%name%! Sorry I’ll be a little late. I wasn’t expecting this but at home my roomies dog had fun with toilet paper and it is everywhere. I’ll take care of it and then meet you ASAP.",
					Tone = Tone.Friendly,
					SubcategoryId = 2
				},
				new Excuse
				{
					Id = 4,
					Body = "Hello%name%! I apologise for being late. There was an urgent situation at home that need to be dealt with. Thank you for being patient with me and I’ll be there in 15 min.",
					Tone = Tone.Polite,
					SubcategoryId = 2
				},
				new Excuse
				{
					Id = 5,
					Body = "Hi%name%. I got carried away while watching the Gossip Girls yesterday. My alarm was not strong enough to wake me up, so I will be a little late for our meetup! Hope that's fine, I will pay for the coffee!",
					Tone = Tone.Friendly,
					SubcategoryId = 2
				}, new Excuse
				{
					Id = 6,
					Body = "Hello%name%! I have to apologize for being late for our meeting. I wasn't feeling well and over slept. I feel much better today, thank you!",
					Tone = Tone.Polite,
					SubcategoryId = 2
				});

		}
	}
}