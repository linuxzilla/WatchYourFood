using MongoDB.Entities;
using WatchYourFood.Models.Core;
using WatchYourFood.Models.Entities.RecipeTag;
using WatchYourFood.Models.Entities.User;

namespace WatchYourFood.Models.Entities.Recipe;

[Collection("Recipes")]
public class RecipeEntity : Entity, ICreatedOn, IModifiedOn, IRecipe
{
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    // public string? CreatedBy { get; set; }
    
    public One<UserEntity> CreatedBy { get; set; }

    //public Many<RecipeTagEntity>? Tags { get; set; }
    
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public IEnumerable<RecipeStep> Steps { get; set; } = new List<RecipeStep>();

    /*
    public RecipeEntity()
    {
        this.InitOneToMany(() => Tags);
    }
    */
} 