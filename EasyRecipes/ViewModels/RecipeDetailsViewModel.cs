using System.Threading.Tasks;
using EasyRecipes.Models;
using EasyRecipes.ViewModels;

namespace EasyRecipes
{
    public class RecipeDetailsViewModel : BaseViewModel
    {
        private Recipe _recipeToShow;
        public Recipe RecipeToShow {
            get => _recipeToShow;

            set
            {
                _recipeToShow = value;
                OnPropertyChanged(nameof(Recipe));
            }
        }

        public RecipeDetailsViewModel()
        {

        }

        public override Task Initialise()
        {
            throw new System.NotImplementedException();
        }
    }
}
