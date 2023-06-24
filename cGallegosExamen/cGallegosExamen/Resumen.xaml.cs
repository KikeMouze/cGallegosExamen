using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cGallegosExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string apellido, int edad, string fecha,
            string ciudad, string pais, double monto, double pagoMensual, double pagoTotal)
        {
            InitializeComponent();

            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lbEdad.Text = edad.ToString();
            lblFecha.Text = fecha;
            lblCiudad.Text = ciudad;
            lblPais.Text = pais;
            lblMonto.Text = monto.ToString();
            lblPago.Text = pagoMensual.ToString();
            lblTotal.Text = pagoTotal.ToString();


        }

        private void btnLogina(object sender, EventArgs e)
        {
            lblNombre.Text = "";
            lblApellido.Text = "";
            lbEdad.Text = "";
            lblFecha.Text = "";
            lblCiudad.Text = "";
            lblPais.Text = "";
            lblMonto.Text = "";
            lblPago.Text = "";
            lblTotal.Text = "";
            Navigation.PushAsync(new Login());
        }
    }
}