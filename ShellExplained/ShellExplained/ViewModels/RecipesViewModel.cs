using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Refit;
using ShellExplained.Model;
using ShellExplained.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShellExplained.ViewModels
{
    public class RecipesViewModel : BindableObject
    {
        private readonly IFoodService foodService;

        private List<Recipe> recipes;
        public List<Recipe> Recipes
        {
            get => recipes;
            set
            {
                recipes = value;
                OnPropertyChanged();
            }
        }

        public RecipesViewModel()
        {
            foodService = RestService.For<IFoodService>(KeyValues.FoodApiUri);            
        }

        public async Task LoadRecipes(string query)
        {
            var recipes = await foodService.GetRecipes(query, KeyValues.FoodApiKeyValue);


            var content = (recipes.Content as JContainer).SelectToken("recipes").ToObject<List<Recipe>>();

            Device.BeginInvokeOnMainThread(() =>
            {
                Recipes = new List<Recipe>(content);
            });
            
        }

        
    }
}
