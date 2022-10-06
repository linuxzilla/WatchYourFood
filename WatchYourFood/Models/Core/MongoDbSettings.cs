namespace WatchYourFood.Models.Core;

public class MongoDbSettings
{
    public string ConnectionUri { get; set; } = null!;
    public string DbName { get; set; } = null!;
}