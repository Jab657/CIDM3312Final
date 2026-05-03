using System.ComponentModel.DataAnnotations;


namespace CIDM3312Final.Models;

public class Character
{
    public int CharacterID { get; set; } // Primary Key
    public string CharacterName { get; set; } = string.Empty;
    public string CharacterStory { get; set; } = string.Empty;


    [Display(Name = "Game")]
    public int GameID { get; set; }
    public Game? Game { get; set; } = default!;
    public List<GameCharacter>? GameCharacters { get; set; } = default!;
}

public class GameCharacter
{
    public int GameID { get; set; } // Composite Primary Key, Foreign Key 1
    public int CharacterID { get; set; } // Composite Primary Key, Foreign Key 2
    public Game Game { get; set; } = default!; // Navigation Property
    public Character Character { get; set; } = default!; // Navigation Property
}