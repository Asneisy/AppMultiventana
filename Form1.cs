using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiltiventanaApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            EditorTexto editor = new EditorTexto();
            editor.Show();
        } // Abre el editor de texto cuando se hace clic en el botón correspondiente

        private void btnPaint_Click(object sender, EventArgs e)
        {
            PaintForm paint = new PaintForm();
            paint.Show();
        } // Abre la aplicación de Paint cuando se hace clic en el botón correspondiente

        private void btnCalc_Click(object sender, EventArgs e)
        {
            CalculadoraForm calc = new CalculadoraForm();
            calc.Show();
        } // Abre la calculadora cuando se hace clic en el botón correspondiente

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Cierra la aplicación cuando se hace clic en el botón "Salir"
    }
}
