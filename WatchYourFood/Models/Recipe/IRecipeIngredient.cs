using MongoDB.Bson.Serialization.Attributes;

namespace WatchYourFood.Models.Recipe;

public interface IRecipeIngredient
{
    [BsonIgnore]
    public Ingredient? Ingredient { get; set; }
    public Double? Amount { get; set; }
    public string? Hint { get; set; }
}