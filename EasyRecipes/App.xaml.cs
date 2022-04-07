using System;

using EasyRecipes.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyRecipes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            IocProvider.Init();
            MainPage = new NavigationPage (new RecipesView());
            NavigationDispatcher.Instance.Initialize(MainPage.Navigation);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
