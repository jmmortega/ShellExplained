using ShellExplained.Model;
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
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipesGridView : ContentPage
	{
        private RecipesViewModel viewModel = new RecipesViewModel();
        public RecipesGridView ()
		{
			InitializeComponent ();
            BindingContext = viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.LoadRecipes(Title);
            
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var recipe = (Recipe)e.CurrentSelection.FirstOrDefault();

            if(recipe != null)
            {
                //(App.Current.MainPage as MyShell).GoToAsync(new ShellNavigationState($"app://shellexplained/recipedetail?id={recipe.Id}"), true);                                
                (App.Current.MainPage as MyShell).GoToAsync(new ShellNavigationState($"app://shellexplained/recipedetail"), true);
            }
        }
    }
}