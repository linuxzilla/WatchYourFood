using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace WatchYourFood.Dao.Core;

public static class MongoQueryableMixIn
{
    public static Task<List<T>> ToMongoListAsync<T>(this IQueryable<T> mongoQuery)
    {
        return ((IMongoQueryable<T>) mongoQuery).ToListAsync();
    }
}