using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.scriptures.Any())
                {
                    return;   // DB has been seeded
                }

                context.scriptures.AddRange(
                    new scriptures
                    {
                        Book = "Moses",
                        DateCreated = DateTime.Parse("2020-10-30"),
                        ChapterSection = 1,
                        Verses = 39,
                        Notes = "Heavenly Fathers Work"
                    },
                    new scriptures
                    {
                        Book = "Nephi",
                        DateCreated = DateTime.Parse("2020-10-28"),
                        ChapterSection = 1,
                        Verses = 1,
                        Notes = "Born of Goodly Parents"
                    },
                    new scriptures
                    {
                        Book = "Doctrine and Covenant",
                        DateCreated = DateTime.Parse("2020-10-25"),
                        ChapterSection = 1,
                        Verses = 37,
                        Notes = "Obedience"
                    },
                    new scriptures
                    {
                        Book = "John",
                        DateCreated = DateTime.Parse("2020-10-26"),
                        ChapterSection = 3,
                        Verses = 16,
                        Notes = "For God so Loved the World"
                    }


                );
                context.SaveChanges();
            }
        }
    }
}
