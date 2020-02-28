using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        BookName = "Nephi",
                        DateAdded = DateTime.Parse("1989-2-12"),
                        Chapter = 5,
                        Verse = 8
                    },

                    new Book
                    {
                        BookName = "Nephi 2",
                        DateAdded = DateTime.Parse("1989-2-12"),
                        Chapter = 3,
                        Verse = 12
                    }
                );
                context.SaveChanges();
            }
        }
    }
}