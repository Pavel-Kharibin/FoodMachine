using System;
using System.Windows.Forms;
using FoodMachine.App.Common.EventArgs;
using FoodMachine.Core.Bases;
using FoodMachine.Core.Enums;

namespace FoodMachine.App.Controls
{
    public partial class DishControl : UserControl
    {
        public DishControl()
        {
            InitializeComponent();
        }
        
        public DishControl(Type type) : this()
        {
            Type = type;

            var dish = CreateDish();

            DishType = dish.Type;

            rdoDish.Text = dish.Name;
            lblPrice.Text = $@"{dish.GetPrice()} р";

            rdoDish.Click += (sender, args) =>
            {
                OnDishSelected?.Invoke(this, new DishSelectedEventArgs(Type));
            };
        }

        public DishTypes DishType { get; }

        public Type Type { get; }

        public DishBase CreateDish()
        {
            return (DishBase) Activator.CreateInstance(Type);
        }

        public bool Selected
        {
            get => rdoDish.Checked;
            set => rdoDish.Checked = value;
        }

        public event EventHandler<DishSelectedEventArgs> OnDishSelected;
    }
}