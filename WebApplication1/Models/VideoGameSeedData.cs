using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGames.Data;

namespace VideoGames.Models
{
    public class VideoGameSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =
                new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {

                if (context.VideoGame.Any())
                {
                    return;
                }
                context.VideoGame.AddRange(
                    new VideoGame
                    {
                        Title = "Call of Duty",
                        Genre = "FPS",
                        Platform = "Multi",
                        Price = 20.00M,
                        Publisher = "Infinity Ward",
                        Rating = "M",
                        ReleaseDate = DateTime.Parse("01-01-2003")

                    },
                    new VideoGame
                    {
                        Title = "Grand Theft Auto",
                        Genre = "Action-adventure game",
                        Platform = "Multi",
                        Price = 21.00M,
                        Publisher = "Rockstar Games",
                        Rating = "M",
                        ReleaseDate = DateTime.Parse("09-17-2013")

                    },
                    new VideoGame
                    {
                        Title = "Centipede",
                        Genre = "Arcade",
                        Platform = "Multi",
                        Price = 4.99M,
                        Publisher = "Atari",
                        Rating = "Early Childhood",
                        ReleaseDate = DateTime.Parse("01-01-1981")

                    }
                    );
                context.SaveChanges();


            }
        }
    }
}
