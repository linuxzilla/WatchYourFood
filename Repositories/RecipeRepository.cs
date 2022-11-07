using MongoDB.Entities;
using WatchYourFood.Exceptions;
using WatchYourFood.Models.Entities.User;
using WatchYourFood.Repositories.Core;

namespace WatchYourFood.Repositories;

public class RecipeRepository : IRepository
{
    public async Task SaveNewUser(UserEntity user)
    {
        var isUsernameExist = await DB.Find<UserEntity>()
            .Match(x => x.Username == user.Username)
            .ExecuteAnyAsync();

        if (isUsernameExist)
            throw new UsernameAlreadyExistException();

        var isEmailExist = await DB.Find<UserEntity>()
            .Match(x => x.Email == user.Email)
            .ExecuteAnyAsync();

        if (isEmailExist)
            throw new EmailAlreadyExistException();
    }
}