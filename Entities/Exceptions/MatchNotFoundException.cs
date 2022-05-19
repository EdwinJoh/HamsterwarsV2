using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class MatchNotFoundException : NotFoundExceptions
    {
        public MatchNotFoundException(int id) : base($"The Match with id: {id} doesn't exsist in the database")
        {

        }
    }
}
