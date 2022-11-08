namespace WatchYourFood.Exceptions;

public class EmailAlreadyExistException : Exception
{
    public EmailAlreadyExistException()
    {
    }
    
    public EmailAlreadyExistException(string? message) : base(message)
    {
    }
}