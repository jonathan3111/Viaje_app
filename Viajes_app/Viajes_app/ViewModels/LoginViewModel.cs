using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Viajes_app.Views;

namespace Viajes_app.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string usuario;
        private string contraseña;

        public string Usuario
        {
            get { return usuario; }
            set { SetProperty(ref usuario, value); }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { SetProperty(ref contraseña, value); }
        }

        public ICommand IniciarSesionCommand { get; }

        public LoginViewModel()
        {
            IniciarSesionCommand = new Command(IniciarSesion);
        }

        private void IniciarSesion()
        {
            if (Usuario == "jonathan@gmail.com" && Contraseña == "123456")
            {
                // Inicio de sesión exitoso, navega a la página en blanco
                Application.Current.MainPage.Navigation.PushAsync(new Viajes_app.Views.cara());
            }
            else
            {
                // Inicio de sesión fallido
                MessagingCenter.Send(this, "LoginFailed");
            }
        }
    }
}