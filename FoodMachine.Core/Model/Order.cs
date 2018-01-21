using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FoodMachine.Core.Bases;

namespace FoodMachine.Core.Model
{
    public class Order : IEnumerable<OrderItem>
    {
        private readonly List<OrderItem> _orderItems = new List<OrderItem>();
        private readonly decimal _price;

        public Order(decimal price = 0)
        {
            _price = price;
        }

        public IEnumerable<OrderItem> Items => _orderItems;

        public void AddDish(DishBase dish)
        {
            _orderItems.Add(new OrderItem(dish));
        }

        public decimal GetPrice()
        {
            return _price == 0 ? _orderItems.Select(i => i.Dish.GetPrice()).Sum() : _price;
        }

        #region Overrides of Object

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in this)
            {
                sb.AppendLine(item.Dish.ToString());
            }

            return sb.ToString();
        }

        #endregion

        #region Implementation of IEnumerable

        public IEnumerator<OrderItem> GetEnumerator()
        {
            return _orderItems.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}