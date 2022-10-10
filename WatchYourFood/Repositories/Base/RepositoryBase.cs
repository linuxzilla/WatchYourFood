using MongoDB.Entities;

namespace WatchYourFood.Repositories.Base;

public abstract class RepositoryBase<T> where T : IEntity
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public virtual async Task<T> GetEntityById(string id)
    {
        return await DB.Find<T>().OneAsync("id");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public virtual async Task<T> AddEntity(T entity)
    {
        await DB.SaveAsync(entity);
        return entity;
    }
}