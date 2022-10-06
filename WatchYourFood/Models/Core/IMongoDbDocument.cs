using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WatchYourFood.Models.Core;

public interface IMongoDbDocument
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    
    public DateTime? CreatedAt { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
    
    public string? CreatedByUserId { get; set; }

}