using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Recipes.Logic.Services;
using Recipes.Repository.Domain;

namespace Recipes.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class RecipesController : ControllerBase
    {
        private readonly IAppService _appService;
        public RecipesController(IAppService appService)
        {
            _appService = appService;
        }

        // Recipes

        [HttpGet]
        public IEnumerable<RecipesDomain> GetAllRecipes()
        {
            return _appService.GetAllRecipes();
        }

        [HttpGet]
        public RecipesDomain GetSingleRecipes(long id)
        {
            return _appService.GetSingleRecipes(id);
        }

        [HttpPost]
        public bool CreateNewRecipes(RecipesDomain model)
        {
            return _appService.CreateNewRecipes(model);
        }

        [HttpGet]
        public IEnumerable<RecipesIngredientDomain> GetRecipesIngredients(long recipesId)
        {
            return _appService.GetRecipesIngredients(recipesId);
        }

        [HttpPost]
        public bool UpdateRecipes(RecipesDomain model)
        {
            return _appService.UpdateRecipes(model);
        }

        // Ingredients

        [HttpPost]
        public bool AddUpdateIngredient([FromBody] IngredientDomain model)
        {
            return _appService.AddUpdateIngredient(model);
        }

        [HttpPost]
        public bool AddRecipesIngredients(IEnumerable<RecipesIngredientDomain> model)
        {
            return _appService.AddRecipesIngredients(model);
        }

        [HttpGet]
        public dynamic GetAllIngredients()
        {
            return _appService.GetAllIngredients();
        }

        [HttpGet]
        public dynamic GetSingleIngredient(long id)
        {
            return _appService.GetSingleIngredient(id);
        }

        [HttpGet]
        public dynamic GetIngredientCategories()
        {
            return _appService.GetIngredientCategories();
        }

        [HttpPost]
        public bool AddToCart(CartItemDomain model)
        {
            return _appService.AddToCart(model);
        }

        [HttpGet]
        public void Check()
        {
            _appService.CreateTables();
        }
    }
}