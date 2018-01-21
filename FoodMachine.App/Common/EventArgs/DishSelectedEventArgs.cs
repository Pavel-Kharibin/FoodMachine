using System;

namespace FoodMachine.App.Common.EventArgs
{
    public class DishSelectedEventArgs : System.EventArgs
    {
        public DishSelectedEventArgs(Type dishType)
        {
            DishType = dishType;
        }

        public Type DishType { get; }
    }
}