using MongoDB.Bson.Serialization.Attributes;

namespace WatchYourFood.Models.Recipe;

public interface IReceiptTag
{
    public string TagTitle { get; set; }
}