using MongoDB.Entities;
using WatchYourFood.Models.Core;

namespace WatchYourFood.Models.Entities.RecipeTag;

[Collection("Tags")]
public class RecipeTagEntity : Entity, ICreatedOn, IModifiedOn, ICreatedBy, IRecipeTag
{
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public string? CreatedBy { get; set; }
    
    public string Content { get; set; } = null!;
}