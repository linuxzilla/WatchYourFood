using System.ComponentModel.DataAnnotations;
using WatchYourFood.Models.Core;

namespace WatchYourFood.Models.Dto.User;

public class UserDto : IUser
{
    public DateTime? CreatedOn { get; set; }
    public DateTime? ModifiedOn { get; set; }
    
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? AboutMe { get; set; }

    public string? Password { get; set; }
}