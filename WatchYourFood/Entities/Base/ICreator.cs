using MongoDB.Bson;

namespace WatchYourFood.Entities.Base;

public interface ICreator
{
    public ObjectId CreatedBy { get; set; }
}