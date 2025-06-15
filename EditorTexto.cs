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
    public partial class EditorTexto : Form
    {
        public EditorTexto()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog // Configuración del diálogo de apertura de archivos
            {
                Filter = "Archivos de Texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*",
                Title = "Abrir Archivo"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) // Si el usuario selecciona un archivo y hace clic en "Aceptar"
            {
                try
                {
                    txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
                    MessageBox.Show("Archivo abierto con éxito.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se seleccionó ningún archivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } // Método para abrir un archivo de texto y cargar su contenido en el editor

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEditor.Text))
            {
                MessageBox.Show("El editor está vacío. Escribe algo antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } // Verifica si el editor tiene contenido antes de intentar guardar

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo de Texto (*.txt)|*.txt",
                Title = "Guardar Archivo"
            }; // Configuración del diálogo de guardado de archivos

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
                    MessageBox.Show("Archivo guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // Si el usuario selecciona un nombre de archivo y hace clic en "Aceptar", se guarda el contenido del editor
        } // Método para guardar el contenido del editor en un archivo de texto

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEditor.Text))
            {
                MessageBox.Show("El editor ya está vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } // Verifica si el editor tiene contenido antes de intentar limpiar

            DialogResult result = MessageBox.Show("¿Deseas limpiar el contenido del editor?", "Confirmar limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                txtEditor.Clear();
            } // Si el usuario confirma, se limpia el contenido del editor
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Método para cerrar el editor de texto

        private void lblContador_Click(object sender, EventArgs e)
        {

        }

        private void txtEditor_TextChanged_1(object sender, EventArgs e)
        {
            int caracteres = txtEditor.Text.Length; // Cuenta el número de caracteres en el editor
            int palabras = string.IsNullOrWhiteSpace(txtEditor.Text) // Si el texto está vacío, el número de palabras es 0
                ? 0 
                : txtEditor.Text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length; // Divide el texto en palabras usando espacios y saltos de línea como delimitadores

            lblContador.Text = $"Palabras: {palabras} | Caracteres: {caracteres}";

        } // Actualiza el contador de palabras y caracteres cada vez que el texto cambia en el editor

        private void cambiarFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog(); // Crea una instancia del diálogo de selección de fuente

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Font = fontDialog.Font;
            } // Si el usuario selecciona una fuente y hace clic en "Aceptar", se aplica la fuente seleccionada al editor de texto
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo de Texto (*.txt)|*.txt",
                Title = "Guardar como..."
            }; 

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, txtEditor.Text); // Guarda el contenido del editor en el archivo seleccionado
                    MessageBox.Show("Archivo guardado correctamente.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information); // Muestra un mensaje de éxito al usuario
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cambiarAModoOscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((modoOscuroToolStripMenuItem.Checked))
            {

                this.BackColor = Color.FromArgb(30, 30, 30);
                txtEditor.BackColor = Color.FromArgb(45, 45, 45);
                txtEditor.ForeColor = Color.White;
                menuStrip1.BackColor = Color.FromArgb(50, 50, 50);
                menuStrip1.ForeColor = Color.White;
                statusStrip1.BackColor = Color.FromArgb(50, 50, 50);
                statusStrip1.ForeColor = Color.DarkMagenta;
            } // Cambia el color de fondo y texto del editor y otros controles a un esquema oscuro
            else
            {
                this.BackColor = SystemColors.Control;
                txtEditor.BackColor = SystemColors.Window;
                txtEditor.ForeColor = SystemColors.ControlText;
                menuStrip1.BackColor = SystemColors.Menu;
                menuStrip1.ForeColor = SystemColors.ControlText;
                statusStrip1.BackColor = SystemColors.Control;
                statusStrip1.ForeColor = SystemColors.ControlText;
            } // Cambia el color de fondo y texto del editor y otros controles a un esquema claro
        }
    }
}
