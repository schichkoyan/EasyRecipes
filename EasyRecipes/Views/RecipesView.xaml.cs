using System;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms;
using EasyRecipes.ViewModels;
using System.Diagnostics;

namespace EasyRecipes.Views
{

    public partial class RecipesView : ContentPage
    {
        public RecipesView()
        {
            
            InitializeComponent();
            BindingContext = IocProvider.ServiceProvider.GetService<RecipesViewModel>();
            SubscribeToEvents();

        }
        private void SubscribeToEvents()
        {
            Appearing += RecipesView_Appearing;
        }

        private async void RecipesView_Appearing(object sender, EventArgs e)
        {
            try
            {
                await (BindingContext as RecipesViewModel).Initialise();
            }
            catch (Exception error)
            {
                Debug.Fail(error.Message); //handle gracefully here
            }
        }
    }
}

