using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class MatchHistoryDto
    {
        public int Id { get; set; }
        public Hamster Winner { get; set; }
        public Hamster Loser { get; set; }
    }
}
