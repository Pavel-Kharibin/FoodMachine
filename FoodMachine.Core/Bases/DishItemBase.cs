using FoodMachine.Core.Enums;

namespace FoodMachine.Core.Bases
{
    public abstract class DishItemBase
    {
        protected DishItemBase()
        {
            Price = PricesTable.Prices[GetType()];
        }

        /// <summary>
        ///     Название товара
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        ///     Тип товара или для какого типа добавка.
        /// </summary>
        public DishTypes Type { get; protected set; }

        /// <summary>
        ///     Цена товара или добавки
        /// </summary>
        public decimal Price { get; protected set; }
    }
}