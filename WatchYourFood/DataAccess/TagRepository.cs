using WatchYourFood.DataAccess.Core;
using WatchYourFood.Models.Recipe;

namespace WatchYourFood.DataAccess;

public class TagRepository : RepositoryBase<ReceiptTag>
{
    public TagRepository(MongoDbContext context) : base(context) { }
    
    
}