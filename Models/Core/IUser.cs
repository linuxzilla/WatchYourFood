namespace WatchYourFood.Models.Core;

public interface IUser
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string? AboutMe { get; set; }
}