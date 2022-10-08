namespace WatchYourFood.Entities.User;

public interface IUser
{
    public string Username { get; set; }
    public string Email { get; set; }
    public bool IsVerified { get; set; }
}