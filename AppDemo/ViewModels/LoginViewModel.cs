using AppDemo.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppDemo.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public INavigation Navigation { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
           await Shell.Current.GoToAsync($"{nameof(AboutPage)}");
            //var navigation = new NavigationPage(new AboutPage());

            //App.Current.MainPage = navigation;
            //App.Current.
        }
    }
}
