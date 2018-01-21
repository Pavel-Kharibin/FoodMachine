using FoodMachine.Core.Enums;
using FoodMachine.Core.Interfaces;
using FoodMachine.Core.Model.Ingredients;

namespace FoodMachine.Core.Bases
{
    public abstract class DrinkBase : DishBase, ISuggarable
    {
        protected DrinkBase()
        {
            Type = DishTypes.Drink;
        }

        #region Implementation of ISuggarable

        public void AddSuggar()
        {
            Ingredients.Add(new Suggar());
        }

        #endregion
    }
}