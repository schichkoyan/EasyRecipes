using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using EasyRecipes.Interfaces;
using EasyRecipes.Models;

namespace EasyRecipes.Services
{
    public class Spoonacular : SpoonacularService
    {
        private readonly HttpClient _httpClient;

		public Spoonacular()
		{
#if DEBUG
			HttpClientHandler insecureHandler = GetInsecureHandler();
			_httpClient = new HttpClient(insecureHandler);
#else
	HttpClient _httpClient = new HttpClient();
#endif
			_httpClient.BaseAddress = new Uri("https://api.spoonacular.com/");
			_httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            

		}
        public async Task<IEnumerable<Recipe>> GetRecipes()
        {
            try
            {
				var response = await _httpClient.GetAsync("recipes/complexSearch");
                _httpClient.DefaultRequestHeaders.Add("api_key", "ac485b4a04ef4ec380fe12ba1b5748dc");
                if (response.IsSuccessStatusCode)
                {
					var responseAsString = await response?.Content?.ReadAsStringAsync();
					return JsonSerializer.Deserialize<IEnumerable<Recipe>>(responseAsString);
				}
            }
			catch (Exception e)
            {
				Debug.Fail(e.Message);
            }

			return new List<Recipe>();
		}

        public HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                if (cert.Issuer.Equals("CN=localhost"))
                    return true;
                return errors == System.Net.Security.SslPolicyErrors.None;
            };
            return handler;
        }
    }
}


	
