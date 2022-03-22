using Microsoft.EntityFrameworkCore;
using RazorPagesErika.Data;

namespace RazorPagesErika.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new RazorPagesErikaContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesErikaContext>>()))
            {
                if (context == null || context.Book == null) 
                {
                    throw new ArgumentNullException("Null RazorPagesErikaContext");
                }
                if (context.Book.Any())
                {
                    return;
                }
                context.Book.AddRange(
                    new Book
                    {
                        Title = "The Ghost Of You",
                        DatePublished = DateTime.Parse("2022-03-13"),
                        Genre = "Romance",
                        Price = 9.99M
                    },
                    new Book
                    {
                        Title = "Thorns Of Roses",
                        DatePublished = DateTime.Parse("2021-02-23"),
                        Genre = "Romance",
                        Price = 8.99M
                    },
                    new Book
                    {
                        Title = "Jack Master of Masters",
                        DatePublished = DateTime.Parse("2020-01-22"),
                        Genre = "Comedy",
                        Price = 7.99M
                    },
                    new Book
                    {
                        Title = "Run",
                        DatePublished = DateTime.Parse("2019-12-21"),
                        Genre = "Horror",
                        Price = 9.99M
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
