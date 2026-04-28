using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace CIDM3312Final.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Games.Any()) 
        {
            return;
        }

        context.Games.AddRange(
            new Game { Title = "Borderlands", ReleaseDate = DateTime.Parse("10/20/2009"), Genre = "Action role-playing, First-person shooter", GameCover = "img/borderlands.jpg"},
            new Game { Title = "Cyberpunk 2077", ReleaseDate = DateTime.Parse("12/10/2020"), Genre = "Action role-playing", GameCover = "img/Cyberpunk_2077.jpg"},
            new Game { Title = "South Of Midnight", ReleaseDate = DateTime.Parse("04/03/2025"), Genre = "Action-adventure", GameCover = "img/South.jpg"},
            new Game { Title = "Red Dead Redemption 2", ReleaseDate = DateTime.Parse("10/26/2018"), Genre = "Western, Shooter game, Action-adventure game,", GameCover = "img/RDR2.jpg"},
            new Game { Title = "God Of War", ReleaseDate = DateTime.Parse("04/20/2018"), Genre = "Action-adventure game, Fighting game", GameCover = "img/GOW.jpg"}
        );

        context.SaveChanges();
    }
}
