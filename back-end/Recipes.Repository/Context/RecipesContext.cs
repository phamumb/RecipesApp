using Microsoft.EntityFrameworkCore;
using Recipes.Repository.Domain;

namespace Recipes.Repository.Context
{
    public class AppContext : DbContext
    {
        public DbSet<RecipeDomain> Recipes { get; set; }
        public DbSet<IngredientDomain> Ingredients { get; set; }
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeDomain>(entity => {
                entity.HasKey(e => e.id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Instructions);
            });
            modelBuilder.Entity<IngredientDomain>(entity => {
                entity.HasKey(e => e.id);
                entity.Property(e => e.Unit);
            });
        }
    }
}