using Microsoft.Extensions.DependencyInjection;

using EasyRecipes.Interfaces;
using EasyRecipes.Services;
using EasyRecipes.ViewModels;

namespace ListviewExampleWithMVVM
{
    public static class DependencyInjectionContainer
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<SpoonacularService, Spoonacular>();

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

            return services;
        }
    }
}
