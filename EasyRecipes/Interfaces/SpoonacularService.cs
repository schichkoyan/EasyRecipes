using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using EasyRecipes.Models;

namespace EasyRecipes.Interfaces
{
    public interface SpoonacularService
    {
        Task<IEnumerable<Recipe>> GetRecipes();
    }
}
