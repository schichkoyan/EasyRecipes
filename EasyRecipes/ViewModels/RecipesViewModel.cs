using System.Collections.ObjectModel;
using System.Threading.Tasks;
using EasyRecipes.Interfaces;
using EasyRecipes.Models;
using Xamarin.Forms;

namespace EasyRecipes.ViewModels
{
    public class RecipesViewModel : BaseViewModel
    {
        public Recipe SelectedItem { get; set; }

        public ObservableCollection<Recipe> ObProducts { get; set; }

        public Command GoToRecipeDetailsCommand { get; set; }

        private IDbService _recipeService;



        public RecipesViewModel(IDbService recipeService)
        {
            _recipeService = recipeService;

            GoToRecipeDetailsCommand = new Command<Recipe>(NavigateToRecipesDetails);

            GetRecipesData();
        }


        public void GetRecipesData()
        {
            ObProducts = new ObservableCollection<Recipe>();

            var items = _recipeService.GetRecipesData();
            foreach (var item in items)
            {
                ObProducts.Add(item);
            }
        }


        private void NavigateToRecipesDetails(Recipe recipeToNavigateTo)
        {
            var pageToNavigate = new RecipesDetailsView(recipeToNavigateTo);
            NavigationDispatcher.Instance.Navigation.PushAsync(pageToNavigate);
        }

        public override Task Initialise()
        {
            throw new System.NotImplementedException();
        }
    }
}