using WatchYourFood.Models.Entities.User;

namespace WatchYourFood.Repositories.Core;

public interface IRepository
{
    public Task SaveNewUser(UserEntity user);
}