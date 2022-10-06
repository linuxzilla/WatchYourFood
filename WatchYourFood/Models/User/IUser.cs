namespace WatchYourFood.Models.User;

public interface IUser
{
    public string Username { get; set; }
    public string EmailAddr { get; set; }
    public string? ProfilePictureId { get; set; }
    public string? ProfileDesc { get; set; }
}