using FoodMachine.Core.Bases;
using FoodMachine.Core.Enums;
using FoodMachine.Core.Interfaces;

namespace FoodMachine.Core.Model.Ingredients
{
    public class Cheese : DishItemBase, IIngredient
    {
        public Cheese()
        {
            Name = "Сыр";
            Type = DishTypes.Food;
        }
    }
}