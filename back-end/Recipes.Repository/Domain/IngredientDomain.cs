using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Recipes.Models.Enums;

namespace Recipes.Repository.Domain
{
    public class IngredientDomain
    {
        [Key]
        public long id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Note { get; set; }
        public string Unit { get; set; }
        public string ImageUrl { get; set; }
        public IngredientCategoryEnum? Category { get; set; }
        public ICollection<RecipesDomain> Recipes { get; set; }
    }
}