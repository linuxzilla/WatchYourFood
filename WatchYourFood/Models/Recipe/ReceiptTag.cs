using WatchYourFood.DataAccess.Core;
using WatchYourFood.Models.Core;

namespace WatchYourFood.Models.Recipe;

public class ReceiptTag : MongoDbDocument, IReceiptTag
{
    public string TagTitle { get; set; } = null!;

    [MongoRef(typeof(Receipt))]
    public IEnumerable<EntityRef?> Receipt { get; set; } = new List<EntityRef?>();
}