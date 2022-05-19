using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class MatchForCreationDto
    {
        public record MatchDto
        {
            [Required(ErrorMessage = "MatchWinnerid is an required field")]
            public int WinnerId { get; set; }

            [Required(ErrorMessage = "MatchLoserid is an required field")]
            public int LoserId { get; set; }
            [Required(ErrorMessage = "DateTime is an required field")]
            public DateTime DateTime { get; set; }
        }
    }
}
