using FoodMachine.Core.Bases;
using FoodMachine.Core.Enums;
using FoodMachine.Core.Interfaces;

namespace FoodMachine.Core.Model.Ingredients
{
    public class Milk : DishItemBase, IIngredient
    {
        public Milk()
        {
            Name = "Молоко";
            Type = DishTypes.Drink;
        }
    }
}