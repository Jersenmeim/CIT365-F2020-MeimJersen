using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>());
            if (context.Movie.Any())
            {
                return;
            }

            context.Movie.AddRange(
               new Movie
               {
                   Title = "The Saratov Approach",
                   ReleaseDate = DateTime.Parse("2013-10-09"),
                   Genre = new Genre { Details = "Drama Action" },
                   Rating = "PG-13",
                   Price = 9.99M,
                   PhotoPath = "../images/TheSaratovApproach.jpg"

               },

                new Movie
                {

                    Title = "Meet the Mormons",
                    ReleaseDate = DateTime.Parse("2014-10-10"),
                    Genre = new Genre { Details = "Documentary" },
                    Rating = "PG",
                    Price = 9.45M,
                    PhotoPath = "../images/Meet_the_Mormons.jpg"
                },

                new Movie
                {
                    Title = "The R.M.",
                    ReleaseDate = DateTime.Parse("2003-01-31"),
                    Genre = new Genre { Details = "Comedy Religious" },
                    Rating = "G",
                    Price = 8.99M,
                    PhotoPath = "../images/TheRM.jpg"
                },

                new Movie
                {
                    Title = "The Other Side of Heaven",
                    ReleaseDate = DateTime.Parse("2002-04-12"),
                    Genre = new Genre { Details = "Drama Adventure" },
                    Rating = "PG",
                    Price = 14.09M,
                    PhotoPath = "../images/Other_Side_of Heaven.jpg"
                }
            );
            context.SaveChanges();
        }
    }
}