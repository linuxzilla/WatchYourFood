using MongoDB.Bson;
using MongoDB.Entities;
using WatchYourFood.Entities.Base;

namespace WatchYourFood.Entities.Recipe;

[Collection("Recipes")]
public class RecipeEntity : Entity, ICreatedOn, IModifiedOn, IRecipe, ICreator
{
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public ObjectId CreatedBy { get; set; }

    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public IEnumerable<RecipeStep> Steps { get; set; } = new List<RecipeStep>();
} 