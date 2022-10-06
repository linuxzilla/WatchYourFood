using MongoDB.Bson.Serialization.Attributes;

namespace WatchYourFood.Models.Recipe;

public interface ITag
{
    public string TagTitle { get; set; }
}