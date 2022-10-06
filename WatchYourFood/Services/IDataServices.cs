using WatchYourFood.Dao;

namespace WatchYourFood.Services;

public interface IDataServices
{
    public TagRepository Tags { get; }
}