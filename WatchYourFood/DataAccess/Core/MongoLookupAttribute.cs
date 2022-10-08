namespace WatchYourFood.DataAccess.Core;

[AttributeUsage(AttributeTargets.Property)]
public class MongoLookupAttribute : Attribute
{
    public MongoLookupAttribute() {}
}