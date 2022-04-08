using System.Collections.ObjectModel;
using EasyRecipes.Interfaces;
using EasyRecipes.Models;
using EasyRecipes.Views;
using Xamarin.Forms;


namespace EasyRecipes.ViewModels
{
    public class RecipesViewModel : BaseViewModel
    {
        public Recipe SelectedItem { get; set; }

        public ObservableCollection<Recipe> ObProducts { get; set; }

        public Command GoToRecipeDetailsCommand { get; set; }

        private readonly IDbService _recipeService;



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
            var pageToNavigate = new RecipeDetailsView(recipeToNavigateTo);

            NavigationDispatcher.Instance.Navigation.PushAsync(pageToNavigate);
        }

        
    }
}