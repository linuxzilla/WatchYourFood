using MongoDB.Entities;

namespace WatchYourFood.Repositories.Base;

public interface IRepositoryBase<T> where T : IEntity
{
    public Task<T> GetEntityById(string id);
}