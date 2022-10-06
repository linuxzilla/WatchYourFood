using WatchYourFood.Models.Core;

namespace WatchYourFood.Models.Recipe;

public class Tag : MongoDbDocument, ITag
{
    public string TagTitle { get; set; } = null!;
}