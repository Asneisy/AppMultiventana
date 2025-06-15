using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiltiventanaApp
{
    public partial class CalculadoraForm : Form
    {
        public CalculadoraForm()
        {
            InitializeComponent();
        }

        double valor1 = 0, valor2 = 0;
        string operacion = "";

        bool operacionEnCurso = false;

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; // Obtiene el botón presionado
            if (operacionEnCurso)
            {
                txtPantalladeresultado.Text = ""; // Limpia el textbox si se ha seleccionado una operación
                operacionEnCurso = false;         // Resetea el estado de operación en curso
            }
            txtPantalladeresultado.Text += btn.Text; // Agrega el número presionado al textbox
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; // Obtiene el botón presionado
            operacion = btn.Text;        // Guarda la operación seleccionada
            valor1 = double.Parse(txtPantalladeresultado.Text); // Convierte el texto del textbox a un número
            operacionEnCurso = true; // Indica que se ha seleccionado una operación
        }

        private void btnPedirresultado_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(txtPantalladeresultado.Text); // Convierte el texto del textbox a un número
            double resultado = 0; 

            switch (operacion)
            {
                case "+": resultado = valor1 + valor2; break; // Realiza la operación correspondiente según el botón presionado
                case "-": resultado = valor1 - valor2; break;
                case "x": resultado = valor1 * valor2; break;
                case "/":
                    if (valor2 !=0) // Verifica que no se divida por cero
                        resultado = valor1 / valor2;
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                    case "%": resultado = (valor1 * valor2) / 100; break; // Calcula el porcentaje si se selecciona la operación de porcentaje
            }
            txtPantalladeresultado.Text = resultado.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalladeresultado.Text = ""; 
            valor1 = 0; 
            valor2 = 0; 
            operacion = ""; 
            operacionEnCurso = false; // Resetea todos los valores y el estado de operación

            txtPantalladeresultado.Focus(); // Para que el foco vuelva al textbox
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPantalladeresultado.Text)) // verifica que el txbox no este vacio
            {
                if (operacionEnCurso) // Si ya se ha seleccionado una operación, no se puede calcular el porcentaje
                {
                    MessageBox.Show("Por favor, complete la operación antes de calcular el porcentaje.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                valor1 = double.Parse(txtPantalladeresultado.Text); // Convierte el texto del textbox a un número
                operacionEnCurso = true; // Indica que se ha seleccionado una operación de porcentaje
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número antes de calcular el porcentaje.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            {
                valor2 = double.Parse(txtPantalladeresultado.Text); //
                double porcentaje = 0; 

                switch (operacion) // Determina qué operación se ha seleccionado para calcular el porcentaje
                {
                    case "+":
                    case "-":
                        porcentaje = (valor1 * valor2) / 100;
                        break; // Para suma y resta, el porcentaje se calcula sobre el primer valor
                    case "x":
                    case "/":
                        porcentaje = valor2 / 100;
                        break; // Para multiplicación y división, el porcentaje se calcula sobre el segundo valor
                }

                txtPantalladeresultado.Text = porcentaje.ToString(); 
                operacionEnCurso = false;
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            if (txtPantalladeresultado.Text.Length > 0) // Verifica que el textbox no esté vacío
            {
                txtPantalladeresultado.Text = txtPantalladeresultado.Text.Substring(0, txtPantalladeresultado.Text.Length - 1);
            }// Elimina el último carácter del texto en el textbox
        }
    }
}
