using MongoDB.Entities;
using WatchYourFood.Models.Dto.User;
using WatchYourFood.Models.Entities.User;
using WatchYourFood.Repositories.Core;

namespace WatchYourFood.Facades;

public class UserAccountFacades : IUserAccountFacades
{
    private readonly IRepository _repository;

    public UserAccountFacades(IRepository repository)
    {
        _repository = repository;
    }
    
    public async Task AddNewUser(UserDto userDto)
    {
        var testNewUser = new UserEntity()
        {
            Email = userDto.Email,
            Username = userDto.Email,
            PasswordHash = userDto.Password
        };

        await testNewUser.SaveAsync();
    }
}