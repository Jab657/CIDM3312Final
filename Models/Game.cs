using System.ComponentModel.DataAnnotations;

namespace CIDM3312Final.Models;

public class Game
{
    public int GameID { get; set; } // Primary Key

    [Display(Name = "Title")]
    public string Title { get; set; } = string.Empty;

    [Display(Name = "Game Cover")]
    public string GameCover { get; set; } = string.Empty;

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Display(Name = "Genre")]
    public string Genre { get; set; } = string.Empty;

    public List<Character>? Characters { get; set; } = default!; 
    public List<GameCharacter>? GameCharacters { get; set; } = default!; 
}