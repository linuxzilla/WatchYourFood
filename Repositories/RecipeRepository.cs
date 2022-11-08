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

        await user.SaveAsync();
    }

    public async Task<UserEntity> GetUserEntityByUsername(string username)
    {
        var user = await DB.Find<UserEntity>()
            .Match(x => x.Username == username)
            .Project(x => new UserEntity
            {
                CreatedOn = x.CreatedOn,
                Email = x.Email,
                Username = x.Username
            })
            .ExecuteSingleAsync();

        return user;
    }

    public Task<UserEntity> GetUserEntityById(string id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsEmailValidationNeeded(string id)
    {
        throw new NotImplementedException();
    }

    public Task IsEmailValidationNeeded()
    {
        throw new NotImplementedException();
    }
}