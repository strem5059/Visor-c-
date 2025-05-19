namespace WindowsFormsApp3
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
            this.btEscuchar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpuerto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btEscuchar
            // 
            this.btEscuchar.ForeColor = System.Drawing.Color.Green;
            this.btEscuchar.Location = new System.Drawing.Point(53, 83);
            this.btEscuchar.Name = "btEscuchar";
            this.btEscuchar.Size = new System.Drawing.Size(75, 23);
            this.btEscuchar.TabIndex = 0;
            this.btEscuchar.Text = "ESCUCHAR";
            this.btEscuchar.UseVisualStyleBackColor = true;
            this.btEscuchar.Click += new System.EventHandler(this.btEscuchar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puerto";
            // 
            // txtpuerto
            // 
            this.txtpuerto.Location = new System.Drawing.Point(71, 47);
            this.txtpuerto.Name = "txtpuerto";
            this.txtpuerto.Size = new System.Drawing.Size(100, 20);
            this.txtpuerto.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(203, 172);
            this.Controls.Add(this.txtpuerto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEscuchar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEscuchar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpuerto;
    }
}

