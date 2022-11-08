using WatchYourFood.Models.Entities.User;

namespace WatchYourFood.Repositories.Core;

public interface IRepository
{
    public Task SaveNewUser(UserEntity user);
    public Task<UserEntity> GetUserEntityByUsername(string username);
    public Task<UserEntity> GetUserEntityById(string id);
    // ToDo:
    public Task<bool> IsEmailValidationNeeded(string id);
    
    
}