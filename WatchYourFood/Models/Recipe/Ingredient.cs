using WatchYourFood.Models.Core;

namespace WatchYourFood.Models.Recipe;

public class Ingredient : MongoDbDocument, IIngredient
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
}