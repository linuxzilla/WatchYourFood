namespace WatchYourFood.Models.User;

public class User : IUser
{
    public string Username { get; set; } = null!;
    public string EmailAddr { get; set; } = null!;
    public string? ProfilePictureId { get; set; }
    public string? ProfileDesc { get; set; }
}