using PRUEBA.Clases.Funcionalidades;
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
            try
            {
                decimal n1 = 0;
                decimal n2 = 0;
                decimal resultado = 0;
                Funcionalidades modelo = new Funcionalidades();

                if (!modelo.validador(txtPrimerValor.Text, txtSegundoValor.Text))
                {
                    MessageBox.Show("por favor, ingrese valores numéricos válidos.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                n1 = Convert.ToDecimal(txtPrimerValor.Text);
                n2 = Convert.ToDecimal(txtSegundoValor.Text);

                // Evaluar la operación seleccionada en el ComboBox

                resultado = modelo.operacion(valor1: n1, valor2: n2, operacion: Convert.ToInt32(cmbOperacion.SelectedValue));

                // Mostrar el resultado en mensaje
                MessageBox.Show("El resultado de la suma es: " + resultado.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            Funcionalidades2 modelo = new Funcionalidades2();
            modelo.metodo2();
        }
    }
}
