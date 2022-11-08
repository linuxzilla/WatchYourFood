using Microsoft.AspNetCore.Mvc;
using WatchYourFood.Repositories.Core;

namespace WatchYourFood.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : Controller
{
    private readonly IRepository _repository;

    public AuthController(IRepository repository)
    {
        _repository = repository;
    }
    
    
}