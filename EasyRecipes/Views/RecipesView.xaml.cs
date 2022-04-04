using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EasyRecipes.ViewModels;
using System.Diagnostics;

namespace EasyRecipes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class RecipesView : ContentPage
    {
        public RecipesView()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            BindingContext = IocProvider.ServiceProvider.GetService<RecipesViewModel>();
            try
            {
                await (BindingContext as RecipesViewModel).PopulateRecipes();
            }
            catch (Exception e)
            {
                Debug.Fail(e.Message);
            }

        }
    }
}
