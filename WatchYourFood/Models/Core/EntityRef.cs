namespace WatchYourFood.Models.Core;

public abstract class EntityRef : MongoDbDocument
{
    public string Collection { get; set; } = null!;
}