using MongoDB.Entities;
using WatchYourFood.Entities.Base;

namespace WatchYourFood.Entities.RecipeTag;

[Collection("Tags")]
public class RecipeTagEntity : Entity, ICreatedOn, IModifiedOn, ICreatedBy, IRecipeTag
{
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public string? CreatedBy { get; set; }
    
    public string Content { get; set; } = null!;
}