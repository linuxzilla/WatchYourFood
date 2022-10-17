using MongoDB.Entities;
using WatchYourFood.Models.Entities.Recipe;
using WatchYourFood.Models.Entities.RecipeTag;

namespace WatchYourFood.Models.Core;

public interface IRecipe
{
    public string Title { get; set; }
    public string? Description { get; set; }
    public IEnumerable<RecipeStep> Steps { get; set; }
    public Many<RecipeTagEntity>? Tags { get; set; }
}