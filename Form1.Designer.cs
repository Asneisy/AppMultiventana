namespace MiltiventanaApp
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblOpciones = new System.Windows.Forms.Label();
            this.btnEditor = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOpciones
            // 
            this.lblOpciones.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOpciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOpciones.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblOpciones.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOpciones.Location = new System.Drawing.Point(12, 9);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(609, 36);
            this.lblOpciones.TabIndex = 0;
            this.lblOpciones.Text = "Elige una opcion";
            this.lblOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditor
            // 
            this.btnEditor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditor.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditor.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnEditor.Location = new System.Drawing.Point(168, 78);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(303, 76);
            this.btnEditor.TabIndex = 2;
            this.btnEditor.Text = "Editor de texto";
            this.btnEditor.UseVisualStyleBackColor = false;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaint.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaint.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnPaint.Location = new System.Drawing.Point(168, 191);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(303, 76);
            this.btnPaint.TabIndex = 3;
            this.btnPaint.Text = "Paint Personalizado";
            this.btnPaint.UseVisualStyleBackColor = false;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnCalc.Location = new System.Drawing.Point(168, 304);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(303, 76);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculadora";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(4, 379);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(43, 40);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(633, 425);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.btnEditor);
            this.Controls.Add(this.lblOpciones);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnSalir;
    }
}

