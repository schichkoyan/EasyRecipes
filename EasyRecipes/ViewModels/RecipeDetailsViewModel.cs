using EasyRecipes.Models;



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
    }
}
