using System.Linq.Expressions;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using WatchYourFood.Models.Core;

namespace WatchYourFood.DataAccess.Core;

public abstract class RepositoryBase<T> where T : IMongoDbDocument
{
    private readonly MongoDbContext _context;
    private readonly IMongoCollection<T> _collection;

    protected IMongoCollection<T> Collection => _collection;
    protected MongoDbContext Context => _context;

    protected RepositoryBase(MongoDbContext context)
    {
        _context = context;
        _collection = context.Database.GetCollection<T>(typeof(T).Name);
    }

    public virtual async Task<T> AddEntityAsync(T entity)
    {
        DateTime dateTimeNow = DateTime.UtcNow;

        if (string.IsNullOrEmpty(entity.Id))
        {
            entity.Id = ObjectId.GenerateNewId().ToString();
        }
        
        if (entity.CreatedAt.Equals(null))
        {
            entity.CreatedAt = dateTimeNow;
        }

        entity.UpdatedAt = dateTimeNow;

        await _collection.InsertOneAsync(entity);

        return entity;
    }

    public virtual async Task<DeleteResult> DeleteAsync(string id)
    {
        return await _collection.DeleteOneAsync<T>(e => e.Id == id);
    }
    
    public virtual async Task<T> GetAsync(string id)
    {
        return (await _collection.FindAsync<T>(e => e.Id == id)).FirstOrDefault();
    }
    
    public virtual async Task<IEnumerable<T>> 
        GetList(int start, int pageSize, Expression<Func<T, bool>>? whereClause = null)
    {
        var query = _collection.AsQueryable();

        if (whereClause != null)
        {
            query = query.Where(whereClause);
        }

        return await query
            .OrderBy(e => e.Id)
            .Skip(start)
            .Take(pageSize)
            .ToListAsync();
    }
}