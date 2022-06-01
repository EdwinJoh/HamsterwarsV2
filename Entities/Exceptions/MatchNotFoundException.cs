namespace Entities.Exceptions;

public class MatchNotFoundException : NotFoundExceptions
{
    public MatchNotFoundException(int id) : base($"The Match with id: {id} doesn't exsist in the database")
    {

    }
}
