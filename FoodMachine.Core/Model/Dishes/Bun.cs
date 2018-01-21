using FoodMachine.Core.Interfaces;
using FoodMachine.Core.Model.Ingredients;

namespace FoodMachine.Core.Model.Dishes
{
    public class Bun : Bread, IJamable
    {
        public Bun()
        {
            Name = "Булочка";
        }

        #region Implementation of IJamable

        public void AddJam()
        {
            Ingredients.Add(new Jam());
        }

        #endregion
    }
}