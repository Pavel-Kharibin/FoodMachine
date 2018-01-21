using System.Windows.Forms;
using FoodMachine.App.Controls;
using FoodMachine.Core.Model;

namespace FoodMachine.App
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(Order order) : this()
        {
            var width = panelOrderItems.Width - panelOrderItems.Margin.All;

            foreach (var item in order)
            {
                var control = new OrderItemControl(item){Width = width};

                panelOrderItems.Controls.Add(control);
            }
        }
    }
}