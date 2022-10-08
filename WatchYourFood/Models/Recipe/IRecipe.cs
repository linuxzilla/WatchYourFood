using MongoDB.Bson.Serialization.Attributes;

namespace WatchYourFood.Models.Recipe;

public interface IRecipe
{
    public string? Title { get; set; }

    public string? Description { get; set; }
    
    [BsonIgnore]
    public IEnumerable<ReceiptTag> Tags { get; set; }
    
    public IEnumerable<RecipeIngredient> Ingredients { get; set; }

    public IEnumerable<ReceiptStep> ReceiptSteps { get; set; }
}