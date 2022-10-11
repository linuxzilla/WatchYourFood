using MongoDB.Entities;
using WatchYourFood.Entities.RecipeTag;

namespace WatchYourFood.Entities.Recipe;

public interface IRecipe
{
    public string Title { get; set; }
    public string? Description { get; set; }
    public IEnumerable<RecipeStep> Steps { get; set; }
    public Many<RecipeTagEntity>? Tags { get; set; }
}