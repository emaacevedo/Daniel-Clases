using System.Data;

namespace PRUEBA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {


            if (!decimal.TryParse(txtPrimerValor.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }

            if (!decimal.TryParse(txtSegundoValor.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal valor1 = 0;
            decimal valor2 = 0;
            decimal resultado = 0;

            valor1 = Convert.ToDecimal(txtPrimerValor.Text);
            valor2 = Convert.ToDecimal(txtSegundoValor.Text);

            // Evaluar la operación seleccionada en el ComboBox

            switch (Convert.ToInt32(cmbOperacion.SelectedValue))
            {
                case 1:
                    // Sumar
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    // Restar
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    // Multiplicar
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    // Dividir
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    resultado = valor1 / valor2;
                    break;
                case 5:
                    // Potencia
                    resultado = (decimal)Math.Pow((double)valor1, (double)valor2);
                    break;
                default:
                    MessageBox.Show("Operación no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Mostrar el resultado en mensaje
            MessageBox.Show("El resultado de la suma es: " + resultado.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));

            dt.Rows.Add(1, "suma");
            dt.Rows.Add(2, "resta");
            dt.Rows.Add(3, "multiplicacion");
            dt.Rows.Add(4, "division");

            // Asignar el DataTable como fuente de datos del ComboBox
            cmbOperacion.DataSource = dt;
            cmbOperacion.DisplayMember = "Nombre"; 
            cmbOperacion.ValueMember = "ID"; 

        }
    }
}
