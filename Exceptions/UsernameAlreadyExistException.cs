namespace WatchYourFood.Exceptions;

public class UsernameAlreadyExistException : Exception
{
    public UsernameAlreadyExistException()
    {
    }
    
    public UsernameAlreadyExistException(string? message) : base(message)
    {
    }
}