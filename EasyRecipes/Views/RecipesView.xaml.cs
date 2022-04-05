using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using EasyRecipes.ViewModels;

using Xamarin.Forms;

namespace EasyRecipes.Views
{
    public partial class RecipesView : ContentPage
    {
        public RecipesView()
        {
            InitializeComponent();

            BindingContext = IocProvider.ServiceProvider.GetService<RecipesViewModel>();
        }

        private void LstProducts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var viewmodel = BindingContext as RecipesViewModel;
            viewmodel.GoToRecipeDetailsCommand.Execute(e.SelectedItem);
        }
    }
}
