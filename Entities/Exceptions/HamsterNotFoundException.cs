using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class HamsterNotFoundException :NotFoundExceptions
    {
        public HamsterNotFoundException(int id) :base ($"The Hamster with id: {id} doesn't exsist in the database")
        {

        }
    }
}
