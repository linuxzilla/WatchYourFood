using MongoDB.Entities;
using WatchYourFood.Models.Core;
using WatchYourFood.Models.Entities.Recipe;

namespace WatchYourFood.Models.Entities.User;

[Collection("Users")]
public class UserEntity : Entity, ICreatedOn, IModifiedOn, IUser
{
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }

    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;

    public string? PasswordHash { get; set; }
    
    [Preserve]
    public bool IsVerified { get; set; }
    [Preserve] 
    public string? EmailVerificationCode { get; set; }
    
    public Many<RecipeEntity> Recipes { get; set; } = null!;

    public UserEntity() => 
        this.InitOneToMany(() => Recipes);

    static UserEntity()
    {
        DB.Index<UserEntity>()
            .Key(x => x.Email, KeyType.Ascending)
            .Option(o => o.Unique = true)
            .CreateAsync();
        
        DB.Index<UserEntity>()
            .Key(x => x.Username, KeyType.Ascending)
            .Option(o => o.Unique = true)
            .CreateAsync();
        
        DB.Index<UserEntity>()
            .Key(x => x.Email, KeyType.Ascending)
            .Option(o => o.Unique = true)
            .CreateAsync();

        DB.Index<UserEntity>()
            .Key(x => x.EmailVerificationCode, KeyType.Ascending)
            .CreateAsync();
    }
}