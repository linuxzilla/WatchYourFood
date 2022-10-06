using MongoDB.Bson;

namespace WatchYourFood.Models.Core;

public abstract class MongoDbDocument : IMongoDbDocument
{
    public string? Id { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? CreatedByUserId { get; set; }
}