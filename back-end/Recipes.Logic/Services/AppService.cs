using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Recipes.Infrastructure.Extensions;
using Recipes.Repository.Context;
using Recipes.Repository.Domain;

namespace Recipes.Logic.Services
{
    public class AppService : IAppService
    {
        private readonly Repository.Context.RecipesContext _context;
        public AppService(Repository.Context.RecipesContext context)
        {
            _context = context;
        }

        public IEnumerable<RecipesDomain> GetAllRecipes()
        {
            return _context.Recipes.Where(x => x.IsDeleted == false);
        }

        public IEnumerable<RecipesIngredientDomain> GetRecipesIngredients(long recipesId)
        {
            return _context.RecipesIngredients.Where(x => x.RecipesId == recipesId).Include(x => x.Ingredient).ToList();
        }

        public RecipesDomain GetSingleRecipes(long id)
        {
            return _context.Recipes.Where(x => x.id == id).FirstOrDefault();
        }

        public bool UpdateRecipes(RecipesDomain model)
        {
            _context.Recipes.Update(model);
            _context.SaveChanges();
            return true;
        }

        public bool CreateNewRecipes(RecipesDomain model)
        {
            _context.Recipes.Add(model);
            _context.SaveChanges();
            Console.WriteLine(model.id);
            return true;
        }

        public bool AddNewIngredient(IngredientDomain model)
        {
            _context.Ingredients.Add(model);
            _context.SaveChanges();
            return true;
        }

        public dynamic GetAllIngredients()
        {
            return _context.Ingredients.Where(x => true).AsEnumerable().GroupBy(x => x.Category).Select(x =>
            {
                return new
                {
                    Category = x.Key,
                    CategoryName = x.Key.GetEnumDescription(),
                    Ingredients = x.ToList()
                };
            });
        }

        public bool AddRecipesIngredients(IEnumerable<RecipesIngredientDomain> model)
        {
            foreach (var ingredient in model)
            {
                _context.RecipesIngredients.Add(ingredient);
                _context.SaveChanges();
            }
            return true;
        }

        public bool CreateTables()
        {
            _context.Database.EnsureCreated();
            return true;
        }

        public bool AddToCart(CartItemDomain model)
        {
            _context.CartDomain.Add(model);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<CartItemDomain> GetCartItems()
        {
            return _context.CartDomain.Where(x => x.IsDeleted == false).ToList();
        }
    }
}