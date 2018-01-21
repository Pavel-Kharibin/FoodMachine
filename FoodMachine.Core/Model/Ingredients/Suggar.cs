using FoodMachine.Core.Bases;
using FoodMachine.Core.Enums;
using FoodMachine.Core.Interfaces;

namespace FoodMachine.Core.Model.Ingredients
{
    public class Suggar : DishItemBase, IIngredient, IMultiIngredient
    {
        public Suggar()
        {
            Name = "Сахар";
            Type = DishTypes.Drink;
        }

        #region Implementation of IMultiIngredient

        public int Count { get; set; }

        #endregion
    }
}