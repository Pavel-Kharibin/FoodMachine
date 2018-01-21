using FoodMachine.Core.Enums;

namespace FoodMachine.Core.Bases
{
    public abstract class FoodBase : DishBase
    {
        protected FoodBase()
        {
            Type = DishTypes.Food;
        }
    }
}