using MongoDB.Entities;

namespace WatchYourFood.Entities.User;

[Collection("Users")]
public class UserEntity : Entity, ICreatedOn, IModifiedOn, IUser
{
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }

    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    
    [Preserve]
    public bool IsVerified { get; set; }
}