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
                Description = "",
                URL = "https://youtu.be/3AAdKl1UYZs"
            });

            obProducts.Add(new Recipe
            {
                Image = "https://natashaskitchen.com/wp-content/uploads/2021/06/Smashed-Burgers-SQ.jpg",
                Name = "Smash Burger",
                Description = "",
                URL = "https://youtu.be/FQeIsqlwV88"

            });

            obProducts.Add(new Recipe
            {
                Image = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/steak-hache-66f0d36.jpg?quality=90&webp=true&resize=440,400",
                Name = "Steak with french fries and bernaise sauce",
                Description = "https://www.bbcgoodfood.com/recipes/steak-hache-pommes-frites-cheats-bearnaise-sauce",
                URL = "https://www.youtube.com/watch?v=9VxgatSjVQE"

            });

            obProducts.Add(new Recipe
            {
                Image = "https://salu-salo.com/wp-content/uploads/2018/10/Crispy-Salmon-with-Garlic-Lemon-Butter-Sauce-3.jpg",
                Name = "Salmon with Lemon and Butter sauce",
                Description = "",
                URL = "https://www.youtube.com/watch?v=-x2E7T3-r7k"
            });

            obProducts.Add(new Recipe
            {
                Image = "https://www.justonecookbook.com/wp-content/uploads/2020/01/Sushi-Rolls-Maki-Sushi-–-Hosomaki-1106-II.jpg",
                Name = "Sushi Rice and Maki",
                Description = "",
                URL = "https://www.youtube.com/watch?v=EGeNKGosXA8&t=186s"
            });



            obProducts.Add(new Recipe
            {
                Image = "https://i.ytimg.com/vi/NKtR3KpS83w/maxresdefault.jpg",
                Name = "The Perfect Risotto",
                Description = "",
                URL = "https://www.youtube.com/watch?v=NKtR3KpS83w"
            });

            obProducts.Add(new Recipe
            {
                Image = "https://www.thespruceeats.com/thmb/uALIO4N-VCYA5SXIguM_9sJfEnk=/3606x2352/filters:fill(auto,1)/IMG_5442-58b427d35f9b586046d8dfa1.JPG",
                Name = "Fish and Chips",
                Description = "",
                URL = "https://www.youtube.com/watch?v=HrNLvCO2tE4"
            });

            obProducts.Add(new Recipe
            {
                Image = "https://therecipecritic.com/wp-content/uploads/2022/01/teriyakichicken.jpg",
                Name = "Chicken Terryaki",
                Description = "",
                URL = "https://www.youtube.com/watch?v=jbRr01FqINo"
            });
            return obProducts;
        }
    }
}