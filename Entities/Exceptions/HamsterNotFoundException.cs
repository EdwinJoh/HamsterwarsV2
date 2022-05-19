using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class HamsterNotFoundException : NotFoundExceptions
    {
        public HamsterNotFoundException(int id) : base($"The Hamster with id: {id} doesn't exsist in the database")
        {

        }

    }
    public class BadRequestException : Exception
    {
        protected BadRequestException(string message) : base(message)
        {
        }
    }
    public sealed class IdParametersBadRequestException : BadRequestException
    {
        public IdParametersBadRequestException() : base("Parameter ids is null")
        {
        }
    }
    public sealed class CollectionByIdsBadRequestException : BadRequestException
    {
        public CollectionByIdsBadRequestException() : base("Collection count missmatch compering to ids")
        {

        }
    }
  
}
