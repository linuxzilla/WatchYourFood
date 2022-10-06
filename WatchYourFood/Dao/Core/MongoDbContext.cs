using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Serilog;
using WatchYourFood.Models.Core;

namespace WatchYourFood.Dao.Core;

public class MongoDbContext
{
    private readonly MongoClient _client;
    private readonly IMongoDatabase _database;

    public IMongoClient Client => _client;
    public IMongoDatabase Database => _database;
    
    public MongoDbContext(IOptions<MongoDbSettings> options)
        : this(options.Value.ConnectionUri, options.Value.DbName)
    {
        Log.Information("Connecting to MongoDB uri: {ValueUri}  database: {ValueDatabaseName}", 
            options.Value.ConnectionUri, options.Value.DbName);
    }

    public MongoDbContext(string connectionUri, string dbName)
    {
        Log.Information("Connecting to MongoDB uri: {ValueUri}", connectionUri );
        _client = new MongoClient(connectionUri);
        _database = _client.GetDatabase(dbName);
    }
}