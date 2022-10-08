using WatchYourFood.DataAccess;
using WatchYourFood.DataAccess.Core;

namespace WatchYourFood.Services;

public class DataServices : IDataServices
{
    private readonly MongoDbContext _context;

    public DataServices(MongoDbContext context)
    {
        this._context = context;
    }

    public TagRepository Tags => new(_context);
    public ReceiptRepository Recipes => new (_context);
}