using System.Collections.Generic;
using Recipes.Repository.Domain;

namespace Recipes.Logic.Services
{
    public interface IAppService
    {
        bool CreateTables();
        RecipeDomain GetSingle(long id);
        bool CreateNewRecipes(RecipeDomain model);
        bool AddNewIngredient(IngredientDomain model);
        IEnumerable<RecipeDomain> GetAllRecipes();
        IEnumerable<IngredientDomain> GetAllIngredients();
    }
}