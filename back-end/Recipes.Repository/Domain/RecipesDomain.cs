using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipes.Repository.Domain
{
    public class RecipesDomain
    {
        public string Name { get; set; }
        public string Instructions { get; set; }
        // TODO: navigation prop
        // public IEnumerable<Ingredient> Ingredients {get; set;}
        [Key]
        public long id { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public string ImageUrl { get; set; }
        public string Test { get; set; }
        public ICollection<IngredientDomain> Ingredients { get; set; }
    }
}