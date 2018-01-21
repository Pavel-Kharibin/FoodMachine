using FoodMachine.Core.Bases;
using FoodMachine.Core.Interfaces;
using FoodMachine.Core.Model.Ingredients;

namespace FoodMachine.Core.Model.Dishes
{
    public class BlackTea : DrinkBase, ISyrupable, IMilkable
    {
        public BlackTea()
        {
            Name = "Чай черный";
        }

        #region Implementation of IMilkable

        public void AddMilk()
        {
            Ingredients.Add(new Milk());
        }

        #endregion

        #region Implementation of ISyrupable

        public void AddSyrup()
        {
            Ingredients.Add(new Syrup());
        }

        #endregion
    }
}