using Microsoft.AspNetCore.Mvc;
using WatchYourFood.Entities.RecipeTag;
using WatchYourFood.Repositories;

namespace WatchYourFood.Controllers;

[ApiController]
public class TagController : ControllerBase
{
    private readonly RecipeTagRepository _repository;

    public TagController(RecipeTagRepository repository)
    {
        _repository = repository;
    }
    
    [HttpPost("/api/tag/add", Name = nameof(AddTag))]
    public async Task<RecipeTagEntity> AddTag([FromBody] RecipeTagEntity receiptTag)
    {
        var result = await _repository.AddEntity(receiptTag);
        return result;
    }
    
}