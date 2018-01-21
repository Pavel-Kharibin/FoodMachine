using FoodMachine.Core.Bases;
using FoodMachine.Core.Interfaces;
using FoodMachine.Core.Model.Ingredients;

namespace FoodMachine.Core.Model.Dishes
{
    public class Cappuccino : DrinkBase, IMilkyFoamable
    {
        public Cappuccino()
        {
            Name = "Капучино";

            Ingredients.Add(new Espresso());
            Ingredients.Add(new Milk());
            Ingredients.Add(new MilkyFoam());
        }

        #region Implementation of IMilkyFoamable

        public void AddMilkyFoam()
        {
            Ingredients.Add(new MilkyFoam());
        }

        #endregion
    }
}