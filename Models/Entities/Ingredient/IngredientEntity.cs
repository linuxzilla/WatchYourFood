using MongoDB.Entities;
using WatchYourFood.Models.Core;

namespace WatchYourFood.Models.Entities.Ingredient;

[Collection("Ingredients")]
public class IngredientEntity : Entity, ICreatedOn, IModifiedOn, ICreatedBy, IIngredient
{
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public string? CreatedBy { get; set; }
    
    public string? Name { get; set; }
    public string? Description { get; set; }
}