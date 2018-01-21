using System;
using System.Windows.Forms;
using FoodMachine.App.Common.EventArgs;
using FoodMachine.Core.Bases;
using FoodMachine.Core.Enums;
using FoodMachine.Core.Interfaces;

namespace FoodMachine.App.Controls
{
    public partial class IngredientControl : UserControl
    {
        public IngredientControl()
        {
            InitializeComponent();
        }

        public IngredientControl(Type type) : this()
        {
            Type = type;

            var ingredient = CreateIngredient();
            var dishItemBase = (DishItemBase) ingredient;

            DishType = dishItemBase.Type;

            lblPrice.Text = $@"{ingredient.Price} р";

            chkIngredient.Text = dishItemBase.Name;
            chkIngredient.Click += (sender, args) => { RaiseSelected(ingredient); };

            numCount.Visible = ingredient is IMultiIngredient;
            numCount.ValueChanged += (sender, args) =>
            {
                if (Selected) RaiseSelected(ingredient);
            };
        }

        public Type Type { get; }
        public DishTypes DishType { get; }

        public bool Selected
        {
            get => chkIngredient.Checked;
            set => chkIngredient.Checked = value;
        }

        public int Count
        {
            get => (int) numCount.Value;
            set => numCount.Value = value;
        }

        public IIngredient CreateIngredient()
        {
            var ingredient = (IIngredient) Activator.CreateInstance(Type);

            if (ingredient is IMultiIngredient multiIngredient)
            {
                multiIngredient.Count = (int) numCount.Value;
            }

            return ingredient;
        }

        public event EventHandler<IngredientSelectedEventArgs> OnIngredientSelected;

        private void RaiseSelected(IIngredient ingredient)
        {
            var count = 0;
            if (ingredient is IMultiIngredient)
            {
                count = (int) numCount.Value;
            }

            OnIngredientSelected?.Invoke(this, new IngredientSelectedEventArgs(Type, count));
        }
    }
}