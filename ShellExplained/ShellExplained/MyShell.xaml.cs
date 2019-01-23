using ShellExplained.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShellExplained
{
    public partial class MyShell : Shell
    {
        public MyShell()
        {
            InitializeComponent();
            BindingContext = this;

            RegisterViewsForNavigation();
        }

        private void RegisterViewsForNavigation()
        {
            Routing.RegisterRoute("recipedetail", typeof(RecipeDetailView));
        }
    }
}
