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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private async void registerbuttonClicked(object sender, EventArgs e)
        {
            Nuser user = new Nuser(nameEntry.Text, emailEntry.Text, passwordEntry.Text, passwordconfirmEntry.Text);

            if (user.CheckNinfo())
            {
                await DisplayAlert("Registro Exitoso", "Ha sido agregado  " + nameEntry.Text, "OK");
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Error", "El Registro ha fallado los parametros Name, Email, Password y la confirmacion no pueden estar vacio", "OK");
                await Navigation.PushAsync(new RegisterPage());
            }

            if (passwordEntry.Text != passwordconfirmEntry.Text)
            {
                await DisplayAlert("Error", "El Password debe ser el mismo a la confirmacion", "OK");
            }
        }
    }
}