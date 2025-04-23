using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA.Clases.Funcionalidades
{
    public class Funcionalidades
    {
        public decimal operacion(decimal valor1, decimal valor2, int operacion)
        {
            decimal resultado = 0;

            switch (operacion)
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
                        return 0;
                    }
                    resultado = valor1 / valor2;
                    break;
                case 5:
                    // Potencia
                    resultado = (decimal)Math.Pow((double)valor1, (double)valor2);
                    break;
                default:
                    MessageBox.Show("Operación no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
            }

            return resultado;
        }

        //Validadores
        public bool validador(string valor1, string valor2)
        {
            bool resultado;

            if (decimal.TryParse(valor1, out _) && decimal.TryParse(valor2, out _))
            {
                resultado = true;
            }
            else
            {
                resultado =  false;
            }

            return resultado;
        }
    }
}
