using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Drawing;
using System.Numerics;
namespace Ejercicio_3
{
    //El botón registrar debe guardar el valor de tbValor en un vector de double de 100 elementos
    //El botón Calcular Promedio debe calcular y mostrar el promedio en lbResultado y tbResultado.
    //Para eso tiene que recorrer el vector para acumular los valores de este y luego así poder calcular el promedio
    public partial class FormPrincipal : Form
    {
        int contador = 0;
        double[] valores = new double[100];

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

                valores[contador] = Convert.ToDouble(tbValor.Text);
                contador++;

                tbValor.Clear();

        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double acumulador = 0;

            for (int i = 0; i < contador; i++)
            {
                acumulador += valores[i];
            }

            double promedio = 0;

            if (contador > 0)
            {
                promedio = acumulador / contador;
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
