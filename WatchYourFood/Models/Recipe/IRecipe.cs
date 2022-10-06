using MongoDB.Bson.Serialization.Attributes;
using WatchYourFood.Dao.Core;

namespace WatchYourFood.Models.Recipe;

public interface IRecipe
{
    public string? Title { get; set; }

    public string? Description { get; set; }

    [BsonIgnore] 
    [MongoLookup] 
    public IEnumerable<Tag> Tags { get; set; }
    
    [BsonIgnore] 
    [MongoLookup] 
    public IEnumerable<RecipeIngredient> Ingredients { get; set; }
}