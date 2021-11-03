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

        [HttpGet]
        public RecipeDomain GetSingleRecipe(long id)
        {
            return _appService.GetSingle(id);
        }

        [HttpGet]
        public void Check()
        {
            _appService.CheckTables();
        }
    }
}