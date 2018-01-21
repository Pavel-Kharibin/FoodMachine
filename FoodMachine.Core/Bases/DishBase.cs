using System.Collections.Generic;
using System.Linq;
using FoodMachine.Core.Interfaces;

namespace FoodMachine.Core.Bases
{
    public abstract class DishBase : DishItemBase
    {
        protected List<IIngredient> Ingredients { get; } = new List<IIngredient>();

        public virtual string GetName()
        {
            return Name;
        }

        public decimal GetPrice()
        {
            return Price + Ingredients.Select(i => i.Price).Sum();
        }

        public string GetIngredientsNames()
        {
            var ingredientGroups = Ingredients.GroupBy(i => i.GetType()).ToList();

            var names = new List<string>();

            if (!GetName().Equals(Name))
            {
                names.Add(Name);
            }

            foreach (var group in ingredientGroups)
            {
                var name = group.Cast<DishItemBase>().First().Name;
                var count = group.Count();

                names.Add($"{name}{(count > 1 ? $"[{count}]" : string.Empty)}");
            }

            var ingredientsNames = string.Join("+", names);

            return !string.IsNullOrWhiteSpace(ingredientsNames) ? $"{ingredientsNames}" : string.Empty;
        }

        #region Overrides of Object

        public override string ToString()
        {
            var ingredientsNames = GetIngredientsNames();

            return $"{GetName()} {(string.IsNullOrWhiteSpace(ingredientsNames) ? string.Empty : $" ({ingredientsNames})")}";
        }

        #endregion
    }
}