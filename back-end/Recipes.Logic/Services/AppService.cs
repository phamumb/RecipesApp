using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipes.Repository.Context;
using Recipes.Repository.Domain;

namespace Recipes.Logic.Services
{
    public class AppService : IAppService
    {
        private readonly AppContext _context;
        public AppService(AppContext context)
        {
            _context = context;
        }

        public IEnumerable<RecipeDomain> GetAllRecipes()
        {
            return _context.Recipes.Where(x => x.IsDeleted == false);
        }

        public RecipeDomain GetSingle(long id)
        {
            return _context.Recipes.Where(x => x.id == id).FirstOrDefault();
        }

        public bool CreateNewRecipe(RecipeDomain model)
        {
            _context.Recipes.Add(model);
            _context.SaveChanges();
            return true;
        }

        public bool AddNewIngredient(IngredientDomain model)
        {
            _context.Ingredients.Add(model);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<IngredientDomain> GetAllIngredients()
        {
            return _context.Ingredients.Where(x => true);
        }

        public bool CreateTables()
        {
            _context.Database.EnsureCreated();
            return true;
        }
    }
}