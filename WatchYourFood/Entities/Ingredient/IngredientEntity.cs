using MongoDB.Bson;
using MongoDB.Entities;
using WatchYourFood.Entities.Base;

namespace WatchYourFood.Entities.Ingredient;

[Collection("Ingredients")]
public class IngredientEntity : Entity, ICreatedOn, IModifiedOn, ICreator, IIngredient
{
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public ObjectId CreatedBy { get; set; }
    
    public string? Name { get; set; }
    public string? Description { get; set; }
}