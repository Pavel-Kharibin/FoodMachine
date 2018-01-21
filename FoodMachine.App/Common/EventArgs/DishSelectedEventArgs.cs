using System;

namespace FoodMachine.App.Common.EventArgs
{
    public class DishSelectedEventArgs
    {
        public DishSelectedEventArgs(Type dishType)
        {
            DishType = dishType;
        }

        public Type DishType { get; }
    }
}