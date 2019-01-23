using Refit;
using ShellExplained.Services;
using ShellExplained.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellExplained.Views
{
    //[QueryProperty("TypeID", "id")]
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipeDetailView : ContentPage
	{
        private readonly IFoodService foodService;


        public string TypeID { get; set; }

        public RecipeDetailView ()
		{
			InitializeComponent ();
            BindingContext = this;

            foodService = RestService.For<IFoodService>(KeyValues.FoodApiUri);
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var recipeDetail = await foodService.GetRecipeDetail(TypeID, KeyValues.FoodApiKeyValue);            
        }


    }
}