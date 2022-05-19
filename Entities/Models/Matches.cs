using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
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
}
