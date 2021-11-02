using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipes.Repository.Domain
{
    public class IngredientDomain
    {
        [Key]
        public long id {get; set;}
        [ForeignKey("RecipeId")]
        public long RecipeId {get; set;}
        public string Amount {get; set;}
        public string Unit {get; set;}
    }
}