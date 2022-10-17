using Microsoft.AspNetCore.Mvc;
using WatchYourFood.Models.Entities.RecipeTag;
using WatchYourFood.Repositories.Core;

namespace WatchYourFood.Controllers;

[ApiController]
[Route("[controller]")]
public class TagController : ControllerBase
{
    private readonly IRepository _repository;

    public TagController(IRepository repository)
    {
        _repository = repository;
    }
    
    [HttpPost("/api/tag/add", Name = nameof(AddTag))]
    public async Task<RecipeTagEntity> AddTag([FromBody] RecipeTagEntity receiptTag)
    {
        return null;
    }
    
}