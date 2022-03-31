using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using EasyRecipes.Interfaces;
using EasyRecipes.Models;

using Xamarin.Essentials;
using Xamarin.Forms;
using EasyRecipes.Services;
using EasyRecipes.Views;

namespace EasyRecipes.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _Username;
        private string _Password;
        private bool _IsBusy;
        private bool _Result;

        public string Username
        {
            get => _Username;
            set
            {
                _Username = value;
                OnPropertyChanged(Username);
            }
        }

        public string Password
        {
            get => _Password;
            set
            {
                _Password = value;
                OnPropertyChanged(Password);
            }
        }

        public bool IsBusy
        {
            get => _IsBusy;
            set
            {
                _IsBusy = value;
                OnPropertyChanged();
            }
        }

        public bool Result
        {
            get => _Result;
            set
            {
                _Result = value;
                OnPropertyChanged();
            }
        }

        public Command LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }


        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginCommandAsync());
            RegisterCommand = new Command(async () => await RegisterCommandAsync());

        }
        private async Task RegisterCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result = await userService.RegisterUser(Username, Password);
                if (Result)
                    await Application.Current.MainPage.DisplayAlert("Success", "User Registered", "OK");
                else
                    await Application.Current.MainPage.DisplayAlert("Error", "User already exist with this credentials", "OK");


            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task LoginCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result = await userService.LoginUser(Username, Password);
                if (Result)
                {
                    Preferences.Set("Username", Username);
                    await Application.Current.MainPage.Navigation.PushModalAsync(new RecipesView());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Invalid Username or Password", "OK");

                }

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }



        public override Task Initialise()
        {
            throw new NotImplementedException();
        }
    }
}
