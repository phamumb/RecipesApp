using Recipes.Repository.Domain;

namespace Recipes.Logic.Services
{
    public interface IAppService
    {
        bool CheckTables();
        RecipeDomain GetSingle(long id);
    }
}