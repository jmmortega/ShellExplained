using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ShellExplained
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            AddStyles();

            MainPage = new MyShell();
        }

        private void AddStyles()
        {
            var collectionViewStyles = new Styles.CollectionViewStyles();

            foreach(var resource in collectionViewStyles.Resources)
            {
                Resources.Add(resource.Key, resource.Value);
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
