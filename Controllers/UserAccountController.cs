using Microsoft.AspNetCore.Mvc;
using WatchYourFood.Facades;
using WatchYourFood.Models.Dto.User;
using WatchYourFood.Repositories.Core;

namespace WatchYourFood.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;
    private readonly UserAccountFacades _accountFacades;

    public AuthController(ILogger<AuthController> logger, UserAccountFacades userAccountFacades)
    {
        _logger = logger;
        _accountFacades = userAccountFacades;
    }
    
    [HttpPost]
    public async Task AddNewUser([FromBody] UserDto userDto)
    {
        _logger.LogInformation("Adding new user ...");
        await _accountFacades.AddNewUser(userDto);
        _logger.LogInformation("New user successfully added: {Username}", userDto.Username);
    }
    
}