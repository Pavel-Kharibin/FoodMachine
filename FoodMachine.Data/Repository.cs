using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using FoodMachine.Core.Bases;
using FoodMachine.Core.Model;
using Newtonsoft.Json;

namespace FoodMachine.Data
{
    public class Repository
    {
        private readonly string _currentPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        private const string DataFolder = "Data";
        private const string BackupFolder = "Data\\Backup";
        private const string DishesFileName = "dishes.json";
        private const string IngredientsFileName = "ingredients.json";
        private const string RecipesFileName = "recipes.json";

        private IEnumerable<Dish> Dishes { get; set; }
        private IEnumerable<Ingredient> Ingredients { get; set; }
        private IEnumerable<Recipe> Recipes { get; set; }

        public async Task<IEnumerable<Dish>> GetDishesAsync()
        {
            return Dishes ?? (Dishes = await LoadData<Dish>(DishesFileName));
        }

        public async Task<IEnumerable<Ingredient>> GetIngredientsAsync()
        {
            return Ingredients ?? (Ingredients = await LoadData<Ingredient>(IngredientsFileName));
        }

        public async Task<IEnumerable<Recipe>> GetRecipesAsync()
        {
            return Recipes ?? (Recipes = await LoadData<Recipe>(RecipesFileName));
        }

        public async Task SaveAsync() { }

        private async Task<IEnumerable<T>> LoadData<T>(string fileName)
        {
            return await Task<IEnumerable<T>>.Factory.StartNew(() =>
            {
                IEnumerable<T> data;
                try
                {
                    data = DeserializeData<T>(fileName);
                    return data;
                }
                catch
                {
                    RestoreData();
                }
                finally
                {
                    data = DeserializeData<T>(fileName);
                }

                return data;
            });
        }

        private IEnumerable<T> DeserializeData<T>(string fileName)
        {
            var fileContent = GetFileContent(fileName);
            return JsonConvert.DeserializeObject<IEnumerable<T>>(fileContent);
        }

        private void RestoreData()
        {

        }

        private void BackupData()
        {

        }

        private string GetFileContent(string fileName)
        {
            var dataPath = Path.Combine(_currentPath, DataFolder, fileName);

            return File.ReadAllText(dataPath);
        }
    }
}