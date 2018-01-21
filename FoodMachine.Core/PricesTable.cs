using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FoodMachine.Core.Model.Dishes;
using FoodMachine.Core.Model.Ingredients;

namespace FoodMachine.Core
{
    // Для удобства, чтоб все цены видеть в одном месте.
    public static class PricesTable
    {
        public static ReadOnlyDictionary<Type, decimal> Prices = new ReadOnlyDictionary<Type, decimal>(
            new Dictionary<Type, decimal>
            {
                // Товары
                {typeof(BlackTea), 25},
                {typeof(Bread), 10},
                {typeof(Bun), 15},
                {typeof(Cappuccino), 0}, // Составной товар, своей цены не имеет, цена образуется из цен ингредиентов.
                {typeof(Chips), 34},
                {typeof(Cookies), 29},
                {typeof(Espresso), 50},
                {typeof(GreenTea), 25},
                {typeof(Latte), 0}, // Составной товар, своей цены не имеет, цена образуется из цен ингредиентов.
                {typeof(Water), 20},

                // Ингредиенты
                {typeof(Cheese), 10},
                {typeof(Ham), 15},
                {typeof(Jam), 7},
                {typeof(Milk), 10},
                {typeof(MilkyFoam), 10},
                {typeof(Suggar), 3},
                {typeof(Syrup), 5}
            });

        public static decimal Complex = 90;
    }
}