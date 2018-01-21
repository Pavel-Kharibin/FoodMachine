using FoodMachine.Core.Bases;
using FoodMachine.Core.Interfaces;
using FoodMachine.Core.Model.Ingredients;

namespace FoodMachine.Core.Model.Dishes
{
    public class Latte : DrinkBase, IMilkable
    {
        public Latte()
        {
            Name = "Латте";

            Ingredients.Add(new Espresso());
            Ingredients.Add(new Milk());
        }

        #region Implementation of IMilkable

        public void AddMilk()
        {
            Ingredients.Add(new Milk());
        }

        #endregion
    }
}