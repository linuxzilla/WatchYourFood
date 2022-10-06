using WatchYourFood.Dao.Core;
using WatchYourFood.Models.Recipe;

namespace WatchYourFood.Dao;

public class TagRepository : RepositoryBase<Tag>
{
    public TagRepository(MongoDbContext context) : base(context) { }
    
    
}