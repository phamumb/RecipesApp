using System.Collections.Generic;
using Recipes.Repository.Domain;

namespace Recipes.Logic.Services
{
    public interface IAppService
    {
        bool CreateTables();
        RecipesDomain GetSingleRecipes(long id);
        bool CreateNewRecipes(RecipesDomain model);
        IEnumerable<RecipesDomain> GetAllRecipes();
        dynamic GetAllIngredients();
        bool AddRecipesIngredients(IEnumerable<RecipesIngredientDomain> model);
        IEnumerable<RecipesIngredientDomain> GetRecipesIngredients(long recipesId);
        bool UpdateRecipes(RecipesDomain model);
        bool AddToCart(CartItemDomain model);
        IngredientDomain GetSingleIngredient(long id);
        bool AddUpdateIngredient(IngredientDomain model);
        dynamic GetIngredientCategories();
    }
}