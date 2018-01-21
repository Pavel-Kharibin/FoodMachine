using FoodMachine.Core.Bases;
using FoodMachine.Core.Enums;
using FoodMachine.Core.Interfaces;

namespace FoodMachine.Core.Model.Ingredients
{
    public class Jam : DishItemBase, IIngredient
    {
        public Jam()
        {
            Name = "Джем";
            Type = DishTypes.Food;
        }
    }
}