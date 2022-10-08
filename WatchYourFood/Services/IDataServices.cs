using WatchYourFood.DataAccess;
using WatchYourFood.Models.Recipe;

namespace WatchYourFood.Services;

public interface IDataServices
{
    public TagRepository Tags { get; }

    public ReceiptRepository Recipes { get; }
}