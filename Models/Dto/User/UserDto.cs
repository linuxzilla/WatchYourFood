using WatchYourFood.Models.Core;

namespace WatchYourFood.Models.Dto.User;

public class UserDto : IUser
{
    public DateTime? CreatedOn { get; set; }
    public DateTime? ModifiedOn { get; set; }
    
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;

    public string? Password { get; set; }
}