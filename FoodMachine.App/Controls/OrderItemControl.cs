using System.Windows.Forms;
using FoodMachine.Core.Model;

namespace FoodMachine.App.Controls
{
    public partial class OrderItemControl : UserControl
    {
        public OrderItemControl()
        {
            InitializeComponent();
        }

        public OrderItemControl(OrderItem item): this()
        {
            lblName.Text = item.Dish.GetName();
            var ingredients = item.Dish.GetIngredientsNames();
            lblIngredients.Text = $@"{(string.IsNullOrWhiteSpace(ingredients) ? string.Empty : $"({ingredients})")}";
        }
    }
}