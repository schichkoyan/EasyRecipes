using System.Collections.Generic;
using EasyRecipes.Interfaces;
using EasyRecipes.Models;


namespace EasyRecipes.Services
{
    public class RecipeDb : IDbService
    {
        public RecipeDb()
        {

        }

        public List<Recipe> GetRecipesData()
        {
            var obProducts = new List<Recipe>();

            obProducts.Add(new Recipe
            {
                Image = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/recipe-image-legacy-id-1001491_11-2e0fa5c.jpg",
                Name = "Pasta Carbonara",
                Description = "https://www.bbcgoodfood.com/recipes/ultimate-spaghetti-carbonara-recipe"
            });

            obProducts.Add(new Recipe
            {
                Image = "https://natashaskitchen.com/wp-content/uploads/2021/06/Smashed-Burgers-SQ.jpg",
                Name = "Smash Burger",
                Description = "https://natashaskitchen.com/smash-burger-recipe/"
            });

            obProducts.Add(new Recipe
            {
                Image = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/steak-hache-66f0d36.jpg?quality=90&webp=true&resize=440,400",
                Name = "Steak with french fries and bernaise sauce",
                Description = "https://www.bbcgoodfood.com/recipes/steak-hache-pommes-frites-cheats-bearnaise-sauce"
            });

            obProducts.Add(new Recipe
            {
                Image = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/recipe-image-legacy-id-1001491_11-2e0fa5c.jpg",
                Name = "Pasta Carbonara",
                Description = "https://www.bbcgoodfood.com/recipes/ultimate-spaghetti-carbonara-recipe"
            });

            obProducts.Add(new Recipe
            {
                Image = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/recipe-image-legacy-id-1001491_11-2e0fa5c.jpg",
                Name = "Pasta Carbonara",
                Description = "https://www.bbcgoodfood.com/recipes/ultimate-spaghetti-carbonara-recipe"
            });



            obProducts.Add(new Recipe
            {
                Image = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/recipe-image-legacy-id-1001491_11-2e0fa5c.jpg",
                Name = "Pasta Carbonara",
                Description = "https://www.bbcgoodfood.com/recipes/ultimate-spaghetti-carbonara-recipe"
            });

            obProducts.Add(new Recipe
            {
                Image = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/recipe-image-legacy-id-1001491_11-2e0fa5c.jpg",
                Name = "Pasta Carbonara",
                Description = "https://www.bbcgoodfood.com/recipes/ultimate-spaghetti-carbonara-recipe"
            });

            obProducts.Add(new Recipe
            {
                Image = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/recipe-image-legacy-id-1001491_11-2e0fa5c.jpg",
                Name = "Pasta Carbonara",
                Description = "https://www.bbcgoodfood.com/recipes/ultimate-spaghetti-carbonara-recipe"
            });
            return obProducts;
        }
    }
}