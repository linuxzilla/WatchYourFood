using Microsoft.AspNetCore.Mvc;
using MongoDB.Entities;
using WatchYourFood.Models.Dto.User;
using WatchYourFood.Models.Entities.User;

namespace WatchYourFood.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : Controller
{
    [HttpGet]
    public async Task<bool> Get()
    {
        var testNewUser = new UserEntity()
        {
            Email = "test@test.com",
            Username = "TestElek",
            PasswordHash = "bauopurepwgbtragpghprgp"
        };

        await testNewUser.SaveAsync();
        
        return true;
    }

    [HttpPost]
    public async Task<UserDto> PostUser([FromBody] UserDto userDto)
    {
        var testNewUser = new UserEntity()
        {
            Email = userDto.Email,
            Username = userDto.Email,
            PasswordHash = userDto.Password
        };

        await testNewUser.SaveAsync();

        return userDto;
    }
}