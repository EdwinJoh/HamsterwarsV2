using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Hamster
{
    [Column("HamsterId")]
    public int Id { get; set; }

    [Required]
    [StringLength(20)]
    [MinLength(1)]
    public string? Name { get; set; }

    [Required]
    [Range(0, 3)]
    public int Age { get; set; }

    [StringLength(20)]
    public string? FavFood { get; set; }

    [StringLength(20)]
    public string? Loves { get; set; }

    public string? ImgName { get; set; }
    public int Wins { get; set; }
    public int Defeats { get; set; }
    public int Games { get; set; }
}
