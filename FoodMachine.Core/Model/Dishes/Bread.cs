using System.Linq;
using FoodMachine.Core.Bases;
using FoodMachine.Core.Interfaces;
using FoodMachine.Core.Model.Ingredients;

namespace FoodMachine.Core.Model.Dishes
{
    public class Bread : FoodBase, ICheesable, IHamable
    {
        public Bread()
        {
            Name = "Хлеб";
        }

        #region Implementation of ICheesable

        public void AddCheese()
        {
            Ingredients.Add(new Cheese());
        }

        #endregion

        #region Implementation of IHamable

        public void AddHam()
        {
            Ingredients.Add(new Ham());
        }

        #endregion

        public override string GetName()
        {
            return Ingredients.Any(i => i.GetType() == typeof(Ham) || i.GetType() == typeof(Cheese)) ? "Бутерброд" : Name;
        }
    }
}