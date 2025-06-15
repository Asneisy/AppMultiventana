namespace MiltiventanaApp
{
    partial class PaintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintForm));
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFondo = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelCanvas
            // 
            this.panelCanvas.Location = new System.Drawing.Point(-1, 59);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(961, 564);
            this.panelCanvas.TabIndex = 0;
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            this.panelCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCnavas_MouseMove);
            this.panelCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseUp);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::MiltiventanaApp.Properties.Resources.signout_logout_out_log_icon_255920__1_;
            this.btnSalir.Location = new System.Drawing.Point(901, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 45);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Plum;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::MiltiventanaApp.Properties.Resources.icons8_limpiar_32;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(239, 8);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 45);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "        Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnFondo
            // 
            this.btnFondo.BackColor = System.Drawing.Color.Plum;
            this.btnFondo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFondo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFondo.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFondo.Image = global::MiltiventanaApp.Properties.Resources.icons8_color_de_relleno_32;
            this.btnFondo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFondo.Location = new System.Drawing.Point(126, 8);
            this.btnFondo.Name = "btnFondo";
            this.btnFondo.Size = new System.Drawing.Size(107, 45);
            this.btnFondo.TabIndex = 2;
            this.btnFondo.Text = "        Cambiar           Fondo";
            this.btnFondo.UseVisualStyleBackColor = false;
            this.btnFondo.Click += new System.EventHandler(this.btnFondo_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Plum;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColor.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Image = global::MiltiventanaApp.Properties.Resources.icons8_color_swatch_32;
            this.btnColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColor.Location = new System.Drawing.Point(13, 8);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(107, 45);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "    Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 622);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnFondo);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.panelCanvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.PaintForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFondo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}