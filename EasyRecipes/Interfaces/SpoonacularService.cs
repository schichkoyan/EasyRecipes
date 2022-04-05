using System.Threading.Tasks;
using System.Collections.Generic;
using EasyRecipes.Models;

namespace EasyRecipes.Interfaces
{
    public interface ISpoonacularService
    {
        Task<IEnumerable<Recipe>> GetRecipes();
    }
}
