using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;



using Xamarin.Forms;
using EasyRecipes.Models;
using EasyRecipes.ViewModels;

namespace EasyRecipes.Views
{
    public partial class RecipeDetailsView : ContentPage
    {
        public RecipeDetailsView(Recipe recipeToShow)
        {
            InitializeComponent();
            BindingContext = IocProvider.ServiceProvider.GetService<RecipeDetailsViewModel>();

            var viewmodel = BindingContext as RecipeDetailsViewModel;

            if (viewmodel != null)
            {
                viewmodel.RecipeToShow = recipeToShow;
            }

        }
    }
}
