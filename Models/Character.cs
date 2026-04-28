using System.ComponentModel.DataAnnotations;


namespace CIDM3312Final.Models;

public class Character
{
    public int CharacterID { get; set; } // Primary Key
    public string CharacterName { get; set; } = string.Empty;

    public string CharacterStats { get; set; } = string.Empty;

    public string CharacterImage { get; set; } = string.Empty;
}

public class GameCharacter
{
    public int GameID { get; set; } // Composite Primary Key, Foreign Key 1
    public int CharacterID { get; set; } // Composite Primary Key, Foreign Key 2
    public Game Game { get; set; } = default!; // Navigation Property
    public Character Character { get; set; } = default!; // Navigation Property
}