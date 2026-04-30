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
            new Game { Title = "Borderlands", ReleaseDate = DateTime.Parse("10/20/2009"), Genre = "Action role-playing, First-person shooter", GameCover = "img/borderlands.jpg" },
            new Game { Title = "Cyberpunk 2077", ReleaseDate = DateTime.Parse("12/10/2020"), Genre = "Action role-playing", GameCover = "img/Cyberpunk_2077.jpg" },
            new Game { Title = "South Of Midnight", ReleaseDate = DateTime.Parse("04/03/2025"), Genre = "Action-adventure", GameCover = "img/South.jpg" },
            new Game { Title = "Red Dead Redemption 2", ReleaseDate = DateTime.Parse("10/26/2018"), Genre = "Western, Shooter game, Action-adventure game,", GameCover = "img/RDR2.jpg" },
            new Game { Title = "God Of War", ReleaseDate = DateTime.Parse("04/20/2018"), Genre = "Action-adventure game, Fighting game", GameCover = "img/GOW.jpg" }
        );

        context.SaveChanges();

        context.Characters.AddRange(
        new Character { CharacterName = "Roland", CharacterStory = "Only the most elite military training can produce a soldier like Roland, who's always ready to charge into battle using whatever firearms are currently on-hand. Roland brings his own backup in the form of the Scorpio Turret Action Skill, which lays down covering fire and can even heal injured teammates.", CharacterImage = ""},
        new Character { CharacterName = "Lilith", CharacterStory = "Lilith possesses otherworldly abilities. Her Phasewalk Action Skill temporarily renders her invisible, allowing her to navigate the battlefield with ease. Once she emerges, Lilith releases a massive burst of energy, devastating any enemies nearby.", CharacterImage = ""},
        new Character { CharacterName = "Modecai", CharacterStory = "Mordecai prefers to pick off his targets from a distance, whether that's with an impeccably aimed sniper shot or the talons of his loyal pet raptor, Bloodwing. Activating the Bloodwing Action Skill sends Mordecai's feathered friend swooping down to eviscerate any enemy in his sights.", CharacterImage = ""},
        new Character { CharacterName = "Brick", CharacterStory = "Brick's fists are as lethal as any firearm, and his hulking, muscle-packed frame makes him a tough target to take down. When activating his Berserk Action Skill, Brick flies into an uncontrollable rage, regaining health at a staggering rate as he punches his opponents to death.", CharacterImage = ""},
        new Character { CharacterName = "Maya", CharacterStory = "Raised by a manipulative order of warrior-monks, Maya is a master of elemental damage. Her Phaselock Action Skill traps enemies in a stasis sphere—giving her and other Vault Hunters plenty of time to fill them with holes.", CharacterImage = ""},
        new Character { CharacterName = "Axton", CharacterStory = "A bad man with a very bad turret, Axton brings a lethal set of commando skills to the table. His Sabre Turret Action Skill doles out serious damage and can be outfitted with a wide range of artillery", CharacterImage = ""},
        new Character { CharacterName = "Salvador", CharacterStory = "This Pandoran native exhibits much of the local exuberance for violence and (alleged) criminal activity. Activating Salvador's Gunzerking Action Skill lets him dual-wield two weapons for double the firepower and an exponentially higher body count.", CharacterImage = ""},
        new Character { CharacterName = "Zero", CharacterStory = "The most effective assassin to ever operate in the galaxies, Zer0 is skilled with everything from long-range rifles to his digistructed blade. Upon activating his Decepti0n Action Skill, Zer0 cloaks, leaving behind a holographic decoy in his place that opens up unsuspecting enemies to devastating sneak attacks.", CharacterImage = ""},
        new Character { CharacterName = "V", CharacterStory = "Roaming the Badlands, looting scrapyards, raiding fuel depots - life on the road wasn't easy. But growing up in a nomad clan has its perks. Honesty, integrity, and a love of freedom - qualities that few in Night City possess, and no amount of money can buy.", CharacterImage = "" },
        new Character { CharacterName = "Johnny Silverhand", CharacterStory = "a famous and influential rockerboy and lead singer of the band Samurai before its breakup in 2008.[2] A military veteran who defined the rockerboy movement as it is known today, Silverhand was the most prominent figure who fought against the corrupt American government and megacorporations, often being described as a terrorist because of this. Despite being charismatic and quite the charmer, he was also known to be irrational, impulsive, and manipulative.", CharacterImage = ""},
        new Character { CharacterName = "Jackie Welles", CharacterStory = "A proud son of Heywood and an even prouder son of Mamá Welles. Jackie's stubborn - when he wants something, he won't stop (or shut up about it) until he gets his hands on it. Jackie always wanted a lot out of life - maybe too much.", CharacterImage = ""},
        new Character { CharacterName = "Panam Palmer", CharacterStory = "Panam is a nomad - although, maybe 'ex-nomad' rings truer these days. She locked horns with the family's leader, Saul, left Aldecaldo nation and moved to Night City to try her luck as a merc. Panam's life is at a crossroads - on one hand she knows her life needs a change, it's now or never. On the other hand, burning bridges with the nomad family where all her friends are might have been a bit drastic. On top of that, Night City doesn't take too kindly to nomads or have patience for people like Panam who are internally conflicted and dream of a brighter future.", CharacterImage = ""},
        new Character { CharacterName = "Judy Alvarez", CharacterStory = "One of braindance's most gifted editors and a skilled techie. If she wanted to, she could get hired at any corpo entertainment studio and make bank, but Judy values her independence too much to sell out — she rejects every offer that comes her way. Her anarchist spirit drew her to the Mox in the hope that they could improve the lives of people in Night City. Her biggest flaw is that she can't keep her mouth shut in the face of injustice — something that always gets her in trouble. For some, though, it's her greatest virtue.", CharacterImage = ""},
        new Character { CharacterName = "Hazel Flood", CharacterStory = "Hazel is the protagonist and the player character of South of Midnight. She is a young woman with magical powers who is from Prospero, a town in the American Deep South that was destroyed from a hurricane.", CharacterImage = "" },
        new Character { CharacterName = "Catfish", CharacterStory = "", CharacterImage = ""},
        new Character { CharacterName = "Crouton", CharacterStory = "", CharacterImage = ""},
        new Character { CharacterName = "Arthur Morgan", CharacterStory = "", CharacterImage = ""},
        new Character { CharacterName = "John Marston", CharacterStory = "", CharacterImage = ""},
        new Character { CharacterName = "Dutch van der linde", CharacterStory = "", CharacterImage = ""},
        new Character { CharacterName = "Abigail Roberts", CharacterStory = "", CharacterImage = ""},
        new Character { CharacterName = "Hosea Matthews", CharacterStory = "", CharacterImage = ""},
        new Character { CharacterName = "Kratos", CharacterStory = "", CharacterImage = ""},
        new Character { CharacterName = "Atreus", CharacterStory = "", CharacterImage = ""},
        new Character { CharacterName = "Mimir", CharacterStory = "", CharacterImage = ""},
        new Character { CharacterName = "Freya", CharacterStory = "", CharacterImage = ""}
        );
        
        context.SaveChanges();
    }
}
