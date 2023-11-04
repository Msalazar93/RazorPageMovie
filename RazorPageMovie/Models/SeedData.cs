using Microsoft.EntityFrameworkCore;
using RazorPageMovie.Data;


namespace RazorPageMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPageMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPageMovieContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                if (context.Movie.Any())
                {
                    //Base de datos muestra todo lo que contiene la clase
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Meet Sally", 
                        RealeseDate = DateTime.Parse("1989-02-12") ,
                        Genre = "Romantic Comedy",
                        Price = 7.99M, 
                        Rating = "R"
                    },

                     new Movie
                     {
                         Title = "Ghostbuster",
                         RealeseDate = DateTime.Parse("1984-3-13"),
                         Genre = "Comedy",
                         Price = 8.99M,
                         Rating = "G",
                     },

                      new Movie
                      {
                          Title = "Ghostbuster 2",
                          RealeseDate =DateTime.Parse("1989-2-23"),
                          Genre = "Comedy",
                          Price =9.99M,
                          Rating = "G",

                      },

                       new Movie
                       {
                           Title = "Rio Bravo",
                           RealeseDate =DateTime.Parse("1959-4-15"),
                           Genre = "Western",
                           Price =3.99M,
                           Rating = "NA",

                       }
                );
                context.SaveChanges();

            }
              
        }
    }
}
