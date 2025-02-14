namespace MiPrimerPrograma
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPractica = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.tbPrueba = new System.Windows.Forms.TextBox();
            this.tbPrueba2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPractica
            // 
            this.btnPractica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPractica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPractica.Image = ((System.Drawing.Image)(resources.GetObject("btnPractica.Image")));
            this.btnPractica.Location = new System.Drawing.Point(304, 183);
            this.btnPractica.Name = "btnPractica";
            this.btnPractica.Size = new System.Drawing.Size(171, 30);
            this.btnPractica.TabIndex = 0;
            this.btnPractica.Text = "Practica";
            this.btnPractica.UseVisualStyleBackColor = false;
            this.btnPractica.Click += new System.EventHandler(this.btnPractica_Click);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEtiqueta.Font = new System.Drawing.Font("Noto Serif Georgian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEtiqueta.Location = new System.Drawing.Point(304, 42);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(171, 29);
            this.lblEtiqueta.TabIndex = 1;
            this.lblEtiqueta.Text = "Hola como estas?";
            this.lblEtiqueta.MouseLeave += new System.EventHandler(this.lblEtiqueta_MouseLeave);
            this.lblEtiqueta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // tbPrueba
            // 
            this.tbPrueba.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPrueba.Location = new System.Drawing.Point(304, 96);
            this.tbPrueba.MaxLength = 50;
            this.tbPrueba.Name = "tbPrueba";
            this.tbPrueba.Size = new System.Drawing.Size(171, 20);
            this.tbPrueba.TabIndex = 2;
            this.tbPrueba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrueba_KeyPress);
            // 
            // tbPrueba2
            // 
            this.tbPrueba2.Location = new System.Drawing.Point(304, 123);
            this.tbPrueba2.Multiline = true;
            this.tbPrueba2.Name = "tbPrueba2";
            this.tbPrueba2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPrueba2.Size = new System.Drawing.Size(171, 20);
            this.tbPrueba2.TabIndex = 3;
            this.tbPrueba2.Leave += new System.EventHandler(this.tbPrueba2_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPrueba2);
            this.Controls.Add(this.tbPrueba);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btnPractica);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primera App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPractica;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.TextBox tbPrueba;
        private System.Windows.Forms.TextBox tbPrueba2;
    }
}

