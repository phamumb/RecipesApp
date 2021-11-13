using System.ComponentModel;

namespace Recipes.Models.Enums
{
    public enum IngredientCategoryEnum
    {
        [Description("Fruits")]
        Fruits = 1,
        [Description("Herbs|Spices")]
        HerbsSpices = 2,
        [Description("Meats")]
        Meat = 3,
        [Description("Vegetables")]
        Vegetables = 4,
        [Description("Milk Products")]
        Milk = 5,
        [Description("Others")]
        Others = 20
    }
}