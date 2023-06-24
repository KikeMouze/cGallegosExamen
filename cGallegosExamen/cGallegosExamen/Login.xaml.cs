using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cGallegosExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string contraseña = "uisrael2023";
            bool isLogin = txtUsuario.Text == usuario && txtPassword.Text == contraseña ? true : false;

            if (!isLogin)
            {
                DisplayAlert("ERROR", "Usuario o Contraseña incorrectos", "Cancelar");
                return;
            }
            Navigation.PushAsync(new Registro(usuario));

        }
    }
}