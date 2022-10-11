using MongoDB.Entities;
using WatchYourFood.Entities.RecipeTag;

namespace WatchYourFood.Repositories.Base;

public class Test : IRepositoryBase<RecipeTagEntity>
{
    public async Task<RecipeTagEntity> GetEntityById(string id)
    {
        return await DB.Find<RecipeTagEntity>().OneAsync(id);
    }
}