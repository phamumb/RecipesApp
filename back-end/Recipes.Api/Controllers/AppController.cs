using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Recipes.Logic.Services;
using Recipes.Repository.Domain;

namespace Recipes.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AppController : ControllerBase
    {
        private readonly IAppService _appService;
        public AppController(IAppService appService)
        {
            _appService = appService;
        }

        // Recipes

        [HttpGet]
        public IEnumerable<RecipeDomain> GetAllRecipes()
        {
            return _appService.GetAllRecipes();
        }

        [HttpGet]
        public RecipeDomain GetSingleRecipe(long id)
        {
            return _appService.GetSingle(id);
        }

        [HttpPost]
        public bool CreateNewRecipe(RecipeDomain model)
        {
            return _appService.CreateNewRecipe(model);
        }

        // Ingredients

        [HttpPost]
        public bool AddNewIngredient([FromBody]IngredientDomain model)
        {
            return _appService.AddNewIngredient(model);
        }

        [HttpGet]
        public IEnumerable<IngredientDomain> GetAllIngredients()
        {
            return _appService.GetAllIngredients();
        }

        [HttpGet]
        public void Check()
        {
            _appService.CreateTables();
        }
    }
}