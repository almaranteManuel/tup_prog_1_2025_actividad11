namespace Ejercicio_4
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        int contador = 0;
        double[] valores = new double[100];

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            valores[contador] = Convert.ToDouble(tbValor.Text);
            contador++;

            tbValor.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int valorBuscado = Convert.ToInt32(tbBuscar.Text);
            int posicion = -1;
            int i = 0;

            while (i < contador && posicion == -1)
            {
                if (valores[i] == valorBuscado)
                {
                    posicion = i;
                }
                i++;
            }

            lsbResultado.Items.Clear();

            if (posicion != -1)
            {
                lsbResultado.Items.Add($"El valor {valorBuscado} se encuentra en la posición {posicion}");
            }
            else
            {
                lsbResultado.Items.Add("El valor no se encuentra");
            }

            tbBuscar.Clear();
        }

        private void btnCalcularPromedio_Click_1(object sender, EventArgs e)
        {
            double acumulador = 0;

            for (int i = 0; i < contador; i++)
            {
                acumulador += valores[i];
            }

            double promedio = 0;

            if (contador > 0)
            {
                promedio = 1.0 * acumulador / contador;
                lbResultado.Text = $"el promedio es: {promedio}";
            }
            
        }

    }
}
