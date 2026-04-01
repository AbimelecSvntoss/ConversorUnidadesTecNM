namespace ConversorUnidadesTecNM
{
    public partial class Form1 : Form
    {
        // Instancia de clase
        CalculadoraMotor motor = new CalculadoraMotor();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCantidad.Text, out double pesos))
            {
                string monedaDestino = cmbOpcion.Text;
                double resultado;

                if (monedaDestino == "Euros")
                {
                    resultado = motor.Convertir(pesos, "Euro");
                    lblResultado.Text = $"Resultado: {resultado:N2} EUR";
                }
                else
                {
                    resultado = motor.Convertir(pesos);
                    lblResultado.Text = $"Resultado: {resultado:N2} USD";
                }
            }
        }
    }
}