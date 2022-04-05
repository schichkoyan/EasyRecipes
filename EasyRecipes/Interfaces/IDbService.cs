using System.Collections.Generic;

using EasyRecipes.Models;

namespace EasyRecipes.Interfaces
{
    public interface IDbService
    {
        List<Recipe> GetRecipesData();
    }
}
