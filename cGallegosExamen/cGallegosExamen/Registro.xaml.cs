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
    public partial class Registro : ContentPage
    {
        string usuario;

        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "usuario conectado" + " " + "es" + " " + usuario;
            this.usuario = usuario;

        }

    
     

        private void btnResumir_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resumen(usuario));
        }

        private void btnCalcularPM_Clicked_1(object sender, EventArgs e)
        {
            double saldo = Convert.ToDouble(txtMonto.Text);
            double pagoInicial = saldo;
            double saldoRestante = 1500 - saldo;
            double cuotaMensual = (saldoRestante / 4) * 1.04; 

            double pagoTotal = pagoInicial + cuotaMensual * 4;
            txtPago.Text = pagoTotal.ToString();
        }
    }
    }
}