using FoodMachine.Core.Bases;

namespace FoodMachine.Core.Model
{
    public class OrderItem
    {
        public OrderItem(DishBase dish)
        {
            Dish = dish;
        }

        public DishBase Dish { get; }
    }
}