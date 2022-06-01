using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Matches
{
    [Key]
    public int Id { get; set; }
    [Required]
    public int WinnerId { get; set; }
    [Required]
    public int LoserId { get; set; }
    [Required]
    public DateTime Timestamp { get; set; } = DateTime.Now;
}
