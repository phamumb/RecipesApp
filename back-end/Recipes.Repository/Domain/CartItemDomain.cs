using System.ComponentModel.DataAnnotations;

namespace Recipes.Repository.Domain
{
    public class CartItemDomain
    {
        [Key]
        public long? Key { get; set; }
        public long? Quantity { get; set; }
        public long IngredientId { get; set; }
        public bool? IsDeleted { get; set; }
        public IngredientDomain Ingredient { get; set; }
    }
}