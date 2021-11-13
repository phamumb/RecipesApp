using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recipes.Repository.Domain
{
    public class RecipesIngredientDomain
    {
        [Key]
        public long id { get; set; }
        public string Amount { get; set; }
        public string Unit { get; set; }
        public long RecipesId { get; set; }
        public RecipesDomain Recipes { get; set; }
        public long IngredientId { get; set; }
        public IngredientDomain Ingredient { get; set; }
    }
}