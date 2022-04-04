using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using EasyRecipes.Models;
using EasyRecipes.Services;
using EasyRecipes.Views;
using EasyRecipes.Interfaces;

namespace EasyRecipes.ViewModels
{
    public class RecipesViewModel : BaseViewModel
    {
        private ObservableCollection<Recipe> recipes;

        private readonly SpoonacularService _spoonacularService;

        public ObservableCollection<Recipe> Recipes
        {
            get => recipes;
            set
            {
                recipes = value;
                OnPropertyChanged(nameof(Recipes));
            }
        }

        public RecipesViewModel(SpoonacularService spoonacularService)
        {
               _spoonacularService = spoonacularService;

                Recipes = new ObservableCollection<Recipe>();
            
        }
    }
}
