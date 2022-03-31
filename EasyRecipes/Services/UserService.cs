using System;
using Firebase.Database;
using System.Linq;
using System.Threading.Tasks;
using EasyRecipes.Models;
using Firebase.Database.Query;

namespace EasyRecipes.Services
{
    public class UserService
    {
        FirebaseClient client;

        public UserService()
        {
            client = new FirebaseClient("https://recipeapp-5f1ff-default-rtdb.europe-west1.firebasedatabase.app/");
        }

        public async Task<bool> IsUserExists(string username)
        {
            var user = (await client.Child("Users").
                OnceAsync<User>()).Where(u => u.Object.Username == username).FirstOrDefault();

            return (user != null);
        }

        public async Task<bool> RegisterUser(string username, string password)
        {
            if (await IsUserExists(username) == false)
            {
                await client.Child("Users").
                    PostAsync(new User()
                    {
                        Username = username,
                        Password = password

                    });
                return true;
            }
            else
            {
                return false;
            }
        }
            
        public async Task<bool> LoginUser(string username, string password)
        {
            var user = (await client.Child("Users")
                .OnceAsync<User>()).Where(u => u.Object.Username == username)
                .Where(u => u.Object.Password == password).FirstOrDefault();
            return (user != null);
        }
   
    }
}
