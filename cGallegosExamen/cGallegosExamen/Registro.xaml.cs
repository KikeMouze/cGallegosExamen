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
    public partial class Registro : ContentPage
    {
        string usuario = null;
        double monto = 0.0;
        double pagoMensual = 0.0;
        double impuesto = 0.0;
        double pagoTotal = 0.0;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            usuario = usuario;
        }

      
  

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            monto = Convert.ToDouble(txtMontoMensual.Text);
            if (monto < 0 || monto >= 1500)
            {
                DisplayAlert("ERROR", "Monto No validos", "Cancelar");
                return;
            }
            impuesto = 1500 * 0.04;
            pagoMensual = ((1500 - monto) / 4) + impuesto;
            txtPagoMensual.Text = pagoMensual.ToString();
            pagoTotal = monto + (pagoMensual * 4);

        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            string fecha = startDatePicker.Date.ToShortDateString();
            string ciudad = pkrCiudad.Items[pkrCiudad.SelectedIndex];
            string pais = pkrPais.Items[pkrPais.SelectedIndex];

            Navigation.PushAsync(new Resumen(usuario, nombre, apellido, edad, fecha, ciudad, pais, monto, pagoMensual, pagoTotal));

        }
    }
}