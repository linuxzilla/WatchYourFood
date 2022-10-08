using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using WatchYourFood.Models.Core;
using WatchYourFood.Models.Recipe;
using WatchYourFood.Services;

namespace WatchYourFood.Controllers;

[ApiController]
public class TagController : ControllerBase
{
    private readonly IDataServices _dataServices;
    private readonly ILogger<TagController> _logger;
    
    public TagController(IDataServices dataServices, ILogger<TagController> logger)
    {
        _dataServices = dataServices;
        _logger = logger;
    }
    
    [HttpPost("/api/tag/add", Name = nameof(AddTag))]
    public async Task<ReceiptTag> AddTag([FromBody] ReceiptTag receiptTag)
    {
        _logger.LogInformation("Adding a new tag... {Title}", receiptTag.TagTitle);
        var result = await _dataServices.Tags.AddEntityAsync(receiptTag);
        return result;
    }
    
    [HttpGet("/api/tag/{id}", Name = nameof(GetEmployee))]
    public async Task<ReceiptTag> GetEmployee(string id)
    {
        _logger.LogInformation("Getting tag with ID: {Id}", id);
        var tag = await _dataServices.Tags.GetAsync(id);
        return tag;
    }

}