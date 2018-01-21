using FoodMachine.Core.Bases;
using FoodMachine.Core.Enums;
using FoodMachine.Core.Interfaces;

namespace FoodMachine.Core.Model.Ingredients
{
    public class MilkyFoam : DishItemBase, IIngredient
    {
        public MilkyFoam()
        {
            Name = "Молочная пенка";
            Type = DishTypes.Drink;
        }
    }
}