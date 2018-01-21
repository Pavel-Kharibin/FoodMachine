using FoodMachine.Core.Bases;
using FoodMachine.Core.Interfaces;
using FoodMachine.Core.Model.Ingredients;

namespace FoodMachine.Core.Model.Dishes
{
    public class Espresso : DrinkBase, IIngredient, IMilkable
    {
        public Espresso()
        {
            Name = "Эспрессо";
        }

        #region Implementation of IMilkable

        public void AddMilk()
        {
            Ingredients.Add(new Milk());
        }

        #endregion
    }
}