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
	public partial class RecipesListView : ContentPage
	{
        private RecipesViewModel viewModel = new RecipesViewModel();
        public RecipesListView ()
		{
			InitializeComponent ();
            BindingContext = viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.LoadRecipes(Title);            
        }
    }
}