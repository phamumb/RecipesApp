using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipes.Repository.Domain
{
    public class IngredientDomain
    {
        [Key]
        public long id { get; set; }
        [ForeignKey("RecipeId")]
        public string Name { get; set; }
        public string Location { get; set; }
        public string Note { get; set; }
        public string Unit { get; set; }
        public string ImageUrl {get; set;}
    }
}