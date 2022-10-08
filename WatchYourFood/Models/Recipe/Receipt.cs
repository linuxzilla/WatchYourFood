using MongoDB.Bson.Serialization.Attributes;
using WatchYourFood.Models.Core;

namespace WatchYourFood.Models.Recipe;

[BsonIgnoreExtraElements]
public class Receipt : MongoDbDocument, IRecipe
{
    public string? Title { get; set; }
    
    public string? Description { get; set; }

    public IEnumerable<ReceiptTag> Tags { get; set; } = new List<ReceiptTag>();
    
    public IEnumerable<RecipeIngredient> Ingredients { get; set; } = new List<RecipeIngredient>();

    public IEnumerable<ReceiptStep> ReceiptSteps { get; set; } = new List<ReceiptStep>();
}