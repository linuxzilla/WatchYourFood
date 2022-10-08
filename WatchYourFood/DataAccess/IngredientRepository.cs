using WatchYourFood.DataAccess.Core;
using WatchYourFood.Models.Recipe;

namespace WatchYourFood.DataAccess;

public class IngredientRepository : RepositoryBase<Ingredient>
{
    public IngredientRepository(MongoDbContext context) : base(context) { }
    
    
}