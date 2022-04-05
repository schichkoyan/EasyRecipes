using Microsoft.Extensions.DependencyInjection;

using EasyRecipes.Interfaces;
using EasyRecipes.Services;
using EasyRecipes.ViewModels;
using EasyRecipes;

namespace ListviewExampleWithMVVM
{
    public static class DependencyInjectionContainer
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IDbService, RecipeDb>();

            return services;
        }

        public static IServiceCollection ConfigureMockServices(this IServiceCollection services)
        {
            //add your mocks.

            return services;
        }

        public static IServiceCollection ConfigureViewModels(this IServiceCollection services)
        {
            
            services.AddTransient<RecipesViewModel>();
            services.AddTransient<RecipeDetailsViewModel>();

            return services;
        }
    }
}
