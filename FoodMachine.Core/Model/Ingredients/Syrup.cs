using FoodMachine.Core.Bases;
using FoodMachine.Core.Enums;
using FoodMachine.Core.Interfaces;

namespace FoodMachine.Core.Model.Ingredients
{
    public class Syrup : DishItemBase, IIngredient
    {
        public Syrup()
        {
            Name = "Сироп";
            Type = DishTypes.Drink;
        }
    }
}