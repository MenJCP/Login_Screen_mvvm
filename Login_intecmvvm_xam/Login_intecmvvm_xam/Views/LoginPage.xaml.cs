using Login_intecmvvm_xam.Models;
using Login_intecmvvm_xam.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_intecmvvm_xam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private async void loginbuttonClicked(object sender, EventArgs e)
        {
            User user = new User(emailEntry.Text, passwordEntry.Text);
            if (user.CheckInfo())
            {
                await DisplayAlert("Login Exitoso", "Bienvenido " + emailEntry.Text, "OK");
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Error", "El Login ha fallado: Email o Password vacio", "OK", "Cancelar");
            }
        }

        private async void registerbuttonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}