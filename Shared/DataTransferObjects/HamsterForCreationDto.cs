using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record HamsterForCreationDto
    {
        [Required(ErrorMessage ="Hamster name is an required fild")]
        [MaxLength(30,ErrorMessage ="Maximum length for the name is 30 characters")]
        public string? Name { get; set; }


        [Required(ErrorMessage = "Hamster age is an required fild")]
        [Range(1,3, ErrorMessage = "Age is required and it can't be lower than 1 or over 3")]
        public int Age { get; set; }

        public string? FavFood { get; set; }
        public string? Loves { get; set; }
        public string? ImgName { get; set; } = "hamster1.jpg";

}
    
}
