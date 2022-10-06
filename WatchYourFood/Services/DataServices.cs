using WatchYourFood.Dao;
using WatchYourFood.Dao.Core;

namespace WatchYourFood.Services;

public class DataServices : IDataServices
{
    private readonly MongoDbContext _context;

    public DataServices(MongoDbContext context)
    {
        this._context = context;
    }

    public TagRepository Tags => new TagRepository(this._context);
}