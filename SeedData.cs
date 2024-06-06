using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Crew",
                    ReleaseDate = DateTime.Parse("2024-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Laapta Ladies ",
                    ReleaseDate = DateTime.Parse("2024-3-13"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Uncharted",
                    ReleaseDate = DateTime.Parse("2022-2-23"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Spider man",
                    ReleaseDate = DateTime.Parse("2022-4-15"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Gujjubhai",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic",
                    Rating = "R",
                    Price = 7.99M
                }
            );
            context.SaveChanges();
        }
    }
}