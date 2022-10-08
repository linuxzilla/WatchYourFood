namespace WatchYourFood.Helpers;

public class MongoDbSettings
{
    public string MongoHost { get; set; } = null!;
    public int Port { get; set; }
    public string Database { get; set; } = null!;
    public string? Username { get; set; }
    public string? Password { get; set; }
}