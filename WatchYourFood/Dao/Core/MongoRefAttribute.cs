namespace WatchYourFood.Dao.Core;

[AttributeUsage(AttributeTargets.Property)]
public class MongoRefAttribute : Attribute
{
    private readonly Type _type;

    public MongoRefAttribute(Type type)
    {
        _type = type;
    }
}