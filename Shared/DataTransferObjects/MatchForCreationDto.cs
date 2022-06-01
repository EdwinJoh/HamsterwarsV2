using System.ComponentModel.DataAnnotations;

namespace SharedHelpers.DataTransferObjects;

public record MatchForCreationDto
{
    [Required(ErrorMessage = "MatchWinnerid is an required field")]
    public int WinnerId { get; set; }

    [Required(ErrorMessage = "MatchLoserid is an required field")]
    public int LoserId { get; set; }

    [Required(ErrorMessage = "DateTime is an required field")]
    public DateTime DateTime { get; set; } = DateTime.Now;
}

