using MongoDB.Bson.Serialization.Attributes;
using WatchYourFood.Dao.Core;
using WatchYourFood.Models.Core;

namespace WatchYourFood.Models.Recipe;

public class Receipt : MongoDbDocument, IRecipe
{
    public string? Title { get; set; }
    
    public string? Description { get; set; }
    
    [BsonIgnore]
    [MongoLookup]
    public IEnumerable<Tag> Tags { get; set; } = new List<Tag>();
    
    public IEnumerable<RecipeIngredient> Ingredients { get; set; } = new List<RecipeIngredient>();
}