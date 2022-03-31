using Microsoft.Extensions.DependencyInjection;

using EasyRecipes.Interfaces;
using EasyRecipes.Services;
using EasyRecipes.ViewModels;

namespace ListviewExampleWithMVVM
{
    public static class DependencyInjectionContainer
    {
       
        public static IServiceCollection ConfigureMockServices(this IServiceCollection services)
        {
            //add your mocks.

            return services;
        }

        public static IServiceCollection ConfigureViewModels(this IServiceCollection services)
        {
            services.AddTransient<LoginViewModel>();


            return services;
        }
    }
}
