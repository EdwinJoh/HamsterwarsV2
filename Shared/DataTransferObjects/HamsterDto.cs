using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
   public record HamsterDto(int Id,string Name, int Age,string FavFood,string Loves,string ImgName,int Wins,int Defeats,int Games);
}
