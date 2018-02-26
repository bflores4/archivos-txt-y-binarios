namespace WindowsFormsApp1
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
            this.lblRepeticoines = new System.Windows.Forms.Label();
            this.btnSerie1 = new System.Windows.Forms.Button();
            this.txtNoRepetticiones = new System.Windows.Forms.TextBox();
            this.btnSerie2 = new System.Windows.Forms.Button();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRepeticoines
            // 
            this.lblRepeticoines.AutoSize = true;
            this.lblRepeticoines.Location = new System.Drawing.Point(-2, 9);
            this.lblRepeticoines.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepeticoines.Name = "lblRepeticoines";
            this.lblRepeticoines.Size = new System.Drawing.Size(186, 20);
            this.lblRepeticoines.TabIndex = 0;
            this.lblRepeticoines.Text = "¿Cuántas repeticiones?";
            // 
            // btnSerie1
            // 
            this.btnSerie1.Location = new System.Drawing.Point(13, 48);
            this.btnSerie1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSerie1.Name = "btnSerie1";
            this.btnSerie1.Size = new System.Drawing.Size(112, 35);
            this.btnSerie1.TabIndex = 1;
            this.btnSerie1.Text = "Serie 1";
            this.btnSerie1.UseVisualStyleBackColor = true;
            this.btnSerie1.Click += new System.EventHandler(this.btnSerie1_Click);
            // 
            // txtNoRepetticiones
            // 
            this.txtNoRepetticiones.Location = new System.Drawing.Point(192, 6);
            this.txtNoRepetticiones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoRepetticiones.Name = "txtNoRepetticiones";
            this.txtNoRepetticiones.Size = new System.Drawing.Size(86, 26);
            this.txtNoRepetticiones.TabIndex = 2;
            this.txtNoRepetticiones.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSerie2
            // 
            this.btnSerie2.Location = new System.Drawing.Point(153, 48);
            this.btnSerie2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSerie2.Name = "btnSerie2";
            this.btnSerie2.Size = new System.Drawing.Size(112, 35);
            this.btnSerie2.TabIndex = 3;
            this.btnSerie2.Text = "Serie 2";
            this.btnSerie2.UseVisualStyleBackColor = true;
            this.btnSerie2.Click += new System.EventHandler(this.btnSerie2_Click);
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(13, 105);
            this.txtResultados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(112, 26);
            this.txtResultados.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 280);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.btnSerie2);
            this.Controls.Add(this.txtNoRepetticiones);
            this.Controls.Add(this.btnSerie1);
            this.Controls.Add(this.lblRepeticoines);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepeticoines;
        private System.Windows.Forms.Button btnSerie1;
        private System.Windows.Forms.TextBox txtNoRepetticiones;
        private System.Windows.Forms.Button btnSerie2;
        private System.Windows.Forms.TextBox txtResultados;
    }
}

