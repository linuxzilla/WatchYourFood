using MongoDB.Driver;
using WatchYourFood.DataAccess.Core;
using WatchYourFood.Models.Recipe;

namespace WatchYourFood.DataAccess;

public class ReceiptRepository : RepositoryBase<Receipt>
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    public ReceiptRepository(MongoDbContext context) : base(context) { }
    
    public async Task<Receipt?> GetReceiptEntityById(string id)
    {
        IMongoCollection<Ingredient> ingredients =
            Context.Database.GetCollection<Ingredient>(nameof(Ingredient));
        IMongoCollection<ReceiptTag> tags =
            Context.Database.GetCollection<ReceiptTag>(nameof(ReceiptTag));
        
        return null;
    }

}