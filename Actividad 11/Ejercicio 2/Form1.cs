using System.Diagnostics.Metrics;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_2
{
    //El botón btRegistrar debe acumular y contar un valor
    //El botón btCalcularPromedio debe calcular y mostrar el promedio en la propiedad Text tanto del control
    //lbResultado como en el control tbResultado
    public partial class FormPrincipal : Form
    {

        int contador = 0;
        double acumulador = 0;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            acumulador += Convert.ToDouble(tbValor.Text);
            contador++;

            tbValor.Clear();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double promedio = 0;

            if (contador > 0)
            {
                promedio = 1.0*acumulador / contador;
                lbResultado.Text = $"{promedio}";
                tbResultado.Text = $"{promedio}";
            }
            else
            {
                lbResultado.Text = "No se han registrado valores.";
                tbResultado.Clear();
            }
        }

    }
}
