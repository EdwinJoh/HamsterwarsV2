using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record HamsterForCreationDto(string Name, int Age, string FavFood, string Loves, string ImgName);
    
}
