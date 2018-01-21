using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using FoodMachine.App.Controls;
using FoodMachine.Core;
using FoodMachine.Core.Bases;
using FoodMachine.Core.Enums;
using FoodMachine.Core.Interfaces;
using FoodMachine.Core.Model;
using FoodMachine.Core.Model.Dishes;
using FoodMachine.Core.Model.Ingredients;

namespace FoodMachine.App
{
    public partial class MainForm : Form
    {
        private readonly List<DishControl> _dishesControls = new List<DishControl>();
        private readonly List<IngredientControl> _ingredientsControls = new List<IngredientControl>();

        private readonly Dictionary<DishTypes, DishControl> _selectedDishControls = new Dictionary<DishTypes, DishControl>();
        private Order _order;

        public MainForm()
        {
            InitializeComponent();
            Load += (sender, args) => { Init(); };
        }

        private void Init()
        {
            btnGiveMe.Click += (sender, args) =>
            {
                var form = new OrderForm(_order);
                form.ShowDialog(this);

                Reset();
            };

            lblComplexPrice.Text = $@"{PricesTable.Complex.ToString(CultureInfo.InvariantCulture)} р";

            chkComplex.CheckedChanged += (sender, args) =>
            {
                if (!chkComplex.Checked) return;

                foreach (var control in _ingredientsControls)
                {
                    control.Selected = false;
                }

                CalculateOrder();
            };

            var width = pnlDrinks.Width - pnlDrinks.Margin.All;
            foreach (var dish in _dishes)
            {
                FlowLayoutPanel panel;
                switch (dish.Type)
                {
                    case DishTypes.Drink:
                        panel = pnlDrinks;
                        break;
                    case DishTypes.Food:
                        panel = pnlFood;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                var control = new DishControl(dish.GetType()) {Width = width};
                control.OnDishSelected += (sender, args) =>
                {
                    var selectedDishControl = (DishControl) sender;
                    _selectedDishControls[selectedDishControl.DishType] = selectedDishControl;
                    
                    ResetDishSelection(selectedDishControl);
                    CheckIngredients(selectedDishControl);
                    CalculateOrder();

                    btnGiveMe.Enabled = true;
                };

                panel.Controls.Add(control);

                _dishesControls.Add(control);
            }

            foreach (var ingredient in _ingredients)
            {
                var disgBase = (DishItemBase) ingredient;

                Panel panel;

                switch (disgBase.Type)
                {
                    case DishTypes.Drink:
                        panel = pnlDrinksIngrediens;
                        break;
                    case DishTypes.Food:
                        panel = pnlFoodIngredients;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                var control = new IngredientControl(ingredient.GetType())
                {
                    Width = width,
                    Enabled = false
                };
                control.OnIngredientSelected += (sender, args) =>
                {
                    if (chkComplex.Checked)
                    {
                        var applicableIngredients = GetIngredientsControls(control.DishType);
                        foreach (var ingredientControl in applicableIngredients.Except(new[] {(IngredientControl) sender}))
                        {
                            ingredientControl.Selected = false;
                        }
                    }

                    CalculateOrder();
                };

                panel.Controls.Add(control);

                _ingredientsControls.Add(control);
            }

            Reset();
        }

        private void Reset()
        {
            _dishesControls.ForEach(c => c.Selected = false);
            _ingredientsControls.ForEach(c =>
            {
                c.Selected = false;
                c.Count = 1;
                c.Enabled = false;
            });

            chkComplex.Checked = false;
            lblPrice.Text = @"Выеберите товар";

            foreach (var key in _selectedDishControls.Keys.ToList())
            {
                _selectedDishControls[key] = null;
            }

            btnGiveMe.Enabled = false;
        }

        private void ResetDishSelection(DishControl selectedDishControl)
        {
            var controls = _dishesControls.Except(new[] {selectedDishControl});
            foreach (var dishControl in controls.Where(c => c.DishType == selectedDishControl.DishType))
            {
                dishControl.Selected = false;
            }
        }

        private void CheckIngredients(DishControl selectedDishControl)
        {
            var sameTypeIngredientsControls = GetIngredientsControls(selectedDishControl.DishType);

            foreach (var control in sameTypeIngredientsControls)
            {
                control.Selected = false;
                control.Enabled = false;
            }

            foreach (var map in _ingridientsMap)
            {
                if (!map.Key.IsAssignableFrom(selectedDishControl.Type)) continue;

                var applicableIntgedientControl =
                    sameTypeIngredientsControls.FirstOrDefault(c => c.Type == map.Value);

                if (applicableIntgedientControl != null) applicableIntgedientControl.Enabled = true;
            }
        }

        private IEnumerable<IngredientControl> GetIngredientsControls(DishTypes dishType)
        {
            return _ingredientsControls.Where(c => c.DishType == dishType).ToList();
        }

        private void CalculateOrder()
        {
            _order = new Order(chkComplex.Checked ? PricesTable.Complex : 0);

            foreach (var selectedDishControl in _selectedDishControls)
            {
                if (selectedDishControl.Value == null) continue;
                var dishControl = selectedDishControl.Value;

                var ingredientControls = GetIngredientsControls(selectedDishControl.Key);
                var selectedIngredientsControls = ingredientControls.Where(c => c.Selected).ToList();

                var dish = dishControl.CreateDish();

                foreach (var map in _ingridientsMap)
                {
                    if (!map.Key.IsAssignableFrom(dishControl.Type)) continue;

                    var applicableIntgedientControl = selectedIngredientsControls.FirstOrDefault(c => c.Type == map.Value);

                    if (applicableIntgedientControl == null) continue;

                    var ingredient = applicableIntgedientControl.CreateIngredient();
                    var ingredientsCount = 1;
                    if (ingredient is IMultiIngredient multiIngredient)
                    {
                        ingredientsCount = multiIngredient.Count;
                    }

                    for (var i = 0; i < ingredientsCount; i++)
                    {
                        _addIngredienActions[map.Key](dish);
                    }
                }

                _order.AddDish(dish);
            }

            lblPrice.Text = $@"Стоимось: {_order.GetPrice()}";
        }

        #region Mappings

        private readonly Dictionary<Type, Action<DishBase>> _addIngredienActions =
            new Dictionary<Type, Action<DishBase>>
            {
                {typeof(ICheesable), dish => { ((ICheesable) dish).AddCheese(); }},
                {typeof(IHamable), dish => { ((IHamable) dish).AddHam(); }},
                {typeof(IJamable), dish => { ((IJamable) dish).AddJam(); }},
                {typeof(IMilkable), dish => { ((IMilkable) dish).AddMilk(); }},
                {typeof(IMilkyFoamable), dish => { ((IMilkyFoamable) dish).AddMilkyFoam(); }},
                {typeof(ISuggarable), dish => { ((ISuggarable) dish).AddSuggar(); }},
                {typeof(ISyrupable), dish => { ((ISyrupable) dish).AddSyrup(); }}
            };

        private readonly Dictionary<Type, Type> _ingridientsMap = new Dictionary<Type, Type>
        {
            {typeof(ICheesable), typeof(Cheese)},
            {typeof(IHamable), typeof(Ham)},
            {typeof(IJamable), typeof(Jam)},
            {typeof(IMilkable), typeof(Milk)},
            {typeof(IMilkyFoamable), typeof(MilkyFoam)},
            {typeof(ISuggarable), typeof(Suggar)},
            {typeof(ISyrupable), typeof(Syrup)}
        };

        #endregion

        #region Data

        private readonly List<DishBase> _dishes = new List<DishBase>
        {
            new Water(),
            new Espresso(),
            new Latte(),
            new Cappuccino(),
            new BlackTea(),
            new GreenTea(),
            new Bread(),
            new Bun(),
            new Chips(),
            new Cookies()
        };

        private readonly List<IIngredient> _ingredients = new List<IIngredient>
        {
            new Milk(),
            new MilkyFoam(),
            new Syrup(),
            new Suggar(),
            new Cheese(),
            new Ham(),
            new Jam()
        };

        #endregion
    }
}