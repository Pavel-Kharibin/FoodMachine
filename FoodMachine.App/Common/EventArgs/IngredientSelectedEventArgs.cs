using System;

namespace FoodMachine.App.Common.EventArgs
{
    public class IngredientSelectedEventArgs : System.EventArgs
    {
        public IngredientSelectedEventArgs(Type ingredientType, int count)
        {
            IngredientType = ingredientType;
            Count = count;
        }

        public Type IngredientType { get; }
        public int Count { get; }
    }
}