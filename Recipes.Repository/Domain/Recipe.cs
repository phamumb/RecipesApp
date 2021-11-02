using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recipes.Repository.Domain
{
    public class RecipeDomain
    {
        public string Name {get; set;}
        public string Instructions {get; set;}
        // TODO: navigation prop
        // public IEnumerable<Ingredient> Ingredients {get; set;}
        [Key]
        public long id {get; set;}
        public virtual ICollection<IngredientDomain> Ingredients {get; set;}
    }
}