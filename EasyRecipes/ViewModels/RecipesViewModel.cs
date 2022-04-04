using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using EasyRecipes.Models;
using EasyRecipes.Interfaces;

namespace EasyRecipes.ViewModels
{
    public class RecipesViewModel : LoginViewModel
    {
        private ObservableCollection<Recipe> recipes;

        private Recipe selectedRecipe;

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

        public Recipe SelectedRecipe
        {
            get => selectedRecipe;
            set
            {
                if (selectedRecipe != value)
                {
                    selectedRecipe = value;

                }
            }
        }

        public RecipesViewModel(SpoonacularService spoonacularService)
        {
            _spoonacularService = spoonacularService;

            Recipes = new ObservableCollection<Recipe>();

        }

        public async Task PopulateRecipes()
        {
            try
            {
                Recipes.Clear();

                var retrievedRecipes = await _spoonacularService.GetRecipes();
                foreach (var recipe in retrievedRecipes)
                {
                    Recipes.Add(recipe);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
