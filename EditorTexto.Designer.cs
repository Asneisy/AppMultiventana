namespace MiltiventanaApp
{
    partial class EditorTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorTexto));
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoOscuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblContador = new System.Windows.Forms.ToolStripStatusLabel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEditor
            // 
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Location = new System.Drawing.Point(0, 53);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(900, 453);
            this.txtEditor.TabIndex = 0;
            this.txtEditor.TextChanged += new System.EventHandler(this.txtEditor_TextChanged_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 29);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(900, 29);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.limpiarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.guardarToolStripMenuItem.Image = global::MiltiventanaApp.Properties.Resources.icons8_guardar_16;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Image = global::MiltiventanaApp.Properties.Resources.icons8_guardar_como_16;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.limpiarToolStripMenuItem.Image = global::MiltiventanaApp.Properties.Resources.icons8_limpiar_16;
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.limpiarToolStripMenuItem.Text = "Limpiar";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.salirToolStripMenuItem.Image = global::MiltiventanaApp.Properties.Resources.icons8_close_window_16;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarFuenteToolStripMenuItem});
            this.formatoToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // cambiarFuenteToolStripMenuItem
            // 
            this.cambiarFuenteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cambiarFuenteToolStripMenuItem.Image = global::MiltiventanaApp.Properties.Resources.icons8_fuente_16;
            this.cambiarFuenteToolStripMenuItem.Name = "cambiarFuenteToolStripMenuItem";
            this.cambiarFuenteToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.cambiarFuenteToolStripMenuItem.Text = "Cambiar Fuente";
            this.cambiarFuenteToolStripMenuItem.Click += new System.EventHandler(this.cambiarFuenteToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoOscuroToolStripMenuItem});
            this.verToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(47, 25);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // modoOscuroToolStripMenuItem
            // 
            this.modoOscuroToolStripMenuItem.CheckOnClick = true;
            this.modoOscuroToolStripMenuItem.Image = global::MiltiventanaApp.Properties.Resources.icons8_moon_symbol_16;
            this.modoOscuroToolStripMenuItem.Name = "modoOscuroToolStripMenuItem";
            this.modoOscuroToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.modoOscuroToolStripMenuItem.Text = "Modo oscuro";
            this.modoOscuroToolStripMenuItem.Click += new System.EventHandler(this.cambiarAModoOscuroToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblContador});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(900, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblContador
            // 
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(151, 20);
            this.lblContador.Text = "toolStripStatusLabel1";
            this.lblContador.Click += new System.EventHandler(this.lblContador_Click);
            // 
            // EditorTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditorTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditorTexto";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblContador;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem cambiarFuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoOscuroToolStripMenuItem;
    }
}