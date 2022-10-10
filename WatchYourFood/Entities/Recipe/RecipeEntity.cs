using MongoDB.Entities;
using WatchYourFood.Entities.Base;

namespace WatchYourFood.Entities.Recipe;

[Collection("Recipes")]
public class RecipeEntity : Entity, ICreatedOn, IModifiedOn, IRecipe, ICreatedBy
{
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public string? CreatedBy { get; set; }

    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public IEnumerable<RecipeStep> Steps { get; set; } = new List<RecipeStep>();
} 