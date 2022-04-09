using System;
using System.Windows.Input;
using EasyRecipes.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace EasyRecipes.ViewModels
{
    public class RecipeDetailsViewModel : BaseViewModel
    {
        private Recipe _recipeToShow;

        public Recipe RecipeToShow {

            get => _recipeToShow;

            set
            {
                _recipeToShow = value;
                OnPropertyChanged(nameof(RecipeToShow));
            }
        }

        public RecipeDetailsViewModel()
        {

        }

        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));


    }
}
