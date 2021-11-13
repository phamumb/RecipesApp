using System.Collections.Generic;
using Recipes.Repository.Domain;

namespace Recipes.Logic.Services
{
    public interface IAppService
    {
        bool CreateTables();
        RecipesDomain GetSingleRecipes(long id);
        bool CreateNewRecipes(RecipesDomain model);
        bool AddNewIngredient(IngredientDomain model);
        IEnumerable<RecipesDomain> GetAllRecipes();
        dynamic GetAllIngredients();
        bool AddRecipesIngredients(IEnumerable<RecipesIngredientDomain> model);
        IEnumerable<RecipesIngredientDomain> GetRecipesIngredients(long recipesId);
        bool UpdateRecipes(RecipesDomain model);
    }
}