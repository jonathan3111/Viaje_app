using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Viajes_app.ViewModels;

namespace Viajes_app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<LoginViewModel>(this, "LoginSucceeded", (sender) =>
            {
                // Inicio de sesión exitoso, puedes navegar a la página principal
                // o realizar cualquier otra acción necesaria.
                DisplayAlert("Éxito", "Inicio de sesión exitoso", "Aceptar");
                // Aquí deberías navegar a la página principal o realizar otras acciones.
            });

            MessagingCenter.Subscribe<LoginViewModel>(this, "LoginFailed", (sender) =>
            {
                // Inicio de sesión fallido
                DisplayAlert("Error", "Usuario o contraseña incorrectos", "Aceptar");
            });
        }

    }
}