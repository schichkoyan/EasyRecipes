using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms;
using EasyRecipes.ViewModels;
using EasyRecipes.Models;

namespace EasyRecipes.Views
{
    public partial class RecipeDetailsView : ContentPage
    {
        public RecipeDetailsView()
        {
            InitializeComponent();
            BindingContext = Startup.ServiceProvider.GetService<RecipeDetailsViewModel>();

            var viewmodel = BindingContext as RecipeDetailsViewModel;

            if (viewmodel != null)
            {
                viewmodel.RecipeToShow = recipeToShow;

            }
        }
    }
}
