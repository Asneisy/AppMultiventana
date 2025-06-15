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
    public partial class PaintForm : Form
    {
        public PaintForm()
        {
            InitializeComponent();
        }

        Color currentColor = Color.Black; // Color actual para el dibujo
        bool drawing = false;            // Indica si se está dibujando
        Point lastPoint;                // Última posición del ratón cuando se dibuja
        Bitmap canvasBitmap;           // Bitmap que representa el lienzo donde se dibuja
        Graphics graphics;            // Gráficos para dibujar en el bitmap

        private void PaintForm_Load(object sender, EventArgs e)
        {
            canvasBitmap = new Bitmap(panelCanvas.Width, panelCanvas.Height);
            graphics = Graphics.FromImage(canvasBitmap);
            panelCanvas.BackgroundImage = canvasBitmap;
            panelCanvas.BackgroundImageLayout = ImageLayout.None;
        } // Inicializa el bitmap y los gráficos al cargar el formulario

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            lastPoint = e.Location;
        } // Comienza el dibujo cuando se presiona el botón del ratón

        private void panelCnavas_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                graphics.DrawLine(new Pen(currentColor, 2), lastPoint, e.Location);
                panelCanvas.Invalidate(); // Redibuja el panel
                lastPoint = e.Location;
            } // Dibuja una línea desde la última posición del ratón hasta la nueva posición mientras se mueve el ratón y se está dibujando
        } //

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        } // paramos el dibujo cuando se suelta el botón del ratón

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                currentColor = colorDialog1.Color;
        } // Cambia el color actual de dibujo

        private void btnFondo_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panelCanvas.BackColor = colorDialog1.Color;
            } // Cambia el color de fondo del panel
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            graphics.Clear(panelCanvas.BackColor); // Limpia el bitmap con el color de fondo actual
            panelCanvas.Invalidate(); // Actualiza el panel para que se vea limpio
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el PaintForm
        }
    }
}
