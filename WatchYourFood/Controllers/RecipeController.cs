using Microsoft.AspNetCore.Mvc;
using WatchYourFood.Models.Recipe;
using WatchYourFood.Services;

namespace WatchYourFood.Controllers;

public class RecipeController : ControllerBase
{
    private readonly IDataServices _dataServices;
    private readonly ILogger<RecipeController> _logger;
    
    public RecipeController(IDataServices dataServices, ILogger<RecipeController> logger)
    {
        _dataServices = dataServices;
        _logger = logger;
    }
    
    [HttpPost("/api/receipt/add", Name = nameof(AddReceipt))]
    public async Task<Receipt> AddReceipt([FromBody] Receipt receipt)
    {
        _logger.LogInformation("Adding a new receipt...");
        var result = await _dataServices.Recipes.AddEntityAsync(receipt);
        return result;
    }
}