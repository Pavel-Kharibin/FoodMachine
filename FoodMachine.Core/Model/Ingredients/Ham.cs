using FoodMachine.Core.Bases;
using FoodMachine.Core.Enums;
using FoodMachine.Core.Interfaces;

namespace FoodMachine.Core.Model.Ingredients
{
    public class Ham : DishItemBase, IIngredient
    {
        public Ham()
        {
            Name = "Ветчина";
            Type = DishTypes.Food;
        }
    }
}