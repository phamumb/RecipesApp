using Microsoft.EntityFrameworkCore;
using Recipes.Repository.Domain;

namespace Recipes.Repository.Context
{
    public class RecipesContext : DbContext
    {
        public DbSet<RecipesDomain> Recipes { get; set; }
        public DbSet<IngredientDomain> Ingredients { get; set; }
        public DbSet<RecipesIngredientDomain> RecipesIngredients { get; set; }
        public DbSet<CartItemDomain> CartDomain { get; set; }
        public RecipesContext(DbContextOptions<RecipesContext> options) : base(options)
        {
        }


    }
}