namespace WatchYourFood.Dao.Core;

[AttributeUsage(AttributeTargets.Property)]
public class MongoLookupAttribute : Attribute
{
    public MongoLookupAttribute() {}
}